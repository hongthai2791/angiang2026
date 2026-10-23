<%@ Control Language="vb" CodeFile="SysConfig.ascx.vb" Inherits="Modules.Settings.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thiết lập cấu hình hệ thống</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-12 b">Thiết lập cấu hình SMTP</div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5 txt-right">SMTP Server</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SMTP_Server" runat="server" placeholder="SMTP Server" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5 txt-right">SMTP Port</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SMTP_Port" runat="server" placeholder="SMTP Port" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5 txt-right">SMTP Email</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SMTP_Email" runat="server" placeholder="SMTP Email" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5 txt-right">SMTP Password</div>
                <div class="col-md-4">
                    <asp:TextBox ID="SMTP_Password" runat="server" autocomplete="on" aria-label="Content" TextMode="Password" placeholder="SMTP Password" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
    </div>
</div>
