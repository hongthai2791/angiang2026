<%@ Control Language="vb" CodeFile="Report3.ascx.vb" Inherits="Modules.Report.view" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Hiển thị kết quả dự báo dạng bảng dữ liệu</h3>
        </div>
        
        <div class="col-md-6 alert alert-warning mgbt0">
                Chức năng này chạy dữ liệu từ các nhóm chỉ tiêu tổng hợp
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel ID="upReport3" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-2 lb">Tỉnh/Thành phố</div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="drGroup" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drTagetID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="drGroup" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="row">
                <div class="col-md-2 pdt5">
                    <a style="color: brown; font-weight: bold" title="Chọn dữ liệu của quá khứ để phân tích"><i class="fa fa-exchange"></i>&nbsp;Khoảng quan sát</a>
                </div>
                <div class="col-md-3">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-3">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2 text-right pdt5">
                    <strong>Số năm dự báo&nbsp;  <i title="Số năm dự báo" class="fa fa-question-circle"></i></strong>
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" MinValue="1" MaxValue="7" ID="txtSoNam" CssClass="TextBox" Value="5" runat="server"></telerik:RadNumericTextBox>
                </div>

            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="h5-title">Bảng thống kê số liệu</div>
                </div>
                <asp:DataGrid ID="grdAnalytic" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                    <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                    <ItemStyle BackColor="#fbf2ec" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="STT">
                            <ItemTemplate>
                                <asp:Literal runat="server" ID="IsOrder" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="11%" CssClass="respo-view" />
                            <HeaderStyle HorizontalAlign="Center" Width="11%" CssClass="respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Năm">
                            <ItemTemplate>
                                <asp:Literal runat="server" ID="txtYear" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="30%" CssClass="column-primary" />
                            <HeaderStyle HorizontalAlign="Center" Width="30%" CssClass="column-primary" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Số liệu">
                            <ItemTemplate>
                                <div class="col-sm-12 pd0">
                                    <asp:Literal ID="Data1" runat="server" />
                                </div>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" CssClass="Contents respo-view" />
                            <HeaderStyle HorizontalAlign="Center" CssClass="Contents respo-title" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="IsFlag">
                            <ItemTemplate>
                                <div class="col-sm-12 pd0">
                                    <asp:TextBox ID="IsFlag" type="number" runat="server" CssClass="TextBox noborder" />
                                </div>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" CssClass="Contents respo-view none" />
                            <HeaderStyle HorizontalAlign="Center" CssClass="Contents respo-title none" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
                <div class="row panel panel-warning pd5 mgt30">
                    <p>- Ghi chú: Màu  <span class="fa fa-circle" style="color: yellowgreen; padding-top: 10px"></span>&nbsp;là hiển thị số liệu dự báo của các năm tương lai</p>
                    <strong>Lưu ý:</strong> &nbsp; Dữ liệu được tổng hợp từ các kết quả đã lưu lại từ phần dự báo
                </div>
            </div>

            <div class="clear"></div>
        </div>
        <asp:Literal runat="server" ID="litPage"></asp:Literal>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
        <asp:Button ID="cmdRefresh" runat="server" Text="Xem kết quả" CssClass="cmsbut Refresh cbclick " OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" CssClass="cmsbut cmdexel " />
    </div>
</div>

<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="TargetID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="GroupID" Value="0" runat="server" Visible="false" />
