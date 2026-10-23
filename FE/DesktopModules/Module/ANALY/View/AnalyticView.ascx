<%@ Control Language="vb" CodeFile="AnalyticView.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Danh mục đánh giá phân tích chỉ tiêu báo cáo</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drGroup_ID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 pdt5 text-right">Chọn c.tiêu</div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="drTarget" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <b><u>Ghi chú:</u> Thêm vào {0}: Giá trị năm báo cáo trừ năm phân tích;  Thêm vào {1}: Giá trị năm báo cáo; Thêm vào {2}: Giá trị năm phân tích; Thêm vào {3}: Tên tỉnh/thành phố</b>
                        </div>
                    </div>
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
                                <asp:TemplateColumn HeaderText="Giá trị phân tích">
                                    <ItemTemplate>
                                        <div class="col-md-3 col-xs-2">Từ</div>
                                        <div class="col-md-9 col-xs-10">
                                            <asp:TextBox ID="ValueFrom" runat="server" CssClass="TextBox txt-center noborder" />
                                        </div>
                                        <div class="col-md-3 col-xs-2">Đến</div>
                                        <div class="col-md-9 col-xs-10">
                                            <asp:TextBox ID="ValueTo" runat="server" CssClass="TextBox txt-center noborder" />
                                        </div>
                                        <div class="col-md-3 col-xs-2 pt5">C.Báo</div>
                                        <div class="col-md-9 col-xs-10">
                                            <asp:DropDownList ID="drFlag" runat="server" CssClass="selectpicker" />
                                        </div>
                                        <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </ItemTemplate>
                                    <ItemStyle Width="20%" CssClass="column-primary" />
                                    <HeaderStyle Width="20%" CssClass="column-primary" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Nội dung đánh giá">
                                    <ItemTemplate>
                                        <div class="col-md-12 nddg">
                                            <asp:TextBox ID="Contents" runat="server" TextMode="MultiLine" Height="100" line-height="17" CssClass="TextBox noborder" />
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle CssClass="Contents respo-view" />
                                    <HeaderStyle CssClass="Contents respo-title" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Phương án xử lý">
                                    <ItemTemplate>
                                        <div class="col-md-12 nddg">
                                            <asp:TextBox ID="Solution" runat="server" TextMode="MultiLine" Height="100" CssClass="TextBox noborder" />
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle CssClass="Contents respo-view" />
                                    <HeaderStyle CssClass="Contents respo-title" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Xóa">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsDelete" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-title" />
                                    <ItemStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-view" />
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
        <asp:AsyncPostBackTrigger ControlID="drTarget" />
        <asp:AsyncPostBackTrigger ControlID="drGroup_ID" />
        <asp:AsyncPostBackTrigger ControlID="cmdSave" />
    </Triggers>
</asp:UpdatePanel>
<script type="text/javascript">
    function deleRow(pid, id, t) {
        if (confirm("Bạn có muốn xóa dòng này đi không?")) {
            $.ajax({
                type: "GET", url: '/api/target/common.asmx/deleteAnalytic?pid=' + pid + "&id=" + id, success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data == "1") { $(t).parents("tr").remove(); notify('success', 'Đã xóa dòng lựa chọn thành công.', 'Thông báo', false); };
                },
            });
        }
    };
</script>
