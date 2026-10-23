<%@ Control Language="vb" CodeFile="ExBook.ascx.vb" Inherits="Modules.ExBook.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9 pdl0">
            <h3 class="box-title">Xuất sổ Cầu lao động</h3>
        </div>
        <div class="col-md-3">
            <div class="alert alert-danger mgbt0">
                Kỳ nhập liệu năm
                        <asp:Literal ID="txtYear" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <fieldset>
                    <legend>Chọn cấp hành chính để xuất dữ liệu</legend>
                    <div class="col-md-4 lb">Kỳ nhập liệu</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="drYear" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                    </div>
                    <div class="col-md-4 lb">Tỉnh/ thành phố</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="TinhTP" Enabled="false" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-4  lb">Quận/ huyện</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="QuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-4 lb">Xã/ phường</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker " />
                    </div>
                </fieldset>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" OnClientClick="exportsBook()" Text="Thực hiện" CssClass="cmsbut cmsbtnew cmsbtmerger" />
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="YearPro" runat="server" />

<script>
    function exportsBook() {
        var tp = $("#<%=TinhTP.ClientID %>").val();
        var qh = $("#<%=QuanHuyen.ClientID %>").val();
        var xp = $("#<%=XaPhuong.ClientID %>").val();
        var year = $("#<%=drYear.ClientID %>").val();
         var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        if (confirm('Quá trình này sẽ mất nhiều thời gian, bạn có chắc chắn muốn thực hiện?') == true) {
<%--         window.open("/api/work/cauld.aspx?id=exBook&pid=0&tp=" + $("#<%=TinhTP.ClientID%>").val() + "&qh=" + $("#<%=QuanHuyen.ClientID%>").val() + "&xa=" + $("#<%=XaPhuong.ClientID%>").val() + "&nam=" + $("#<%=drYear.ClientID%>").val())--%>
         window.open("/exports?page=work&view=ExCauLD&typeid=exBook&pid=0&tp=" + tp + "&qh=" + qh + "&xp=" + xp + "&year=" + year + "&dtype=" + dtype);

        }
    };
</script>
