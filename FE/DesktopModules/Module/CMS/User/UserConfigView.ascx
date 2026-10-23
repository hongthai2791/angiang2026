<%@ Control Language="vb" CodeFile="UserConfigView.ascx.vb" Inherits="Modules.TN_UserList.View" AutoEventWireup="false" Explicit="True" %>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm người dùng" />
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>

<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">Quản lý danh sách người dùng</h3>
            &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <asp:DropDownList Visible="false" ID="TinhTP" CssClass="selectpicker" runat="server" />
                <div class="col-md-3 pdl0">
                    <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" DataValueField="Id" DataTextField="TenPhongBan" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-6">
                    <asp:DropDownList ID="PhongBan" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                </div>
                <div class="col-md-3 pdr0">
                    <asp:TextBox CssClass="TextBox" ID="txtSearch" runat="server"></asp:TextBox>
                    <asp:LinkButton ID="btnSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="table-responsive">
                <asp:DataGrid ID="grdData" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                    <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                    <ItemStyle BackColor="#f5f5f5" />
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
                        <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <div style="text-align: center;">
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </div>
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" />
                            <ItemStyle Width="4%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tên tài khoản" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <asp:Literal ID="Username" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle />
                            <HeaderStyle Width="22%" />
                            <ItemStyle Width="22%" CssClass="text_ellipsis" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tên người dùng" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <asp:Literal ID="DisplayName" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Phòng ban" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <asp:Literal ID="PhongBan" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="20%" />
                            <ItemStyle Width="20%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Địa chỉ email" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <asp:Literal ID="Email" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle />
                            <HeaderStyle Width="20%" />
                            <ItemStyle Width="20%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Khóa" HeaderStyle-CssClass="ItemCss">
                            <ItemTemplate>
                                <div style="text-align: center;">
                                    <asp:Literal ID="IsDeleted" runat="server"></asp:Literal>
                                </div>
                            </ItemTemplate>
                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <asp:Literal ID="litPage" runat="server" />
            <div class="clr"></div>
        </div>
    </div>
</div>

<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<script>
    function activeuser(id, d, t) {
        var link, msg;
        link = "/api/admin/uactive.ashx?i=" + id + "&a=" + d + "&p=<%=ddlPortal.SelectedValue%>" + "&ta=<%=Me.PortalSettings.ActiveTab.TabName %>";
        msg = $.ajax({ url: link, async: false }).responseText;
        if (d == "1") {//Lock
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
    }
</script>
