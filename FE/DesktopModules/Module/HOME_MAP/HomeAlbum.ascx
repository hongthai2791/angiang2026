<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeAlbum.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeAlbum" %>
<div class="box-album ">
    <div class="container">
        <div class="row">
            <div class="tit-cat">
                <div class="tit-cat-name">Hình ảnh hoạt động</div>
                <span id="prev-album" class="cus-owl-prev"><i class="fa fa-angle-left" aria-hidden="True"></i></span>
                <span id="next-album" class="cus-owl-next"><i class="fa fa-angle-right" aria-hidden="True"></i></span>
                <div class="clear"></div>
            </div>
        </div>
        <div class="row">
            <div class="psa-box">
                <div class="box-div">
                    <div class="owl-carousel owl-theme" id="owl-album">
                        
                        <asp:Literal ID="litAlbum" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
