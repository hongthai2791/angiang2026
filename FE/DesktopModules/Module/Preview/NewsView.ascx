<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="NewsView.ascx.vb" Inherits="DesktopModules.Modules.Preview" %>
<asp:Literal ID="litBr" runat="server" />
<div class="clear"></div>
<div class="detail-post hnoneview" enableviewstate="false" runat="server" id="viewhinone">
    <div class="col-md-12 col-xs-12">
        <asp:Literal ID="Introduction" runat="server" />
        <h1 class="post-title">
            <asp:Literal ID="lbTitle" runat="server" Text="..."></asp:Literal></h1>
        <div class="clear"></div>
    </div>

    <div class="post-head">
        <div class="col-md-6 col-xs-6">
            <span class="post-subinfo">
                <asp:Literal ID="lbPublishedDate" runat="server"></asp:Literal>
            </span>
        </div>
        <div class="col-md-6 col-xs-6">
            <div style="text-align: right;">
                <a onclick="printto()" class="printview" title="Print">
                    <img src="/image/images/print.png?w" alt="print" /></a>&nbsp;&nbsp;
            </div>
        </div>
    </div>
    <div class="clear"></div>
    <div class="col-md-12 col-xs-12">
        <div class="post-summary">
            <asp:Literal ID="lbSummary" runat="server" Text=""></asp:Literal>
        </div>
        <asp:Panel ID="pnRelate" runat="server" CssClass="post-relate" Visible="false">
            <asp:Repeater ID="rptRelate" runat="server">
                <ItemTemplate>
                    <a href='<%#CMS.Ultis.FormatLink(Me.PortalId, DataBinder.Eval(Container.DataItem, "CategoryId"), DataBinder.Eval(Container.DataItem, "NewId"))%>'>
                        <h3><i class="fa fa-angle-right"></i>&nbsp;<%# DataBinder.Eval(Container.DataItem, "Title")%></h3>
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </asp:Panel>
        <div class="post-content">
            <asp:Literal ID="lbContent" runat="server"></asp:Literal>
            <asp:Literal ID="ltAlbumImg" runat="server"></asp:Literal>
        </div>
        <div class="post-tag">
            <asp:Literal ID="litTag" runat="server" />
        </div>
    </div>
    <div class="clear"></div>

</div>
<script type="text/javascript">
    function fonterror() {
        var html = $(".post-content").html();
        for (i = 0; i < html.length; i++) {
            html = html.replace('ô%3ḅ', 'ộ'); html = html.replace('ê%3ḅ', 'ệ'); html = html.replace('â%3ḅ', 'ậ');
            html = html.replace('Ô%3ḅ', 'Ộ'); html = html.replace('Ê%3ḅ', 'Ệ'); html = html.replace('Â%3ḅ', 'Ậ');
        }
        $(".post-content").html(html);
    };
    $(document).ready(function () { $(".dbox").remove(); fonterror(); });
    function printto() {
        window.history.pushState('', document.title, $(".change").html()); window.print();
        window.history.pushState('', document.title, $(".oldurl").html())
    };
</script>
