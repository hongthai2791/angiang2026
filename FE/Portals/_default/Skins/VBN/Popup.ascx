<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<div class="popwai none">
    <img style="top: 38%; left: 38%; position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
</div>
<div id="ContentPane" runat="server" class="popupPane"></div>
<script type="text/javascript">
    $(document).ready(function () {
        $(".personalBarContainer").addClass("none");
        $('.timepicker').datetimepicker(); $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y' });
    });
</script>
