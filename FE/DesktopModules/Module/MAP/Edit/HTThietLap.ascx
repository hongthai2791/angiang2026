<%@ Control Language="vb" CodeFile="HTThietLap.ascx.vb" Inherits="Modules.HTThietLap.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .CheckBox {
        padding: 0 !important;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Quản trị bố cục trang chủ</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Dân số</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropDanSo" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn dân số ---</asp:ListItem>
                            <asp:ListItem Value="1">Mật độ dân số</asp:ListItem>
                            <asp:ListItem Value="2">Tỷ lệ tăng trưởng dân số</asp:ListItem>
                            <asp:ListItem Value="3">Thành phần dân số</asp:ListItem>
                            <asp:ListItem Value="4">Phân bố dân cư theo vùng</asp:ListItem>
                            <asp:ListItem Value="5">Tỷ lệ sinh và tỷ lệ tử</asp:ListItem>
                            <asp:ListItem Value="6">Di cư</asp:ListItem>
                            <asp:ListItem Value="7">Mức độ đô thị hóa</asp:ListItem>
                            <asp:ListItem Value="8">Thu nhập bình quân hoặc tình trạng kinh tế</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Lực lượng lao động</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropLucLuongLD" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn lực lượng lao động ---</asp:ListItem>
                            <asp:ListItem Value="1">Tỷ lệ tham gia lực lượng lao động</asp:ListItem>
                            <asp:ListItem Value="2">Tỷ lệ thất nghiệp</asp:ListItem>
                            <asp:ListItem Value="3">Phân loại theo ngành nghề</asp:ListItem>
                            <asp:ListItem Value="4">Phân bố giới tính trong lực lượng lao động</asp:ListItem>
                            <asp:ListItem Value="5">Tỷ lệ lao động chính thức và không chính thức</asp:ListItem>
                            <asp:ListItem Value="6">Thu nhập bình quân</asp:ListItem>
                            <asp:ListItem Value="7">Tỷ lệ việc làm theo độ tuổi</asp:ListItem>
                            <asp:ListItem Value="8">Phân bố theo trình độ học vấn</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Có việc làm</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropCoVL" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn có việc làm ---</asp:ListItem>
                            <asp:ListItem Value="1">Tỷ lệ có việc làm</asp:ListItem>
                            <asp:ListItem Value="2">Phân loại theo ngành nghề</asp:ListItem>
                            <asp:ListItem Value="3">Phân bố theo giới tính</asp:ListItem>
                            <asp:ListItem Value="4">Phân bố theo độ tuổi</asp:ListItem>
                            <asp:ListItem Value="5">Loại hình việc làm</asp:ListItem>
                            <asp:ListItem Value="6">Thu nhập từ việc làm</asp:ListItem>
                            <asp:ListItem Value="7">Trình độ học vấn</asp:ListItem>
                            <asp:ListItem Value="8">Tỷ lệ lao động tự do</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Thất nghiệp</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropThatNghiep" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn thất nghiệp ---</asp:ListItem>
                            <asp:ListItem Value="1">Phân bố theo độ tuổi</asp:ListItem>
                            <asp:ListItem Value="2">Phân loại theo giới tính</asp:ListItem>
                            <asp:ListItem Value="3">Phân bố theo khu vực địa lý</asp:ListItem>
                            <asp:ListItem Value="4">Thất nghiệp theo ngành nghề</asp:ListItem>
                            <asp:ListItem Value="5">Thất nghiệp theo trình độ học vấn</asp:ListItem>
                            <asp:ListItem Value="6">Thất nghiệp dài hạn và ngắn hạn</asp:ListItem>
                            <asp:ListItem Value="7">Tỷ lệ thất nghiệp của lao động phi chính thức</asp:ListItem>
                            <asp:ListItem Value="8">Tỷ lệ thất nghiệp của người lao động di cư</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Hoạt động kinh tế</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropHoatDongKT" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn hoạt động kinh tế ---</asp:ListItem>
                            <asp:ListItem Value="1">Tổng sản phẩm quốc nội (GDP)</asp:ListItem>
                            <asp:ListItem Value="2">Tốc độ tăng trưởng kinh tế</asp:ListItem>
                            <asp:ListItem Value="3">Phân bố ngành kinh tế</asp:ListItem>
                            <asp:ListItem Value="4">Mức thu nhập bình quân </asp:ListItem>
                            <asp:ListItem Value="5">Tỷ lệ đầu tư nước ngoài (FDI)</asp:ListItem>
                            <asp:ListItem Value="6">Tỷ lệ xuất nhập khẩu</asp:ListItem>
                            <asp:ListItem Value="7">Tỷ lệ doanh nghiệp theo ngành</asp:ListItem>
                            <asp:ListItem Value="8">Hoạt động tiêu dùng</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Không hoạt động kinh tế</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropKhongHDKT" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn không hoạt động kinh tế ---</asp:ListItem>
                            <asp:ListItem Value="1">Tỷ lệ lao động không tham gia</asp:ListItem>
                            <asp:ListItem Value="2">Tỷ lệ thất nghiệp</asp:ListItem>
                            <asp:ListItem Value="3">Tỷ lệ lao động không chính thức</asp:ListItem>
                            <asp:ListItem Value="4">Khu vực có mức độ nghèo đói cao</asp:ListItem>
                            <asp:ListItem Value="5">Khu vực thiếu cơ hội việc làm</asp:ListItem>
                            <asp:ListItem Value="6">Tỷ lệ học sinh và sinh viên</asp:ListItem>
                            <asp:ListItem Value="7">Khu vực không có doanh nghiệp</asp:ListItem>
                            <asp:ListItem Value="8">Khu vực có tỷ lệ cao của công việc không được trả lương</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Doanh nghiệp</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropDoanhNghiep" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="0">--- Chọn doanh nghiệp ---</asp:ListItem>
                            <asp:ListItem Value="1">Số lượng doanh nghiệp</asp:ListItem>
                            <asp:ListItem Value="2">Phân loại doanh nghiệp theo ngành</asp:ListItem>
                            <asp:ListItem Value="3">Quy mô doanh nghiệp</asp:ListItem>
                            <asp:ListItem Value="4">Doanh nghiệp có vốn đầu tư nước ngoài (FDI)</asp:ListItem>
                            <asp:ListItem Value="5">Doanh nghiệp khởi nghiệp (Startups)</asp:ListItem>
                            <asp:ListItem Value="6">Doanh nghiệp vừa và nhỏ (SMEs)</asp:ListItem>
                            <asp:ListItem Value="7">Tăng trưởng doanh nghiệp</asp:ListItem>
                            <asp:ListItem Value="8">Mức đóng góp vào GDP</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
