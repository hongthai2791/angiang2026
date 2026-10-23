<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Workflow.ascx.vb" Inherits="DesktopModules.DanhMuc.PhongBan.inc_Workflow" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">QUY TRÌNH XUẤT BẢN NỘI DUNG</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <asp:DropDownList ID="ddlPortal" CssClass="selectpicker validate[required]" runat="server" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="col-md-12 b">
                <asp:Label ID="lblPhongBan" runat="server" ForeColor="Maroon" Font-Bold="true" Text=""></asp:Label>
            </div>
            <div class="col-md-12">
                <asp:UpdatePanel ID="udpContent" runat="server">
                    <ContentTemplate>
                        <div class="ctable-respo">
                            <asp:DataGrid ID="drgLuong" runat="server" DataKeyField="ID" AutoGenerateColumns="False" CssClass="table table-bordered" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="Both" Width="100%">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:BoundColumn HeaderText="STT" DataField="OrderNumber" ItemStyle-Width="5%" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="5%" />
                                    <asp:TemplateColumn HeaderText="Mặc định" HeaderStyle-HorizontalAlign="Center" Visible="false">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkLuong" Checked='<%# eval("isDefault") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:BoundColumn HeaderText="Mã" DataField="ID" Visible="false" />
                                    <asp:BoundColumn HeaderText="Tên quy trình" DataField="TenLuong" />
                                    <asp:TemplateColumn ItemStyle-Width="20px" HeaderText="Sửa">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imb_edit" CommandName="imb_edit" ImageUrl="/image/images/F-edit.png" ToolTip="Sửa quy trình"
                                                AlternateText="Edit" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                                        <HeaderStyle Width="100px" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xóa">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imb_delete" CommandName="imb_delete" ImageUrl="/image/7.gif" ToolTip="Xóa quy trình"
                                                AlternateText="Delete" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                                        <HeaderStyle Width="100px" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <div id="dialog-modal" title="Cập nhật thông tin quy trình" style="display: none;">
                <asp:UpdatePanel ID="udpWF" runat="server">
                    <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="height: 40px">
                                <td style="width: 130px; vertical-align: text-top">Quy trình </td>
                                <td>
                                    <asp:TextBox ID="txtTenLuong" CssClass="TextBox validate[required]" runat="server" Width="100%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr style="height: 40px">
                                <td>Là mặc định</td>
                                <td>
                                    <asp:CheckBox ID="chkLuongMacDinh" runat="server" />
                                </td>
                            </tr>
                            <tr style="height: 40px; display: none">
                                <td style="width: 130px; height: 34px">Quy trình gửi từ: </td>
                                <td>
                                    <asp:DropDownList ID="ddlLoaiWF" CssClass="selectpicker" runat="server" Width="100%"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr style="height: 40px">
                                <td style="width: 130px; height: 34px">Trạng thái đích</td>
                                <td>
                                    <asp:DropDownList ID="ddlStatus" CssClass="selectpicker validate[required]" runat="server" Width="100%"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr style="height: 40px">
                                <td style="width: 130px; height: 34px">Sắp xếp</td>
                                <td>
                                    <asp:TextBox ValidationGroup="AddThreadValidate" CssClass="TextBox validate[required,custom[integer]]" ID="txtLuongOrder" runat="server"
                                        Width="60px">1</asp:TextBox>
                                </td>
                            </tr>
                            <tr style="height: 40px">
                                <td style="width: 130px; height: 34px"></td>
                                <td>
                                    <asp:LinkButton OnClientClick="return retunwaiting();" CssClass="QLVP_button" runat="server" ID="lbtLuongNguoiDung" OnClick="lbtLuongNguoiDung_Click">
                                     <img src="/images/save.gif" border="0" />&nbsp;Lưu lại</asp:LinkButton>
                                </td>
                            </tr>

                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdNews" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới quy trình" OnClientClick="return OpenDialog(-1); "></asp:Button>
        <asp:Button ID="cmdCancel" runat="server" Text="Quay lại" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="pbID" runat="server" />
<asp:HiddenField ID="wid" runat="server" />
<script type="text/javascript">
    function OpenDialog(b) {
        if (b == "-1") { $("#<%=wid.ClientID%>").val(""); $("#<%=txtTenLuong.ClientID%>").val(""); }
        else {$("#<%=wid.ClientID%>").val(b)}
        $('#Form').validationEngine('detach');
        $("#dialog-modal").dialog({ width: 700, height: 400, modal: false, position: { my: "", at: "center", of: window } });
        $("#dialog-modal").parent().appendTo($("form:first"));
        return false;
    };
    function CloseDialog() { $("#dialog-modal").dialog("destroy"); $("form:first").remove('#dialog-modal'); };
</script>
<style>
    div.ui-dialog-titlebar > .ui-dialog-titlebar-close {
        top: -20px;
        right: -20px;
    }

    .ui-widget-content {
        padding: 15px;
    }

    .dialog-modal table tr {
        min-height: 34px;
    }
</style>
