<%@ Control Language="vb" AutoEventWireup="false" CodeFile="MediaHistory.ascx.vb" Inherits="DesktopModules.Modules.Media.Manager.Media_Process" %>
<div id="vlistplay" runat="server">
    <div class="box box-info">
        <div class="box-header with-border ">
            <div class="row">
                <div class="col-md-12">
                    <h3 class="box-title">Lịch sử biên tập video, audio</h3>
                </div>
            </div>
        </div>
        <div class="box-body">
            <div class="main-body">
                <div class="col-md-12">
                    <div class="process-nav-main">Tiêu đề:</div>
                    <div class="process-nav-name">
                        <asp:Label ID="lbNews" runat="server" />
                    </div>
                    <div class="process-nav-main">Người tạo:</div>
                    <div class="process-nav-name">
                        <asp:Label ID="lbUserCreated" runat="server" />
                    </div>
                    <div style="clear: both;"></div>
                </div>
                <asp:DataGrid ID="drgDataViewer" DataKeyField="ID" Width="100%" runat="server" AllowPaging="false"
                    AutoGenerateColumns="False" CssClass="table-bordered">
                    <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#006699"></HeaderStyle>
                    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                    <ItemStyle CssClass="TRgrid" BackColor="#F7FBFB" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="Thời gian">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# EPORTAL.flReg.ReadDate(Eval("Createdate")) %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="25%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Thông tin xử lý">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" ForeColor="Maroon" Text='<%# GetUserName(DataBinder.Eval(Container.DataItem, "ByUser"))%>'></asp:Label>: 
                                <asp:Label ID="Label6" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProcessName") %>'></asp:Label>
                                <br />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
        </div>
    </div>
</div>
<script>
    $("#ControlBar_ControlPanel").hide();
    function CloseMySelf(sender) { window.close(); return false; }
</script>
<style>
    .process-css {
        padding: 20px;
    }

    .process-nav-main {
        float: left;
        width: 25%;
    }

    .process-nav-name {
        float: left;
        font-weight: bold;
        width: 75%;
        color: #b52f2f;
        padding-bottom: 10px;
    }
</style>
