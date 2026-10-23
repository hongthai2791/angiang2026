<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="BusinessList.ascx.vb" Inherits="DesktopModules.Modules.Work.WorksList" %>
<div class="box_list_works">
      <div class="row">
        <div class="col-md-10 mt10 mb10">
        <asp:TextBox runat="server" ID="txtKey" placeholder="Nhập tên doanh nghiệp, mã số thuế để tìm kiếm"  CssClass="TextBox" />

        </div>
        <div class="col-md-2 mt10 mb10">
            <asp:LinkButton runat="server" ID="btnTimKiem" CssClass="btn btn-primary" ><i class="fa fa-search"></i>&nbsp;Tìm kiếm</asp:LinkButton>
        </div>
        
    </div>
    <asp:Literal ID="litVal" runat="server"></asp:Literal>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="SearchID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="vUrl" runat="server" Visible="false" />
<asp:HiddenField ID="Title" Value="" runat="server" Visible="false" />
