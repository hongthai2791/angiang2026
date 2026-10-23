<%@ Control Language="vb" EnableViewState="false" AutoEventWireup="false" Explicit="true" CodeFile="NewsList.ascx.vb" Inherits="DesktopModules.Modules.NewsView_List" %>
<asp:Literal runat="server" ID="litHot"></asp:Literal>
<asp:Literal runat="server" ID="litNews"></asp:Literal>
<div class="clear"></div>
<asp:HiddenField ID="currPage" runat="server" Value="1" />
<asp:HiddenField ID="vUrl" runat="server" />
<asp:HiddenField ID="NewsId" runat="server" />
<asp:HiddenField ID="CategoryId" runat="server" />
<script type="text/javascript">
    function changeurl(p) { var url = $("#<%=vUrl.ClientID%>").val(); url = url + "/p/" + p; window.history.pushState('', document.title, url); }
    function fnext(p) { changeurl(p); var link = "/api/home/newslistpage.ashx?p=" + p + "&cid=" + $("#<%=CategoryId.ClientID%>").val() + "&pid=<%=Me.PortalId%>&nid=" + $("#<%=NewsId.ClientID%>").val(), msg = $.ajax({ url: link, async: false }).responseText; $(".ex_page").remove(), $(".ctrangc3").html(msg); window.scrollTo(0, 137); };
    function setScroll() { var h = $("#mainnew-getheight").height(); $(".box-subnews .i-subcontent").height(h); $(".box-subnews .i-subcontent").niceScroll(); }; $(document).ready(function () { setScroll(); });
</script>

