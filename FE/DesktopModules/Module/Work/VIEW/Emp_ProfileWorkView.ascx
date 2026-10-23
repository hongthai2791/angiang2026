<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Emp_ProfileWorkView.ascx.vb" Inherits="Modules.EPORTAL.View" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Danh sách hồ sơ đã ứng tuyển (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
        <div class="col-md-2 ">
            <asp:DropDownList Visible="false" ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        </div>
        <div class="col-md-1">
            <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:UpdatePanel ID="pageView" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="PhuongXa" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Status_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-5 ">
                            <asp:DropDownList ID="Business_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Gender" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
                    <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
                    <asp:AsyncPostBackTrigger ControlID="Status_ID" />
                    <asp:AsyncPostBackTrigger ControlID="Business_ID" />
                    <asp:AsyncPostBackTrigger ControlID="Career_ID" />
                    <asp:AsyncPostBackTrigger ControlID="Salary_ID" />
                    <asp:AsyncPostBackTrigger ControlID="Gender" />

                </Triggers>
            </asp:UpdatePanel>
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
                        <asp:TemplateColumn HeaderText="Thông tin tuyển dụng" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ProfileWork" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="40%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Thông tin ứng viên" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ProfileUser" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Trạng thái hồ sơ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
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
                            </ItemTemplate>
                            <HeaderStyle Width="22%" />
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
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdActive" runat="server" Text="Cập nhật" OnClientClick="waiting();" CssClass="cmsbut cmsbtupdate" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
        <asp:LinkButton runat="server" OnClick="btnExport_Click" ID="btnExport" Text="<i class='fa fa-file-excel-o'></i> Xuất Excel" CssClass="btn btn-primary"></asp:LinkButton>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
<asp:HiddenField ID="IsActive" Value="True" runat="server" Visible="false" />
