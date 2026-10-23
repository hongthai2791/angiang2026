<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DS_BaoCao.ascx.vb" Inherits="Modules.SVL.DsBaoCao.View" %>
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="reportTitle">Thông tin chung</div>
        <table cellpadding="1" cellspacing="1" style="background-color: #95b9c7; border-top: 5px solid #cc0000; width: 100%">
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
        <p>&nbsp;</p>
        <div class="reportTitle">Kết quả phiên giao dịch</div>
        <table cellpadding="1" cellspacing="1" style="background-color: #95b9c7; border-top: 5px solid #cc0000; width: 100%">
            <tr>
                <td class="td-report1">Ứng viên trúng sơ tuyển</td>
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
    </ContentTemplate>
</asp:UpdatePanel>
