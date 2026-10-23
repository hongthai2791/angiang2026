<%@ Control Language="vb" CodeFile="ImportView.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-5">
            <h3 class="box-title">
                <asp:Literal ID="litH3" runat="server"></asp:Literal>
            </h3>
        </div>
        <div class="col-md-7 txt-right">
        <asp:Button ID="cmdTotal" runat="server" Text="Tổng hợp DL từ Cung-Cầu"  CssClass="cmsbut cbclick Refresh" />
            <asp:Button ID="cmdAdvImport" Visible="false" runat="server" Text="Nhập dữ liệu nhiều kỳ" CssClass="cmsbut cmsbtImport" />
            <asp:Button ID="cmdExport" runat="server" OnClientClick="popexp('exports'); return false" Text="Xuất ra excel" CssClass="cmsbut cbclick cmsbtExport" />
            <a id="cmdImport" runat="server" style="height: auto" onclick="waiting();upfile();" title="Import excel" class="cmsbut cmsbtImport">Nhập từ excel</a>

        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-1 txt-center lb">Tỉnh/TP</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TinhTP" onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-2 text-center lb">Nhóm chỉ tiêu</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drGroup_ID" Enabled="false" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-1 text-center lb">Kỳ dữ liệu</div>
                <div class="col-md-1">
                    <asp:DropDownList ID="YearID" onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DataGrid ID="grdTarget" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle Width="5%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mã chỉ tiêu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Targets_Code" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                <ItemStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chỉ tiêu báo cáo" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Targets_Name" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Số liệu báo cáo">
                                <ItemTemplate>
                                    <asp:TextBox ID="GiaTri" CssClass="TextBox txt-center validate[custom[number]]" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                <ItemStyle Width="20%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Đơn vị tính" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal runat="server" ID="UnitType" />
                                    <asp:HiddenField runat="server" ID="hdUnitType" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>

                    </asp:DataGrid>
                </div>
                <div class="clear"></div>
            </div>
            <asp:Literal runat="server" ID="litPage"></asp:Literal>
        </div>

    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
        <asp:Button ID="cmdSave" runat="server" Text="Lưu dữ liệu" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdRunAll" runat="server" data-toggle="tooltip" ToolTip="Tổng hợp dữ liệu từ dữ liệu khảo sát nhập vào hệ thống" Text="Tổng hợp số liệu" CssClass="cmsbut cmsbtrun"/>
        <asp:Button ID="cmdRun" runat="server" data-toggle="tooltip" ToolTip="Tính toán số liệu liên kết giữa các chỉ tiêu hoặc chỉ tiêu tổng" Text="Liên kết số liệu" CssClass="cmsbut cmsbtsubmit" OnClientClick="return submitsum(); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa dữ liệu" CssClass="cmsbut cmsbtdel" />
        <asp:Button ID="cmdSetting" runat="server" Text="Thiết lập" CssClass="cmsbut cmdSettings" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField runat="server" ID="HF_GroupCode" />
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />

<script type="text/javascript">
    function upfile(t) { jQuery("#<%= fileImages.ClientID%>").click(); }; function upLoad() { jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
    function exports() { var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" } window.open("/api/analy/reports.aspx?pid=0&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&gr=" + $("#<%=drGroup_ID.ClientID %>").val() + "&yr=" + $("#<%=YearID.ClientID %>").val() + "&tid=0") };

    function lienket() {
        var year = $("#<%=YearID.ClientID %>").val(), tinh = $("#<%=TinhTP.ClientID %>").val();
        $(".caculator").each(function (e) {
            var cacl = Base64.encode($(this).attr("b-cacl")), idk = $(this).attr("b-id");
            $.ajax({
                type: 'GET', url: '/api/analy/data.asmx/lienket?pid=0&year=' + year + '&tinh=' + tinh + '&cacl=' + cacl,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) { $("." + idk).attr("style", ""); $("." + idk).val(json.data); }
                    else { $("." + idk).attr("style", ""); }
                }
            });
        });
    };
    function submitsum() { $(".caculator").attr("style", "background: url(/image/images/loader.gif)center 10px no-repeat;"); setTimeout("lienket()", 50); return false; };
</script>

