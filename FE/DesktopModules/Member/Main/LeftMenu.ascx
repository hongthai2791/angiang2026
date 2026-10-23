<%@ Control Language="vb" AutoEventWireup="true" CodeFile="LeftMenu.ascx.vb" Inherits="Modules.LeftMenu.View" %>
<style>
    .fix-menu {top:0px !important}
    .sidebar-menu .treeview-menu > li > a{color:#fff}
    .sidebar-menu .treeview-menu > li > a > span{color:#fff}
    .sidebar-menu .treeview-menu > li > a > .fa, .sidebar-menu .treeview-menu > li > a > .glyphicon, .sidebar-menu .treeview-menu > li > a > .ion{color:#fff}
    .sidebar-menu .treeview-menu > li.active{border-left:none}
    .sidebar-menu .treeview-menu > li.active a{color:#ffd800}
@media (max-width: 2048px){

.left-side, .main-sidebar {
    width: 230px;
}
.content-wrapper, .main-footer, .right-side{
    
    margin-left: 230px;
}
}
</style>
<aside class="left-side hidden-print left-none fix-menu">
    <section class="sidebar">
        <asp:Literal ID="litMenu" runat="server" />
        <div class="clear"></div>
    </section>
</aside>
<asp:HiddenField ID="_PortalID" runat="server" />
<asp:HiddenField ID="VaiTroND" runat="server" Visible="false" />
<script type="text/javascript">
    $(document).ready(function () {
        setTimeout(function () { $('.left-none').removeClass('left-none'); }, 500);
        var pathname = window.location.pathname; var check = '/' + '<%= PortalSettings.ActiveTab.TabName %>';
        $(".active").parents('ul .treeview-menu').addClass("menu-open").attr("style", "display: block");
    });
    function toogleModal(modal, status) {
        if (status == true) {
            $('.remodal-overlay').css("display", "block");
            $('.remodal-wrapper').css("display", "none");
            $(modal).css("display", "block");
        } else {
            $('.remodal-overlay').css("display", "none");
            $('.remodal-wrapper').css("display", "none");
        }
    };
</script>
<asp:Panel ID="pnJs" runat="server" Visible="true">
    <script type="text/html">
        $(function () {
            $(".dis-report-1,.dis-report-2,.dis-report-3,.dis-report-4,.war-report-1,.war-report-2,.war-report-3,.war-report-4").each(function (e) {
                var _id = $(this).attr("id"); var _pid = $("#<%=_PortalID.ClientID %>").val();
                $.ajax({
                    type: "POST", url: '/api/admin/pubcms.asmx/Notification', dataType: 'json', async: true,
                    data: JSON.stringify({ id: _id, pid: _pid }), cache: false, contentType: 'application/json; charset=utf-8',
                    success: function (data) { var json = $.parseJSON(data.d); $("." + _id).html(json.data); }
                });
            });
        });
    </script>
</asp:Panel> 