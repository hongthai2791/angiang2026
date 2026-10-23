<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="RPT_CauLDJob.ascx.vb" Inherits="DesktopModules.Modules.CauLD_DN" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">BÁO CÁO DỮ LIỆU CẦU NGƯỜI LAO ĐỘNG</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel runat="server" ID="poe">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-2 col-xs-4 pdt5">Tỉnh/ thành phố</div>
                        <div class="col-md-3 col-xs-8">
                            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-2 col-xs-4 pdt5 txt-right">Năm khai thác</div>
                        <div class="col-md-2 col-xs-8">
                            <asp:DropDownList ID="Years_ID" runat="server" AutoPostBack="true" CssClass="selectpicker Years_ID" />
                        </div>
                        <div class="col-md-3 col-xs-12">
                            <asp:Button CssClass="cbtonghop" Text="Tổng hợp toàn bộ" runat="server" ID="cmdTongHop"/>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="STT" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã mẫu biểu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ID" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên biểu mẫu khai thác" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenBaoCao" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tải số liệu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TaiVe" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    <ItemStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tổng hợp số liệu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TongHop" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                    <ItemStyle Width="15%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="Years_ID" />

                </Triggers>
            </asp:UpdatePanel>
        </div>
    </div>
</div>
<script type="text/javascript">
    function tonghop(id, y, tp) {
        if (y == 0) { y = $(".Years_ID").val(); }
        if (tp == 0) { tp = $(".TinhTP").val(); }
        $.ajax({
            type: 'GET', url: '/api/work/cauld.asmx/tonghop?pid=' + <%= Me.PortalId  %> + "&tp=" + tp + "&id=" + id + "&year=" + y,
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) { notify('info', json.data, 'Thông báo', false); removewaiting();};
            },
        });
    };
</script>