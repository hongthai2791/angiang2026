<%@ Control Language="VB" AutoEventWireup="false" CodeFile="EmailSetting.ascx.vb" Inherits="DotNetNuke.Modules.Edit_Settings" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP EMAIL NHẬN THÔNG TIN LIÊN HỆ</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 pdt5 txt-right ">Email nhận liên hệ</div>
                <div class="col-md-5">
                <asp:TextBox ID="WF_EMAIL_LH" CssClass="TextBox" runat="server" />
                </div>
                <div style="clear: both;"></div>
                <div class="col-md-2"></div>
                <div>Ghi chú: Các Email được phân biệt nhau bởi dấu <b>;</b></div>
                <div style="clear: both;"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Thiết lập cài đặt" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
