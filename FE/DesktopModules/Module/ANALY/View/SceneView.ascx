<%@ Control Language="vb" CodeFile="SceneView.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7">
                    <h3 class="box-title">Xây dựng kịch bản</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TinhTP"   onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drTypeScene"  onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:DataGrid ID="grdAnalytic" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT">
                                    <ItemTemplate>
                                        <asp:TextBox ID="IsOrder" ReadOnly="true" runat="server" CssClass="std med txt-center noborder" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                    <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Năm">
                                    <ItemTemplate>
                                        <asp:TextBox ID="YearID" runat="server" CssClass="std med txt-center noborder" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Giá trị">
                                    <ItemTemplate>
                                        <asp:TextBox ID="Data" runat="server" CssClass="std med txt-center noborder" />
                                    </ItemTemplate>
                                    <ItemStyle Width="20%" CssClass="column-primary" />
                                    <HeaderStyle Width="20%" CssClass="column-primary" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                        <table cellspacing="0" id="tblRow" runat="server" cellpadding="3" border="0" style="width: 100%; border-collapse: collapse; border-top: 0px!important">
                            <tbody>
                                <tr style="border-top: 0px!important; background: #fff;">
                                    <td style="border-top: 0px!important; text-align: center; font-weight: bold;"></td>
                                    <td style="border-top: 0px!important; text-align: center; width: 50px">
                                        <asp:Button ID="cmdAddRow" runat="server" ToolTip="Thêm dòng" CssClass="cmsbut-td cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach'); " />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class="clear"></div>
                </div>
                <asp:Literal runat="server" ID="litPage"></asp:Literal>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
            </div>
        </div>
        <asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="cmdAddRow" />
        <asp:AsyncPostBackTrigger ControlID="cmdSave" />
    </Triggers>
</asp:UpdatePanel>
<script type="text/javascript">
    function deleRow(pid, id, t) {
        if (confirm("Bạn có muốn xóa dòng này đi không?")) {
            $.ajax({
                type: "GET", url: '/api/analy/common.asmx/deleteAnalytic?pid=' + pid + "&id=" + id, success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { $(t).parents("tr").remove(); notify('success', 'Đã xóa dòng lựa chọn thành công.', 'Thông báo', false); };
                },
            });
        }
    };
</script>
