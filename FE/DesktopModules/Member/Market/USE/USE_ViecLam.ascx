<%@ Control Language="VB" AutoEventWireup="false" CodeFile="USE_ViecLam.ascx.vb" Inherits="Modules.SVL.US.USE_ViecLam.View" %>
<asp:HiddenField ID="ItemID" Visible="false" runat="server" />

<div class="col-md-9">
    <asp:TextBox ID="txtFind" placeHolder="Nhập tiêu đề tin cần tìm" CssClass="std med" runat="server" />
</div>
<div class="col-md-3">
    <asp:Button ID="cmdSearch" CssClass="da-button blue large" runat="server" OnClientClick="return $('#Form').validationEngine('detach');" Text="Tìm việc làm" />
</div>
<div class="clear"></div>
<div class="row">
    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
        <ItemStyle BackColor="#f8f4f1" />
        <AlternatingItemStyle BackColor="#ffffff" />
        <Columns>
            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="IsOrder" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Tin tuyển dụng/ Doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="Title" runat="server" />
                    <asp:HiddenField ID="Work_ID" runat="server" />
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Số lượng" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="SoLuong" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                <ItemStyle Width="5%" HorizontalAlign="Center" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Chức danh" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="ChucDanh" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="15%" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Mức lương" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="MucLuong" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="7%" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Nộp hồ sơ" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="Edit" runat="server" />
                    <div class="pdt10">
                        <asp:LinkButton ID="cmdNopHS" runat="server" ToolTip="Nộp hồ sơ ứng tuyển" OnCommand="onCommandItem" CommandArgument='<%#Eval("Business_ID")%>' CommandName='<%#Eval("Work_ID")%>'>
                                    <img src="/image/svl_vao.png?w=24" alt="Nộp hồ sơ" />&nbsp;Nộp hồ sơ
                        </asp:LinkButton>
                        <asp:Literal runat="server" ID="litTrangThaiNop" />
                    </div>
                </ItemTemplate>
                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                <ItemStyle Width="10%" HorizontalAlign="Center" />
            </asp:TemplateColumn>
              <asp:TemplateColumn HeaderText="CV đã nộp" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="CVDaNop" runat="server" />
                </ItemTemplate>
                <HeaderStyle Width="15%" />
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Kết quả phỏng vấn" HeaderStyle-CssClass="hdTitle">
                <ItemTemplate>
                    <asp:Literal ID="TrangThai" runat="server"></asp:Literal>
                </ItemTemplate>
                <HeaderStyle Width="12%" HorizontalAlign="Center" />
                <ItemStyle Width="12%" HorizontalAlign="Center" />
            </asp:TemplateColumn>
        </Columns>
    </asp:DataGrid>
</div>
<div class="modal fade" id="boxNopHS" tabindex="-1" role="dialog">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div>
                <button class="remodal-close" data-dismiss="modal" style="position: fixed !important; left: auto !important; right: -15px !important; top: 10px !important" onclick="toogleModalkt();"><i class="fa fa-times" aria-hidden="true"></i></button>
                <h5 class="hs_block" style="margin-left: 10px !important; margin-right: 10px !important">Danh sách hồ sơ  
                </h5>
            </div>
            <div class="modal-body" style="overflow: hidden !important">
                <asp:Repeater ID="rptProfile" runat="server">
                    <ItemTemplate>
                        <asp:RadioButton ID="radProfile" GroupName="radJobUser" runat="server" CssClass="RadioButton radProfile" onclick="checkradio(this);" ValidationGroup="Profile" />
                        <asp:HiddenField ID="hdProfileId" runat="server" Value='<%# Eval("JobUser_ID") %>' />
                        <span class="font16"><%# Eval("Title") %></span>
                        <p class="rpt-p">
                            <i class="fa fa-calendar" aria-hidden="true"></i>
                            Ngày đăng: <%# EPORTAL.flReg.ReadDate(Eval("StartDate"), False) %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <i class="fa fa-eye" aria-hidden="true"></i>
                            Lượt xem: <%# EPORTAL.flReg.FormatPrice(Eval("IsView")) %>
                        </p>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="center mt-20">
                    <asp:Button ID="btnSend" Visible="false"  runat="server" CssClass="btn-big btn-danger btn_nop " Text="Nộp hồ sơ" />
                </div>
                <div class="footer_popup_success">
                    Bạn gặp khó khăn khi tìm việc?<br>
                    <asp:Literal ID="litHotline1" runat="server"></asp:Literal>
                </div>
            </div>
        </div>

    </div>
</div>
<asp:HiddenField runat="server" ID="_WID" />
<asp:HiddenField runat="server" ID="_BUSID" />
<script type="text/javascript">


    function popDetailJob(pid, id) {
        waiting(); $.ajax({
            type: 'GET', url: '/api/member/data.asmx/GetDetailJob?pid=' + pid + '&idWork=' + id, success: function (data) {
                var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                    $(".main-contents").html(json.data); removewaiting(); $("#showPopup").modal('show');
                };
            },
        });
    };
    function SetUniqueRadioButton(nameregex, current) {
        re = new RegExp(nameregex);
        for (i = 0; i < document.forms[0].elements.length; i++) {
            elm = document.forms[0].elements[i]
            if (elm.type == 'radio') {
                if (re.test(elm.name)) {
                    elm.checked = false;
                }
            }
        }
        current.checked = true;
    }
</script>

