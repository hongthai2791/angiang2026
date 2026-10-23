<%@ WebHandler Language="VB" Class="Reports2" %>
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.CMS

Public Class Reports2 : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim litList, strLit As String, arrTemp, arrTemp1 As New ArrayList
    Dim int, intCount, intView As Integer, b As Boolean
    Dim FDate, TDate, portal, UserID, pban As String

    Private Function GetData(CategoryId As String) As String
        GetData = ""
        For Each Cr As CMS_NewsInfo In arrTemp
            If Cr.CategoryId = CategoryId Then
                GetData += "<tr style='vertical-align:middle;'>"
                GetData += "<td style='width:5%;text-align:center;font-weight: bold'>" & int & "</td>"
                GetData += "<td style='width:70%;'><a target='_bank' href='" & Ultis.FormatLink(Cr.PortalId, Cr.CategoryId, Cr.NewId, Cr.ToUrl) & "'>" & Cr.Title & "</a></td>"
                GetData += "<td style='width:10%;text-align:center;'>" & flReg.FormatNumber(Cr.ViewCount) & "</td>"
                GetData += "<td style='width:15%;text-align:right;'>" & flReg.ReadDate(Cr.PublishedDate) & "</td>"
                GetData += "</tr>"
                int += 1 : intCount += 1 : intView += Cr.ViewCount
            End If
        Next
    End Function
    Public Sub Reports(ByVal portal As Integer, pban As String, UserID As String, fromd As String, tod As String)
        arrTemp = ObjController.CMS_Reports_2(portal, portal, pban, UserID, Ultis.ValDate(fromd, True), Ultis.ValDate(tod, False))
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspacing='0' style='font-family: Times New Roman;'>"
        litList += "<tr class='hdTitle' style='text-align:center;color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%'>STT</td>"
        litList += "<td style='text-align:left;width:70%'>Tiêu đề tin/bài</td>"
        litList += "<td style='width:10%'>Lượt xem</td>"
        litList += "<td style='width:15%'>Ngày xuất bản</td>"
        litList += "</tr>"
        int = 1
        arrTemp1 = New ArrayList
        For Each Cr As CMS_NewsInfo In arrTemp
            If arrTemp1.Count = 0 Then
                arrTemp1.Add(Cr)
            Else
                b = False
                For Each Cr1 As CMS_NewsInfo In arrTemp1
                    If Cr.CategoryId = Cr1.CategoryId Then
                        b = True : Exit For
                    End If
                Next
                If b = False Then arrTemp1.Add(Cr)
            End If
        Next
        For Each Ci As CMS_NewsInfo In arrTemp1
            intView = 0 : intCount = 0 : strLit = GetData(Ci.CategoryId) 'Danh sach tin
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='font-weight:bold;color:black' colspan='2'>"
            If Ci.CategoryParentName & "" <> "" Then
                litList += "<span class='scmchinh'>" & Ci.CategoryParentName & "</span> / "
                litList += "<span class='scmphu'>" & Ci.CategoryName & "</span></td>"
            Else
                litList += "<span class='scmchinh'>" & Ci.CategoryName & "</span></td>"
            End If
            litList += "<td style='width:8%;text-align:center;font-weight:bold;color:black;font-size:14px'>" & flReg.FormatNumber(intView) & "</td>"
            litList += "<td style='width:12%;text-align:right;font-weight:bold;color:black;font-size:14px'>" & flReg.FormatNumber(intCount) & "</td>"
            litList += "</tr>"
            litList += strLit
        Next
        litList += "</table>"
    End Sub
    Public Function getNull(val As Object) As String
        If val = "null" Then
            Return ""
        Else
            Return val
        End If
    End Function
    Public Function NameExport() As String
        Return flReg.FormatNumber(Now.Day) & "_" & flReg.FormatNumber(Now.Month) & "_" & Now.Year
    End Function
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        FDate = context.Request.Item("fd") & ""
        TDate = context.Request.Item("td") & ""
        pban = getNull(context.Request.Item("pban")) & ""
        portal = flReg.WriteNumber(context.Request.Item("portal"))
        UserID = getNull(context.Request.Item("user")) & ""
        Call Reports(portal, pban, UserID, FDate, TDate)
        context.Response.Write(litList)

    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class