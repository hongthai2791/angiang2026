<%@ Control Language="vb" AutoEventWireup="true" CodeFile="BC_THBienDong.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Báo cáo số liệu nhập tin</h3>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                </div>
                <div class="col-md-2 txt-center lb">
                    Kỳ nhập liệu
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" runat="server" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="box-table">
                            <table style="width: 100%">
                                <tr style="text-align: center; background-color: #053281; font-weight: bold; color: #fff">
                                    <td style="width: 80px" rowspan="3">STT</td>
                                    <td style="min-width: 250px" rowspan="3">Đơn vị</td>
                                    <td colspan="6">Kết quả cập nhật thông tin doanh nghiệp</td>
                                </tr>
                                <tr style="text-align: center; background-color: #053281; font-weight: bold; color: #fff">
                                    <td rowspan="2">Tổng số DN</td>
                                    <td colspan="5">Trong đó</td>
                                </tr>
                                <tr style="text-align: center; background-color: #053281; font-weight: bold; color: #fff">
                                    <td>DN phát sinh mới</td>
                                    <td>Đang hoạt động</td>
                                    <td>Không hoạt động</td>
                                    <td>Không tìm thấy</td>
                                    <td>Số DN cập nhật thông tin thay đổi</td>
                                </tr>
                                <tr style="text-align: center; background-color: #d3981e">
                                    <td>A</td>
                                    <td>B</td>
                                    <td>1=6</td>
                                    <td>2</td>
                                    <td>3</td>
                                    <td>4</td>
                                    <td>5</td>
                                    <td>6</td>
                                </tr>
                                <asp:Literal ID="litRow" runat="server"></asp:Literal>
                            </table>
                        </div>
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdTongHop" runat="server" Text="Tổng hợp báo cáo" CssClass="cmsbut cbtonghop" />
                <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" OnClientClick="retunwaiting();" CssClass="cmsbut cmdview" />
                <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" OnClientClick="popexp('exports');" CssClass="cmsbut cmdexel " />
                <div class="clear"></div>
            </div>
        </div>
        <script type="text/javascript">
            function exports() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCauLD&typeid=THBienDong&tp=" + tp + "&year=" + year + "&dtype=" + dtype);
                return false;
            };
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
