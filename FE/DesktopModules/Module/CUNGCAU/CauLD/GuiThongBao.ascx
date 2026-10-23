<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="GuiThongBao.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports1" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">GỬI THÔNG BÁO CHO DOANH NGHIỆP (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
        <div class="col-md-1">
            <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel runat="server" ID="poe">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-4 col-xs-6">
                            <asp:DropDownList ID="TinhTP" runat="server" onchange="waiting();" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-4 col-xs-6">
                            <asp:DropDownList ID="QuanHuyen" runat="server" onchange="waiting();" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="TrangThai" runat="server" onchange="waiting();" AutoPostBack="true" CssClass="selectpicker Years_ID" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <fieldset>
                            <legend>Nội dung gửi thông báo cho doanh nghiệp cập nhật thông tin</legend>
                            <div class="col-md-12">
                                <asp:TextBox ID="NoiDung" CssClass="std med NoiDung" TextMode="MultiLine" Height="50" runat="server" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-10 col-xs-12 lbthoigian">
                                <asp:Literal ID="ThoiGian" runat="server"></asp:Literal>
                            </div>
                            <div class="col-md-2 txt-right">
                                <asp:Button CssClass="btSendMail" runat="server" ID="cmdSend" Text="Gửi email thông báo" />
                            </div>
                            <div class="clear"></div>
                        </fieldset>
                    </div>


                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="btSelect" runat="server" CssClass="cs-select bCur bDel" onclick="clickSelect('bDel','cDel');" ToolTip="Chọn để gửi mail" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsSelect" Visible="false" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để gửi mail" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="3%" />
                                    <ItemStyle HorizontalAlign="Center" Width="3%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="STT" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã số thuế" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TaxCode" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenDoanhNghiep" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DiaChi" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="30%" />
                                    <ItemStyle Width="30%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Email/ Điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Email" runat="server" /><br />
                                        <asp:HiddenField ID="HF_Email" Visible="false" runat="server" />
                                        <asp:Literal ID="DienThoai" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="20%" />
                                    <ItemStyle Width="20%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/check.png" title="Thông báo" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="ThaoTac" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="4%" />
                                    <ItemStyle HorizontalAlign="Center" Width="4%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderTemplate>
                                        <img src="/image/images/download.png?w" title="Tải phiếu điều tra">
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="TaiPhieu" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="4%" />
                                    <ItemStyle HorizontalAlign="Center" Width="4%" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
                    <asp:HiddenField ID="ToDate" runat="server" Visible="false" />
                    <asp:HiddenField ID="FromDate" runat="server" Visible="false" />
                    <asp:HiddenField ID="hidID" runat="server" />
                    <asp:HiddenField ID="currPage" runat="server" Visible="false" />
                    <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
                    <asp:AsyncPostBackTrigger ControlID="TrangThai" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>
</div>
<script type="text/javascript">
    function xuatExcel(id) { $("#<%=hidID.ClientID %>").val(id); popdoc('exports'); return false; }
    function exports() {
        var bcID = $("#<%=hidID.ClientID %>").val();
        var dtype = $("#docx:checked").val(); if (dtype == "true") { dtype = ".docx" } else { dtype = ".pdf" }
        window.open("/exports?page=work&view=ExCauLD&typeid=PhieuDTDN&bcID=" + bcID + "&dtype=" + dtype);
    };
    function activeselect(d, t) {
        var id = $(t).attr("id");
        var noidung =$(".NoiDung").html()
        if ($(".e-" + id).html() == "") {
            notify('info', 'Doanh nghiệp này không có email để gửi thông báo.', 'Thông báo', false);
        }
        else {
            $.ajax({
                type: 'GET', url: '/api/work/cauld.asmx/guiThongBao?id=' + id + "&d=" + d + "&nd=" + noidung,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (d == "1") {//Lock
                        notify('success', 'Đã gửi thông báo tới doanh nghiệp.', 'Thông báo', false);
                        $(".se-" + id).attr('src', '/image/images/select.png'); $(t).attr("onclick", "activeselect(0,this)");
                    }
                    else {//Unlock
                        $(".se-" + id).attr('src', '/image/images/unselect.png'); $(t).attr("onclick", "activeselect(1,this)");
                        notify('info', 'Chưa gửi thông báo tới doanh nghiệp.', 'Thông báo', false);
                    }
                },
            });
        }
    }
</script>
