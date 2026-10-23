<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Reports2.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports2" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-6">
            <h3 class="box-title">THỐNG KÊ BÀI VIẾT THEO NGƯỜI ĐĂNG TIN
            </h3>
        </div>
         <div class="col-md-6">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker"></asp:DropDownList>
          </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:DropDownList ID="drUser" runat="server" CssClass="selectpicker" />
                </div>
                <div class="col-md-1 col-xs-4 pdt5 b lb">Từ ngày</div>
                <div class="col-md-2 col-xs-8">
                    <div class="rccalpopup date-pub">
                        <asp:TextBox ID="FromDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
                </div>
                <div class="col-md-1 col-xs-4 txt-right pdt5 lb">Đến ngày</div>
                <div class="col-md-2 col-xs-8">
                    <div class="rccalpopup date-pub">
                        <asp:TextBox ID="ToDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
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
    var user, tod, fromd, portal, link, msg, pban;
    function getID() {
        user = $("#<%= drUser.ClientID%>").val();
        tod = $("#<%=ToDate.ClientID%>").val();
        fromd = $("#<%= FromDate.ClientID%>").val();
        portal = $("#<%= ddlPortal.ClientID%>").val();
        pban = 1
        if (fromd != "") fromd = fromd.replace("/", "-").replace("/", "-")
        if (tod != "") tod = tod.replace("/", "-").replace("/", "-")
    };
    function reports() {
        getID(); link = "/api/cms/reports2.ashx?fd=" + fromd + "&td=" + tod + "&pban=" + pban + "&portal=" + portal + "&user=" + user;
        msg = $.ajax({ url: link, async: false }).responseText; $(".ctable").html(msg); setTimeout(removewaiting(), 2000);
    };
    function exports() {
        getID(); link = "/api/cms/reports.aspx?fd=" + fromd + "&td=" + tod + "&pban=" + pban + "&portal=" + portal + "&user=" + user + "&rpt=2";
        window.open(link); setTimeout(removewaiting(), 2000);
    }
    $(document).ready(function () { reports(); });

</script>
