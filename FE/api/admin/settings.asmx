<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

<ScriptService>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService
    Private result As New Response With {.Status = ServiceStatus.NODATA, .Data = Nothing, .Message = String.Empty}
    Dim objControler As New CmsController
    Dim data As New Response
    Dim settings As New JsonSerializerSettings()

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function HomeBlock(pid As Integer, id As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        Dim obj As CMS_BlockInfo = objControler.CMS_Block_Get_By_Key(pid, id)
        If IsNothing(obj) = False Then
            data.Data = "<img src=""" & obj.Block_Img & "?w=500""  alt=""" & obj.Block_Name & """ />"
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function mahoa(p As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = flReg.Encrypt("1", p)
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function giaima(p As String) As String
        p = flReg.DeCode64(p)
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = flReg.DeCode64(flReg.Decrypt("1", p))
        Return JsonConvert.SerializeObject(data, settings)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function PageLocal(pid As Integer, id As String) As String
        Call flReg.SetContentResponse()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        data.Data = ""
        Dim obj As CMS_PageLocalInfo = objControler.CMS_PageLocal_Get(pid, id)
        If IsNothing(obj) = False Then
            data.Data = "<img src=""" & obj.ImagePath & "?w=500""  alt=""" & obj.PageLocal_Name & """ />"
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
End Class
