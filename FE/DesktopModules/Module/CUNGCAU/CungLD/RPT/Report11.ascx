<%@ Control Language="vb" CodeFile="Report11.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v19.1, Version=19.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Báo cáo tùy biến</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-12">
                <dx:ASPxPivotGrid  OLAPConnectionString="provider=MSOLAP;data source=DESKTOP-AK1LIRG;cube name=LaodongPortalCB04NK;initial catalog=laodongportalcb04;locale identifier=9;user id=;password=" OptionsCustomization-CustomizationFormStyle="Excel2007" ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID">
                    <Fields>
                        <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Tỉnh/TP" FieldName="[Dm Diaban].[Dm Tinh - City Index Level1].[Dm Tinh - City Index Level1]"
                            ID="fieldDmTinhCityIndexLevel1" Name="fieldDmTinhCityIndexLevel1" />
                        <dx:PivotGridField ID="fieldNamsl" Area="ColumnArea" AreaIndex="0" Caption="Năm dữ liệu" FieldName="[Table Namsolieu].[Namsl].[Namsl]" Name="fieldNamsl">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldLaodong" Area="DataArea" AreaIndex="0" Caption="Lực lượng lao động" DisplayFolder="Table Personal Info Items" FieldName="[Measures].[Laodong]" Name="fieldLaodong">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldDmHuyenCityIndexLevel2" Area="RowArea" AreaIndex="1" Caption="Quận/Huyện" FieldName="[Dm Diaban].[Dm Huyen - City Index Level2].[Dm Huyen - City Index Level2]" Name="fieldDmHuyenCityIndexLevel2">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldCityIndexLevel3" Area="RowArea" AreaIndex="2" Caption="Phường/Xã" FieldName="[Dm Diaban].[City Index Level3].[City Index Level3]" Name="fieldCityIndexLevel3">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldCityIndexLevel4" Area="RowArea" AreaIndex="3" Caption="Thôn/Tổ" FieldName="[Dm Diaban].[City Index Level4].[City Index Level4]" Name="fieldCityIndexLevel4">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldSexId" Area="ColumnArea" AreaIndex="1" Caption="Giới tính" FieldName="[TableSex].[Sex Id].[Sex Id]" Name="fieldSexId">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldTdcmId" Area="ColumnArea" AreaIndex="2" Caption="TĐCM" FieldName="[TableTdcm].[Tdcm Id].[Tdcm Id]" Name="fieldTdcmId">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldTdhvId" Area="ColumnArea" AreaIndex="3" Caption="TĐHV" FieldName="[TableTdhv].[Tdhv Id].[Tdhv Id]" Name="fieldTdhvId">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldUnWorkTypeId" Area="ColumnArea" AreaIndex="4" Caption="Loại thất nghiệp" FieldName="[TableUnWorkType].[Un Work Type Id].[Un Work Type Id]" Name="fieldUnWorkTypeId">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="fieldWorkJoinId" Area="ColumnArea" AreaIndex="5" Caption="Công việc" FieldName="[TableWorkJoin].[Work Join Id].[Work Join Id]" Name="fieldWorkJoinId">
                        </dx:PivotGridField>
                    </Fields>
                    <OptionsView HorizontalScrollBarMode="Auto" />
                    <OptionsFilter NativeCheckBoxes="False" />

                    <OptionsCustomization CustomizationFormStyle="Excel2007"></OptionsCustomization>
                </dx:ASPxPivotGrid>
            </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" Cssclass="cmsbut cmsback" />
                <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" Cssclass="cmsbut cmdexel " />
                <div class="clear"></div>
            </div>
        </div>
    </div>
</div>

