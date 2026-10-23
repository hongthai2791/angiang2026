<%@ Control Language="vb" CodeFile="APISyncEdit.ascx.vb" Inherits="Modules.APISyncEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin cài đặt đồng bộ dữ liệu Api</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên Api</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenAPI" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Api đồng bộ</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropAPI" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>

                    <div class="col-md-2 lb">Thời gian</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="ThoiGian" runat="server" MaxLength="2" CssClass="TextBox validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="dropKieu" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="1">Giờ</asp:ListItem>
                            <asp:ListItem Value="2">Ngày</asp:ListItem>
                            <asp:ListItem Value="3">Tuần</asp:ListItem>
                            <asp:ListItem Value="4">Tháng</asp:ListItem>
                            <asp:ListItem Value="5">Năm</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Ngày bắt đầu</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="NgayBatDau" runat="server" placeholder="dd/mm/yyyy" CssClass="TextBox validate[required, custom[dateVN]]" />
                    </div>
                     <div class="col-md-2 lb">Ngày kết thúc</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="NgayKetThuc" runat="server" placeholder="dd/mm/yyyy" CssClass="TextBox validate[required, custom[dateVN]]" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-12 lstDataVe none">
                        <h3 class="box-title">Kết quả đồng bộ</h3>
                    </div>
                    <div class="col-md-12 lstDataVe i_datave">
                        <asp:Literal ID="litUpdate" runat="server" />
                    </div>
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdView" runat="server" Text="Kiểm tra kết quả đồng bộ" CssClass="cmsbut cmsbtcheck" OnClientClick="$('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="LichSuNote" runat="server" Visible="false" />
            <asp:HiddenField ID="OrderAPIHeader" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>


<!-- Modal -->
<div class="modal fade" id="popMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel" style="display: contents">Thông tin tham số</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-times" aria-hidden="true"></i>
                </button>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group m_tentinnhan">
                        <label for="recipient-name" class="col-form-label lbl_title">Key:</label>
                        <asp:TextBox ID="txtKey" runat="server" CssClass="form-control i_tieude" />
                    </div>
                    <div class="form-group m_kichbanlienket i_duongdan">
                        <label for="recipient-name" class="col-form-label ">Value:</label>
                        <asp:TextBox ID="txtValue" runat="server" CssClass="form-control i_urlsub" />
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function openMessage(isActive) {
        $('.btnAddMessageSub').addClass("none");
        $('.lstMessage').addClass("none");
        if (isActive > 0) {
            $('.btnAddMessageSub').removeClass("none");
            $('.lstMessage').removeClass("none");
        }
    }
    function openData(isActive) {
        $('.lstDataVe').addClass("none");
        $('.i_datave').addClass("none");
        if (isActive > 0)
            $('.lstDataVe').removeClass("none");
        else
            $('.i_datave').empty();
    }

</script>
