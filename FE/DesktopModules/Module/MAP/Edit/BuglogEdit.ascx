<%@ Control Language="vb" CodeFile="BuglogEdit.ascx.vb" Inherits="Modules.Roles.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin bug lỗi hệ thống</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Lỗi hệ thống</div>
            <div class="col-md-10">
                <asp:DropDownList ID="TabName" Enabled="false" CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Mã lỗi</div>
            <div class="col-md-10">
                <div class="bug-id">
                    <asp:Literal ID="Buglog_ID" runat="server" />
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Nội dung lỗi</div>
            <div class="col-md-10">
                <div class="bug-val">
                    <asp:Literal ID="Contents" runat="server" />
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Cách xử lý</div>
            <div class="col-md-10">
                <asp:TextBox ID="Resolve" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="150" />
            </div>
            <div class="clear"></div>
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
</div>
