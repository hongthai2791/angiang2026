<%@ Control Language="vb" AutoEventWireup="true" CodeFile="BC_Mau04.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Mẫu số 04: Báo cáo về thông tin thị trường lao động</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drPhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa" />
                </div>
                <div class="col-md-2 txt-center lb">
                    Kỳ nhập liệu
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" runat="server" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="box-table">
                            <table style="width: 100%">
                                <tr style="text-align: center; background-color: #053281; font-weight: bold; color: #fff">
                                    <td style="width: 50px">STT</td>
                                    <td>Chỉ tiêu</td>
                                    <td style="width: 150px">Đơn vị</td>
                                    <td style="width: 200px">Kỳ trước</td>
                                    <td style="width: 200px">Kỳ báo cáo</td>
                                </tr>
                                <tr style="text-align: center; background-color: #d3981e">
                                    <td>A</td>
                                    <td>B</td>
                                    <td>C</td>
                                    <td>1</td>
                                    <td>2</td>
                                </tr>
                                <tr>
                                    <td colspan="5" style="font-weight: bold">II. THÔNG TIN CẦU LAO ĐỘNG</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">1</td>
                                    <td style="font-weight: bold">Tổng số doanh nghiệp</td>
                                    <td style="text-align: center; font-style: italic">DN</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_TongSoDN" runat="server"></asp:Label>
                                    </td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="TongSoDN" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">2</td>
                                    <td style="font-weight: bold">Tổng số lao động</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_LD_TongSo" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="LD_TongSo" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                <tr>
                                    <td style="text-align: center;">a</td>
                                    <td colspan="4" style="font-weight: bold">Chia theo loại lao động</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Lao động nữ</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_LD_Nu" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="LD_Nu" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Lao động trên 35 tuổi</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_LD_TREN35" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="LD_TREN35" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Lao động tham gia BHXH bắt buộc</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_LD_BHXH" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="LD_BHXH" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">b</td>
                                    <td colspan="4" style="font-weight: bold">Chia theo vị trí việc làm</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Nhà quản lý</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_VT_NhaQuanLy" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="VT_NhaQuanLy" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Chuyên môn kỹ thuật bậc cao</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_VT_CMKT_Cao" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="VT_CMKT_Cao" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Chuyên môn kỹ thuật bậc trung</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_VT_CMKT_Trung" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="VT_CMKT_Trung" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td style="font-style: italic">- Khác</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_VT_CMKT_Khac" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="VT_CMKT_Khac" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td colspan="5" style="font-weight: bold">III. THÔNG TIN NHU CẦU TUYỂN DỤNG LAO ĐỘNG</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">1</td>
                                    <td style="font-weight: bold">Tổng số lượng tuyển</td>
                                    <td style="font-style: italic; text-align: center">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">2</td>
                                    <td style="font-weight: bold" colspan="4">Chia theo loại hình</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">a</td>
                                    <td style="font-style: italic">Doanh nghiệp nhà nước</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_NhaNuoc" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_NhaNuoc" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">b</td>
                                    <td style="font-style: italic">Doanh nghiệp ngoài nhà nước</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_NgoaiNuoc" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_NgoaiNuoc" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">c</td>
                                    <td style="font-style: italic">Doanh nghiệp có vốn đầu tư nước ngoài</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_VonNN" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_VonNN" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">d</td>
                                    <td style="font-style: italic">Cơ quan, đơn vị nhà nước</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_DonViNN" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_DonViNN" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">e</td>
                                    <td style="font-style: italic">Hộ kinh doanh</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_HoKD" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_HoKD" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">g</td>
                                    <td style="font-style: italic">Cá nhân</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C10_LaoDong_CaNhan" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C10_LaoDong_CaNhan" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">3</td>
                                    <td style="font-weight: bold" colspan="4">Chia theo mã nghề cấp 2</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà quản lý của các cơ quan Tập đoàn, Tổng công ty và tương đương (chuyên trách)</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_17" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_17" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn trong lĩnh vực khoa học và kỹ thuật</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_21" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_21" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn về sức khỏe</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_22" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_22" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn về giảng dạy</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_23" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_23" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn về kinh doanh và quản lý</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_24" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_24" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn trong lĩnh vực công nghệ thông tin và truyền thông</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_25" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_25" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhà chuyên môn về luật pháp, văn hóa, xã hội</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_26" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_26" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Kỹ thuật viên khoa học và kỹ thuật</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_31" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_31" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Kỹ thuật viên sức khỏe</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_32" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_32" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên về kinh doanh và quản lý</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_33" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_33" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên luật pháp, văn hóa, xã hội</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_34" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_34" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Kỹ thuật viên thông tin và truyền thông</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_35" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_35" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Giáo viên bậc trung</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_36" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_36" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên tổng hợp và nhân viên làm các công việc bàn giấy</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_41" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_41" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên dịch vụ khách hàng</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_42" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_42" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên ghi chép số liệu và vật liệu</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_43" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_43" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên hỗ trợ văn phòng khác</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_44" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_44" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên dịch vụ cá nhân</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_51" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_51" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên bán hàng</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_52" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_52" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên chăm sóc cá nhân</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_53" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_53" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Nhân viên dịch vụ bảo vệ</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_54" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_54" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động có kỹ năng trong nông nghiệp có sản phẩm chủ yếu để bán</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_61" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_61" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động có kỹ năng trong lâm nghiệp, thủy sản và săn bắn có sản phẩm chủ yếu để bán</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_62" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_62" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động tự cung tự cấp trong nông nghiệp, lâm nghiệp và thủy sản</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_63" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_63" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động xây dựng và lao động có liên quan đến nghề xây dựng (trừ thợ điện)</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_71" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_71" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ luyện kim, cơ khí và thợ có liên quan</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_72" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_72" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ thủ công và thợ liên quan đến in</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_73" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_73" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ điện và thợ điện tử</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_74" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_74" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ chế biến thực phẩm, gia công gỗ, may mặc, đồ thủ công và thợ có liên quan khác</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_75" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_75" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ vận hành máy móc và thiết bị</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_81" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_81" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Thợ lắp ráp</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_82" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_82" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lái xe và thợ vận hành thiết bị chuyển động</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_83" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_83" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Người quét dọn và giúp việc</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_91" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_91" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động giản đơn trong nông nghiệp, lâm nghiệp và thủy sản</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_92" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_92" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động trong ngành khai khoáng, xây dựng, công nghiệp chế biến, chế tạo và giao thông vận tải</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_93" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_93" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Người phụ giúp chuẩn bị thực phẩm</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_94" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_94" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Lao động trên đường phố và lao động có liên quan đến bán hàng</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_95" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_95" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;"></td>
                                    <td>Người thu dọn vật thải và lao động giản đơn khác</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_C11_96" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="C11_96" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td colspan="5" style="font-weight: bold">IV. THÔNG TIN NGƯỜI LAO ĐỘNG NƯỚC NGOÀI LÀM VIỆC TẠI VIỆT NAM</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">1</td>
                                    <td style="font-weight: bold">Tổng số</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="KT_LD_NuocNgoai_Tong" runat="server"></asp:Label></td>
                                    <td style="text-align: center;">
                                        <asp:Label ID="LD_NuocNgoai_Tong" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center; font-weight: bold">2</td>
                                    <td style="font-weight: bold" colspan="4">Chia theo vị trí công việc</td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">a</td>
                                    <td>Nhà quản lý</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;"></td>
                                    <td style="text-align: center;"></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">b</td>
                                    <td>Giám đốc điều hành</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;"></td>
                                    <td style="text-align: center;"></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">c</td>
                                    <td>Chuyên gia</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;"></td>
                                    <td style="text-align: center;"></td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">d</td>
                                    <td>Lao động kỹ thuật</td>
                                    <td style="text-align: center; font-style: italic">Người</td>
                                    <td style="text-align: center;"></td>
                                    <td style="text-align: center;"></td>
                                </tr>

                            </table>
                        </div>
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" OnClientClick="retunwaiting();" CssClass="cmsbut cmdview" />
                <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" OnClientClick="popexp('exports');" CssClass="cmsbut cmdexel " />
                <div class="clear"></div>
            </div>
        </div>
        <script type="text/javascript">
            function exports() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCauLD&typeid=Mau_04&tp=" + tp + "&year=" + year + "&dtype=" + dtype);
                return false;
            };
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
