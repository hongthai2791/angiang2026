<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Reports3.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports3" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-6">
            <h3 class="box-title">THỐNG KÊ BÀI VIẾT THEO CHUYÊN MỤC
            </h3>
        </div>
          <div class="col-md-6">
                    <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-4">
                    <asp:DropDownList ID="drCategory" runat="server" CssClass="selectpicker" />
                </div>
                
                <div class="col-md-1 col-xs-4 pdt5 b lb">Từ ngày</div>
                <div class="col-md-2 col-xs-8">
                    <div class="rccalpopup date-pub">
                        <asp:TextBox ID="FromDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
                </div>
                <div class="col-md-1 col-xs-4  pdt5 lb">Đến ngày</div>
                <div class="col-md-2 col-xs-8">
                    <div class="rccalpopup date-pub">
                        <asp:TextBox ID="ToDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
                </div>
                <div class="col-md-2 pdt5 col-xs-12">
                    <asp:CheckBox ID="chkFlag" CssClass="CheckBox" Text=" Báo cáo tổng hợp" runat="server" />
                </div>

                <div class="clear"></div>
            </div> 
            <div class="row">
                <div class="ctable rep-table"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdRun" Text="Xem báo cáo" CssClass="cmdbtt cmdReport" OnClientClick="waiting();reports(); return false;" runat="server" />
        <asp:Button ID="cmdExport" Text="Xuất ra excel" CssClass="cmdbtt cmdExcel" OnClientClick="waiting();exports(); return false;" runat="server" />
    </div>
</div>
<script>
    var cad, tod, fromd, portal, link, msg;
    function getID() {
        cad = $("#<%= drCategory.ClientID%>").val(); tod = $("#<%= toDate.ClientID%>").val();
        fromd = $("#<%= FromDate.ClientID%>").val(); portal = $("#<%= ddlPortal.ClientID%>").val();
        flag = document.getElementById('<%=chkFlag.ClientID%>').checked;
        if (fromd != "") fromd = fromd.replace("/", "-").replace("/", "-")
        if (tod != "") tod = tod.replace("/", "-").replace("/", "-")
    };
    function reports() {
        getID(); link = "/api/cms/reports3.ashx?fd=" + fromd + "&flag=" + flag + "&td=" + tod + "&portal=" + portal + "&cad=" + cad;
        msg = $.ajax({ url: link, async: false }).responseText; $(".ctable").html(msg); setTimeout(removewaiting(), 2000);
    };
    function exports() {
        getID(); link = "/api/cms/reports.aspx?fd=" + fromd + "&flag=" + flag + "&td=" + tod + "&portal=" + portal + "&cad=" + cad + "&rpt=3";
        window.open(link); setTimeout(removewaiting(), 2000);
    }
    $(document).ready(function () { reports(); });
</script>
