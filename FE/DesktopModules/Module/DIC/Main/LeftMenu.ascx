<%@ Control Language="vb" AutoEventWireup="true" CodeFile="LeftMenu.ascx.vb" Inherits="Modules.LeftMenu.View" %>
<style>
    .selectpicker-single {
        color: #444 !important
    }

    .thonToMenuLeft .dropdown-menu li > a {
        color: #333 !important;
    }

    .thonToMenuLeft .dropdown-menu .active > a:focus, .dropdown-menu > .active > a:hover {
        color: #fff !important;
    }
</style>
<aside class="left-side hidden-print left-none fix-menu">
    <div class="user-block transition-2 show">
        <div class="user-info-wrapper">
            <div class="user-info">
                <a title="Cập nhật thông tin tài khoản" href="/Admin/User/Account">
                    <div class="image">
                        <img src="/image/images/noavatar.png?h=48&amp;w=48" width="55" height="55" alt="User" onerror="this.onerror=null;this.src = '/Content/Admin/images/no-avatar.jpg';">
                    </div>
                </a>
                <div class="info-container">
                    <a href="/Admin/User/Account">
                        <div class="name"><%=Me.UserInfo.DisplayName %></div>
                    </a>
                    <a href="/Admin/User/Account">
                        <div class="email"><%=Me.UserInfo.Username %>&nbsp;|&nbsp;<%=Me.UserInfo.Email %></div>  
                    </a>
                </div>
            </div>
        </div>
    </div>
    <section class="sidebar scroll">
        <asp:Literal ID="litMenu" runat="server" />
        <div class="clear"></div>
    </section>
</aside>
<asp:HiddenField ID="_PortalID" runat="server" />
<asp:HiddenField ID="VaiTroND" runat="server" Visible="false" />
<asp:HiddenField ID="TinhTP" runat="server" Visible="false" />
<asp:HiddenField ID="QuanHuyen" runat="server" Visible="false" />
<asp:HiddenField ID="PhuongXa" runat="server" Visible="false" />
<script type="text/javascript">
    $(document).ready(function () {
        setTimeout(function () { $('.left-none').removeClass('left-none'); }, 500);
        $(".active").parents('ul .treeview-menu').addClass("menu-open").attr("style", "display: block");
    });
    $(function () {
        function filterMenu(term) {
            var filter, input = term.toUpperCase();
            $(".sidebar-menu a").each(function (i, el) {
                filter = $(el).text().toUpperCase();
                if (filter.indexOf(input) < 0) {
                    $(el).parent().hide();
                }
            });
        }

        $("#txt_search").keyup(function (event) {
            $(".sidebar-menu li").show();
            if ($(this).val() !== "") {
                filterMenu($(this).val());
            }
        });
    });
</script>
<asp:Panel ID="pnJs" runat="server" Visible="true">
    <script>
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
