<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MarketMain.ascx.vb" Inherits="DesktopModules.Modules.MarketMain" %>
<%@ Register TagPrefix="SVL" TagName="DSBTD00" Src="~/DesktopModules/Module/SanViecLam/DSBTD00.ascx" %>
<%@ Register TagPrefix="SVL" TagName="DSBTD01" Src="~/DesktopModules/Module/SanViecLam/DSBTD01.ascx" %>
<%@ Register TagPrefix="SVL" TagName="DSBTD02" Src="~/DesktopModules/Module/SanViecLam/DSBTD02.ascx" %>
<%@ Register TagPrefix="SVL" TagName="DSUV01" Src="~/DesktopModules/Module/SanViecLam/DSUV01.ascx" %>
<%@ Register TagPrefix="SVL" TagName="TKBCS" Src="~/DesktopModules/Module/SanViecLam/TKBCS.ascx" %>

<SVL:DSBTD00 ID="ctlDSBTD00" runat="server" />
<div id="tabs">
    <div class="HeadSearch" style="margin-top: 25px;">
        <a id="a1a" class="HeadTextSelected" href="javascript:switchid('a1','#a1a');">Thông tin doanh nghiệp&nbsp;
            <span class="header_number"><%= EPORTAL.flReg.WriteNumber(Session.Item("DSBTD01"))%></span>
        </a>
        <a id="a2a" href="javascript:switchid('a2','#a2a');">Thông tin việc làm&nbsp;
            <span class="header_number"><%= EPORTAL.flReg.WriteNumber(Session.Item("DSBTD02"))%></span>
        </a>
        <a id="a3a" href="javascript:switchid('a3','#a3a');">Thông tin ứng viên 
            <span class="header_number"><%= EPORTAL.flReg.WriteNumber(Session.Item("DSUV01"))%></span>
        </a>
        <a id="a4a" href="javascript:switchid('a4','#a4a');">Thông tin kết quả</a>
    </div>
    <div class="ContentSearch">
        <div style="background: #fff;">
            <div id="a1">
                <SVL:DSBTD01 ID="ctlDSBTD01" runat="server" />
            </div>
            <div id="a2" style="display: none;">
                <SVL:DSBTD02 ID="ctlDSBTD02" runat="server" />
            </div>
            <div id="a3" style="display: none;">
                <SVL:DSUV01 ID="ctlDSUV01" runat="server" />
            </div>
            <div id="a4" style="display: none;">
                <SVL:TKBCS ID="ctlTKBCS" runat="server" />
            </div>
        </div>
    </div>
</div>

<div class="clear"></div>
<link href="/Portals/_default/Skins/vbn/css/svl.css?v=1.0" rel="stylesheet" />
<script src="/js/market/jquery.poshytip.min.js?v=1.0" type="text/javascript"></script>
<link rel="stylesheet" href="/js/market/tip-skyblue/tip-skyblue.css?v=1.0" type="text/css" />
<script type="text/javascript">
    $(function () {
        $('.tooltip, .svl_doanhnghiep').poshytip({
            className: 'tip-skyblue',
            bgImageFrameSize: 9,
            offsetX: 0,
            offsetY: 20,
            content: function () {
                var text = $(this).find('.marker').html();
                if ($.trim(text) == '') {
                    return 'Hiện tại doanh nghiệp chưa có hồ sơ nào!';
                } else {
                    return text;
                }
            },
            showTimeout: 100
        });
    });
    function switchid(id, obj) {
        hideallids();
        showdiv(id);
        $("#a1a").removeClass('HeadTextSelected');
        $("#a2a").removeClass('HeadTextSelected');
        $("#a3a").removeClass('HeadTextSelected');
        $("#a4a").removeClass('HeadTextSelected');
        $(obj).addClass('HeadTextSelected');
    }
    function hideallids() {
        var ids = new Array('a1', 'a2', 'a3', 'a4');
        for (var i = 0; i < ids.length; i++) {
            hidediv(ids[i]);
        }
    }

    function hidediv(id) {
        $("#" + id).attr("style", "display:none")
    }

    function showdiv(id) {
        $("#" + id).attr("style", "display:block")
    }
</script>
