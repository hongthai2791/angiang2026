<%@ Control Language="VB" AutoEventWireup="false" CodeFile="VanBanPhapQuy.ascx.vb" Inherits="DesktopModules.Home.VanBanPhapQuy" %>

        <div class="col-md-4">
            <asp:DropDownList CssClass="selectpicker" ID="DocGroup_ID" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-md-4">
            <asp:DropDownList CssClass="selectpicker" ID="DocType_ID" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
         <div class="col-md-4">
            <asp:DropDownList CssClass="selectpicker" ID="DocField_ID" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="clear"></div>
        <div class="col-md-6 pdt10">
            <asp:DropDownList CssClass="selectpicker" ID="DocUnit_ID" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="col-md-4 pdt10">
            <asp:TextBox CssClass="TextBox " ID="Search" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2 pdt10">
            <asp:Button ID="cmdFind" Text="Tìm kiếm"  CssClass="cmdFind_VB" runat="server"></asp:Button>
        </div>
        <div class="clear"></div>
        <div class="col-md-12 mgt10 vb_total">
            <asp:Literal ID="lbTotal" runat="server"></asp:Literal>
        </div>
        <div class="clear"></div>
        <div class="col-md-12 mgt10">
            <div class="vban-phapquy">
                <div class="noidung-vb">
                    <table style="width: 100%;">
                        <tbody>
                            <tr class="tieudeu-vb">
                                <td style="width: 15%; font-weight: 600; text-align: center;">Số hiệu</td>
                                <td class="hidden-xs" style="width: 15%; font-weight: 600; text-align: center;">Ngày ban hành</td>
                                <td style="width: 60%; font-weight: 600; text-align: center;"><span>Trích yếu</span></td>
                                <td style="width: 10%; font-weight: 600; text-align: center;">Tệp gốc</td>
                            </tr>
                            <asp:Literal ID="litRow" runat="server"></asp:Literal>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class="clear"></div>
        <div class="col-md-12 mgt10">
            <asp:Literal ID="litPage" runat="server"></asp:Literal>
        </div>
        <div class="clear"></div>
        <asp:HiddenField ID="DOC_LIST_GROUP" runat="server" Visible="false" />
        <asp:HiddenField ID="currPage" runat="server" Value="1" />
