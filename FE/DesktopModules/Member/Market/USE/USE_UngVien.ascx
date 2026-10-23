<%@ Control Language="VB" AutoEventWireup="false" CodeFile="USE_UngVien.ascx.vb" Inherits="Modules.SVL.US.USE_UngVien.View" %>
<link href="/js/mark/css/jquery.ui.dialog.css" rel="stylesheet" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="row">
            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                <ItemStyle BackColor="#f8f4f1" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <%#Container.ItemIndex + 1%>
                        </ItemTemplate>
                        <HeaderStyle Width="4%" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Phỏng vấn" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <a class="btn btn-success" onclick="return javascriptCall('<%# Eval("NguoiTimViec_ID") %>')">Gọi phỏng vấn</a>
                        </ItemTemplate>
                        <HeaderStyle Width="10%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Thông tin ứng viên" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <a title="Hồ sơ xin việc của ứng viên" href='<%# WORK.flCheck.GetLinkProfile(WORK.flCheck.JobUser_Name("", 0, Eval("JobUser_ID")), Eval("JobUser_ID")) %>' target="_blank">
                                <span style="color: #a00000; font-weight: bold;"><%# Eval("TenDayDu") %></span><br />
                            </a>
                            <span style="font-weight: normal">Email: </span><strong><%# Eval("Email")%></strong>
                            <span style="font-weight: normal">- Điện thoại: </span><strong><%# Eval("Tel")%></strong>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Việc làm ứng tuyển" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <span style="font-weight: bold; color: #a00000">
                                <%#WORK.flCheck.LinkWork_Name(0, Eval("Work_ID"))%>
                            </span>
                        </ItemTemplate>
                        <HeaderStyle Width="30%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Kết quả" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:DropDownList runat="server" CssClass="selectpicker" ID="KetQuaPhongVan" Width="100%" />
                        </ItemTemplate>
                        <HeaderStyle Width="15%" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <asp:Button ID="cmdUpdateValue" runat="server" CssClass="cmdUpdateValue none" />
        <asp:HiddenField ID="KQPV" runat="server" />
        <asp:HiddenField ID="DNUV_ID" runat="server" />
        <script>
            function updatevalue(t, id) {
                $("#<%=KQPV.ClientID%>").val($(t).val());
                $("#<%=DNUV_ID.ClientID%>").val(id);
                console.log($(t).val());
                console.log(id);
                $(".cmdUpdateValue").click();
            }
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdateValue" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="ItemID" Value="" runat="server" />
<asp:HiddenField ID="hidBusiness_ID" Value="" runat="server" />
