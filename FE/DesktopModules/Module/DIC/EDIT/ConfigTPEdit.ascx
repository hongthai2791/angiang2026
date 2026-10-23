<%@ Control Language="vb" Inherits="Modules.ConfigTP.Edit" CodeFile="ConfigTPEdit.ascx.vb" ClientIDMode="Static" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN CẤU HÌNH</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 pdt5">Tỉnh/ thành phố</div>
            <div class="col-md-10">
                <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Tiêu đề hệ thống</div>
            <div class="col-md-10">
                <asp:TextBox ID="PortalName" runat="server" CssClass="TextBox validate[required,maxSize[249]]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Tên miền sử dụng</div>
            <div class="col-md-10">
                <asp:TextBox ID="PortalAlias" runat="server" CssClass="TextBox validate[required,maxSize[249]]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Nội dung mô tả</div>
            <div class="col-md-10">
                <asp:TextBox ID="PortalDes" runat="server" TextMode="MultiLine" Height="100" CssClass="TextBox" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Logo hệ thống</div>
            <div class="col-md-10 dvimg-logo">
                <div class="seimgselect se-logo" onclick="changekey('logo'); insertavatar(900,550,'se-logo','<%=LogoHid.ClientID %>'); return false;">
                    <asp:Image runat="server" ID="imgLogo" ToolTip="Logo hệ thống" ImageUrl="/image/images/noimage.png?h=120" />
                </div>
                <asp:HiddenField ID="LogoHid" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Ảnh đại diện</div>
            <div class="col-md-10 dvimg">
                <div class="seimgselect avt-img" onclick="changekey('avt'); insertavatar(900,550,'avt-img','<%=ImagesHid.ClientID %>'); return false;">
                    <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh đại diện" ImageUrl="/image/images/noimage.png?h=120" />
                </div>
                <asp:HiddenField ID="ImagesHid" runat="server" />
            </div>
            <div class="clear"></div>
        </div>

    </div>
</div>
<div class="clr clUp"></div>
<asp:Literal ID="litUpdate" runat="server" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmdbtt cmdDel" OnClientClick="return $('#Form').validationEngine('detach'); " />
        <div class="clear"></div>
    </div>
</div>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
<script type="text/javascript">
    var thd;
    function insertavatar(w, h, dv, hid) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = '<%= PortalId.ToString%>';
        if (typeof (Worker) !== "undefined") {
            if (typeof (thd) == "undefined") {
                thd = new Worker("/js/worker.js");
                thd.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thd.terminate(); thd = undefined;
                        $('#' + hid).val("");
                        if (addValue(hid, result)) {
                            $('.' + dv + ' img').remove();
                            $('.' + dv).append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?h=250" />');
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain%>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Chọn ảnh", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
</script>

