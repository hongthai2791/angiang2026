<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Ab_Edit.ascx.vb" Inherits="DesktopModules.TinAnh.Manager.Edit_News" EnableViewState="true" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="newContent" runat="server">
    <div class="xbody commonx">
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdExit" runat="server" CssClass="cmdbtt cmdExit" Text="Thoát" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />

                <asp:Button ID="cmdRun0" runat="server" CssClass="cmdbtt cmdRun" Text="Thực hiện 0" Visible="false" />
                <asp:Button ID="cmdRun1" runat="server" CssClass="cmdbtt cmdRun1" Text="Thực hiện 1" Visible="false" />
                <asp:Button ID="cmdRun2" runat="server" CssClass="cmdbtt cmdRun2" Text="Thực hiện 2" Visible="false" />
                <asp:Button ID="cmdRun3" runat="server" CssClass="cmdbtt cmdRun3" Text="Thực hiện 3" Visible="false" />
                <asp:Button ID="cmdPUBNOW" runat="server" CssClass="cmdbtt cmdPUBNOW" Text="Xuất bản ngay" Visible="false" />

                <asp:Button ID="cmdStop" runat="server" CssClass="cmdbtt cmdStop" Text="Ngừng xuất bản" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" />
            </div>
        </div>
    </div>
    <div class="box box-info">
        <div class="box-header with-border ">
            <div class="col-md-12">
                <h3 class="box-title">BIÊN TẬP NỘI DUNG TIN ẢNH</h3>
            </div>
        </div>
        <div class="box-body">
            <div class="main-body">
                <div class="pustyle">
                    <div class="ubox_wrap">
                        <div class="xhead">
                            <div class="col-sm-2 pdl0 pdt7">Nội dung chi tiết</div>
                            <div class="col-sm-10 txt-right pdr0">
                                <asp:Button ID="cmdBack1" runat="server" CssClass="cmdbtt cmdBack" Text="Trả lại 1" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                                <asp:Button ID="cmdBack2" runat="server" CssClass="cmdbtt cmdBack2" Text="Trả lại 2" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                                <asp:Button ID="cmdBack3" runat="server" CssClass="cmdbtt cmdBack3" Text="Trả lại 3" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                                <asp:Button ID="cmdBack4" runat="server" CssClass="cmdbtt cmdBack4" Text="Trả lại 4" Visible="false" OnClientClick="updateTags(); return checkinput();" />

                                <asp:Button ID="cmdDel" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa tin bài" Visible="false" />
                                <asp:Button ID="cmdView" runat="server" CssClass="cmdbtt cmdView" Text="Xem trước" OnClientClick="popuppreview(); return $('#Form').validationEngine('detach');" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div style="margin:8px 8px 0">
                            <div class="col-md-6">
                                <div class="col-md-12">Chọn phân hệ</div>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="ddlPortal selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12">Chọn chuyên mục</div>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlCategory" CssClass="selectpicker cmcoption validate[required]" runat="server" DataTextField="CategoryName" DataValueField="CategoryID"></asp:DropDownList>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12">Tiêu đề tin</div>
                            <div class="col-md-12">
                                <asp:TextBox ID="txtTitle" runat="server" CssClass="TextBox  validate[required]" TextMode="MultiLine" Height="50"></asp:TextBox>
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <div class="clear"></div>
                            <div class="col-md-9">
                                <div class="col-md-12 pdl0 b">Mô tả nội dung</div>
                                <div class="col-md-12 pdl0 pdr0">
                                    <div class="telerik-editor">
                                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" Width="100%" CssClass="texteditor" ID="txtSummary" runat="server"
                                            ToolsFile="/Portals/_default/HtmlEditor/PSAEditor.xml" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="16px" Font-Names="Times New Roman" Height="250px">
                                            <CssFiles>
                                                <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                                            </CssFiles>
                                        </telerik:RadEditor>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-6 pdl0 txt-right " style="font-style: italic; color: #e80505; font-size: 14px;">(Chú ý: Nội dung Bút danh, nguồn tin sẽ được đưa vào cuối nội dung tin bài khi xuất bản.)</div>
                                <div class="col-md-2 b right pdt5">Bút danh, nguồn tin</div>
                                <div class="col-md-4 pdr0">
                                    <asp:TextBox ID="NguonTin" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="50"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="col-md-6 b pdl0">Ảnh đại diện</div>
                                <div class="col-md-6">
                                    <a title="Xóa ảnh" id="lbtDelImg" runat="server" class="delimages" onclick="DelAvatar()" style="display: none;"></a>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-12" id="DivAvatar" style="min-height: 150px">
                                    <asp:HiddenField ID="txtImagePath" runat="server" />
                                    <div id="imgDD" style="cursor: pointer;" runat="server" class="seimgselect ImgView list-img" onclick="changekey('avt'); insertavatar(900,550); return false;">
                                        <img class="vImg" src="/image/images/noimage.png?dpi=150&quality=100&w=120" alt="Ảnh đại diện" />
                                    </div>
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="ubox_wrap">
                        <div class="xhead">
                            <b>Danh sách ảnh</b>
                            <a id="page-popupImg" onclick="changekey('lit'); insertalbum(900,600); return false;" title="Chọn ảnh">
                                <img src="/images/icons/folder_image.png" alt="Chọn ảnh" id="btImg" runat="server" visible="true" />
                            </a>
                        </div>
                        <div id="aenndx1" class="xbody1 commonx1">
                            <div class="col-md-12 pdt10">
                                <table class="addImg" id="tbl_albumimg">
                                    <tbody>
                                        <tr class="hdTitle">
                                            <td style="text-align: center; width: 5%;">STT</td>
                                            <td style="text-align: center; width: 5%;">Xóa</td>
                                            <td style="width: 20%;">Ảnh đại diện</td>
                                            <td style="width: 70%;">Ghi chú</td>
                                        </tr>
                                        <asp:Literal runat="server" ID="lrAlbum"></asp:Literal>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="col-md-7 pdl0">
                            <div class="ubox_wrap">
                                <div class="xhead"><b>Đặt lịch xuất bản, tin nổi bật, từ khóa</b></div>
                                <div class="xbody commonx" id="aenlybp1">
                                    <div class="col-md-6 col-xs-6  pdr0">
                                        <asp:CheckBox ID="chkCare" CssClass="csHot" runat="server" Text="Tin nóng trang chủ"></asp:CheckBox>
                                    </div>
                                    <div class="col-md-6 col-xs-6 pdr0">
                                        <asp:CheckBox ID="chkHotCat" CssClass="csHotCat" runat="server" Text="Tin nóng chuyên mục"></asp:CheckBox>
                                    </div>
                                    <div class="none">
                                        <asp:CheckBox ID="chkIsFocus" CssClass="csFocus" runat="server" Text="Tin thời sự"></asp:CheckBox>
                                        <asp:CheckBox ID="chkIsEvent" CssClass="csEvent" runat="server" Text="Tin nóng thời sự"></asp:CheckBox>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-3  pdl0 pdr0">
                                        <div class="col-md-12 b">Lịch xuất bản</div>
                                        <div class="col-md-12 pdr0">
                                            <div class="rccalpopup date-pub">
                                                <asp:TextBox ID="txtPublishDate" runat="server" Width="115px" CssClass="timepicker" PlaceHolder="Ngày xuất bản"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-9 pdr0">
                                        <div class="col-md-12 b">Từ khóa</div>
                                        <div class="col-md-12 pdr0">
                                            <input type="text" value="" id="IdTags" runat="server" class="IdTags TextBox" data-role="tagsinput" />
                                        </div>
                                    </div>
                                    <div class="col-md-4 pdr0 none">
                                        <div class="col-md-12 b">Tác giả bài viết</div>
                                        <div class="col-md-12 pdr0">
                                            <asp:DropDownList ID="WriterName" data-actions-box="true" multiple="multiple" runat="server" CssClass="WriterName selectpicker"></asp:DropDownList>
                                            <asp:HiddenField ID="hdWriterName" runat="server" ClientIDMode="Static" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                </div>
                            </div>
                            <div class="clear"></div>
                            <asp:Panel CssClass="ubox_wrap" ID="pnButPhe" runat="server" Visible="true">
                                <div class="xhead">
                                    <b>
                                        <asp:Literal ID="labBP" runat="server" Text="Bút phê" /></b>
                                </div>
                                <div class="xbody commonx" id="aenlybp">
                                    <div class="w-control">
                                        <div class="col-md-12 pdr0">
                                            <div class="id-but-phe">
                                                <asp:Literal ID="litButPhe" runat="server" />
                                            </div>
                                        </div>
                                        <asp:Panel ID="pnAddBp" runat="server" Visible="true">
                                            <div class="col-md-10">
                                                <asp:TextBox ID="txtButPhe" runat="server" onchange="removescript(this)" TextMode="MultiLine" Height="60px" CssClass="TextBox txtButPhe"></asp:TextBox>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:Button ID="cmdButPhe" runat="server" Text="Lưu ghi chú" OnClientClick="return butphe()" CssClass="cmdbtt cmdSave" />
                                            </div>
                                        </asp:Panel>
                                        <div class="clear"></div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <div class="clear"></div>
                        </div>
                        <div class="col-md-5 ">
                            <div class="ubox_wrap">
                                <div class="xhead">
                                    <b>Tin ảnh liên quan</b>
                                    <a onclick="popupwindow(900,600); return false;" title="Chọn tin liên quan">
                                        <img src="/images/icons/note_go.png" alt="Chọn ảnh" id="Img1" runat="server" />
                                    </a>
                                </div>
                                <div class="xbody1x commonx1x psa-row">
                                    <div class="list-lq" style="float: left; padding-top: 5px" id="divrelated">
                                        <ul style="padding-left: 0px">
                                            <asp:Repeater runat="server" ID="rptRelated">
                                                <ItemTemplate>
                                                    <li>
                                                        <a href="#"><%# Eval("Title")%> </a>
                                                        <a class="delRelated" onclick="javascript:delRl(this,<%# Eval("NewId")%>);" title="Remove this?" style="cursor: pointer;"></a>
                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>
                                    </div>
                                    <div class="clear"></div>
                                </div>
                            </div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <%--Nhuận bút--%>
                    <div class="ubox_wrap" id="pnNhuanBut" runat="server" visible="false">
                        <div class="xhead"><b>Chấm nhuận bút</b></div>
                        <div class="xbody commonx" id="nhuanbut1">
                            <div class="col-md-12">
                                <div class="col-sm-2 pdt5 b">Định mức tin tin bài</div>
                                <div class="col-sm-3">
                                    <asp:DropDownList onchange="loadMoneyTin();" ID="drMaDMTin" Width="100%" runat="server" ClientIDMode="Static"  CssClass="selectpicker"></asp:DropDownList>
                                </div>
                                <div class="col-sm-7">
                                    <span style="background: #ff6a00; color: #fff; padding: 7px 16px; float: left; height: 31px;" class="lblTienTin"></span>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <table class="addImg" id="datatable">
                                    <tbody>
                                        <tr class="hdTitle" style="text-align: center">
                                            <td style="width: 5%;">STT</td>
                                            <td style="width: 30%;">Định mức ảnh</td>
                                            <td style="width: 15%;">Hệ số</td>
                                            <td style="width: 15%;">Số lượng</td>
                                            <td style="width: 15%;">Đơn giá</td>
                                            <td style="width: 20%;">Tiền nhuận bút</td>
                                        </tr>
                                        <asp:Literal ID="litNB" runat="server" />
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div style="clear: both; height: 5px"></div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:HiddenField ID="ItemID" runat="server" />
        <asp:HiddenField ID="WF_DEFAULT" runat="server" />
        <asp:HiddenField ID="WF_TO1" runat="server" Value="0" Visible="false" />
        <asp:HiddenField ID="WF_TO2" runat="server" Value="0" Visible="false" />
        <asp:HiddenField ID="WF_TO3" runat="server" Value="0" Visible="false" />

        <asp:HiddenField ID="WF_STATUS" Value="0" runat="server" />

        <asp:HiddenField ID="WF_BACK1" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK2" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK3" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK4" Value="0" runat="server" />

        <asp:HiddenField ID="WF_ROLE" Value="0" runat="server" />
        <asp:HiddenField ID="WF_PUBNOW" Value="0" runat="server" />
        <asp:HiddenField ID="hdf_Category" runat="server" />
        <asp:HiddenField ID="hdf_Related" runat="server" />
        <asp:HiddenField ID="hdf_Tags" runat="server" />
        <asp:HiddenField ID="_HTTPAlias" runat="server" />
        <asp:HiddenField ID="NB_ID" runat="server" />
        <asp:HiddenField ID="UrlReferrer" runat="server" />
        <asp:HiddenField ID="lockNews" runat="server" Value="False" />
        <asp:HiddenField ID="butPhe" runat="server" />
        <asp:HiddenField ID="User_Name" runat="server" />
        <div class="WriterFullName"></div>

    </div>
    <link href="/js/tags/bootstrap-tagsinput.css?v=2" rel="stylesheet" type="text/css" />
    <script src="/js/tags/bootstrap-tagsinput.min.js?v=2"></script>
    <script type="text/javascript">
        window.onbeforeunload = function () {
            if ($("#<%=lockNews.ClientID %>").val() == "True") {
                var id = $("#<%=ItemID.ClientID %>").val(); var pid = $("#<%=ddlPortal.ClientID %>").val();
                var link = "/api/admin/unlock.ashx?id=" + id + "&pid=" + pid + "&u=" + $("#<%=User_Name.ClientID %>").val(), msg = $.ajax({ url: link, async: false }).responseText;
            }
        };
        function saveNB(pid, NewsID) {
            var DM_ID = $("#<%=drMaDMTin.ClientID%>").val(); var NB_ID = $("#<%=NB_ID.ClientID%>").val();
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/SaveNB',
                data: { NB_ID: NB_ID, pid: pid, NewsID: NewsID, DM_ID: DM_ID },
                success: function (response) {
                    if (response.mesage = "success") {
                        console.log(response.data);
                        $('.tr-nb-row').each(function (i) {
                            var id = $(this).attr("id"); var MaDM = $(".MaDM-" + id).html();
                            var HeSo = $(".HeSo-" + id).html(); var SoLuong = $(".SoLuong-" + id).val();
                            var DonGia = $(".DonGia-" + id).html(); var IsMoney = $(".money-" + id).html();
                            $.ajax({
                                type: "POST", url: '/api/admin/nhuanbut.asmx/SaveNBDetail',
                                data: { NewsNB_ID: response.data, pid: pid, id: id, MaDM: MaDM, HeSo: HeSo, SoLuong: SoLuong, DonGia: DonGia, IsMoney: IsMoney },
                                success: function (data) { }
                            });
                        });
                    }
                }, error: function (b) { }
            });
            return false;
        };
        function sendwf(id, pdate, username, wf, wtext) {
            var pid = $("#<%=ddlPortal.ClientID %>").val();
            $.ajax({
                type: "POST", url: '/api/cms/album.asmx/workflow',
                data: "{pco:'" + pid + "', id:'" + id + "', WFID:'" + wf + "', username:'" + username + "', ProcessName:'" + wtext + "', PublishedDate:'" + pdate + "'}",
                contentType: "application/json; charset=utf-8", dataType: "json",
                success: function (msg) { window.location.href = $('#<%=UrlReferrer.ClientID%>').val() + id; }, error: function (b) { }
            });
        };
        function saves(wf, wfid, wtext) {
            if ($('#Form').validationEngine('validate') == true) {                //debugger;
                //wf = 1: Gưi theo quy trình ; sv = 1: Đồng bộ dữ liệu
                var Title = $('#<%=txtTitle.ClientID%>').val();
                var notes = $('#<%=butPhe.ClientID%>').val();
                var b = '0';
                var username = $('#<%=User_Name.ClientID %>').val();
                var PortalId = $('#<%=ddlPortal.ClientID %>').val();
                var id = $('#<%=ItemID.ClientID%>').val();
                var cateid = $('#<%=ddlCategory.ClientID%>').val();
                var PublishedDate = $('#<%= txtPublishDate.ClientID%>').val();
                if (PublishedDate != "undefined" && PublishedDate != null && PublishedDate != '') { PublishedDate = Base64.encode(PublishedDate); }
                var editor = $find('<%=txtSummary.ClientID%>');
                var fd = new FormData();
                fd.append("id", id);
                fd.append("cateid", cateid);
                fd.append("pid", PortalId);
                fd.append("username", username);
                fd.append("PublishedDate", $('#<%= txtPublishDate.ClientID%>').val());
                fd.append("ImagePath", $('#<%=txtImagePath.ClientID%>').val());
                fd.append("IsCare", document.getElementById('<%=chkCare.ClientID %>').checked);
                fd.append("IsEvent", document.getElementById('<%=chkIsEvent.ClientID %>').checked);
                fd.append("IsFocus", document.getElementById('<%=chkIsFocus.ClientID %>').checked);
                fd.append("Hotcat", document.getElementById('<%=chkHotCat.ClientID %>').checked);
                fd.append("NguonTin", $('#<%=NguonTin.ClientID%>').val());
                fd.append("Links", $('#<%=hdf_Related.ClientID%>').val());
                fd.append("Tags", $('#<%=hdf_Tags.ClientID%>').val());
                fd.append("Title", Title);
                fd.append("Summary", editor.get_html());
                fd.append("Notes", notes);

                $.ajax({
                    type: "POST", url: '/api/cms/album.asmx/savenews',
                    enctype: 'multipart/form-data', contentType: false, processData: false, cache: false, data: fd,
                    success: function (data) {
                        id = $(data).find("string").text();
                        $('#<%=ItemID.ClientID%>').val(id);
                        //saveNB(PortalId, id);
                        savealbum(PortalId, id, cateid);
                        if (wf == "1") {
                            debugger;
                            sendwf(id, PublishedDate, username, wfid, wtext);
                        }
                        notify('success', 'Đã cập nhật thông tin thành công.', 'Thông báo', false);
                    }, error: function (b) { }
                });
            }
        };
        function savealbum(pid, newid, catid) {
            $('.new-row-album').each(function (e) {
                var fd = new FormData();
                var img = $(this).find(".album-img").attr("src");
                fd.append("pco", pid);
                fd.append("newid", newid);
                fd.append("catid", catid);
                fd.append("id", $(this).attr("id"));
                fd.append("stt", $(this).find(".album-stt").val());
                fd.append("img", img);
                fd.append("username", $('#<%=User_Name.ClientID %>').val());
                fd.append("nameimg", $(this).find(".album-name").attr("title"));
                fd.append("dec", $(this).find(".mota").val());
                fd.append("url", $(this).find(".album-url").val());
                if (img != "undefined") {
                    $.ajax({
                        type: "POST", url: '/api/cms/album.asmx/savealbum',
                        enctype: 'multipart/form-data', contentType: false, processData: false, cache: false, data: fd,
                        success: function (data) { }, error: function (b) { }
                    });
                }
            });
        };
        $(document).ready(function () {
            if ($("#DivAvatar img").attr("src") == "" || $("#DivAvatar img").attr("src") == null) { $("#DivAvatar img").attr("src", "/image/images/noimage.png?dpi=150&quality=100&w=120"); }
            var n = document.getElementById('<%=txtImagePath.ClientID %>').value;
            if (n.length > 3) { $(".delimages").css("display", "block"); }
        });
        function DelAvatar() { $("#DivAvatar img").attr("src", "/image/images/noimage.png?dpi=150&quality=100&w=120"); $("#DivAvatar input[type='hidden']").val(""); $(".delimages").css("display", "none"); };
        //POP-UP
        function popuppreview() { var item = $('#<%=ItemID.ClientID%>').val(); var pid = $('#<%=ddlPortal.ClientID%>').val(); preview(item, pid); };
        function delRlImg(t, id) {
            if (confirm("Bạn có chắc chắn muốn xóa ảnh này không?") == true) {
                var pid = $("#<%=ddlPortal.ClientID %>").val();
                var link = "/api/cms/delete.ashx?id=" + id + "&pid=" + pid; var msg = $.ajax({ url: link, async: false }).responseText; $(t).parents(".new-row-album").remove();
            }
        };
        var thread;
        function insertavatar(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (thread) == "undefined") {
                    thread = new Worker("/js/worker.js");
                    thread.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            thread.terminate(); thread = undefined;
                            $('#<%= txtImagePath.ClientID %>').val("");
                            if (addValue('<%= txtImagePath.ClientID %>', result)) {
                                $('.list-img img').remove();
                                $('.list-img').append('<img class="imgDd" width="120" height="120" src="<%=VBN.flConnect.fileDomain%>' + result + '?dpi=150&quality=100" />');
                                $(".delimages").css("display", "block");
                            }
                        }
                    };
                }
            }

            var newid = $("#<%=ItemID.ClientID %>").val();
            return window.open("<%=VBN.flConnect.fileDomain %>/files/default.aspx?v=img&newid=" + newid + "&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function indextt() { var key = 0, idex = 0; $('.sv-ab').each(function (e) { key = $(this).attr("value"); if (parseFloat(key) > parseFloat(idex)) { idex = key; } }); return parseFloat(idex) + 1; };
        //album image
        function insertalbum(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (thread) == "undefined") {
                    thread = new Worker("/js/worker.js");
                    thread.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            thread.terminate(); thread = undefined;
                            var arr = new Array(); arr = result.split("@_@");
                            var intI = indextt();
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var pathImg = arr[i].split("|")[0];
                                    str = '<tr class="new-row-album" id="0">';
                                    str += '<td><input type="text" name="stt" class="sv-ab album-stt" style="width:80%;text-align:center" value="' + intI + '" /></td>';
                                    str += "<td style='text-align:center;'><a class='delRelated' style='cursor: pointer;margin: 0 auto;float:none' onclick='delRlImg(this," + intI + ");' title='Xóa ảnh?' style='cursor:pointer;'></a></td>";
                                    str += '<td style="text-align:center"><img width="130" class="album-img" src="<%=VBN.flConnect.fileDomain%>' + pathImg + '?dpi=150&quality=100"/></td>';
                                    str += '<td><textarea style="width:98%;height:100%" class="mota" name="ghichu" type="text"></textarea>';
                                    str += '<br/><div class="sp-ab">Link liên kết</div><br/>';
                                    str += '<input type="text" name="url" class="sv-ab TextBox album-url" style="width:100%;" /></td>';
                                    str += '<td style="display:none;"><p class="album-name" title="' + pathImg + '"></p></td>';
                                    str += '</tr>';
                                    $('#tbl_albumimg').append(str);
                                    intI = intI + 1;
                                }
                            }
                            $(".IdKey").html("");
                        }
                    };
                }
            }

            var newid = $("#<%=ItemID.ClientID %>").val();
            return window.open("<%=VBN.flConnect.fileDomain %>/files/default.aspx?v=img&newid=" + newid + "&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function isNumber(evt) { evt = (evt) ? evt : window.event; var charCode = (evt.which) ? evt.which : evt.keyCode; if (charCode > 31 && (charCode < 48 || charCode > 57)) { return false; } return true; };
        var preVal;
        function popupwindow(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), PId = $('#<%= ddlPortal.ClientID%>').val();
            return window.open("/desktopmodules/module/cms/config/news.aspx?portalid=" + PId + "&s=settingsphongsuanh", "Chọn tin liên quan", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left);
        };
        function HandlePopupResult(result) {
            var arr = new Array(); arr = result.split(";");
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] != null && arr[i] != '') {
                    var sid = arr[i].split("|")[0]; var stitle = Base64.decode(arr[i].split("|")[1]); addValue('<%= hdf_Related.ClientID %>', sid);
                    $('.list-lq ul').append('<li><a href="#"> ' + stitle + '</a><a class="delRelated" onclick="javascript:delRl(this,' + sid + ');" title="Xóa" style="cursor:pointer;"></a></li>');
                }
            }
        };
        function delRl(sender, id) { if (confirm("Bạn có chắc chắn muốn xóa phóng sự liên quan không?") == true) { removeValue('<%= hdf_Related.ClientID %>', id); $(sender).parent().remove(); return false; } };
        function removeValue(id, value) {
            var arrTemp = $('#' + id).val(); var sResult = ""; var arr = new Array(); arr = arrTemp.split(";");
            for (var i = 0; i < arr.length; i++) { if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; } }
            $('#' + id).val(sResult.substring(1, sResult.length));
        };
        function addValue(id, value) { if ($('#' + id).val().indexOf(value) == -1) { if ($('#' + id).val() == '' || $('#' + id).val() == null) $('#' + id).val(value); else $('#' + id).val($('#' + id).val() + ';' + value); } };
        function updateTags() { $('#<%=hdf_Tags.ClientID %>').val($('.IdTags').val()); };
        jQuery(document).ready(function () {
            $(".cmcoption  option:not(:contains('--'))").addClass("strongtxt");
            jQuery("[cid]").each(function () { var me = jQuery(this); var cid = me.attr("cid"); var state = jQuery.cookie(cid); if (state == 'hide') { me.hide(); } else { me.show(); } });

            jQuery(".xhead").unbind("click"); jQuery(".xhead").bind("click", function () { var me = jQuery(this); var body = me.parent().find(".xbody"); var cid = body.attr("cid"); if (cid == "" || cid == null) { body.toggle(); return; } var state = jQuery.cookie(cid); if (state == 'hide') { jQuery.cookie(cid, ""); body.show(); } else { jQuery.cookie(cid, "hide"); body.hide(); } });
            $("#hideboxtag").attr("style", "display:none"); $("#aenlybps").attr("style", "display:none");

        });
        var PortalID = $("#<%=ddlPortal.ClientID %>").val(); var itemid = $("#<%=ItemID.ClientID %>").val();
        if (itemid != "") {
            var dmID = $("#<%=drMaDMTin.ClientID %>").val();
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + dmID + "','ItemID':'" + itemid + "','type':'<%=CMS.CategoryType.Album%>' }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });
            var loadMoneyTin = function () {
                var dmID = $("#<%=drMaDMTin.ClientID %>").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.Album%>'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        } else {
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.Album%>'  }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });
            var loadMoneyTin = function () {
                var dmID = $("#<%=drMaDMTin.ClientID %>").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.Album%>'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        };
        function butphe() {
            var txt = $(".txtButPhe").val();
            if (txt != "") {
                var user = "<%=Me.UserInfo.DisplayName%>"; var date = "<%=Now %>"; var htl = "<div class='nd-bp'>" + txt + "</div>";
                htl += "<div class='gc-bp'>" + user + " - " + date + "</div>"; $(".id-but-phe").append(htl); $(".txtButPhe").val("")
            }
            else { alert("Bạn chưa nhập vào nội dung bút phê.") }
            $("#<%=butPhe.ClientID%>").val($(".id-but-phe").html());
            return false;
        };
        function updatePrice(heso, price, t, id) { var total = parseFloat($(t).val()) * parseFloat(heso) * parseFloat(price); $('.money-' + id).html(total); };
    </script>
</div>
<asp:Literal ID="lbmsg" runat="server" />
