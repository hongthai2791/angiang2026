<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="CheckChange.ascx.vb" Inherits="DesktopModules.Modules.CheckChange" %>
<link href="/portals/_default/skins/vbn/css/checkchange.css" rel="stylesheet" />
<div id="changeview" runat="server" class="changeview">
    <div class="box box-info">
        <div class="checkchange">
            <div class="col-md-3 pdl0 pdr0">
                <div class="bgtt" style="margin-top: 6px; color: red">
                    <a href="#">Lịch sử biên tập tin</a>
                </div>
                <asp:Literal ID="litChange" runat="server" />
            </div>
            <div class="col-md-9 pdr0">
                <div class="col-md-4 pdl0">
                    <asp:Literal ID="liT" runat="server" Text="<div class='title-bt'>Chuyên mục</div>" />
                </div>
                <div class="col-md-6">
                    <asp:DropDownList ID="OldVersion" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-2" style="text-align: center;">
                    <asp:Button ID="cmdCheck" Text="Đối chiếu" CssClass="cmdCheck" runat="server" />
                </div>
                <div class="clear"></div>
                <asp:Literal ID="litContent" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<asp:HiddenField ID="ItemID" runat="server" Visible="false" />
<asp:HiddenField ID="PortalConnect" runat="server" Visible="false" />
<asp:HiddenField ID="VersionID" runat="server" Visible="false" />
<script>
    function fonterror() {
        var html = $(".post-content").html();
        for (i = 0; i < html.length; i++) {
            html = html.replace('ô%3ḅ', 'ộ'); html = html.replace('ê%3ḅ', 'ệ'); html = html.replace('â%3ḅ', 'ậ');
            html = html.replace('Ô%3ḅ', 'Ộ'); html = html.replace('Ê%3ḅ', 'Ệ'); html = html.replace('Â%3ḅ', 'Ậ');
        }
        $(".post-content").html(html);
    };
    $(document).ready(function () { fonterror(); });
</script>

