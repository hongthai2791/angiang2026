<%@ Control Language="vb" CodeFile="TinNhanCheckEdit.ascx.vb" Inherits="Modules.TinNhanCheckEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<link href="/Portals/_default/chatbot.css?cdv=11" type="text/css" rel="stylesheet" />
<style type="text/css">
    .modal-body {
        min-height: 350px;
    }

    .placeHolder div {
        background-color: white !important;
        border: dashed 1px gray !important;
    }

    #fancybox-button {
        color: #fff;
    }

    .cmsbtsetting {
        float: none !important;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-8">
                    <h3 class="box-title">Thông tin tin nhắn hộp kiểm</h3>
                </div>
                <div class="col-md-4" style="text-align: right;">
                    <asp:Button ID="btnAddTNSub1" runat="server" Text="Thêm kiểu mặc định" CssClass="btn btn-primary btnAddMessageSub" />
                    <asp:Button ID="btnAddTNSub2" runat="server" Text="Thêm kiểu ảnh" CssClass="btn btn-info btnAddMessageSub" />
                    <%--<button type="button" class="btn btn-primary btnAddMessageSub none" onclick="loadPop(8)">Thêm mới</button>--%>
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
                    <div class="col-md-6 text-center lstMessage none">
                        <div class="col-md-12">
                            <h3 class="box-title" style="margin: 0;">Thông tin kiểu mặc định</h3>
                        </div>
                        <div class="clr clUp"></div>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Tên</th>
                                    <th scope="col" style="width: 100px;"></th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="repMessage" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <th scope="row"><%#Container.ItemIndex + 1%></th>
                                            <td><%#Eval("TenTinNhanSub") %></td>
                                            <td>
                                                <asp:Button runat="server" ID="lnkEdit" CssClass="btn_update" OnCommand="_ProcessCommand" CommandName="UpdateMessage" CommandArgument='<%# Eval("Id")%>' ToolTip="Chỉnh sửa"></asp:Button>
                                                <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa thông tin này không?');" ClientIDMode="AutoID" ID="lnkChinhSua" runat="server" ToolTip="Xóa tin nhắn"
                                                    OnCommand="_ProcessCommand" CommandName="XoaMessage" CommandArgument='<%# Eval("Id")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/close.png?w=20" alt="edit" title="Xóa thông tin">
                                                </asp:LinkButton>

                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </tbody>
                        </table>
                    </div>
                    <div class="col-md-6 text-center lstMessage">
                        <div class="col-md-12">
                            <h3 class="box-title" style="margin: 0;">Thông tin kiểu ảnh</h3>
                        </div>
                        <div class="clr clUp"></div>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th scope="col">#</th>
                                    <th scope="col">Tên</th>
                                    <th scope="col" style="width: 100px;"></th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="repMessage2" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <th scope="row"><%#Container.ItemIndex + 1%></th>
                                            <td><%#Eval("TenTinNhanSub") %></td>
                                            <td>
                                                <asp:Button runat="server" ID="lnkEdit" CssClass="btn_update" OnCommand="_ProcessCommand" CommandName="UpdateMessage" CommandArgument='<%# Eval("Id")%>' ToolTip="Chỉnh sửa"></asp:Button>
                                                <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa thông tin này không?');" ClientIDMode="AutoID" ID="lnkChinhSua" runat="server" ToolTip="Xóa tin nhắn"
                                                    OnCommand="_ProcessCommand" CommandName="XoaMessage" CommandArgument='<%# Eval("Id")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/close.png?w=20" alt="edit" title="Xóa thông tin">
                                                </asp:LinkButton>

                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdTinNhanAPI" runat="server" Text="Cài đặt tin nhắn API" CssClass="cmsbut cmsbtsetting" />
                        <asp:Button ID="cmdKichBan" runat="server" Text="Cài đặt kịch bản" CssClass="cmsbut cmsbtsetting" OnClientClick="loadrenhanh(1);" />
                        <asp:Button ID="cmdBien" runat="server" Text="Cài đặt biến" CssClass="cmsbut cmsbtsetting" OnClientClick="loadrenhanh(2);" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemSubId" runat="server" Visible="false" />
            <asp:HiddenField ID="IdKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="IdChatBot" runat="server" Visible="false" />
            <asp:HiddenField ID="IdNhomKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="KieuAdd" runat="server" Visible="false" />
            <asp:HiddenField ID="IdPhanLoai" runat="server" Visible="false" />
        </div>

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
                                <label for="recipient-name" class="col-form-label lbl_title">Kiểu mặc định:</label>
                                <asp:TextBox ID="txtTenTinNhanSub" runat="server" CssClass="form-control i_tieude" />
                            </div>
                            <div class="clr"></div>
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
                        <button type="button" class="btn btn-secondary btnClosePopUp" data-dismiss="modal">Đóng</button>
                        <button type="button" class="btn btn-primary" onclick="return validateMessage();">Lưu lại</button>
                        <asp:Button ID="btnSaveMessage" runat="server" Text="Lưu lại" CssClass="btn btn-savemessage btn-primary none" OnClientClick="return retunwaiting();" />
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="popReNhanh" tabindex="-1" role="dialog" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Cài đặt</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times" aria-hidden="true"></i>
                        </button>
                    </div>
                    <div class="modal-body" style="min-height: 350px;">
                        <form>
                            <div class="form-group p_kichban">
                                <label for="message-text" class="col-form-label">Kịch bản:</label>
                                <asp:DropDownList ID="dropKichBan" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="form-group p_bien">
                                <label for="message-text" class="col-form-label">Biến:</label>
                                <asp:DropDownList ID="dropBien" runat="server" CssClass="selectpicker" />
                            </div>
                        </form>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary btnClosePopUp" data-dismiss="modal">Đóng</button>
                        <button type="button" class="btn btn-renhanh btn-primary">Lưu lại</button>
                    </div>
                </div>
            </div>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>


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

    function loadPop(type) {
        $('#popMessage').modal({
            show: 'false'
        });
        disablemessage(type);
        _tyleMessage = type;
    }

    function openMessage(isActive) {
        $('.lstMessage').addClass("none");
        $('.i_api').removeClass("none");
        if (isActive > 0) {
            $('.lstMessage').removeClass("none");
            $('.i_api').addClass("none");
        }
        disablemessage(isActive);
        _tyleMessage = isActive;
    }

    function disablemessage(type) {
        $('.m_slideanh').addClass('none');
        $('.t_hinhanh').addClass('none');
        if (type == 1) {
            $('.lbl_title').text('Kiểu mặc định: ');
            $('.modal-title').text('Kiểu mặc định');
        } else {
            $('.m_slideanh').removeClass('none');
            $('.t_hinhanh').removeClass('none');
            $('.lbl_title').text('Kiểu ảnh: ');
            $('.modal-title').text('Kiểu ảnh');
        }
    }

    function validateMessage() {
        if (_tyleMessage == 1) {
            var _noidung = $('.i_tieude').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập đáp án kiểu mặc định ?', 'Thông báo', false);
                return;
            }
            else {
                $('.btnClosePopUp').click();
                $('.btn-savemessage').click();
            }
        }
        if (_tyleMessage == 2) {
            var _noidung = $('.i_tieude').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập tên kiểu ảnh ?', 'Thông báo', false);
                return;
            }
            else {
                $('.btnClosePopUp').click();
                $('.btn-savemessage').click();
            }
        }

    }

    function removeloading() {
        $('.modal-backdrop').remove();
    }

    function loadrenhanh(type) {
        $('.p_kichban').addClass('none');
        $('.p_bien').addClass('none');
        if (type == 1) {
            $('.p_kichban').removeClass('none');
            $('.modal-title').text('Cài đặt liên kết kịch bản');
        }
        if (type == 2) {
            $('.p_bien').removeClass('none');
            $('.modal-title').text('Cài đặt biến');
        }
        $('#popReNhanh').modal({
            show: 'false'
        });
    }
    $(document).ready(function () {
        $(".btn-renhanh").click(function () {
            notify('success', 'Cài đặt liên kết kịch bản thành công.', 'Thông báo', false);
            removewaiting();
            $('.cmsbtupdate').click();
            $('.btnClosePopUp').click();
            //$('#popReNhanh').modal('toggle');
            //eval($('.cmsbtupdate').attr('href'));
        });
    });

</script>
