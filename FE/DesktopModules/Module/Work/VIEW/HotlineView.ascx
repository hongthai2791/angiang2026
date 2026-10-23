<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HotlineView.ascx.vb" Inherits="DotNetNuke.Modules.HotlineView" %>

<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin hỗ trợ khách hàng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-12">Số Hotline hỗ trợ Nhà tuyển dụng</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="NTD_Hotline" CssClass="TextBox" runat="server" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="col-md-12">Số Hotline hỗ trợ Người lao động</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="NLD_Hotline" CssClass="TextBox" runat="server" />
                    </div>
                </div>
                <div class="clear"></div>
                <div class="row">
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-12">Email hỗ trợ Nhà tuyển dụng</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="NTD_Email" CssClass="TextBox" runat="server" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="col-md-12">Email hỗ trợ Người lao động</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="NLD_Email" CssClass="TextBox" runat="server" />
                    </div>
                </div>
                <div class="clear"></div>
                <div class="row">
                </div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
