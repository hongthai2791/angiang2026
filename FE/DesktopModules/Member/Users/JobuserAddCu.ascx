<%@ Control Language="vb" AutoEventWireup="true" CodeFile="JobuserAddCu.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin hồ sơ xin việc làm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-sm-9">
                    <div class="col-md-2">Tiêu đề hồ sơ</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Title" runat="server" MaxLength="250" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5">Ngày đăng</div>
                    <div class="col-md-2 ">
                        <div class="rccalpopup">
                              <asp:TextBox ID="StartDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker TuNgay TextBox validate[required]" runat="server" />
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="col-md-2 txt-right pdt5">Ngày hết hạn</div>
                    <div class="col-md-2">
                        <div class="rccalpopup">
                            <asp:TextBox ID="EndDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker DenNgay TextBox validate[required]" runat="server" />
                            <span class="required"></span>
                        </div>
                    </div>
                    <div class="col-md-3 txt-right none">Hồ sơ đã duyệt </div>
                    <div class="co-md-1 none">
                        <asp:CheckBox ID="IsApproval" Enabled="false" CssClass="cs-select " runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5">Ngành nghề</div>
                    <div class="col-md-10">
                       <asp:DropDownList ID="Career_ID" CssClass="selectpicker validate[required]" runat="server" />
                       <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <asp:UpdatePanel runat="server" ID="uptinh">
                        <ContentTemplate>
                            <div class="col-md-2 pdt5">
                                Nơi ứng tuyển
                               <asp:CheckBox CssClass="chkMultiple Checkbox right" AutoPostBack="true" runat="server" ID="chkMultiple" ToolTip="Tích để chọn nhiều tỉnh thành phố" />
                            </div>
                            <div class="col-md-3" runat="server" id="divSelectTP">
                                
                                 <asp:DropDownList ID="TinhTP" AutoPostBack="true" data-actions-box="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                                 <asp:DropDownList ID="TinhTPMulti" onchange="getMultiple(); " multiple="multiple" data-actions-box="true" CssClass="none selectpicker TinhTP2 validate[required]" runat="server" />
                                 <span class="required"></span>
                            </div>
                            <div class="col-md-7  divQuanHuyen" runat="server" id="divSelectQH">
                              
                                <asp:DropDownList ID="QuanHuyen" multiple="multiple" data-actions-box="true" CssClass="selectpicker QuanHuyen" runat="server" />
                                <asp:HiddenField ID="HidQuanHuyen" runat="server" />
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                        </Triggers>
                    </asp:UpdatePanel>
                    <div class="clear"></div>
                </div>
                <div class="col-md-3">
                    <div class="col-md-12 txt-center ist-img">
                        <div id="imgDD" style="cursor: none; margin: 0 auto; float: unset;" runat="server" class="seimgselect ImgView list-img">
                            <img class="vImg" src="/image/images/noimage.png?w=120" alt="Ảnh đại diện" />
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin chung
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="col-md-3">Chức vụ mong muốn</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="LevelDesired" CssClass="selectpicker " runat="server" />
                     
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3">Số năm kinh nghiệm</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3">Mức lương đề xuất</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Salary_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-sm-6">
                    <div class="col-md-3">Chức vụ hiện tại</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="CurrentLevel" CssClass="selectpicker validate[required]" runat="server" />
                           <span class="required"></span>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-3">Trình độ</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Level_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3">Nhu cầu làm việc</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Needs_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin trình độ, kinh nghiệm
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-12">Trình độ học vấn</div>
                    <div class="col-md-12 telerik-editor">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="Education" Width="100%" runat="server"
                            TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/FooterEditor.xml"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="22px" Font-Names="Tahoma" Height="300px">
                        </telerik:RadEditor>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="col-md-12">Kinh nghiệm làm việc</div>
                    <div class="col-md-12 telerik-editor">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="CareerGoals" Width="100%" runat="server"
                            TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/FooterEditor.xml"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="22px" Font-Names="Tahoma" Height="300px">
                        </telerik:RadEditor>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin mục tiêu, kỹ năng
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-12">Mục tiêu nghề nghiệp</div>
                    <div class="col-md-12 telerik-editor">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="WorkExperience" Width="100%" runat="server"
                            TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/FooterEditor.xml"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="22px" Font-Names="Tahoma" Height="300px">
                        </telerik:RadEditor>
                    </div>
                </div>
                <div class="col-md-6">

                    <div class="col-md-12">Kỹ năng sở trường</div>
                    <div class="col-md-12 telerik-editor">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="SkillsForte" Width="100%" runat="server"
                            TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/FooterEditor.xml"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" EnableViewState="False"
                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="22px" Font-Names="Tahoma" Height="300px">
                        </telerik:RadEditor>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin người tham khảo
                </div>
            </div>
            <div class="row">
                <table border="1" class="tbl">
                    <tr>
                       <td  width="5%" class="hdTitle center">STT</td> 
                    <td  width="12%"class="hdTitle">Họ tên</td>
                    <td width="12%" class="hdTitle">Chức vụ</td>
                    <td class="hdTitle">Nơi công tác</td>
                    <td width="12%" class="hdTitle">Số điện thoại</td>
                    <td width="12%" class="hdTitle">Email</td>
                    <td width="12%" class="hdTitle">Mối quan hệ</td>
                    <td width="5%" class="hdTitle center"><i class="fa fa-trash"></i></td>
                    </tr>
                    <tr>
                       <td class="">1</td> 
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_HoTen"></asp:TextBox>
                        <asp:HiddenField runat="server" ID="HF_NTK1_ID" Value="0" Visible="false"/>
                    </td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_ChucVu"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_NoiCongTac"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_SoDienThoai"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_Email"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK1_MoiQuanHe"></asp:TextBox></td> 
                        <td class=""><asp:LinkButton ToolTip="Xóa người tham khảo" runat="server" ID="btnXoa1" OnClick="btnXoa1_Click" CssClass="btn btn-danger"><i class="fa fa-trash"></i></asp:LinkButton></td>
                    </tr>
                    <tr>
                       <td class="">2</td> 
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_HoTen"></asp:TextBox>
                        <asp:HiddenField runat="server" ID="HF_NTK2_ID" Value="0" Visible="false"/>

                    </td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_ChucVu"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_NoiCongTac"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_SoDienThoai"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_Email"></asp:TextBox></td>
                    <td class=""><asp:TextBox runat="server"  CssClass="Textbox" id="NTK2_MoiQuanHe"></asp:TextBox></td>
                        <td class=""><asp:LinkButton ToolTip="Xóa người tham khảo" runat="server" ID="btnXoa2" OnClick="btnXoa2_Click" CssClass="btn btn-danger"><i class="fa fa-trash"></i></asp:LinkButton></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="clr clUp "></div>
    <asp:Literal ID="litUpdate" runat="server" />
</div>
<asp:HiddenField ID="ItemID" runat="server" Visible="true" />
<asp:HiddenField ID="HidTinhTP" runat="server" />
<div class="row text-center pd10">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple(); return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');"/>
    </div>
</div>
<script type="text/javascript">
     function setMultiple() {
    var vdata = $('#<%= HidTinhTP.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
    $('#<%= TinhTPMulti.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
    $("#<%= TinhTPMulti.ClientID%>").trigger('selectpicker:updated');
     });
     vdata = $('#<%= HidQuanHuyen.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
     $('#<%= QuanHuyen.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
     $("#<%= QuanHuyen.ClientID%>").trigger('selectpicker:updated');
     });
     };
     function getMultiple() {
     $('#<%=HidTinhTP.ClientID%>').val($("#<%= TinhTPMulti.ClientID%>").val());
     $('#<%=HidQuanHuyen.ClientID%>').val($("#<%= QuanHuyen.ClientID%>").val());
     };
</script>
