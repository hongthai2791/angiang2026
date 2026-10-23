<%@ Control Language="vb" AutoEventWireup="true" CodeFile="SendLink.ascx.vb" Inherits="Modules.Main.View" %>
<div class="box box-Active ">
    <div class="box-body">
        <div class="main-body pdt50">
            <div class="col-md-5 NoiDung">
                <div class="Active-title">
                    <asp:Literal ID="lbTbao" runat="server"></asp:Literal>
                </div>                
                <div class="Active-title">
                    Hoặc bấm <a class="noti-hotline" style="color: red" href="/<%=_tabName %>">vào đây</a> để quay lại trang chủ.
                </div>
            </div>
            <div class="col-md-7">
                <div class="extra-section__image" style="background-image: url('/image/images/thongbao.jpg?w')">
                </div>
            </div>
        </div>
    </div>
</div>
<style type="text/css">
    .box-body {
        padding: 5px !important;
        margin-bottom: 100px !important;
    }

    .main-body {
        min-height: 560px;
        margin-bottom: 50px;
    }

    .Active-title {
        color: #0076a9;
        font-size: 22px;
        text-align: center;
        justify-content: center;
        padding-bottom: 15px;
    }

    .NoiDung {
        padding-top: 150px;
    }

    .noti-hotline {
        font-size: 24px;
        font-weight: bold;
        text-align: center;
    }

    .extra-section__image {
        height: 450px;
        background-size: cover;
        background-position: center;
        max-width: 100%;
    }
</style>

<script src="/Resources/libraries/jQuery/03_02_01/jquery.js?cdv=51" type="text/javascript"></script>
<script src="/Resources/libraries/jQuery-UI/01_12_01/jquery-ui.js?cdv=51" type="text/javascript"></script>
<script src="/Resources/Shared/Scripts/dnn.jquery.js?cdv=51" type="text/javascript"></script>
