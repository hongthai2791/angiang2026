<%@ Control Language="vb" CodeFile="KichBanView.ascx.vb" Inherits="Modules.KichBanView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Danh sách kịch bản (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-2 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-md-4 pdl0">
                        <asp:DropDownList ID="dropBot" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-4 pdl0">
                        <asp:DropDownList ID="dropNhomKichBan" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="text-center col-md-4 pdl0">
                        <asp:Button ID="cmdNangCao" runat="server" Text="Chế độ nâng cao" CssClass="cmsbut cmsback cbclick" />
                    </div>
                </div>
                <div class="main-body">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa?" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>

                            <asp:TemplateColumn HeaderText="Tên kịch bản" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenKichBan" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>

                            <asp:TemplateColumn HeaderText="Nhóm từ khóa" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="NhomTuKhoa" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>

                            <asp:TemplateColumn HeaderText="Ý định" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="YDinh" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>

                            <asp:TemplateColumn HeaderText="Mô tả" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="GhiChu" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="25%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreatedDate" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_unlock.png?w" alt="Active" title="Duyệt nội dung?" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsActive" Enabled="false" runat="server" CssClass="cs-select cAct" ToolTip="Chọn duyệt?" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Literal ID="IsEdit" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
                <asp:Button ID="cmdCopy" runat="server" Text="Sao chép" CssClass="cmsbut cmsbtcheck" OnClientClick="$('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdSetting" runat="server" Text="Cài đặt nhóm từ khóa" CssClass="cmsbut cmsbtsetting" OnClientClick="$('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdYDinh" runat="server" Text="Cài đặt ý định" CssClass="cmsbut cmsbtsetting" OnClientClick="$('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdReNhanh" runat="server" Text="Cài đặt rẽ nhánh" CssClass="cmsbut cmsbtsetting" OnClientClick="$('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdSort" runat="server" Text="Sắp xếp" CssClass="cmsbut cmsbtsetting" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="IdKichBan" runat="server" />
        <asp:HiddenField ID="TypeSetting" runat="server" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drSort" />
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
        <asp:AsyncPostBackTrigger ControlID="cmdCopy" />
    </Triggers>
</asp:UpdatePanel>

<style>
    .cmsbtsetting {
        float: none !important;
    }

    .modal-title {
        float: left;
    }
</style>
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
            <div class="modal-body" style="min-height: 350px;">
                <form>
                    <div class="form-group m_nhomtukhoa">
                        <label for="message-text" class="col-form-label">Nhóm từ khóa:</label>
                        <asp:DropDownList ID="dropNhomTuKhoa" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="form-group m_ydinh">
                        <label for="message-text" class="col-form-label">Ý định:</label>
                        <asp:DropDownList ID="dropYDinh" runat="server" CssClass="selectpicker" />
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                <%--<button type="button" class="btn btn-primary" onclick="return validateMessage();">Lưu lại</button>--%>
                <asp:Button ID="btnSaveMessage" runat="server" Text="Lưu lại" CssClass="btn btn-savemessage btn-primary" OnClientClick="return retunwaiting();" />
            </div>
        </div>
    </div>
</div>

<div class="modal fade" id="popReNhanh" tabindex="-1" role="dialog" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title">Cài đặt rẽ nhánh kịch bản</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-times" aria-hidden="true"></i>
                </button>
            </div>
            <div class="modal-body" style="min-height: 350px;">
                <form>
                    <div class="form-group">
                        <label for="message-text" class="col-form-label">Kịch bản rẻ nhánh:</label>
                        <asp:DropDownList ID="dropKichBan" runat="server" CssClass="selectpicker" />
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                <button type="button" class="btn btn-renhanh btn-primary">Lưu lại</button>
            </div>
        </div>
    </div>
</div>


<script>
    function loadPop(title, type) {
        $('.m_nhomtukhoa').addClass('none');
        $('.m_ydinh').addClass('none');
        $('#popMessage').modal({
            show: 'false'
        });
        $('.modal-title').text('Cài đặt ' + title);
        if (type == 1)
            $('.m_nhomtukhoa').removeClass('none');
        if (type == 2)
            $('.m_ydinh').removeClass('none');
    }
    function loadrenhanh() {
        $('#popReNhanh').modal({
            show: 'false'
        });
    }
    $(document).ready(function () {
        $(".btn-renhanh").click(function () {
            notify('success', 'Đã cài đặt rẽ nhánh kịch bản thành công.', 'Thông báo', false);
            removewaiting();
            $('#popReNhanh').modal('toggle');
        });
    });
</script>
