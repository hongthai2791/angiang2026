<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Infomation.ascx.vb" Inherits="DesktopModules.Modules.TNFooter" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<style>
td.reEditorModesCell {
    display: inline-block !important;
}
</style>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN WEBSITE</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 b">Chọn phân hệ</div>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b">Tiêu đề website</div>
            <div class="col-md-10">
                <asp:TextBox ID="NameH1" runat="server" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b">Logo trái</div>
            <div class="col-md-4" id="imgLeft">
                <asp:HiddenField ID="Images" runat="server" />
                <div id="imgDD" runat="server" class="ImgView list-img-banner" onclick="changekey(); logo_banner(900,550); return false;" style="cursor: pointer;">
                    <asp:Literal ID="ltr_Image" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="col-md-2 b txt-right">Logo phải</div>
            <div class="col-md-4" id="imgRight">
                <asp:HiddenField ID="ImagesR" runat="server" />
                <div id="imgDdp" runat="server" class="ImgView list-img-phai" onclick="changekey(); logo_phai(900,550); return false;" style="cursor: pointer;">
                    <asp:Literal ID="ltr_ImageR" runat="server"></asp:Literal>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b">Fanpage Facebook</div>
            <div class="col-md-10">
                <asp:TextBox ID="NameH2" runat="server" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="col-md-2 b">Fanpage Twitter</div>
            <div class="col-md-10">
                <asp:TextBox ID="NameH3" runat="server" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b">Footer web</div>
            <div class="col-md-10">
                <div class="telerik-editor">
                    <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" Width="100%" CssClass="texteditor" ID="Footer_Name" runat="server"
                        ToolsFile="/Portals/_default/HtmlEditor/CateEditor.xml" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                        StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                        EnableEmbeddedBaseStylesheet="True" EditModes="Design,HTML,Preview" ContentFilters="DefaultFilters" Font-Size="16px" Font-Names="Times New Roman" Height="200px">
                        <CssFiles>
                            <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                        </CssFiles>
                    </telerik:RadEditor>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 b">Footer Mobile</div>
            <div class="col-md-10 ">
                <div class="telerik-editor">
                    <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" Width="100%" CssClass="texteditor" ID="Infomation" runat="server"
                        ToolsFile="/Portals/_default/HtmlEditor/CateEditor.xml" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                        StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                        EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="16px" Font-Names="Times New Roman" Height="200px">
                        <CssFiles>
                            <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                        </CssFiles>
                    </telerik:RadEditor>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>

<asp:Literal ID="lbmsg" runat="server" />
<script type="text/javascript">
    $("#Footer_Name .ImageManager").click(function () { changekey('imgvn'); insertimg(900, 550, 'goc'); return false; });
    $("#Infomation .ImageManager").click(function () { changekey('imgvn'); insertimg(900, 550, 'vi'); return false; });
    var thse;
    function logo_banner(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (Worker) !== "undefined") {
            if (typeof (thse) == "undefined") {
                thse = new Worker("/js/worker.js");
                thse.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thse.terminate(); thse = undefined;
                        if (addValuer('<%= Images.ClientID %>', result)) {
                            $('.list-img-banner img').remove();
                            $('.list-img-banner').append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?h=85" />');
                            $(".del_imgLeft").css("display", "block");
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function addValuer(id, value) { var NotExists = ($('#' + id).val().indexOf(value) == -1); if (NotExists) { if ($('#' + id).val() == '' || $('#' + id).val() == null) { $('#' + id).val(value); } else { $('#' + id).val(value); } } return NotExists; };
    function logo_phai(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (Worker) !== "undefined") {
            if (typeof (thse) == "undefined") {
                thse = new Worker("/js/worker.js");
                thse.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thse.terminate(); thse = undefined;
                        var arr = new Array(); arr = result.split('@_@');

                        for (var i = 0; i < arr.length; i++) {
                            if (addValuer('<%= ImagesR.ClientID %>', arr[0])) {
                                $('.list-img-phai img').remove();
                                $('.list-img-phai').append('<img class="imgDdp" src="<%=EPORTAL.flConnect.fileDomain%>' + arr[0] + '?h=85" />');
                                $(".del_imgRight").css("display", "block");
                            }
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function insertimg(w, h, c) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (Worker) !== "undefined") {
            if (typeof (thse) == "undefined") {
                thse = new Worker("/js/worker.js");
                thse.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thse.terminate(); thse = undefined;
                        var editor; if (c == "goc") { editor = $find('<%=Infomation.ClientID%>'); } else { editor = $find('<%=Footer_Name.ClientID%>'); }
                        var arr = new Array(); arr = result.split("@_@");
                        var s = "";
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0];
                                s += '<table border="0" id="' + $(".idk").html() + '" class="imgEditor" >';
                                s += '<tr style="text-align:center"><td class="dbox">';
                                s += '<a title="Trái" onclick="leftmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/left.png" alt="left"></a>';
                                s += '<a title="Giữa" onclick="centermybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/center.png" alt="center"></a>';
                                s += '<a title="Phải" onclick="rightmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/right.png" alt="right"></a>';
                                s += '<a title="Xóa" onclick="delmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/images/red-error_16px.gif" alt="del"></a>';
                                s += '</td></tr>';
                                s += '<tr><td><img class="imgtelerik" src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '?w=500"/></td></tr>';
                                s += '<tr class="alt_imgEditor"><td>&nbsp;</td></tr></table>';

                                $(".idk").html($(".idk").html() + i);
                            }
                        }
                        if (s != "") { editor.pasteHtml(s) }
                        $(".IdKey").html("");
                    }
                };
            }
        }

        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&i=" + pid + "&f=" + $(".IdKey").html() + "", "Chèn Img - Audio - Video", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
</script>
<div style="display: none;" class="IdKey"></div>
