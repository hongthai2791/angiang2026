<%@ Control Language="vb" CodeFile="ImportViewQH.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Biên tập dữ liệu cấp Quận/huyện
                    </h3>
                </div>
                <div class="col-md-7 txt-right">
                    <asp:Button ID="cmdRunAll" runat="server" Text="Tổng hợp DL từ Cung-Cầu" CssClass="cmsbut cbclick Refresh" />
                    <asp:Button ID="cmdMerge" runat="server" Text="Tổng hợp từ cấp cơ sở" CssClass="cmsbut cbclick cmsbtchange" />

                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="PhuongXa" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 text-center lb">Kỳ dữ liệu</div>
                        <div class="col-md-1">
                            <asp:DropDownList ID="YearID"  runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <asp:Button runat="server" ID="btnView" OnClick="btnView_Click" CssClass="btn btn-primary" Text="Xem dữ liệu" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdTarget" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <ItemStyle BackColor="#fbf2ec" />
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
                                            <asp:Literal ID="Targets_Code" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                        <ItemStyle Width="15%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Chỉ tiêu báo cáo" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Targets_Name" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Số liệu báo cáo">
                                        <ItemTemplate>
                                            <asp:TextBox ID="GiaTri" CssClass="TextBox txt-center validate[custom[number]]" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                        <ItemStyle Width="20%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>

                            </asp:DataGrid>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <asp:Literal runat="server" ID="litPage"></asp:Literal>
                </div>

            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdSave" runat="server" Text="Lưu dữ liệu" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa dữ liệu" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>

    </ContentTemplate>
    <Triggers>
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField runat="server" ID="HF_GroupCode" />
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField ID="ItemID" Value="0" runat="server" Visible="false" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />


