<%@ Control Language="vb" CodeFile="TapTinView.ascx.vb" Inherits="Modules.TapTinView.View" AutoEventWireup="false" Explicit="True" %>
<style>
    .box-body{padding:0 10px}
    .main-body {
        width: 100%;
        height: auto;
    }

        .main-body iframe {
            width: 100%;
            height: 100%;
        }
</style>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12 pdl0">
            <h3 class="box-title">Quản lý tập tin</h3>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
        </div>
    </div>
</div>

<script>
    function loadfile(i) {
        $('.main-body').html('<iframe id="i_loadfile" src="' + i + '"></iframe>');
    }
</script>
