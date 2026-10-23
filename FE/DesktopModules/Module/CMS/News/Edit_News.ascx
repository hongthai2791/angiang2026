<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Edit_News.ascx.vb" Inherits="DotNetNuke.CMS.Edit" EnableViewState="true" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Literal ID="lbmsg" runat="server" />
<asp:Panel ID="pnContent" CssClass="edit-news" runat="server">
    <div class="fix-btt-toolbar">
        <div>
            <asp:Button ID="cmdExit" runat="server" CssClass="cmdbtt cmdExit" Text="Thoát" OnClientClick="return $('#Form').validationEngine('detach');" />
            <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="updateTags();return checkinput();" />

            <asp:Button ID="cmdRun0" runat="server" CssClass="cmdbtt cmdRun" Text="Thực hiện 0" Visible="false" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdRun1" runat="server" CssClass="cmdbtt cmdRun1" Text="Thực hiện 1" Visible="false" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdRun2" runat="server" CssClass="cmdbtt cmdRun2" Text="Thực hiện 2" Visible="false" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdRun3" runat="server" CssClass="cmdbtt cmdRun3" Text="Thực hiện 3" Visible="false" OnClientClick="updateTags(); return checkinput();" />
            <asp:Button ID="cmdPUBNOW" runat="server" CssClass="cmdbtt cmdPUBNOW" Text="Xuất bản ngay" Visible="false" OnClientClick="updateTags(); return checkinput();" />

            <asp:Button ID="cmdStop" runat="server" CssClass="cmdbtt cmdStop" Text="Ngừng xuất bản" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" />
            <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" OnClientClick="return $('#Form').validationEngine('detach');" />
        </div>
    </div>
    <div class="box box-info">
        <div class="box-header with-border ">
            <div class="col-md-12">
                <h3 class="box-title">Biên tập nội dung tin bài</h3>
            </div>
        </div>
        <div class="box-body">
            <div class="main-body">
                <div class="ubox_wrap">
                    <div class="xhead">
                        <div class="col-sm-2 b pdt7">Nội dung chi tiết</div>
                        <div class="col-sm-10 txt-right pdr0">
                            <asp:Button ID="cmdBack1" runat="server" CssClass="cmdbtt cmdBack" Text="Trả lại 1" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                            <asp:Button ID="cmdBack2" runat="server" CssClass="cmdbtt cmdBack2" Text="Trả lại 2" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                            <asp:Button ID="cmdBack3" runat="server" CssClass="cmdbtt cmdBack3" Text="Trả lại 3" Visible="false" OnClientClick="updateTags(); return checkinput();" />
                            <asp:Button ID="cmdBack4" runat="server" CssClass="cmdbtt cmdBack4" Text="Trả lại 4" Visible="false" OnClientClick="updateTags(); return checkinput();" />

                            <asp:Button ID="cmdDel" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa tin bài" Visible="false" />
                            <asp:Button ID="cmdView" runat="server" CssClass="cmdbtt cmdView" Text="Xem trước" OnClientClick="popuppreview(); return $('#Form').validationEngine('detach');" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="xbody commonx" id="aentdmd">
                        <div class="col-md-6 pdr0">
                            <div class="col-md-12 b">Chọn phân hệ</div>
                            <div class="col-md-12">
                                <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" Width="100%" AutoPostBack="true"></asp:DropDownList>
                                <span class="required"></span>
                            </div>
                        </div>
                        <div class="col-md-6 pdr0">
                            <div class="col-md-12 b">
                                <asp:Literal ID="ParentText" runat="server" Text="Chọn chuyên mục"></asp:Literal>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-12 pdr0">
                                <asp:DropDownList onchange="changeCategory();" ID="ddlCategory" CssClass="selectpicker cmcoption validate[required]" runat="server" Width="100%" DataTextField="CategoryName" DataValueField="CategoryID"></asp:DropDownList>
                                <span class="required"></span>
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-9 pdr0">
                            <div class="row">
                                <div class="col-md-12 b">Tiêu đề tin bài </div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="txtTitle" runat="server" CssClass="TextBox txtTitle  validate[required]" TextMode="MultiLine" Height="40"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="row">
                                <div class="col-md-9 b">Tít phụ</div>
                                <div class="col-md-3 none">
                                    <asp:CheckBox ID="chkIsNewsLive" runat="server" onclick="checkIsNewsKind()" />&nbsp;Tin tường thuật trực tiếp?
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="Introduction" runat="server" CssClass="TextBox"></asp:TextBox>
                                </div>
                                <div class="clear"></div>
                            </div>

                            <div class="row">
                                <div class="col-md-12 b">Tóm tắt tin bài</div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="txtSummary" runat="server" CssClass="TextBox  validate[required]" Height="90px" TextMode="MultiLine" MaxLength="1000"></asp:TextBox>
                                    <span class="required"></span>
                                </div>
                            </div>
                            
                            <di
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lbm"></asp:Label>
                            <div id="DivAvatar">
                                <div class="col-md-6 b">
                                    <span style="float: left;">&nbsp;&nbsp;&nbsp;Ảnh đại diện</span>
                                    <span style="float: right;">
                                        <a title="Xóa ảnh" id="lbtDelImg" runat="server" class="delimages" onclick="DelAvatar()" ></a>
                                    </span>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-12">
                                    <div style="cursor: pointer;" class="seimgselect ImgView " onclick="changekey('avt'); insertavatar(900,550); return false;">
                                        <div id="imgDD" class="list-img chon-dai-dien" runat="server">
                                            <img class="vImg" src="/image/images/noimage.png?dpi=150&quality=100&w=165&h=130" title="Chọn ảnh đại diện khác" alt="Ảnh đại diện" />
                                        </div>
                                    </div>
                                    <div class="clear"></div>
                                    <div class="bt-chon-anh" onclick="changekey('avt'); insertavatar(900,550); return false;">Chọn ảnh khác</div>
                                    <asp:HiddenField ID="txtImagePath" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-12 b">Nội dung chi tiết tin bài</div>
                        <div class="col-md-12 pdr0">
                            <div class="telerik-editor">
                                <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="teContent" Width="100%" runat="server" OnClientCommandExecuted="OnClientCommandExecuted"
                                    OnClientPasteHtml="OnClientPasteHtml" TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/ToolsEditor.xml"
                                    StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" OnClientLoad="OnClientLoad" EnableViewState="False" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                                    EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Height="600px">
                                    <CssFiles>
                                        <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                                    </CssFiles>
                                </telerik:RadEditor>
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-5 txt-right" style="font-style: italic; color: #e80505; font-size: 14px;">(Chú ý: Nội dung Bút danh, nguồn tin sẽ được đưa vào cuối nội dung tin bài khi xuất bản.)</div>
                        <div class="col-md-2 b right pdt5">Bút danh, nguồn tin</div>
                        <div class="col-md-5 pdr0 pdbt0 mgbt0">
                            <asp:TextBox ID="NguonTin" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="50"></asp:TextBox>
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
                <div style="clear: both;"></div>
                <div class="row pdt10">
                    <div class="col-md-7">
                        <div class="ubox_wrap">
                            <div class="xhead"><b>Đặt lịch xuất bản, tin nổi bật, loại tin bài</b></div>
                            <div class="xbody commonx" id="aenlybp1">
                                <div class="col-md-4 col-xs-6 pdr0">
                                    <asp:CheckBox ID="chkCare" CssClass="csHot" runat="server" Text="Tin nóng trang chủ"></asp:CheckBox>
                                </div>
                                <div class="col-md-4 col-xs-6 pdr0">
                                    <asp:CheckBox ID="chkHotCat" CssClass="csHotCat" runat="server" Text="Tin nóng chuyên mục"></asp:CheckBox>
                                </div>
                                <div class="col-md-4 col-xs-6 pdr0">
                                    <asp:CheckBox ID="chkMobile" CssClass="csMobile b" runat="server" Text="Hiển thị trên mobile"></asp:CheckBox>
                                </div>
                            </div>
                            <div class="clear"></div>
                            <div class="col-md-6 pdr0">
                                <div class="col-md-12 b">Lịch xuất bản</div>
                                <div class="col-md-12 pdr0">
                                    <div class="rccalpopup date-pub">
                                        <asp:TextBox ID="txtPublishDate" runat="server" CssClass="timepicker" PlaceHolder="Ngày xuất bản"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0">
                                <div class="col-md-12 b">Loại tin bài</div>
                                <div class="col-md-12">
                                    <asp:DropDownList runat="server" ID="SourceInfo" Width="400px" CssClass="selectpicker">
                                        <asp:ListItem Value="0" Text="Tin thường"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="Tin ảnh"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="Tin video"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="Tin audio"></asp:ListItem>
                                        <asp:ListItem Value="4" Text="Tin ảnh, video"></asp:ListItem>
                                        <asp:ListItem Value="5" Text="Tin ảnh, audio"></asp:ListItem>
                                        <asp:ListItem Value="6" Text="Tin video, audio"></asp:ListItem>
                                        <asp:ListItem Value="7" Text="Tin ảnh, audio, video"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6 pdr0 none">
                                <div class="col-md-12 b">Tác giả bài viết</div>
                                <div class="col-md-12 pdr0">
                                    <asp:DropDownList ID="WriterName" data-actions-box="true" multiple="multiple" runat="server" CssClass="WriterName selectpicker"></asp:DropDownList>
                                    <asp:HiddenField ID="hdWriterName" runat="server" ClientIDMode="Static" />
                                </div>
                            </div>
                        </div>
                        <div class="clear"></div>
                        <div class="ubox_wrap">
                            <div class="xhead">
                                <b>Danh sách tin liên quan</b>
                                <a onclick="popupwindow(900,600); return false;" title="Chọn tin bài sự liên quan">
                                    <img src="/images/icons/note_go.png" alt="Chọn tin liên quan" id="Img1" runat="server" />
                                </a>
                            </div>
                            <div class="xbody1x commonx1x">
                                <div class="list-lq" id="divrelated">
                                    <ul style="padding-left: 0px">
                                        <asp:Repeater runat="server" ID="rptRelated">
                                            <ItemTemplate>
                                                <li>
                                                    <a href="#"><%# Eval("Title")%> </a>
                                                    <a class="delRelated" onclick="javascript:delRl(this,<%# Eval("NewId")%>);" title="Remove this?" style="cursor: pointer;"></a>
                                                </li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="clear"></div>
                            </div>
                        </div>
                        <div class="clear pdt10"></div>
                        <div class="ubox_wrap">
                            <div class="xhead"><b>Từ khóa (Bấm , để thêm từ khóa mới)</b></div>
                            <div style="clear: both; height: 15px"></div>
                            <div class="col-md-12">
                                <input type="text" value="" id="IdTags" runat="server" class="IdTags" data-role="tagsinput" />
                            </div>
                            <div style="clear: both;"></div>
                        </div>
                        <div style="clear: both;"></div>
                        <asp:Panel CssClass="ubox_wrap" ID="pnButPhe" runat="server" Visible="true">
                            <div class="xhead">
                                <b>
                                    <asp:Literal ID="labBP" runat="server" Text="Bút phê tin bài" /></b>
                            </div>
                            <div style="padding-top: 10px">
                                <div class="col-md-12">
                                    <div class="id-but-phe">
                                        <asp:Literal ID="litButPhe" runat="server" />
                                    </div>
                                </div>
                                <asp:Panel ID="pnAddBp" runat="server" Visible="true">
                                    <div class="col-md-10">
                                        <asp:TextBox ID="txtButPhe" runat="server" TextMode="MultiLine" Height="60px" CssClass="TextBox txtButPhe"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:Button ID="cmdButPhe" runat="server" Text="Lưu ghi chú" OnClientClick="return butphe()" CssClass="cmdbtt cmdSave" />
                                    </div>
                                </asp:Panel>
                                <div class="clear"></div>
                            </div>
                        </asp:Panel>
                        <div style="clear: both;"></div>
                    </div>
                    <div class="col-md-5 pdr0 pdbt0 mgbt0">
                        <div class="ubox_wrap">
                            <div class="xhead"><b>Chuyên mục phụ - Nóng chuyên mục phụ</b></div>
                            <div style="clear: both; height: 15px"></div>
                            <div class="col-md-12 cmp-row">
                                <telerik:RadTreeView ID="catePhu" runat="server" OnClientNodeChecked="ClientNodeChecked" CheckBoxes="True" Height="365px" Width="100%" TriStateCheckBoxes="True" CheckChildNodes="False">
                                    <DataBindings>
                                        <telerik:RadTreeNodeBinding Expanded="True" />
                                    </DataBindings>
                                </telerik:RadTreeView>
                            </div>
                            <div style="clear: both;"></div>
                        </div>
                    </div>
                </div>
                <div style="clear: both; height: 5px"></div>
            </div>
            <div style="clear: both; height: 5px"></div>
            <asp:Panel CssClass="ubox_wrap pnNhuanBut" ID="pnNhuanBut" runat="server" Visible="false">
                <div class="xhead"><b>Chấm nhuận bút</b></div>
                <div class="xbody commonx">
                    <div class="col-md-8">
                        <div class="col-md-3 pdt5 b">Định mức tin tin bài</div>
                        <div class="col-md-4">
                            <asp:DropDownList onchange="loadMoneyTin();" ID="drMaDMTin" Width="100%" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-sm-5">
                            <span style="background: #ff6a00; color: #fff; padding: 7px 16px; float: left; height: 31px;" class="lblTienTin"></span>
                        </div>
                        <asp:DataGrid ID="grdDMAnh" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                            <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                            <ItemStyle BackColor="#f5f5f5" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="50px" HorizontalAlign="Center" CssClass="fix-column" />
                                    <HeaderStyle Width="50px" HorizontalAlign="Center" CssClass="fix-column" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="ID" Visible="false">
                                    <ItemTemplate>
                                        <asp:Literal ID="ID" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="fix-column" />
                                    <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Định mức ảnh">
                                    <ItemTemplate>
                                        <asp:Literal ID="drMaDMAnh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle CssClass="column-primary" />
                                    <ItemStyle CssClass="column-primary" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Hệ số">
                                    <ItemTemplate>
                                        <asp:Literal ID="HeSo" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="HeSo respo-view" />
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="HeSo respo-title" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số lượng">
                                    <ItemTemplate>
                                        <telerik:RadNumericTextBox ID="SoLuong" Width="100%" Value="0" runat="server" CssClass="grdtxt center soluong" NumberFormat-AllowRounding="false" />
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" HorizontalAlign="Center" CssClass="SoLuong respo-view" />
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" CssClass="SoLuong respo-title" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Đơn giá">
                                    <ItemTemplate>
                                        <asp:Literal ID="DonGia" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" CssClass="DonGia respo-view" HorizontalAlign="Center" />
                                    <HeaderStyle Width="15%" CssClass="DonGia respo-title" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tiền nhuận bút">
                                    <ItemTemplate>
                                        <telerik:RadNumericTextBox ID="IsMoney" Width="100%" Value="0" runat="server" ReadOnly="true" CssClass="grdtxt center money-div monney" NumberFormat-AllowRounding="false" />
                                    </ItemTemplate>
                                    <ItemStyle Width="20%" CssClass="IsMoney respo-view" HorizontalAlign="Center" />
                                    <HeaderStyle Width="20%" CssClass="IsMoney respo-title" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="col-md-4 pdr0">
                        <div class="col-md-12 pdt5 b">Ghi chú chậm nhuận bút</div>
                        <div class="col-md-12 pdt5 pdr0">
                            <asp:TextBox ID="txtNotePrices" runat="server" TextMode="MultiLine" Height="238px" CssClass="TextBox txtNotePrices"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <%--Bản dịch tiếng việt--%>
            <div style="clear: both; height: 5px"></div>
            <div class="ubox_wrap newVN" id="newVN" runat="server" visible="false">
                <div class="xhead xhead-vi"><b>Bản dịch tiếng việt</b></div>
                <div class="xbody commonx" id="transtevn">
                    <div class="w-control">
                        <div class="w-label-new">Tiêu đề (<span style="color: Red;">*</span>)</div>
                        <div class="w-text-new">
                            <asp:TextBox ID="TitleVN" CssClass="TextBox" runat="server" TextMode="MultiLine" Height="40"></asp:TextBox>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="w-control">
                        <div class="w-label-new">Tóm tắt</div>
                        <div class="w-text-new">
                            <asp:TextBox ID="SummaryVN" CssClass="TextBox" runat="server" Height="55px" TextMode="MultiLine" ToolTip="Input summary" MaxLength="1000"></asp:TextBox>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="w-label-new" style="width: 9.5%">Nội dung</div>
                    <div class="w-text-new telerik-editor" style="width: 88.5%">
                        <telerik:RadEditor ClientIDMode="Static" NewLineMode="P" CssClass="texteditor" ID="ContentVN" Width="100%" runat="server" OnClientCommandExecuted="OnClientCommandExecuted"
                            OnClientPasteHtml="OnClientPasteHtml" TemplateManager-ViewPaths="/Portals/_default/HtmlEditor" ToolsFile="/Portals/_default/HtmlEditor/ToolsEditor.xml"
                            StripFormattingOptions="MSWordRemoveAll,Css,Font,Span" OnClientLoad="OnClientLoad" EnableViewState="False" DialogsCssFile="/portals/_default/skins/vbn/css/telerik.css?v=2.0.1"
                            EnableEmbeddedBaseStylesheet="True" ContentFilters="DefaultFilters" Font-Size="14px" Font-Names="Arial" Height="480px">
                            <CssFiles>
                                <telerik:EditorCssFile Value="/portals/_default/skins/vbn/css/vi.css?v=3.3.3" />
                            </CssFiles>
                        </telerik:RadEditor>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:HiddenField ID="ItemID" runat="server" />
        <asp:HiddenField ID="WF_DEFAULT" runat="server" />
        <asp:HiddenField ID="WF_TO1" runat="server" Value="0" Visible="false" />
        <asp:HiddenField ID="WF_TO2" runat="server" Value="0" Visible="false" />
        <asp:HiddenField ID="WF_TO3" runat="server" Value="0" Visible="false" />

        <asp:HiddenField ID="WF_STATUS" Value="0" runat="server" />

        <asp:HiddenField ID="WF_BACK1" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK2" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK3" Value="0" runat="server" />
        <asp:HiddenField ID="WF_BACK4" Value="0" runat="server" />

        <asp:HiddenField ID="WF_ROLE" Value="0" runat="server" />
        <asp:HiddenField ID="WF_PUBNOW" Value="0" runat="server" />
        <asp:HiddenField ID="hdf_theloai" runat="server" />
        <asp:HiddenField ID="cateID_NPhu" runat="server" Value="" />
        <asp:HiddenField ID="cateID_CMP" runat="server" Value="" />
        <asp:HiddenField ID="hdf_Category" runat="server" />
        <asp:HiddenField ID="hdf_Related" runat="server" />
        <asp:HiddenField ID="hdf_Tags" runat="server" />
        <asp:HiddenField ID="_HTTPAlias" runat="server" />
        <asp:HiddenField ID="WF_VIVN" runat="server" Visible="false" />
        <asp:HiddenField ID="NB_ID" runat="server" />
        <asp:HiddenField ID="nowStatus" runat="server" Value="False" />
        <asp:HiddenField ID="lockNews" runat="server" Value="False" />
        <asp:HiddenField ID="butPhe" runat="server" />
        <div class="WriterFullName"></div>

    </div>
    <link href="/js/tags/bootstrap-tagsinput.css?v=2" rel="stylesheet" type="text/css" />
    <script src="/js/tags/bootstrap-tagsinput.min.js?v=2"></script>
    <div class="idk none"><%=Guid.NewGuid.ToString() %></div>
    <script type="text/javascript">
       
    

        $("#teContent .ImageManager").click(function () { changekey('imgvn'); insertimg(900, 550, 'goc'); return false; });
        $("#teContent .DocumentManager").click(function () { changekey('imgnew'); insertdoc(900, 550, 'goc'); return false; });
        $("#teContent .MediaManager").click(function () { changekey('medianew'); insertmedia(900, 550, 'goc'); return false; });
        $("#teContent .InsertExternalVideo").click(function () { changekey('multinew'); insertmulti(900, 550, 'goc'); return false; });
        $("#teContent .LinkManager").click(function () { openlink(900, 600, 'goc'); return false; });

        $("#ContentVN .ImageManager").click(function () { changekey('imgvn'); insertimg(900, 550, 'vn'); return false; });
        $("#ContentVN .DocumentManager").click(function () { changekey('imgnew'); insertdoc(900, 550, 'vn'); return false; });
        $("#ContentVN .MediaManager").click(function () { changekey('medianew'); insertmedia(900, 550, 'vn'); return false; });
        $("#ContentVN .InsertExternalVideo").click(function () { changekey('multinew'); insertmulti(900, 550, 'vn'); return false; });
        $("#ContentVN .LinkManager").click(function () { openlink(900, 600, 'vn'); return false; });
        function OnClientCommandExecuted(editor, args) { if (args.get_commandName() === "ToggleScreenMode") { var editorElement = editor.get_element(); if (editor.isFullScreen()) { editorElement.style.position = "absolute"; editorElement.style.zIndex = "9999999999"; } else { editorElement.style.position = ""; editorElement.style.zIndex = ""; } } };
        function butphe() {
            var txt = $(".txtButPhe").val();
            if (txt != "") {
                var user = "<%=Me.UserInfo.DisplayName%>"; var date = "<%=Now %>"; var htl = "<div class='nd-bp'>" + txt + "</div>";
                htl += "<div class='gc-bp'>" + user + " - " + date + "</div>"; $(".id-but-phe").append(htl); $(".txtButPhe").val("")
            }
            else { alert("Bạn chưa nhập vào nội dung bút phê cho tin bài.") }
            $("#<%=butPhe.ClientID%>").val($(".id-but-phe").html());
            return false;
        };
        var pid = $("#<%=ddlPortal.ClientID%>").val();
        var itemid = $("#<%=ItemID.ClientID%>").val();
        if (itemid != "") {
            var dmID = $("#<%=drMaDMTin.ClientID%>").val(); if (dmID == undefined) { dmID = 0 }
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + pid + "', 'ID': '" + dmID + "','ItemID':'" + itemid + "','type':'<%=CMS.CategoryType.News%>' }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });
            var loadMoneyTin = function () {
                var dmID = $("#<%=drMaDMTin.ClientID%>").val(); if (dmID == undefined) { dmID = 0 }
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + pid + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        } else {
            var dmID = $("#<%=drMaDMTin.ClientID%>").val(); if (dmID == undefined) { dmID = 0 }
            $.ajax({
                type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                data: "{ 'PortalID':'" + pid + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
            });
            var loadMoneyTin = function () {
                var dmID = $("#<%=drMaDMTin.ClientID%>").val(); if (dmID == undefined) { dmID = 0 }
                $.ajax({
                    type: "POST", url: '/api/admin/nhuanbut.asmx/GetMoney', contentType: "application/json; charset=utf-8",
                    data: "{ 'PortalID':'" + pid + "', 'ID': '" + dmID + "','ItemID':'0','type':'<%=CMS.CategoryType.News%>'  }",
                    success: function (response) { $('.lblTienTin').html(response.d); }, error: function (error) { }
                });
            };
        };
        function updatePrice(heso, price, t, id) { var total = parseFloat($(t).val()) * parseFloat(heso) * parseFloat(price); $('.money-' + id).val(total); };
        function popuppreview() { var item = $('#<%=ItemID.ClientID%>').val(); var pid = $('#<%=ddlPortal.ClientID%>').val(); preview(item, pid); };
        function isNumber(evt) { evt = (evt) ? evt : window.event; var charCode = (evt.which) ? evt.which : evt.keyCode; if (charCode > 31 && (charCode < 48 || charCode > 57)) { return false; } return true; };
        $(document).ready(function () { if ($("#DivAvatar img").attr("src") == "" || $("#DivAvatar img").attr("src") == null) { $("#DivAvatar img").attr("src", "/image/images/noimage.png?dpi=150&quality=100&w=165&h=130"); } });
        function DelAvatar() { $("#DivAvatar img").attr("src", "/image/images/noimage.png?dpi=150&quality=100&w=165&h=130"); $("#<%=txtImagePath.ClientID%>").val(""); $(".delimages").css("display", "none"); };
        function OnClientPasteHtml(sender, args) { var commandName = args.get_commandName(); var value = args.get_value(); };
        function getSelectionHtml() { var html = ""; return html; }; function copyToClipboard(s) { return false; }; function showhideUpload() { };
        function OnClientLoad(editor, args) { { editor.attachEventHandler('onkeydown', function (e) { if (e.keyCode == '9') { editor.pasteHtml("&nbsp;"); if (!document.all) { e.preventDefault(); e.stopPropagation(); } else { e.returnValue = false; e.cancelBubble = true; } } }); } };
        function OnClientSelectedIndexChanged(sender, eventArgs) { var item = eventArgs.get_item(); nguontin = item.get_value(); };
        function removeValue(id, value) { var arrTemp = $('#' + id).val(); var sResult = ""; var arr = new Array(); arr = arrTemp.split(";"); for (var i = 0; i < arr.length; i++) { if (arr[i] && arr[i] != value) { sResult += ";" + arr[i]; } } $('#' + id).val(sResult.substring(1, sResult.length)); };
        function addValue(id, value) { var NotExists = ($('#' + id).val().indexOf(value) == -1); if (NotExists) { if ($('#' + id).val() == '' || $('#' + id).val() == null) { $('#' + id).val(value); } else { $('#' + id).val($('#' + id).val() + ';' + value); } } return NotExists; };
        var preVal; function changeCategory() { var eSelect = document.getElementById('<%= ddlCategory.ClientID%>'); if (eSelect.selectedIndex > -1) { var tree = $find("<%= catePhu.ClientID %>"); var allNodes = tree.get_allNodes(); for (var i = 0; i < allNodes.length; i++) { var node = allNodes[i]; node.enable(); node.collapse(); } var preNode = tree.findNodeByValue(preVal); if (preNode) { preNode.set_checked(false); } var catid = eSelect.options[eSelect.selectedIndex].value; document.getElementById('<%= hdf_Category.ClientID %>').value = catid; preVal = catid; var nodechecked = tree.findNodeByValue(catid); if (nodechecked) { nodechecked.set_checked(true); nodechecked.disable(); if (nodechecked.get_parent() != tree) { nodechecked.get_parent().expand(); if (nodechecked.get_parent()) { nodechecked.get_parent().disable(); } for (var j = 0; j < nodechecked.get_nodes().get_count(); j++) { var nodeSub = nodechecked.get_nodes().getNode(j); nodeSub.set_checked(false); } } } } };
        function checkIsNewsKind() { if ($("#<%=chkIsNewsLive.ClientID%>").attr("checked") == "checked") { $('#<%=hdf_theloai.ClientID %>').val(5); } else $('#<%=hdf_theloai.ClientID %>').val(1); };
        jQuery(document).ready(function () { var f = function () { jQuery("[cid]").each(function () { var me = jQuery(this); var cid = me.attr("cid"); var state = jQuery.cookie(cid); if (state == 'hide') { me.hide(); } else { me.show(); } }); jQuery(".xhead").unbind("click"); jQuery(".xhead").bind("click", function () { var me = jQuery(this); var body = me.parent().find(".xbody"); var cid = body.attr("cid"); if (cid == "" || cid == null) { body.toggle(); return; } var state = jQuery.cookie(cid); if (state == 'hide') { jQuery.cookie(cid, ""); body.show(); } else { jQuery.cookie(cid, "hide"); body.hide(); } }); }; f(); $("#hihecmd").attr("style", "display:none"); $("#aenadd").attr("style", "display:none"); $("#transtevn").attr("style", "display:none"); $("#aenlybps").attr("style", "display:none"); });
        $(function () { var theTable = $('table.tablesorter'); $("#filter").keyup(function () { refreshFiles(); }); });
        var totalPage = 0, curpage = 1; var storagePath = '<%= StorageFolder %>';
        function popupwindow(w, h) { var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val(); return window.open("/desktopmodules/module/cms/config/news.aspx?portalid=" + pid, "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left); };
        function HandlePopupResult(result) { var arr = new Array(); arr = result.split(";"); for (var i = 0; i < arr.length; i++) { if (arr[i] != null && arr[i] != '') { var sid = arr[i].split("|")[0]; var stitle = Base64.decode(arr[i].split("|")[1]); if (addValue('<%= hdf_Related.ClientID %>', sid)) { $('.list-lq ul').append('<li><a href="#"> ' + stitle + '</a> <a class="delRelated" onclick="javascript:delRl(this,' + sid + ');" title="Xóa tin liên quan?" style="cursor:pointer;"> </a></li>'); } } } };
        function delRl(sender, id) { if (confirm("Bạn có muốn xóa tin liên quan này không?") == true) { removeValue('<%= hdf_Related.ClientID %>', id); $(sender).parent().remove(); return false; } };
        function updateTags() { $('#<%=hdf_Tags.ClientID %>').val($('.IdTags').val()); }; function OnFail(result) { };
    </script>
    <%--Chèn ảnh từ domain khác--%>
    <script>
        var thnew;
        function insertavatar(w, h) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thnew.terminate(); thnew = undefined;
                        $('#<%= txtImagePath.ClientID %>').val("");
                        if (addValue('<%= txtImagePath.ClientID %>', result)) {
                            $('.list-img img').remove();
                            $('.list-img').append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?dpi=150&quality=100&w=165&h=130" />');
                            $(".delimages").css("display", "block");
                        }
                        $(".IdKey").html();
                    }
                };
            }
            var newid = $("#<%=ItemID.ClientID %>").val();
            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&newid=" + newid + "&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function insertimg(w, h, c) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        var editor; if (c == "goc") { editor = $find('<%=teContent.ClientID%>'); } else { editor = $find('<%=ContentVN.ClientID%>'); }
                        thnew.terminate(); thnew = undefined;
                        var arr = new Array(); arr = result.split("@_@"); var s = "";
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0];
                                s += '<table border="0" id="' + $(".idk").html() + '" class="imgEditor" >';
                                s += '<tr style="text-align:center"><td class="dbox">';
                                s += '<a title="Trái" onclick="leftmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/left.png" alt="left"></a>';
                                s += '<a title="Giữa" onclick="centermybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/center.png" alt="center"></a>';
                                s += '<a title="Phải" onclick="rightmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/right.png" alt="right"></a>';
                                s += '<a title="Xóa" onclick="delmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/images/red-error_16px.gif" alt="del"></a>';
                                s += '</td></tr>';
                                s += '<tr><td style="text-align:center"><img class="imgtelerik" src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '?dpi=150&quality=100&w=620"/></td></tr>';
                                s += '<tr class="alt_imgEditor"><td>&nbsp;</td></tr></table>';

                                $(".idk").html($(".idk").html() + i);
                            }
                        }
                        if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                    }
                };
            }
            var newid = $("#<%=ItemID.ClientID %>").val();
            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&newid=" + newid + "&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function insertdoc(w, h, c) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        var editor; if (c == "goc") { editor = $find('<%=teContent.ClientID%>'); } else { editor = $find('<%=ContentVN.ClientID%>'); }
                        thnew.terminate(); thnew = undefined; var s = "";
                        var arr = new Array(); arr = result.split("@_@");
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                var selection = editor.getSelection(), selectedText = selection.getText();
                                if (selectedText == "") { s = '<span class="docEditor"><a href="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '">' + show + ' </a></span>'; }
                                else { s = '<span class="docEditor"><a href="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '">' + selectedText + ' </a></span>'; }
                            }
                        }
                        if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                    }
                };
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=doc&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function insertmedia(w, h, c) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        var editor; if (c == "goc") { editor = $find('<%=teContent.ClientID%>'); } else { editor = $find('<%=ContentVN.ClientID%>'); }
                        thnew.terminate(); thnew = undefined;
                        var arr = new Array(); arr = result.split("@_@"); var s = "";
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                s += '<table border="0" id="' + $(".idk").html() + '" class="imgEditor" ><tr style="text-align:center">';
                                s += '<td class="dbox">';
                                s += '<a title="Trái" onclick="leftmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/left.png" alt="left"></a>';
                                s += '<a title="Giữa" onclick="centermybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/center.png" alt="center"></a>';
                                s += '<a title="Phải" onclick="rightmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/right.png" alt="right"></a>';
                                s += '<a title="Xóa" onclick="delmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/images/red-error_16px.gif" alt="del"></a>';
                                s += '</td></tr><tr><td style="text-align:center">';
                                s += '<video controls="controls" width="620">';
                                s += '<source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="video/mp4"></video></td></tr>';
                                s += '<tr class="alt_imgEditor"><td>&nbsp</td></tr></table>';
                                $(".idk").html($(".idk").html() + i);
                            }
                        }
                        if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                    }
                };
            }

            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=video&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function insertmulti(w, h, c) {
            var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        var editor; if (c == "goc") { editor = $find('<%=teContent.ClientID%>'); } else { editor = $find('<%=ContentVN.ClientID%>'); }
                            thnew.terminate(); thnew = undefined;
                            var arr = new Array(); arr = result.split("@_@"); var s = "";
                            for (var i = 0; i < arr.length; i++) {
                                if (arr[i] != null && arr[i] != '') {
                                    var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                    s += '<table border="0" id="' + $(".idk").html() + '" class="imgEditor" ><tr style="text-align:center">';
                                    s += '<td class="dbox">';
                                    s += '<a title="Trái" onclick="leftmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/left.png" alt="left"></a>';
                                    s += '<a title="Giữa" onclick="centermybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/center.png" alt="center"></a>';
                                    s += '<a title="Phải" onclick="rightmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/image/images/right.png" alt="right"></a>';
                                    s += '<a title="Xóa" onclick="delmybox(' + "'" + $(".idk").html() + "'" + ')"><img src="/images/red-error_16px.gif" alt="del"></a>';
                                    s += '</td></tr><tr><td style="text-align:center">';
                                    s += '<video controls="controls" width="620">';
                                    s += '<source src="<%=EPORTAL.flConnect.fileDomain%>' + stitle + '" type="video/mp4"></video></td></tr>';
                                s += '<tr class="alt_imgEditor"><td>&nbsp</td></tr></table>';
                                $(".idk").html($(".idk").html() + i);
                            }
                        }
                        if (s != "") { editor.pasteHtml(s); }; $(".IdKey").html("");
                    }
                };
            }
            return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=video&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
        };
        function openlink(w, h, c) { var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val(); return window.open("/desktopmodules/module/cms/config/link.aspx?portalid=" + pid + "&flag=" + c, "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=20, left=' + left); };
        function addlink(link, c) { var editor; if (c == "goc") { editor = $find('<%=teContent.ClientID%>'); } else { editor = $find('<%=ContentVN.ClientID%>'); } var selection = editor.getSelection(), selectedText = selection.getText(); editor.pasteHtml("<a href='" + link + "'>" + selectedText + "</a>"); };
        function getpenname() { var name = ""; $(".search-choice").each(function (e) { name = name + $(this).html() + " - "; }); $(".WriterFullName").html(name); };
        function checkinput() { getmultile(); $("#<%=butPhe.ClientID%>").val($(".id-but-phe").html()); return $('#Form').validationEngine('validate'); };
        window.onbeforeunload = function () { if ($("#<%=lockNews.ClientID %>").val() == "True") { var id = $("#<%=ItemID.ClientID %>").val(); var pid = $("#<%=ddlPortal.ClientID %>").val(); var link = "/api/admin/unlock.ashx?id=" + id + "&pid=" + pid + "&u=<%=Me.UserInfo.Username %>", msg = $.ajax({ url: link, async: false }).responseText; } };
        function setmultile() { var values = $('#<%= hdWriterName.ClientID%>').val(); $.each(values.split(','), function (index, element) { $('#<%= WriterName.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected'); $("#<%= WriterName.ClientID%>").trigger('selectpicker:updated'); }); };
        function getmultile() { var id = $("#<%= WriterName.ClientID%>").val(); $('#<%= hdWriterName.ClientID%>').val(id); };
        function AddJavascriptFile(sfileUrl, oDocument) { var theDoc = oDocument != null ? oDocument : document; var oScript = theDoc.createElement("script"); oScript.setAttribute("src", sfileUrl, 0); oScript.setAttribute("type", "text/javascript"); var oHead = theDoc.getElementsByTagName("head")[0]; oHead.appendChild(oScript); };
        Sys.Application.add_load(function () { var editor = $find("<%=teContent.ClientID%>"); var oDocument = editor.get_document(); AddJavascriptFile("/js/delboxImg.js", oDocument); });
        function AddRemoveHotCategory(sender, value) { if (sender.checked) { addValue('<%= cateID_NPhu.ClientID %>', value); } else { removeValue('<%= cateID_NPhu.ClientID %>', value); } };
        function ClientNodeChecked(sender, eventArgs) { var value = ""; var tree = $find("<%= catePhu.ClientID %>"); var allNodes = tree.get_allNodes(); for (var i = 0; i < allNodes.length; i++) { var node = allNodes[i]; if (node.get_checked()) { value += ";" + node.get_value(); } } $("#<%=cateID_CMP.ClientID %>").val(value); };
    </script>
    <div id="conteVN" runat="server" visible="false">
        <script>Sys.Application.add_load(function () { var editor = $find("<%=ContentVN.ClientID%>"); var oDocument = editor.get_document(); AddJavascriptFile("/js/delboxImg.js", oDocument); });</script>
    </div>
    <asp:Label ID="lbResult" runat="server" />
</asp:Panel>
<%--<%=strCssCn%>--%>
 