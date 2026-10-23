<%@ Control Language="vb" AutoEventWireup="false" CodeFile="ConfigUser.ascx.vb" Inherits="DotNetNuke.CMS.EditProfile" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">Phân quyền người sử dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-8">
                <div class="col-sm-12">
                    <p id="ErrorValidate" class="error" style="display: none;">
                        <asp:Label runat="server" ID="lblError"></asp:Label>
                    </p>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Cổng tác nghiệp</div>
                    <div class="col-md-9">
                        <asp:DropDownList runat="server" ID="ddlPortal" CssClass="selectpicker validate[required]" AutoPostBack="true" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Tài khoản truy cập</div>
                    <div class="col-md-9">
                        <asp:TextBox CssClass="TextBox red validate[required]" ID="txtUserName" runat="server" MaxLength="100" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Họ và tên (<span style="color: red">*</span>)</div>
                    <div class="col-md-3">
                        <asp:TextBox CssClass="TextBox validate[required]" ID="txtHo" placeHolder="Họ" runat="server" MaxLength="20"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox CssClass="TextBox" ID="txtDem" placeHolder="Đệm" runat="server" MaxLength="20"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox CssClass="TextBox validate[required]" ID="txtTen" placeHolder="Tên" runat="server" MaxLength="20"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Ngày sinh</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlDay" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlMonth" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlYear" CssClass="selectpicker" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Giới tính</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="drdSex" CssClass="selectpicker" runat="server">
                            <asp:ListItem Text="Nam" Value="Nam" />
                            <asp:ListItem Text="Nữ" Value="Nữ" />
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ChucVu" runat="server" CssClass="selectpicker" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Email (<span style="color: red">*</span>)</div>
                    <div class="col-md-9">
                        <asp:TextBox CssClass="TextBox  validate[required, custom[email]]" ID="txtEmail" placeHolder="mail@example.vn" runat="server" MaxLength="100"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3 b pdt5">Điện thoại</div>
                    <div class="col-md-9">
                        <asp:TextBox CssClass="TextBox" ID="txtPhone" placeHolder="(+99) 999 888 777" runat="server" MaxLength="15"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="drgViewData" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="Chọn">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkChon" ToolTip="Check để gán đơn vị" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="7%" />
                                        <HeaderStyle HorizontalAlign="Center" Width="7%" />
                                    </asp:TemplateColumn>
                                    <asp:BoundColumn HeaderText="M&#227;" DataField="Id" Visible="false" />
                                    <asp:BoundColumn HeaderText="Phòng ban, đơn vị tác nghiệp" DataField="TenPhongBan" />
                                    <asp:TemplateColumn HeaderText="Lãnh đạo">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkNguoiKy" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Center" Width="15%" />
                                        <HeaderStyle HorizontalAlign="Center" Width="15%" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="col-md-4 pdl0">
                <div class="col-md-12 line-row">Quyền tác nghiệp</div>
                <div class="col-md-12 tb-row">
                    <asp:Literal ID="litSub" runat="server"></asp:Literal>
                </div>
                <div class="row line-row tb-row">
                    <div class="col-md-12 pdl0">
                        <asp:CheckBox ID="UserAll" runat="server" CssClass="CheckBox pdl0 chkall" onclick="clickSelect('chkall','chk');" Text="Chuyên mục sử dụng" />
                    </div>
                </div>
                <div class="col-md-12  tb-row scroll" style="height: 590px; background: #fff; overflow: auto; padding-top: 5px; padding-left: 0!important">
                    <div class="col-md-12 pdl10">
                        <asp:CheckBoxList ID="chkCate" CssClass="chk " runat="server"></asp:CheckBoxList>
                    </div>
                </div>
            </div>
            <div class="clear"></div>

        </div>
    </div>
</div>
<asp:HiddenField ID="RolData" runat="server" />
<asp:HiddenField ID="dataVal" runat="server" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="btnReturn" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="btnSignUp" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return getVal();" />
    </div>
</div>
<script type="text/javascript">
    function getVal() { var d = ""; $(".adnew").each(function (e) { if (d === "") { d = $(this).attr("id"); } else { d = d + "," + $(this).attr("id"); } }); $("#<%=RolData.ClientID%>").val(d); return retunwaiting(); };
    function checkinput(id) { if ($("#subra-" + id).hasClass("adnew")) { $("#subra-" + id).removeClass("adnew"); } else { $("#subra-" + id).addClass("adnew"); } };
    function alertError(error) { $('p.error').empty(); $('p.error').append("<img src='/Images/cancelgray.gif' class='close' alt='Close' />"); $('p.error').append(error); $('p.error').fadeIn('slow'); $('img.close').click(function () { $('p.error').fadeOut('slow'); }); };
    function focusAndAlert(name, arlertMess) { document.getElementById(name).style.border = "red 1px solid"; document.getElementById(name).focus(); document.getElementById(name).select(); alertError(arlertMess); };
    function refreshBack(name) { document.getElementById(name).style.border = "#6991b6 1px solid"; };
    function checkValidAt(name) { var val = document.getElementById(name).value; if (val == '' || val == null) return true; return false; };
    function validate_email(name) { var val = document.getElementById(name).value; apos = val.indexOf("@"); dotpos = val.lastIndexOf("."); if (apos < 1 || dotpos - apos < 2) return false; return true; };
    function CheckLengPass(name) { var val = document.getElementById(name).value; if (val.length > 3) return true; return false };
</script>
