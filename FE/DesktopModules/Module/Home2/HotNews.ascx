<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HotNews.ascx.vb" Inherits="DesktopModules.Modules.HotNews" %>
<div class="bg-white">
    <div class="container pdt20">
        <%--<div class="cate-title">
            <h4><a href="/tin-tuc-va-su-kien" title="Tin tức sự kiện"><i class="fa fa-newspaper-o"></i>&nbsp;Tin tức sự kiện
            </a></h4>
        </div>--%>
        <div class="section-title center-block text-center">
            <h1>TIN TỨC SỰ KIỆN</h1>
            <p>Cập nhật tin tức, sự kiện nóng nhất xung quanh vấn đề việc làm được bạn đọc quan tâm nhất</p>
        </div>
        <div class="post-slide-block hotnews">
            <div class="col-md-12">
                <asp:Literal ID="litSlide" runat="server" />
            </div>
            <%--<div class="col-md-6  slide-box right-box">
                <asp:Literal ID="litNew" runat="server" />
            </div>--%>
            <div class="col-md-12 text-center">
                <div class="mt-4" style="padding: 10px 0 0;"><a href="/tin-tuc-va-su-kien" title="Xem thêm tin tức sự kiện" class="btn btn-primary btn-category"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a> </div>

            </div>
            <div class="clear"></div>
        </div>

    </div>
</div>

