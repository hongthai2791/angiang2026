<%@ Control Language="vb" Inherits="Dotnetnuke.Modules.Edit" CodeFile="DocUnit_Edit.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">BIÊN TẬP NỘI DUNG VĂN BẢN PHÁP LUẬT</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 lb">Chọn phân hệ</div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb">Tên cơ quan ban hành</div>
            <div class="col-md-10">
                <asp:TextBox ID="DocUnit_Name" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Mô tả</div>
            <div class="col-md-10 ">
                <asp:TextBox ID="DocUnit_Des" runat="server" TextMode="MultiLine" Height="150px" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Thứ tự hiển thị</div>
            <div class="col-md-1">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox validate[required,custom[number]]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clear clUp"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
