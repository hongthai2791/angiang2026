<%@ Control Language="vb" Inherits="Modules.Reports.Statistics" ClientIDMode="Static" CodeFile="RPT_Statistics.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<script src="/js/validation/highcharts.js?v=3.0" type="text/javascript"></script>
<script src="/js/validation/exporting.js?v=3.0" type="text/javascript"></script>
<script src="/js/validation/data.js?v=3.0" type="text/javascript"></script>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">Thống kê lượt truy cập website</h3>
        </div>
        <div class="col-md-2">
            <asp:DropDownList ID="Months" runat="server" CssClass="selectpicker" AutoPostBack="true" />
        </div>
        <div class="col-md-2">
            <asp:DropDownList ID="Years" runat="server" CssClass="selectpicker" AutoPostBack="true" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div id="container2" class="das-char"></div>
            </div>
        </div>
    </div>
</div>
<script><%=strData%></script>
