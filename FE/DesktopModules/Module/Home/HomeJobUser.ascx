<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeJobUser.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeJobUser" %>
<div class="home-jobuser bg-white container">
    <%--<div class="cate-title">
            <h4><a style="display:inline-block"  href="/ho-so-xin-viec"  title="Hồ sơ ứng viên"><i class="fa fa-users"></i>&nbsp;Hồ sơ xin việc
            </a></h4>
        </div>--%>
    <div class="text-center">
        <a href="/ho-so-xin-viec"><h2 class="section-title mb-10">Hồ sơ xin việc</h2></a>
        <p class="font-lg color-text-paragraph-2">Tập hợp các ứng viên tốt nhất phù hợp với nhu cầu tuyển dụng.</p>
    </div>
    <div class="data_jobuser_home">
    </div>
    <div class="clear"></div>
    <div class="link-readmore pdt10">
        <a href="/ho-so-xin-viec"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a>
    </div>
</div>

<script type="text/javascript">
    function getValue() {
        $.ajax({
            type: 'GET', url: '/api/work/home.asmx/jobUser',
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) {
                    $(".data_jobuser_home").html(json.data);
                };
            },
        });
    };
    jQuery(document).ready(function () { getValue(); });
</script>
