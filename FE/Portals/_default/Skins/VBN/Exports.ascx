<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
<link rel="stylesheet" href="/js/validation/toastr.min.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap.min.css?v=6.0.0.0" />
<link rel="stylesheet" href="/js/select/bootstrap-select.css?v=6.0.0.0" />
<body>
    <div class="hold-transition skin-blue-light bodyfake">
        <div class="wrapper">
            <div id="ContentPane" runat="server" class="contentPane"></div>
        </div>
    </div>
</body>
<script type="text/javascript" src="/js/validation/jquery.validationEngine.js?v=7.0.0.0"></script>
<script type="text/javascript" src="/js/validation/jquery.validationEngine-vi.js?v=7.0.0.2"></script>
<script type="text/javascript" src="/js/validation/toastr.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/validation/nicescroll.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap.min.js?v=6.0.0.0"></script>
<script type="text/javascript" src="/js/select/bootstrap-select.js?v=6.0.0.0"></script>
<script type="text/javascript">
    $(".an1cai").click(function () {
        if ($(".personalBarContainer").hasClass("andi")) {
            $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important");
        } else {
            $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style");
        }
        $(".personalBarContainer").removeAttr("style");
    });
    $(".personalBarContainer").addClass("andi");
    function pageLoad() { $(".scroll").niceScroll(); };
    $(document).ready(function () { pageLoad(); });
</script>
<style>
    .andi {
        display: none;
    }

    #Body {
        margin-left: 0 !important;
    }
</style>
