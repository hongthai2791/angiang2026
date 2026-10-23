<%@ Control Language="VB" AutoEventWireup="false" CodeFile="USE_DoanhNghiep.ascx.vb" Inherits="Modules.SVL.US.USE_DoanhNghiep.View" %>
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />

<div class="row">
    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
        <ItemStyle BackColor="#f8f4f1" />
        <AlternatingItemStyle BackColor="#ffffff" />
        <Columns>
            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                <HeaderTemplate>
                    <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="IsCheck" runat="server" CssClass="cs-select cDel" ToolTip="Chọn" />
                </ItemTemplate>
                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="IsOrder" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="Business_Vn" runat="server" />
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="ContactMobile" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="10%" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="Address" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="30%" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Bàn số" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:TextBox ID="SoBan" ReadOnly="true" runat="server" CssClass="tx-ban" />
                </ItemTemplate>
                <HeaderStyle Width="7%" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateColumn>
        </Columns>
    </asp:DataGrid>
    <div id="myDetailDN" class="modal fade" role="dialog">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header1">
                    <h4 class="modal-title" style="background: none !important">&nbsp;Thông tin chi tiết doanh nghiệp</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body " data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; height: 500px">
                    <div class="row" style="top: 0px !important">
                        <div class="myDetailDN">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function popDetailDN(pid, id) {
        waiting();
        $.ajax({
            type: 'GET', url: '/api/member/data.asmx/DetailBusiness?pid=' + pid + '&id=' + id,
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) { $(".myDetailDN").html(json.data); removewaiting(); $("#myDetailDN").modal('show'); };
            },
        });
    };
</script>
