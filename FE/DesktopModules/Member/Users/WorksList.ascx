<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WorksList.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeWorks" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Danh sách việc làm tuyển dụng</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body box-search-job">
                    <div class="row">
                        <div class="col-md-3 ViTri">
                            <asp:DropDownList ID="ViTri" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 NganhNghe">
                            <asp:DropDownList ID="NganhNghe" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 TinhTP">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 MucLuong">
                            <asp:DropDownList ID="MucLuong"  AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">

                        <div class="col-md-3 TrinhDo">
                            <asp:DropDownList ID="TrinhDo"  AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 KinhNghiem">
                            <asp:DropDownList ID="KinhNghiem"  AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 GioiTinh">
                            <asp:DropDownList ID="GioiTinh" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtSearch" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="box_list_works">
                            <asp:Literal ID="litHot" runat="server"></asp:Literal>
                            <asp:Literal ID="litVal" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="currPage" Value="1" runat="server" Visible="false" />
        <asp:HiddenField ID="vUrl" Value="1" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
    </Triggers>
</asp:UpdatePanel>

