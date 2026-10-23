<%@ Control Language="VB" AutoEventWireup="false" CodeFile="JobUserChoose.ascx.vb" Inherits="Modules.PageWork.View" %>
<asp:UpdatePanel runat="server" ID="pUserProfile">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Danh sách CV ứng viên phù hợp để giới thiệu (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsSelect" runat="server" CssClass="CheckBox cDel" ToolTip="Chọn để xóa?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle Width="4%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="CV ứng viên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CVUngVien" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Họ tên ứng viên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTen" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="18%" />
                                    <HeaderStyle Width="18%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tuổi" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Tuoi" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="8%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DienThoai" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Trình độ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TrinhDo" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                    <HeaderStyle Width="10%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngành nghề" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NganhNghe" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" />
                                    <HeaderStyle Width="15%" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Giới thiệu cho doanh nghiệp" CssClass="cmsbut cmsbtchange" OnClientClick="return retunwaiting();" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="WID" runat="server" />

        <div id="myDetailUserProfile" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content" style="width: 950px">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông tin hồ sơ ứng viên</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body" data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; max-height: calc(100vh - 40px);">
                        <div class="row" style="top: 0px !important">
                            <div class="myDetailUserProfile">
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <script type="text/javascript">
            function popDetailJobuser(pid, id, us) {
                waiting();
                $.ajax({
                    type: 'GET', url: '/api/work/works.asmx/DetailJobUserworkGT?pid=' + pid + '&id=' + id +'&us=' + us,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data) {
                            $(".myDetailUserProfile").html(json.data);
                            removewaiting();
                            $("#myDetailUserProfile").modal('show');
                        };
                    },
                });
            };
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
        <asp:AsyncPostBackTrigger ControlID="Career_ID" />
        <asp:AsyncPostBackTrigger ControlID="Salary_ID" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
    </Triggers>
</asp:UpdatePanel>

