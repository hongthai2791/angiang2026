<%@ Control Language="vb" CodeFile="CalcAdv.ascx.vb" Inherits="Modules.Report.CalcAdv" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Tổng hợp số liệu đa chiều</h3>
        </div>
        
        <div class="col-md-6 alert alert-warning mgbt0">
                Chức năng này chạy dữ liệu từ các nhóm số liệu thô
        </div>
        <div class="col-md-1 lb text-center none">Tỉnh/TP</div>
        <div class="col-md-3 none">
            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="col-md-2 none txt-center lb">Chọn cách tính</div>
        <div class="col-md-1 none ">
            <asp:DropDownList ID="drDataType" runat="server" CssClass="selectpicker"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 lb text-center">Chọn nhóm chỉ tiêu</div>
                <div class="col-md-6">
                    <asp:DropDownList ID="drGroup" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb text-center">Chọn kỳ dữ liệu</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2 txt-center lb">Chọn dữ liệu hàng</div>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="drTarRow" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="col-md-2 txt-center lb">Chọn dữ liệu cột</div>
                <div class="col-md-4 ">
                    <asp:DropDownList ID="drTarCol" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12 ">
                    <asp:Literal runat="server" ID="litData" />
                    <div class="clear"></div>
                </div>
            </div>
            <div class="clr"></div>
            <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button runat="server" ID="cmdView" Text="Xem kết quả" class="cmsbut cmdview"></asp:Button>
        <asp:Button runat="server" ID="cmdExport" Text="Xuất Excel" class="cmsbut cmdExcel"></asp:Button>
    </div>
</div>
<script>
  <%--  function caculatorData() {
        waiting();
        var data = $("#DataReportAdv");
        data.html("Không có dữ liệu được tìm thấy")
        $.ajax({
            type: 'GET', url: '/api/analy/data.asmx/CaculatorData?pid=' + <%=Me.PortalId%> + '&tp=' + $("#<%=TinhTP.ClientID%>").val() + '&gr=' + $("#<%=drGroup.ClientID%>").val()
             + '&yr=' + $("#<%=drYear.ClientID%>").val() + '&row=' + $("#<%=drTarRow.ClientID%>").val() + '&col=' + $("#<%=drTarCol.ClientID%>").val(),
             success: function (data) {
                 var json = $.parseJSON($(data).find("string").text());
                 if (json.data) { $("#DataReportAdv").html(json.data); };
                 removewaiting();
             },
         });

     }--%>
</script>
