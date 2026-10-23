<%@ Control Language="vb" CodeFile="InputDataEdit.ascx.vb" Inherits="Modules.ExDistrict.Edit" AutoEventWireup="false" Explicit="True" %>
<%--<link href="/js/jexcel/jexcel.analy.css?v=3.1.3" rel="stylesheet" />
<link href="/js/jexcel/jsuites.css?v=3.0.3" rel="stylesheet" />--%>
<div class="box box-info ">
    <div class="box-header with-border fix-top">
        <div class="col-md-10">
            <asp:Literal ID="litTitle" runat="server"></asp:Literal>
        </div>
        <div class="col-md-2 txt-right">
            <asp:Button ID="cmdAdd" runat="server" Text="Thêm dòng" CssClass="cmsbut cmdcol cmsbAdd" OnClientClick="savedata(1);" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body mgt30">
            <div class="row">
                <asp:Literal ID="litTraLai" runat="server"></asp:Literal>
                <div class="col-md-12">
                    <div id='jtable' class="jtable" runat="server"></div>
                </div>
            </div>
            <div class="clear"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="waiting(); return savedata(0);" />
                <asp:Button ID="cmdSend" runat="server" Text="Nộp báo cáo " OnClientClick="savedata(0);" CssClass="cmsbut cmsbtsend none" />
                <asp:Button ID="cmdExcel" runat="server" Text="Xuất ra excel" CssClass="cmsbut cmsbtExport" OnClientClick="savedata(1); popexp('exports'); return false;" />
                <a id="cmdImport" runat="server" style="height: auto" onclick="upfile(0);" title="Import excel" class="cmsbut cmdexel">Nhập mới từ excel</a>
                <a id="cmdImport1" runat="server" style="height: auto" onclick="upfile(1);" title="Import excel" class="cmsbut cmsbtImport">Nhập thêm từ excel</a>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="TinhTP" runat="server" />
    <asp:HiddenField ID="Group_ID" runat="server" />
    <asp:HiddenField ID="Years_ID" runat="server" />
    <asp:HiddenField ID="TempRpt_ID" runat="server" />
    <asp:HiddenField ID="Temp_Name" runat="server" />
    <asp:HiddenField ID="InportEx" runat="server" />
    <asp:HiddenField ID="ItemId" runat="server" />
    <asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx" CssClass="none" AllowMultiple="false" runat="server" />
    <asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
    <asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
</div>
<asp:Panel ID="pjs" runat="server">
    <script src="/js/jexcel/jexcel.analy.js?v=3.1.4"></script>
    <script src="/js/jexcel/jsuites.js?v=3.0.3"></script>
    <script type="text/javascript">
        data = [<%=jData%>];
        data1 = [<%=jValCss%>];
        $('.jtable').jexcel({
            //editable: false,
            data: data,
            data1: data1,
            colWidths: [ <%=ColWidth%> ],
            columns: [<%=jColumns%>],
            mergeCells: {<%=mergeCells%>},
        });

    </script>
</asp:Panel>
<script type="text/javascript">
    function upfile(t) {
        if (t == 0) {
            if (confirm("Dữ liệu đã nhập được lưu trong CSDL sẽ được thay thế toàn bộ bằng dữ liệu trong tệp excel. \nBạn có chắc muốn tiếp tục thực hiện hay không?")) {
                waiting(); $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
            }
        }
        else {
            waiting(); $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
        }
    };
    function upLoad() { waiting(); jQuery('#<%= cmdUpfile.ClientID%>').click(); };
    function exports() {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        var tempid = $("#<%=TempRpt_ID.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/api/analy/reports.aspx?pid=0&tid=3&id=" + itemid + "&tempid=" + tempid + "&type=" + dtype);
        return false;
    };
    function savedata(silent) {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        var tempRptid = $("#<%=TempRpt_ID.ClientID %>").val();
        $("tr.row-input").each(function (e) {
            var rowID = $(this).attr("b-rowid");
            var noiDung = $(this).find("td._noiDung").html();
            if ((noiDung != "") && (noiDung != undefined)) {
                noiDung = Base64.encode(noiDung);
                var inputrptc = $(this).find("td.jexcel-input").attr("b-inputrptc");
                var iTT = $(this).attr("b-order");
                $.ajax({
                    type: 'GET', url: '/api/analy/data.asmx/InDataRow?pid=0&rowID=' + rowID
                        + '&itemid=' + itemid
                        + '&inputrptc=' + inputrptc
                        + '&noiDung=' + noiDung
                        + '&iTT=' + iTT,
                    success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                });

                $(this).find("._giaTri").each(function (e) {
                    var gText = ""; var gSo = "";
                    if ($(this).hasClass("_gtText")) {
                        gText = $(this).html(); if ((gText != "") && (gText != undefined)) { gText = Base64.encode(gText); }
                    }
                    else {
                        gSo = $(this).html(); if ((gSo != "") && (gSo != undefined)) { gSo = Base64.encode(gSo); }
                    }
                    var inputrptc = $(this).attr("b-inputrptc");
                    var coltype = $(this).attr("b-coltype");
                    var targets = $(this).attr("b-targets");
                    var inT = $(this).attr("b-stt");
                    $.ajax({
                        type: 'GET', url: '/api/analy/data.asmx/InDataRowC?pid=0&rowID=' + rowID
                            + '&itemid=' + itemid
                            + '&inputrptc=' + inputrptc
                            + '&targets=' + targets
                            + '&colType=' + coltype
                            + '&gText=' + gText
                            + '&gSo=' + gSo
                            + '&inT=' + inT,
                        success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                    });
                });
            }
            else {
                $.ajax({
                    type: 'GET', url: '/api/analy/data.asmx/delInDataRow?pid=0&rowID=' + rowID,
                    success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                });
            }
        });
        if (silent == 0) {
            notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);
            removewaiting();
        }
        return false;
    };
    function newvalues() {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        $("._giaTri").each(function (e) {
            var inputrptc = $(this).attr("b-inputrptc");
            var coltype = $(this).attr("b-coltype");
            var rowID = $(this).attr("b-rowid");
            var celid = $(this).attr("b-celid");
            $.ajax({
                type: 'GET', url: '/api/analy/data.asmx/valData?pid=0&itemid=' + itemid + '&rowID=' + rowID + '&inputrptc=' + inputrptc + '&coltype=' + coltype,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) {
                        console.log(celid);
                        $(".rowid-" + celid).html(json.data);
                    }
                    $(".rowid-" + celid).removeAttr("style");
                },
                error: function (error) {
                    $(".rowid-" + celid).removeAttr("style");
                }
            });
        });
    };
    function loadvalue() {
        $("._giaTri").attr("style", "background: url(/image/images/loader.gif)center 10px no-repeat;");
        setTimeout("newvalues()", 10);
    };
</script>
