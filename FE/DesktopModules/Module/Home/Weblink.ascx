<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="Weblink.ascx.vb" Inherits="DesktopModules.Home.Weblink" %>
<style>
    .blog:hover {
    border-color: #26a2c9;
     -webkit-box-shadow: 0 0 24px 0 rgb(13 154 214 / 30%); 
    -moz-box-shadow: 0 0 24px 0 rgba(13,154,214,0.3);
    box-shadow: 0 0 24px 0 rgb(13 154 214 / 30%);
}
    .blog {
    position: relative;
    border: 2px solid transparent;
    transition-duration: .3s;
    display: block;
    border-radius: 8px;
    overflow: hidden;
    border: 1px solid #dddddd
}
   .box-doitac h5 a, .box-doitac h5{
    font-family: 'Roboto-Medium' !important;
    font-size: 20px;
    padding: 20px;
    text-align: left !important;
}
   .text-dt, .img-dt{    display: table-cell;}
   .doitac-color{
    
   }
  .doitac-color{
               padding:1px 5px;

    }
  .doitac-cl{
      height:80px;
      color:#000
  }
  .pdt25{
      padding-top:25px;
  }
  .img-dt{
      padding-top:5px;
  }
  .blog:hover {
    border-color: #26a2c9;
    -webkit-box-shadow: 0 0 24px 0 rgb(13 154 214 / 30%);
    -moz-box-shadow: 0 0 24px 0 rgba(13,154,214,0.3);
    box-shadow: 0 0 24px 0 rgb(13 154 214 / 30%);
}
</style>
<div class="box-doitac">
    <div class="container chinhmau mgt10 bg-main pd10">
         <div class="cate-title">
                <h4><a style="display: inline-block"  title="Liên kết Website"><i class="fa fa-link"></i>&nbsp;Liên kết Website
                    <i class="cate-border" style="background: #77024f"></i>
                </a></h4>
            </div>
        <div class="row pd10">
            <div class="owl-carousel owl-theme" id="owl-doitac">
                <asp:Literal ID="ltWeblink" runat="server" />
            </div>
        </div>
    </div>
</div>
