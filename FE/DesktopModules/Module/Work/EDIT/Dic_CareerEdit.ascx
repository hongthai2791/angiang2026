<%@ Control Language="vb" CodeFile="Dic_CareerEdit.ascx.vb" Inherits="Modules.Career.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin ngành nghề</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 pdt5">Mã ngành nghề</div>
            <div class="col-md-2">
                <asp:TextBox ID="Career_Code" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Tên ngành nghề</div>
            <div class="col-md-10">
                <asp:TextBox ID="Career_Name" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Mô tả</div>
            <div class="col-md-10">
                <asp:TextBox ID="Career_Des" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Sử dụng?</div>
            <div class="col-md-4">
                <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Thứ tự hiển thị</div>
            <div class="col-md-1">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox txt-center validate[required,custom[number]]" />
            </div>
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

