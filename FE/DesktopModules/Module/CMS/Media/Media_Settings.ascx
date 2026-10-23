<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Media_Settings.ascx.vb" Inherits="DotNetNuke.Modules.Media_Settings" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP QUY TRÌNH LÀM VIỆC</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 pdt5 b">Tiêu đề danh sách:</div>
                <div class="col-md-10">
                    <asp:TextBox ID="WF_TITLE" CssClass="TextBox" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b">*. Kiểu dữ liệu media:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_TYPE" CssClass="selectpicker" runat="server" AutoPostBack="true" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b">1. Quy trình xử lý:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_FROM" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:CheckBox ID="WF_NEW" runat="server" Text="Có chức năng thêm mới?" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b" style="color: red">2. Quy trình nhận trả lại:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_RETURN" CssClass="selectpicker" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b">3. Quy trình gửi đến:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_TO" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXT" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>

            <div class="row">
                <div class="col-md-2 pdt5 b">4. Quy trình trả lại 1:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_BACK1" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_BACK_TEXT1" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 b">5. Quy trình trả lại 2:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_BACK2" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_BACK_TEXT2" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 b">6. Quy trình trả lại 3:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_BACK3" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_BACK_TEXT3" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 b">7. Trang kế tiếp:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_PAGE" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_PAGETEXT" CssClass="TextBox" runat="server" placeholder="Tên trang kế tiếp" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 b">8. Trang kế tiếp:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_PAGENEXT" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_PAGENEXTTEXT" CssClass="TextBox" runat="server" placeholder="Tên trang kế tiếp" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div style="clear: both;"></div>

            <div class="col-md-7 pdl0 pdbt0 mgbt0">
                <div style="clear: both;"></div>
                <div class="col-md-3 pdt5 b">9. Tin đã xuất bản:</div>
                <div class="col-md-9 pdl30">
                    <asp:CheckBox ID="WF_PUBLIC" runat="server" Text="Hiện thị danh sách tin đã xuất bản" />
                </div>
                <div style="clear: both;"></div>
                <div class="col-md-3 pdt5 b">10. Tin ngừng đăng:</div>
                <div class="col-md-9 pdl30">
                    <asp:CheckBox ID="WF_STOP" runat="server" Text="Hiện thị danh sách tin ngừng xuất bản" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="col-md-5">
                <div style="font-weight: bold;">11. Quyền tác nghiệp:</div>
                <div style="padding-left: 20px" class="no-border">
                    <asp:CheckBoxList ID="WF_ROLE" runat="server"></asp:CheckBoxList>
                </div>
                <div style="clear: both;"></div>
            </div>
            <div style="clear: both;"></div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Thiết lập cài đặt" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
