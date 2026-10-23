<%@ Control Language="vb" CodeFile="TinNhanAdvEdit.ascx.vb" Inherits="Modules.TinNhanAdvEdit.Edit" AutoEventWireup="false" Explicit="True" %>
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
    .cmsbtsetting{float:none !important;}
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-8">
                    <h3 class="box-title">Thông tin tin nhắn</h3>
                </div>
                <div class="col-md-4" style="text-align: right;">
                    <asp:Button runat="server" CssClass="btn btn-danger btnDeleteAllSub" Visible="false" ID="btnDeleteAllSub" Text="Xóa từ khóa động" />
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
                    <div class="col-md-1 lb i_api none">API</div>
                    <div class="col-md-5 i_api none">
                        <asp:DropDownList ID="dropAPI" runat="server" CssClass="TextBox" />
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
                    <div class="col-md-12 text-center lstMessage none">
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
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                         <asp:Button ID="cmdSettingAPI" runat="server" TabIndex="9" Text="Cài đặt" CssClass="cmsbut cmsbtsetting" />
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemSubId" runat="server" Visible="false" />
            <asp:HiddenField ID="IdKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="IdChatBot" runat="server" Visible="false" />
            <asp:HiddenField ID="IdNhomKichBan" runat="server" Visible="false" />
            <asp:HiddenField ID="KieuAdd" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemIdAPI" runat="server" Visible="false" />
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
                                <label for="recipient-name" class="col-form-label lbl_title">Tiêu đề:</label>
                                <asp:TextBox ID="txtTenTinNhanSub" runat="server" CssClass="form-control i_tieude" />
                            </div>
                            <div class="form-group m_ydinh">
                                <label for="message-text" class="col-form-label">Ý định:</label>
                                <asp:DropDownList ID="dropYDinh" runat="server" CssClass="selectpicker i_ydinh" />
                            </div>
                            <div class="form-group m_tukhoa">
                                <label for="message-text" class="col-form-label">Từ khóa:</label>
                                <asp:DropDownList ID="dropTuKhoa" runat="server" CssClass="selectpicker i_tukhoa" />
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

    </ContentTemplate>
</asp:UpdatePanel>


<script type="text/javascript">
    var _tyleMessage = 0;
    var vrtimeout = 2000;
    var thd;

    function loadPop(type) {
        $('#popMessage').modal({
            show: 'false'
        });
        disablemessage(type);
        _tyleMessage = type;
    }

    function openMessage(isActive) {
        $('.btnAddMessageSub').addClass("none");
        $('.lstMessage').addClass("none");
        $('.i_api').removeClass("none");
        if (isActive > 0) {
            $('.btnAddMessageSub').removeClass("none");
            $('.lstMessage').removeClass("none");
            $('.i_api').addClass("none");
        }
        disablemessage(isActive);
        _tyleMessage = isActive;
    }

    function disablemessage(type) {
        $('.m_slideanh').addClass('none');
        $('.t_hinhanh').addClass('none');
        $('.m_ydinh').addClass('none');
        $('.m_tukhoa').addClass('none');
        if (type == 12) { //từ khóa động
            $('.btnAddMessageSub').text('Thêm từ khóa động');
            $('.lbl_title').text('Từ khóa động: ');
            $('.modal-title').text('Từ khóa động');
            $('.m_tukhoa').removeClass('none');
        }
        if (type == 11) { //Văn bản
            $('.btnAddMessageSub').text('Thêm điều kiện lọc ý định');
            $('.lbl_title').text('Điều kiện lọc ý định: ');
            $('.modal-title').text('Điều kiện lọc ý định');
            $('.m_ydinh').removeClass('none');
        }
    }

    function validateMessage() {
        if (_tyleMessage == 12) { //từ khóa động
            var _noidung = $('.i_tieude').val();
            var _ydinh = $('.i_tukhoa button').text();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập từ khóa động ?', 'Thông báo', false);
                return;
            }
            if (_ydinh == "" || _ydinh == "----- Chọn từ khóa -----") {
                notify('warning', 'Vui lòng chọn từ khóa ?', 'Thông báo', false);
                return;
            }
            else {
                $('.btnClosePopUp').click();
                $('.btn-savemessage').click();
            }
        }
        if (_tyleMessage == 11) { //Văn bản
            var _noidung = $('.i_tieude').val();
            var _ydinh = $('.i_ydinh button').text();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập điều kiện lọc ý định ?', 'Thông báo', false);
                return;
            }
            if (_ydinh == "" || _ydinh == "----- Chọn ý định -----") {
                notify('warning', 'Vui lòng chọn ý định ?', 'Thông báo', false);
                return;
            }
            //if (_noidung.length < 10) {
            //    notify('warning', 'Vui lòng nhập tên slide trên 10 ký tự ?', 'Thông báo', false);
            //    return;
            //}
            else {
                $('.btnClosePopUp').click();
                $('.btn-savemessage').click();
            }
        }
    }

    function removeloading() {
        $('.modal-backdrop').remove();
    }

</script>
