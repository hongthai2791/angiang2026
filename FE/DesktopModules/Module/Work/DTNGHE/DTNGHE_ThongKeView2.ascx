<%@ Control Language="vb" CodeFile="DTNGHE_ThongKeView2.ascx.vb" Inherits="Modules.DTNGHE_ThongKeNgayTCView.View" %>
<style>
   .radio-inline input[type=radio]{
       
    margin-left: -20px !important;
   }
    .radio-inline label {
        margin-top: 0px !important;
    }
</style>
<asp:UpdatePanel ID="upChart" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <h3 class="box-title">Thống kê Lớp học theo Thời gian tổ chức (Ngày khai giảng)</h3>
            </div>
            <div class="box-body">
                <div class="form-inline" style="margin-bottom: 20px; text-align: center;">
                    <div class="col-md-6">

                        <asp:RadioButtonList ID="rblViewType" runat="server" RepeatDirection="Horizontal" AutoPostBack="true" CssClass="lst-viewtype radio-inline table">
                            <asp:ListItem Value="YEAR" Selected="True">Xem theo Năm</asp:ListItem>
                            <asp:ListItem Value="MONTH">Xem theo Tháng</asp:ListItem>
                        </asp:RadioButtonList>

                    </div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drNam" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drThang" runat="server" CssClass="selectpicker" Visible="false">
                            <%-- Các tháng sẽ được thêm từ code-behind --%>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2">
                    <asp:Button ID="cmdXemThongKe" runat="server" Text="Xem thống kê" CssClass="btn btn-primary" /> </div>
                </div>

                <div id="chartContainerNgayTC" style="width: 100%; height: 400px;"></div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<script src="/js/validation/highcharts.js?v=1.2"></script>
<script src="/js/validation/exporting.js?v=1.2"></script>
