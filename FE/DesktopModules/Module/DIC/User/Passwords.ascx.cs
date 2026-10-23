#region Usings

using System;
using System.Threading;
using System.Web.Security;
using System.Web.UI;

using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Entities.Users.Membership;
using DotNetNuke.Instrumentation;
using DotNetNuke.Security;
using DotNetNuke.Security.Membership;
using DotNetNuke.Services.Localization;
using DotNetNuke.Services.Log.EventLog;
using DotNetNuke.Services.Mail;
using DotNetNuke.UI.Skins.Controls;
using DotNetNuke.Web.UI.WebControls;

#endregion

namespace DotNetNuke.Modules.Admin.Users
{

    public partial class Passwords : UserModuleBase
    {
        private static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(Passwords));
        protected bool UseCaptcha
        {
            get
            {
                return Convert.ToBoolean(GetSetting(PortalId, "Security_CaptchaChangePassword"));
            }
        }
        #region Delegates

        public delegate void PasswordUpdatedEventHandler(object sender, PasswordUpdatedEventArgs e);

        #endregion

        #region Public Properties

        public UserMembership Membership
        {
            get
            {
                UserMembership _Membership = null;
                if (User != null)
                {
                    _Membership = User.Membership;
                }
                return _Membership;
            }
        }

        #endregion

        #region Events

        public event PasswordUpdatedEventHandler PasswordUpdated;
        public event PasswordUpdatedEventHandler PasswordQuestionAnswerUpdated;

        #endregion

        #region Event Methods

        public void OnPasswordUpdated(PasswordUpdatedEventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            if (PasswordUpdated != null)
            {
                PasswordUpdated(this, e);
            }
        }

        public void OnPasswordQuestionAnswerUpdated(PasswordUpdatedEventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            if (PasswordQuestionAnswerUpdated != null)
            {
                PasswordQuestionAnswerUpdated(this, e);
            }
        }

        #endregion

        #region Public Methods

        public override void DataBind()
        {
            lblLastChanged.Text = User.Membership.LastPasswordChangeDate.ToLongDateString();

            //Set Password Expiry Label
            if (User.Membership.UpdatePassword)
            {
                lblExpires.Text = Localization.GetString("ForcedExpiry", LocalResourceFile);
            }
            else
            {
                lblExpires.Text = PasswordConfig.PasswordExpiry > 0 ? User.Membership.LastPasswordChangeDate.AddDays(PasswordConfig.PasswordExpiry).ToLongDateString() : Localization.GetString("NoExpiry", LocalResourceFile);
            }

            if (((!MembershipProviderConfig.PasswordRetrievalEnabled) && IsAdmin && (!IsUser)))
            {
                pnlChange.Visible = true;
                cmdUpdate.Visible = true;
                oldPasswordRow.Visible = false;
            }
            else
            {
                pnlChange.Visible = true;
                cmdUpdate.Visible = true;

                //Set up Change Password
                if (IsAdmin && !IsUser)
                {
                    oldPasswordRow.Visible = false;
                }
                else
                {
                    if (Request.IsAuthenticated)
                    {
                        pnlChange.Visible = true;
                        cmdUserReset.Visible = false;
                        cmdUpdate.Visible = true;
                    }
                    else
                    {
                        pnlChange.Visible = false;
                        cmdUserReset.Visible = true;
                        cmdUpdate.Visible = false;
                    }
                }
            }

            if (!MembershipProviderConfig.PasswordResetEnabled)
            {
                pnlReset.Visible = false;
                cmdReset.Visible = false;
            }
            else
            {
                pnlReset.Visible = true;
                cmdReset.Visible = true;

                //Set up Reset Password
                if (IsAdmin && !IsUser)
                {
                    if (MembershipProviderConfig.RequiresQuestionAndAnswer)
                    {
                        pnlReset.Visible = false;
                        cmdReset.Visible = false;
                    }
                    else
                    {
                        lblResetHelp.Text = Localization.GetString("AdminResetHelp", LocalResourceFile);
                    }
                    questionRow.Visible = false;
                    answerRow.Visible = false;
                }
                else
                {
                    if (MembershipProviderConfig.RequiresQuestionAndAnswer && IsUser)
                    {
                        lblResetHelp.Text = Localization.GetString("UserResetHelp", LocalResourceFile);
                        lblQuestion.Text = User.Membership.PasswordQuestion;
                        questionRow.Visible = true;
                        answerRow.Visible = true;
                    }
                    else
                    {
                        pnlReset.Visible = false;
                        cmdReset.Visible = false;
                    }
                }
            }

            //Set up Edit Question and Answer area
            if (MembershipProviderConfig.RequiresQuestionAndAnswer && IsUser)
            {
                pnlQA.Visible = true;
                cmdUpdateQA.Visible = true;
            }
            else
            {
                pnlQA.Visible = false;
                cmdUpdateQA.Visible = false;
            }
        }

        #endregion

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmdReset.Click += cmdReset_Click;
            cmdUserReset.Click += cmdUserReset_Click;
            cmdUpdate.Click += cmdUpdate_Click;
            cmdUpdateQA.Click += cmdUpdateQA_Click;

            if (MembershipProviderConfig.RequiresQuestionAndAnswer && User.UserID != UserController.Instance.GetCurrentUserInfo().UserID)
            {
                pnlChange.Visible = false;
                cmdUpdate.Visible = false;
            }

            if (UseCaptcha)
            {
                captchaRow.Visible = true;
                ctlCaptcha.ErrorMessage = Localization.GetString("InvalidCaptcha", LocalResourceFile);
                ctlCaptcha.Text = Localization.GetString("CaptchaText", LocalResourceFile);
            }
            //if (this.UserInfo.Membership.UpdatePassword == true)
            //{
                litChange.Text = "<div class='cmsUpdate'>Mật khẩu của bạn đã hết hạn hoặc không đảm bảo an toàn khi sử dụng, vui lòng đổi lại mật khẩu trước khi tiếp tục.</div>";
            //}

        }

        protected override void OnPreRender(EventArgs e)
        {


            base.OnPreRender(e);

            //if (Host.EnableStrengthMeter)
            //{
            passwordContainer.CssClass = "password-strength-container";
            txtNewPassword.CssClass = "password-strength";

            var options = new DnnPaswordStrengthOptions();
            var optionsAsJsonString = Json.Serialize(options);
            var script = string.Format("dnn.initializePasswordStrength('.{0}', {1});{2}", "password-strength", optionsAsJsonString, Environment.NewLine);

            if (ScriptManager.GetCurrent(Page) != null)
            {
                // respect MS AJAX
                ScriptManager.RegisterStartupScript(Page, GetType(), "PasswordStrength", script, true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "PasswordStrength", script, true);
            }
            //}

            var confirmPasswordOptions = new DnnConfirmPasswordOptions()
            {
                FirstElementSelector = "#" + passwordContainer.ClientID + " input[type=password]",
                SecondElementSelector = ".password-confirm",
                ContainerSelector = ".dnnPassword",
                UnmatchedCssClass = "unmatched",
                MatchedCssClass = "matched"
            };

            var confirmOptionsAsJsonString = Json.Serialize(confirmPasswordOptions);
            var confirmScript = string.Format("dnn.initializePasswordComparer({0});{1}", confirmOptionsAsJsonString, Environment.NewLine);

            if (ScriptManager.GetCurrent(Page) != null)
            {
                // respect MS AJAX
                ScriptManager.RegisterStartupScript(Page, GetType(), "ConfirmPassword", confirmScript, true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "ConfirmPassword", confirmScript, true);
            }
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            string answer = "";
            if (MembershipProviderConfig.RequiresQuestionAndAnswer && !IsAdmin)
            {
                if (String.IsNullOrEmpty(txtAnswer.Text))
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                    return;
                }
                answer = txtAnswer.Text;
            }
            try
            {
                //create resettoken
                UserController.ResetPasswordToken(User, Entities.Host.Host.AdminMembershipResetLinkValidity);

                bool canSend = Mail.SendMail(User, MessageType.PasswordReminder, PortalSettings) == string.Empty;
                var message = String.Empty;
                var moduleMessageType = ModuleMessage.ModuleMessageType.GreenSuccess;
                if (canSend)
                {
                    message = Localization.GetString("PasswordSent", LocalResourceFile);
                    LogSuccess();
                }
                else
                {
                    message = Localization.GetString("OptionUnavailable", LocalResourceFile);
                    moduleMessageType = ModuleMessage.ModuleMessageType.RedError;
                    LogFailure(message);
                }


                UI.Skins.Skin.AddModuleMessage(this, message, moduleMessageType);
            }
            catch (ArgumentException exc)
            {
                Logger.Error(exc);
                OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
            }
            catch (Exception exc)
            {
                Logger.Error(exc);
                OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
            }
        }

        private void cmdUserReset_Click(object sender, EventArgs e)
        {
            try
            {
                //send fresh resettoken copy
                bool canSend = UserController.ResetPasswordToken(User, true);

                var message = String.Empty;
                var moduleMessageType = ModuleMessage.ModuleMessageType.GreenSuccess;
                if (canSend)
                {
                    message = Localization.GetString("PasswordSent", LocalResourceFile);
                    LogSuccess();
                }
                else
                {
                    message = Localization.GetString("OptionUnavailable", LocalResourceFile);
                    moduleMessageType = ModuleMessage.ModuleMessageType.RedError;
                    LogFailure(message);
                }


                UI.Skins.Skin.AddModuleMessage(this, message, moduleMessageType);
            }
            catch (ArgumentException exc)
            {
                Logger.Error(exc);
                OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
            }
            catch (Exception exc)
            {
                Logger.Error(exc);
                OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
            }
        }

        private void LogSuccess()
        {
            LogResult(string.Empty);
        }

        private void LogFailure(string reason)
        {
            LogResult(reason);
        }

        private void LogResult(string message)
        {
            var portalSecurity = new PortalSecurity();

            var log = new LogInfo
            {
                LogPortalID = PortalSettings.PortalId,
                LogPortalName = PortalSettings.PortalName,
                LogUserID = UserId,
                LogUserName = portalSecurity.InputFilter(User.Username, PortalSecurity.FilterFlag.NoScripting | PortalSecurity.FilterFlag.NoAngleBrackets | PortalSecurity.FilterFlag.NoMarkup)
            };

            if (string.IsNullOrEmpty(message))
            {
                log.LogTypeKey = "PASSWORD_SENT_SUCCESS";
            }
            else
            {
                log.LogTypeKey = "PASSWORD_SENT_FAILURE";
                log.LogProperties.Add(new LogDetailInfo("Cause", message));
            }

            LogController.Instance.AddLog(log);
        }

        private void cmdUpdate_Click(Object sender, EventArgs e)
        {
            if ((UseCaptcha && ctlCaptcha.IsValid) || !UseCaptcha)
            {
                if (IsUserOrAdmin == false) { return; }
                //1. Check New Password and Confirm are the same
                if (txtNewPassword.Text != txtNewConfirm.Text)
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordMismatch));
                    return;
                }

                //2. Check New Password is Valid
                if (!UserController.ValidatePassword(txtNewPassword.Text))
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordInvalid));
                    return;
                }

                //3. Check old Password is Provided
                if (!IsAdmin && String.IsNullOrEmpty(txtOldPassword.Text))
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordMissing));
                    return;
                }

                //4. Check New Password is ddifferent
                if (!IsAdmin && txtNewPassword.Text == txtOldPassword.Text)
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordNotDifferent));
                    return;
                }
                //5. Check New Password is not same as username or banned
                var settings = new MembershipPasswordSettings(User.PortalID);

                if (settings.EnableBannedList)
                {
                    var m = new MembershipPasswordController();
                    if (m.FoundBannedPassword(txtNewPassword.Text) || User.Username == txtNewPassword.Text)
                    {
                        OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.BannedPasswordUsed));
                        return;
                    }
                }
                if (!IsAdmin && txtNewPassword.Text == txtOldPassword.Text)
                {
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordNotDifferent));
                    return;
                }
                if (!IsAdmin)
                {
                    try
                    {
                        OnPasswordUpdated(UserController.ChangePassword(User, txtOldPassword.Text, txtNewPassword.Text)
                                              ? new PasswordUpdatedEventArgs(PasswordUpdateStatus.Success)
                                              : new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));

                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey(), "removewaiting(); notify('success','Đã thay đổi mật khẩu thành công.', 'Thông báo', false);", true);
                    }
                    catch (MembershipPasswordException exc)
                    {
                        Logger.Error(exc);
                        OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                    }
                    catch (ThreadAbortException)
                    {
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                    }
                    catch (Exception exc)
                    {
                        Logger.Error(exc);
                        OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                    }
                }
                else
                {
                    try
                    {
                        OnPasswordUpdated(UserController.ResetAndChangePassword(User, txtNewPassword.Text)
                                              ? new PasswordUpdatedEventArgs(PasswordUpdateStatus.Success)
                                              : new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));

                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey(), "removewaiting(); notify('success','Đã thay đổi mật khẩu thành công.', 'Thông báo', false);", true);
                    }
                    catch (MembershipPasswordException exc)
                    {
                        Logger.Error(exc);
                        OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);

                    }
                    catch (ThreadAbortException)
                    {
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                    }
                    catch (Exception exc)
                    {
                        Logger.Error(exc);
                        OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
                        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), EPORTAL.flReg.GenKey() , "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                    }
                }
            }
        }

        private void cmdUpdateQA_Click(object sender, EventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            if (String.IsNullOrEmpty(txtQAPassword.Text))
            {
                OnPasswordQuestionAnswerUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordInvalid));
                return;
            }
            if (String.IsNullOrEmpty(txtEditQuestion.Text))
            {
                OnPasswordQuestionAnswerUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordQuestion));
                return;
            }
            if (String.IsNullOrEmpty(txtEditAnswer.Text))
            {
                OnPasswordQuestionAnswerUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                return;
            }

            //Try and set password Q and A
            UserInfo objUser = UserController.GetUserById(PortalId, UserId);
            OnPasswordQuestionAnswerUpdated(UserController.ChangePasswordQuestionAndAnswer(objUser, txtQAPassword.Text, txtEditQuestion.Text, txtEditAnswer.Text)
                                                ? new PasswordUpdatedEventArgs(PasswordUpdateStatus.Success)
                                                : new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
        }

        #endregion

        #region Nested type: PasswordUpdatedEventArgs

        public class PasswordUpdatedEventArgs
        {
            public PasswordUpdatedEventArgs(PasswordUpdateStatus status)
            {
                UpdateStatus = status;
            }

            public PasswordUpdateStatus UpdateStatus { get; set; }
        }

        #endregion
    }
}