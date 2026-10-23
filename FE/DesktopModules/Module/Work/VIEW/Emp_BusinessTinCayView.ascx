<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Emp_BusinessTinCayView.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<%@ Register Src="~/DesktopModules/Module/DIC/Main/Breadcum.ascx" TagPrefix="uc1" TagName="Breadcum" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border acv-header ">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách doanh nghiệp tin cậy <asp:Literal ID="litCount" runat="server" /></h3>
                </div>
                <div class="col-md-6 col-xs-6 text-right">
                    <uc1:Breadcum runat="server" ID="Breadcum" />

                </div>
            </div>
            <div class="clear"></div>

            <div class="box-body">
                <div class="acv-body">

                    <div class="row pdt20">
                        <div class="col-md-3">
                            <div class="material-control">
                                <label>Tỉnh/Thành phố</label>
                                <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                            </div>
                        </div>
                      
                        <div class="col-md-3">
                            <div class="material-control">
                                <label>Phường/xã</label>
                                <asp:DropDownList ID="PhuongXa" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                            </div>
                        </div>
                            <div class="col-md-2 none">
                                    <asp:DropDownList ID="drSort" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                             
                            </div>
                            <div class="col-md-2">
                                <div class="material-control">
                                    <label>Số bản ghi trên trang</label>
                                <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                            </div>   </div>
                            <div class="col-md-4">
                                <div class="material-control">
                                    <label>Tìm kiếm</label>
                                    <asp:TextBox ID="txtkey" runat="server" placeholder="Nhập mã, tên ..." CssClass="timKiemD" Columns="20" Width="100%" />
                                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                                </div>
                            </div>
                    </div>
                    <div class="main-body">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa" />
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
                                <asp:TemplateColumn HeaderText="#" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ID" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" />
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="IsEdit" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="3%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Business_Vn" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Người đại diện" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ContactUser" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ContactMobile" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="8%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Address" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="30%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_check.png?w" alt="Active" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsApproval" runat="server" CssClass="cs-select cAct" ToolTip="Hoạt động" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
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
        </div>
        <div class="fix-btt-toolbar">
            <div>
                 <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa tin cậy" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />

    </Triggers>
</asp:UpdatePanel>



