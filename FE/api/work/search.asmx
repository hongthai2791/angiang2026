<%@ WebService Language="VB" Class="WebserviceGolbal.search" %>
Imports System.Web.Services
Imports System.Web.Script.Services
Imports DotNetNuke.EPORTAL
Imports DotNetNuke.WORK

Namespace WebserviceGolbal
    <WebService(Namespace:="http://tempuri.org/")>
    <WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
    <ScriptService()>
    Public Class search
        Dim ObjController As New WorkController
        <WebMethod()>
        <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
        Public Function findBusiness(search As String, tp As String, qh As String) As ArrayList
            findBusiness = New ArrayList
            For Each Cr As CMS_BusinessInfo In ObjController.CMS_Business_List_Approval(flConnect.PortalId, search, flReg.RemoveScript(search), 1, 10, flReg.WriteNumber(tp), flReg.WriteNumber(qh), True)
                Cr.Business_ID = Cr.Business_ID
                Cr.Business_Vn = flReg.RemoveScript(Cr.Business_Vn, False)
                Cr.ContactUser = flReg.RemoveScript(Cr.ContactUser, False)
                Cr.ContactEmail = flReg.RemoveScript(Cr.ContactEmail, False)
                Cr.ContactMobile = flReg.RemoveScript(Cr.ContactMobile, False)
                Cr.TaxCode = flReg.RemoveScript(Cr.TaxCode, False)
                Cr.Address = flReg.RemoveScript(Cr.Address, False)
                findBusiness.Add(Cr)
            Next
        End Function

    End Class

End Namespace
