<%@ Control Language="VB" AutoEventWireup="false" CodeFile="CategoryConfig.ascx.vb" Inherits="DesktopModules.TinTuc.Configurations.HomeBlockConfig" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP CÀI ĐẶT HIỂN THỊ KHỐI TIN</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">

            <div class="col-md-2 b">Chọn phân hệ</div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="ddlPortal selectpicker dKey"></asp:DropDownList>
            </div>

            <div class="col-md-2 b">Nhóm khối tin</div>
            <div class="col-md-10">
                <asp:DropDownList runat="server" AutoPostBack="true" CssClass="selectpicker" ID="ddlBlockFlag"></asp:DropDownList>
            </div>
            <div class="col-md-2 b">Tên khối tin</div>
            <div class="col-md-10">
                <asp:DropDownList onchange="changevalue();settingval();" runat="server" CssClass="selectpicker drlSettings validate[required]" ID="drlSettings"></asp:DropDownList>
            </div>

            <div class="clear"></div>
            <div class="col-md-6" style="padding-left: 0px; padding-right: 0px;">
                <div class="col-md-12 b">Ảnh mô tả</div>
                <div class="col-md-12 img-settings">
                </div>
            </div>
            <div class="col-md-6" style="padding-left: 0px; padding-right: 0px;">
                <div class="col-md-6 b">Cấu hình thiết lập</div>
                <div class="col-md-6">
                    <div id="Div1" runat="server">
                        <a id="page-popup" onclick="popupwindow(900,600); return false;" style="text-decoration: underline; cursor: pointer; color: #CB2027;">
                            <img src="/image/paperclip.png" />Chọn chuyên mục</a>
                    </div>
                </div>
                <div class="clear"></div>
                <div class="settings" id="sortable"></div>
                <div class="clear"></div>
            </div>

        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="lbtUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="updateFormValues(); regcache(); return true;" />
        <asp:Button ID="lbtCancelTop" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>

<div class="clear"></div>
<asp:HiddenField ID="hdf_Value" runat="server" />
<asp:HiddenField ID="_HTTPAlias" runat="server" />
<script type="text/javascript">
    function delCategory(sender, id) { if (confirm("Bạn có chắc chắn muốn xóa?") == true) { $(sender).parent().remove(); return false; } };
    function addValue(id, value) { if ($('#' + id).val().indexOf(value) == -1) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ',' + value); } };
    function updateFormValues() { $('#<%= hdf_Value.ClientID %>').val(""); $("#sortable li").each(function (index) { addValue('<%= hdf_Value.ClientID %>', $(this).attr("rel")); }); };
    function popupwindow(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2); var PId = $('#<%= ddlPortal.ClientID%>').val(), key = $('#<%= drlSettings.ClientID%>').val();
        return window.open("/desktopmodules/module/cms/config/category.aspx?portalid=" + PId + "&settings=" + key, "Cấu hình chuyên mục tin trang chủ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left);
    };
    function HandlePopupResult(result) {
        var arr = new Array(); arr = result.split(";");
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] != null && arr[i] != '') {
                var sid = arr[i].split("|")[0]; var stitle = Base64.decode(arr[i].split("|")[1]);
                $('#sortable').append('<li class="ui-state-default" rel=' + sid + '><span class="ui-icon ui-icon-arrowthick-2-n-s"></span>' + stitle + ' <a class="delRelated" onclick="javascript:delCategory(this,' + sid + ');" title="Remove this?" style="cursor:pointer;"></a></li>');
            }
        }
    };
    function settingval() { $(".img-settings").html(""); $.ajax({ type: "GET", url: '/api/admin/settings.asmx/HomeBlock?pid=' + <%= Me.PortalId  %> + "&id=" + $("#<%=drlSettings.ClientID%>").val(), success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".img-settings").html(json.data); } } }); };
    function changevalue() {
        $("#sortable").html("");
        var key = $("#<%=drlSettings.ClientID%>").val(), portal = $("#<%=ddlPortal.ClientID%>").val();
        var link = "/api/cms/blockconfig.ashx?key=" + key + "&portal=" + portal;
        var msg = $.ajax({ url: link, async: false }).responseText; $("#sortable").html(msg); $("#sortable").sortable(); $("#sortable").disableSelection();
    };
    $(document).ready(function () { changevalue(); settingval(); });
</script>
