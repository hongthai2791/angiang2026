#region Usings

using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Entities.Users.Membership;
using DotNetNuke.EPORTAL;
using DotNetNuke.Instrumentation;
using DotNetNuke.Security;
using DotNetNuke.Security.Membership;
using DotNetNuke.Services.Localization;
using DotNetNuke.Services.Log.EventLog;
using DotNetNuke.Services.Mail;
using DotNetNuke.UI.Skins.Controls;
using DotNetNuke.Web.UI.WebControls;
using System;
using System.IO;
using System.Threading;
using System.Web.Security;
using System.Web.UI;

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
                if (this.UserInfo != null)
                {
                    _Membership = this.UserInfo.Membership;
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

            if (PasswordUpdated != null)
            {
                PasswordUpdated(this, e);
            }
        }

        public void OnPasswordQuestionAnswerUpdated(PasswordUpdatedEventArgs e)
        {

            if (PasswordQuestionAnswerUpdated != null)
            {
                PasswordQuestionAnswerUpdated(this, e);
            }
        }

        #endregion

        #region Public Methods

        public override void DataBind()
        {
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
                        cmdUpdate.Visible = true;
                    }
                    else
                    {
                        pnlChange.Visible = false;
                        cmdUpdate.Visible = false;
                    }
                }
            }
        }

        #endregion

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmdUpdate.Click += cmdUpdate_Click;
            cmdReset.Click += cmdReset_Click;
            emailForgotPast.Text=this.UserInfo.Email;
            if (MembershipProviderConfig.RequiresQuestionAndAnswer && this.UserInfo.UserID != UserController.Instance.GetCurrentUserInfo().UserID)
            {
                pnlChange.Visible = false;
                cmdUpdate.Visible = false;
            }
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
            if (this.UserInfo.Membership.UpdatePassword == true)
            {
                litChange.Text = "<div class='cmsUpdate'>Mật khẩu của bạn đã hết hạn hoặc không đảm bảo an toàn khi sử dụng, vui lòng đổi lại mật khẩu trước khi tiếp tục.</div>";
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
                LogUserID = this.UserInfo.UserID,
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
        private void cmdReset_Click(object sender, EventArgs e) 
        {
            try
            {
              
                    string RestPassWordId = Guid.NewGuid().ToString();
                    DateTime strEndDate = DateTime.Now.AddMinutes(15);
                    string HTTPAlias = flReg.UrlAlias() + "/kich-hoat-tai-khoan/rs/" + RestPassWordId;
                    StreamReader sr = new StreamReader(Server.MapPath("/api/admin/resetpass.html"));
                    sr = File.OpenText(Server.MapPath("/api/admin/resetpass.html"));
                    string subject = string.Format("Lấy lại mật khẩu");
                    string Content = sr.ReadToEnd();

                    Content = Content.Replace("[DisplayName]", this.UserInfo.DisplayName);
                    Content = Content.Replace("[PortalName]", flReg.WebConfig("TenDonVi"));
                    Content = Content.Replace("[HTTPAlias]", HTTPAlias);
                    Content = Content.Replace("[Username]", this.UserInfo.Username);
                    Content = Content.Replace("[Email]", this.UserInfo.Email);
                    Content = Content.Replace("[EndDate]", strEndDate.ToString());

                    flDnn.DNN_AddRestPassWord(RestPassWordId, this.PortalId.ToString(), this.UserInfo.Username, this.UserInfo.Email, strEndDate.ToString());
                    flDnn.DNN_SendMail(this.UserInfo.Email, subject, Content);

                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "page_warning", "removewaiting(); notify('success','Vui lòng kiểm tra email để lấy lại mật khẩu.', 'Thông báo', false);", true);
               
            }
            // End If
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "page_warning", "notify('warning', 'Yêu cầu của bạn hệ thống chưa kịp xử lý, vui lòng thử lại sau.', 'Thông báo', false);", true);
            }
        }

        private void cmdUpdate_Click(Object sender, EventArgs e)
        {

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
            var settings = new MembershipPasswordSettings(this.UserInfo.PortalID);

            if (settings.EnableBannedList)
            {
                var m = new MembershipPasswordController();
                if (m.FoundBannedPassword(txtNewPassword.Text) || this.UserInfo.Username == txtNewPassword.Text)
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
                    OnPasswordUpdated(UserController.ChangePassword(this.UserInfo, txtOldPassword.Text, txtNewPassword.Text)
                                          ? new PasswordUpdatedEventArgs(PasswordUpdateStatus.Success)
                                          : new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));

                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "removewaiting(); notify('success','Đã thay đổi mật khẩu thành công.', 'Thông báo', false);", true);
                }
                catch (MembershipPasswordException exc)
                {
                    Logger.Error(exc);
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                }
                catch (ThreadAbortException)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                }
                catch (Exception exc)
                {
                    Logger.Error(exc);
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                }
            }
            else
            {
                try
                {
                    OnPasswordUpdated(UserController.ResetAndChangePassword(User, txtNewPassword.Text)
                                          ? new PasswordUpdatedEventArgs(PasswordUpdateStatus.Success)
                                          : new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));

                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "removewaiting(); notify('success','Đã thay đổi mật khẩu thành công.', 'Thông báo', false);", true);
                }
                catch (MembershipPasswordException exc)
                {
                    Logger.Error(exc);
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.InvalidPasswordAnswer));
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);

                }
                catch (ThreadAbortException)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                }
                catch (Exception exc)
                {
                    Logger.Error(exc);
                    OnPasswordUpdated(new PasswordUpdatedEventArgs(PasswordUpdateStatus.PasswordResetFailed));
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "noti_error", "notify('error', 'Lỗi đổi mật khẩu.', 'Thông báo', false);", true);
                }
            }
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