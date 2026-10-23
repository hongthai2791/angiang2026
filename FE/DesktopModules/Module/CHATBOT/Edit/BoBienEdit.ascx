<%@ Control Language="vb" CodeFile="BoBienEdit.ascx.vb" Inherits="Modules.BoBienEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<%--<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>--%>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin bộ biến</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên bộ biến</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenBien" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Biến</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropBien" multiple="multiple" data-actions-box="true"  runat="server" CssClass="selectpicker" />
                    </div>
                    <%--<asp:Panel ID="pnArea" Visible="false" runat="server">
                        <div class="col-md-2  txt-center lb">Khu vực</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drArea" runat="server" CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                    </asp:Panel>--%>
                    
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                     <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple();return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="BienID" runat="server" />
        </div>
<%--    </ContentTemplate>
</asp:UpdatePanel>--%>

<script>
    function setMultiple() {
        var vdata = $('#<%= BienID.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
               $('#<%= dropBien.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= dropBien.ClientID%>").trigger('selectpicker:updated');
        });

    };
    function getMultiple() {
        $('#<%= BienID.ClientID%>').val($("#<%= dropBien.ClientID%>").val());
    };
</script>