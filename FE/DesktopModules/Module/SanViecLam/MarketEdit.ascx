<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MarketEdit.ascx.vb" Inherits="DesktopModules.Modules.MarketEdit" %>
<%@ Register TagPrefix="BT" TagName="BTD00" Src="~/DesktopModules/Module/SanViecLam/BTD00.ascx" %>
<%@ Register TagPrefix="BT" TagName="BTD01" Src="~/DesktopModules/Module/SanViecLam/BTD01.ascx" %>
<%@ Register TagPrefix="BT" TagName="BTD02" Src="~/DesktopModules/Module/SanViecLam/BTD02.ascx" %>
<%@ Register TagPrefix="BT" TagName="BTD03" Src="~/DesktopModules/Module/SanViecLam/BTD03.ascx" %>
<%@ Register TagPrefix="BT" TagName="BTD04" Src="~/DesktopModules/Module/SanViecLam/BTD04.ascx" %>

<BT:BTD00 ID="ctlBTD00" runat="server" />
<div id="tabs">
    <div class="HeadSearch" style="margin-top: 25px;">
        <a id="a2a" class="HeadTextSelected" href="javascript:switchid('a2','#a2a');">Thông tin tuyển dụng&nbsp;
            <span class="header_number"><%= EPORTAL.flReg.WriteNumber(Session.Item("BTD01"))%></span>
        </a>
        <a id="a1a" href="javascript:switchid('a1','#a1a');">Ứng viên chờ phỏng vấn&nbsp;
            <span class="header_number"><%= EPORTAL.flReg.WriteNumber(Session.Item("BTD02"))%></span>
        </a>
        <a id="a3a" href="javascript:switchid('a3','#a3a');">Thông tin về nhà tuyển dụng</a>
        <a id="a4a" href="javascript:switchid('a4','#a4a');">Kết quả tuyển dụng</a>
    </div>
    <div class="ContentSearch" style="background: #fff;min-height:250px">
        <div id="a2">
            <BT:BTD01 ID="ctlBTD01" runat="server" />
        </div>
        <div id="a1" style="display: none">
            <BT:BTD02 ID="ctlBTD02" runat="server" />
        </div>
        <div id="a3" style="display: none; text-align: center">
            <BT:BTD03 ID="ctlBTD03" runat="server" />
        </div>
        <div id="a4" style="display: none; text-align: center">
                <BT:BTD04 ID="ctlBTD04" runat="server" />
            </div>
    </div>
    <div class="clear"></div>
</div>
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
    function switchid(id, obj) { hideallids(); showdiv(id); $("#a1a").removeClass('HeadTextSelected'); $("#a2a").removeClass('HeadTextSelected'); $("#a3a").removeClass('HeadTextSelected'); $("#a4a").removeClass('HeadTextSelected'); $(obj).addClass('HeadTextSelected'); };
    function hideallids() { var ids = new Array('a1', 'a2', 'a3', 'a4'); for (var i = 0; i < ids.length; i++) { hidediv(ids[i]); } };
    function hidediv(id) { $("#" + id).attr("style", "display:none"); };
    function showdiv(id) { $("#" + id).attr("style", "display:block"); };
</script>
