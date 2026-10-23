<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.ANALY
Imports DotNetNuke.EPORTAL
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.CompilerServices
Imports System.Threading

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim objControler As New AnalyController
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()
    Dim str() As String
    Dim cthuc As String, iVal As Double
    Dim dataInfo As New CMS_InDataRowInfo
    Dim dataCInfo As New CMS_InDataRowCInfo
    Dim oDt As New DataTable

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function valData(pid As Integer, itemid As String, rowID As String, inputRptC As String, colType As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            data.data = ""
            oDt = CType(flCache.GetCache("CMS_InDataRowC_Get_By_CMS_InputRpt" & pid & "_" & itemid), DataTable)
            For Each Cr As DataRow In oDt.Select("DataRow_ID = '" & rowID & "' AND InputRptC_ID = '" & inputRptC & "'")
                If flReg.WriteNumber(colType) = 2 Then
                    data.data = Cr.Item("GiaTri_So").ToString()
                Else
                    data.data = Cr.Item("GiaTri_Text").ToString()
                End If
                Exit For
            Next
        Catch ex As Exception
            data.data = ""
            flReg.BugLog(pid, ex.Message, "analy")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function lienket(pid As Integer, tinh As Integer, year As Integer, cacl As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            cthuc = flReg.DeCode64(cacl) : str = cthuc.Split("@")
            cthuc = cthuc.Replace("@", "")
            For i As Integer = 0 To str.Length - 1
                If str(i).Contains("#") Then
                    iVal = objControler.CMS_Data_Get_By_Year_Code(pid, tinh, str(i), year)
                    cthuc = cthuc.Replace(str(i), iVal)
                End If
            Next
            Dim a As New Evaluant.Calculator.Expression(cthuc)
            cthuc = System.Math.Round(a.Evaluate, 3)
            data.Data = cthuc
        Catch ex As Exception
            data.Data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function delInDataRow(pid As Integer, rowID As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_InDataRow_Delete(pid, readString(rowID))
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "analy")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function InDataRow(pid As Integer, rowID As String, itemid As String, inputRptC As String, noiDung As String, iTT As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            noiDung = readString(noiDung)
            dataInfo = New CMS_InDataRowInfo
            dataInfo.DataRow_ID = readString(rowID)
            dataInfo.InputRpt_ID = readString(itemid)
            dataInfo.InputRptC_ID = readString(inputRptC)
            dataInfo.NoiDung = flReg.JValue(noiDung)
            dataInfo.IsOrder = flReg.WriteNumber(readString(iTT))
            objControler.CMS_InDataRow_Add(pid, dataInfo)
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "analy")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function InDataRowC(pid As Integer, rowID As String, noidung As String, itt As String, itemid As String, inputRptC As String, targets As String, colType As String, gText As String, gSo As String, inT As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            noidung = readString(noidung)
            dataInfo = New CMS_InDataRowInfo
            dataInfo.DataRow_ID = readString(rowID)
            dataInfo.InputRpt_ID = readString(itemid)
            dataInfo.InputRptC_ID = readString(inputRptC)
            dataInfo.NoiDung = flReg.JValue(noidung)
            dataInfo.IsOrder = flReg.WriteNumber(readString(itt))
            objControler.CMS_InDataRow_Add(pid, dataInfo)

            gText = readString(gText)
            If gText <> "" Then gText = flReg.DeCode64(gText)

            gSo = readString(gSo)
            If gSo <> "" Then gSo = flReg.DeCode64(gSo)
            If gSo <> "" Or gText <> "" Then
                dataCInfo = New CMS_InDataRowCInfo
                dataCInfo.DataRow_ID = readString(rowID)
                dataCInfo.InputRpt_ID = readString(itemid)
                dataCInfo.InputRptC_ID = readString(inputRptC)
                dataCInfo.Targets_ID = readString(targets)
                dataCInfo.ColType = flReg.WriteNumber(readString(colType))
                dataCInfo.GiaTri_Text = flReg.JValue(gText)
                dataCInfo.GiaTri_So = flReg.WriteNumber(gSo)
                dataCInfo.IsOrder = flReg.WriteNumber(readString(inT))

                data.data = objControler.CMS_InDataRowC_Add(pid, dataCInfo)
            Else
                objControler.CMS_InDataRowC_Delete_Value(pid, readString(rowID), readString(inputRptC))
                data.data = readString(rowID)
            End If
        Catch ex As Exception
            data.data = flReg.BugLog(pid, ex.Message, "analy")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod>
    Public Function SaveData(pid As Integer, rowID As String, itemid As String, noidung As String, inputRptC As String, itt As String, inputRptCG As String, targets As String, colType As String, gText As String, gSo As String, inT As String, colCount As Integer) As String
        Call flReg.SetContentResponse()
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim data = New Response
        data.status = ServiceStatus.NODATA
        data.message = "Error"
        Dim rID(), nID(), iRptC(), it2() As String
        Dim icg(), tar(), col(), gt(), gs(), it() As String
        Dim dem As Integer = 0
        Dim countR As Integer = 0
        Try
            rID = rowID.Split("#") : nID = noidung.Split("#") : iRptC = noidung.Split("#") : it2 = itt.Split("#")
            For i = 0 To rID.Count - 1
                If rID(i) <> "" Then
                    If nID(i) <> "" Then
                        dataInfo = New CMS_InDataRowInfo
                        dataInfo.DataRow_ID = readString(rID(i))
                        dataInfo.InputRpt_ID = readString(itemid)
                        dataInfo.InputRptC_ID = readString(iRptC(i))
                        dataInfo.NoiDung = flReg.JValue(nID(i))
                        dataInfo.IsOrder = flReg.WriteNumber(readString(it2(i)))
                        objControler.CMS_InDataRow_Add(pid, dataInfo)

                        icg = inputRptCG.Split("#") : tar = targets.Split("#") : col = colType.Split("#")
                        gt = gText.Split("#") : gs = gSo.Split("#") : it = inT.Split("#")
                        countR = 0
                        For j = dem To icg.Count - 1
                            If dem > 0 And countR = colCount Then
                                Exit For
                            End If
                            If icg(j) <> "" Then
                                If readString(gs(j)) <> "" Or readString(gt(j)) <> "" Then
                                    dataCInfo = New CMS_InDataRowCInfo
                                    dataCInfo.DataRow_ID = readString(rID(i))
                                    dataCInfo.InputRpt_ID = readString(itemid)
                                    dataCInfo.InputRptC_ID = readString(icg(j))
                                    dataCInfo.Targets_ID = readString(tar(j))
                                    dataCInfo.ColType = flReg.WriteNumber(readString(col(j)))
                                    dataCInfo.GiaTri_Text = flReg.JValue(readString(gt(j)))
                                    dataCInfo.GiaTri_So = flReg.WriteNumber(readString(gs(j)))
                                    dataCInfo.IsOrder = flReg.WriteNumber(readString(it(j)))
                                    data.data = objControler.CMS_InDataRowC_Add(pid, dataCInfo)
                                Else
                                    objControler.CMS_InDataRowC_Delete_Value(pid, readString(rID(i)), readString(icg(j)))
                                End If
                            End If
                            dem += 1 : countR += 1
                        Next
                    Else
                        objControler.CMS_InDataRow_Delete(pid, readString(rID(i)))
                    End If
                End If
            Next

            data.status = ServiceStatus.SUCCESS
            data.data = dataInfo.DataRow_ID
            data.message = "Success"
        Catch ex As Exception
            data.message = ex.Message
            data.status = ServiceStatus.FAILED
            flReg.BugLog(pid, ex.Message, "analy")
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function CaculatorData(pid As Int16, tp As Int16, gr As Integer, yr As Int16, row As Integer, col As Integer) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            Dim str As String = ""
            Dim arrCol, arrRow As ArrayList
            arrCol = objControler.CMS_CateTar_List_ByTarget(pid, col)
            arrRow = objControler.CMS_CateTar_List_ByTarget(pid, row)
            str += "<table class=""table-bordered respo-table"">"
            'col
            str += "<thead>"
            str += "<tr >"
            str += "<td style='background-color:#fff'></td>"

            For Each objC As CMS_CateTarInfo In arrCol
                str += "<td style='background-color:#dfdddd;text-align:center'>"
                str += objC.CateName
                str += "</td>"
            Next
            str += "</tr>"
            str += "</thead>"
            'row
            str += "<tbody>"

            For Each objR As CMS_CateTarInfo In arrRow
                str += "<tr>"
                str += "<td style='background-color: #ebeaea;'>"
                str += objR.CateName
                str += "</td>"
                For Each objC As CMS_CateTarInfo In arrCol
                    str += "<td style='text-align:right'>"
                    str += objControler.CMS_InDataRowC_Get_Data(pid, tp, yr, gr, col, row, objR.CodeCateTar, objC.CodeCateTar, 1).ToString()
                    str += "</td>"
                Next
                str += "</tr>"
            Next
            str += "<tr style='font-weight:600'>"
            str += "<td style='background-color: #ebeaea;'>Tổng cộng</td>"
            For Each objC As CMS_CateTarInfo In arrCol
                str += "<td style='text-align:right'>"
                str += "0"
                str += "</td>"
            Next
            str += "</tr>"
            str += "</tbody>"
            str += "</table>"
            data.data = str
        Catch ex As Exception
            data.data = ex.Message.ToString()
        End Try

        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function delColC(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_TempRptC_Delete(pid, id)
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function delCateTar(pid As String, id As String) As String
        Call flReg.SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Try
            objControler.CMS_CateTar_Delete(pid, id)
            data.data = "1"
        Catch ex As Exception
            data.data = ""
        End Try
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    Private Function readString(val As String) As Object
        If val = "undefined" Or val = "" Then
            Return Nothing
        Else
            Return val
        End If
    End Function
End Class

Public Module Moduler
    <Extension()>
    Public Sub ToHttpResponse(ByVal target As Response)
        Dim context As HttpContext = HttpContext.Current
        Dim settings = New JsonSerializerSettings() With {.ContractResolver = New CamelCasePropertyNamesContractResolver()}

        context.Response.ContentType = "text/json"
        context.Response.Charset = "UTF-8"
        context.Response.Write(JsonConvert.SerializeObject(target, settings))
    End Sub
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


