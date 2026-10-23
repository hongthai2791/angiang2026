<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="ContactUs_Edit.ascx.vb" Inherits="DotNetNuke.CMS.Edit" EnableViewState="true" %>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
        <asp:Button ID="cmdDel" runat="server" Visible="false" Text="Xóa liên hệ" CssClass="cmdbtt cmdDel" />
    </div>
</div>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">CHI TIẾT LIÊN HỆ
            </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="c_content">
                <div class="col-md-2 b pdt5">Chuyên san</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker "></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Họ tên độc giả</div>
                <div class="col-md-9">
                    <asp:TextBox ID="FullName" runat="server" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Email liên hệ</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Điện thoại liên hệ</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Tel" runat="server" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Nội dung liên hệ</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Contents" runat="server" Height="250px" TextMode="MultiLine" CssClass="TextBox" />
                </div>
                <div class="clear"></div>
                <asp:Literal ID="litUpdate" runat="server" />
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="ID" runat="server" Visible="false" />
