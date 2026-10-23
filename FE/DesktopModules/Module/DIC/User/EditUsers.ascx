<%@ Control Language="C#" AutoEventWireup="false" Inherits="DotNetNuke.Modules.Admin.Users.EditUsers" CodeFile="EditUsers.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Membership" Src="~/DesktopModules/Admin/Security/Membership.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Passwords" Src="~/DesktopModules/Module/DIC/User/Passwords.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Profile" Src="~/DesktopModules/Admin/Security/Profile.ascx" %>
<%@ Register TagPrefix="dnn" TagName="MemberServices" Src="~/DesktopModules/Admin/Security/MemberServices.ascx" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<%@ Register TagPrefix="dnn" TagName="UserSubscriptions" Src="~/DesktopModules/CoreMessaging/Subscriptions.ascx" %>


<%@ Import Namespace="DotNetNuke.UI.Utilities" %>
<script type="text/javascript">
    (function ($, Sys) {
        function setUpDnnEditUser() {
            $('#dnnEditUser').dnnTabs().dnnPanels();
            $('#<%= cmdDelete.ClientID %>').dnnConfirm({
                text: '<%= ClientAPI.GetSafeJSString(LocalizeString("UnregisterUser")) %>',
                yesText: '<%= Localization.GetSafeJSString("Yes.Text", Localization.SharedResourceFile) %>',
                noText: '<%= Localization.GetSafeJSString("No.Text", Localization.SharedResourceFile) %>',
                title: '<%= Localization.GetSafeJSString("Confirm.Text", Localization.SharedResourceFile) %>',
                isButton: false
            });
            var serviceFramework = $.ServicesFramework(<%=ModuleId %>);

            var closeText = '<%= ClientAPI.GetSafeJSString(LocalizeString("Close")) %>';
            var errorTitle = '<%= ClientAPI.GetSafeJSString(LocalizeString("ErrorDialogTitle")) %>';
            var erroMessage = '<%= ClientAPI.GetSafeJSString(LocalizeString("ErrorDialogMessage")) %>';
            var successMessage = '<%= ClientAPI.GetSafeJSString(LocalizeString("SuccessMessage")) %>';

            function displayMessage(message, cssclass) {
                var messageNode = $("<div/>").addClass('dnnFormMessage ' + cssclass).text(message);
                $('#accountSettingsFieldSet').prepend(messageNode);
                messageNode.fadeOut(3000, 'easeInExpo', function () { messageNode.remove(); });
            };
            
            function toggleVanityUrl(show) {
                var $vanityUrlLabel =$('#<%= VanityUrl.ClientID %>');
                var $vanityUrlPanel = $('#<%= VanityUrlPanel.ClientID %>');
                
                if (show) {
                    $vanityUrlPanel.show();
                    $vanityUrlLabel.hide();
                } else {
                    $vanityUrlPanel.hide();
                    $vanityUrlLabel.show();
                }
            }

            toggleVanityUrl(<%=ShowVanityUrl.ToString().ToLowerInvariant() %>);

            $('#updateProfileUrl').click(function(e) {
                //validate url
                var $vanityUrl = $('#<%= VanityUrlTextBox.ClientID %>');
                var $vanityUrlLabel =$('#<%= VanityUrl.ClientID %>');
                var httpAlias = $('#<%= VanityUrlAlias.ClientID %>').html();
                var vanityUrl = $vanityUrl.val();
                
                //Call Service Framework
                $.ajax({
                    type: 'POST',
                    url: serviceFramework.getServiceRoot('InternalServices') + 'ProfileService/UpdateVanityUrl',
                    data: { url: vanityUrl },
                    beforeSend: serviceFramework.setModuleHeaders
                }).done(function (result) {
                    if (result.Result == "warning") {
                        $.dnnAlert({
                            okText: closeText,
                            title: result.Title,
                            text: result.Message
                        });
                        $vanityUrl.val(result.SuggestedUrl);
                    } else {
                        displayMessage(successMessage, "dnnFormSuccess");
                        $vanityUrlLabel.html(httpAlias + vanityUrl);
                        toggleVanityUrl(false);
                    }
                }).fail(function (xhr, status, error) {
                    $.dnnAlert({
                        okText: closeText,
                        title: errorTitle,
                        text: error
                    });
                });
            });
            
            var dnn = dnn || {};
            dnn.subscriptionsSettings = <%=UserSubscriptions.GetSettingsAsJson()%>;
            dnn.subscriptionsController = new Subscription(ko, dnn.subscriptionsSettings,'dnnUserSubscriptions');
        }

        $(document).ready(function () {
            setUpDnnEditUser();
            var pageNo = <%=PageNo %>;
            if(pageNo > 0) {
                $('#dnnEditUser > ul > li:nth-child(' + pageNo + ')').find('a').click();
            }

            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
                setUpDnnEditUser();
            });
        });
    } (jQuery, window.Sys));
</script>


<dnn:DnnJsInclude ID="DnnJsInclude1" runat="server" FilePath="~/Resources/Shared/scripts/knockout.js" />
<div class="ContentPane">
    <div class="dnnForm dnnEditUser dnnClear" id="dnnEditUser" runat="server" clientidmode="Static">
        <ul class="dnnAdminTabNav dnnClear" id="adminTabNav" runat="server" visible="false">
            <li><a href="#dnnUserDetails"><%=LocalizeString("cmdUser")%></a></li>
            <li><a href="#<%=dnnProfileDetails.ClientID%>"><%=LocalizeString("cmdProfile")%></a></li>
            <li id="subscriptionsTab" runat="server"><a href="#dnnUserSubscriptions"><%=LocalizeString("cmdCommunications")%></a></li>
            <li id="servicesTab" runat="server"><a href="#<%=dnnServicesDetails.ClientID%>"><%=LocalizeString("cmdServices")%></a></li>
        </ul>
        <div id="dnnUserDetails" class="dnnUserDetails dnnClear">
            <div class="udContent dnnClear">
                <fieldset id="accountSettingsFieldSet" runat="server" visible="false">
                    <dnn:DnnFormEditor ID="userForm" runat="Server" FormMode="Short">
                        <Items>
                            <dnn:DnnFormLiteralItem ID="userNameReadOnly" runat="server" DataField="Username" />
                            <dnn:DnnFormTextBoxItem ID="displayName" runat="server" DataField="DisplayName" Required="true" />
                            <dnn:DnnFormTextBoxItem ID="email" runat="server" DataField="Email" Required="true" />
                        </Items>
                    </dnn:DnnFormEditor>
                    <asp:Panel class="dnnFormItem" ID="VanityUrlRow" runat="server" Visible="False" ViewStateMode="Disabled">
                        <dnn:Label ID="VanityUrlLabel" runat="server" />
                        <asp:Label runat="server" ID="VanityUrl" />
                        <div class="dnnFormGroup" id="VanityUrlPanel" runat="Server">
                            <asp:Label runat="server" ID="VanityUrlHeader" CssClass="NormalBold" resourcekey="VanityUrlHeader" />
                            <div>
                                <asp:Label runat="server" ID="VanityUrlAlias" />
                                <asp:TextBox CssClass="dnnUserVanityUrl" runat="server" ID="VanityUrlTextBox" />
                                <a id="updateProfileUrl" href="#" class="dnnSecondaryAction"><%=LocalizeString("cmdUpdate")%></a>
                            </div>
                        </div>
                    </asp:Panel>
                </fieldset>
                <%--<h2 id="H1" class="dnnFormSectionHead"><a href=""><%=LocalizeString("PasswordSettings")%></a></h2>--%>
                <fieldset>
                    <div class="dnnPasswordDetails dnnClear" style="width: 100%;">
                        <dnn:Passwords ID="ctlPassword" runat="server"></dnn:Passwords>
                    </div>
                </fieldset>
                <div id="div2" runat="server" visible="false">
                    <h2 id="H2" class="dnnFormSectionHead"><a href=""><%=LocalizeString("AccountInfo")%></a></h2>
                    <fieldset>
                        <div class="dnnMembership">
                            <dnn:Membership ID="ctlMembership" runat="Server" />
                        </div>
                    </fieldset>
                </div>
            </div>
            <div id="div3" runat="server" visible="false">
                <ul id="actionsRow" runat="server" class="dnnActions dnnClear">
                    <li>
                        <asp:LinkButton ID="cmdUpdate" runat="server" CssClass="dnnPrimaryAction" resourcekey="cmdUpdate" /></li>
                    <li>
                        <asp:LinkButton ID="cmdDelete" runat="server" CssClass="dnnSecondaryAction" resourcekey="cmdDelete" /></li>
                </ul>
            </div>
        </div>
        <div id="div4" runat="server" visible="false">
            <asp:Panel ID="dnnProfileDetails" runat="server" class="dnnProfileDetails dnnClear">
                <dnn:Profile ID="ctlProfile" runat="server"></dnn:Profile>
            </asp:Panel>
            <div id="dnnUserSubscriptions" runat="server" visible="false" class="dnnUserSubscriptions">
                <dnn:UserSubscriptions ID="UserSubscriptions" runat="server" LocalResourceFile="~/DesktopModules/CoreMessaging/App_LocalResources/View.ascx.resx"></dnn:UserSubscriptions>
            </div>
            <div id="dnnServicesDetails" runat="server" visible="false" class="dnnServicesDetails dnnClear">
                <dnn:MemberServices ID="ctlServices" runat="server"></dnn:MemberServices>
            </div>
        </div>
        <div class="clr"></div>
    </div>
</div>
