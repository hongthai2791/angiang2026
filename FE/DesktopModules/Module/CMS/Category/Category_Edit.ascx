<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" ClientIDMode="Static" CodeFile="Category_Edit.ascx.vb" Inherits="DesktopModules.Modules.Category.Edit" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<style>
td.reEditorModesCell {
    display: inline-block !important;
}
</style>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">Biên tập nội dung danh mục </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-9  ">
                <div class="col-md-2 b pdt5">Chọn phân hệ</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Chuyên mục cha</div>
                <div class="col-md-6">
                    <asp:DropDownList ID="ddlParentCategory" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-2 b pdt5 txt-right">Phân loại</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drlType" CssClass="selectpicker validate[required]" runat="server" AutoPostBack="true">
                    </asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Tên chuyên mục</div>
                <div class="col-md-10">
                    <asp:TextBox CssClass="TextBox validate[required]" ID="txtCategoryName" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Mô tả nội dung</div>
                <div class="col-md-10">
                    <div class="telerik-editor">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" Width="100%" CssClass="texteditor" ID="txtdescription" runat="server"
                            ToolsFile="/Portals/_default/HtmlEditor/CateEditor.xml" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                            EnableEmbeddedBaseStylesheet="True" EditModes="Design,HTML,Preview"  ContentFilters="DefaultFilters" Font-Size="16px" Font-Names="Times New Roman" Height="250px">
                            <CssFiles>
                                <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                            </CssFiles>
                        </telerik:RadEditor>
                    </div>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 col-xs-6 b pdt5">Sử dụng?</div>
                <div class="col-md-4 col-xs-6">
                    <asp:CheckBox ID="chkIsActive" Checked="true" runat="server"></asp:CheckBox>
                </div>
                <div class="col-md-2 col-xs-6 b pdt5 txt-right">Thứ tự hiển thị</div>
                <div class="col-md-4 col-xs-6">
                    <asp:TextBox ID="txtOrderNumber" Text="1" runat="server" Width="50" CssClass="TextBox center validate[required, custom[integer]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">TabID</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drTabID" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 col-xs-6 b">Tạo mới trang?</div>
                <div class="col-md-2 col-xs-6">
                    <asp:CheckBox ID="isPage" runat="server" AutoPostBack="true"></asp:CheckBox>
                </div>
                <div class="col-md-2 col-xs-6 b txt-right">Thay đổi Skin?</div>
                <div class="col-md-2 col-xs-6">
                    <asp:CheckBox ID="chSkin" runat="server" AutoPostBack="true"></asp:CheckBox>
                </div>
                <div class="col-md-2 col-xs-6 b txt-right">Fix tên trang?</div>
                <div class="col-md-2 col-xs-6">
                    <asp:CheckBox ID="chLang" runat="server"></asp:CheckBox>
                </div>
                <div class="clear"></div>
                <asp:Panel runat="server" ID="pnCreatePage" CssClass="none" Visible="true">
                    <div class="col-md-2 b pdt5">SkinSrc</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="SkinSrc" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-md-2 b pdt5">ContainerSrc</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ContainerSrc" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5 none">Module</div>
                    <div class="col-md-10 none">
                        <asp:DropDownList ID="ModuleTitle" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                    <div class="clear"></div>
                </asp:Panel>
            </div>
            <div class="col-md-3  ">
                <div class="b pdt5-pms">Phân quyền người sử dụng</div>
                <div class="top-list-1 " style="border-bottom: 2px solid #fff; height: auto;">
                    <asp:CheckBox ID="UserAll" runat="server" CssClass="chkall" onclick="clickSelect('chkall','chk');" Text="Tất cả người dùng" />
                </div>
                <div class="top-list-1 lbchk " style="background-color: #fff">
                    <asp:CheckBoxList ID="ListUser" runat="server" CssClass="chk" />
                </div>
            </div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdCancel" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="GetTabPath" runat="server" />
<asp:HiddenField ID="ItemID" runat="server" Visible="false" />
<script>
    var thd;
    $("#txtdescription .ImageManager").click(function () { changekey('imgvn'); insertimg(900, 550); return false; });
    $("#txtdescription .DocumentManager").click(function () { changekey('imgnew'); insertdoc(900, 550, 'goc'); return false; });
    function insertimg(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (thnew) == "undefined") {
            thnew = new Worker("/js/worker.js");
            thnew.onmessage = function (event) {
                var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                if (result != "") {
                    var editor = $find('<%=txtdescription.ClientID%>');
                    thnew.terminate(); thnew = undefined;
                    var arr = new Array(); arr = result.split("@_@"); var s = "";
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
                            s += '<tr><td style="text-align:center"><img class="imgtelerik" src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '?dpi=150&quality=100&w=620"/></td></tr>';
                            s += '<tr class="alt_imgEditor"><td>&nbsp;</td></tr></table>';

                            $(".idk").html($(".idk").html() + i);
                        }
                    }
                    if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                }
            };
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function insertdoc(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (thd) == "undefined") {
            thd = new Worker("/js/worker.js");
            thd.onmessage = function (event) {
                var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                if (result != "") {
                    var editor = $find('<%=txtdescription.ClientID%>');
                        thd.terminate(); thd = undefined; var s = "";
                        var arr = new Array(); arr = result.split("@_@");
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                var selection = editor.getSelection(), selectedText = selection.getText();
                                if (selectedText == "") { s = '<span class="docEditor"><a href="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '">' + show + ' </a></span>'; }
                                else { s = '<span class="docEditor"><a href="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '">' + selectedText + ' </a></span>'; }
                        }
                    }
                    if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                }
            };
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=doc&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function cleartabscache() {
        var PortalConnect = $('#<%=ddlPortal.ClientID %>').val();
        $.ajax({ type: "POST", url: '<%=EPORTAL.flConnect.WebDomain(ddlPortal.SelectedValue)%>/api/cms/autoTabs.asmx/ClearTabsCache', data: { PortalConnect: PortalConnect }, success: function (response) { } });
    };
</script>
