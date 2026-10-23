<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DSBTD01.ascx.vb" Inherits="DesktopModules.Modules.DSBTD01" %>
<asp:Literal ID="litV" runat="server"></asp:Literal>
<asp:HiddenField ID="ItemID" Value="" runat="server" />
<script type="text/javascript">
    function addFav(args) { var u = $(args); var _id = u.attr('data-value'); var valuecookie = $.cookie(_id); if (valuecookie != 'true') { $.cookie(_id, "true", { expires: 1 }); u.attr('src', "/image/svl/sao.png"); } else { $.cookie(_id, null); u.attr('src', "/image/svl/saoout.png"); } };
    $(document).ready(function () { $.each($('.addfav'), function (index, value) { var _attr = $(this).attr('data-value'); var valuecookie = $.cookie(_attr); if (valuecookie == 'true') { $(this).attr('src', "/image/svl/sao.png"); } }); });
</script>
