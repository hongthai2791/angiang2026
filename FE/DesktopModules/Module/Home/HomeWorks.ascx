<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeWorks.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<div id="homeworks ">
    <div class="bg-home-work shadow bg-white pd10 ">
        <div class="row mt10 container">
            <div class="col-md-12 col-xs-12">
                <div class="text-center">
                  <a href="/viec-lam">  <h2 class="section-title mb-10">Danh sách việc làm</h2></a>
                    <p class="font-lg color-text-paragraph-2">Danh sách việc làm tốt nhất nhanh chóng hiệu quả. Tìm kiếm việc làm phù hợp với đãi ngộ hấp dẫn...</p>
                </div>
            </div>
            <div class="col-md-12 col-xs-12">
                <div class="col-md-12">
                    <div class="works-title" style="padding:20px 0 30px;">
                        <a onclick="homework(1, this);" class="wactive" title="Việc làm mới nhất"><i class="fa fa-plus"></i>&nbsp;Mới nhất</a>
                        <%--<a onclick="homework(0, this);" class="" title="Việc làm tốt nhất">Tốt nhất</a>--%>
                        <a onclick="homework(2, this);" class="" title="Việc làm lương cao"><i class="fa fa-eercast" aria-hidden="true"></i>&nbsp;Lương cao</a>
                        <a onclick="homework(3, this);" class="" title="Tuyển gấp"><i class="fa fa-plus" aria-hidden="true"></i>&nbsp;Tuyển gấp</a>
                        <a href="/viec-lam"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="row datawork_home">
                <div class="clear"></div>
            </div>

            <div class="clear"></div>

        </div>
    </div>
</div>
<script type="text/javascript">
    function homework(flag, t) {
        //$("#homeworks").attr("class", "").addClass("home-works hw-" + flag);
        $.ajax({ type: 'GET', url: '/api/home/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=" + flag + "&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, });
        $(".works-title a").removeClass("wactive"); $(t).addClass("wactive");
    };
    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/home/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=1&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });
</script>
