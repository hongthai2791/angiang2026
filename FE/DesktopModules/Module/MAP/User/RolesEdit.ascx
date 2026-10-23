<%@ Control Language="vb" CodeFile="RolesEdit.ascx.vb" Inherits="Modules.Roles.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin Nhóm người dùng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clr"></div>
            <div class="col-md-2 pdt5">Hệ thống tác nghiệp</div>
            <div class="col-md-10">
                <asp:DropDownList ID="SubMod_ID" CssClass="selectpicker SubMod_ID" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Mã vai trò</div>
            <div class="col-md-3">
                <asp:TextBox ID="Roles_Code" runat="server" onchange="checkcode(this,'msgError')" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="col-md-7 msgError"></div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Tên vai trò</div>
            <div class="col-md-10">
                <asp:TextBox ID="Roles_Name" runat="server" CssClass="TextBox validate[required]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Mô tả</div>
            <div class="col-md-10">
                <asp:TextBox ID="Roles_Des" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 pdt5">Sử dụng?</div>
            <div class="col-md-4">
                <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox" />
            </div>
            <div class="col-md-2 pdt5 txt-right">Thứ tự</div>
            <div class="col-md-1">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox txt-center validate[required,custom[number]]" />
            </div>
            <div class="clear"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" />
</div>
<script type="text/javascript">
    function checkcode(t, c) { $("." + c).html(""); $.ajax({ type: 'GET', url: '/api/admin/check.asmx/roles?pid=0&subid=' + $("#<%=SubMod_ID.ClientID %>").val() + '&id=' + $("#<%=ItemId.ClientID %>").val() + '&code=' + $(t).val(), success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $("." + c).html(json.data); $(t).val(""); }; }, }); };
</script>
