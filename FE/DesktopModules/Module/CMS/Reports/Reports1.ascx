<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Reports1.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports1" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">DANH SÁCH TIN ĐƯỢC ĐỌC NHIỀU NHẤT
            </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-3 col-xs-7">
                    <asp:DropDownList ID="ddlPortal" runat="server" AutoPostBack="true" CssClass="selectpicker" Width="40%"></asp:DropDownList>
                </div>
                <div class="col-md-1 col-xs-4 pdt5 lb" style="margin-left:10px;">Số tin </div>
                <div class="col-md-1 col-xs-8" style="margin-left:10px;">
                    <asp:DropDownList ID="drTop" runat="server" CssClass="selectpicker" />
                </div>
                 <div class="col-md-1 col-xs-4 pdt5  lb" style="margin-left:10px; margin-right:15px;">Từ ngày</div>
                    <div class="rccalpopup" >
                        <asp:TextBox ID="FromDate" runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
                 <div class="col-md-1 col-xs-4 pdt5  lb" style="margin-left:15px;margin-right:15px;">Đến ngày</div>
                    <div class="rccalpopup"  >
                        <asp:TextBox ID="ToDate"  runat="server" Width="100px" CssClass="datepicker" PlaceHolder="Chọn ngày" />
                    </div>
                <div class="col-md-2 col-xs-5 pdt5" style="padding-left:30px;">
                    <asp:CheckBox  ID="chkFlag"   CssClass="CheckBox" Text=" Đọc ít nhất" runat="server" />
                </div>
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
    var _top, tod, fromd, portal, flag, link, msg;
    function getID() {
        _top = $("#<%= drTop.ClientID%>").val(); tod = $("#<%=ToDate.ClientID%>").val();
        fromd = $("#<%= FromDate.ClientID%>").val(); portal = $("#<%= ddlPortal.ClientID%>").val();
        flag = document.getElementById('<%=chkFlag.ClientID%>').checked;
        if (fromd != "") fromd = fromd.replace("/", "-").replace("/", "-");
        if (tod != "") tod = tod.replace("/", "-").replace("/", "-");
    };
    function reports() {
        getID(); link = "/api/cms/reports1.ashx?fd=" + fromd + "&td=" + tod + "&portal=" + portal + "&flag=" + flag + "&top=" + _top;
        msg = $.ajax({ url: link, async: false }).responseText; $(".ctable").html(msg); setTimeout(removewaiting(), 2000);
    };
    function exports() {
        getID(); link = "/api/cms/reports.aspx?fd=" + fromd + "&td=" + tod + "&portal=" + portal + "&flag=" + flag + "&top=" + _top + "&rpt=1";
        window.open(link); setTimeout(removewaiting(), 2000);
    };
    $(document).ready(function () { reports(); });

</script>
