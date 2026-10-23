<%@ Control Language="vb" CodeFile="ImportAdvView.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">Nhập số liệu chỉ tiêu đầu vào theo nhiều kỳ</h3>
        </div>
        <div class="col-md-4 text-right">
            <a onclick="popexp('exports'); return false;" class="cmsbut cbclick cmdcol cmsbtExport">Tải mẫu Excel</a>
            <a id="cmdImport" runat="server" style="height: auto" onclick="upfile();" title="Import excel" class="cmsbut cmsbtImport cmdcol">Import excel</a>
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
                    <asp:DropDownList ID="drGroup_ID" onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-1 lb text-center">Số năm</div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drNumYear" onchange="retunwaiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal runat="server" ID="litData" />
                </div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
        <asp:Button ID="cmdSave" runat="server" Text="Lưu dữ liệu" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
    </div>
</div>
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="TargetID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="YearID" Value="0" runat="server" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />

<script type="text/javascript">
    function upfile(t) { jQuery("#<%= fileImages.ClientID%>").click(); }; function upLoad() { jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
    function exports() { var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" } window.open("/api/analy/reports.aspx?pid=0&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&gr=" + $("#<%=drGroup_ID.ClientID %>").val() + "&yr=" + $("#<%=YearID.ClientID %>").val() + "&tid=2&num=" + $("#<%=drNumYear.ClientID %>").val()) };
    function submitsum() { $(".caculator").attr("style", "background: url(/image/images/loader.gif)center 10px no-repeat;"); setTimeout("lienket()", 50); return false; };
</script>

