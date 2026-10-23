<%@ Control EnableViewState="true" Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Edit_Media.ascx.vb" Inherits="DesktopModules.Media.Manager.Edit_Media" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div id="newContents" runat="server">
    <div class="box box-info">
        <div class="box-header with-border ">
            <div class="col-md-12">
                <h3 class="box-title">
                    <asp:Literal ID="litTitle" runat="server"></asp:Literal></h3>
            </div>
        </div>
        <div class="box-body">
            <div class="main-body">
                <div class="col-md-8">
                    <div class="ubox_wrap">
                        <div class="xhead"><b>Thông tin chi tiết</b></div>
                        <div class="row pdt10">
                            <div class="row">
                                <div class="col-md-12 b">Chọn phân hệ</div>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlPortal" CssClass="selectpicker  validate[required]" runat="server" AutoPostBack="true"></asp:DropDownList>
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="col-md-12 b">Phân loại</div>
                                    <div class="col-md-12">
                                        <asp:DropDownList runat="server" CssClass="selectpicker validate[required]" ID="ddlType" Width="100%"></asp:DropDownList>
                                        <span class="required"></span>
                                    </div>
                                </div>
                                <div class="col-md-6 pdr0">
                                    <div class="col-md-12 b">Chuyên mục</div>
                                    <div class="col-md-12">
                                        <asp:DropDownList ID="ddlDanhmuc" CssClass="selectpicker cmcoption validate[required]" runat="server" Width="100%"></asp:DropDownList>
                                        <span class="required"></span>
                                    </div>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                            <div class="row">
                                <div class="col-sm-9">
                                    <div class="col-md-12 b">Tên video, audio </div>
                                    <div class="col-md-12">
                                        <asp:TextBox ID="txtTitle" runat="server" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="50px"></asp:TextBox>
                                        <span class="required"></span>
                                    </div>
                                    <div class="col-md-12 b">Tóm tắt</div>
                                    <div class="col-md-12">
                                        <asp:TextBox ID="txtSummary" runat="server" TextMode="MultiLine" Height="145px" CssClass="TextBox"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-3 pdr0">
                                    <div class="col-md-12" id="mediaAvatar">
                                        <div class="row">
                                            <div class="b pdb10 ">Ảnh đại diện</div>
                                            <span style="float: right;">
                                                <a title="Xóa ảnh" id="lbtDelImg" runat="server" onclick="DelAvatar()" class="delimages" style="display: none;"></a>
                                            </span>
                                        </div>
                                        <asp:HiddenField ID="txtImagePath" runat="server" />
                                        <div id="imgDD" style="cursor: pointer;" runat="server" class="seimgselect ImgView list-img" onclick="changekey('avt'); insertavatar(900,550); return false;">
                                            <img class="vImg" src="/image/images/noimage.png?w=120" alt="Ảnh đại diện" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 b">Lịch xuất bản</div>
                                    <div class="col-md-12">
                                        <div class="rccalpopup">
                                            <asp:TextBox ID="txtPublishDate" runat="server" CssClass="timepicker" PlaceHolder="Ngày xuất bản"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="col-md-12 pdt10">
                                        <asp:CheckBox ID="IsHome" CssClass="csHot" runat="server" Text="Tin nóng trang chủ"></asp:CheckBox>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="none">
                                    <asp:CheckBox ID="IsHot" CssClass="csFocus" runat="server" Text="Tin thời sự"></asp:CheckBox>
                                    <asp:CheckBox ID="IsPage" CssClass="csHotCat" runat="server" Text="Tin nóng chuyên mục"></asp:CheckBox>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:HiddenField ID="hdfMedia" runat="server" />
                                    <asp:Panel ID="pnaVideo" runat="server" CssClass="clAudio">
                                          <div class="b">
                                            <asp:CheckBox ID="chkYoutube" runat="server" Text="Là nguồn từ Youtube" Checked="true" ></asp:CheckBox>
                                        </div>
                                        <asp:Button runat="server" ID="bCMS_Media" CssClass="bt-chon video-bt none" OnClientClick="changekey('video'); insertmedia(900, 550); return false;" Text="Chọn video" />
                                        <asp:Button runat="server" ID="btnMulti" CssClass="bt-chon video-bt none" OnClientClick="changekey('multi'); insertmulti(900, 550); return false;" Text="Chọn multimedia" />
                                      
                                        <div class="control media-youtube" id="ytb" runat="server">
                                            <asp:TextBox ID="txtlinkYotube" CssClass="TextBox" runat="server" Width="235px"></asp:TextBox>
                                            <div style="clear: both; font-size: 11px;">
                                                (VD: www.youtube.com/watch?v=<span style="color: Red; font-weight: bold;">dyQA6a7YE</span>)
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="pnaAudio" runat="server" CssClass="clAudio" Visible="false">
                                        <asp:Button runat="server" CssClass="bt-chon" ID="btnAudio" OnClientClick="changekey('audio'); insertaudio(900, 500); return false;" Text="Chọn audio" />
                                        <asp:Button runat="server" ID="btnAudiomulti" CssClass="bt-chon" OnClientClick="changekey('admul'); insertadmul(900, 550); return false;" Text="Chọn multimedia" />
                                    </asp:Panel>

                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                    <div class="div-view-video">
                        <div id="viewMedia" runat="server" class="view-media">
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="ubox_wrap">
                        <div class="xhead1">
                            <asp:Literal ID="MediaRela" runat="server" />
                        </div>
                        <div class="commonx" style="height: 180px; overflow: auto; border: 1px solid #ccc; background-color: #fff">
                            <div class="list-lq" id="divrelated">
                                <ul style="padding-left: 0px">
                                    <asp:Repeater runat="server" ID="rptRelated">
                                        <ItemTemplate>
                                            <li>
                                                <a href="#"><%# Eval("Name")%> </a>
                                                <a class="delRelated" onclick="javascript:delRl(this,<%# Eval("ID")%>);" title="Remove this?" style="cursor: pointer;"></a>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <%--Tags của tin tức--%>
                    <div style="clear: both; height: 5px"></div>
                    <div class="ubox_wrap">
                        <div class="xhead"><b>Từ khóa</b></div>
                        <div style="clear: both; height: 5px"></div>
                        <div class="col-md-12">
                            <input type="text" value="" id="IdTags" runat="server" class="IdTags" data-role="tagsinput" />
                        </div>
                        <div style="clear: both;"></div>
                        <div class="col-md-12 none">
                            <div class="b">Tác giả bài viết</div>
                            <asp:DropDownList ID="WriterName" data-actions-box="true" multiple="multiple" runat="server" CssClass="WriterName selectpicker"></asp:DropDownList>
                            <asp:HiddenField ID="hdWriterName" runat="server" ClientIDMode="Static" />
                        </div>
                    </div>
                    <div style="clear: both; height: 5px"></div>
                    <asp:Panel CssClass="ubox_wrap" ID="pnButPhe" runat="server" Visible="true">
                        <div class="xhead">
                            <b>
                                <asp:Literal ID="labBP" runat="server" Text="Bút phê tin bài" /></b>
                        </div>
                        <div style="padding-top: 10px">
                            <div class="w-control">
                                <div class="col-md-12">
                                    <div class="id-but-phe">
                                        <asp:Literal ID="litButPhe" runat="server" />
                                    </div>
                                </div>
                                <asp:Panel ID="pnAddBp" runat="server" Visible="true">
                                    <div class="col-md-12">
                                        <asp:TextBox ID="txtButPhe" runat="server" TextMode="MultiLine" Height="60px" CssClass="TextBox txtButPhe"></asp:TextBox>
                                    </div>
                                    <div class="col-md-12">
                                        <asp:Button ID="cmdButPhe" runat="server" Text="Lưu ghi chú" OnClientClick="return butphe()" CssClass="cmdbtt cmdSave" />
                                    </div>
                                </asp:Panel>
                                <div class="clear"></div>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
                <div style="clear: both"></div>
                <div class="col-md-12">
                    <div class="ubox_wrap" id="nhuanbut" runat="server" visible="false">
                        <div class="xhead"><b>Chấm nhuận bút</b></div>
                        <div class="xbody commonx" id="nhuanbut1">
                            <div class="row">
                                <div class="col-md-2 pdt5 b">Định mức tin tin bài</div>
                                <div class="col-md-4">
                                    <asp:DropDownList onchange="loadMoneyTin();" ID="drMaDMTin" Width="100%" runat="server" ClientIDMode="Static"  CssClass="selectpicker"></asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <span style="background: #ff6a00; color: #fff; padding: 7px 16px; float: left; height: 31px;" class="lblTienTin"></span>
                                </div>
                            </div>
                            <asp:DataGrid ID="grdDMAnh" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="ID" Visible="false">
                                        <ItemTemplate>
                                            <asp:Literal ID="ID" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Định mức ảnh">
                                        <ItemTemplate>
                                            <asp:Literal ID="drMaDMAnh" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Hệ số">
                                        <ItemTemplate>
                                            <asp:Literal ID="HeSo" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="HeSo respo-view" />
                                        <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="HeSo respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Số lượng">
                                        <ItemTemplate>
                                            <telerik:RadNumericTextBox ID="SoLuong" Width="100%" Value="0" runat="server" CssClass="grdtxt center soluong" NumberFormat-AllowRounding="false" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="SoLuong respo-view" />
                                        <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="SoLuong respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Đơn giá">
                                        <ItemTemplate>
                                            <asp:Literal ID="DonGia" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="DonGia respo-view" />
                                        <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="DonGia respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tiền nhuận bút">
                                        <ItemTemplate>
                                            <telerik:RadNumericTextBox ID="IsMoney" Width="100%" Value="0" runat="server" ReadOnly="true" CssClass="grdtxt center money-div monney" NumberFormat-AllowRounding="false" />
                                        </ItemTemplate>
                                        <ItemStyle Width="20%" HorizontalAlign="Center" CssClass="IsMoney respo-view" />
                                        <HeaderStyle Width="20%" HorizontalAlign="Center" CssClass="IsMoney respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:HiddenField ID="ItemId" runat="server" />
        <asp:HiddenField ID="NB_ID" runat="server" />
        <asp:HiddenField ID="NBType" runat="server" />
        <asp:HiddenField ID="hdf_Tags" runat="server" />
        <asp:HiddenField ID="butPhe" runat="server" />
        <asp:HiddenField ID="New_STATUS" Value="0" runat="server" Visible="false" />
        <asp:HiddenField ID="WF_DEFAULT" Value="0" runat="server" Visible="false" />
        <asp:HiddenField ID="WF_STATUS" Value="0" runat="server" Visible="false" />
        <asp:HiddenField ID="WF_BACK1" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK2" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK3" Value="0" runat="server" />
        <asp:HiddenField ID="WF_ROLE" Value="0" runat="server" />
        <asp:HiddenField ID="WF_PUBNOW" Value="0" runat="server" />
        <asp:HiddenField ID="WF_TYPE" Value="0" runat="server" Visible="false" />
        <asp:HiddenField ID="hdf_Related" runat="server" />
        <asp:Label ID="lbResult" runat="server" />

    </div>
    <div class="fix-btt-toolbar">
        <div>
            <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach')" />
            <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return checkinput();" />
            <asp:Button ID="cmdRun" runat="server" Text="Thực hiện" CssClass="cmdbtt cmdRun1" />
            <asp:Button ID="cmdPUBNOW" runat="server" Visible="false" Text="Xuất bản ngay" CssClass="cmdbtt cmdRun" OnClientClick="updateTags(); return checkinput();" />

            <asp:Button ID="cmdBack1" runat="server" Visible="false" Text="Trả lại" CssClass="cmdbtt cmdBack" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdBack2" runat="server" Visible="false" Text="Trả lại" CssClass="cmdbtt cmdBack2" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdBack3" runat="server" Visible="false" Text="Trả lại" CssClass="cmdbtt cmdBack3" OnClientClick="updateTags(); return checkinput();" />

            <asp:Button ID="cmdStop" runat="server" Visible="false" Text="Ngừng xuất bản" CssClass="cmdbtt cmdStop" OnClientClick="return $('#Form').validationEngine('detach');" />
            <asp:Button ID="cmdDel" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
            <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" OnClientClick="return $('#Form').validationEngine('detach')" />
        </div>
    </div>
    <link href="/js/tags/bootstrap-tagsinput.css?v=2" rel="stylesheet" type="text/css" />
    <script src="/js/tags/bootstrap-tagsinput.min.js?v=2"></script>
    <script type="text/javascript">
        function popupRelated(page, w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), PId = $('#<%= ddlPortal.ClientID%>').val();
            return window.open("/desktopmodules/module/cms/config/" + page + ".aspx?portalid=" + PId, "Chèn Img - Audio - Video", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left);
        };
        function removeValue(id, value) {
            var arrTemp = $('#' + id).val(); var sResult = ""; var arr = new Array();
            arr = arrTemp.split(";");
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; }
            }
            $('#' + id).val(sResult.substring(1, sResult.length));
        };
        function HandlePopupResult(result) {
            var arr = new Array(); arr = result.split(";");
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] != null && arr[i] != '') {
                    var sid = arr[i].split("|")[0]; var stitle = Base64.decode(arr[i].split("|")[1]);
                    if (addValue('<%= hdf_Related.ClientID %>', sid)) {
                        $('.list-lq ul').append('<li><a href="#"> ' + stitle + '</a> <a class="delRelated" onclick="javascript:delRl(this,' + sid + ');" title="Xóa tin liên quan?" style="cursor:pointer;"> </a></li>');
                    }
                }
            }
        };
        function delRl(sender, id) { if (confirm("Bạn có muốn xóa tin liên quan này không?") == true) { removeValue('<%= hdf_Related.ClientID %>', id); $(sender).parent().remove(); return false; } };
        var PortalID = $("#<%=ddlPortal.ClientID %>").val(); var itemid = $("#<%=ItemId.ClientID %>").val(); var NBType = $("#<%=NBType.ClientID%>").val();
        if (itemid != "") {
            var selectedOption = $("#drMaDMTin option:selected").val();
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'" + itemid + "','type':'" + NBType + "' }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });
            var loadMoneyTin = function () {
                var selectedOption = $("#drMaDMTin option:selected").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'" + NBType + "'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        } else {
            var selectedOption = $("#drMaDMTin option:selected").val();
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'" + NBType + "'  }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });

            var loadMoneyTin = function () {
                var selectedOption = $("#drMaDMTin option:selected").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'" + NBType + "'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        };
        function updatePrice(heso, price, t, id) {
            var total = parseFloat($(t).val()) * parseFloat(heso) * parseFloat(price);
            $('.money-' + id).val(total);
        };
        function checkinput() { getmultile(); return $('#Form').validationEngine('validate'); };
        function updateTags() { $('#<%=hdf_Tags.ClientID %>').val($('.IdTags').val()); };
        function butphe() {
            var txt = $(".txtButPhe").val();
            if (txt != "") {
                var user = "<%=Me.UserInfo.DisplayName%>"; var date = "<%=Now %>"; var htl = "<div class='nd-bp'>" + txt + "</div>";
                htl += "<div class='gc-bp'>" + user + " - " + date + "</div>"; $(".id-but-phe").append(htl); $(".txtButPhe").val("")
            }
            else { alert("Bạn chưa nhập vào nội dung bút phê cho tin bài.") }
            $("#<%=butPhe.ClientID%>").val($(".id-but-phe").html());
            return false;
        };

        jQuery(document).ready(function () {
            jQuery("[cid]").each(function () {
                var me = jQuery(this); var cid = me.attr("cid"); var state = jQuery.cookie(cid);
                if (state == 'hide') { me.hide(); }
                else { me.show(); }
            });

            jQuery(".xhead").unbind("click");
            jQuery(".xhead").bind("click", function () {
                var me = jQuery(this); var body = me.parent().find(".xbody"); var cid = body.attr("cid");
                if (cid == "" || cid == null) { body.toggle(); return; }
                var state = jQuery.cookie(cid);
                if (state == 'hide') { jQuery.cookie(cid, ""); body.show(); }
                else { jQuery.cookie(cid, "hide"); body.hide(); }
            });
            $("#hidebox2").attr("style", "display:none");
            $(".cmcoption  option:not(:contains('--'))").addClass("strongtxt")
        });
        function GetDateStamp() {
            var d = new Date();
            var month = d.getMonth() + 1, day = d.getDate(), hour = d.getHours(), minute = d.getMinutes();
            var output = (('' + day).length < 2 ? '0' : '') + day + '/' + (('' + month).length < 2 ? '0' : '') + month + '/' + d.getFullYear() + ' - ' + (('' + hour).length < 2 ? '0' : '') + hour + ':' + (('' + minute).length < 2 ? '0' : '') + minute;
            return output;
        };
        function OpenMSGDialog() {
            $("#dialog-msg").dialog({ title: "Thông tin", width: 700, height: 250, modal: false, position: { my: "top", at: "top", of: window } });
            $("#dialog-msg").parent().appendTo($("form:first"));
        };
        function CloseMSGDialog() { $("#dialog-msg").dialog("destroy"); $("form:first").remove('#dialog-msg'); };
        var anhdd = document.getElementById('<%=txtImagePath.ClientID %>').value;
        var imgDD = '';
        function cdel() { $(".use-del").each(function () { $(this).removeAttr("xoaclink"); $(this).attr("onclick", "tbtdel(this)"); }); }

        $(document).ready(function () {
            if ($(".ImgView img").attr("src") == "" || $(".ImgView img").attr("src") == null) {
                $(".ImgView img").attr("src", "/image/images/noimage.png?w=120");
            }
            var n = document.getElementById('<%=txtImagePath.ClientID%>').value;
            if (n.length > 3) { $(".delimages").css("display", "block"); }
        });
        function DelAvatar() { $("#mediaAvatar img").attr("src", "/image/images/noimage.png?w=120"); $("#mediaAvatar input[type='hidden']").val(""); $(".delimages").css("display", "none"); };
        function setAnhDD(idDiv) {
            var imgpath = $('#' + idDiv + ' a[title="Play"]').attr("class") + "/" + $('#' + idDiv + ' a[title="Play"]').attr("href");
            var imgDD = document.getElementById('<%= imgDD.ClientID%>');
            imgDD.innerHTML = "<img src='" + imgpath + "' width='120px'/>";
            document.getElementById('<%=txtImagePath.ClientID%>').value = imgpath;
        };
        function setAvatar(idDiv) {
            var imgpath = $('#' + idDiv).attr("title");
            var imgDD = document.getElementById('<%= imgDD.ClientID%>');
            imgDD.innerHTML = "<img src='" + imgpath + "' width='120px'/>";
            document.getElementById('<%=txtImagePath.ClientID%>').value = imgpath;
        };

    </script>
    <script>
        var mediath;
        function insertavatar(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (mediath) == "undefined") {
                    mediath = new Worker("/js/worker.js");
                    mediath.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            mediath.terminate(); mediath = undefined;
                            $('#<%= txtImagePath.ClientID %>').val("");
                            if (addValue('<%= txtImagePath.ClientID %>', result)) {
                                $('.list-img img').remove();
                                $('.list-img').append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?w=165&h=130" />');
                                $(".delimages").css("display", "block");
                            }
                            $(".IdKey").html();
                        }
                    };
                }
            }

            var newid = $("#<%=ItemID.ClientID %>").val();
            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&newid=" + newid + "&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Chèn Img - Audio - Video", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };

        //media
        function insertmedia(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (mediath) == "undefined") {
                    mediath = new Worker("/js/worker.js");
                    mediath.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            mediath.terminate(); mediath = undefined;
                            var arr = new Array(); arr = result.split("@_@");
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                    if (addValue('<%= hdfMedia.ClientID%>', stitle)) {
                                        $('.view-media').html('<video width="220" controls><source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="video/mp4"></video>');
                                    }
                                }
                            }
                            $(".IdKey").html("");
                        }
                    };
                }
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=video&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        }
        //insertmulti
        function insertmulti(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (mediath) == "undefined") {
                    mediath = new Worker("/js/worker.js");
                    mediath.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            mediath.terminate(); mediath = undefined;
                            var arr = new Array(); arr = result.split("@_@");
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                    if (addValue('<%= hdfMedia.ClientID%>', stitle)) {
                                        $('.view-media').html('<video width="220" controls><source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="video/mp4"></video>');
                                    }
                                }
                            }
                            $(".IdKey").html("");
                        }
                    };
                }
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=video&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        }
        //audio
        function insertaudio(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (mediath) == "undefined") {
                    mediath = new Worker("/js/worker.js");
                    mediath.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            mediath.terminate(); mediath = undefined;
                            var arr = new Array(); arr = result.split("@_@");
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                    if (addValue('<%= hdfMedia.ClientID%>', stitle)) {
                                        $('.view-media').html('<audio width="220" controls><source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="audio/mpeg"></audio>');
                                    }
                                }
                            }
                            $(".IdKey").html("");
                        }
                    };
                }
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=audio&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        }
        //insertadmul
        function insertadmul(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (Worker) !== "undefined") {
                if (typeof (mediath) == "undefined") {
                    mediath = new Worker("/js/worker.js");
                    mediath.onmessage = function (event) {
                        var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                        if (result != "") {
                            mediath.terminate(); mediath = undefined;
                            var arr = new Array(); arr = result.split("@_@");
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                    if (addValue('<%= hdfMedia.ClientID%>', stitle)) {
                                        $('.view-media').html('<audio width="220" controls><source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="audio/mpeg"></audio>');
                                    }
                                }
                            }
                            $(".IdKey").html("");
                        }
                    };
                }
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=audio&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        }
        function deletedash() { if (confirm('Bạn có muốn xóa video/audio này không?') == true) { return true; } else return false; };
        $("#<%=chkYoutube.ClientID%>").change(function () { if ($(".video-bt").hasClass("none") == true) { $(".media-youtube").addClass("none"); $(".video-bt").removeClass("none"); } else { $(".media-youtube").removeClass("none"); $(".video-bt").addClass("none"); } });
        function setmultile() { var values = $('#<%= hdWriterName.ClientID%>').val(); $.each(values.split(','), function (index, element) { $('#<%= WriterName.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected'); $("#<%= WriterName.ClientID%>").trigger('selectpicker:updated'); }); };
        function getmultile() { var id = $("#<%= WriterName.ClientID%>").val(); $('#<%= hdWriterName.ClientID%>').val(id); };
    </script>
</div>

<asp:Literal ID="lbmsg" runat="server" />