<%@ Control Language="vb" CodeFile="RecoveryData.ascx.vb" Inherits="Modules.HoGD.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Khôi phục dữ liệu hộ gia đình của kỳ trước</h3>
                </div>
                <div class="col-md-3">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2">Chọn Tỉnh/TP</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clr"></div>
                        <div class="col-md-2">Chọn Quận/huyện</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clr"></div>
                        <div class="col-md-2">Chọn Phường/xã</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="PhuongXa" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clr"></div>
                        <div class="col-md-2">Chọn Thôn/tổ</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row strong" style="color:darkred">
                        <p>Lưu ý:  Cần chọn đúng địa bàn để khôi phục dữ liệu</p>
                    </div>
                    <asp:Literal runat="server" ID="litInfo" />
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdRestore" runat="server" Text="Khôi phục địa bàn đã chọn" CssClass="cmsbut cmsbtsubmit" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdRestore" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
    </Triggers>
</asp:UpdatePanel>
