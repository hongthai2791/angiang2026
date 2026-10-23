<%@ Control Language="vb" CodeFile="ConfigUser.ascx.vb" Inherits="Modules.UserConfigEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Phân quyền người sử dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-3">
                    <asp:Literal ID="litPhoto" runat="server"></asp:Literal>
                </div>
                <div class="col-md-6">
                    <div class="col-md-4">Tài khoản đăng nhập </div>
                    <div class="col-md-8 b">
                        <asp:Literal ID="ltUserName" runat="server"></asp:Literal>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4">Tên hiển thị </div>
                    <div class="col-md-8 b">
                        <asp:Literal ID="ltDisplayName" runat="server"></asp:Literal>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4">Email đăng ký</div>
                    <div class="col-md-8 b">
                        <asp:Literal ID="ltEmail" runat="server"></asp:Literal>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4">Ngày đăng ký</div>
                    <div class="col-md-8 b">
                        <asp:Literal ID="ltCreate" runat="server"></asp:Literal>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-md-3">
                    <asp:Literal ID="litSub" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="clear" style="border-bottom: 2px solid #017c00; margin-top: 10px; margin-bottom: 30px;"></div>
            <asp:UpdatePanel runat="server" ID="ppod">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-6 col-xs-5">
                            <div class="col-md-12 txt-center">Tỉnh/ thành phố </div>
                            <asp:ListBox ID="TinhTP_All" runat="server" Height="160px" CssClass="scroll list-selectpicker" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="col-md-1 col-xs-2 txt-center">
                            <div class="pdt30">
                                <asp:ImageButton ID="addTinh" ToolTip="Chọn tỉnh" ImageUrl="/image/next.png" runat="server" />
                            </div>
                            <div class="pdt30">
                                <asp:ImageButton ID="removeTinh" ToolTip="Bỏ chọn" ImageUrl="/image/back.png" runat="server" />
                            </div>
                        </div>
                        <div class="col-md-5 col-xs-5">
                            <div class="col-md-12 txt-center">Tỉnh/ thành phố tác nghiệp</div>
                            <asp:HiddenField ID="ID_TinhTP" Visible="false" runat="server" />
                            <asp:ListBox ID="TinhTP_Set" runat="server" CssClass="scroll list-active" Height="160px" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="clr"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6 col-xs-5">
                            <div class="col-md-12 txt-center">Xã/ phường</div>
                            <asp:ListBox ID="XaPhuong_All" runat="server" Height="160px" CssClass="scroll list-selectpicker" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="col-md-1 col-xs-2 txt-center">
                            <div class="pdt30">
                                <asp:ImageButton ID="addXaPhuong" ToolTip="Chọn xã" ImageUrl="/image/next.png" runat="server" />
                            </div>
                            <div class="pdt30">
                                <asp:ImageButton ID="removeXaPhuong" ToolTip="Bỏ chọn" ImageUrl="/image/back.png" runat="server" />
                            </div>
                        </div>
                        <div class="col-md-5 col-xs-5">
                            <div class="col-md-12 txt-center">Xã/ phường tác nghiệp</div>
                            <asp:HiddenField ID="ID_XaPhuong" Visible="false" runat="server" />
                            <asp:ListBox ID="XaPhuong_Set" runat="server" Height="160px" CssClass="scroll list-active" Width="100%" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="clr"></div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="addTinh" />
                    <asp:AsyncPostBackTrigger ControlID="removeTinh" />
                    <asp:AsyncPostBackTrigger ControlID="addXaPhuong" />
                    <asp:AsyncPostBackTrigger ControlID="removeXaPhuong" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="clr"></div>
        </div>
    </div>
    <div class="clr"></div>
    <asp:HiddenField ID="dataVal" runat="server" />
    <asp:Literal ID="litUpdate" runat="server" />
    <div class="fix-btt-toolbar">
        <div>
            <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
            <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" />
        </div>
    </div>
</div>
<script type="text/javascript">
    function checkinput(sub, id) {
        if ($("#subra-" + id).hasClass("adnew")) {
            removeValue("<%=dataVal.ClientID%>", sub + "#" + id);
            $("#subra-" + id).removeClass("adnew")
        }
        else {
            addValue("<%=dataVal.ClientID%>", sub + "#" + id);
            $("#subra-" + id).addClass("adnew")
        }
    };
</script>
