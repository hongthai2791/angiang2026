<%@ Control Language="vb" EnableViewState="false" AutoEventWireup="false" Explicit="true" CodeFile="Related.ascx.vb" Inherits="DesktopModules.Modules.Related" %>
<style>
    .box-tt
    {
        margin-top:10px ;
    }
    .comments-title-lq
    {
    font: 600 16px/42px Tahoma;
    color: #da0100;
    text-transform: uppercase;
    padding:0px 15px;
    }
    .box-news-hot .list-news-tt {
    display: -webkit-flex;
    display: flex;
    padding: 15px;
    border-bottom: 1px solid #ebebeb;
}
</style>
<div class="row">
    <div class="box-cam-nang box-news-hot box-tt">
        <div class="comments-title-lq">
            Tin liên quan
        </div>
        <asp:Literal runat="server" ID="litNews"></asp:Literal>
        <div class="clear"></div>
    </div>
</div>
<asp:HiddenField ID="NewsId" runat="server" />
<asp:HiddenField ID="CategoryId" runat="server" />
