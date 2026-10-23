<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Report12.ascx.vb" Inherits="Modules.Report.Edit" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">KHO BÁO CÁO TỔNG HỢP</h3>
        </div>
        <div class="col-md-1 col-xs-3 txt-center lb">Năm BC</div>
        <div class="col-md-1 col-xs-9">
            <asp:DropDownList ID="Years_ID" runat="server" AutoPostBack="true" CssClass="selectpicker Years_ID" />
        </div>
        <div class="col-md-2 txt-center">
            <asp:Button ID="cmdRun" runat="server" Text="Tổng hợp số liệu" CssClass="cmsbut cmdTH" />
            <asp:Button ID="cmdRefresh" runat="server" Text="cmdRefresh" CssClass="none cmdRefresh" />
            <asp:Button ID="cmdRunAll" runat="server" Text="cmdRunAll" CssClass="none cmdRunAll" OnClientClick="return retunwaiting();" />
            <asp:Button ID="cmdRun1" runat="server" Text="cmdRun1" CssClass="none cmdRun1" OnClientClick="return retunwaiting();" />
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
                            <asp:TemplateColumn HeaderText="Mã mẫu biểu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="MaBC" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên biểu mẫu khai thác" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenBaoCao" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tải số liệu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TaiVe" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                <ItemStyle Width="12%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tổng hợp số liệu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TongHop" runat="server" />
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
</div>

<script type="text/javascript">
    function cmdRun_Click() { waiting(); $(".cmdRunAll").click(); }
    function cmdRefresh_Click() { waiting(); $(".cmdRun1").click(); }
    function tonghop(id) {
        $("#<%=_BCID.ClientID%>").val(id); $(".cmdRefresh").click();
    }
    function exports(id) {
        var tp = $("#<%=drTinhTP.ClientID%>").val();
        var qh = $("#<%=drQuanHuyen.ClientID%>").val();
        var px = $("#<%=drPhuongXa.ClientID%>").val();
        var nam = $("#<%=Years_ID.ClientID%>").val();
        var mbc = $(".id-" + id).attr("mbc");
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExCungLD&typeid=" + mbc + "&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&year=" + nam + "&dtype=" + dtype);
         return false;
    };
</script>

