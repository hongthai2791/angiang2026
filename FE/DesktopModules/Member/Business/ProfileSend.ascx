<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ProfileSend.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách hồ sơ đã ứng tuyển (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList Visible="false" ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-5 ">
                            <asp:TextBox ID="Business_Name" CssClass="TextBox" Enabled="false" runat="server" />
                            
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Status_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Gender" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thông tin hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="W_Title" runat="server" />
                                        <asp:Literal ID="HoTen" runat="server" />
                                        <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                    </ItemTemplate>
                                    <HeaderStyle CssClass="TenBC respo-view" HorizontalAlign="Center" />
                                    <ItemStyle CssClass="TenBC respo-title" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tuổi" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Tuoi" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="CV ứng tuyển" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CV_UngTuyen" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="25%" />
                                    <HeaderStyle Width="25%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Trạng thái hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SoLuong" runat="server" />
                                        <asp:Panel ID="pnTrangThai" runat="server">
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsView" Text="Đã Xem" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsContact" Text="Đã liên hệ" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsInterview" Text="Đã phỏng vấn" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsTest" Text="Đã test" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsElect" Text="Trúng tuyển" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:CheckBox ID="IsCancel" Text="Từ chối" CssClass="cblist" runat="server" />
                                            </div>
                                            <div class="clear"></div>
                                        </asp:Panel>
                                    </ItemTemplate>
                                    <HeaderStyle Width="25%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div id="myDetailVL" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông tin chi tiết tin tuyển dụng</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body " data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; height: 500px">
                        <div class="row" style="top: 0px !important">
                            <div class="myDetailVL">
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div id="myDetailVLUV" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content" style="width: 950px">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông tin chi tiết CV ứng viên</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body" data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; max-height: calc(100vh - 40px);">
                        <div class="row" style="top: 0px !important">
                            <div class="myDetailVLUV">
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="row text-center pd10">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdActive" runat="server" Text="Cập nhật" CssClass="cmsbut cmsbtupdate cbclick" />
              
            </div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
        <asp:HiddenField ID="Business_ID" runat="server" Visible="true" />
        <asp:HiddenField ID="hIdUser" runat="server" />
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="TinhTP" runat="server" Visible="false" />
        <asp:HiddenField ID="QuanHuyen" runat="server" Visible="false" />
        <script type="text/javascript">
              $('.header').click(function () {
                $(this).toggleClass('expand').parents('tr.tr-parent').nextUntil('tr.tr-parent').slideToggle(100);
                if ($(this).hasClass("expand") == false) {
                    $(this).html("<i class='fa fa-angle-double-left' aria-hidden='true' ></i>");
                }
                else {
                    $(this).html("<i class='fa fa-angle-double-down' aria-hidden='true' ></i>");
                }
            });
            function popDetailVL(pid, id) {
                waiting();
                $.ajax({
                    type: 'GET', url: '/api/member/data.asmx/Detailvieclam?pid=' + pid + '&id=' + id,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data) { $(".myDetailVL").html(json.data); removewaiting(); $("#myDetailVL").modal('show'); };
                    },
                });
            };
            function popDetailVLUV(pid, id, rid, us) {
                waiting();
                $(".tr-" + id).removeClass("blue"); $("input.m-IsView-" + id).attr("checked", "checked");
                $.ajax({
                    type: 'GET', url: '/api/member/data.asmx/DetailUngVien?pid=' + pid + '&id=' + id + '&rid=' + rid + '&username=' + us,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data) { $(".myDetailVLUV").html(json.data); removewaiting(); $("#myDetailVLUV").modal('show'); };
                    },
                });
            };
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
        <asp:AsyncPostBackTrigger ControlID="Status_ID" />
        <asp:AsyncPostBackTrigger ControlID="Career_ID" />
        <asp:AsyncPostBackTrigger ControlID="Salary_ID" />
        <asp:AsyncPostBackTrigger ControlID="Gender" />
        <asp:AsyncPostBackTrigger ControlID="cmdActive" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack" />
    </Triggers>
</asp:UpdatePanel>
