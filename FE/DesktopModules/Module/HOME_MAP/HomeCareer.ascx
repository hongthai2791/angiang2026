<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeCareer.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeCareer" %>
<%@ Register Src="~/DesktopModules/Module/Home/HomeBanner.ascx" TagPrefix="uc1" TagName="HomeBanner" %>
<%@ Register Src="~/DesktopModules/Module/Home/HomeJobUser.ascx" TagPrefix="uc1" TagName="HomeJobUser" %>


<div class="career-box shadow bg-white pd10 mgt10">
    <div class="container">
        <div class="col-md-9  pd10" style="position: relative">
            <uc1:HomeJobUser runat="server" ID="HomeJobUser" />
        </div>
        <div class="col-md-3">
            <div class=" shadow pd10" style="position: relative">
                <div class="cate-title">
                    <h4><a style="display: inline-block" href="/viec-lam" title="Danh sách việc làm"><i class="fa fa-server "></i>&nbsp;Nhóm việc làm
                    </a></h4>
                </div>
                <asp:Literal ID="litBus" runat="server"></asp:Literal>
                <div class="link-readmore">
                    <a href="/viec-lam"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
                </div>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript">
    $('.career-number').each(function () { $(this).prop('Counter', 0).animate({ Counter: $(this).text() }, { duration: 2000, easing: 'swing', step: function (now) { $(this).text(Math.ceil(now)); } }); });
</script>
