<%@ Control Language="vb" CodeFile="LoaiSoEdit.ascx.vb" Inherits="Modules.LoaiSo.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin danh mục sổ</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 pdt5">Mã sổ</div>
            <div class="col-md-2">
                <asp:TextBox ID="LoaiSo_Code" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Tên sổ</div>
            <div class="col-md-10">
                <asp:TextBox ID="LoaiSo_Name" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="col-md-2 pdt5">Sử dụng?</div>
            <div class="col-md-4">
                <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox" />
            </div>
            <div class="col-md-2 pdt5 txt-right">Thứ tự</div>
            <div class="col-md-1">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox txt-center validate[required,custom[number]]" />
            </div>
            <div class="clear"></div>
            <div class="clear"></div>
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

