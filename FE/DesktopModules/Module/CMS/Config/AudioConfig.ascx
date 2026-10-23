<%@ Control Language="VB" AutoEventWireup="false" CodeFile="AudioConfig.ascx.vb" Inherits="DesktopModules.TinTuc.Configurations.AudioConfig" %>
<script src="/Resources/Shared/scripts/jquery/jquery-ui.min.js"></script>
<div class="pustyle">
    <div class="toolbar-placeholder">
        <div class="toolbarBox toolbarHead">
            <ul class="cc_button">
                <li>
                    <asp:LinkButton ID="lbtUpdate" runat="server" Font-Bold="True" CssClass="toolbar_btn" OnClientClick="updateFormValues(); regcache(); return true;">
                        <img src="/images/icons/script_save.png" alt="Thực hiện"/> Cập nhật</asp:LinkButton></li>
                <li>
                    <asp:LinkButton ID="lbtCancelTop" runat="server" Font-Bold="True" CssClass="toolbar_btn">
                        <img src="/images/icons/arrow_rotate_clockwise.png" alt="Exit" /> Thoát</asp:LinkButton></li>
            </ul>
            <div class="clear"></div>
        </div>
    </div>
</div>
<table width="100%" cellpadding="4" cellspacing="4">
    <tr>
        <td width="15%" class="w-lable">Chọn cổng</td>
        <td width="85%">
            <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker dKey" Width="70%"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="w-lable">Loại cấu hình:</td>
        <td class="w-lable">
            <div style="float: left; width: 40%">
                <asp:DropDownList runat="server" ID="drlSettings" CssClass="selectpicker dKey" Width="95%">
                    <asp:ListItem Value="settingsAudioNB" Text="Audio nổi bật trang chủ"></asp:ListItem>
                    <asp:ListItem Value="settingsAudio" Text="Audio nổi bật trang"></asp:ListItem>
                    <asp:ListItem Value="settingsAudioTD" Text="Audio tiêu điểm"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div style="float: left; width: 10%; display: table">
                <a id="page-popup" onclick="popupwindow(900,600); return false;" style="text-decoration: underline; cursor: pointer; color: #CB2027;">
                    <img src="/images/paperclip.png" />Chọn tin:</a>
            </div>
            <div style="float: left; width: 30%;">
                <asp:CheckBox ID="ckHand" CssClass="ckHand" Text="Cấu hình bằng tay?" runat="server" />
            </div>
        </td>

    </tr>
</table>
<div class="settings"></div>

<asp:HiddenField ID="hdf_Value" runat="server" />
<asp:HiddenField ID="_HTTPAlias" runat="server" />
<script type="text/javascript">
    function delNews(sender, id) { if (confirm("Bạn có chắc chắn muốn Delete?") == true) { $(sender).parent().remove(); return false; } };
    function addValue(id, value) { if ($('#' + id).val().indexOf(value) == -1) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ',' + value); } };
    function updateFormValues() { $('#<%= hdf_Value.ClientID %>').val(""); $("#sortable li").each(function (index) { addValue('<%= hdf_Value.ClientID %>', $(this).attr("rel")); }); };
    function popupwindow(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), PId = $('#<%= ddlPortal.ClientID%>').val(), IsFlag = $('#<%= drlSettings.ClientID%>').val();
        return window.open("/desktopmodules/module/cms/config/Audio.aspx?pid=" + PId + "&s=" + IsFlag.toLowerCase(), "Cấu hình audio", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left);
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
    function changevalue() {
        var key = $("#<%= drlSettings.ClientID%>").val(), portal = $("#<%= ddlPortal.ClientID%>").val();
        var link = "/api/cms/AudioConfig.ashx?key=" + key + "&portal=" + portal;
        var msg = $.ajax({ url: link, async: false }).responseText; $(".settings").html(msg);
        link = "/api/cms/ckHand.ashx?key=" + key + "&portal=" + portal;
        msg = $.ajax({ url: link, async: false }).responseText;
        if (msg == "true") { $(".ckHand input").attr("checked", "checked"); } else { $(".ckHand input").removeAttr("checked"); }
        $("#sortable").sortable(); $("#sortable").disableSelection();
    };
    $(".dKey").live("change", function () { changevalue(); });
    $(document).ready(function () { changevalue(); });
</script>
