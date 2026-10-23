<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="NotiProfile.ascx.vb" Inherits="Modules.PageWork.View" %>
<div class="box box-Active ">
    <div class="box-body">
        <div class="main-body pdt50">
            <div class="col-md-5 NoiDung">
                <div class="Active-title">
                    <p>Bạn vui lòng cập nhật đầy đủ thông tin <br /> hồ sơ cá nhân trước khi sử dụng hệ thống</p>
                </div>
                <div class="noti-hotline">
                    Bấm <a href="/<%=Me.PortalSettings.ActiveTab.TabName %>/view/profile-user">vào đây</a>
                </div>
            </div>
            <div class="col-md-7 pdl0">
                <div class="extra-section__image" style="background-image: url('/image/images/thongbao.jpg?w')">
                </div>
            </div>
        </div>
    </div>
</div>

