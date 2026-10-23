<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Ab_EditSet.ascx.vb" Inherits="DotNetNuke.Modules.Edit_Settings" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP QUY TRÌNH LÀM VIỆC</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 pdt5 b">1. Quy trình mặc định:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_DEFAULT" CssClass="selectpicker" runat="server" />
                </div>             
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXTDF" CssClass="TextBox" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
              <div class="row">
                <div class="col-md-2 pdt5 b">2. Quy trình gửi đến 1:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_TO1" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXT1" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b">3. Quy trình gửi đến 2:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_TO2" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXT2" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row  none">
                <div class="col-md-2 pdt5 b">4. Quy trình gửi đến 3:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_TO3" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXT3" CssClass="TextBox" placeholder="Tên nút chức năng" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>          
             <div class="row">
                <div class="col-md-2 pdt5 b">5. Quy trình xuất bản:</div>
                <div class="col-md-5">
                    <asp:DropDownList ID="WF_PUBNOW" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="WF_TEXTPUBNOW" CssClass="TextBox" runat="server" />
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row">
                <div class="col-md-2 pdt5 b">6. Vai trò xuất bản ngay:</div>

                <div class="col-md-5 no-border">
                    <asp:CheckBoxList ID="WF_PUBROLE" runat="server"></asp:CheckBoxList>
                </div>
                <div style="clear: both;"></div>
            </div>
            <div class="row none">
                <div class="col-md-2 pdt5 b">7. Sử dụng bản dịch tiếng Việt</div>
                <div class="col-md-5 no-border" >
                    <asp:CheckBoxList ID="WF_VIVN" runat="server"></asp:CheckBoxList>
                </div>
                <div style="clear: both;"></div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Thiết lập cài đặt" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
