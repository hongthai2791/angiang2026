<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeWorks.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<div id="homeworks">
    <div class="bg-home-work top-job shadow bg-white pd10">
        <div class="container mt10">
            <div class="col-md-12 col-xs-12">
                <div class="cate-title">
                    <h4><a href="/viec-lam" title="Việc làm tốt nhất"><i class="fa fa-check-circle"></i>&nbsp;Việc làm tốt nhất
                    </a></h4>
                </div>
            </div>
            <div class="clear"></div>
            <div class="row datawork_home">
                <div class="clear"></div>
            </div>
             
            <div class="col-md-12 col-xs-12 text-center">
                               <a href="/viec-lam"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
                            <div class="clear"></div>
            </div>
            <div class="clear"></div>

        </div>
    </div>
</div>
<script type="text/javascript">
 
    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/home/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=0&tinhTp=<%=EPORTAL.flReg.WebConfig("TinhTP")%>", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });
</script>
