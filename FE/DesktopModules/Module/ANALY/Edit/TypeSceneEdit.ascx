<%@ Control Language="vb" CodeFile="TypeSceneEdit.ascx.vb" Inherits="Modules.TypeScene.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
       <div class="col-md-12" ><h3 class="box-title">Thông tin loại kịch bản</h3></div>
    </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="clear"></div>
                    
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Tên kịch bản</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TypeScene_Name" runat="server" TabIndex="4" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TypeScene_Des" runat="server" TabIndex="5" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" TabIndex="8" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" TabIndex="10" CssClass="cmsbut cmsbtdel" />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
     
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
