<%@ Page Language="VB" AutoEventWireup="false" ClientIDMode="Static" CodeFile="NhuanBut.aspx.vb" Inherits="DesktopModules.Modules.NhuanBut" %>

<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head runat="server">
    <title>Chấm lại nhuận bút</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=yes" />
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2017-10-27-144540-937" type="image/x-icon" />
    <script src="/Resources/Shared/scripts/jquery/jquery.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/font-awesome.min.css?v=1.0" />
    <link href="/Portals/_default/skins/vbn/Skin.css?v=4.2.1" rel="stylesheet" type="text/css" />
    <link href="/Portals/_default/skins/vbn/css/Manager.css?v=4.2" rel="stylesheet" />
    <link rel="stylesheet" href="/Portals/_default/skins/vbn/css/style.css?v=2.1" />
    <link href="/js/datetime/datetimepicker.css?v=4.0.1" rel="stylesheet" />
    <link href="/js/validation/validationEngine.jquery.css" rel="stylesheet" />
    <link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
    <link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
</head>
<body>
    <form id="Form" runat="server" style="padding: 5px;">
        <div class="col-md-12">
            <div class="TitleH2">Chấm lại nhuận bút </div>
            <div class="clear"></div>
            <div class="post-title">
                <asp:Literal ID="lbTitle" runat="server" Text="..."></asp:Literal>
            </div>
            <div class="clear"></div>
        </div>
        <div class="col-md-12" style="margin-bottom: 5px;">
            <div class="col-sm-3 pdt5 b " style="padding-left: 0">Định mức tin tin bài</div>
            <div class="col-sm-3">
                <asp:DropDownList ID="drMaDMTin" Width="100%" runat="server" ClientIDMode="Static" onchange="loadMoneyTin();" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="col-sm-6">
                <span style="background: #ff6a00; color: #fff; padding: 7px 16px; float: left; height: 31px;" class="lblTienTin"></span>
            </div>
            <div class="clear"></div>
        </div>
        <div class="col-md-12">
            <asp:DataGrid ID="grdDMAnh" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#006699"></HeaderStyle>
                <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                <ItemStyle CssClass="TRgrid" BackColor="#F7FBFB" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT">
                        <ItemTemplate>
                            <asp:Literal ID="IsOrder" runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                        <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="ID" Visible="false">
                        <ItemTemplate>
                            <asp:Literal ID="ID" runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Định mức ảnh">
                        <ItemTemplate>
                            <asp:Literal ID="drMaDMAnh" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle CssClass="column-primary" />
                        <ItemStyle CssClass="column-primary" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Hệ số">
                        <ItemTemplate>
                            <asp:Literal ID="HeSo" runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="15%" CssClass="HeSo respo-view" />
                        <HeaderStyle Width="15%" CssClass="HeSo respo-title" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Số lượng">
                        <ItemTemplate>
                            <asp:TextBox ID="SoLuong" Width="100%" Value="0" runat="server" CssClass="grdtxt center soluong" />
                        </ItemTemplate>
                        <ItemStyle Width="15%" CssClass="SoLuong respo-view" />
                        <HeaderStyle Width="15%" CssClass="SoLuong respo-title" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Đơn giá">
                        <ItemTemplate>
                            <asp:Literal ID="DonGia" runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="15%" CssClass="DonGia respo-view" />
                        <HeaderStyle Width="15%" CssClass="DonGia respo-title" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tiền nhuận bút">
                        <ItemTemplate>
                            <asp:TextBox ID="IsMoney" Width="100%" Value="0" runat="server" ReadOnly="true" CssClass="grdtxt money-div monney" />
                        </ItemTemplate>
                        <ItemStyle Width="20%" CssClass="IsMoney respo-view" />
                        <HeaderStyle Width="20%" CssClass="IsMoney respo-title" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>

        <asp:Literal ID="lbmsg" runat="server" />

        <asp:HiddenField ID="ItemID" runat="server" />
        <asp:HiddenField ID="Username" runat="server" />
        <asp:HiddenField ID="IsType" runat="server" />
        <asp:HiddenField ID="PortalID" runat="server" />
        <asp:HiddenField ID="NB_ID" runat="server" />
        <script type="text/javascript">
            var PortalID = $("#<%=PortalID.ClientID%>").val();
            var itemid = "<%=ItemID.Value  %>";
            if (itemid != "") {
                var selectedOption = $("#drMaDMTin option:selected").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'" + itemid + "','type':'<%=CMS.CategoryType.News%>' }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
                var loadMoneyTin = function () {
                    var selectedOption = $("#drMaDMTin option:selected").val();
                    $.ajax({
                        type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                        data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                        success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                    });
                };
            } else {
                var selectedOption = $("#drMaDMTin option:selected").val();
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });

                var loadMoneyTin = function () {
                    var selectedOption = $("#drMaDMTin option:selected").val();
                    $.ajax({
                        type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                        data: "{ 'PortalID':'" + PortalID + "', 'ID': '" + selectedOption + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                        success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                    });
                };
            };
            function updatePrice(heso, price, t, id) {
                var total = parseFloat($(t).val()) * parseFloat(heso) * parseFloat(price);
                $('.money-' + id).val(total);
            };
            function CloseMySelf(sender) { try { } catch (err) { } window.close(); return false; };
            function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); $(".selectpicker-container").css("width", "100%"); }
            $(function () { pageLoad(); });
        </script>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="formModified=false; return checkmoney();" />
                <asp:Button ID="cmdExit" runat="server" Text="Thoát" OnClientClick="CloseMySelf(this)" CssClass="cmdbtt cmdExit" />
            </div>
        </div>

    </form>
    <script type="text/javascript" src="/js/jquery.cookie.js?v=4.6.0.3.3.0"></script>
    <%--<script type="text/javascript" src="/Portals/_default/skins/vbn/js/bootstrap.js"></script>--%>
    <script src="/js/base64.js?v=2.1" type="text/javascript"></script>
    <script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=4.6.0.3.3.0"></script>
    <script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=4.6.0.3.3.0"></script>
    <script type="text/javascript" src="/js/datetime/datetimepicker.js?v=4.0.1"></script>
    <%--<script src="/js/selectpicker/selectpicker.jquery.js?v=2.1" type="text/javascript"></script>--%>
    <script src="/Portals/_default/skins/vbn/js/general.js?v=2.1" type="text/javascript"></script>
    <script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
    <script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>
</body>
</html>


