<%@ Control Language="vb" CodeFile="PreviewTemp.ascx.vb" Inherits="Modules.ExDistrict.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info " style="background:#fff!important">
    <div class="box-header with-border fix-top">
        <div class="col-md-12">
            <asp:Literal ID="litTitle" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body mgt30">
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="litTraLai" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="litData" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="litPage" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <asp:Literal ID="litUpdate" runat="server" />
                <div class="clear"></div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
            </div>
        </div>
    </div>
    <asp:HiddenField ID="TempRpt_ID" runat="server" />
    <asp:HiddenField ID="Temp_Name" runat="server" />
</div>
