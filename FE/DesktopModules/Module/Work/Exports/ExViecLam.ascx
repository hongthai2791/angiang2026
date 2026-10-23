<%@ Control Language="vb" CodeFile="ExViecLam.ascx.vb" Inherits="Modules.ExCungLD.View" AutoEventWireup="false" Explicit="True" %>
<div class="cho-nen">
    <div class="col-md-12">
        <img src="/image/wating.gif" />
    </div>
    <div class="col-md-12">
        <div class="cho-ti">🍓🍓🍓 Hãy chờ một chút, hệ thống đang xử lý bạn nhé.🍓🍓🍓</div>
        <div class="cho-loi">
            <asp:Literal ID="litCode" runat="server"></asp:Literal>
            <asp:Button ID="cmdRun" CssClass="cmdRun none" Text="cmdRun" runat="server" />
        </div>
    </div>
    <div class="clear"></div>

</div>
<script>
    function runExports() { $(".cmdRun").click(); }
    function closeWindow(path) { window.location.href = path; setTimeout(function () { window.close(); }, 3000); };
</script>
<style>
    body {
        background: #001d30 !important;
    }

    .cmdClose {
        padding: 10px 50px;
        color: #001d30;
    }

    .none {
        display: none !important
    }

    .noidung {
        max-height: 500px;
    }

    .cho-nen {
        width: 100%;
        padding-top: 50px;
        text-align: center;
        background: #001d30;
    }

    .cho-ti {
        font-size: 20px;
        color: #cecece;
        width: 100%;
        margin-top: -50px
    }

    .cho-loi {
        font-size: 20px;
        color: #cecece;
        width: 100%;
        padding-top: 30px
    }
</style>

