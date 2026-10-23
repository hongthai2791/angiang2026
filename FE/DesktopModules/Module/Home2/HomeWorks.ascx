<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeWorks.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<div id="homeworks">
    <div class="bg-home-work shadow bg-white pd10">
        <div class="container mt10">
            <div class="section-title center-block text-center">
                <h1>DANH SÁCH VIỆC LÀM</h1>
                <p>Tổng hợp những việc làm hot nhất từ các top công ty tốt nhất và dựa trên những tiêu chí Chất lượng dịch vụ ...</p>
            </div>
                <div class="col-md-12">
                    <div class="works-title">
                        <div class="box-w-title">
                            <a onclick="homework(1, this);" class="wactive" title="Việc làm mới nhất">Mới nhất</a>
                            <%--<a onclick="homework(0, this);" class="" title="Việc làm tốt nhất">Tốt nhất</a>--%>
                            <a onclick="homework(2, this);" class="" title="Việc làm lương cao">Lương cao</a>
                            <a onclick="homework(3, this);" class="" title="Tuyển gấp">Tuyển gấp</a>
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
        $(".box-w-title a").removeClass("wactive"); $(t).addClass("wactive");
    };
    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/home/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=1&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });
</script>
