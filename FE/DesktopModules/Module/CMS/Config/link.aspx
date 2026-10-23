<%@ Page Language="VB" AutoEventWireup="false" CodeFile="link.aspx.vb" Inherits="DesktopModules.TinTuc.Control.Choose" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head runat="server">
    <title>Chèn link liên kết</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=yes" />
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2017-10-27-144540-937" type="image/x-icon" />
    <link rel="stylesheet" href="/Portals/_default/fonts/resource/font-awesome/css/font-awesome.min.css?v=4.5.3" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/AdminLTE.min.css?v=4.1.1" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/style.css?v=4.0.1" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/manager.css?v=4.1.10" />
    <link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=4.0.1" />
    <link rel="stylesheet" href="/js/validation/validationEngine.jquery.css" />
    <link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
    <link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
</head>
<body>
    <form id="formChoose" runat="server">
        <div id="content" style="padding: 5px;">
            <div class="col-sm-12 col-sm-12 ">
                <span style="font-weight: bold; color: #035f8c; font-size: 15px">DANH SÁCH TIN BÀI ĐÃ XUẤT BẢN</span>
            </div>
            <div class="clear pdbt10"></div>
            <div class="col-sm-2 pdt5">Xuất bản từ</div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtStartdate" runat="server" CssClass="TextBox datepicker" PlaceHolder="Từ ngày"></asp:TextBox>
            </div>
            <div class="col-sm-1 txt-right pdt5">Đến</div>
            <div class="col-sm-2">
                <asp:TextBox ID="txtEndDate" runat="server" CssClass="TextBox datepicker" PlaceHolder="Đến ngày"></asp:TextBox>
            </div>
            <div class="col-sm-1 pdt5 txt-right pdr0">Tiêu đề</div>
            <div class="col-sm-4 pdr0">
                <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
            </div>
            <div class="clear pdbt10"></div>
            <div class="col-sm-2 pdt5">Chuyên mục</div>
            <div class="col-sm-10 pdr0">
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="clear pdbt10"></div>
            <div class="col-sm-2 pdt5">Link từ trang ngoài</div>
            <div class="col-sm-10 pdr0">
                <asp:TextBox runat="server" ID="txtLinkOther" CssClass="timKiemD txtLinkOther  txtlink" Width="100%"></asp:TextBox>
                <asp:LinkButton ID="LinkButton1" OnClientClick="chenLinkNgoai();" runat="server" CausesValidation="False" CssClass="btTkiemD" />
            </div>
            <div class="clear pdbt10"></div>
            <asp:DataGrid ID="grdData" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                <ItemStyle BackColor="#f5f5f5" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="IsOrder" runat="server" />
                        </ItemTemplate>
                        <ItemStyle Width="60" HorizontalAlign="Center" CssClass="fix-column" />
                        <HeaderStyle Width="60" HorizontalAlign="Center" CssClass="fix-column" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Ảnh đại diện">
                        <ItemTemplate>
                            <a href="#" onclick="return getlink('<%# CMS.Ultis.FormatLink(GetPortalSettings.PortalId, DataBinder.Eval(Container.DataItem, "CategoryId"), DataBinder.Eval(Container.DataItem, "NewId"), DataBinder.Eval(Container.DataItem, "ToUrl"))%>');">
                                <img src="<%# EPORTAL.flReg.ImgSRC(Eval("ImagePath"), 70, 0, True)%>" alt="ảnh đại diện">
                            </a>
                        </ItemTemplate>
                        <ItemStyle Width="150px" HorizontalAlign="Center" />
                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Lấy link">
                        <ItemTemplate>
                            <div class="pop-view">
                                <a href="javascript:;" class="a-list" onclick="return getlink('<%# CMS.Ultis.FormatLink(GetPortalSettings.PortalId, DataBinder.Eval(Container.DataItem, "CategoryId"), DataBinder.Eval(Container.DataItem, "NewId"), DataBinder.Eval(Container.DataItem, "ToUrl"))%>');">
                                    <%# Highlight(Eval("Title"), "<span class='highlight'>", "</span>")%>
                                </a>
                            </div>
                            <asp:Literal ID="litDate" runat="server" /><br />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <div class="col-md-12 pdr0">
                <asp:Literal ID="litPage" runat="server" />
            </div>
        </div>
        <asp:HiddenField ID="PortalID" runat="server" />
        <asp:HiddenField ID="CurrentPage" runat="server" />
        <asp:HiddenField ID="flag" runat="server" />
    </form>
</body>
<script src="/Resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0" type="text/javascript"></script>
<script type="text/javascript" src="/js/datetime/datetimepicker.js?v=4.0.1"></script>
<script src="/js/base64.js?v=4.6.0.3.3.0" type="text/javascript"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

<script language="javascript" type="text/javascript">
    function pageLoad() { $('.selectpicker').selectpicker({ liveSearch: true }); $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y' }); };
    $(function () { pageLoad(); }); $("tr.TRgrid").hover(function () { $(this).addClass("TRgrid-Hover"); }, function () { $(this).removeClass("TRgrid-Hover"); });
    function getlink(link) { window.opener.addlink(link, $("#<%=flag.ClientID%>").val()); CloseMySelf(this); };
    function CloseMySelf(sender) { window.close(); return false; };
    function chenLinkNgoai() { var link = $(".txtLinkOther").val(); getlink(link); }
</script>
</html>

