<%@ Control Language="vb" CodeFile="SysCopy.ascx.vb" Inherits="Modules.Settings.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Sao chép chỉ tiêu báo cáo</h3>
        </div>
    </div>
    <asp:UpdatePanel ID="upView" runat="server">
        <ContentTemplate>
    <div class="box-body">
        <div class="main-body">
            <div class="row">

            </div>
            <div class="row">
                <div class="col-md-3">Dữ liệu gốc</div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="TinhTp1" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="QuanHuyen1" Visible="false" AutoPostBack="true" CssClass="selectpicker " />
                </div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="PhuongXa1" Visible="false"  CssClass="selectpicker " />
                </div>
                <div class="col-md-3">Đơn vị nhận dữ liệu</div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="TinhTp2" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="QuanHuyen2" Visible="false"  AutoPostBack="true" CssClass="selectpicker " />
                </div>
                <div class="col-md-3"><asp:DropDownList runat="server" ID="PhuongXa2" Visible="false"  CssClass="selectpicker " />
                </div>
                <div class="clear"></div>
            </div>
            <div class="clr"></div>
                  <asp:Literal ID="litUpdate" runat="server" />
        </div>
    </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="TinhTp1" />
            <asp:AsyncPostBackTrigger ControlID="QuanHuyen1" />
            <asp:AsyncPostBackTrigger ControlID="TinhTp2" />
            <asp:AsyncPostBackTrigger ControlID="QuanHuyen2" />
        </Triggers>
    </asp:UpdatePanel>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
    </div>
</div>
