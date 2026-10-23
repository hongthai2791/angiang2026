<%@ Control Language="vb" AutoEventWireup="true" CodeFile="LaoDongGiamList.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
            <h3 class="box-title">Danh sách lao động giảm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="box-table">
                    <table style="width: 130%">
                        <tr style="text-align: center; background-color: #2b5e75; color: #fff">
                            <td class="hdTitle" style="width: 30px" rowspan="3">STT</td>
                            <td class="hdTitle" style="width: 130px" rowspan="3">Họ và tên</td>
                            <td class="hdTitle" colspan="5">Thông tin cá nhân</td>
                            <td class="hdTitle" colspan="6">Trình độ chuyên môn kỹ thuật</td>
                            <td class="hdTitle" colspan="4">Loại HĐLĐ/ hợp đồng làm việc</td>
                            <td class="hdTitle" rowspan="3">Ngày, tháng, năm HĐLĐ/ HĐLV có hiệu lực</td>
                            <td class="hdTitle" rowspan="3">Ngày tháng năm chấm dứt HĐLĐ/ HĐLV </td>
                            <td class="hdTitle" rowspan="3">Thuộc đối tượng tham gia BHTN</td>
                            <td class="hdTitle" colspan="5">Lý do giảm</td>
                        </tr>
                        <tr style="text-align: center; background-color: #2b5e75; color: #fff">
                            <td class="hdTitle" colspan="2">Ngày, tháng, năm sinh</td>
                            <td class="hdTitle" rowspan="2">Dân tộc</td>
                            <td class="hdTitle" rowspan="2">Số CMND</td>
                            <td class="hdTitle" rowspan="2">Số sổ BHXH (nếu có)</td>
                            <td class="hdTitle" rowspan="2">CN kỹ thuật không bằng</td>
                            <td class="hdTitle" rowspan="2">Chứng chỉ nghề ngắn hạn dưới 3 tháng</td>
                            <td class="hdTitle" rowspan="2">Sơ cấp từ 3-12 tháng</td>
                            <td class="hdTitle" rowspan="2">Trung cấp</td>
                            <td class="hdTitle" rowspan="2">Cao đẳng</td>
                            <td class="hdTitle" rowspan="2">ĐH trở lên</td>
                            <td class="hdTitle" rowspan="2">Không xác định thời hạn</td>
                            <td class="hdTitle" rowspan="2">Từ đủ 12 tháng đến 36 tháng</td>
                            <td class="hdTitle" rowspan="2">Từ đủ 3 tháng đến dưới 12 tháng</td>
                            <td class="hdTitle" rowspan="2">Dưới 3 tháng</td>
                            <td class="hdTitle" rowspan="2">Nghỉ hưu</td>
                            <td class="hdTitle" rowspan="2">Đơn phương chấm dứt HĐLĐ/ HĐLV</td>
                            <td class="hdTitle" rowspan="2">Thay đổi cơ cấu công nghệ</td>
                            <td class="hdTitle" rowspan="2">Thỏa thuận chấm dứt</td>
                            <td class="hdTitle" rowspan="2">Lý do khác</td>
                        </tr>
                        <tr style="text-align: center; background-color: #2b5e75; color: #fff">
                            <td class="hdTitle" >Nam</td>
                            <td class="hdTitle" >Nữ</td>
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
                            <td>15</td>
                            <td>16</td>
                            <td>17</td>
                            <td>18</td>
                            <td>19</td>
                            <td>20</td>
                            <td>21</td>
                            <td>22</td>
                            <td>23</td>
                            <td>24</td>
                            <td>25</td>
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
