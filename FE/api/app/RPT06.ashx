<%@ WebHandler Language="VB" Class="RPT06" %>
Imports DotNetNuke.APP
Imports DotNetNuke.EPORTAL

Public Class RPT06 : Implements IHttpHandler
    Dim ObjController As New AppController
    Dim litList As String, arrTemp As New ArrayList
    Dim FDate, TDate, top, flag As String
    Dim int As Integer

    Public Sub Reports(portal As Integer, tinhTP As Integer, top As Integer, fromd As String, tod As String, flag As String)
        If flag = "true" Then
            arrTemp = ObjController.RPT_Reports_06(portal, flReg.WriteNumber(tinhTP), top, CMS.Ultis.ValDate(fromd, True), CMS.Ultis.ValDate(tod, False), 1)
        Else
            arrTemp = ObjController.RPT_Reports_06(portal, flReg.WriteNumber(tinhTP), top, CMS.Ultis.ValDate(fromd, True), CMS.Ultis.ValDate(tod, False), 0)
        End If
        litList = "<table border='1' class=""pro-ctable"" width='100%' cellspaci='0' style='font-family: Times New Roman;'>"
        litList += "<tr class='hdTitle' style='text-align:center;color:#fff;font-weight: bold;vertical-align:middle;'>"
        litList += "<td style='width:5%;'>STT</td>"
        litList += "<td style='text-align:left;width:35%;'>Tin tuyển dụng</td>"
        litList += "<td style='text-align:left;width:40%;'>Đơn vị tuyển dụng</td>"
        litList += "<td style='width:10%;'>Lượt xem</td>"
        litList += "<td style='width:10%;'>Ngày đăng tin</td>"
        litList += "</tr>"
        int = 1
        For Each Cr As CMS_WorksInfo In arrTemp
            litList += "<tr style='vertical-align:middle;'>"
            litList += "<td style='width:5%;text-align:center;'>" & int & "</td>"
            litList += "<td style='width:35%;'><p>" & Cr.Title & "</p>"
            litList += "Khu vực: " & flDic.RegionalName(portal, Cr.TinhTP, Cr.QuanHuyen) & "</td>"

            litList += "<td style='width:40%;'><p>" & flCheck.Business_Name(portal, Cr.Business_ID) & "</p>"
            litList += "<div class='col-xs-7 pdl0'>Mức lương: " & WORK.flCheck.Salary_Name(portal, Cr.Salary_ID) & "</div>"
            litList += "<div class='col-xs-5 pdl0'>Mã tin: <span style='color:red'>" & APP.flCheck.ReadCode(Cr.ID) & "</div></td>"

            litList += "<td style='width:10%;text-align:center;'>" & flReg.FormatNumber(Cr.IsView) & "</td>"
            litList += "<td style='width:10%;text-align:center;'>" & flReg.ReadDate(Cr.StartDate, False) & "</td>"
            litList += "</tr>"
            int += 1
        Next
        litList += "</table>"
    End Sub
    Public Function NameExport() As String
        Return flReg.FormatNumber(Now.Day) & "_" & flReg.FormatNumber(Now.Month) & "_" & Now.Year
    End Function

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        FDate = context.Request.Item("fd") & ""
        TDate = context.Request.Item("td") & ""
        top = flReg.WriteNumber(context.Request.Item("top") & "")
        flag = context.Request.Item("flag") & ""
        Call Reports(0, flReg.WriteNumber(context.Request.Item("tp")), top, FDate, TDate, flag)
        context.Response.Write(litList)
    End Sub
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class