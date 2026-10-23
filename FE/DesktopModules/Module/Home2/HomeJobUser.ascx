<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeJobUser.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeJobUser" %>

<section class="sptb bg-white">
    <div class="container">
        <div class="home-jobuser">
            <div class="section-title center-block text-center">
                <h1>HỒ SƠ XIN VIỆC</h1>
                <p>Thông tin cá nhân: Họ và tên, ngày tháng năm sinh, SĐT, email, địa chỉ cư trú...</p>
            </div>
            <div class="data_jobuser_home">
            </div>
            <div class="clear"></div>
            <div class="mt-4 text-center"><a href="/ho-so-xin-viec" title="Xem thêm hồ sơ" class="btn btn-primary btn-category"><i class="fa fa-long-arrow-right"></i>&nbsp;Xem thêm</a> </div>
        </div>
    </div>
</section>

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
