<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ViewSetting.ascx.vb" Inherits="Modules.ExSetting.View" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP VÙNG HIỂN THỊ MẶC ĐỊNH</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
           
            <div class="row">
                <div class="col-md-2 lb pdt5">Vùng mặc định</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drBoCuc" CssClass="selectpicker" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
        <asp:Button ID="cmdSave" runat="server" Text="Thiết lập cài đặt" CssClass="cmdbtt cmdSave" />
    </div>
</div>
