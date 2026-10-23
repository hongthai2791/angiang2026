<%@ Control Language="vb" CodeFile="TemplateEdit.ascx.vb" Inherits="Modules.FileAttach.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin mẫu báo cáo</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clear"></div>
            <div class="col-md-2 lb">Tên mẫu</div>
            <div class="col-md-10">
                <asp:TextBox ID="FileAttach_Des" runat="server" TabIndex="5" CssClass="TextBox" />
            </div>
            <div class="col-md-2 pdt5">Tệp đính kèm</div>
            <div class="col-md-10">
                <asp:FileUpload runat="server" ClientIDMode="Static" CssClass="fileMod none" onchange="setValue(this,'fileMod');" accept=".doc,.docx" ID="fileMod" />
                <input type="button" id="ipFile1" runat="server" class="file-bt" onclick="triggerUpload('fileMod')" value="Chọn tệp" />
                <div class="file-up fileMod"></div>
                <asp:Literal ID="litDown1" runat="server" />
                <asp:TextBox runat="server" ID="FileName" Visible="false" />
                <asp:TextBox runat="server" ID="FileAttach" Visible="false" />
            </div>
              <div class="clear"></div>
            <div class="col-md-2 lb ">Thứ tự</div>
            <div class="col-md-4">
                <asp:TextBox ID="FileAttach_IsOrder" runat="server" TabIndex="7" CssClass="TextBox center validate[required, custom[integer]]" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" TabIndex="8" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" TabIndex="10" CssClass="cmsbut cmsbtdel" />
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
