<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeWorks.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<div id="homeworks">
    <div class="bg-home-work top-job shadow bg-white pd10">
        <div class="container mt10">
            <div class="section-title center-block text-center">
                <h1>VIỆC LÀM TỐT NHẤT</h1>
                <p>Tổng hợp những việc làm hot nhất từ các top công ty tốt nhất và dựa trên những tiêu chí Chất lượng dịch vụ ...</p>
            </div>
            <div class="clear"></div>
            <div class="row datawork_home">
                <div class="clear"></div>
            </div>
            <div class="mt-4 text-center"><a href="/viec-lam" title="Xem thêm việc làm" class="btn btn-primary btn-category"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a> </div>
        </div>
    <div class="clear"></div>
</div>
</div>
<script type="text/javascript">

    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/home/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=0&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });
</script>
