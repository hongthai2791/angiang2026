<%@ Control Language="vb" CodeFile="DomainEdit.ascx.vb" Inherits="Modules.ActiveDomain.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin đơn vị triển khai kinh tế xã hội</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 pdt5">Tỉnh/ thành phố</div>
            <div class="col-md-4">
                <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker validate[required]" />
                <span class="required"></span>
            </div>

            <div class="col-md-2 pdt5 txt-right">Quận/Huyện</div>
            <div class="col-md-4">
                <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Tên miền triển khai</div>
            <div class="col-md-10">
                <asp:TextBox ID="ActiveDomain_Name" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Ngày kích hoạt</div>
            <div class="col-md-4">
                <asp:TextBox ID="ActiveDate" runat="server" CssClass="TextBox datepicker validate[required]" />
                <span class="required"></span>
            </div>
            <div class="col-md-2 pdt5 txt-right">Ngày hết hạn</div>
            <div class="col-md-4">
                <asp:TextBox ID="ExpriteDate" runat="server" CssClass="TextBox datepicker" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Ghi chú</div>
            <div class="col-md-10">
                <asp:TextBox ID="ActiveDomain_Des" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100" />
            </div>
            <div class="col-md-2 pdt5">Sử dụng?</div>
            <div class="col-md-4">
                <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox" />
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

