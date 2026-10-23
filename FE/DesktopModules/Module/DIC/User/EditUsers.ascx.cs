#region Usings

using System;
using System.Web;

using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Profile;
using DotNetNuke.Entities.Urls;
using DotNetNuke.Entities.Users;
using DotNetNuke.Instrumentation;
using DotNetNuke.Modules.Admin.Security;
using DotNetNuke.Security;
using DotNetNuke.Security.Membership;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Services.Mail;
using DotNetNuke.UI.Skins.Controls;

#endregion

namespace DotNetNuke.Modules.Admin.Users
{
    
    public partial class EditUsers : UserModuleBase
    {
        private static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(EditUsers));

        #region Protected Members

        protected bool DisplayServices
        {
            get
            {
                object setting = GetSetting(PortalId, "Profile_ManageServices");
                return Convert.ToBoolean(setting) && !(IsEdit || User.IsSuperUser);
            }
        }

        protected string RedirectURL
        {
            get
            {
                string _RedirectURL = "";

                object setting = GetSetting(PortalId, "Redirect_AfterRegistration");

                if (Convert.ToInt32(setting) == Null.NullInteger)
                {
                    if (Request.QueryString["returnurl"] != null)
                    {
                        //return to the url passed to register
                        _RedirectURL = HttpUtility.UrlDecode(Request.QueryString["returnurl"]);
                        //redirect url should never contain a protocol ( if it does, it is likely a cross-site request forgery attempt )
                        if (_RedirectURL.Contains("://"))
                        {
                            _RedirectURL = "";
                        }
                        if (_RedirectURL.Contains("?returnurl"))
                        {
                            string baseURL = _RedirectURL.Substring(0, _RedirectURL.IndexOf("?returnurl"));
                            string returnURL = _RedirectURL.Substring(_RedirectURL.IndexOf("?returnurl") + 11);

                            _RedirectURL = string.Concat(baseURL, "?returnurl", HttpUtility.UrlEncode(returnURL));
                        }
                    }
                    if (String.IsNullOrEmpty(_RedirectURL))
                    {
                        //redirect to current page 
                        _RedirectURL = Globals.NavigateURL();
                    }
                }
                else //redirect to after registration page
                {
                    _RedirectURL = Globals.NavigateURL(Convert.ToInt32(setting));
                }
                return _RedirectURL;
            }
        }

        protected string ReturnUrl
        {
            get
            {
                return Globals.NavigateURL(TabId, "", !String.IsNullOrEmpty(UserFilter) ? UserFilter : "");
            }
        }

        protected string UserFilter
        {
            get
            {
                string filterString = !string.IsNullOrEmpty(Request["filter"]) ? "filter=" + Request["filter"] : "";
                string filterProperty = !string.IsNullOrEmpty(Request["filterproperty"]) ? "filterproperty=" + Request["filterproperty"] : "";
                string page = !string.IsNullOrEmpty(Request["currentpage"]) ? "currentpage=" + Request["currentpage"] : "";

                if (!string.IsNullOrEmpty(filterString))
                {
                    filterString += "&";
                }
                if (!string.IsNullOrEmpty(filterProperty))
                {
                    filterString += filterProperty + "&";
                }
                if (!string.IsNullOrEmpty(page))
                {
                    filterString += page;
                }
                return filterString;
            }
        }

        #endregion

        #region Public Properties

        public int PageNo
        {
            get
            {
                int _PageNo = 0;
                if (ViewState["PageNo"] != null && !IsPostBack)
                {
                    _PageNo = Convert.ToInt32(ViewState["PageNo"]);
                }
                return _PageNo;
            }
            set
            {
                ViewState["PageNo"] = value;
            }
        }

        public bool ShowVanityUrl { get; private set; }

        #endregion

        #region Private Methods

        private void BindData()
        {
            if (User != null)
            {
                //If trying to add a SuperUser - check that user is a SuperUser
                if (VerifyUserPermissions() == false)
                {
                    return;
                }

                if (!Page.IsPostBack)
                {
                    if ((Request.QueryString["pageno"] != null))
                    {
                        PageNo = int.Parse(Request.QueryString["pageno"]);
                    }
                    else
                    {
                        PageNo = 0;
                    }
                }
                userForm.DataSource = User;

                if (!Page.IsPostBack)
                {
                    userForm.DataBind();
                }

                ctlPassword.User = User;
                ctlPassword.DataBind();

                //if ((!DisplayServices))
                //{
                //    servicesTab.Visible = false;
                //}
                //else
                //{
                //    ctlServices.User = User;
                //    ctlServices.DataBind();
                //}


                BindUser();
                ctlProfile.User = User;
                ctlProfile.DataBind();

                subscriptionsTab.Visible = false;
                servicesTab.Visible = false;

                dnnServicesDetails.Visible = servicesTab.Visible;

                var urlSettings = new DotNetNuke.Entities.Urls.FriendlyUrlSettings(PortalSettings.PortalId);
                var showVanityUrl = (Config.GetFriendlyUrlProvider() == "advanced") && !User.IsSuperUser;
                if (showVanityUrl)
                {
                    //VanityUrlRow.Visible = true;
                    if (String.IsNullOrEmpty(User.VanityUrl))
                    {
                        //Clean Display Name
                        bool modified;
                        var options = UrlRewriterUtils.GetOptionsFromSettings(urlSettings);
                        var cleanUrl = FriendlyUrlController.CleanNameForUrl(User.DisplayName, options, out modified);
                        var uniqueUrl = FriendlyUrlController.ValidateUrl(cleanUrl, -1, PortalSettings, out modified).ToLowerInvariant();

                        VanityUrlAlias.Text = String.Format("{0}/{1}/", PortalSettings.PortalAlias.HTTPAlias, urlSettings.VanityUrlPrefix);
                        VanityUrlTextBox.Text = uniqueUrl;
                        ShowVanityUrl = true;
                    }
                    else
                    {
                        VanityUrl.Text = String.Format("{0}/{1}/{2}", PortalSettings.PortalAlias.HTTPAlias, urlSettings.VanityUrlPrefix, User.VanityUrl);
                        ShowVanityUrl = false;
                    }
                }
            }
            else
            {
                AddModuleMessage("NoUser", ModuleMessage.ModuleMessageType.YellowWarning, true);
                DisableForm();
            }
        }

        private bool VerifyUserPermissions()
        {
            if (IsHostMenu && !UserInfo.IsSuperUser)
            {
                AddModuleMessage("NoUser", ModuleMessage.ModuleMessageType.YellowWarning, true);
                DisableForm();
                return false;
            }

            //Check if User is a member of the Current Portal (or a member of the MasterPortal if PortalGroups enabled)
            if (User.PortalID != Null.NullInteger && User.PortalID != PortalId)
            {
                AddModuleMessage("InvalidUser", ModuleMessage.ModuleMessageType.YellowWarning, true);
                DisableForm();
                return false;
            }

            //Check if User is a SuperUser and that the current User is a SuperUser
            if (User.IsSuperUser && !UserInfo.IsSuperUser)
            {
                AddModuleMessage("NoUser", ModuleMessage.ModuleMessageType.YellowWarning, true);
                DisableForm();
                return false;
            }
            if (IsEdit)
            {
                //Check if user has admin rights
                if (!IsAdmin || (User.IsInRole(PortalSettings.AdministratorRoleName) && !PortalSecurity.IsInRole(PortalSettings.AdministratorRoleName)))
                {
                    AddModuleMessage("NotAuthorized", ModuleMessage.ModuleMessageType.YellowWarning, true);
                    DisableForm();
                    return false;
                }
            }
            else
            {
                if (!IsUser)
                {
                    if (Request.IsAuthenticated)
                    {
                        if (!PortalSecurity.IsInRole(PortalSettings.AdministratorRoleName))
                        {
                            //Display current user's profile
                            Response.Redirect(Globals.NavigateURL(PortalSettings.UserTabId, "", "UserID=" + UserInfo.UserID), true);
                        }
                    }
                    else
                    {
                        if ((User.UserID > Null.NullInteger))
                        {
                            AddModuleMessage("NotAuthorized", ModuleMessage.ModuleMessageType.YellowWarning, true);
                            DisableForm();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void BindMembership()
        {
            ctlMembership.User = User;
            ctlMembership.DataBind();
            AddModuleMessage("UserLockedOut", ModuleMessage.ModuleMessageType.YellowWarning, ctlMembership.UserMembership.LockedOut && (!Page.IsPostBack));
        }

        private void BindUser()
        {
            BindMembership();
        }

        private void DisableForm()
        {
            adminTabNav.Visible = false;
            dnnProfileDetails.Visible = false;
            dnnServicesDetails.Visible = false;
            actionsRow.Visible = false;
            ctlMembership.Visible = false;
        }

        private void UpdateDisplayName()
        {
            //Update DisplayName to conform to Format
            object setting = GetSetting(UserPortalID, "Security_DisplayNameFormat");
            if ((setting != null) && (!string.IsNullOrEmpty(Convert.ToString(setting))))
            {
                User.UpdateDisplayName(Convert.ToString(setting));
            }
        }


        #endregion

        #region Event Handlers

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            cmdDelete.Click += cmdDelete_Click;
            cmdUpdate.Click += cmdUpdate_Click;
            //updateProfileUrl.Click += updateProfileUrl_Click;

            ctlServices.SubscriptionUpdated += SubscriptionUpdated;
            ctlProfile.ProfileUpdateCompleted += ProfileUpdateCompleted;
            ctlPassword.PasswordUpdated += PasswordUpdated;
            ctlPassword.PasswordQuestionAnswerUpdated += PasswordQuestionAnswerUpdated;

            //jQuery.RequestDnnPluginsRegistration();
            //DotNetNuke.Framework.jQuery.RequestUIRegistration();

            DotNetNuke.Framework.jQuery.RequestDnnPluginsRegistration();

            //Set the Membership Control Properties
            ctlMembership.ID = "Membership";
            ctlMembership.ModuleConfiguration = ModuleConfiguration;
            ctlMembership.UserId = UserId;

            //Set the Password Control Properties
            ctlPassword.ID = "Passwords";
            ctlPassword.ModuleConfiguration = ModuleConfiguration;
            ctlPassword.UserId = UserId;

            //Set the Profile Control Properties
            ctlProfile.ID = "Profile";
            ctlProfile.ModuleConfiguration = ModuleConfiguration;
            ctlProfile.UserId = UserId;

            //Set the Services Control Properties
            ctlServices.ID = "MemberServices";
            ctlServices.ModuleConfiguration = ModuleConfiguration;
            ctlServices.UserId = UserId;

            //Define DisplayName filed Enabled Property:
            object setting = GetSetting(UserPortalID, "Security_DisplayNameFormat");
            if ((setting != null) && (!string.IsNullOrEmpty(Convert.ToString(setting))))
            {
                displayName.Enabled = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                //Bind the User information to the controls
                BindData();
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            UserInfo user = User;
            if (!UserController.DeleteUser(ref user, true, false))
            {
                AddModuleMessage("UserDeleteError", ModuleMessage.ModuleMessageType.RedError, true);
            }

            //DNN-26777 
            new PortalSecurity().SignOut();
            Response.Redirect(Globals.NavigateURL(PortalSettings.HomeTabId));
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (userForm.IsValid && (User != null))
            {
                if (User.UserID == PortalSettings.AdministratorId)
                {
                    //Clear the Portal Cache
                    DataCache.ClearPortalCache(UserPortalID, true);
                }
                try
                {
                    //Update DisplayName to conform to Format
                    UpdateDisplayName();

                    UserController.UpdateUser(UserPortalID, User);

                    Response.Redirect(Request.RawUrl);
                }
                catch (Exception exc)
                {
                    Logger.Error(exc);
                    AddModuleMessage("UserUpdatedError", ModuleMessage.ModuleMessageType.RedError, true);
                }
            }

        }

        private void PasswordQuestionAnswerUpdated(object sender, Passwords.PasswordUpdatedEventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            PasswordUpdateStatus status = e.UpdateStatus;
            if (status == PasswordUpdateStatus.Success)
            {
                AddModuleMessage("PasswordQAChanged", ModuleMessage.ModuleMessageType.GreenSuccess, true);
            }
            else
            {
                AddModuleMessage(status.ToString(), ModuleMessage.ModuleMessageType.RedError, true);
            }
        }

        private void PasswordUpdated(object sender, Passwords.PasswordUpdatedEventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            PasswordUpdateStatus status = e.UpdateStatus;

            if (status == PasswordUpdateStatus.Success)
            {
                //Send Notification to User
                try
                {
                    var accessingUser = (UserInfo)HttpContext.Current.Items["UserInfo"];
                    if (accessingUser.UserID != User.UserID)
                    {
                        //The password was changed by someone else 
                        Mail.SendMail(User, MessageType.PasswordReminder, PortalSettings);
                    }
                    else
                    {
                        //The User changed his own password
                        Mail.SendMail(User, MessageType.UserUpdatedOwnPassword, PortalSettings);
                    }
                    AddModuleMessage("PasswordChanged", ModuleMessage.ModuleMessageType.GreenSuccess, true);
                }
                catch (Exception ex)
                {
                    AddModuleMessage("PasswordMailError", ModuleMessage.ModuleMessageType.YellowWarning, true);
                    Exceptions.LogException(ex);
                }
            }
            else
            {
                AddModuleMessage(status.ToString(), ModuleMessage.ModuleMessageType.RedError, true);
            }
        }

        private void ProfileUpdateCompleted(object sender, EventArgs e)
        {
            if (IsUserOrAdmin == false)
            {
                return;
            }
            if (IsUser)
            {
                //Notify the user that his/her profile was updated
                Mail.SendMail(User, MessageType.ProfileUpdated, PortalSettings);

                ProfilePropertyDefinition localeProperty = User.Profile.GetProperty("PreferredLocale");
                if (localeProperty.IsDirty)
                {
                    //store preferredlocale in cookie, if none specified set to portal default.
                    if (User.Profile.PreferredLocale == string.Empty)
                    {
                        Localization.SetLanguage(PortalController.GetPortalDefaultLanguage(User.PortalID));
                    }
                    else
                    {
                        Localization.SetLanguage(User.Profile.PreferredLocale);
                    }
                }
            }

            //Redirect to same page (this will update all controls for any changes to profile
            //and leave us at Page 0 (User Credentials)
            Response.Redirect(Request.RawUrl, true);
        }

        private void SubscriptionUpdated(object sender, MemberServices.SubscriptionUpdatedEventArgs e)
        {
            string message = Null.NullString;
            if (e.Cancel)
            {
                message = string.Format(Localization.GetString("UserUnSubscribed", LocalResourceFile), e.RoleName);
            }
            else
            {
                message = string.Format(Localization.GetString("UserSubscribed", LocalResourceFile), e.RoleName);
            }
            AddLocalizedModuleMessage(message, ModuleMessage.ModuleMessageType.GreenSuccess, true);
        }

        #endregion
    }
}
