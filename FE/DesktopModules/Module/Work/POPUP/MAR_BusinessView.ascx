<%@ Control Language="vb" AutoEventWireup="true" CodeFile="MAR_BusinessView.ascx.vb" Inherits="Modules.EPORTAL.View" %>

<div class="modal fade " style="overflow: hidden !important" id="popDsDoanhNghiep" tabindex="-1" role="dialog" aria-hidden="true">
    <div class="modal-dialog modal-lg" style="min-width: 1024px; width: 70%; height: 100%">
        <div class="modal-content">
            <asp:UpdatePanel ID="pageView" runat="server">
                <ContentTemplate>
                    <div class="box ">
                        <div class="row pdt10">
                            <div class="col-md-3 none">
                                <div class="material-control">
                                    <label>Tỉnh/Thành phố</label>
                                    <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-3 none">
                                <div class="material-control">
                                    <label>Phường/xã</label>
                                    <asp:DropDownList ID="PhuongXa" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-2 none">
                                <asp:DropDownList ID="drSort" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />

                            </div>
                            <div class="col-md-2 none">
                                <div class="material-control">
                                    <label>Số bản ghi trên trang</label>
                                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-12">
                                <asp:TextBox ID="txtkey" runat="server" placeholder="Nhập mã doanh nghiệp, tên doanh nghiệp..." CssClass="timKiemD" Columns="20" Width="100%" />
                                <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                            </div>
                        </div>
                        <div class="main-body">
                            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                                <ItemStyle BackColor="#f8f4f1" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                        <HeaderTemplate>
                                            <asp:RadioButton ID="chkItemsTop" Enabled="false" runat="server" CssClass="bCur bDel" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <input type="radio" name="GrdDN" onclick="setIdChoose()" cssclass="cs-select cDel" title="Chọn để thay thế" />
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
                                    <asp:TemplateColumn HeaderText="#" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="ID" runat="server" />
                                            <asp:HiddenField ID="HF_ID_InGrid" ClientIDMode="Static" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="4%" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Business_Vn" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Người đại diện" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="ContactUser" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="ContactMobile" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Address" runat="server" />
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
                    </div>
                    <asp:Literal ID="lbMsg" runat="server" />
                    <asp:HiddenField ID="currPage" runat="server" Visible="false" />
                    <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
                    <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
                    <asp:HiddenField runat="server" ID="hdUrlRefer" Visible="False" />
                    <asp:HiddenField runat="server" ID="_HF_GrItem" Value="-1" />
                    <asp:HiddenField runat="server" ID="_SelectedId" Value="-1" />
                    <asp:HiddenField runat="server" ID="_PGDId" Value="" />
                    <asp:HiddenField runat="server" ID="_DNId" Value="" />
                    <asp:HiddenField ID="hdRefresh" runat="server" Value="false" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="PhuongXa" />

                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>
</div>

<script type="text/javascript">

    function showDialogDoanhNghiep(s, t) {
        $('#<%=_PGDId.ClientID%>').val(s);
        $('#<%=_HF_GrItem.ClientID%>').val(-1);
        $('#<%=_SelectedId.ClientID%>').val(t);
        $('#popDsDoanhNghiep').modal('show');
    }

    function closeDialogDoanhNghiep() {
        $('#popDsDoanhNghiep').modal('hide');
    }
    function setIdChoose() {
        debugger;
        var selectedId = $('input[name="GrdDN"]:checked').closest('tr').find('#HF_ID_InGrid').val();
        $('#<%=_HF_GrItem.ClientID%>').val(selectedId);
    }
    $('#popDsDoanhNghiep').on('hidden.bs.modal', function () {
        $('#<%=_PGDId.ClientID%>').val("");
        $('#<%=_HF_GrItem.ClientID%>').val(-1)
        $('#<%=_SelectedId.ClientID%>').val(-1);
        $('input[name="GrdDN"]').prop('checked', false);

    });
</script>

