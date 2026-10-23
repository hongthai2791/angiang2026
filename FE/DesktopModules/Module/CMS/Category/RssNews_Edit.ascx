<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="RssNews_Edit.ascx.vb" Inherits="DesktopModules.Weblinks.Weblink_Edit" EnableViewState="true" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN TIN BÀI RSS
            </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div id="newContent" runat="server">
                <div class="col-md-12">
                    <div class="col-md-2" style="font-weight: bold">Đơn vị</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlPortal" runat="server" CssClass="chosen validate[required]"  AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2" style="font-weight: bold">Tên nguồn </div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Name" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2" style="font-weight: bold">Địa chỉ liên kết</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Url" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
                <asp:HiddenField ID="User_Name" runat="server" />
                <asp:HiddenField ID="ItemID" runat="server" />
                <div class="IdKey" style="display: none;"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu" CssClass="cmdbtt cmdSave" OnClientClick="return $('#Form').validationEngine('validate');"/>
        <asp:Button ID="cmdDel" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel"   />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');"/>
    </div>
</div>
