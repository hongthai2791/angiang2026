<%@ Control Language="vb" AutoEventWireup="true" CodeFile="TBDauCuoiList.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
            <h3 class="box-title">Thông tin về số lao động đầu kỳ - cuối kỳ</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="box-table">
                    <table>
                        <tr style="text-align: center; background-color: #2b5e75; color: #fff">
                            <td class="hdTitle" rowspan="2" style="width: 80px">Thời điểm báo cáo</td>
                            <td class="hdTitle" colspan="2">Tổng số lao động</td>
                            <td class="hdTitle" colspan="6">Trình độ chuyên môn kỹ thuật</td>
                            <td class="hdTitle" colspan="4">Loại HĐLĐ/ hợp đồng làm việc</td>
                            <td class="hdTitle" rowspan="2">Tổng số người tham gia BHTN</td>
                        </tr>
                        <tr style="text-align: center; background-color: #2b5e75; color: #fff">
                            <td class="hdTitle" style="width: 80px">Tổng số	</td>
                            <td class="hdTitle" style="width: 80px">Trong đó nữ	</td>
                            <td class="hdTitle">Công nhân kỹ thuật không bằng</td>
                            <td class="hdTitle">Chứng chỉ nghề ngắn hạn dưới 3 tháng</td>
                            <td class="hdTitle">Sơ cấp từ 3-12 tháng</td>
                            <td class="hdTitle">Trung cấp</td>
                            <td class="hdTitle">Cao đẳng</td>
                            <td class="hdTitle">ĐH trở lên</td>
                            <td class="hdTitle">Không xác định thời hạn	</td>
                            <td class="hdTitle">Từ đủ 12 tháng đến dưới 36 tháng</td>
                            <td class="hdTitle">Từ đủ 3 tháng đến dưới 12 tháng	</td>
                            <td class="hdTitle">Dưới 3 tháng</td>

                        </tr>
                        <tr style="text-align: center; background-color: #fee9e9">
                            <td>1</td>
                            <td>2</td>
                            <td>3</td>
                            <td>4</td>
                            <td>5</td>
                            <td>6</td>
                            <td>7</td>
                            <td>8</td>
                            <td>9</td>
                            <td>10</td>
                            <td>11</td>
                            <td>12</td>
                            <td>13</td>
                            <td>14</td>
                        </tr>
                        <asp:Literal ID="litRow" runat="server"></asp:Literal>
                    </table>
                </div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>
<div class="row text-center pd10">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
        <asp:Button ID="cmdNew" runat="server" Text="Đẩy lại dữ liệu" OnClientClick="chontepimport(); return false;" CssClass="cmsbut cmsbtnew cbclick" />
        <asp:Button ID="cmdImport" runat="server" CssClass="none" Text="Imports" />
    </div>
</div>
<asp:FileUpload ID="fileImages" accept=".xlsx,.xls" onchange="importdulieu()" AllowMultiple="false" CssClass="none" runat="server" />
<asp:HiddenField runat="server" ID="DoanhNghiepID" Visible="false" />
<asp:HiddenField runat="server" ID="ThongBaoID" Visible="false" />
<asp:HiddenField runat="server" ID="TrangThai" Visible="false" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
<script>function chontepimport() { waiting(); jQuery("#<%= fileImages.ClientID%>").click(); }; function importdulieu() { jQuery("#<%= cmdImport.ClientID%>").click(); };</script>
