<%@ Control Language="vb" CodeFile="KichBanEdit.ascx.vb" Inherits="Modules.KichBanEdit.Edit" AutoEventWireup="false" Explicit="True"  %>
<link href="/Portals/_default/chatbot.css?cdv=11" type="text/css" rel="stylesheet" />
<style>
    .waiting {
        z-index: 99999;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin kịch bản</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-9">
                            <div class="col-md-2 lb">ChatBot</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="dropBot" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="col-md-2 lb">Nhóm kịch bản</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="dropNhomKichBan" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="clr"></div>
                            <div class="col-md-2 lb">Tên kịch bản</div>
                            <div class="col-md-4">
                                <asp:TextBox ID="TenBot" runat="server" CssClass="TextBox validate[required]" />
                                <span class="required"></span>
                            </div>
                            <div class="clr"></div>
                            <div class="col-md-2 lb">Mô tả</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="60px" TextMode="MultiLine" />
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
                            <div class="clr"></div>
                            <div class="col-md-12 text-center lstMessage none">
                                <asp:Repeater ID="repMessage" runat="server">
                                    <ItemTemplate>
                                        <div class="itemKb blockCard">
                                            <div class="cdk-drag-handle headerHandle p-16">
                                                <div class="cdk-drag-item">
                                                    <div class="iconCardType">
                                                        <img fxflex="35px" alt="Icon" src="/portals/_default/skins/chatbot/images/message_<%#Eval("PhanLoai") %>.png" class="ng-star-inserted">
                                                    </div>
                                                    <div class="ml-10"><b class="f-13"><%#Eval("TenPhanLoai") %></b></div>
                                                </div>
                                                <div class="onHoverCard">
                                                    <asp:Button runat="server" ID="lnkEdit" CssClass="btn_update" OnCommand="_ProcessCommand" CommandName="UpdateMessage" CommandArgument='<%# Eval("Id")%>' ToolTip="Chỉnh sửa"></asp:Button>
                                                    <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa phiên bản hiển thị ngẫu nhiên của tin nhắn?');" ClientIDMode="AutoID" ID="lnkKieuHT" runat="server" ToolTip="Xóa phiên bản hiển thị"
                                                        OnCommand="_ProcessCommand" CommandName="XoaHienThi" CommandArgument='<%# Eval("Id")%>' Visible='<%# IIf(Eval("PhanLoai") = "1" And Eval("KieuHienThi") <> "-1", "True", "False")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/layout.png?w=20" alt="xóa" width="20" title="Xóa phiên bản hiển thị">
                                                    </asp:LinkButton>
                                                    <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa tin nhắn này không?');" ClientIDMode="AutoID" ID="lnkChinhSua" runat="server" ToolTip="Xóa tin nhắn" CssClass="btn-delete"
                                                        OnCommand="_ProcessCommand" CommandName="XoaMessage" CommandArgument='<%# Eval("Id")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/close.png?w=20" width="22"  alt="xóa" title="Xóa tin nhắn">
                                                    </asp:LinkButton>
                                                </div>
                                            </div>
                                            <div class="bodyCard">
                                                <%#Eval("NoiDung") %>
                                                <br />
                                                <%#Eval("NoiDungButton") %> <%#Eval("NoiDungSlide") %>
                                            </div>
                                        </div>
                                        <div class="clr"></div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div id="todoIdList" class="example-list todoCard none">
                                <asp:LinkButton runat="server" ID="btnMessageVB">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_1.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">QL Văn bản</b><p class="cardType_subtitle">Tin nhắn kiểu văn bản</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageNut">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_2.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Kiểu nút</b><p class="cardType_subtitle">Tin nhắn kiểu nút</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageSlide">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_3.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Slide ảnh</b><p class="cardType_subtitle">Tin nhắn kiểu slide ảnh</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageTapTin">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_4.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Tập tin</b><p class="cardType_subtitle">Tin nhắn kiểu tập tin</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageNhanh">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_5.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Phản hồi nhanh</b><p class="cardType_subtitle">Tin nhắn phản hồi nhanh</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageKB">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_6.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Kết nối kịch bản</b><p class="cardType_subtitle">Tin nhắn kiểu kết nối kịch bản</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>

                                <asp:LinkButton runat="server" ID="btnMessageTK">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_7.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Từ khóa</b><p class="cardType_subtitle">Tin nhắn kiểu từ khóa</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                                <asp:LinkButton runat="server" ID="btnMessageHK">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_1.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Hộp kiểm</b><p class="cardType_subtitle">Tin nhắn kiểu hộp kiểm</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                                <asp:LinkButton runat="server" ID="btnMessageAPI">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_2.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Api</b><p class="cardType_subtitle">Tin nhắn kiểu API</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                                <asp:LinkButton runat="server" ID="btnMessageTre">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_3.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Trễ</b><p class="cardType_subtitle">Tin nhắn kiểu trễ</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                                <asp:LinkButton runat="server" ID="btnMessageVB2">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_3.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Văn bản</b><p class="cardType_subtitle">Tin nhắn kiểu văn bản</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                                <asp:LinkButton runat="server" ID="btnMessageTKDong">
                                <div class="example-box cardType_item ng-star-inserted" style="place-content: center flex-start; align-items: center; flex-direction: row; box-sizing: border-box; display: flex;">
                                    <div class="iconCardType" style="place-content: center; align-items: center; flex-direction: row; box-sizing: border-box; display: flex; flex: 1 1 28px; max-width: 28px; min-width: 28px;">
                                        <img alt="Icon" src="/portals/_default/skins/chatbot/images/message_4.png" class="ng-star-inserted" style="flex: 1 1 35px; box-sizing: border-box; max-width: 35px; min-width: 35px;"><!----><!---->
                                    </div>
                                    <div class="ml-10">
                                        <b class="f-13">Từ khóa động</b><p class="cardType_subtitle">Tin nhắn kiểu từ khóa động</p>
                                    </div>
                                    <div class="mat-tooltip-trigger icon_question ng-star-inserted"><i class="far fa-question-circle"></i></div>
                                </div>
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>

                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
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
            <asp:HiddenField ID="ItemMessageId" runat="server" Visible="false" />
            <asp:HiddenField ID="LoaiTinNhan" runat="server" Visible="false" />
            <asp:HiddenField ID="OrderTinNhan" runat="server" Visible="false" />
            <asp:HiddenField ID="nhomTuKhoaID" runat="server" />
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
                                <label for="recipient-name" class="col-form-label ">Tiêu đề:</label>
                                <asp:TextBox ID="txtTenTinNhan" runat="server" CssClass="form-control i_tieude" />
                            </div>
                            <div class="form-group m_nhomtukhoa">
                                <label for="message-text" class="col-form-label">Nhóm từ khóa:</label>
                                <asp:DropDownList ID="dropNhomTuKhoa" onchange="getMultiple();" multiple="multiple" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="form-group m_noidung">
                                <label for="message-text" class="col-form-label">Nội dung:</label>
                                <asp:TextBox ID="txtNoiDung" runat="server" CssClass="TextBox i_noidung" Height="100px" TextMode="MultiLine" />
                            </div>
                            <div class="form-group m_kichbanlienket i_kichbanlienket">
                                <label for="message-text" class="col-form-label">Kịch bản:</label>
                                <asp:DropDownList ID="dropKichBan" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="form-group m_kichbanlienket">
                                <label for="recipient-name" class="col-form-label ">Đường dẫn:</label>
                                <asp:TextBox ID="txtUrl" runat="server" CssClass="form-control i-duongdan" />
                            </div>
                            <div class="form-group m_vitri">
                                <label for="recipient-name" class="col-form-label ">Chia sẻ vị trí:</label>
                                <asp:TextBox ID="txtViTri" runat="server" Placeholder="Đường link chia sẻ Google Maps" CssClass="form-control i-vitri" />
                            </div>
                            <div class="form-group m_thoigian">
                                <label for="recipient-name" class="col-form-label ">Chọn thời gian:</label>
                                <asp:TextBox ID="txtThoiGian" Placeholder="dd/mm/yyyy hh:mm" CssClass="timepicker TextBox" runat="server" />
                            </div>
                            <div class="form-group m_danhmay">
                                <label for="recipient-name" class="col-form-label ">Hiệu ứng đánh máy:</label>
                                <asp:CheckBox ID="cbDanhMay" runat="server" />
                            </div>
                            <div class="form-group m_iscall">
                                <label for="recipient-name" class="col-form-label ">Yêu cầu chat trực tiếp:</label>
                                <asp:CheckBox ID="cbIsCall" runat="server" />
                            </div>
                            <div class="form-group m_kieuhienthi">
                                <label for="recipient-name" class="col-form-label ">Kiểu hiển thị:</label>
                                <asp:DropDownList ID="dropKieuHienThi" runat="server" CssClass="selectpicker">
                                    <asp:ListItem Value="-1">----- Chọn kiểu hiển thị -----</asp:ListItem>
                                    <asp:ListItem Value="0">Chữ thường</asp:ListItem>
                                    <asp:ListItem Value="1">Chữ đậm</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group m_bien">
                                <label for="message-text" class="col-form-label">Bộ biến:</label>
                                <asp:DropDownList ID="dropBoBien" runat="server" CssClass="selectpicker" />
                            </div>
                            <div class="form-group m_bien">
                                <div class="lst-bien">
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="recipient-name" class="col-form-label ">Thứ tự hiển thị:</label>
                                <asp:TextBox ID="txtOrder" runat="server" CssClass="form-control" />
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

    </ContentTemplate>
</asp:UpdatePanel>

<script>
    var _tyleMessage = 0;
    var vrtimeout = 2000;
    function loadPop(title, type, update) {
        if (update == 0) {
            clearpopup();
        }
        $('#popMessage').modal({
            show: 'false'
        });
        $('.modal-title').text('Tin nhắn kiểu ' + title);
        disablemessage(type);
        _tyleMessage = type;
    }
    function setMultiple() {
        var vdata = $('#<%= nhomTuKhoaID.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
            $('#<%= dropNhomTuKhoa.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= dropNhomTuKhoa.ClientID%>").trigger('selectpicker:updated');
        });
    };
    function getMultiple() {
        $('#<%= nhomTuKhoaID.ClientID%>').val($("#<%= dropNhomTuKhoa.ClientID%>").val());
    };

    function openMessage(isActive) {
        $('#todoIdList').addClass("none");
        $('.lstMessage').addClass("none");
        if (isActive > 0) {
            $('#todoIdList').removeClass("none");
            $('.lstMessage').removeClass("none");
        }
    }
    $('#dnn_HomeMain1_ctl00_dropBoBien').on('change', function () {
        waiting();
        $('.lst-bien').empty();
        var _idBoBien = this.value;
        var _html = '';
        if (_idBoBien > 0) {
            $.ajax({
                type: 'POST',
                url: '/API/chatbot/common.asmx/bien_by_bobienid',
                data: { idBoBien: _idBoBien },
                success: function (res) {
                    setTimeout(function () {
                        if (res.status == 1) {
                            removewaiting();
                            return;
                        }
                        if (res.status == 2) {
                            var i;
                            for (i = 0; i < res.data.length; ++i) {
                                _html += '<a class="btn btn-primary" href="javascript:void(0);" data-item="' + res.data[i].keyBien + '" id="bien-' + res.data[i].id + '" onclick="chooseBien(' + res.data[i].id + ')" title="' + res.data[i].tenBien + '">' + res.data[i].keyBien + '</a>'
                            }
                            $('.lst-bien').append(_html);
                            removewaiting();
                            return;
                        }
                        else {
                            removewaiting();
                            return;
                        }
                    }, vrtimeout);
                }
            });
        } else
            removewaiting();
    });

    function chooseBien(id) {
        if (id > 0) {
            $('.i_noidung').val($('.i_noidung').val() + " " + $('#bien-' + id).data("item"));
        }
        removewaiting();
    }

    function clearpopup() {
        $('.i_noidung').val('')
        $('.i-duongdan').val('')
        $('.i-vitri').val('')
        //$('.lst-bien').empty();
    }

    function disablemessage(type) {
        openMessage(type);
        $('.m_tentinnhan').addClass('none');
        $('.m_nhomtukhoa').addClass('none');
        $('.m_noidung').addClass('none');
        $('.m_kichbanlienket').addClass('none');
        $('.m_vitri').addClass('none');
        $('.m_thoigian').addClass('none');
        $('.m_kieuhienthi').addClass('none');
        $('.m_bien').addClass('none');
        $('.m_danhmay').addClass('none');
        $('.m_iscall').addClass('none');
        if (type == 10) { //Trễ
            $('.m_noidung').removeClass('none');
            $('.m_thoigian').removeClass('none');
            $('.m_danhmay').removeClass('none');
        }
        if (type == 7) { //từ khóa
            $('.m_nhomtukhoa').removeClass('none');
            $('.m_noidung').removeClass('none');
        }
        if (type == 6) { //kết nối kịch bản
            $('.m_tentinnhan').removeClass('none');
            $('.m_tentinnhan label').text('Tiêu đề kịch bản: ');
            $('.m_kichbanlienket').removeClass('none');
            $('.m_noidung').removeClass('none');
        }
        if (type == 5) { //Phản hồi nhanh
            $('.m_noidung').removeClass('none');
            $('.m_vitri').removeClass('none');
            $('.m_thoigian').removeClass('none');
            $('.m_kieuhienthi').removeClass('none');
            $('.m_bien').removeClass('none');
            $('.m_iscall').removeClass('none');
        }
        //if (type == 4) { //Tập tin
        //    $('.m_tentinnhan').removeClass('none');
        //    $('.m_tentinnhan label').text('Tên tập tin: ');
        //    $('.m_noidung').removeClass('none');
        //}
        //if (type == 3) { //Slide ảnh
        //    $('.m_noidung').removeClass('none');
        //}
        //if (type == 2) { //Kiểu nút
        //    $('.m_noidung').removeClass('none');
        //}
        if (type == 1) { //Văn bản
            $('.m_noidung').removeClass('none');
            $('.m_bien').removeClass('none');
            $('.m_kieuhienthi').removeClass('none');
        }
    }

    function validateMessage() {
        if (_tyleMessage == 10) { //trễ
            var _noidung = $('.i_noidung').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập nội dung ?', 'Thông báo', false);
                return;
            }
            if (_noidung.length < 10) {
                notify('warning', 'Vui lòng nhập nội dung trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            else {
                //eval($('.btn-savemessage').attr('href'));
                $('.btn-savemessage').click();
            }
        }
        if (_tyleMessage == 7) { //từ khóa
            var _nhomtukhoa = $('.m_nhomtukhoa button').text();
            var _noidung = $('.i_noidung').val();
            if (_nhomtukhoa == "" || _nhomtukhoa == "Chưa chọn ") {
                notify('warning', 'Vui lòng chọn nhóm từ khóa ?', 'Thông báo', false);
                return;
            }
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập nội dung ?', 'Thông báo', false);
                return;
            }
            if (_noidung.length < 10) {
                notify('warning', 'Vui lòng nhập nội dung trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            else {
                //eval($('.btn-savemessage').attr('href'));
                $('.btn-savemessage').click();
            }
        }
        if (_tyleMessage == 6) { //kết nối kịch bản
            var _kichbanLK = $('.i_kichbanlienket button').text();
            var _tentinnhan = $('.i_tieude').val();
            if (_tentinnhan == "") {
                notify('warning', 'Vui lòng nhập tiêu đề ?', 'Thông báo', false);
                return;
            }
            if (_tentinnhan.length < 10) {
                notify('warning', 'Vui lòng nhập tiêu đề trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            if (_kichbanLK == "" || _kichbanLK == "----- Chọn kịch bản -----") {
                console.log(_kichbanLK);
                notify('warning', 'Vui lòng chọn kịch bản ?', 'Thông báo', false);
                return;
            }
            else
                $('.btn-savemessage').click();
        }
        if (_tyleMessage == 5) { //Phản hồi nhanh
            var _noidung = $('.i_noidung').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập nội dung ?', 'Thông báo', false);
                return;
            }
            if (_noidung.length < 10) {
                notify('warning', 'Vui lòng nhập nội dung trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            else
                $('.btn-savemessage').click();
        }
        if (_tyleMessage == 4) { //Tập tin

        }
        if (_tyleMessage == 1) { //Văn bản
            var _noidung = $('.i_noidung').val();
            if (_noidung == "") {
                notify('warning', 'Vui lòng nhập nội dung ?', 'Thông báo', false);
                return;
            }
            if (_noidung.length < 10) {
                notify('warning', 'Vui lòng nhập nội dung trên 10 ký tự ?', 'Thông báo', false);
                return;
            }
            else
                $('.btn-savemessage').click();
        }
    }

    function removeloading() {
        $('.modal-backdrop').remove();
    }
</script>
