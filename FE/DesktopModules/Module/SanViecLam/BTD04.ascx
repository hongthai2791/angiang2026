<%@ Control Language="VB" AutoEventWireup="false" CodeFile="BTD04.ascx.vb" Inherits="DesktopModules.Modules.BTD04" %>
<div class="row ">
        <div class="a4-box">
            <div class="reportTitle" style="margin-top: 10px">Thông tin chung</div>
            <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #79ac00; width: 100%">
                <tr>
                    <td class="td-report1">Sàn việc làm</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSanViecLam" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Doanh nghiệp</td>
                    <td class="td-report2">
                        <asp:Label ID="lbtBussines" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Bàn số</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoBan" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Thời gian bắt đầu</td>
                    <td class="td-report2">
                        <asp:Label ID="lblThoiGian" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Thời gian kết thúc</td>
                    <td class="td-report2">
                        <asp:Label ID="lblThoiGianKetThuc" runat="server" /></td>
                </tr>
                <tr>
                    <td class="td-report1">Số ứng viên tham gia</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVien" runat="server" />
                        ứng viên</td>
                </tr>
            </table>
        </div>
        <div class="a4-box">
            <div class="reportTitle" style="margin-top: 10px">Kết quả phiên giao dịch</div>
            <table cellpadding="1" cellspacing="1" style="border-top: 5px solid #79ac00; width: 100%">
                <tr>
                    <td class="td-report1">Ứng viên trúng tuyển</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienTrungTuyen" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Ứng viên đạt</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienDat" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Ứng viên không đạt</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienKhongDat" runat="server" />
                        ứng viên</td>
                </tr>
                <tr>
                    <td class="td-report1">Hẹn phỏng vấn lại</td>
                    <td class="td-report2">
                        <asp:Label ID="lblSoUngVienHenGapLai" runat="server" />
                        ứng viên</td>
                </tr>
            </table>
        </div>
        <div class="a4-box">
            <div class="reportTitle" style="margin-top: 10px;border-bottom: 5px solid #79ac00;margin-bottom:10px;">Danh sách ứng viên tham gia</div>
             <asp:GridView runat="server" ID="GridView1" Border="0" CssClass="svl_table" AutoGenerateColumns="false" AllowPaging="false" DataKeyNames="UngVien_ID" Width="100%">
                <Columns>
                    <asp:TemplateField HeaderText="STT">
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                        </ItemTemplate>
                        <ItemStyle Width="5%" HorizontalAlign="Center" />
                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên ứng viên">
                        <ItemTemplate>
                            <b><%# DataBinder.Eval(Container.DataItem, "tenDayDu")%></b>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Trình độ">
                        <ItemTemplate>
                            <%# EPORTAL.flDic.Education_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "TrinhDoChuyenMon"))%>
                        </ItemTemplate>
                        <ItemStyle Width="20%" HorizontalAlign="Left" />
                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ngành nghề đào tạo">
                        <ItemTemplate>
                            <%#WORK.flCheck.Career_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "NganhNghe"))%>
                        </ItemTemplate>
                        <ItemStyle Width="30%" HorizontalAlign="Left" />
                        <HeaderStyle Width="30%" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Kết quả">
                        <ItemTemplate>
                           <%# FormatKetQuaPhongVan(Eval("KetQuaPhongVan"))%>
                        </ItemTemplate>
                        <ItemStyle Width="15%" HorizontalAlign="Center" />
                        <HeaderStyle Width="15%" HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle CssClass="svl_header" />
                <RowStyle CssClass="svl_row" />
                <FooterStyle CssClass="svl_row" />
                <AlternatingRowStyle CssClass="svl_altrow" />
            </asp:GridView>
        </div>
</div>
<asp:HiddenField ID="BusID" Visible="false" runat="server" />
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />
