<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeWorks.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<div id="homeworks">
    <div class="bg-home-work shadow bg-white pd10">
                <div class="col-md-12">
                    <div class="works-title">
                        <div class="box-w-title">
                            VIỆC LÀM &nbsp;
                            <a onclick="homework(1, this);" class="wactive" title="Việc làm mới nhất">Mới nhất</a>
                            <a onclick="homework(0, this);" class="" title="Việc làm tốt nhất">Tốt nhất</a>
                            <a onclick="homework(2, this);" class="" title="Việc làm lương cao">Lương cao</a>
                            <a onclick="homework(3, this);" class="" title="Tuyển gấp">Tuyển gấp</a>
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
<script type="text/javascript">
    function homework(flag, t) {
        //$("#homeworks").attr("class", "").addClass("home-works hw-" + flag);
        $.ajax({ type: 'GET', url: '/api/home/kiosk.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=" + flag + "&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, });
        $(".box-w-title a").removeClass("wactive"); $(t).addClass("wactive");
    };
    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/home/kiosk.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=1&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });
</script>
