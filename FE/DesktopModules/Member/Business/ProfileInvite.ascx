<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ProfileInvite.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách hồ sơ ứng viên đã mời (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
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
                        <div class="col-md-3 ">
                            <asp:TextBox ID="Business_Name" CssClass="TextBox" Enabled="false" runat="server" />
                            <asp:HiddenField ID="Business_ID" runat="server" Visible="false" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>

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
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="3%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Hồ sơ xin việc" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="JobWork" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Việc làm" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Work_ID" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày mời" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CreateDate" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                             </asp:TemplateColumn>   
                                   <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsStatus" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                       <ItemStyle HorizontalAlign="Center" />
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
        <asp:Literal ID="lbMsg" runat="server" />
        <div class="row text-center pd10">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="TinhTP" runat="server" Visible="false" />
        <asp:HiddenField ID="QuanHuyen" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
        <asp:AsyncPostBackTrigger ControlID="Career_ID" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack" />
    </Triggers>
</asp:UpdatePanel>
<div id="myDetailVLUV" class="modal fade" role="dialog">
    <div class="modal-dialog modal-lg">
        <div class="modal-content" style="width: 950px">
            <div class="modal-header1">
                <h4 class="modal-title">&nbsp;Thông tin CV hồ sơ ứng viên</h4>
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
<script type="text/javascript">
    function popDetailVLUV1(pid, id) {
        waiting();
        $.ajax({
            type: 'GET', url: '/api/member/data.asmx/DetailUngVien1?pid=' + pid + '&id=' + id,
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) { $(".myDetailVLUV").html(json.data); removewaiting(); $("#myDetailVLUV").modal('show'); };
            },
        });
    };
</script>



