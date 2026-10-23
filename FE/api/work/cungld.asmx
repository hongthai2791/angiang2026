<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CUNG
Imports DotNetNuke.WORK
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim litList As String, n As Integer
    Dim cungCTL As New CungController()
    Dim ObjController As New WorkController()
    Dim arrTemp As New ArrayList
    Dim _tabName As String = "work"
    Dim objConfig As New CMS_Provide_ConfigInfo
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function getValue(pid As Integer, tinh As String, huyen As String, nam As Integer, ky As Integer, key As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Select Case key
            Case "tonghop"
                'data.Data = TongHop(pid, tinh, huyen, nam, ky)
            Case "tanggiam"
                'data.Data = TangGiam(pid, tinh, huyen, nam, ky)
            Case Else
                data.Data = ""
        End Select

        Return JsonConvert.SerializeObject(data, settings)

    End Function
    'Public Function TongHop(pid As Integer, tinh As String, huyen As String, nam As Integer, ky As Integer) As String
    '    litList = flCache.GetCache("BC_TBCuoiKy_TongHop_" & tinh & "_" & huyen & "_" & nam & "_" & ky) & ""
    '    If litList = "" Then
    '        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0' style='font-family: Times New Roman;'>"
    '        litList += "<tr style='text-align: center; color: #fff; font-weight: bold; vertical-align: middle;'>"
    '        litList += "<td style='' class='hdTitle' rowspan='2'>STT</td>"
    '        litList += "<td style='width: 130px; ' class='hdTitle' rowspan='2'>Quận/Huyện</td>"
    '        litList += "<td style='width: 70px; ' class='hdTitle' rowspan='2'>Thời điểm</td>"
    '        litList += "<td colspan='2' style='' class='hdTitle'>Tổng số LĐ</td>"
    '        litList += "<td colspan='6' style='' class='hdTitle'>Trình độ chuyên môn kỹ thuật</td>"
    '        litList += "<td colspan='4' style='' class='hdTitle'>Loại HĐLĐ/ hợp đồng làm việc</td>"
    '        litList += "<td rowspan='2' style='' class='hdTitle'>Tổng số người tham gia BHTN</td>"
    '        litList += "</tr>"
    '        litList += "<tr style='text-align: center; color: #fff; font-weight: bold; vertical-align: middle;'>"
    '        litList += "<td style='' class='hdTitle'>Tổng số</td>"
    '        litList += "<td style='' class='hdTitle'>Trong đó nữ</td>"
    '        litList += "<td style='' class='hdTitle'>CN kỹ thuật không bằng</td>"
    '        litList += "<td style='' class='hdTitle'>Chứng chỉ nghề ngắn hạn dưới 3 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Sơ cấp từ 3-12 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Trung cấp</td>"
    '        litList += "<td style='' class='hdTitle'>Cao đẳng</td>"
    '        litList += "<td style='' class='hdTitle'>ĐH trở lên</td>"
    '        litList += "<td style='' class='hdTitle'>Không xác định thời hạn</td>"
    '        litList += "<td style='' class='hdTitle'>Từ đủ 12 tháng đến 36 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Từ đủ 3 tháng đến dưới 12 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Dưới 3 tháng</td>"
    '        litList += "</tr>"
    '        n = 1
    '        For Each Ci As BC_ThongBaoInfo In ObjController.BC_ThongBao_List_QuanHuyen(pid, tinh, huyen, nam, ky)
    '            litList += "<tr style='vertical-align:middle;'>"
    '            litList += "<td rowspan='4' style='text-align:center;'>" & n & "</td>"
    '            litList += "<td rowspan='4' style='width:130px;'>" & flDic.Regional_Name(pid, Ci.QuanHuyen) & "</td>"
    '            litList += "<td>Đầu kỳ</td>"
    '            Call rowsTongHop(ObjController.BC_TBCuoiKy_TongHop(pid, Ci.QuanHuyen, nam, ky, "Đầu kỳ"))
    '            litList += "</tr>"
    '            litList += "<tr><td>Số tăng</td>"
    '            Call rowsTongHop(ObjController.BC_TBCuoiKy_TongHop(pid, Ci.QuanHuyen, nam, ky, "Số tăng"))
    '            litList += "</tr>"
    '            litList += "<tr><td>Số giảm</td>"
    '            Call rowsTongHop(ObjController.BC_TBCuoiKy_TongHop(pid, Ci.QuanHuyen, nam, ky, "Số giảm"))
    '            litList += "</tr>"
    '            litList += "<tr><td>Cuối kỳ</td>"
    '            Call rowsTongHop(ObjController.BC_TBCuoiKy_TongHop(pid, Ci.QuanHuyen, nam, ky, "Cuối kỳ"))
    '            litList += "</tr>"
    '            n += 1
    '        Next
    '        litList += "</table>"

    '        flCache.SetCache("BC_TBCuoiKy_TongHop_" & tinh & "_" & huyen & "_" & nam & "_" & ky, litList, 5)
    '    End If
    '    Return litList
    'End Function
    'Private Sub rowsTongHop(obj As BC_TBCuoiKyInfo)
    '    If IsNothing(obj) = False Then
    '        litList += "<td style='text-align: center'>" & obj.TongSoLD & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.TongSoNu & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CNKT & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CCN & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.SoCap & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.TrungCap & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CaoDang & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.DaiHoc & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_0T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_36T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_12T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_3T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.BHTN & "</td>"
    '    Else
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '    End If
    'End Sub
    'Public Function TangGiam(pid As Integer, tinh As String, huyen As String, nam As Integer, ky As Integer) As String
    '    litList = flCache.GetCache("BC_LDHoan_TongHop_" & tinh & "_" & huyen & "_" & nam & "_" & ky) & ""
    '    If litList = "" Then
    '        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0' style='font-family: Times New Roman;'>"
    '        litList += "<tr style='text-align: center; color: #fff; font-weight: bold; vertical-align: middle;'>"
    '        litList += "<td style='' class='hdTitle' rowspan='2'>STT</td>"
    '        litList += "<td style='width: 130px; ' class='hdTitle' rowspan='2'>Quận/Huyện</td>"
    '        litList += "<td style='width: 110px; ' class='hdTitle' rowspan='2'>Biến động</td>"
    '        litList += "<td colspan='2' style='' class='hdTitle'>Tổng số LĐ</td>"
    '        litList += "<td colspan='6' style='' class='hdTitle'>Trình độ chuyên môn kỹ thuật</td>"
    '        litList += "<td colspan='4' style='' class='hdTitle'>Loại HĐLĐ/ hợp đồng làm việc</td>"
    '        litList += "</tr>"
    '        litList += "<tr style='text-align: center; color: #fff; font-weight: bold; vertical-align: middle;'>"
    '        litList += "<td style='' class='hdTitle'>Tổng số</td>"
    '        litList += "<td style='' class='hdTitle'>Trong đó nữ</td>"
    '        litList += "<td style='' class='hdTitle'>CN kỹ thuật không bằng</td>"
    '        litList += "<td style='' class='hdTitle'>Chứng chỉ nghề ngắn hạn dưới 3 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Sơ cấp từ 3-12 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Trung cấp</td>"
    '        litList += "<td style='' class='hdTitle'>Cao đẳng</td>"
    '        litList += "<td style='' class='hdTitle'>ĐH trở lên</td>"
    '        litList += "<td style='' class='hdTitle'>Không xác định thời hạn</td>"
    '        litList += "<td style='' class='hdTitle'>Từ đủ 12 tháng đến 36 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Từ đủ 3 tháng đến dưới 12 tháng</td>"
    '        litList += "<td style='' class='hdTitle'>Dưới 3 tháng</td>"
    '        litList += "</tr>"
    '        n = 1
    '        For Each Ci As BC_ThongBaoInfo In ObjController.BC_ThongBao_List_QuanHuyen(pid, tinh, huyen, nam, ky)
    '            litList += "<tr style='vertical-align:middle;'>"
    '            litList += "<td rowspan='3' style='text-align:center;'>" & n & "</td>"
    '            litList += "<td rowspan='3' style='width:130px;'>" & flDic.Regional_Name(pid, Ci.QuanHuyen) & "</td>"
    '            litList += "<td>Lao động tăng</td>"
    '            Call rowsTangGiam(ObjController.BC_LDTang_TongHop(pid, Ci.QuanHuyen, nam, ky))
    '            litList += "</tr>"
    '            litList += "<tr><td>Lao động hoãn</td>"
    '            Call rowsTangGiam(ObjController.BC_LDHoan_TongHop(pid, Ci.QuanHuyen, nam, ky))
    '            litList += "</tr>"
    '            litList += "<tr><td>Lao động giảm</td>"
    '            Call rowsTangGiam(ObjController.BC_LDGiam_TongHop(pid, Ci.QuanHuyen, nam, ky))
    '            litList += "</tr>"
    '            n += 1
    '        Next
    '        litList += "</table>"
    '        flCache.SetCache("BC_LDHoan_TongHop_" & tinh & "_" & huyen & "_" & nam & "_" & ky, litList, 5)
    '    End If
    '    Return litList
    'End Function
    'Private Sub rowsTangGiam(obj As BC_TBCuoiKyInfo)
    '    If IsNothing(obj) = False Then
    '        litList += "<td style='text-align: center'>" & obj.TongSoLD & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.TongSoNu & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CNKT & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CCN & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.SoCap & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.TrungCap & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.CaoDang & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.DaiHoc & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_0T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_36T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_12T & "</td>"
    '        litList += "<td style='text-align: center'>" & obj.HD_3T & "</td>"
    '    Else
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '        litList += "<td style='text-align: center'>0</td>"
    '    End If
    'End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function SendData(pid As Integer, matinh As String, mahuyen As String, maxa As String, mathon As String, yr As Integer, username As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        Dim icount As Integer = 0
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            matinh = flReg.WriteNumber(matinh)
            mahuyen = flReg.WriteNumber(mahuyen)
            maxa = flReg.WriteNumber(maxa)
            mathon = flReg.WriteNumber(mathon)
            yr = flReg.WriteNumber(yr)
            If mahuyen > 0 Then
                cungCTL.CMS_HoGD_Backup(matinh, matinh, mahuyen, maxa, mathon, yr, username)
                cungCTL.CMS_HoGD_Khau_Backup(matinh, matinh, mahuyen, maxa, mathon, yr, username)
            Else
                arrTemp = flDnn.CMS_Regional_Get_By_CMS_Regional(pid, matinh)
                For Each ci As CMS_RegionalInfo In arrTemp
                    cungCTL.CMS_HoGD_Backup(matinh, matinh, ci.Regional_ID, maxa, mathon, yr, username)
                    cungCTL.CMS_HoGD_Khau_Backup(matinh, matinh, ci.Regional_ID, maxa, mathon, yr, username)
                Next
            End If
            'chuyen sang ky du lieu tiep theo
            objConfig = New CMS_Provide_ConfigInfo
            objConfig.ProConfig_ID = flReg.GenKey
            objConfig.TinhTP = matinh
            objConfig.QuanHuyen = 0
            objConfig.PhuongXa = 0
            objConfig.ThonTo = 0
            objConfig.ProConfig_Value = yr + 1
            objConfig.IsActive = True
            objConfig.IsLock = False
            objConfig.IsFlag = 1
            objConfig.UpdatedDate = Now
            objConfig.UpdatedUser = username
            objConfig.CreatedDate = Now
            objConfig.CreatedUser = username
            cungCTL.CMS_Provide_Config_Add(matinh, objConfig)

            flCache.RemoveCache("ProvideYear_" & objConfig.TinhTP)
            flCache.RemoveCache("ProvideLock_" & objConfig.TinhTP)
            data.Data = "Sao lưu dữ liệu thành công"
        Catch ex As Exception
            data.Data = flReg.BugLog(pid, ex.Message, "work")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class

Public Module Moduler
    Public ReadOnly Property UserInfo As UserInfo
        Get
            Dim user As UserInfo
            If (HttpContext.Current Is Nothing) Then
                If Not Thread.CurrentPrincipal.Identity.IsAuthenticated Then
                    Return New UserInfo()
                End If
                Dim portalSettings = PortalController.Instance.GetCurrentPortalSettings()
                If portalSettings IsNot Nothing Then
                    user = UserController.GetCachedUser(portalSettings.PortalId, Thread.CurrentPrincipal.Identity.Name)
                    Return If(user, New UserInfo())
                End If
                Return New UserInfo()
            ElseIf HttpContext.Current.Items("UserInfo") Is Nothing Then
                If HttpContext.Current.Request.IsAuthenticated Then
                    user = UserController.GetCachedUser(PortalSettings.Current.PortalId, HttpContext.Current.User.Identity.Name)
                    HttpContext.Current.Items("UserInfo") = user
                End If
            End If
            user = DirectCast(HttpContext.Current.Items("UserInfo"), UserInfo)
            Return If(user, New UserInfo())
        End Get
    End Property
End Module