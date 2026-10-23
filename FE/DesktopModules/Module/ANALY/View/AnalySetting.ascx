<%@ Control Language="VB" AutoEventWireup="false" CodeFile="AnalySetting.ascx.vb" Inherits="DotNetNuke.Modules.ReportSetting" %>
<asp:UpdatePanel ID="ppp" runat="server">
    <ContentTemplate>

        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">THIẾT LẬP DỮ LIỆU HIỂN THỊ</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div style="clear: both;"></div>
                        <div class="col-md-2 lb">Nhóm chỉ tiêu:</div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Group_ID" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                        </div>
                        <div style="clear: both;"></div>
                        <div class="col-md-2 lb">Chọn chỉ tiêu:</div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Targets_ID" CssClass="selectpicker" runat="server" />
                        </div>
                        <div style="clear: both;"></div>
                        <div class="col-md-2 lb">Chọn loại biểu đồ:</div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="ChartType_ID" CssClass="selectpicker" runat="server" />
                        </div>
                        <div style="clear: both;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdSave" runat="server" Text="Thiết lập cài đặt" CssClass="cmdbtt cmdSave" />
                <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
            </div>
        </div>

    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Group_ID" />
        <asp:AsyncPostBackTrigger ControlID="cmdSave" />
    </Triggers>
</asp:UpdatePanel>
