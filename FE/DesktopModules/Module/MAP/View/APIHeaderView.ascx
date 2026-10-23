<%@ Control Language="vb" CodeFile="APIHeaderView.ascx.vb" Inherits="Modules.APIHeaderView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Danh sách cấu hình (<asp:Literal ID="litCount" runat="server" />)</h3>
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
                        <asp:DropDownList ID="dropAPI" AutoPostBack="true" runat="server" CssClass="selectpicker" />
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

                            <asp:TemplateColumn HeaderText="Tên API" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenAPI" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Lịch đồng bộ" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="LichDongBo" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Key" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="APIKey" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
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
                <asp:Button ID="cmdLichDongBo" runat="server" Text="Lịch đồng bộ" CssClass="cmsbut cmsbtsetting" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drSort" />
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
    </Triggers>
</asp:UpdatePanel>
<style>
    .cmsbtsetting{float:none!important;}
    .cblist tbody tr td{padding:5px;font-size:16px;}
</style>


<!-- Modal -->
<div class="modal fade" id="popMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel" style="display: contents">Lịch đồng bộ</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-times" aria-hidden="true"></i>
                </button>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group m_tentinnhan">
                        <asp:CheckBoxList runat="server" ID="_lichdongbo" CssClass="cblist">
                            <asp:ListItem Value="Thứ 2" Text="Thứ 2" />
                            <asp:ListItem Value="Thứ 3" Text="Thứ 3" />
                            <asp:ListItem Value="Thứ 4" Text="Thứ 4" />
                            <asp:ListItem Value="Thứ 5" Text="Thứ 5" />
                            <asp:ListItem Value="Thứ 6" Text="Thứ 6" />
                            <asp:ListItem Value="Thứ 7" Text="Thứ 7" />
                            <asp:ListItem Value="Chủ nhật" Text="Chủ nhật" />
                        </asp:CheckBoxList>
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

<script type="text/javascript">
    function openpopup() {
        $('#popMessage').modal({
            show: 'false'
        });
    }

    function validateMessage() {
        //var _noidung = $('.i_tieude').val();
        //var _urlsub = $('.i_urlsub').val();
        //if (_noidung == "") {
        //    notify('warning', 'Vui lòng nhập key tham số ?', 'Thông báo', false);
        //    return;
        //}
        //if (_urlsub == "") {
        //    notify('warning', 'Vui lòng nhập giá trị tham số ?', 'Thông báo', false);
        //    return;
        //}
        //else
            $('.btn-savemessage').click();
    }

</script>