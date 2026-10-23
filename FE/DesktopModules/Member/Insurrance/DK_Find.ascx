<%@ Control Language="VB" EnableViewState="true" AutoEventWireup="false" CodeFile="DK_Find.ascx.vb" Inherits="DesktopModules.Modules.TIMKIEM" %>
<div class="box-timkiem">
    <div class="search-box">
        <div class="col-md-8">
            <asp:TextBox runat="server" class="TextBox txt-center" ID="txtSearch" placeholder="Mã số hồ sơ" onkeypress="return clickButton(event,'')" />
        </div>
        <div class="col-md-4">
            <asp:LinkButton Text="text" ID="cmSearch" CssClass="cmSearch" runat="server">
                <img src="/image/images/view.png?dpi=150&quality=100" alt="Tìm kiếm" />Tra cứu hồ sơ
            </asp:LinkButton>
        </div>
        <div class="clear"></div>
    </div>
    <div class="clear"></div>
    <asp:Panel CssClass="col-md-12" ID="ptraLai" runat="server" Visible="false">
        <div class="col-md-2 txt-center pdt15">
            <asp:Literal ID="tl_qrCode" runat="server"></asp:Literal>
        </div>
        <div class="col-md-7">
            <div class="top-sub-title">Tình trạng xử lý hồ sơ</div>
            <h3 class="tbh3">Hồ sơ của bạn bị trả lại vào lúc
                <asp:Literal ID="tl_ngayTra" runat="server"></asp:Literal></h3>
            <h4 class="pb">Lý do trả lại:</h4>
            <p class="w70">
                <asp:Literal ID="tl_lyDo" runat="server"></asp:Literal>
            </p>
        </div>
        <div class="col-md-3 txt-center">
            <asp:TextBox runat="server" class="TextBox txt-center" ID="tl_DienThoai" placeholder="Điện thoại" onkeypress="return clickButton(event,'')" />
            <asp:HiddenField runat="server" ID="tl_page" Visible="false" />
            <asp:HiddenField runat="server" ID="tl_Mobile" Visible="false" />
            <p class="w70 pdt10">Nhập vào số điện thoại đăng ký để tiếp tục chỉnh sửa.</p>
            <asp:Button ID="tl_buttom" CssClass="bt-home block" runat="server" Text="Chỉnh sửa hồ sơ"></asp:Button>
        </div>
        <div class="clear"></div>
    </asp:Panel>
    <asp:Panel CssClass="col-md-12" ID="ptiepNhan" Visible="false" runat="server">
        <div class="col-md-2 txt-center pdt15">
            <asp:Literal ID="tn_qrCode" runat="server"></asp:Literal>
        </div>
        <div class="col-md-7">
            <div class="top-sub-title">Tình trạng xử lý hồ sơ</div>
            <h3 class="tbh3">Hồ sơ của bạn được tiếp nhận vào lúc
                <asp:Literal ID="tn_ngayNhan" runat="server"></asp:Literal></h3>
            <p class="w70">Hồ sơ của bạn đã được chuyển đến bộ phận xử lý hồ sơ để xử lý.</p>
            <p class="w70">Trân trọng.</p>
        </div>
        <div class="col-md-3 txt-center">
            <a href="/" title="Quay về trang chủ" class="bt-home block">Về trang chủ</a>
        </div>
        <div class="clear"></div>
    </asp:Panel>
    <asp:Panel CssClass="col-md-12" ID="pchoNhan" Visible="false" runat="server">
        <div class="col-md-2 txt-center pdt15">
            <asp:Literal ID="cn_qrCode" runat="server"></asp:Literal>
        </div>
        <div class="col-md-7">
            <div class="top-sub-title">Tình trạng xử lý hồ sơ</div>
            <h3 class="tbh3">Hồ sơ của bạn được gửi vào lúc
                <asp:Literal ID="cn_ngayNop" runat="server"></asp:Literal></h3>
            <p class="w70">Hồ sơ của bạn đang được bộ phận tiếp nhận kiểm tra xử lý hồ sơ.</p>
            <p class="w70">Trân trọng.</p>
        </div>
        <div class="col-md-3 txt-center">
            <a href="/" title="Quay về trang chủ" class="bt-home block">Về trang chủ</a>
        </div>
        <div class="clear"></div>
    </asp:Panel>
    <asp:Panel CssClass="col-md-12" ID="pkhongKQ" Visible="false" runat="server">
        <div class="col-md-2 txt-center pdt15">
            <img src="<%=EPORTAL.bigCode.QRCode("0000", EPORTAL.flReg.UrlAlias & "/huong-dan-su-dung/") %>" alt="Mã hồ sơ">
        </div>
        <div class="col-md-7">
            <div class="top-sub-title">Không có kết quả nào được tìm thấy.</div>
            <p class="w70">Vui lòng kiểm tra lại mã hồ sơ của bạn cần tra cứu.</p>
            <p class="w70">Trân trọng.</p>
        </div>
        <div class="col-md-3 txt-center">
            <a href="/" title="Quay về trang chủ" class="bt-home block">Về trang chủ</a>
        </div>
        <div class="clear"></div>
    </asp:Panel>
    <div class="clear"></div>
</div>
<div class="clear"></div>
<div class="box-app">
    <div class="col-md-12">
        <div class="txt-center">
            <div class="top-sub-title">Tải áp Keng | Mạng cộng đồng tuyển dụng</div>
            <h3 class="tbh3">Hỗ trợ Người lao động, lao động hưởng Bảo hiểm thất nghiệp</h3>
        </div>
    </div>
    <div class="clear"></div>
    <div class="col-md-2 txt-center hidden-xs">
        <img src="/image/icon/app-keng2.jpg?w=100" alt="Tải app">
    </div>
    <div class="col-md-3 col-xs-6">
        <div class="col-xs-12">
            <h4 class="pb">Nhận thông báo</h4>
            <p class="w70">Bạn sẽ nhận được thông báo nhắc lịch hẹn trả kết quả, khai báo việc làm hàng tháng, các thông tin chính sách, phiên giao dịch việc làm, ....</p>
        </div>
    </div>
    <div class="col-md-4 col-xs-6">
        <div class="col-xs-12">
            <h4 class="pb">Tìm kiếm việc làm</h4>
            <p class="w70">Chỉ với chiếc điện thoại thông minh trên tay, bạn sẽ tìm kiếm được tất cả các thông tin tuyển dụng việc làm một cách dễ dàng, nhanh chóng và hiệu quả ở mọi lúc, mọi nơi.</p>
            <p class="w70">Kiểm tra thông tin doanh nghiệp, đánh giá - review doanh nghiệp nhanh chóng.</p>
        </div>
    </div>
    <div class="col-md-3 col-xs-6">
        <div class="col-xs-12">
            <h4 class="pb">Nộp hồ sơ ứng tuyển</h4>
            <p class="w70">Bạn hoàn toàn có thể tạo hồ sơ xin việc một cách đơn giản, nhanh chóng dù bạn ở bất cứ nơi đâu.</p>
            <p class="w70">Chỉ một vài thao tác, bạn đã hoàn thành việc nộp hồ sơ đến nhà tuyển dụng.</p>
        </div>
    </div>
    <div class="clear"></div>
    <div class="row">
        <div class="col-md-6 col-xs-6 txt-center ">
            <a style="width: 320px" class="link-border block" href="/appkeng.html" target="_blank" rel="nofollow">
                <img src="/image/icon/ios.svg" alt="Appstore">
            </a>
        </div>
        <div class="col-md-6 col-xs-6 txt-center">
            <a style="width: 320px" class="link-border block" href="/appkeng.html" target="_blank" rel="nofollow">
                <img src="/image/icon/android.svg" alt="Googleplay">
            </a>
        </div>
        <div class="clear"></div>
    </div>
    <div class="clear"></div>
</div>
