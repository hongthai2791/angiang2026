<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_DSBaoCao.ascx.vb" Inherits="Modules.SVL.Mar_DSBaoCao.View" %>
<asp:HiddenField ID="DSBaoCao_ItemID" Visible="false" runat="server" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="reportTitle">Thông tin chung</div>
        <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #337ab7; width: 100%">
            <tr>
                <td class="td-report1">Sàn việc làm</td>
                <td class="td-report2">
                    <asp:Label ID="lblSanViecLam" runat="server" /></td>
            </tr>
            <tr>
                <td class="td-report1">Số bàn phỏng vấn</td>
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
                    <asp:Label ID="lblSoUngVien" CssClass="lblSoUngVien" runat="server" />
                    ứng viên</td>
            </tr>
        </table>
        <p>&nbsp;</p>
        <div class="reportTitle" style="border-top:20px solid #ddd;padding-top:20px">Kết quả phiên giao dịch</div>

        <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #337ab7; width: 100%">
            <tr>
                <td class="td-report1">Doanh nghiệp đã giới thiệu</td>
                <td class="td-report2">
                    <asp:Label ID="lbldngioithieu" runat="server" />
                    ứng viên</td>
            </tr> 
            <tr>
                <td class="td-report1">Doanh nghiệp chưa giới thiệu</td>
                <td class="td-report2">
                    <asp:Label ID="lbldnchuagioithieu" runat="server" />
                    ứng viên</td>
            </tr>  
            <tr>
                <td class="td-report1">Ứng viên đã giới thiệu</td>
                <td class="td-report2">
                    <asp:Label ID="lbluvdagioithieu" runat="server" />
                    ứng viên</td>
            </tr> 
            <tr>
                <td class="td-report1">Ứng viên chưa giới thiệu</td>
                <td class="td-report2">
                    <asp:Label ID="lbluvchuagioithieu" runat="server" />
                    ứng viên</td>
            </tr> 
               <tr>
                <td class="td-report1">Ứng viên đạt</td>
                <td class="td-report2">
                    <asp:Label ID="lblSoUngVienDat" runat="server" />
                    ứng viên</td>
            </tr>
            <tr>
                <td class="td-report1">Ứng viên trúng tuyển</td>
                <td class="td-report2">
                    <asp:Label ID="lblSoUngVienTrungTuyen" runat="server" />
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
      <div class="pdt10">  Xem thêm các báo cáo <a target="_blank" href="/work/view/mar-rpt-one/pgd/<%=DSBaoCao_ItemID.Value %>" >Doanh nghiệp chia theo ngành nghề</a> | <a target="_blank" href="/work/view/mar-rpt-two/pgd/<%=DSBaoCao_ItemID.Value %>" >Doanh nghiệp chia theo quy mô lao động</a> |  <a target="_blank" href="/work/view/mar-rpt-three/pgd/<%=DSBaoCao_ItemID.Value %>" >Lao động chia theo nhu cầu việc làm</a> </div>
    </ContentTemplate>
</asp:UpdatePanel>
