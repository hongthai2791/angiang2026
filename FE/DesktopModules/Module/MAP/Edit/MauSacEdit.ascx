<%@ Control Language="vb" CodeFile="MauSacEdit.ascx.vb" Inherits="Modules.MauSacEdit.Edit" AutoEventWireup="false" Explicit="True" %>

<!-- jQuery -->
<script src="//code.jquery.com/jquery.min.js"></script>
<!-- MiniColors -->
<script src="/Portals/_default/color/jquery.minicolors.min.js"></script>
<link rel="stylesheet" href="/Portals/_default/color/jquery.minicolors.css">

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin màu sắc</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên màu sắc</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenThucThe" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-center lb">Thuộc tính</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="LinkURL" runat="server" CssClass="TextBox tt_color validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemView" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<script>
    $('.tt_color').minicolors({
        // animation speed
        animationSpeed: 50,
        // easing function
        animationEasing: 'swing',
        // defers the change event from firing while the user makes a selection
        changeDelay: 0,
        // hue, brightness, saturation, or wheel
        control: 'hue',
        // default color
        defaultValue: '',
        // hex or rgb
        format: 'hex',
        // show/hide speed
        showSpeed: 100,
        hideSpeed: 100,
        // is inline mode?
        inline: false,
        // a comma-separated list of keywords that the control should accept (e.g. inherit, transparent, initial). 
        keywords: '',
        // uppercase or lowercase
        letterCase: 'lowercase',
        // enables opacity slider
        opacity: false,
        // custom position
        position: 'bottom left',
        // additional theme class
        theme: 'default',
        // an array of colors that will show up under the main color <a href="https://www.jqueryscript.net/tags.php?/grid/">grid</a>
        swatches: []

    });
</script>