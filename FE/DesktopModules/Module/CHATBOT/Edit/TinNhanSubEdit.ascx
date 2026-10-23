<%@ Control Language="vb" CodeFile="TinNhanSubEdit.ascx.vb" Inherits="Modules.TinNhanSubEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<link href="/Portals/_default/chatbot.css?cdv=11" type="text/css" rel="stylesheet" />
<style type="text/css">
    .container ul {
        margin: 0px;
        padding: 0px;
        margin-left: 20px;
    }

    #list1 {
        width: 100%;
        list-style-type: none;
        margin: 0px;
    }

        #list1 li {
            float: left;
            padding: 5px;
            margin: 10px;
        }

            #list1 li div span {
                cursor: move !important;
            }

            #list1 li a {
                position: absolute;
                margin: -5% 0 0 3.5%;
            }

        #list1 div {
            border: solid 1px #ccc;
            text-align: center;
            padding: 10px;
        }

    #list2 {
        float: right;
    }

    .placeHolder div {
        background-color: white !important;
        border: dashed 1px gray !important;
    }

    #fancybox-button {
        color: #fff;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-10">
                    <h3 class="box-title">Thông tin tin nhắn</h3>
                </div>
                <div class="col-md-2">
                    <button type="button" class="btn btn-primary btnAddMessageSub none" data-toggle="modal" data-target="#popMessage">Thêm mới</button>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="clr"></div>
                    <div class="col-md-2 lb i_title">Tên tin nhắn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenBot" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Nội dung</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr m_taptin"></div>
                    <div class="col-md-2 lb m_taptin">Tập tin</div>
                    <div class="col-md-4 m_taptin">
                        <asp:TextBox ID="TapTin" runat="server" CssClass="TextBox fancybox-input" />
                    </div>
                    <div class="col-md-2 m_taptin">
                        <a id="fancybox-button" class="btn btn-primary" type="button" href="<%=EPORTAL.flConnect.cdnDomain%>?context=fancybox">Chọn tập tin</a>
                    </div>
                    <div class="col-md-2 lb m_taptin">Định dạng tập tin</div>
                    <div class="col-md-2 m_taptin">
                         <asp:TextBox ID="KieuTapTin" runat="server" CssClass="TextBox fancybox-input" />
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
                    <div class="clr clUp"></div>
                    <div class="col-md-12 text-center lstMessage none">
                        <ul id="list1">
                            <asp:Repeater ID="repMessage" runat="server">
                                <ItemTemplate>
                                    <li data-itemid='<%# Eval("Id") %>'>
                                        <div class="t_ndtentinnhansub"><span class="btn btn-primary"><%#Eval("TenTinNhanSub") %></span></div>
                                        <div class="t_hinhanh">
                                            <img title="Ảnh đại diện" src=" <%=EPORTAL.flConnect.fileDomain%><%# Eval("Logo")%>" style="height: 40px;">
                                        </div>
                                        <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa tin nhắn này không?');" ClientIDMode="AutoID" ID="lnkChinhSua" runat="server" ToolTip="Xóa tin nhắn"
                                            OnCommand="_ProcessCommand" CommandName="XoaMessage" CommandArgument='<%# Eval("Id")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/close.png?w=20" alt="edit" title="Xóa tin nhắn">
                                        </asp:LinkButton>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
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
            <asp:HiddenField ID="IdKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="IdChatBot" runat="server" Visible="false" />
            <asp:HiddenField ID="IdNhomKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="KieuAdd" runat="server" Visible="false" />
            <asp:HiddenField ID="IdStrSoft" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>


<!-- Modal -->
<div class="modal fade" id="popMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">New message</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-times" aria-hidden="true"></i>
                </button>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group m_tentinnhan">
                        <label for="recipient-name" class="col-form-label lbl_title">Tiêu đề:</label>
                        <asp:TextBox ID="txtTenTinNhanSub" runat="server" CssClass="form-control i_tieude" />
                    </div>
                    <div class="form-group m_kichbanlienket">
                        <label for="message-text" class="col-form-label">Dạng liên kết:</label>
                        <select class="form-control" id="dropkieulk">
                            <option value="0">Liên kết website</option>
                            <option value="1">Liên kết kịch bản</option>
                        </select>
                    </div>
                    <div class="form-group m_kichbanlienket i_kichbanlienket none">
                        <label for="message-text" class="col-form-label">Kịch bản:</label>
                        <asp:DropDownList ID="dropKichBanSub" runat="server" CssClass="selectpicker i_kichbanlienket" />
                    </div>
                    <div class="form-group m_kichbanlienket i_duongdan">
                        <label for="recipient-name" class="col-form-label ">Đường dẫn:</label>
                        <asp:TextBox ID="txtUrlSub" runat="server" CssClass="form-control i_urlsub" />
                    </div>
                    <div class="form-group m_slideanh">
                        <label for="recipient-name" class="col-form-label ">Hình ảnh:</label>
                        <div class="dvimg">
                            <a title="Xóa ảnh" id="lbtDelImg" class="deleteavatar none" onclick="deleteimg('dvimg','lbtDelImg')"></a>
                            <div class="seimgselect" onclick="changekey('avt'); insertavatar(900,550); return false;">
                                <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh đại diện" Width="120" ImageUrl="/image/images/noimage.png" />
                            </div>
                            <asp:HiddenField ID="ImagesHid" runat="server" />
                        </div>
                    </div>
                    <div class="clr"></div>
                    <div class="form-group" style="padding: 10px 0 0;">
                        <label for="recipient-name" class="col-form-label ">Thứ tự:</label>
                        <asp:TextBox ID="txtOrderSub" runat="server" CssClass="TextBox" Width="150" />
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                <button type="button" class="btn btn-primary" onclick="return validateMessage();">Lưu lại</button>
                <asp:Button ID="btnSaveMessage" runat="server" Text="Lưu lại" CssClass="btn btn-savemessage btn-primary none" OnClientClick="return retunwaiting();" />
            </div>
        </div>
    </div>
</div>

<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css">
<script type="text/javascript" src="/Portals/_default/Skins/ChatBot/js/jquery.fancybox.min.js"></script>

<script type="text/javascript" src="/js/drag/jquery.dragsort.js"></script>
<script type="text/javascript">
    var _tyleMessage = 0;
    var vrtimeout = 2000;
    var thd;
    function insertavatar(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = '<%= PortalId.ToString%>';
        if (typeof (Worker) !== "undefined") {
            if (typeof (thd) == "undefined") {
                thd = new Worker("/js/worker.js");
                thd.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thd.terminate(); thd = undefined;
                        $('#<%= ImagesHid.ClientID %>').val("");
                        if (addValue('<%= ImagesHid.ClientID%>', result)) {
                            $('.seimgselect img').remove();
                            $('.seimgselect').append('<img class="imgDd" width="120" height="120" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '" />');
                            $("#lbtDelImg").removeClass("none");
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain%>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Chọn ảnh", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function deleteimg(t, id) { $("." + t + " img").attr("src", "/image/images/noimage.png"); $("." + t + " input[type='hidden']").val(""); $("#" + id).addClass("none"); };

    function openMessage(isActive) {
        $('.btnAddMessageSub').addClass("none");
        $('.lstMessage').addClass("none");
        if (isActive > 0) {
            $('.btnAddMessageSub').removeClass("none");
            $('.lstMessage').removeClass("none");
        }
        disablemessage(isActive);
        _tyleMessage = isActive;
    }

    function disablemessage(type) {
        $('.m_kichbanlienket').addClass('none');
        $('.m_slideanh').addClass('none');
        $('.t_ndtentinnhansub').addClass('none');
        $('.t_hinhanh').addClass('none');
        $('.m_taptin').addClass('none');
        if (type == 2) { //Kiểu nút
            $('.btnAddMessageSub').text('Thêm nút cho tin nhắn');
            $('.lbl_title').text('Tên nút: ');
            $('.m_kichbanlienket').removeClass('none');
            $('.i_kichbanlienket').addClass('none');
            $('.modal-title').text('Thêm mới nút cho tin nhắn');
            $('.t_tentinnhansub').text('Tên nút');
            $('.t_ndtentinnhansub').addClass('text-center');
            $('.t_ndtentinnhansub span').addClass('btn btn-primary');
            $('.t_hinhanh').addClass('none');
            $('.t_ndtentinnhansub').removeClass('none');
        }
        if (type == 3) { //Kiểu slide ảnh
            $('.btnAddMessageSub').text('Thêm slide cho tin nhắn');
            $('.lbl_title').text('Tên slide: ');
            $('.m_slideanh').removeClass('none');
            $('.modal-title').text('Thêm mới slide cho tin nhắn')
            $('.t_tentinnhansub').text('Tên slide');
            $('.t_ndtentinnhansub span').removeClass('btn btn-primary');
            $('.t_hinhanh').removeClass('none');
            $('.t_ndtentinnhansub').addClass('none');
        }
        if (type == 4) { //Tập tin
            $('.btnAddMessageSub').addClass("none");
            $('.lstMessage').addClass("none");
            $('.m_taptin').removeClass('none');
            loadcdnfile();
        }
    }
    $('#dropkieulk').change(function () {
        $('.i_kichbanlienket').addClass('none');
        $('.i_duongdan').addClass('none');
        if ($(this).val() == "0") {
            $('.i_duongdan').removeClass('none');
            $('.i_kichbanlienket button').text('----- Chọn kịch bản -----');
            $("#dnn_HomeMain1_ctl00_dropKichBanSub").val('-1');
        }
        if ($(this).val() == "1") {
            $('.i_kichbanlienket').removeClass('none');
            $('.i_duongdan input').val('');
        }
    });

    function validateMessage() {
        if (_tyleMessage == 3) { //Slide ảnh
            var _noidung = $('.i_tieude').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập tên slide ?', 'Thông báo', false);
                return;
            }
            if (_noidung.length < 10) {
                notify('warning', 'Vui lòng nhập tên slide trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            else
                $('.btn-savemessage').click();
        }
        if (_tyleMessage == 2) { //Kiểu nút
            var _noidung = $('.i_tieude').val();
            var _urlsub = $('.i_urlsub').val()
            var _kichbanLK = $('.i_kichbanlienket button').text();
            var _kieunut = $('#dropkieulk').val()
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập tên nút ?', 'Thông báo', false);
                return;
            }
            if (_kieunut == "0") { // đường dẫn
                if (_urlsub == "") {
                    notify('warning', 'Vui lòng nhập đường dẫn ?', 'Thông báo', false);
                    return;
                }
                else
                    $('.btn-savemessage').click();
            }
            if (_kieunut == "1") { // Kịch bản
                if (_kichbanLK == "" || _kichbanLK == "----- Chọn kịch bản -----") {
                    notify('warning', 'Vui lòng chọn kịch bản ?', 'Thông báo', false);
                    return;
                }
                else
                    $('.btn-savemessage').click();
            }
            else
                $('.btn-savemessage').click();
        }
    }

    function saveOrder() {
        var data = $("#list1 li").map(function () {
            return $(this).data("itemid");
        }).get();
        $.ajax({
            type: 'POST',
            url: '/API/chatbot/common.asmx/tinnhansub_updateorderby',
            data: { idStr: data.join("|") },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        notify('success', 'Thay đổi thứ tự thành công!', 'Thông báo', false);
                    }
                    else { notify('warning', 'Vui lòng thử lại', 'Thông báo', false); };
                }, vrtimeout);
            }
        });
    }

    $(function () {
        loaddargsort();
        loadcdnfile();
    });
    function loadcdnfile() {
        $('#fancybox-button').fancybox({
            'width': '90%',
            'height': '90%',
            'type': 'iframe',
            'autoSize': false
        });

        $('#fancybox-button').on('click', function () {
            function handlePostMessage(e) {
                var data = e.originalEvent.data;
                if (data.source === 'richfilemanager') {
                    $('#<%=TapTin.ClientID%>').val(data.preview_url);
                    //$('.fancybox-input').val(data.preview_url);
                    $.fancybox.close();

                    // remove an event handler
                    $(window).off('message', handlePostMessage);
                }
            }

            $(window).on('message', handlePostMessage);
        });
    }
    function loaddargsort() {
        $("#list1").dragsort({
            dragSelector: "div",
            dragBetween: true,
            dragEnd: saveOrder,
            placeHolderTemplate: "<li class='placeHolder'><div></div></li>",
            cursor: "move"
        });
    }

    function loadtaptin(i) {
        $('.m_taptin').addClass('none');
        if (i == 4) { //Tập tin
            console.log("1scs");
            $('.i_title').text('Tên tập tin: ');
            $('.m_taptin').removeClass('none');
            $('.lstMessage').addClass("none");
            $('.btnAddMessageSub').addClass("none");
        }
    }
</script>
