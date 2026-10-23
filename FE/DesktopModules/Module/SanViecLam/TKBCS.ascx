<%@ Control Language="VB" AutoEventWireup="false" CodeFile="TKBCS.ascx.vb" Inherits="Modules.SVL.View" %>
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />

<div class="row">
    <div class="col-md-12">
        <div class="a4-box">
            <div class="reportTitle" style="margin-top: 20px">Thông tin chung</div>
            <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #79ac00; width: 100%">
                <tr>
                    <td class="td-report1">Sàn việc làm</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSanViecLam" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Số bàn</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoBan" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Thời gian bắt đầu</td>
                    <td class="td-report2">
                        <asp:Label ID="lblThoiGian" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Thời gian kết thúc</td>
                    <td class="td-report2">
                        <asp:Label ID="lblThoiGianKetThuc" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Số ứng viên tham gia</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVien" runat="server" />
                        ứng viên</td>
                </tr>
            </table>
        </div>
        <div class="a4-box">
            <div class="reportTitle">Kết quả phiên giao dịch</div>
            <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #79ac00; width: 100%">
                <tr>
                    <td class="td-report1">Ứng viên trúng tuyển</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienTrungTuyen" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Ứng viên đạt</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienDat" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Ứng viên không đạt</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienKhongDat" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Hẹn phỏng vấn lại</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienHenGapLai" runat="server" />
                        ứng viên</td>
                </tr>
            </table>
        </div>
        <div class="clear"></div>
    </div>
</div>

