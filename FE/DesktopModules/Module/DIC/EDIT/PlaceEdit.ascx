<%@ Control Language="vb" CodeFile="PlaceEdit.ascx.vb" Inherits="Modules.Place.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <h3 class="box-title">Thông tin danh mục nơi cấp gấy tờ</h3>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clear"></div>
             <div class="col-md-2 b pdt5">Mã danh mục</div>
            <div class="col-md-2">
                <asp:TextBox ID="Place_Code" runat="server" CssClass="TextBox b txt-center ReadOnly validate[required]" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Tên danh mục</div>
            <div class="col-md-10">
                <asp:TextBox ID="Place_Name" runat="server" CssClass="TextBox validate[required]" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Mô tả</div>
            <div class="col-md-10">
                <asp:TextBox ID="Place_Des" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Sử dụng? </div>
            <div class="col-md-10">
                <asp:CheckBox ID="Place_IsActive" CssClass="CheckBox" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b pdt5">Thứ tự</div>
            <div class="col-md-1">
                <asp:TextBox ID="Place_IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
            </div>
            <div class="clear"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return $('#Form').validationEngine('validate');" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel"/>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
