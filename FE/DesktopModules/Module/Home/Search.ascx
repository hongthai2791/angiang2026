<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Search.ascx.vb" Inherits="DesktopModules.Home.Search" %>
<div class="row row5">
    <div class="col-md-12 col-xs-12 col5">
        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" PlaceHolder="Nhập từ khóa tìm kiếm..."></asp:TextBox>
        <div class="btn-search-new">
            <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-info"><i class="fa fa-search"></i></asp:LinkButton>
        </div>
    </div>
    <div class="clear mgt10"></div>
    <div class="col-md-6 col-xs-6 col5">
        <div class="form-group">
            <asp:DropDownList ID="drType" runat="server" AutoPostBack="true" CssClass="form-control selectpicker"></asp:DropDownList>
        </div>
    </div>
    <div class="col-md-6 col-xs-6 col5">
        <div class="form-group">
            <asp:DropDownList ID="drAdvanced" runat="server" AutoPostBack="true" CssClass="form-control selectpicker"></asp:DropDownList>
        </div>
    </div>
    <div class="clear"></div>
    <div class="col-md-6 col-xs-12 col5">
        <div class="form-group">
            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" CssClass="form-control selectpicker">
            </asp:DropDownList>
        </div>
    </div>

    <div class="col-md-3 col-xs-6 col5">
        <div class="form-group">
            <asp:TextBox ID="txtDateFrom" runat="server" CssClass="datepicker form-control" placeholder="Từ ngày"></asp:TextBox>
        </div>
    </div>
    <div class="col-md-3 col-xs-6 col5">
        <div class="form-group">
            <asp:TextBox ID="txtDateTo" runat="server" CssClass="datepicker form-control" placeholder="Đến ngày"></asp:TextBox>
        </div>
    </div>
</div>
<div runat="server" enableviewstate="false" id="f">
    <div class="category-list">
        <div class="row">
        <asp:Literal ID="litSearch" runat="server"></asp:Literal>
        <div class="clear"></div>
            </div>
    </div>
</div>

<asp:HiddenField ID="currPage" runat="server" Value="1" Visible="false" />
<asp:HiddenField ID="vUrl" runat="server" />

<link rel="stylesheet" type="text/css" href="/js/datetime/datetimepicker.css?v=3.2>" />
<script type="text/javascript" src="/js/datetime/datetimepicker.js?v=3.2"></script>
<script type="text/javascript">
    Sys.Application.add_load(function () { $('.selectpicker').selectpicker({ search_contains: true, width: "100%", placeholder_text_multiple: "- - - Chọn - - -" }); jQuery(function () { $(".rcCalPopup").click(function () { $(this).find(".timepicker").datetimepicker("show"), $(this).find(".timepicker").datetimepicker("show") }), $(".timepicker").datetimepicker({ timepicker: true, format: 'd/m/Y H:i', mask: true }), $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y', mask: true }) }); });
    function fnext(p) { changeurl(p); var link = "/api/home/searchpage.ashx?q=" + $('#<%= txtSearch.ClientID %>').val() + "&ad=<%= adVan %>&type=<%=Request.Item("type")%>&cid=<%= CategoryId %>&f=" + '<%= Datefrom %>' + "&t=" + '<%= DateTo %>' + "&p=" + p, msg = $.ajax({ url: link, async: false }).responseText; $(".ex_page").remove(), $(".sub-news").html(msg); window.scrollTo(0, 137) };
    function changeurl(p) { var url = $("#<%=vUrl.ClientID%>").val(); url = url + "/p/" + p; window.history.pushState('', document.title, url); }    
</script>
<div runat="server" enableviewstate="false" style="position: absolute; width: 0px; overflow: hidden">
    <asp:Literal ID="litSeo" runat="server" />
</div>
