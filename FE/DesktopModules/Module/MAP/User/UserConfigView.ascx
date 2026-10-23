<%@ Control Language="vb" CodeFile="UserConfigView.ascx.vb" Inherits="Modules.UserConfig.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Quản lý danh sách người dùng (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drSubMod" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" Visible="false" runat="server" />
                </div>
                <div class="col-md-3 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="XaPhuong" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/appintegrity.png" alt="Edit" title="Phân quyền" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Literal ID="IsEdit" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên tài khoản" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Username" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="22%" />
                                <ItemStyle  Width="22%" CssClass="text_ellipsis" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên người dùng" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="DisplayName" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Email" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="20%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày đăng ký" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreatedOnDate" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_unlock.png" alt="lock" title="Khóa tài khoản?" class="bCur bAct" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Literal ID="IsDeleted" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/remove.png" alt="lock" title="Xóa tài khoản?" class="bCur bAct" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Literal ID="IsDeletedUser" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
                <div class="row">
                    <asp:Literal ID="litPage" runat="server" />
                </div>
                <div class="clr"></div>
                <asp:Literal ID="lbMsg" runat="server" />
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm người dùng" CssClass="cmsbut cmsbtnew cbclick" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
<script type="text/javascript">
    function activeuser(id, d, t) {
        var link, msg;
        link = "/api/admin/uactive.ashx?i=" + id + "&a=" + d + "&p=<%=Me.PortalId%>"+ "&ta=<%=Me.PortalSettings.ActiveTab.TabName %>";
        msg = $.ajax({ url: link, async: false }).responseText;
        if (d == "-1") {
            notify('success', 'Đã xóa tài khoản thành công!.', 'Thông báo', false);
            eval($('.btTkiemD').attr('href'));
        }
        else if (d == "1") {//Lock
            $(".imgActive-" + id).attr('src', '/image/lock.png');
            $(t).attr("onclick", "activeuser(" + id + ",0,this)");
            $(t).parent("td").parent("tr").addClass("red");
            notify('success', 'Đã khóa tài khoản thành công!.', 'Thông báo', false);
        }
        else {//Unlock
            $(".imgActive-" + id).attr('src', '/image/unlock.png');
            $(t).attr("onclick", "activeuser(" + id + ",1,this)");
            $(t).parent("td").parent("tr").removeClass("red");
            notify('info', 'Đã mở khóa tài khoản thành công!.', 'Thông báo', false);
        }
    };
</script>
