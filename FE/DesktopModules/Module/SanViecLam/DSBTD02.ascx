<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DSBTD02.ascx.vb" Inherits="DesktopModules.Modules.DSBTD02" %>
<asp:UpdatePanel runat="server" ID="pnlDoanhNghiepThamGia">
    <ContentTemplate>
        <div class="row">
            <div class="a2-head">
                <div class="col-md-3">
                    <asp:DropDownList ID="nganhNghe" data-placeholder="Chọn ngành nghề..." runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="chucVu" data-placeholder="Chọn chức danh..." runat="server" CssClass="selectpicker" AutoPostBack="true" DataValueField="Id" DataTextField="TenChucDanh"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="trinhDo" data-placeholder="Chọn trình độ..." runat="server" CssClass="selectpicker" AutoPostBack="true" DataValueField="Id" DataTextField="TrinhDoChuyenMonKyThuat"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" AutoPostBack="true" ID="sapXep" CssClass="selectpicker">
                        <asp:ListItem Text="Ngày cập nhật mới nhất" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Tên doanh nghiệp" Value="1"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="a2-table">
                    <asp:GridView runat="server" ID="drgRecruitment" CssClass="svl_table" Border="0" AutoGenerateColumns="false" AllowPaging="false" DataKeyNames="Work_ID" Width="100%">
                        <Columns>
                            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="5%">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex + 1%>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tuyển dụng/Doanh Nghiệp" ItemStyle-HorizontalAlign="Left">
                                <ItemTemplate>
                                    <div style="font-weight: bold;">
                                        <%#WORK.flCheck.LinkWork_Name(Me.PortalId, Eval("Work_ID"))%>
                                    </div>
                                    <div><%# Eval("Business_Vn")%></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Số lượng" >
                                <ItemTemplate>
                                    <%#Eval("Quantity")%>
                                </ItemTemplate>
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Chức danh" >
                                <ItemTemplate>
                                    <%#EPORTAL.flDic.Position_Name(Me.PortalId, Eval("LevelDesired_ID"))%>
                                </ItemTemplate>
                                <ItemStyle Width="20%" HorizontalAlign="Center" />
                                <HeaderStyle Width="20%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mức lương" >
                                <ItemTemplate>
                                    <%#WORK.flCheck.Salary_Name(Me.PortalId, Eval("Salary_ID"))%>
                                </ItemTemplate>                                
                                <ItemStyle Width="17%" HorizontalAlign="Center" />
                                <HeaderStyle Width="17%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Trình độ" >
                                <ItemTemplate>
                                    <%#EPORTAL.flDic.Education_Name(Me.PortalId, Eval("Level_ID"))%>
                                </ItemTemplate>                                
                                <ItemStyle Width="17%" HorizontalAlign="Center" />
                                <HeaderStyle Width="17%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nộp hồ sơ ứng tuyển" >
                                <ItemTemplate>
                                    <a href="<%=EPORTAL.flReg.WebConfig("member") %>" title="Đăng nhập để nộp hồ sơ">
                                        <img src="/image/svl/svl_vao.png" alt="Vào phỏng vấn" />
                                    </a>
                                </ItemTemplate>
                                <ItemStyle Width="15%" HorizontalAlign="Center" />
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle CssClass="svl_header" />
                        <RowStyle CssClass="svl_row" />
                        <AlternatingRowStyle CssClass="svl_altrow" />
                    </asp:GridView>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
        </div>
        <div class="none">
            <asp:HiddenField ID="ItemID" Value="" runat="server" />
            <asp:HiddenField ID="curentPage" Value="1" runat="server" />
            <asp:Button ID="cmdNext" runat="server" CssClass="none" />
            <script type="text/javascript">function nextpage_02(p) { $("#<%=curentPage.ClientID  %>").val(p); $("#<%=cmdNext.ClientID  %>").click(); };</script>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="nganhNghe" />
        <asp:AsyncPostBackTrigger ControlID="chucVu" />
        <asp:AsyncPostBackTrigger ControlID="trinhDo" />
        <asp:AsyncPostBackTrigger ControlID="sapXep" />
        <asp:AsyncPostBackTrigger ControlID="cmdNext" />
    </Triggers>
</asp:UpdatePanel>
