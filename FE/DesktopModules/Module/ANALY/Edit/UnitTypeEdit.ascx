<%@ Control Language="vb" CodeFile="UnitTypeEdit.ascx.vb" Inherits="Modules.UnitType.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin đơn vị tính</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 lb">Tên đơn vị tính</div>
            <div class="col-md-3">
                <asp:TextBox ID="UnitType_Name" runat="server"  CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Mã đơn vị tính</div>
            <div class="col-md-3">
                <asp:TextBox ID="UnitType_Code" runat="server"  CssClass="TextBox " />
            </div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" />
</div>

