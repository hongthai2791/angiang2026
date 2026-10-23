<%@ Control Language="VB" AutoEventWireup="false" CodeFile="BTD00.ascx.vb" Inherits="DesktopModules.Modules.BTD00" %>
<div class="svl_bantuyendung_box">
    <div class="row">
        <div class="head-bantd">
            <div class="col-md-10">
                <div class="svl_bantuyendung_header">
                    <div class="ban-so">
                        Bàn
                        <asp:Literal ID="txtIdBanPhongVan" runat="server" Text="0"></asp:Literal>
                    </div>
                </div>
                <div class="ten-doanh-nghiep">
                    <asp:Literal ID="txtTenDN" runat="server" Text="Tên doanh nghiệp"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-md-2">
                <div class="text txt-back">
                    <div class="back-box-icon" onclick="window.location.href = '/san-viec-lam'">Quay lại</div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div class="row">
        <div class="svl_bantuyendung_bg_line txt-center">
            <img style="margin-top: -11px" src="/image/svl/svl_bantuyendung_bg_img.png" />
        </div>
    </div>
    <div class="row svl_header_info">
        <div class="col-md-4">
            <div class="ct-btd ">
                <div>Nhu cầu tuyển dụng</div>
                <div style="font-size: 26px; margin-top: 5px">
                    <asp:Literal ID="txtSoViecLam" runat="server" Text="0"></asp:Literal>
                </div>
            </div>
            <div class="svl_header_separator"></div>
        </div>
        <div class="col-md-4">
            <div class="ct-btd ">
                <div>Thời gian còn</div>
                <div style="font-size: 26px; margin-top: 5px">
                    <asp:Literal ID="txtThoiGianCon" runat="server" Text="0"></asp:Literal>
                </div>
            </div>
            <div class="svl_header_separator"></div>
        </div>
        <div class="col-md-4">
            <div class="ct-btd ">
                <div>Số hồ sơ ứng tuyển</div>
                <div style="font-size: 26px; margin-top: 5px">
                    <asp:Literal ID="txtSoUngVien" runat="server" Text="0"></asp:Literal>
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </div>

    
</div>
<asp:HiddenField ID="ItemID" Value="0" runat="server" />
<asp:HiddenField ID="hiddeBusiness_ID" Value="0" runat="server" />
