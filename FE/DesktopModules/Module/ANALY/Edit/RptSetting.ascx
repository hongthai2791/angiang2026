<%@ Control Language="VB" AutoEventWireup="false" CodeFile="RptSetting.ascx.vb" Inherits="Modules.ExSetting.View" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP DỮ LIỆU HIỂN THỊ</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 pdt5">Nhóm chỉ tiêu hiển thị</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="Group_ID" CssClass="selectpicker" runat="server" />
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
