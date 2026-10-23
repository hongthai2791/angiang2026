<%@ Control Language="vb" CodeFile="MagazinePublic.ascx.vb" Inherits="Modules.Group.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Danh sách các ấn phẩm xuất bản</h3>
        </div>
        <div class="col-md-2 none">
            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-md-2 none lb txt-center">Chọn kỳ dữ liệu</div>
        <div class="col-md-2 none">
            <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <asp:Literal runat="server" ID="litData" />
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<script type="text/javascript">
    function exportsMagazine(id) { window.open("/api/analy/reports.aspx?pid=0&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&tid=1&id=" + id + "&yr=" + $("#<%=drYear.ClientID %>").val()); };
</script>
