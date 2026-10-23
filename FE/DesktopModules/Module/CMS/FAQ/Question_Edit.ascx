<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Question_Edit.ascx.vb" Inherits="DesktopModules.FAQ.Question_Edit" EnableViewState="true" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN CÂU HỎI</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div id="newContent" runat="server">
                <div class="col-md-12">
                <div class="col-md-2 b pdt5">Chọn phân hệ</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Họ tên</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="_Name" CssClass="TextBox" runat="server" Width="100%"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Nội dung</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="_Contents" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Email</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="_Email" runat="server" CssClass="TextBox "></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Số điện thoại</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="_Phone" runat="server" CssClass="TextBox "></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Nội dung trả lời</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="_FAQAnswer"  runat="server" TextMode="MultiLine" Height="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                </div>

            </div>
        </div>
    </div>
</div>
<asp:HiddenField runat="server" ID="ItemID" Visible="false" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDuyet" runat="server" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" Text="Duyệt hiển thị" CssClass="cmdbtt cmdPublic" />
        <asp:Button ID="cmdHuyDuyet" runat="server" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" Text="Hủy duyệt" CssClass="cmdbtt cmdStop" />
        <asp:Button ID="cmdDel" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
