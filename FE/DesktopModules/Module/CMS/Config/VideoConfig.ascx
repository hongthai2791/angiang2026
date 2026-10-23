<%@ Control Language="VB" AutoEventWireup="false" CodeFile="VideoConfig.ascx.vb" Inherits="DesktopModules.TinTuc.Configurations.VideoConfig" %>
<script src="/Resources/Shared/scripts/jquery/jquery-ui.min.js"></script>


<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="lbtUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="updateFormValues(); regcache(); return true;" />
        <asp:Button ID="lbtCancelTop" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
<div class="col-md-2 b">Thiết lập chuyên san</div>
<div class="col-md-10">
    <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker dKey"></asp:DropDownList>
</div>
<div class="col-md-2 b">Nội dung thiết lập</div>
<div class="col-md-10">
    <asp:DropDownList runat="server" ID="drlSettings" CssClass="selectpicker dKey" Width="95%">
        <asp:ListItem Value="settingsVideoNB" Text="Video nổi bật trang chủ"></asp:ListItem>
        <asp:ListItem Value="settingsVideo" Text="Video nổi bật trang"></asp:ListItem>
        <asp:ListItem Value="settingsVideoTD" Text="Video tiêu điểm"></asp:ListItem>
    </asp:DropDownList>
</div>
<div class="col-md-2 b">Cấu hình thiết lập</div>
<div class="col-md-10">
    <div class="col-sm-4">
        <asp:CheckBox ID="ckHand" CssClass="ckHand" Text="Cấu hình bằng tay?" runat="server" />
    </div>
    <div class="col-sm-8">
        <a id="page-popup" onclick="popupwindow(900,600); return false;" style="text-decoration: underline; cursor: pointer; color: #CB2027;">
            <img src="/images/paperclip.png" />Chọn tin:</a>
    </div>
</div>
<div class="clear"></div>
<div class="settings"></div>

<asp:HiddenField ID="hdf_Value" runat="server" />
<asp:HiddenField ID="_HTTPAlias" runat="server" />
<script type="text/javascript">
    function delNews(sender, id) { if (confirm("Bạn có chắc chắn muốn Delete?") == true) { $(sender).parent().remove(); return false; } };
    function addValue(id, value) { if ($('#' + id).val().indexOf(value) == -1) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ',' + value); } };
    function updateFormValues() { $('#<%= hdf_Value.ClientID %>').val(""); $("#sortable li").each(function (index) { addValue('<%= hdf_Value.ClientID %>', $(this).attr("rel")); }); };
    function popupwindow(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), PId = $('#<%= ddlPortal.ClientID%>').val(), IsFlag = $('#<%= drlSettings.ClientID%>').val();
        return window.open("/desktopmodules/module/cms/config/Video.aspx?pid=" + PId + "&s=" + IsFlag.toLowerCase(), "Cấu hình video", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left);
    };
    function HandlePopupResult(result) {
        var arr = new Array(); arr = result.split(";");
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] != null && arr[i] != '') {
                var sid = arr[i].split("|")[0]; var stitle = Base64.decode(arr[i].split("|")[1]);
                $('#sortable').append('<li class="ui-state-default" rel=' + sid + '><span class="ui-icon ui-icon-arrowthick-2-n-s"></span>' + stitle + ' <a class="delRelated" onclick="javascript:delNews(this,' + sid + ');" title="Remove this?" style="cursor:pointer;"></a></li>');
            }
        }
    };
    function regcache() {
        var p = $("#<%=ddlPortal.ClientID%>").val(), val = $("#<%=drlSettings.ClientID%>").val(), id = $("#<%=hdf_Value.ClientID%>").val();
        indexhome1("settings", p, 0, val, id);

        id = document.getElementById('<%=ckHand.ClientID %>').checked;
        indexhome1("settings", p, 0, val + "_ckHand", id);
    };
    function indexhome1(key, p, d, val, id) {
        var link = "<%=_HTTPAlias.Value%>/api/admin/cache.ashx?key=" + key + "&p=" + p + "&d=" + d + "&val=" + val + "&id=" + id, msg = $.ajax({ url: link, async: false }).responseText;
    };
    function changevalue() {
        var key = $("#<%= drlSettings.ClientID%>").val(), portal = $("#<%= ddlPortal.ClientID%>").val();
        var link ="/api/cms/videoconfig.ashx?key=" + key + "&portal=" + portal;
        var msg = $.ajax({ url: link, async: false }).responseText; $(".settings").html(msg);
        link = "/api/cms/ckHand.ashx?key=" + key + "&portal=" + portal;
        msg = $.ajax({ url: link, async: false }).responseText;
        if (msg == "true") { $(".ckHand input").attr("checked", "checked"); } else { $(".ckHand input").removeAttr("checked"); }
        $("#sortable").sortable(); $("#sortable").disableSelection();
    };
    $(".dKey").live("change", function () { changevalue(); });
    $(document).ready(function () { changevalue(); });
</script>
