<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HotNews.ascx.vb" Inherits="DesktopModules.Modules.HotNews" %>
<div class="bg-white">
    <div class="container pdt20">
        <div class="cate-title">
            <h4><a href="/tin-tuc-va-su-kien" title="Tin tức sự kiện"><i class="fa fa-newspaper-o"></i>&nbsp;Tin tức sự kiện
            </a></h4>
        </div>
        <div class="post-slide-block hotnews">
            <div class="col-md-6">
                <asp:Literal ID="litSlide" runat="server" />
            </div>
            <div class="col-md-6  slide-box right-box">
                <asp:Literal ID="litNew" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>

