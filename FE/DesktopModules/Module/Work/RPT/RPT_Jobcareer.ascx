<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="RPT_Jobcareer.ascx.vb" Inherits="Modules.Reports.Employer" %>
<div class="box box-info">
    <div class="box-header with-border">
        <h3 class="box-title">Thống kê việc làm theo ngành nghề</h3>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <asp:UpdatePanel runat="server" ID="pep">
                    <ContentTemplate>
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker TinhTP" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="PhuongXa" CssClass="selectpicker PhuongXa" AutoPostBack="true" runat="server" />
                        </div>
                             <div class="col-md-2">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-1 col-xs-4 pdt5 lb">Từ ngày</div>
                        <div class="col-md-2 col-xs-8">
                            <div class="rccalpopup">
                                <asp:TextBox ID="FromDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                            </div>
                        </div>
                        <div class="col-md-1 col-xs-4 pdt5 lb">Đến ngày</div>
                        <div class="col-md-2 col-xs-8">
                            <div class="rccalpopup">
                                <asp:TextBox ID="ToDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                            </div>
                        </div>
                        <div class="clear"></div>
                       
                        <div class="col-md-3 none">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="row">
                <div class="ctable"></div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdRun" Text="Xem báo cáo" CssClass="cmsbut cmsbtrun" OnClientClick="reports(); return false;" runat="server" />
        <%--<asp:Button ID="cmdExport" Text="Xuất ra excel" CssClass="cmsbut cmdExcel" OnClientClick="return false;" runat="server" />--%>
        <asp:Button ID="cmdExport" runat="server" OnClientClick="TinTuyenDung(); return false" Text="Xuất ra excel" CssClass="cmsbut cmdexel cbclick" />
    </div>
</div>
<script type="text/javascript">
             function TinTuyenDung() {
                var dtype = $("#xlsx:checked").val();
                var TinhTP = $("#<%= TinhTP.ClientID%>").val();
                 var PhuongXa =$("#<%= PhuongXa.ClientID%>").val();
                 var TuNgay = $("#<%= FromDate.ClientID%>").val();
                 var DenNgay = $("#<%= ToDate.ClientID%>").val();
                 var car = $("#<%= Career_ID.ClientID%>").val();
                 var sal = $("#<%= Salary_ID.ClientID%>").val();
                 if (dtype == "true") { dtype = ".xlsx" }
                 else { dtype = ".xls" }
                 window.open("/api/work/export.aspx?typeid=TDNganhNghe&pid=<%=Me.PortalId%>&TinhTP=" + TinhTP + "&PhuongXa=" + PhuongXa + "&TuNgay=" + TuNgay + "&DenNgay=" + DenNgay + "&car=" + car + "&sal=" + sal)
    };
    function reports() {
        waiting();
        var tod, fromd, tp, px,car,sal;
        fromd = $("#<%= FromDate.ClientID%>").val(); if (fromd != "") { fromd = fromd.replace("/", "-").replace("/", "-") }
        tod = $("#<%= ToDate.ClientID%>").val(); if (tod != "") { tod = tod.replace("/", "-").replace("/", "-") }
        tp = $("#<%= TinhTP.ClientID%>").val(); px = $("#<%= PhuongXa.ClientID%>").val();
        car = $("#<%= Career_ID.ClientID%>").val();sal = $("#<%= Salary_ID.ClientID%>").val();
        $.ajax({
            type: 'GET', url: '/api/work/reports.asmx/getValue?pid=' + <%= Me.PortalId  %> + "&tp=" + tp + "&px=" + px + "&fd=" + fromd + "&td=" + tod + "&car=" + car + "&sal=" + sal + "&key=career",
            success: function (data) {  removewaiting(); var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".ctable").html(json.data); }; },
        });
      
    };
    $(document).ready(function () { reports(); });
</script>
