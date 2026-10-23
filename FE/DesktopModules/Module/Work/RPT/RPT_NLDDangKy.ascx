<%@ Control Language="vb" Inherits="Modules.Reports.Statistics" ClientIDMode="Static" CodeFile="RPT_NLDDangKy.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<script src="/js/validation/highcharts.js?v=3.0" type="text/javascript"></script>
<script src="/js/validation/exporting.js?v=3.0" type="text/javascript"></script>
<script src="/js/validation/data.js?v=3.0" type="text/javascript"></script>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Thống kê lượt NLĐ đăng ký mới</h3>
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
        
                        <div class="col-md-2 col-xs-12"><asp:LinkButton runat="server" ID="btnSearch" OnClick="btnSearch_Click"></asp:LinkButton></div>
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
