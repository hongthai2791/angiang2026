<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Report13.ascx.vb" Inherits="Modules.Report.Edit" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">THEO DÕI NHẬP LIỆU (<asp:Literal ID="litCount" runat="server" Text="0" />)</h3>
        </div>
        <div class="col-md-1 col-xs-3 txt-center lb">Năm BC</div>
        <div class="col-md-3 col-xs-9">
            <asp:DropDownList ID="Years_ID" runat="server" AutoPostBack="true" CssClass="selectpicker Years_ID" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-1 hidden-xs txt-center lb">Tỉnh/TP</div>
                <div class="col-md-3 ">
                    <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                </div>
                <div class="col-md-1 pdl0 pdr0 hidden-xs txt-center lb">Quận/huyện</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                </div>
                <div class="col-md-1 pdl0 pdr0 hidden-xs txt-center lb">Xã/phường</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DropDownList runat="server" id="drCreateUser" Visible="false"></asp:DropDownList>
                    <asp:DropDownList runat="server" id="drUpdatedUser" Visible="false"></asp:DropDownList>
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#f8f4f1" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="STT" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle Width="5%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Họ tên " HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="HoTen" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên tài khoản" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenTaiKhoan" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" />
                                <ItemStyle Width="12%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Email" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" />
                                <ItemStyle Width="15%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Thêm mới" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="SoDoiTuongTM" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                <ItemStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Biến động" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="SoDoiTuongBD" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                <ItemStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày tạo" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="NgayTao" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                <ItemStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>
            <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
            <asp:HiddenField ID="IsNow" runat="server" />
            <asp:HiddenField ID="YearPro" runat="server" />
            <asp:HiddenField ID="_BCID" runat="server" />
            <asp:HiddenField ID="_TenVT" runat="server" />
            <asp:HiddenField ID="regionalID" runat="server" Value="0" />
            <asp:HiddenField ID="regionalLevel" runat="server" Value="1" />
        </div>
    </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" Cssclass="cmsbut cmsback" />
                <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" Cssclass="cmsbut cmdview " />
                <asp:Button ID="cmdExport"  OnClientClick="popexp('exports');" runat="server" Text="Xuất ra Excel" Cssclass="cmsbut cmdexel " />
                <div class="clear"></div>
            </div>
        </div>
</div>

<script type="text/javascript">
  
    function exports(id) {
        var tp = $("#<%=drTinhTP.ClientID%>").val();
        var qh = $("#<%=drQuanHuyen.ClientID%>").val();
        var px = $("#<%=drPhuongXa.ClientID%>").val();
        var nam = $("#<%=Years_ID.ClientID%>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExCungLD&typeid=report-thirdty&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&year=" + nam + "&dtype=" + dtype);
         return false;
    };
</script>

        
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drTinhTP" />
        <asp:AsyncPostBackTrigger ControlID="drQuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="drPhuongXa" />
    </Triggers>
</asp:UpdatePanel>