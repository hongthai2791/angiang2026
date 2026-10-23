<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Video.aspx.vb" Inherits="DesktopModules.TinTuc.Control.ChooseVideo" %>

<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head runat="server">
    <title>Chọn video</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=yes" />
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2017-10-27-144540-937" type="image/x-icon" />
    <link rel="stylesheet" href="/Portals/_default/fonts/resource/font-awesome/css/font-awesome.min.css?v=4.5.3" />
    <%--<link rel="stylesheet" href="/js/selectpicker/bootstrap-selectpicker.css?v=4.0.3" />--%>
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/AdminLTE.min.css?v=4.1.1" />
    <%--<link rel="stylesheet" href="/portals/_default/skins/vbn/css/bootstrap.css?v=4.0.1" />--%>
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/style.css?v=4.0.1" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/manager.css?v=4.1.10" />
    <link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=4.0.1" />
    <link rel="stylesheet" href="/js/validation/validationEngine.jquery.css?v=4.6.0.3.3.0" />
    <link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
    <link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
    <style type="text/css" media="screen">
        #content {
            padding: 5px 5px 30px 10px;
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

        .list-lq {
            padding-top: 10px;
            padding-bottom: 10px
        }
    </style>

</head>
<body>
    <form id="formChoose" runat="server" style="padding: 5px; height: 590px; overflow-y: scroll;">
        <div id="content">
            <asp:HiddenField ID="PortalID" runat="server" />
            <div class="nav-main">
                <div class="col-md-12 col-sm-12 ">
                    <span style="font-weight: bold; color: #035f8c; font-size: 15px">DANH SÁCH VIDEO ĐÃ XUẤT BẢN</span>
                </div>
                <div class="col-sm-2 pdt5">Xuất bản từ</div>
                <div class="col-sm-2">
                    <asp:TextBox ID="FromDate" runat="server" CssClass="TextBox datepicker" PlaceHolder="Từ ngày"></asp:TextBox>
                </div>
                <div class="col-sm-1 txt-right pdt5">Đến</div>
                <div class="col-sm-2">
                    <asp:TextBox ID="ToDate" runat="server" CssClass="TextBox datepicker" PlaceHolder="Đến ngày"></asp:TextBox>
                </div>
                <div class="col-sm-1 pdt5 txt-right pdr0">Tiêu đề</div>
                <div class="col-sm-4 pdr0">
                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                </div>
                <div class="clear pdbt10"></div>
                <div class="col-sm-2 pdt5">Chuyên mục</div>
                <div class="col-sm-10 pdr0">
                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear "></div>
                <div class="row">
                    <div class="list-lq">
                        <ul></ul>
                    </div>
                </div>
            </div>
            <asp:DataGrid ID="grdData" DataKeyField="id" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered">
                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                <ItemStyle BackColor="#f5f5f5" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT">
                        <ItemTemplate>
                            <asp:Literal ID="STT" runat="server"></asp:Literal>
                        </ItemTemplate>
                        <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="ViewCount respo-view" />
                        <HeaderStyle HorizontalAlign="Center" CssClass="ViewCount respo-title" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tên video">
                        <ItemTemplate>
                            <a href="javascript:setVal(<%# Eval("ID") %>,Base64.encode('<%# HtmlUtils.StripPunctuation(Eval("name"), True).Replace("'", "")%>'))">
                                <%# DataBinder.Eval(Container.DataItem, "Name")%>
                            </a>
                            <br />
                            <font style="color: Maroon;">Ngày xuất bản:</font><asp:Label ID="lblPublishInfo" ForeColor="Maroon" runat="server" Text='<%# Eval("PublishedDate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Lượt xem">
                        <ItemTemplate>
                            <%# Eval("ViewCount") %>
                        </ItemTemplate>
                        <ItemStyle Width="120px" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
            <div class="clear"></div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:HiddenField ID="CurrentPage" runat="server" Value="0" Visible="false" />
        </div>
    </form>
    <script src="/Resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0" type="text/javascript"></script>
    <script type="text/javascript" src="/js/datetime/datetimepicker.js?v=4.0.1"></script>
    <script src="/js/base64.js?v=4.6.0.3.3.0" type="text/javascript"></script>
    <script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
    <script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

    <script language="javascript" type="text/javascript">
        function CloseMySelf(sender) { window.close(); return false; };
        function setVal(id, title) {
            if (typeof ($('.list-lq ul').find('li[data-item-id="' + id + '"]').html()) == "undefined") {
                $('.list-lq ul').append('<li data-item-id="' + id + '"><a href="#">' + Base64.decode(title) + '</a></li>');
                window.opener.HandlePopupResult(id + "|" + title);
                $('.TRgrid-Hover').closest('tr').remove()
            }
        };
        function removeVal(sender) { alert($(sender).parent().html()); };
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
            var sResult = "";
            var arr = new Array();
            arr = arrTemp.split(";");
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] && arr[i] != value) {
                    sResult += ";" + arr[i];
                }
            }
            $('#divResult').attr("result", sResult.substring(1, sResult.length));
        }
        function pageLoad() {
            $('.selectpicker').selectpicker({ liveSearch: true });
            $('.datepicker').datetimepicker({ timepicker: false, format: 'd/m/Y' });
        };
        $(function () { pageLoad(); })
        $("tr.TRgrid").hover(function () { $(this).addClass("TRgrid-Hover"); }, function () { $(this).removeClass("TRgrid-Hover"); });
    </script>
</body>

</html>
