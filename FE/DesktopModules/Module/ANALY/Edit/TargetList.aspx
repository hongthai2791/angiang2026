<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TargetList.aspx.vb" Inherits="DesktopModules.TinTuc.Control.ChooseCategory" %>

<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head runat="server">
    <title>Cấu hình chuyên mục hiển thị trang chủ</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=yes" />
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2017-10-27-144540-937" type="image/x-icon" />
    <%--    <link href="/Portals/_default/skins/vbn/css/bootstrap.css" rel="stylesheet" />--%>
    <link href="/Portals/_default/skins/vbn/css/Manager.css" rel="stylesheet" />
    <link rel="stylesheet" href="/js/respo-table/respo.style.css?v=<%=Ultis.Version %>" />
    <link href="/js/datetime/datetimepicker.css?v=4.0.1" rel="stylesheet" />
    <link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />


    <style type="text/css" media="screen">
        .square-thumb {
            width: 60px;
            height: 60px;
        }
    </style>
    <style type="text/css">
        .list-lq {
            padding: 10px 0px 5px 20px;
        }

        ul {
            list-style: none;
        }

        .list-lq ul li {
            line-height: 20px;
            padding-left: 15px;
        }

            .list-lq ul li a:hover {
                color: #f59206;
            }
    </style>

</head>
<body>  
    <form id="formChoose" runat="server" style="padding: 5px;">
        <div id="content">
            <div class="col-md-2 col-xs-2">
                <a id="divResult" href="#" onclick="return CloseMySelf(this);" class="StandardButton">
                    <img src="/images/icons/arrow_redo.png" alt="Thoát" />Đóng</a>
            </div>
            <div class="col-md-10 col-xs-10">
                <div class="list-lq">
                    <ul></ul>
                </div>
            </div>
             <div class="clear"></div>
            <div class="col-md-12 box-title">Nhóm chỉ tiêu</div>
       
            <div class="col-md-4">
                <asp:DropDownList ID="drGroup" AutoPostBack="true" runat="server" TabIndex="5" CssClass="selectpicker" />
            </div>
       
            <div class="col-md-6"></div>
      
            <div class="clear"></div>
            <asp:DataGrid ID="grdTarget" DataKeyField="CategoryID" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                <ItemStyle CssClass="TRgrid" BackColor="#fbf2ec"></ItemStyle>
                <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#006699"></HeaderStyle>
                <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                 <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="IsOrder" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="5%" HorizontalAlign="Center" />
                            <ItemStyle Width="5%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Mã chỉ tiêu" HeaderStyle-CssClass="hdTitle">
                     <ItemTemplate>
                         <%# Eval("Targets_Code") %>
                            </ItemTemplate>
                            <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            <ItemStyle Width="15%" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Chỉ tiêu báo cáo" HeaderStyle-CssClass="hdTitle">                          
                        <ItemTemplate>
                             <a href="javascript:setVal(<%# Eval("Targets_ID") %>,Base64.encode('<%# Eval("Targets_Code") %>'),Base64.encode('<%# HtmlUtils.StripPunctuation(Eval("Targets_Name"),True).Replace("'","") %>'))">
                                <%# Eval("Targets_Name") %>
                            </a>
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
         <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        <script src="/js/base64.js?v=4.6.0.3.3.0" type="text/javascript"></script>
        <script src="/Resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0" type="text/javascript"></script>
        <%--<script type="text/javascript" src="/Portals/_default/skins/vbn/js/bootstrap.js"></script>--%>
        <script type="text/javascript" src="/js/datetime/datetimepicker.js?v=4.0.1"></script>
        <script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>

        <script language="javascript" type="text/javascript">
            function CloseMySelf(sender) { window.close(); return false; };
            function setVal(id,code, title) {
                if (typeof ($('.list-lq ul').find('li[data-item-id="' + id + '"]').html()) == "undefined") {
                    $('.list-lq ul').append('<li data-item-id="' + id + '"><a href="#">[' + Base64.decode(code) + "]" + Base64.decode(title) + '</a></li>');
                    window.opener.HandlePopupResult(id + "|" + code + "|" + title);
                }
            };

            function removeVal(sender) { alert($(sender).parent().html()); }
            function addValue(value) {
                if ($('#divResult').attr("result").indexOf(value) == -1) {
                    if ($('#divResult').attr("result") == '' || $('#divResult').attr("result") == null)
                        $('#divResult').attr("result", value);
                    else
                        $('#divResult').attr("result", $('#divResult').attr("result") + ';' + value);
                }

            };
            function removeValue(value) {
                var arrTemp = $('#divResult').attr("result");
                var sResult = ""; var arr = new Array(); arr = arrTemp.split(";");
                for (var i = 0; i < arr.length; i++) {
                    if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; }
                }
                $('#divResult').attr("result", sResult.substring(1, sResult.length));

            };
            $("tr.TRgrid").hover(function () { $(this).addClass("TRgrid-Hover"); }, function () { $(this).removeClass("TRgrid-Hover"); });
        </script>
    </form>
      
</body>
</html>
