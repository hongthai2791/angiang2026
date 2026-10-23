<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DSBTD00.ascx.vb" Inherits="DesktopModules.Modules.DSBTD00" %>

<div id="divEditPhienGiaoDich">
    <div class="col-md-8 col-xs-12">
        <asp:Panel runat="server" ID="Panel1" Style="height: 140px;">
            <div class="tieu-de">
                <asp:Label ID="lblTenPhien" runat="server"></asp:Label>
            </div>
            <div class="ghi-chu">
                <asp:Label ID="lblDiaDiem" runat="server"></asp:Label>
            </div>
        </asp:Panel>
        <div class="col-md-4 none">
            <asp:Button ID="btnBangGiaoDichChung" CssClass="da-button blue large" runat="server" Text=" Bảng giao dịch chung " />
        </div>
        <div class="col-md-4 none">
            <asp:Button ID="btnBangTinViecTimNguoi" CssClass="da-button blue large" runat="server" Text=" Bảng tin việc tìm người " />
        </div>
        <div class="col-md-4 none">
            <asp:Button ID="btnBangTinNguoiTimViec" CssClass="da-button blue large" runat="server" Text=" Bảng tin người tìm việc " />
        </div>
        <div class="clear"></div>
    </div>
    <div class="col-md-4 col-xs-12">
        <div class="vsmobang">
            <div class="col-sm-4 col-xs-3">
                <asp:LinkButton ID="lnkOpenTableContent" runat="server" ToolTip="Mở bảng thông tin chung">
                            <div style="width:100px; height:75px"></div>
                </asp:LinkButton>
            </div>
            <div class="col-sm-8 col-xs-9">
                <div class="col-sm-5 col-xs-4 b">Bắt đầu:</div>
                <div class="col-sm-7 col-xs-8">
                    <asp:Label ID="lblThoiGianBatDau" runat="server"></asp:Label>
                </div>
                <div class="clear"></div>
                <div class="col-sm-5 col-xs-4 b">Kết thúc:</div>
                <div class="col-sm-7 col-xs-8">
                    <asp:Label ID="lblThoiGianKetThuc" runat="server"></asp:Label>
                </div>
                <div class="clear"></div>
                <div class="col-sm-5 col-xs-4 b">Hotline:</div>
                <div class="col-sm-7 col-xs-8">
                    <asp:Label ID="lblHotline" runat="server"></asp:Label>
                </div>
            </div>
            <div class="col-sm-12 col-xs-12">
                <asp:LinkButton ID="btnThamGiaNgay" OnClientClick="return JoinNow();" runat="server" CssClass="btnThamGiaSan">
                        Tham gia vào sàn
                </asp:LinkButton>
            </div>
        </div>

    </div>

    <div class="clear"></div>
</div>
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />

