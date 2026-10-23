<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="DaThongBao.ascx.vb" Inherits="DesktopModules.Modules.Reports.DaThongBao" %>
<asp:UpdatePanel runat="server" ID="AP">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-8">
                    <h3 class="box-title">DANH SÁCH DOANH NGHIỆP ĐÃ NỘP THÔNG BÁO (<asp:Literal ID="litCount" runat="server"></asp:Literal>)</h3>
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker QuanHuyen" />
                        </div>
                        <div class="col-md-1 col-xs-4 txt-center lb">Năm</div>
                        <div class="col-md-2 col-xs-8">
                            <asp:DropDownList ID="Years_ID" runat="server" CssClass="selectpicker Years_ID" />
                        </div>
                        <div class="col-md-1 col-xs-4 txt-center lb">Kỳ BC</div>
                        <div class="col-md-3 col-xs-8">
                            <asp:DropDownList ID="Period_ID" runat="server" CssClass="selectpicker Period_ID" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
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
                                <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Address" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="30%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Kỳ/năm thông báo" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Years_ID" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày nộp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayNop" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                        <asp:HiddenField ID="hidTotal" runat="server"  />
                        <asp:HiddenField ID="currPage" runat="server"  />
                    </div>
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdRun" Text="Xem báo cáo" CssClass="cmsbut cmsbtrun" runat="server" />
                        <asp:Button ID="cmdExport" OnClientClick="popexp('exports');" Text="Xuất ra excel" CssClass="cmsbut cmdExcel" runat="server" />

                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdRun" />
        <asp:AsyncPostBackTrigger ControlID="cmdExport" />
    </Triggers>
</asp:UpdatePanel>

<script>
    function exports() {
        var txtkey = $("#<%=txtkey.ClientID %>").val();
        var tp = $("#<%=TinhTP.ClientID %>").val();
        var qh = $("#<%=QuanHuyen.ClientID %>").val();
        var kyBC = $("#<%=Period_ID.ClientID %>").val();
        var year = $("#<%=Years_ID.ClientID %>").val();
        var total = $("#<%=hidTotal.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExCauLD&typeid=DaThongBao&pid=0&txtkey=" + txtkey + "&tp=" + tp + "&qh=" + qh + "&kyBC=" + kyBC + "&year=" + year + "&total=" + total + "&dtype=" + dtype);
        return false;
    };
</script>