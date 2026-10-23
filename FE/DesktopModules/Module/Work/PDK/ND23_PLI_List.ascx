<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ND23_PLI_List.ascx.vb" Inherits="DesktopModules.PDK.ND23_PLI_List" %>
<asp:UpdatePanel ID="upAuthors" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH PHIẾU ĐĂNG KÝ DÀNH CHO NLĐ
                    </h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-4 col-xs-12 pdl0">
                            <asp:DropDownList ID="ddlPortal" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                        </div>
                        
                        <div class="col-md-4">
                            
                            <asp:DropDownList ID="drYear" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                        </div>
                        <div class="col-md-4 col-xs-12 pdr0">
                            <asp:TextBox ID="txtKey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                            <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                        </div>
                        <div class="clear"></div>
                    </div>

                    <div style="clear: both"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdData" Width="100%" DataKeyField="Id" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:Literal ID="STT" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mã">
                                        <ItemTemplate>
                                            <asp:Literal ID="Code" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="penname respo-view" />
                                        <HeaderStyle Width="15%" CssClass="penname respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Họ và tên">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col1" runat="server" />
                                            <div class="toggle-row" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="CCCD">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col2" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="Col2 respo-view" />
                                        <HeaderStyle Width="12%" CssClass="Col2 respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày sinh">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col3" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" CssClass="Col3 respo-view" />
                                        <HeaderStyle Width="10%" CssClass="Col3 respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Điện thoại">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col4" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" CssClass="Col4 respo-view" />
                                        <HeaderStyle Width="10%" CssClass="Col4 respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Email">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col5" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="Col5 respo-view" />
                                        <HeaderStyle Width="12%" CssClass="Col5 respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="T.Gian đăng ký">
                                        <ItemTemplate>
                                            <asp:Literal ID="Col6" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" CssClass="Col6 respo-view" />
                                        <HeaderStyle Width="10%" CssClass="Col6 respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="CurrentPage" runat="server" Value="0" Visible="false" />
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" />
                 <a id="A1" runat="server" style="height: auto" onclick="retunwaiting();upfile();" title="Import dữ liệu" class="cmsbut cmdExcel">Nhập từ excel</a>

                <asp:Button ID="cmdExport" OnClientClick="popexp('exports');" Text="Xuất ra excel" CssClass="cmdbtt cmdExcel" runat="server" />
                <asp:Button ID="cmdDel" Visible="false" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa" />
            </div>
        </div>
          <div runat="server" id="pnHidValue" style="display: none">
            <asp:DropDownList runat="server" ID="TinhTP" />
            <asp:DropDownList runat="server" ID="PhuongXa" />
            <asp:DropDownList runat="server" ID="drDanToc" />
            <asp:DropDownList runat="server" ID="drTonGiao" />
        <asp:HiddenField ID="YearPro" runat="server" />
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="cmdDel" />
    </Triggers>
</asp:UpdatePanel>

<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />

<script type="text/javascript">
    function upfile(t) { jQuery("#<%= fileImages.ClientID%>").click(); }; function upLoad() { jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
    function exports() {
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/api/analy/reportsNLD.aspx?pid=0&tid=1&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&yr=" + $("#<%=drYear.ClientID %>").val())
    };
</script>