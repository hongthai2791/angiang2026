<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_DSMoiUV.ascx.vb" Inherits="Modules.SVL.Mar_DSMoiUV.View" %>

<div class="modal fade " style="overflow: hidden !important" id="popDsUngVien" tabindex="-1" role="dialog" aria-hidden="true">
    <div class="modal-dialog modal-lg" style="min-width: 1024px; width: 70%; height: 100%">
        <div class="modal-content">
<asp:UpdatePanel runat="server" ID="DSMoiUV_Panel">
    <ContentTemplate>
        <div class="row pdt10">
            <div class="col-md-6">
                <asp:TextBox ID="DSMoiUV_Find" placeHolder="Nhập vào tên, điện thoại, email ứng viên cần tìm" CssClass="std med" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Button ID="cmdDSMoiUV_Search" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Tìm ứng viên" />
            </div>
            <div class="clear"></div>
        </div>
        <div class="row ">
            <div class="col-md-12">
                <asp:DataGrid ID="dgrDanhSachUngVien" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                    <ItemStyle BackColor="#f8f4f1" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                            <HeaderTemplate>
                                <asp:RadioButton ID="chkItemsTop" Enabled="false" runat="server" CssClass="bCur bDel" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <input type="radio" name="GrdUV" onclick="setIdUVChoose()" cssclass="cs-select cDel" title="Chọn để thay thế" />
                            </ItemTemplate>
                            <HeaderStyle Width="3%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="IsOrder" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="4%" HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tên ứng viên" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="tenDayDu" runat="server" />
                                  <asp:HiddenField ID="HF_UVID_InGrid" ClientIDMode="Static" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Tel" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="15%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Email liên hệ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="UserName" Visible="false" runat="server" />
                                <asp:Literal ID="Email" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="30%" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div style="text-align: center; position: fixed; bottom: 40px; width: 100%; left: 0">
       <asp:LinkButton ID="cmdSubmit" runat="server" Style="" Text="Xác nhận thay thế" CssClass="cmsbut cmdPublic" />
       <asp:LinkButton Text="Đóng" runat="server" CssClass="cmsbut cmdExit" ID="btnClose" class="close" data-dismiss="modal" />
   </div>
            <div class="clear"></div>
        </div>

        <asp:HiddenField runat="server" ID="_HF_GrItem" Value="" />
        <asp:HiddenField runat="server" ID="_SelectedId" Value="" />
        <asp:HiddenField runat="server" ID="_PGDId" Value="" />
    </ContentTemplate>
</asp:UpdatePanel>

            </div>
            </div>
            </div>
<script type="text/javascript">

    function showDialogUngVien(s, t) {
        $('#<%=_PGDId.ClientID%>').val(s);
        $('#<%=_HF_GrItem.ClientID%>').val("");
        $('#<%=_SelectedId.ClientID%>').val(t);
        $('#popDsUngVien').modal('show');
    }

    function closeDialogUngVien() {
        $('#popDsUngVien').modal('hide');
    }
    function setIdUVChoose() {
        debugger;
        var selectedId = $('input[name="GrdUV"]:checked').closest('tr').find('#HF_UVID_InGrid').val();
        $('#<%=_HF_GrItem.ClientID%>').val(selectedId);
    }
    $('#popDsUngVien').on('hidden.bs.modal', function () {
        $('#<%=_PGDId.ClientID%>').val("");
        $('#<%=_HF_GrItem.ClientID%>').val("")
        $('#<%=_SelectedId.ClientID%>').val("");
        $('input[name="GrdUV"]').prop('checked', false);

    });
</script>
