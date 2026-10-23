<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="DotNetNuke.Modules.MainSettings" %>
<link href="/desktopmodules/module/addmodule/addmodule.css?v=2" rel="stylesheet" />
<div class="Vbn_Add_Module">
    <div style="width: 800px; margin: 10px auto;padding:10px; ">
        <div class="row div-tit-settings">
            <div class="col-sm-8" style="padding-top: 5px;">
                <asp:Literal ID="lit" runat="server"></asp:Literal>
            </div>
            <div class="col-sm-4" style="padding-right: 0px">
                <asp:TextBox ID="txtSearch" runat="server" CssClass="Vbn_Add_Module_txtearch add-txtearch"></asp:TextBox>
                <asp:LinkButton ID="lbtFind" runat="server" CssClass="add-btsearch" OnClientClick="finds();return false;" />
            </div>
            <div class="clear"></div>
        </div>
        <div class="row add-title-bg">
            <div class="col-sm-4 col-xs-4 add-title">Bạn đang chọn module </div>
            <div class="col-sm-8 col-xs-8 add-title-select add-select">
                <asp:Literal ID="litModule" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="clear"></div>
        <div class="row">
            <div class="col-sm-4 col-xs-4 add-folder add-panel">
            </div>
            <div class="col-sm-8 col-xs-8 add-browse add-panel">
            </div>
            <div class="clear"></div>
        </div>
        <div class="row">
            <div class="div-but">
                <asp:Button ID="cmdUpdate" CssClass="addCbt add-acc" runat="server" Text="Lưu lại" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdBack" CssClass="addCbt" runat="server" Text="Hủy bỏ" OnClientClick="return $('#Form').validationEngine('detach');" />
            </div>
        </div>
        <asp:HiddenField ID="selectPath" runat="server" />
        <asp:HiddenField ID="hidPath" runat="server" />
        <script type="text/javascript">
            $(function () { $.ajax({ type: 'GET', url: "/desktopmodules/module/addmodule/module.asmx/Folders", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".add-folder").html(json.data); } } }); });
            function expan(t) { $(".ad-tv-li").each(function (e) { $(this).find(".ad-tv-ul").attr("style", "display:none"); }); $(t).parents("li").find(".ad-tv-ul").removeAttr("style"); };
            function getchild(t) {
                var path = $(t).attr("id"); $(".fl-a").removeClass("active"); $(t).addClass("active");
                $("#<%=selectPath.ClientID %>").val(path);
                if ($(t).hasClass("set") == false) {
                    $.ajax({
                        type: "GET", url: '/desktopmodules/module/addmodule/module.asmx/Childs?parent=' + path, success: function (data) {
                            var json = $.parseJSON($(data).find("string").text());
                            if (json.data) { $(t).parents("li").append(json.data); $(t).addClass("set"); };
                        },
                    });
                }
                $(".add-browse").html(""); var s = $(".EPORTAL_Add_Module_txtearch").val(); if (s == undefined) { s = ""; }
                $.ajax({
                    type: "GET", url: '/desktopmodules/module/addmodule/module.asmx/Browses?path=' + path + "&search=" + s, success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data) { $(".add-browse").html(json.data) };
                        checkselect();
                    },
                }); expan(t);
            };
            function finds() {
                var path = $("#<%=selectPath.ClientID %>").val();
                var s = $(".EPORTAL_Add_Module_txtearch").val(); if (s == undefined) { s = ""; }
                $.ajax({
                    type: "GET", url: '/desktopmodules/module/addmodule/module.asmx/Browses?path=' + path + "&search=" + s, success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data) { $(".add-browse").html(json.data) };
                        checkselect();
                    },
                });
            }
            function selectbrowse(t) { var path = $(t).attr("id"); $(".add-a").removeClass("select"); $(t).addClass("select"); $(".add-select").html("/desktopmodules/" + path); $("#<%=hidPath.ClientID %>").val("/desktopmodules/" + path); };
            function checkselect() { var pselect = $("#<%=hidPath.ClientID %>").val(); if ((pselect != undefined) && (pselect != "")) { $(".add-a").each(function (e) { if ("/desktopmodules/" + $(this).attr("id") == pselect) { $(this).addClass("select"); } }); } };
        </script>
        
    </div>
</div>

