<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hệ thống chọn tệp đính kèm</title>
    <link rel="stylesheet" href="/files/css/file.css" type="text/css" media="all" />
    <script src="/files/js/base64.js" type="text/javascript"></script>
    <script src="/files/js/jquery-1.9.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="getvalue none"></div>
            <div class="waiting none">
                <img style="top: 38%; left: 48%; position: relative;" alt="waiting" src="/files/images/ajax-loader.gif" />
            </div>
            <div>
                <div class="pleft">
                    <telerik:RadTreeView ID="_Folder" runat="server" Skin="Office2007" SingleExpandPath="False" autopostback="true"
                        EnableDragAndDrop="True" OnNodeClick="TreeNodeClick" OnContextMenuItemClick="_Folder_ContextMenuItemClick">
                    </telerik:RadTreeView>
                </div>
                <div class="pright">
                    <asp:Literal ID="litTitle" runat="server" />
                    <div class="pheader">
                        <div class="box1">
                            <div class="box-content">
                                <asp:HiddenField ID="fileTypeUp" runat="server" Visible="false" />
                                <asp:FileUpload ID="fileImages" onchange="upLoad()" AllowMultiple="true" CssClass="upload-file" runat="server" />
                                <div class="div-upload none">
                                    <img style="position: relative;" alt="waiting" src="/images/ajax-loader.gif" />
                                </div>
                                <asp:Button runat="server" ID="cmdUpload" CssClass="none" Text="Tải file" />
                                <div class="clr"></div>
                            </div>
                        </div>
                        <div class="box2">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Tìm kiếm ..." CssClass="txts"></asp:TextBox>
                            <asp:Button runat="server" ID="btnSearch" ToolTip="Tìm kiếm" Text="Tìm kiếm" CssClass="btn btn-default btntk " />
                            <div class="clr"></div>
                        </div>
                        <div class="clr"></div>
                    </div>
                    <div class="pheader">
                        <div class="box1">
                            <div class="box-content">
                                <asp:Literal ID="litFile" runat="server"></asp:Literal>
                            </div>
                        </div>
                        <div class="box2">
                        </div>

                        <div class="clr"></div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="ppage">
                        <div>
                            <asp:Button ID="cmdDel" OnClientClick="return deletefile();" Visible="false" runat="server" Text="Xóa ảnh" CssClass="bt-dele" />
                            <asp:Button ID="cmdSave" runat="server" CssClass="bt-dele cbclick" Text="Chèn ảnh" />
                            <asp:CheckBox ID="cbImgNew" runat="server" AutoPostBack="true" Text="" CssClass="cbImgNew" />
                            <asp:Literal ID="spTitle" runat="server" />
                            <asp:Literal ID="litCount" runat="server" />
                            <div class="clr"></div>
                        </div>
                        <div class="litView">
                            <asp:Literal runat="server" ID="lblMessage"></asp:Literal>
                            <asp:Literal ID="litView" runat="server" />
                        </div>
                        <div class="viewPage"></div>
                    </div>
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="valnew"></div>
            <script>
                function nextPage(_Total, pageRow, currPage, RedirectURL) {
                    var link = "/api/home/nextpage.ashx?t=" + _Total + "&pr=" + pageRow + "&ps=5&cp=" + currPage + "&ru=" + Base64.encode(RedirectURL);
                    var msg = $.ajax({ url: link, async: false }).responseText;
                    $(".viewPage").html(msg)
                }
                function addValue(value) {
                    var NotExists = ($('.getvalue').html().indexOf(value) == -1);
                    if (NotExists) {
                        if ($('.getvalue').html() == '' || $('.getvalue').html() == null)
                            $('.getvalue').html(value);
                        else
                            $('.getvalue').html($('.getvalue').html() + ';' + value);
                    }
                    return NotExists;
                };
                function removeValue(value) {
                    var arrTemp = $('.getvalue').html();
                    var sResult = "";
                    var arr = new Array();
                    arr = arrTemp.split(";");
                    for (var i = 0; i < arr.length; i++) {
                        if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; }
                    }
                    $('.getvalue').html(sResult.substring(1, sResult.length));
                };
                $(".cbclick").click(function () { $("div.waiting").removeClass("none"); });
                $(".upload-file").click(function () { jQuery("#<%= fileImages.ClientID%>").click(); });
                function upLoad() { $(".div-upload").removeClass("none"); jQuery("#" + '<%= cmdUpload.ClientID%>').click(); };
                function doneUpload() { $(".div-upload").addClass("none"); };
                function removewaiting() { $("div.waiting").addClass("none") };
                function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
                function selectedfile(t) {
                    $(t).parent(".cfdiv").find(".xcheck input").click();
                    var src = $(t).parent(".cfdiv").find(".cfinput input").attr("value");
                    var chk = $(t).parent(".cfdiv").find(".xcheck input:checked").val();
                    if (chk == "on") { addValue(src); } else { removeValue(src); }
                };
                function clickfile(t) {
                    var src = $(t).parent(".cfcheck").parent(".cfdiv").find(".cfinput input").attr("value");
                    var chk = $(t).parent(".cfcheck").parent(".cfdiv").find(".xcheck input:checked").val();
                    if (chk == "on") { addValue(src); }
                    else { removeValue(src); }
                };
                function deletefile() {
                    var r = confirm('Bạn có muốn xóa danh sách file đã chọn không?')
                    if (r == true) {
                        var arr = jQuery(".cfdiv");
                        for (i = 0; i < arr.length; i++) {
                            var me = jQuery(arr[i]), checked = me.find(".cfcheck input:checked").val();
                            if (checked == "on") {
                                var link = "/image/delefile.ashx?i=" + Base64.encode(me.find(".mathpath").html());
                                var msg = $.ajax({ url: link, async: false }).responseText;
                                var link1 = "/api/admin/delefile.ashx?i=" + Base64.encode(me.find(".webpath").html()) + "&us=" + Base64.encode($("#<%=_UserName.ClientID %>").val()) + "&p=" + $("#<%=_pid.ClientID %>").val();
                                var msg1 = $.ajax({ url: link1, async: false }).responseText;
                                arr[i].remove();
                            }
                        }
                    }
                    return false;
                };
                function onechoose(title) {
                    var link = "/api/admin/cookieadd.ashx?k=<%=strKey%>&v=" + Base64.encode(title);
                    var msg = $.ajax({ url: link, async: false }).responseText; $.ajax({ url: "/files/token.ashx", async: false }).responseText; window.close();
                };
                function multiplechoose() {
                    var listsrc = $(".getvalue").html();
                    for (i = 0; i < listsrc.length; i++) { listsrc = listsrc.replace(";", "@_@"); }
                    var link = "/api/admin/cookieadd.ashx?k=<%=strKey%>&v=" + Base64.encode(listsrc);
                    var msg = $.ajax({ url: link, async: false }).responseText; $.ajax({ url: "/files/token.ashx", async: false }).responseText; window.close();
                };
                function readOne() {
                    var src = ""; var sval = ""; var fileName = ""; var i = 0;
                    $(".new-content").find("img").each(function (e) {
                        src = $(this).attr("src");
                        if (src.indexOf("/data/") > 0) {
                            i = i + 1;
                            src = src.replace("?w=680", "");
                            fileName = src.substring(src.lastIndexOf("/") + 1);;
                            sval += "<div class='cfdiv'>";
                            sval += "<div class='cfcheck xcheck'><input id='id-" + i + "' type='checkbox' name='image'></div>";
                            sval += "<div class=\"cfimg\" onclick=\"onechoose(\'" + src + "\');\">";
                            sval += "<span><img src='" + src + "?w=150&h=90'></span>";
                            sval += "</div>"
                            sval += "<div class='mathpath'>" + src + "</div>";
                            sval += "<div class='webpath'>" + src + "</div>";
                            sval += "<div class='cftitle '>" + fileName + "</div>";
                            sval += "</div>";
                        }
                    });
                    $(".litView").html(sval); $(".count").html("Tổng số (" + i + ")");
                };
                function readMulti() {
                    var src = ""; var sval = ""; var fileName = ""; var i = 0;
                    $(".new-content").find("img").each(function (e) {
                        src = $(this).attr("src");
                        if (src.indexOf("/data/") > 0) {
                            i = i + 1;
                            src = src.replace("?w=680", "");
                            fileName = src.substring(src.lastIndexOf("/") + 1);
                            sval += "<div class='cfdiv'>";
                            sval += "<div class='cfcheck xcheck'>";
                            sval += "<input id='id" + i + "' type='checkbox' name='image' onclick='clickfile(this);'>";
                            sval += "</div>";
                            sval += "<div class='cfimg' onclick='selectedfile(this);'>";
                            sval += "<span><img src='" + src + "?w=150&h=90'></span>";

                            sval += "</div>";
                            sval += "<div class='cfinput'>";
                            sval += "<input type='text' name='text' value='" + src + "'>";
                            sval += "</div>";
                            sval += "<div class='mathpath'>" + src + "</div>";
                            sval += "<div class='webpath'>" + src + "</div>";
                            sval += "<div class='cftitle id" + i + "'>" + fileName + "</div>";
                            sval += "</div>";

                        }
                    });
                    $(".litView").html(sval); $(".count").html("Tổng số (" + i + ")");
                };
                function getContent(d) {
                    var _pid = $("#<%=_pid.ClientID %>").val();
                    var _id = $("#<%=_newid.ClientID %>").val();
                    $.ajax({
                        type: "POST", url: '/api/cms/contents.asmx/NewsContent',
                        data: { PortalConnect: _pid, NewsID: _id },
                        success: function (response) {
                            $(".valnew").html(response.data);
                            if (d == "1") { setTimeout("readOne()", 300); }
                            else { setTimeout("readMulti()", 300); }
                        }
                    });
                };
            </script>
            <asp:HiddenField ID="_Total" runat="server" ClientIDMode="Static" />
            <asp:HiddenField ID="imgInsert" runat="server" Visible="false" />
            <asp:HiddenField ID="foundFolder" runat="server" Visible="false" />
            <asp:HiddenField runat="server" ID="_Years" Visible="False" />
            <asp:HiddenField runat="server" ID="_Month" Visible="False" />
            <asp:HiddenField runat="server" ID="_Day" Visible="False" />
            <asp:HiddenField runat="server" ID="_UserName" ClientIDMode="Static" />
            <asp:HiddenField runat="server" ID="_pid" ClientIDMode="Static" />
            <asp:HiddenField runat="server" ID="_newid" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        </div>
    </form>
</body>
</html>
