<%@ WebHandler Language="VB" Class="Reports1" %>
Imports DotNetNuke.CMS
Imports DotNetNuke.EPORTAL

Public Class Reports1 : Implements IHttpHandler
    Dim ObjController As New CmsController
    Dim litList, strLit As String, arrTemp, arrTemp1 As New ArrayList
    Dim int, intCount, intView As Integer, str() As String, b As Boolean
    Dim FDate, TDate, portal, top, flag As String

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
                int += 1 : intView += Cr.ViewCount : intCount += 1
            End If
        Next
    End Function
    Public Sub Reports(ByVal portal As Integer, top As String, fromd As String, tod As String, flag As String)
        If flag = "true" Then
            arrTemp = ObjController.CMS_Reports_1(portal, portal, flConnect.IsLang, top, Ultis.ValDate(fromd, True), Ultis.ValDate(tod, False), 1)
        Else
            arrTemp = ObjController.CMS_Reports_1(portal, portal, flConnect.IsLang, top, Ultis.ValDate(fromd, True), Ultis.ValDate(tod, False), 0)
        End If
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspaci='0' style='font-family: Times New Roman;'>"
        litList += "<tr class='hdTitle' style='text-align:center;color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;'>STT</td>"
        litList += "<td style='text-align:left;width:70%;'>Tiêu đề tin</td>"
        litList += "<td style='width:10%;'>Lượt xem</td>"
        litList += "<td style='width:15%;padding:0;'>Ngày xuất bản</td>"
        litList += "</tr>"
        int = 1
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
            intCount = 0 : intView = 0 : strLit = GetData(Ci.CategoryId) 'Danh sach tin
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='font-weight:bold;color:black' colspan='2'>"
            If Ci.CategoryParentName & "" <> "" Then
                litList += "<span class='scmchinh'>" & Ci.CategoryParentName & "</span> / "
                litList += "<span class='scmphu'>" & Ci.CategoryName & "</span></td>"
            Else
                litList += "<span class='scmchinh'>" & Ci.CategoryName & "</span></td>"
            End If
            litList += "<td style='width:10%;text-align:center;font-weight:bold;color:black;font-size:14px'>" & flReg.FormatNumber(intView) & "</td>"
            litList += "<td style='width:15%;text-align:right;font-weight:bold;color:black;font-size:14px'>" & flReg.FormatNumber(intCount) & "</td>"
            litList += "</tr>"
            litList += strLit
        Next
        litList += "</table>"
    End Sub
    Public Function NameExport() As String
        Return flReg.FormatNumber(Now.Day) & "_" & flReg.FormatNumber(Now.Month) & "_" & Now.Year
    End Function

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        FDate = context.Request.Item("fd") & ""
        TDate = context.Request.Item("td") & ""
        portal = flReg.WriteNumber(context.Request.Item("portal") & "")
        top = flReg.WriteNumber(context.Request.Item("top") & "")
        flag = context.Request.Item("flag") & ""
        Call Reports(portal, top, FDate, TDate, flag)
        context.Response.Write(litList)

    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class