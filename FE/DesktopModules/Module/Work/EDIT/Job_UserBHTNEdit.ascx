<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Job_UserBHTNEdit.ascx.vb" Inherits="Modules.Job_UserBHTNEdit.Edit" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin hồ sơ</h3>
        </div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row pdt0">
                <fieldset class="mgt0 pdt0">
                    <legend title="Thông tin hồ sơ được lấy từ hệ thống BHTN" data-toggle="tooltip">Thông tin hồ sơ BHTN
                    </legend>
                    <div class="clear"></div>
                    <div class="col-md-1 b pdt5">Họ và tên</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_HoTen" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Ngày sinh</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_NgaySinh" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Giới tính</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_GioiTinh" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Email</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_Email" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-1 b pdt5">Số CMND</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_CMND" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Ngày cấp</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_NgayCap" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Nơi cấp</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_NoiCap" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Số sổ BHXH</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_SoBHXH" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-1 b pdt5">Số điện thoại</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_DienThoai" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Tôn giáo</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_TonGiao" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Dân tộc</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_DanToc" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-1 b pdt5">Trình độ GD</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="BHTN_GDPhoThong" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Trình độ đào tạo</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="BHTN_TDCM" Enabled="false" runat="server" CssClass="TextBox" />
                        <asp:HiddenField ID="BHTN_IDNghe" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-2 b pdt5">Kinh nghiệm làm việc</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="BHTN_Kinhnghiemlamviec" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 b pdt5">Ngành nghề mong muốn</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="BHTN_NganhngheMongmuon" Enabled="false" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 b pdt5">Vị trí mong muốn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="BHTN_ViTri" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 b pdt5">Mức lương mong muốn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="BHTN_MucLuong" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Nơi làm việc mong muốn</div>
                    <div class="col-md-5">
                        <asp:TextBox ID="GTVLNoiLamViecMongmuon_TenHuyen" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-5">
                        <asp:TextBox ID="GTVLNoiLamViecMongmuon_TenTinh" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                </fieldset>

                <fieldset>
                    <legend title="Vui lòng điền đầy đủ các thông tin trước khi chuyển hồ sơ BHTN này thành hồ sơ xin việc trên hệ thống" data-toggle="tooltip">Thông tin hồ sơ xin việc</legend>
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="clear"></div>
                            <div class="col-md-2 b">Tiêu đề hồ sơ</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="Title" runat="server" MaxLength="250" CssClass="TextBox validate[required]" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2 b">Ngày đăng</div>
                            <div class="col-md-2 ">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="StartDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-2 b" style="text-align: right;">Ngày hết hạn</div>
                            <div class="col-md-2 ">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="EndDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                                    <span class="required"></span>
                                </div>
                            </div>
                            <div class="col-md-3 b" style="text-align: right;">Duyệt hồ sơ</div>
                            <div class="co-md-1">
                                <asp:CheckBox ID="IsApproval" Checked="true" CssClass="cs-select" runat="server" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-2">Ngành nghề</div>
                            <div class="col-md-10">
                                <asp:DropDownList ID="Career_ID" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <asp:UpdatePanel runat="server" ID="uptinh">
                                <ContentTemplate>
                                    <div class="col-md-2">
                                        Nơi ứng tuyển
                                    </div>
                                    <div class="col-md-3" runat="server" id="divSelectTP">
                                        <asp:DropDownList ID="TinhTP" AutoPostBack="true" data-actions-box="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                                    </div>
                                    <div class="col-md-7 divQuanHuyen" runat="server" id="divSelectQH">
                                        <asp:DropDownList ID="QuanHuyen" multiple="multiple" data-actions-box="true" CssClass="selectpicker QuanHuyen" runat="server" />
                                    </div>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                                </Triggers>
                            </asp:UpdatePanel>
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
                            <div class="clear"></div>
                            <div class="col-md-3 b">Chức vụ mong muốn</div>
                            <div class="col-md-9">
                                <asp:DropDownList ID="LevelDesired" CssClass="selectpicker " runat="server" />
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-3 b">Số năm kinh nghiệm</div>
                            <div class="col-md-9">
                                <asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-3 b">Mức lương đề xuất</div>
                            <div class="col-md-9">
                                <asp:DropDownList ID="Salary_ID" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="col-sm-6">
                            <div class="col-md-3 b">Chức vụ hiện tại</div>
                            <div class="col-md-9">
                                <asp:DropDownList ID="CurrentLevel" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-3 b">Trình độ</div>
                            <div class="col-md-9">
                                <asp:DropDownList ID="Level_ID" CssClass="selectpicker validate[required]" runat="server" />
                                <span class="required"></span>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-3 b">Nhu cầu làm việc</div>
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
                </fieldset>
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="ItemID" runat="server" Visible="true" />
<asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
<asp:HiddenField ID="HidTinhTP" runat="server" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" data-toggle="tooltip" ToolTip="Chuyển hồ sơ BHTN này thành hồ sơ xin việc và lưu lại thông tin xin việc" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdSend" Visible="false" data-toggle="tooltip" ToolTip="Chuyển nhanh hồ sơ BHTN này thành hồ sơ xin việc và không lưu lại các thông tin xin việc" runat="server" Text="Chuyển nhanh" CssClass="cmsbut cmsbtnew" OnClientClick="return $('#Form').validationEngine('detach');" />

    </div>
</div>
