<%@ WebService Language="VB" Class="WebService" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports System.IO
Imports DotNetNuke.EPORTAL

<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
Public Class WebService
    Inherits System.Web.Services.WebService

    Dim dirinfo As DirectoryInfo
    Dim allFiles() As System.IO.FileInfo
    Dim folderRoot As String = "DesktopModules"
    Dim notFolder() As String = "app_localresources,images,scripts,css,resources,js".Split(",")

    Public Sub SetContentResponse()
        Context.Response.ContentType = "text/json"
        Context.Response.AddHeader("Content-Type", "text/json;charset=UTF-8")
        Context.Response.Charset = "UTF-8"
    End Sub
    Private Function CheckFolder(folder As String) As Boolean
        For i As Integer = 0 To notFolder.Length - 1
            If folder.ToLower() = notFolder(i).ToLower() Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function getPath(folder As String) As String
        getPath = folder.Substring(folder.IndexOf(folderRoot) + folderRoot.Length + 1)
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Childs(parent As String) As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim di As New DirectoryInfo(Server.MapPath("/" & folderRoot & "/" & parent.Replace("!", "/")))
        Dim chid As DirectoryInfo() = di.GetDirectories()
        data.Data = ""
        If chid.Length > 1 Then
            data.Data += "<ul class=""treeview-menu"">"
            For j As Integer = 0 To chid.Length - 1 Step 1
                Dim tchid As DirectoryInfo = chid(j)
                If CheckFolder(tchid.Name) = False Then
                    data.Data += "<li class='treeview'><a class='fl-a' href='javascript:;' onclick=""getchild(this)"" id='" & getPath(tchid.FullName.Replace("\", "!")) & "'>"
                    data.Data += "<img src='/desktopmodules/module/addmodule/sfld1.png'>&nbsp;" & tchid.Name & "</a></li>"
                End If
            Next
            data.Data += "</ul>"
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Folders() As String
        Call SetContentResponse()
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()

        Dim di As New DirectoryInfo(Server.MapPath("/" & folderRoot))
        Dim child1s As DirectoryInfo() = di.GetDirectories()
        data.Data = "<ul class=""sidebar-menu"">"
        For i As Integer = 0 To child1s.Length - 1 Step 1
            Dim tmpdi As DirectoryInfo = child1s(i)
            If CheckFolder(tmpdi.Name) = False Then
                data.Data += "<li class='treeview'><a class='fl-a' href='javascript:;' onclick=""getchild(this)"" id='" & getPath(tmpdi.FullName.Replace("\", "!")) & "'>"
                data.Data += "<img src='/desktopmodules/module/addmodule/sfld0.gif'>&nbsp;" & tmpdi.Name & "</a></li>"
            End If
        Next
        data.Data += "</ul>"
        Return JsonConvert.SerializeObject(data, settings)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function Browses(path As String) As String
        Dim data = New Response
        Dim settings = New JsonSerializerSettings()
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        dirinfo = New DirectoryInfo(Server.MapPath("/" & folderRoot & "/" & path.Replace("!", "/")))
        data.Data = ""
        If dirinfo.Exists Then
            allFiles = dirinfo.GetFiles()
            Array.Sort(allFiles, New clsCompareFileInfo)
            For i As Integer = 0 To allFiles.Length - 1
                Select Case flReg.GetFileType(allFiles(i).Name, ".").ToLower
                    Case "ascx"
                        data.Data += "<div class='col-md-6 div-bro'><img src='/image/ascx.png'>&nbsp;<a href='javascript:;' class='add-a' onclick='selectbrowse(this);' id='" & getPath(allFiles(i).FullName).Replace("\", "/") & "'>" & allFiles(i).Name & "</a></div>"
                End Select
            Next
        End If
        Return JsonConvert.SerializeObject(data, settings)
    End Function


End Class

Public Class Response
    Public Property Data As Object
End Class
