Imports DotNetNuke.Common
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Web.UI.WebControls
Imports System.IO
Imports Microsoft.ApplicationBlocks.Data
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Web
Imports System.Web.UI.HtmlControls
Imports System.Security.Cryptography
Imports DotNetNuke.UI.Utilities
Imports System.Threading
Imports DotNetNuke.Entities.Users
Imports DotNetNuke.Entities.Portals
Imports QRCodeEncoderDecoderLibrary
Imports System.Drawing
Imports Spire.Barcode
Imports System.Drawing.Drawing2D
Imports Microsoft.Security.Application
Public Class flReg

	Shared str(), strUrl As String
	Shared strOld As String
	Shared arrTemp As New ArrayList
	Public Shared Function FormatCount(count As String, Optional ByVal tooltip As String = "Số lượng bản ghi") As String
		Return "<span class='label label-warning label-count' title='" + tooltip + "'>" + count + "</span>"
	End Function
	Public Shared Function FormatGenCode(code As String, Optional ByVal tooltip As String = "Mã bản ghi") As String
		Return "<span class='label label-info' title='" + tooltip + "'>#" + code + "</span>"
	End Function
	Public Shared Function getCheck(val As String, index As String, Optional ByVal isContain As Boolean = False) As String
		Try
			If isContain Then
				If val.ToString.Contains(index.ToString) Then
					Return "[ x ]"
				Else
					Return "[   ]"
				End If
			Else
				If val.Equals(index) Then
					Return "[ x ]"
				Else
					Return "[   ]"
				End If
			End If

		Catch ex As Exception
			Return "[   ]"
		End Try
	End Function
	Public Shared Function ClearEmptyText(valStr As String) As String
		If String.IsNullOrEmpty(valStr) = False Then
			Return valStr.Replace("- - - Chọn - - -", "").Replace("--- Chọn ---", "").Replace("|--", "").Replace("- - Chọn tỉnh/ TP - -", "").Replace("- - Quận/Huyện - -", "").Replace("- - Xã/Phường - -", "")
		Else
			Return ""
		End If

	End Function
	Public Shared Function ClearEmptyDropList(valStr As DropDownList) As String
		If valStr.SelectedItem IsNot Nothing Then
			Return valStr.SelectedItem.Text.Replace("- - - Chọn - - -", "").Replace("--- Chọn ---", "").Replace("|--", "").Replace("- - Chọn tỉnh/ TP - -", "").Replace("- - Quận/Huyện - -", "").Replace("- - Xã/Phường - -", "")
		Else
			Return ""
		End If

	End Function
	Public Shared Function GenerateIframeDownloadHtmlCode(sFileUrl As String, Optional sFilename As String = "") As String
		Dim sResult As String = ""
		If sFilename = "" Then
			sFilename = System.IO.Path.GetFileName(sFileUrl)
		End If
		sResult = String.Format("<iframe src='/sp/download.aspx?fn={0}&fu={1}'></iframe>", HttpUtility.UrlEncode(flReg.EnCode64(sFilename)), HttpUtility.UrlEncode(flReg.EnCode64(sFileUrl)))
		Return sResult
	End Function
	Public Shared Function GetRadioValueBoolean(rd1 As RadioButton, rd2 As RadioButton) As Boolean
		GetRadioValueBoolean = False
		Try
			If rd1.Checked Then
				GetRadioValueBoolean = True
				Exit Function
			End If
			If rd2.Checked Then
				GetRadioValueBoolean = False
				Exit Function
			End If
		Catch ex As Exception
			GetRadioValueBoolean = False
		End Try
	End Function
	Public Shared Function GetRadioValue(rd1 As RadioButton, rd2 As RadioButton) As Integer
		GetRadioValue = 0
		Try
			If rd1.Checked Then
				GetRadioValue = 1
				Exit Function
			End If
			If rd2.Checked Then
				GetRadioValue = 2
				Exit Function
			End If
		Catch ex As Exception
			GetRadioValue = 0
		End Try
	End Function
	Public Shared Sub SetRadioValue(rd1 As RadioButton, rd2 As RadioButton, val As String)
		rd1.Checked = False
		rd2.Checked = False
		Try
			If val = 1 Then
				rd1.Checked = True
				Exit Sub
			End If
			If val = 2 Then
				rd2.Checked = True
				Exit Sub
			End If
		Catch ex As Exception
			rd1.Checked = False
			rd2.Checked = False
		End Try
	End Sub
	Public Shared Function GetRadio3Value(rd1 As RadioButton, rd2 As RadioButton, rd3 As RadioButton) As Integer
		GetRadio3Value = 0
		Try
			If rd1.Checked Then
				GetRadio3Value = 1
				Exit Function
			End If
			If rd2.Checked Then
				GetRadio3Value = 2
				Exit Function
			End If
			If rd3.Checked Then
				GetRadio3Value = 3
				Exit Function
			End If
		Catch ex As Exception
			GetRadio3Value = 0
		End Try
	End Function
	Public Shared Sub SetRadio3Value(rd1 As RadioButton, rd2 As RadioButton, rd3 As RadioButton, val As String)
		rd1.Checked = False
		rd2.Checked = False
		rd3.Checked = False
		Try
			If val = 1 Then
				rd1.Checked = True
				Exit Sub
			End If
			If val = 2 Then
				rd2.Checked = True
				Exit Sub
			End If
			If val = 3 Then
				rd3.Checked = True
				Exit Sub
			End If
		Catch ex As Exception
			rd1.Checked = False
			rd2.Checked = False
			rd3.Checked = False
		End Try
	End Sub
	Public Shared Sub SetRadioValueBoolean(rd1 As RadioButton, rd2 As RadioButton, val As Boolean)
		rd1.Checked = False
		rd2.Checked = False
		Try
			If val Then
				rd1.Checked = True
				Exit Sub
			End If
			If val <> True Then
				rd2.Checked = True
				Exit Sub
			End If
		Catch ex As Exception
			rd1.Checked = False
			rd2.Checked = False
		End Try
	End Sub
	Public Shared Function GetCheckListValue(rd1 As CheckBoxList) As String
		GetCheckListValue = ""
		Try
			For i = 0 To rd1.Items.Count - 1
				If rd1.Items(i).Selected Then
					GetCheckListValue += rd1.Items(i).Value & ","
				End If
			Next
		Catch ex As Exception
			GetCheckListValue = ""
		End Try
	End Function
	Public Shared Sub SetCheckListValue(rd1 As CheckBoxList, val As String)
		rd1.ClearSelection()
		Try
			Dim str() As String
			Dim rdS As ListItem = Nothing
			If String.IsNullOrEmpty(val) = False Then
				str = val.Split(",")
				For i = 0 To str.Count - 1
					If String.IsNullOrEmpty(str(i)) = False Then
						rdS = rd1.Items.FindByValue(str(i))
						If IsNothing(rdS) = False Then
							rd1.Items.FindByValue(str(i)).Selected = True
						End If
					End If
				Next
			End If
		Catch ex As Exception
			rd1.ClearSelection()
		End Try
	End Sub
	Public Shared Function toPage(val As Integer, Optional ByVal recode As Integer = 100) As Integer
		If val < recode Then
			Return 1
		ElseIf (CType(val / recode, Integer) * recode) < val Then
			Return CType(val / recode, Integer) + 1
		Else
			Return CType(val / recode, Integer)
		End If
	End Function
	Public Shared Function NumberRandom(min As Integer, max As Integer) As String
		Dim generator As Random = New Random()
		Return generator.Next(min, max)
	End Function

	Public Shared Function getStringNullHtml(Val As String) As String
		If Val = "null" Or Val = "undefined" Then
			Return ""
		Else
			Try
				Return Sanitizer.GetSafeHtmlFragment(Val).Trim()
			Catch ex As Exception
				Return Val
			End Try
		End If
	End Function

	Public Shared Function MapPath(path As String) As String
		Dim di1 As New IO.DirectoryInfo(Web.HttpContext.Current.Server.MapPath(path))
		If Not di1.Exists Then di1.Create()
		Return path
	End Function
	Public Shared Sub SaveFileName(FilePath As String, ByVal FileName As String, Optional ByVal cotype As String = "application/octet-stream")
		HttpContext.Current.Response.ContentType = "application/octet-stream"
		HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" & FileName)
		HttpContext.Current.Response.WriteFile(FilePath)
		HttpContext.Current.Response.End()
	End Sub
	Public Shared Sub SetContentResponse()
		HttpContext.Current.Response.ContentType = "text/html"
		HttpContext.Current.Response.AddHeader("Content-Type", "text/html;charset=UTF-8")
		HttpContext.Current.Response.Charset = "UTF-8"
	End Sub

	Public Shared Function AESEncrypt(ByVal plainText As Object, ByVal key As String, ByVal iv As String) As String
		'key sẽ có 32 ký tự,vi sẽ là 16
		Dim sKey = Encoding.ASCII.GetBytes(key)
		Dim sIV = Encoding.ASCII.GetBytes(iv)
		Dim encrypted As Byte()

		Using aes = New AesManaged()
			aes.KeySize = 256
			aes.Mode = CipherMode.CBC
			Dim encryptor = aes.CreateEncryptor(sKey, sIV)
			Dim sms = New MemoryStream()
			Dim scs = New CryptoStream(sms, encryptor, CryptoStreamMode.Write)
			Using sw = New StreamWriter(scs)
				sw.Write(plainText)
			End Using
			encrypted = sms.ToArray()
		End Using

		Return Convert.ToBase64String(encrypted)
	End Function

	Public Shared Function AESDecrypt(ByVal cipherText As Object, ByVal key As String, ByVal iv As String) As String
		Try
			Dim plaintext As String = Nothing

			Using aes = New AesManaged()
				aes.KeySize = 256
				aes.Mode = CipherMode.CBC
				Dim decryptor = aes.CreateDecryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(iv))
				Dim ms = New MemoryStream(Convert.FromBase64String(cipherText))
				Dim cs = New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
				Dim reader = New StreamReader(cs)
				plaintext = reader.ReadToEnd()
			End Using

			Return plaintext
		Catch
			Return Nothing
		End Try
	End Function

	Public Shared Function AESEncrypt(ByVal plainText As Object) As String
		'key sẽ có 32 ký tự,vi sẽ là 16
		Dim key = "@#!@#@!#!@#!@#!@DAVFASWEWQEQWF@@", iv = "@EPTAJASDa@2024@"
		Dim sKey = Encoding.ASCII.GetBytes(key)
		Dim sIV = Encoding.ASCII.GetBytes(iv)
		Dim encrypted As Byte()

		Using aes = New AesManaged()
			aes.KeySize = 256
			aes.Mode = CipherMode.CBC
			Dim encryptor = aes.CreateEncryptor(sKey, sIV)
			Dim sms = New MemoryStream()
			Dim scs = New CryptoStream(sms, encryptor, CryptoStreamMode.Write)
			Using sw = New StreamWriter(scs)
				sw.Write(plainText)
			End Using
			encrypted = sms.ToArray()
		End Using

		Return Convert.ToBase64String(encrypted)
	End Function

	Public Shared Function AESDecrypt(ByVal cipherText As Object) As String
		Try
			Dim plaintext As String = Nothing
			Dim key = "@#!@#@!#!@#!@#!@DAVFASWEWQEQWF@@", iv = "@EPTAJASDa@2024@"

			Using aes = New AesManaged()
				aes.KeySize = 256
				aes.Mode = CipherMode.CBC
				Dim decryptor = aes.CreateDecryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(iv))
				Dim ms = New MemoryStream(Convert.FromBase64String(cipherText))
				Dim cs = New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
				Dim reader = New StreamReader(cs)
				plaintext = reader.ReadToEnd()
			End Using

			Return plaintext
		Catch
			Return Nothing
		End Try
	End Function

	Public Shared Function RptDate(dates As String, f As Boolean) As DateTime
		If f = True Then
			If dates <> "" Then
				str = dates.Split("-")
				Return New DateTime(str(2), str(1), str(0), 0, 0, 0)
			Else
				Return New DateTime(Now.AddDays(-30).Year, Now.AddDays(-30).Month, Now.AddDays(-30).Day, 0, 0, 0)
			End If
		Else
			If dates <> "" Then
				str = dates.Split("-")
				Return New DateTime(str(2), str(1), str(0), 23, 59, 59)
			Else
				Return New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 59)
			End If
		End If
	End Function
	Public Shared Function SettingValue(PortalConnect As String, SubMod As String, setting_Key As String, setting_Page As String) As String
		SettingValue = flCache.GetCache(setting_Key & "_" & SubMod & "_" & setting_Page) & ""
		If SettingValue = "" Then
			Dim obj As CMS_SettingsInfo = flDnn.CMS_Settings_Get_Value(PortalConnect, SubMod, setting_Key, setting_Page)
			If IsNothing(obj) = False Then
				SettingValue = obj.Setting_Value
				flCache.SetCache(setting_Key & "_" & SubMod & "_" & setting_Page, SettingValue)
			End If
		End If
	End Function
	Public Shared Sub LoadRoles(drGroup As DropDownList, tabName As String, Optional ByVal text As String = "- - - Chọn - - -")
		drGroup.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_Roles_Get_By_CMS_SubMod_" & flDic.SubMod_ID(0, tabName))) Then
			arrTemp = flDnn.CMS_Roles_Get_By_CMS_SubMod(0, flDic.SubMod_ID(0, tabName))
			flCache.SetCache("CMS_Roles_Get_By_CMS_SubMod_" & flDic.SubMod_ID(0, tabName), arrTemp)
		Else
			arrTemp = CType(flCache.GetCache("CMS_Roles_Get_By_CMS_SubMod_" & flDic.SubMod_ID(0, tabName)), ArrayList)
		End If
		drGroup.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_RolesInfo In arrTemp
			drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Roles_Name, False), Ci.Roles_ID))
		Next
	End Sub
	Public Shared Function FileID(FileName As String, IsSuperUser As Boolean, PortalId As Integer) As String
		FileName = FileName.Substring(FileName.LastIndexOf("/") + 1)
		If IsSuperUser = True Then
			arrTemp = flDnn.DNN_Files_Get_By_FileName(-1, FileName)
		Else
			arrTemp = flDnn.DNN_Files_Get_By_FileName(PortalId, FileName)
		End If
		For Each Cr As DnnInfo In arrTemp
			Return Cr.FileID
		Next
		Return ""
	End Function
	Public Shared Sub LoadTabName(drTabID As DropDownList, IsCMS As Boolean, Optional ByVal text As String = "- - - Chọn - - -")
		drTabID.Items.Clear()
		drTabID.Items.Add(New ListItem(text, ""))
		arrTemp = flDnn.DNN_PortalID_Get_Parent_IsNull(flConnect.PortalId, IsCMS)
		For Each Cr As DnnInfo In arrTemp
			drTabID.Items.Add(New ListItem(Cr.TabName & " > " & Cr.Description, Cr.TabName))
			strOld = ""
			Call LoadTabIDs(drTabID, Cr.Tabid, "")
		Next
	End Sub
	Private Shared Sub LoadTabName(drTabID As DropDownList, intTabId As String, strO As String)
		For Each Cr As DnnInfo In flDnn.DNN_PortalID_Get_By_ParentID(intTabId)
			If strO = "" Then strO = "|--- "
			drTabID.Items.Add(New ListItem(strO & Cr.TabName & " > " & Cr.Description, Cr.TabName))
			strOld = strO & "--"
			Call LoadTabIDs(drTabID, Cr.Tabid, strOld)
		Next
	End Sub
	Public Shared Sub LoadTabID(drTabID As DropDownList, IsCMS As Boolean, Optional ByVal text As String = "- - - Chọn - - -")
		drTabID.Items.Clear()
		drTabID.Items.Add(New ListItem(text, ""))
		arrTemp = flDnn.DNN_PortalID_Get_Parent_IsNull(flConnect.PortalId, IsCMS)
		For Each Cr As DnnInfo In arrTemp
			drTabID.Items.Add(New ListItem(Cr.TabName & " > " & Cr.Description, Cr.Tabid))
			strOld = ""
			Call LoadTabID(drTabID, Cr.Tabid, "")
		Next
	End Sub
	Private Shared Sub LoadTabIDs(drTabID As DropDownList, intTabId As String, strO As String)
		For Each Cr As DnnInfo In flDnn.DNN_PortalID_Get_By_ParentID(intTabId)
			If strO = "" Then strO = "|--- "
			drTabID.Items.Add(New ListItem(strO & Cr.TabName & " > " & Cr.Description, Cr.Tabid))
			strOld = strO & "--"
			Call LoadTabIDs(drTabID, Cr.Tabid, strOld)
		Next
	End Sub
	Public Shared Function NextPage(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, hrefPage As String) As String
		NextPage = ""
		If recodperPage < intTotal Then
			NextPage = flDnn.DNN_NextPage(intTotal, currPage, recodperPage, Pagesize, hrefPage)
			If NextPage <> "" Then
				NextPage = "<div class=""ex_page"">" & NextPage & "<div class=""clr""></div></div>"
			End If
		End If
	End Function
	Public Shared Function NextPageJs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
		NextPageJs = ""
		If recodperPage < intTotal Then
			NextPageJs = flDnn.DNN_NextPageJs(intTotal, currPage, recodperPage, Pagesize, functions)
			If NextPageJs <> "" Then
				NextPageJs = "<div class=""ex_page"">" & NextPageJs & "<div class=""clr""></div></div>"
			End If
		End If
	End Function
	Public Shared Function NextPageVs(intTotal As Integer, recodperPage As Integer, currPage As Integer, Pagesize As Integer, functions As String) As String
		NextPageVs = ""
		If recodperPage < intTotal Then
			NextPageVs = flDnn.DNN_NextPageVs(intTotal, currPage, recodperPage, Pagesize, functions)
			If NextPageVs <> "" Then
				NextPageVs = "<div class=""ex_page"">" & NextPageVs & "<div class=""clr""></div></div>"
			End If
		End If
	End Function
	Private Shared Function Parent_Name(PortalConnect As String, subMod As String, Parent_ID As String) As String
		Dim obj As CMS_ModuleInfo = flDnn.CMS_Module_Get_Parent_ID(PortalConnect, subMod, Parent_ID)
		If IsNothing(obj) = False Then Return "<span class='span-title'>" & obj.ModuleName & "</span>: "
		Return ""
	End Function
	Public Shared Function ModuleName(PortalConnect As String, subMod As String, ModuleSrc As String) As String
		Dim obj As CMS_ModuleInfo = flDnn.CMS_Module_Get(PortalConnect, subMod, flReg.Encrypt("1", ModuleSrc))
		If IsNothing(obj) = False Then Return Parent_Name(PortalConnect, obj.SubMod, obj.Parent_ID) & obj.ModuleName
		Return ""
	End Function
	Public Shared Function ActiveMenu(subMod As String, ctlMenu As String) As String
		Dim obj As New CMS_ModuleInfo
		obj = flDnn.CMS_Module_Get(flConnect.DmConnect, subMod, flReg.Encrypt("1", ctlMenu))
		If IsNothing(obj) = False Then
			If obj.Parent_ID <> "" Then
				obj = flDnn.CMS_Module_Get_Parent_ID(flConnect.DmConnect, obj.SubMod, obj.Parent_ID)
				If IsNothing(obj) = False Then
					ctlMenu = flReg.Decrypt("1", obj.ModuleSrc)
				End If
			End If
		End If
		Return ctlMenu
	End Function
	Public Shared Function GetUserName(UserName As String, Optional ByVal Pid As Integer = 0) As String
		GetUserName = flCache.GetCache("GetUserName_" & UserName) & ""
		If GetUserName = "" Then
			arrTemp = flDnn.DNN_User_Get(Pid, UserName)
			If arrTemp.Count > 0 Then
				GetUserName = arrTemp.Item(0).FullName
				flCache.SetCache("GetUserName_" & UserName, GetUserName)
			Else
				Return UserName
			End If
		End If
	End Function
    Public Shared Function UserName(UserID As String) As String
        arrTemp = flDnn.DNN_User_Get_By_ID(flConnect.PortalId, UserID)
        For Each Cr As DnnInfo In arrTemp
            Return Cr.FullName
        Next
        Return ""
    End Function
    Public Shared Function UserDelete(pid As Integer, UserName As String) As Boolean
        strOld = flCache.GetCache("UserDelete" & UserName & pid) & ""
        If strOld = "" Then
            UserDelete = flDnn.DNN_User_Check_Delete(pid, UserName)
            flCache.SetCache("UserDelete" & UserName & pid, UserDelete)
            Return UserDelete
        End If
        Return flReg.ToBoolean(strOld)
    End Function
    Public Shared Function EncodeUserName(UserName As String) As String
		Return UserName & "@v" & DateTime.Now.Day & "b" & DateTime.Now.Month
	End Function
	Public Shared Function DecodeUserName(UserName As String) As String
		Return UserName
	End Function
    Public Shared Function ImgAlt(alt As String) As String
        alt = System.Web.HttpUtility.HtmlDecode(alt.Trim)
        Dim arr1 As String() = New String() {".", ":", """", "`", "!", "'", "@", "#", "$", "%", "^", "&",
                                             "*", "(", ")", "|", "{", "}", "?", "<", ">", "/", "\", "  ", "~"}
        For i As Integer = 0 To arr1.Length - 1
            alt = alt.Replace(arr1(i), " ")
            alt = alt.Replace(" ", " ")
        Next
        Return alt.Trim
    End Function
    Public Shared Function JValue(alt As String) As String
        If alt = "" Then Return ""
        alt = System.Web.HttpUtility.HtmlDecode(alt.Trim)
        Dim arr1 As String() = New String() {"""", "'", "  "}
        For i As Integer = 0 To arr1.Length - 1
            alt = alt.Replace(arr1(i), " ")
            alt = alt.Replace(" ", " ")
        Next
        Return alt.Trim
    End Function
    Public Shared Function ImgType(Type As String) As Boolean
		str = New String() {"jpg", "jpeg", "jpe", "jpe", "gif", "png",
										   "bmp", "png", "svg", "ico", "ttf"}
		For i As Integer = 0 To str.Length - 1
			If Type = str(i) Then Return True
		Next
		Return False
	End Function
	Public Shared Function TrimAttch(filesName As String, Optional ByVal length As Integer = 25) As String
		If filesName.Length <= length Then
			Return filesName
		Else
			Return flReg.Trimstr(flReg.GetFileName(filesName, "."), length) & "..." & flReg.GetFileType(filesName, ".")
		End If
	End Function
	Public Shared Function fileExten(fileType As String) As String()
		Return fileType.Split(",")
	End Function
	Public Shared Function ImagesName(imgName As String) As String
		imgName = ToEnglish(imgName).Trim
		imgName = ToEnglishs(imgName).Trim
		imgName = System.Web.HttpUtility.HtmlDecode(imgName.Trim)
		Dim arr1 As String() = New String() {".", ":", """", "`", "!", "'",
											 "@", "#", "$", "%", "^", "&",
											 "*", "(", ")", "|", "{", "}",
											 "?", "<", ">", "/", "\", "  ", "~"}
		For i As Integer = 0 To arr1.Length - 1
			imgName = imgName.Replace(arr1(i), " ")
			imgName = imgName.Replace(" ", " ")
		Next
		Return imgName.Trim
	End Function

	Public Shared Function ImgSRCNoCompress(path As String, Optional ByVal width As Integer = 0, Optional ByVal height As Integer = 0, Optional ByVal gif As Boolean = False, Optional ByVal noimage As String = "noimage.png", Optional ByVal _fileDomain As String = "default") As String
		If _fileDomain = "default" Then _fileDomain = flConnect.fileDomain
		If path = "" Then
			Return _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg"

		End If
		ImgSRCNoCompress = "" : strUrl = ""
		If GetFileType(path, ".") = "gif" And gif = True Then
			ImgSRCNoCompress = """"

			Return _fileDomain & path & ImgSRCNoCompress & " onError=""this.src='" & _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg" & strUrl & "';"
		Else
			Return _fileDomain & path & ImgSRCNoCompress & """ onError=""this.src='" & _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg" & ImgSRCNoCompress & " ';"

		End If
	End Function
	Public Shared Function ImgSRC(path As String, Optional ByVal width As Integer = 0, Optional ByVal height As Integer = 0, Optional ByVal gif As Boolean = False, Optional ByVal noimage As String = "noimage.png", Optional ByVal _fileDomain As String = "default", Optional ByVal version As String = "1.1") As String
		Dim vrsionStr As String = "v=" & version
		If _fileDomain = "default" Then _fileDomain = flConnect.fileDomain
		If path = "" Then
			ImgSRC = ""
			If width > 0 Then
				ImgSRC = "&w=" & width
				If height > 0 Then ImgSRC += "&h=" & height
			Else
				If height > 0 Then ImgSRC = "&h=" & height
			End If
			Return _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg?" & vrsionStr & ImgSRC
		End If
		ImgSRC = "" : strUrl = ""
		If GetFileType(path, ".") = "gif" And gif = True Then
			ImgSRC = """"
			If width > 0 Then
				strUrl = "&w=" & width
				ImgSRC = """ width='" & width & "px' "
				If height > 0 Then
					ImgSRC += " height='" & height & "px' "
					strUrl += "&h=" & height
				End If
			Else
				If height > 0 Then
					strUrl = "&h=" & height
					ImgSRC = """ height='" & height & "px' "
				End If
			End If
			Return _fileDomain & path & ImgSRC & " onError=""this.src='" & _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg?" & vrsionStr & strUrl & "';"
		Else
			If width > 0 Then
				ImgSRC = "?" & vrsionStr & "&w=" & width
				If height > 0 Then ImgSRC += "&h=" & height
			Else
				If height > 0 Then ImgSRC = "?" & vrsionStr & "&h=" & height
			End If
			If ImgSRC = "" Then ImgSRC = "?" & vrsionStr
			Return _fileDomain & path & ImgSRC & """ onError=""this.src='" & _fileDomain & "/image/noimage/" & flReg.NumberRandom(1, 10) & ".jpg" & ImgSRC & " ';"
		End If
	End Function
	Public Shared Function ToEnglishs(strName As String) As String
		Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\p{IsCombiningDiacriticalMarks}+")
		ToEnglishs = System.Text.RegularExpressions.Regex.Replace(strName, "[^\w\.-]", " ")
		ToEnglishs = ToEnglishs.Normalize(System.Text.NormalizationForm.FormD)
	End Function
	Public Shared Function ToEnglish(text As String) As String
		text = System.Web.HttpUtility.HtmlDecode(text).ToLower.Trim
		Dim arr1 As String() = New String() {"á", "à", "ả", "ã", "ạ", "â",
			"ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ",
			"é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í",
			"ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ",
			"ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ",
			"ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ",
			"ỵ"}
		Dim arr2 As String() = New String() {"a", "a", "a", "a", "a", "a",
			 "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d",
			 "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i",
			 "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o",
			 "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u",
			 "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y",
			 "y"}
		For i As Integer = 0 To arr1.Length - 1
			text = text.Replace(arr1(i), arr2(i))
		Next
		arr1 = New String() {"é", "ẹ", "ẻ", "è", "ẽ", "ị", "í", "ì", "ĩ", "ị",
							 "ý", "ỵ", "ỳ", "ỹ", "ỷ", "ả", "à", "á", "ạ", "ã",
							 "ò", "ọ", "ó", "ỏ", "õ", "ụ", "ù", "ủ", "ú", "ũ"}
		arr2 = New String() {"e", "e", "e", "e", "e", "i", "i", "i", "i", "i",
							 "y", "y", "y", "y", "y", "a", "a", "a", "a", "a",
							 "o", "o", "o", "o", "o", "u", "u", "u", "u", "u"}
		For i As Integer = 0 To arr1.Length - 1
			text = text.Replace(arr1(i), arr2(i))
		Next
		Return text.Trim
	End Function
	Public Shared Function Trimstr(s As String, length As Integer, Optional isDot As Boolean = True) As String
		If s & "" = "" Then
			Return s
		Else
			If s.Length > length Then
				Dim words As String() = s.Split(New String() {" "c}, StringSplitOptions.RemoveEmptyEntries)
				If words(0).Length > length Then
					Return s
				End If
				Dim sb = New StringBuilder()
				For Each word In words
					If (Convert.ToString(sb) & word).Length > length Then
						If isDot Then
							Return String.Format("{0}...", sb.ToString().TrimEnd(" "c))
						Else
							Return String.Format("{0}", sb.ToString().TrimEnd(" "c))
						End If
					End If
					sb.Append(word & " ")
				Next
				If isDot Then
					Return String.Format("{0}...", sb.ToString().TrimEnd(" "c))
				Else
					Return String.Format("{0}", sb.ToString().TrimEnd(" "c))
				End If
			Else
				Return s
			End If
		End If
	End Function
	Public Shared Function RemoveScript(text As String, Optional ByVal input As Boolean = True) As String
		Return flReg.getStringNullHtml(text)
		'If IsNothing(text) = True Then Return ""
		'If input = True Then
		'	Return System.Web.HttpUtility.HtmlEncode(text.Trim)
		'Else
		'	Return System.Web.HttpUtility.HtmlDecode(text.Trim)
		'End If
	End Function
	Public Shared Function RemoveHTML(strHTML As String) As String
		If strHTML & "" <> "" Then
			strHTML = HttpUtility.HtmlDecode(strHTML)
			Return Regex.Replace(strHTML, "<(.|\n)*?>", "")
		End If
		Return ""
	End Function
	Public Shared Sub RemoveParent(dr As DropDownList, idkey As String)
		For i As Integer = 0 To dr.Items.Count - 1
			If dr.Items(i).Value = idkey Then
				dr.Items(i).Enabled = False
				Exit Sub
			End If
		Next
	End Sub
	Public Shared Function GenKey() As String
		Return Guid.NewGuid.ToString()
	End Function
	Public Shared Function GetFileName(str As String, Optional ByVal strchar As String = "\") As String
		Return str.Substring(0, str.LastIndexOf(strchar)).Trim
	End Function
	Public Shared Function GetFileType(str As String, Optional ByVal strchar As String = "\") As String
		Dim t As Integer = 0
		t = InStrRev(str.Trim, strchar, , 1)
		If t = 0 Then
			GetFileType = ""
		Else
			GetFileType = Mid(str.Trim, t + 1, Len(str.Trim) - t)
		End If
	End Function
	Public Shared Function SaveImage(fimage As String) As String
		SaveImage = GetFileName(fimage, ".")
		SaveImage = ToEnglish(SaveImage.Trim)
		For i As Integer = 0 To SaveImage.Length - 1
			SaveImage = SaveImage.Replace("  ", " ")
		Next
		SaveImage = SaveImage.Replace(" ", "-")
		SaveImage = SaveImage.Replace(".", "-")
		SaveImage = SaveImage.Replace("_", "-")
		SaveImage = GenKey() & "-" & SaveImage
		Return SaveImage.ToLower
	End Function
	Public Shared Function NameUrl(strName As String) As String
		NameUrl = strName.Replace(": ", " ").Trim
		NameUrl = RemoveScript(NameUrl).Trim
		NameUrl = ToEnglish(NameUrl).Trim
		NameUrl = ToEnglishs(NameUrl).Trim
		NameUrl = NameUrl.Replace(" ", "-")
		NameUrl = NameUrl.Replace(".", "-")
		NameUrl = NameUrl.Replace(",", "")
		For i As Integer = 0 To 5
			NameUrl = NameUrl.Replace("--", "-")
		Next
		Return NameUrl.ToLower
	End Function
	Public Shared Function HightLightSearch(strName As String) As String
		HightLightSearch = strName.Replace(": ", " ").Trim
		HightLightSearch = RemoveScript(HightLightSearch).Trim
		HightLightSearch = HightLightSearch.Replace(" ", "-")
		HightLightSearch = HightLightSearch.Replace(",", "")
		For i As Integer = 0 To HightLightSearch.Length - 1
			HightLightSearch = HightLightSearch.Replace("--", "-")
		Next
		Return HightLightSearch
	End Function
	Public Shared Function NameTags(strName As String) As String
		NameTags = RemoveScript(strName, " ").Trim
		NameTags = ToEnglish(NameTags).Trim
		NameTags = NameTags.Replace(" ", "-")
		For i As Integer = 0 To NameTags.Length - 1
			NameTags = NameTags.Replace("--", "-")
			NameTags = NameTags.Replace(",-", ",")
		Next
		Return NameTags
	End Function 'Return NameTags
	Public Shared Function NamePages(strName As String) As String
		NamePages = ToEnglishs(strName).Trim
		NamePages = ToEnglish(NamePages).Trim
		For i As Integer = 0 To NamePages.Length
			NamePages = NamePages.Replace("_", "")
			NamePages = NamePages.Replace(" ", "")
		Next
		NamePages = NamePages.Trim.ToLower
	End Function
	Public Shared Sub DeleteAllFiles(Optional ByVal PathDelete As String = "\Portals\0\Temp")
		Try
			Dim Dire() As DirectoryInfo
			Dim file() As FileInfo
			Dim dir As New DirectoryInfo(HttpContext.Current.Server.MapPath(PathDelete))
			Dire = dir.GetDirectories()
			file = dir.GetFiles()
			If Dire.Length > 0 Then
				For i As Integer = 0 To Dire.Length - 1
					Dire(i).Delete(True)
				Next
			End If
			If file.Length > 0 Then
				For i As Integer = 0 To file.Length - 1
					file(i).Delete()
				Next
			End If
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub
	Public Shared Function getRolesND(pid As Integer, UserName As String, tabName As String) As String
		getRolesND = ""
		Dim obj As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", UserName, tabName, pid)
		If IsNothing(obj) = False Then
			getRolesND = obj.RolesID.Replace(",", ";")
			flCache.SetCache("VaiTroNguoiDung_" & tabName & "_" & UserName, getRolesND)
		End If
	End Function
	Public Shared Function RolesND(pid As Integer, UserName As String, tabName As String) As String
		If UserName = "host" Or UserName = "admin" Then Return -1
		RolesND = flCache.GetCache("VaiTroNguoiDung_" & tabName & "_" & UserName) & ""
		If RolesND = "" Then
			RolesND = getRolesND(pid, UserName, tabName) & ""
			flCache.SetCache("VaiTroNguoiDung_" & tabName & "_" & UserName, RolesND)
		End If
		If RolesND = "" Then RolesND = getRolesND(pid, UserName, tabName)
	End Function
	Public Shared Function GetRolesID(tabName As String, roleCode As String) As Integer
        GetRolesID = flReg.WriteNumber(flCache.GetCache("1GetRolesID_" & tabName & "_" & roleCode) & "")
        If GetRolesID = 0 Then
			Dim obj As CMS_RolesInfo = flDnn.CMS_Roles_Get_By_SubMod_Code(flConnect.PortalId, flDic.SubMod_ID(flConnect.PortalId, tabName), roleCode)
			If IsNothing(obj) = False Then
                flCache.SetCache("1GetRolesID_" & tabName & "_" & roleCode, obj.Roles_ID)
                Return obj.Roles_ID
			End If
		End If
	End Function
	Public Shared Function RolesCode(ID As Integer) As String
		RolesCode = flCache.GetCache("RolesCode_" & ID) & ""
		If RolesCode = "" Then
			Dim obj As CMS_RolesInfo = flDnn.CMS_Roles_Get(flConnect.PortalId, ID)
			If IsNothing(obj) = False Then
				flCache.SetCache("RolesCode_" & ID, obj.Roles_Code)
				Return obj.Roles_Code
			End If
		End If
	End Function
	Public Shared Function IsInRole(pid As Integer, tabName As String, code As String) As Boolean
		If UserInfo.Username = "host" Or UserInfo.Username = "admin" Then Return True
		IsInRole = False
		If IsNothing(flCache.GetCache("IsInRole_" & UserInfo.Username & "_" & tabName & "_" & code)) Then
			strOld = RolesND(pid, UserInfo.Username, tabName)
			If strOld.Contains(";") Then
				str = strOld.Split(";")
			Else
				str = strOld.Split(",")
			End If
			For i As Integer = 0 To str.Length - 1
				If RolesCode(flReg.WriteNumber(str(i))) = code Then
					flCache.SetCache("IsInRole_" & UserInfo.Username & "_" & tabName & "_" & code, True)
					Return True
				End If
			Next
		Else
			Return ToBoolean(flCache.GetCache("IsInRole_" & UserInfo.Username & "_" & tabName & "_" & code))
		End If
	End Function
	Public Shared Function IsInRole(pid As Integer, _userName As String, tabName As String, roleCode As String) As Boolean
		If _userName = "host" Or _userName = "admin" Then Return True
		IsInRole = False
		If IsNothing(flCache.GetCache("IsInRole_" & _userName & "_" & tabName & "_" & roleCode)) Then
			str = RolesND(pid, _userName, tabName).Split(",")
			For i As Integer = 0 To str.Length - 1
				If RolesCode(flReg.WriteNumber(str(i))) = roleCode Then
					flCache.SetCache("IsInRole_" & _userName & "_" & tabName & "_" & roleCode, True)
					Return True
				End If
			Next
		Else
			Return ToBoolean(flCache.GetCache("IsInRole_" & _userName & "_" & tabName & "_" & roleCode))
		End If
	End Function
	Public Shared Function WriteNumber(number As String, Optional ByVal round As Boolean = False) As Double
		Try
			Double.TryParse(number, WriteNumber)
			If round = True Then WriteNumber = Math.Round(WriteNumber, 0)
		Catch ex As Exception
			Return 0
		End Try
	End Function
	Public Shared Function WriteStringLess(number As String) As Double
		Try
			If number = "" Or IsNumeric(number) = False Then
				WriteStringLess = -1
			Else
				WriteStringLess = number
			End If
		Catch ex As Exception
			WriteStringLess = -1
		End Try
	End Function
	Public Shared Function DobuleNull(Field As Object) As Object
		If flReg.WriteNumber(Field) < 0 Then
			Return DBNull.Value
		Else
			Return flReg.WriteNumber(Field)
		End If
	End Function
	Public Shared Function WriteString(number As String) As String
		If flReg.WriteNumber(number) = 0 Then
			Return ""
		Else
			Return number
		End If
	End Function
	Public Shared Function ReadString(number As String) As String
		If flReg.WriteNumber(number) < 0 Then
			Return ""
		Else
			Return number
		End If
	End Function
	Public Shared Function ToBoolean(number As String) As Boolean
		If WriteNumber(number) = 1 Then
			Return True
		Else
			Boolean.TryParse(number, ToBoolean)
		End If
	End Function
	Public Shared Function WritePrice(number As String) As Double
		Try
			If number & "" = "" Then
				WritePrice = 0
			Else
				number = number.Replace(".", "")
				number = number.Replace(",", ".")
				WritePrice = number
			End If
		Catch ex As Exception
			WritePrice = 0
		End Try
	End Function
	Public Shared Function FormatNumber(number As Double) As String
		Try
			If number <> 0 Then
				FormatNumber = String.Format("{0:0,0}", number)
			Else
				FormatNumber = "0"
			End If
		Catch ex As Exception
			FormatNumber = ""
		End Try
	End Function
	Public Shared Function ToNumber(number As Integer) As String
		If number > 0 Then
			Return number
		Else
			Return ""
		End If
	End Function
	Public Shared Function ReadNumber(number As Integer) As String
		If number < 10 Then
			ReadNumber = "0" & number
		Else
			ReadNumber = number
		End If
	End Function
	Public Shared Function CodeNumber(number As Integer) As String
		If number < 1000 Then
			CodeNumber = "0" & number
		ElseIf number < 100 Then
			CodeNumber = "00" & number
		ElseIf number < 10 Then
			CodeNumber = "000" & number
		Else
			CodeNumber = "0000" & number
		End If
	End Function
	Public Shared Function FormatPrice(isPrice As String, Optional ByVal vNull As Boolean = True) As String
		FormatPrice = ""
		If WriteNumber(isPrice) > 0 Then
			FormatPrice = String.Format("{0:0,0}", WriteNumber(isPrice))
			FormatPrice = FormatPrice.Replace(".", "_")
			FormatPrice = FormatPrice.Replace(",", ".")
			FormatPrice = FormatPrice.Replace("_", ",")
		End If
		If vNull = True And FormatPrice = "" Then FormatPrice = 0
	End Function
	Public Shared Function FormatMoney(isPrice As String, Optional ByVal vDefault As Boolean = True) As String
		FormatMoney = ""
		If WriteNumber(isPrice) > 0 Then
			FormatMoney = String.Format("{0:0,0}", WriteNumber(isPrice))
		End If
		If vDefault = True And FormatMoney = "" Then FormatMoney = "0"
	End Function
	Public Shared Function FormatPriceForAjax(isPrice As String) As String
		FormatPriceForAjax = ""
		If WriteNumber(isPrice) > 0 Then
			FormatPriceForAjax = String.Format("{0:0,0}", WriteNumber(isPrice))
			FormatPriceForAjax = FormatPriceForAjax.Replace(",000", "")
		End If
		If FormatPriceForAjax = "" Then FormatPriceForAjax = 0
	End Function
	Public Shared Function FormatDienTich(dienTich As String) As String
		FormatDienTich = ""
		If WriteNumber(dienTich) > 0 Then
			FormatDienTich = dienTich.Replace(",", "_")
			FormatDienTich = FormatDienTich.Replace(".", ",")
			FormatDienTich = FormatDienTich.Replace("_", ".")
		End If
	End Function
	Public Shared Function SetNullText(txt As String) As String
		If String.IsNullOrEmpty(txt) Then
			txt = "Đang cập nhật"
		End If
		Return txt
	End Function
    Public Shared Function RelativeTime(ByVal myDate As DateTime) As String
        If myDate.Year < 1900 Then
            RelativeTime = ""
            Exit Function
        End If
        Const SECOND As Integer = 1
        Const MINUTE As Integer = 60 * SECOND
        Const HOUR As Integer = 60 * MINUTE
        Const DAY As Integer = 24 * HOUR
        Const MONTH As Integer = 30 * DAY
        Dim ts = New TimeSpan(DateTime.Now.Ticks - myDate.Ticks)
        Dim delta As Double = Math.Abs(ts.TotalSeconds)
        If delta < 1 * MINUTE Then Return If(ts.Seconds = 1, "1 giây trước", ts.Seconds & " giây trước")
        If delta < 2 * MINUTE Then Return "1 phút trước"
        If delta < 45 * MINUTE Then Return ts.Minutes & " phút trước"
        If delta < 90 * MINUTE Then Return "1 giờ trước"
        If delta < 24 * HOUR Then Return ts.Hours & " giờ trước"
        If delta < 48 * HOUR Then Return "1 ngày trước"
        If delta < 30 * DAY Then Return ts.Days & " ngày trước"
        If delta < 12 * MONTH Then
            Dim months As Integer = Convert.ToInt32(Math.Floor(CDbl(ts.Days) / 30))
            Return If(months <= 1, "1 tháng trước", months & " tháng trước")
        Else
            Dim years As Integer = Convert.ToInt32(Math.Floor(CDbl(ts.Days) / 365))
            Return If(years <= 1, "1 năm trước", years & " năm trước")
        End If
    End Function
    Public Shared Function getStar(toStar As Integer, nowStar As Integer) As String
        getStar = flCache.GetCache("getStar_" & toStar & "_" & nowStar) & ""
        If getStar = "" Then
            For i = 1 To toStar
                If i < nowStar Then
                    getStar += "<i class='fa fa-star has-text-warning'></i>"
                Else
                    getStar += "<i class='fa fa-star-o has-text-warning'></i>"
                End If
            Next
            flCache.SetCache("getStar_" & toStar & "_" & nowStar, getStar)
        End If
    End Function
	Public Shared Function subPortal(PortalConnect As String, subMode As String) As Integer
		If IsNothing(flCache.GetCache("subPortal_" & subMode)) Then
			Dim obj As CMS_SubModInfo = flDnn.CMS_SubMod_Get_By_Path(PortalConnect, subMode)
			If IsNothing(obj) = False Then
				subPortal = obj.SubMod_PID
				flCache.SetCache("subPortal_" & subMode, subPortal)
			Else
				Return 0
			End If
		Else
			Return flReg.WriteNumber(flCache.GetCache("subPortal_" & subMode))
		End If
	End Function
	Public Shared Function SubMod_ID(PortalConnect As String, subMode As String) As Integer
		If IsNothing(flCache.GetCache("SubMod_ID_" & subMode)) Then
			Dim obj As CMS_SubModInfo = flDnn.CMS_SubMod_Get_By_Path(PortalConnect, subMode)
			If IsNothing(obj) = False Then
				SubMod_ID = obj.SubMod_ID
				flCache.SetCache("SubMod_ID_" & subMode, SubMod_ID)
			Else
				Return 0
			End If
		Else
			Return flReg.WriteNumber(flCache.GetCache("SubMod_ID_" & subMode))
		End If
	End Function
	Public Shared Sub AddCss(Page As System.Web.UI.Page, Href As String)
		Dim adCss As HtmlLink = New HtmlLink()
		adCss.Attributes.Add("rel", "stylesheet")
		adCss.Attributes.Add("type", "text/css")
		adCss.Href = Href
		Page.Header.Controls.Add(adCss)
	End Sub
	Public Shared ReadOnly Property BasePage(Page As System.Web.UI.Page) As DotNetNuke.Framework.CDefault
		Get
			Return DirectCast((Page), DotNetNuke.Framework.CDefault)
		End Get
	End Property
	Public Shared Sub LoadBasePage(Page As System.Web.UI.Page, Title As String, KeyWords As String, Description As String, ByVal datePublished As DateTime, url As String, image As String)

		Dim tag As New HtmlMeta()

		BasePage(Page).Title = Title
		BasePage(Page).Description = Description
		BasePage(Page).KeyWords = KeyWords

		'Meta google
		tag = New HtmlMeta()
		tag.Attributes.Add("name", "description")
		tag.Content = Description
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("itemprop", "name")
		tag.Content = Title
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("itemprop", "description")
		tag.Content = Description
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("itemprop", "image")
		tag.Content = image
		Page.Header.Controls.Add(tag)
		'----------------End meta google

		'Meta facebook ----------------
		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:url")
		tag.Content = url
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:type")
		tag.Content = "article"
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:title")
		tag.Content = Title
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:description")
		tag.Content = Description
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:image")
		tag.Content = image
		Page.Header.Controls.Add(tag)
		'----------------End Meta facebook

		'Meta Zalo

		tag = New HtmlMeta()
		tag.Attributes.Add("property", "og:image")
		tag.Attributes.Add("itemprop", "image")
		tag.Content = image
		Page.Header.Controls.Add(tag)

		tag = New HtmlMeta()
		tag.Attributes.Add("name", "description")
		tag.Content = Description
		Page.Header.Controls.Add(tag)

	End Sub
	Public Shared Function GetMoneyWord(money As String) As String
		GetMoneyWord = ""
		Dim Dt = CType(SqlHelper.ExecuteDataset(flConnect.DmConnect, CommandType.Text, "Select dbo.fn_GetWord(" & money & ")"), DataSet).Tables(0)
		For Each Cr As DataRow In Dt.Rows
			GetMoneyWord = Cr.Item(0) & ""
		Next
	End Function
	Public Shared Function UrlAlias() As String
		Return System.Configuration.ConfigurationManager.AppSettings("UrlAlias") & GetPortalSettings.PortalAlias.HTTPAlias
	End Function
	Public Shared Function GetNull(Field As Object) As Object
		Try
			If IsNothing(Field) = True Then
				Return DBNull.Value
			Else
				If Field.ToString() = "1/1/1900 12:00:00 AM" Or Field.ToString() = "1/1/0001 12:00:00 AM" Then
					Return DBNull.Value
				Else
					Return Utilities.Null.GetNull(Field, DBNull.Value)
				End If
			End If
		Catch ex As Exception
			Return DBNull.Value
		End Try
	End Function
	Public Shared Function GetNulls(Field As Object) As Object
		If Field & "" = "" Then
			Return DBNull.Value
		Else
			Return Field
		End If
	End Function
	Public Shared Function WriteDate(ngay As String, thang As String, nam As String, Optional ByVal gio As String = "0", Optional ByVal phut As String = "0") As Date
		Try
			Return New Date(flReg.WriteNumber(nam), flReg.WriteNumber(thang), flReg.WriteNumber(ngay), gio, phut, 0)
		Catch ex As Exception
			Return New Date(1900, 1, 1)
		End Try
	End Function
	Public Shared Function WriteDate(dates As String, Optional ByVal time As Boolean = True, Optional ByVal yyMMdd As Boolean = False) As Date
		Try
			If dates & "" <> "" Then
				dates = ((dates.Replace(" ", "/")).Replace(":", "/")).Replace("-", "/")
				str = dates.Split("/")
				If yyMMdd = False Then
					If time = True Then
						If flReg.WriteNumber(str(1)) > 12 Then
							Return New Date(str(2), str(0), str(1), str(3), str(4), 0)
						Else
							Return New Date(str(2), str(1), str(0), str(3), str(4), 0)
						End If
					Else 'Ghi ngày không
						If flReg.WriteNumber(str(1)) > 12 Then
							Return New Date(str(2), str(0), str(1))
						Else
							Return New Date(str(2), str(1), str(0))
						End If
					End If
				Else
					Return New Date(str(0), str(1), str(2))
				End If
			Else
				Return New Date(1900, 1, 1)
			End If
		Catch ex As Exception
			Return New Date(1900, 1, 1)
		End Try
	End Function
	Public Shared Function DateNull(dates As DateTime) As Object
		If Year(dates) = 1900 Then
			Return DBNull.Value
		Else
			Return dates
		End If
	End Function
	Public Shared Function DateNull() As DateTime
		Return New Date(1900, 1, 1)
	End Function
	Public Shared Function ReadDate(dates As DateTime, Optional ByVal time As Boolean = True, Optional ByVal mmHHdd As Boolean = False) As String
		If dates.Year > 1 And dates.Year <> 1900 Then
			If time = True Then
				If mmHHdd = False Then
					ReadDate = dates.ToString("dd/MM/yyyy HH:mm").Replace(" 00:00", "")
				Else
					ReadDate = dates.ToString("HH:mm dd/MM/yyyy").Replace("00:00 ", "")
				End If
			Else
				ReadDate = dates.ToString("dd/MM/yyyy")
			End If
		Else
			Return ""
		End If
	End Function
	Public Shared Function ReadDates(dates As DateTime, Optional ByVal time As Boolean = True) As String
		If dates.Year > 1 And dates.Year <> 1900 Then
			If time = True Then
				ReadDates = dates.ToString("HH:mm dd/MM").Replace(" 00:00", "")
			Else
				ReadDates = dates.ToString("dd/MM")
			End If
		Else
			Return ""
		End If
	End Function
	Public Shared Function SetDate(dates As DateTime) As DateTime
		If dates.Year > 1 And dates.Year <> 1900 Then
			Return dates
		Else
			Return New Date(1900, 1, 1)
		End If
	End Function
	Public Shared Function Security(code As String) As Boolean
		If code = "@v" & DateTime.Now.Day & "b" & DateTime.Now.Month Then
			Return True
		End If
		Return False
	End Function
	Public Shared Function Token() As String
		Token = ""
		For i As Integer = 0 To 5
			Token += New Random().Next(1, 100).ToString()
		Next
		Token = Encrypt("BTV", Token) & ":" & Encrypt("T", GenKey() & "-" & GenKey())
		Token = Token.Replace("=", "")
		Token = Token.Replace("+", "_")
		Token = Token.Replace("/", "_")
		Token = Token.Replace("__", "_")
	End Function
	Public Shared Function Encrypt(strKey As String, ByVal strData As String) As String
		If (strKey = "") Then Return strData
		Dim num As Integer = Strings.Len(strKey)
		If (num < &H10) Then
			strKey = (strKey & Strings.Left("XXXXXXXXXXXXXXXX", (&H10 - Strings.Len(strKey))))
		ElseIf (num > &H10) Then
			strKey = Strings.Left(strKey, &H10)
		End If
		Dim bytes As Byte() = Encoding.UTF8.GetBytes(Strings.Left(strKey, 8))
		Dim rgbIV As Byte() = Encoding.UTF8.GetBytes(Strings.Right(strKey, 8))
		Dim buffer As Byte() = Encoding.UTF8.GetBytes(strData)
		Dim provider As New DESCryptoServiceProvider
		Dim stream2 As New MemoryStream
		Dim stream As New CryptoStream(stream2, provider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write)
		stream.Write(buffer, 0, buffer.Length)
		stream.FlushFinalBlock()
		Return Convert.ToBase64String(stream2.ToArray)
	End Function
	Public Shared Function Decrypt(strKey As String, ByVal strData As String) As String
		If (strData = "") Then Return ""
		Dim str2 As String = ""
		If (strKey = "") Then Return strData
		Dim num As Integer = Strings.Len(strKey)
		If (num < &H10) Then
			strKey = (strKey & Strings.Left("XXXXXXXXXXXXXXXX", (&H10 - Strings.Len(strKey))))
		ElseIf (num > &H10) Then
			strKey = Strings.Left(strKey, &H10)
		End If
		Dim bytes As Byte() = Encoding.UTF8.GetBytes(Strings.Left(strKey, 8))
		Dim rgbIV As Byte() = Encoding.UTF8.GetBytes(Strings.Right(strKey, 8))
		Dim buffer As Byte() = New Byte((strData.Length + 1) - 1) {}
		Try
			buffer = Convert.FromBase64String(strData)
		Catch exception1 As Exception
			ProjectData.SetProjectError(exception1)
			str2 = strData
			ProjectData.ClearProjectError()
		End Try
		If (str2 = "") Then
			Try
				Dim provider As New DESCryptoServiceProvider
				Dim stream2 As New MemoryStream
				Dim stream As New CryptoStream(stream2, provider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write)
				stream.Write(buffer, 0, buffer.Length)
				stream.FlushFinalBlock()
				str2 = Encoding.UTF8.GetString(stream2.ToArray)
			Catch exception2 As Exception
				ProjectData.SetProjectError(exception2)
				str2 = ""
				ProjectData.ClearProjectError()
			End Try
		End If
		Return str2
	End Function
	Public Shared Function EnCode64(values As String) As String
		If values.Trim & "" = "" Then Return ""
		Return Convert.ToBase64String(Encoding.UTF8.GetBytes(values))
	End Function
	Public Shared Function DeCode64(values As String) As String
		If values.Trim & "" = "" Then Return ""
		values = Encoding.UTF8.GetString(Convert.FromBase64String(values))
		Return values
	End Function
	Public Shared Function PhotoURLFile(username As String, Optional ByVal PortalID As Integer = 0) As String
		PhotoURLFile = flCache.GetCache("PhotoURLFile_" & username & "_" & PortalID) & ""
		If PhotoURLFile = "" Then
			Dim uinfo As UserInfo = UserController.GetUserByName(PortalID, username)
			If IsNothing(uinfo) = False Then
				PhotoURLFile = uinfo.Profile.PhotoURL
				If PhotoURLFile <> "/images/no_avatar.gif" Then
					PhotoURLFile = PhotoURLFile.Substring(0, PhotoURLFile.LastIndexOf("?")).ToLower()
					flCache.SetCache("PhotoURLFile_" & username & "_" & PortalID, PhotoURLFile)
					Return PhotoURLFile
				Else
					Return "/image/images/noimage.png"
				End If
			Else
				Return "/image/images/noimage.png"
			End If
		End If
	End Function
	Public Shared Function DecodeSearch(ToUrl As String) As String
		If ToUrl.Trim & "" <> "" Then
			Dim arr1 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
										 "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
										 "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
										 "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

			Dim arr2 As String() = New String() {".", ":", """", "`", "!", "'",
										 "@", "#", "$", "^", "&", "*",
										 "(", ")", "|", "{", "}", "?", "+",
										 "~", "<", ">", "/", "\", "_"}

			For i As Integer = 0 To arr1.Length - 1
				ToUrl = ToUrl.Replace(arr1(i), arr2(i))
			Next
			Return ToUrl.Replace("-", " ")
		Else
			Return ""
		End If
	End Function
	Public Shared Function notiDecode(ToUrl As String) As String
		ToUrl = RemoveHTML(ToUrl).Replace("""", "")
		ToUrl = ToUrl.Replace("`", "").Replace("&", " ")
        ToUrl = ToUrl.Replace("/", "-").Replace("\", "-")
        ToUrl = ToUrl.Replace("(", "").Replace(")", "")
        Return ToUrl.Trim()
    End Function
	Public Shared Function RequestSearch(ToUrl As String, Optional ByVal html As String = ".html") As String
		If ToUrl.Contains("/s/") Then
			str = ToUrl.Substring(ToUrl.LastIndexOf("/s/") + 3).Split("/")
			Dim arr1 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
										 "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
										 "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
										 "-1D", "-3D", "-4D", "-5D", "-6D", "-2D"}

			Dim arr2 As String() = New String() {".", ":", """", "`", "!", "'",
										 "@", "#", "$", "^", "&", "*",
										 "(", ")", "|", "{", "}", "?", "+",
										 "~", "<", ">", "/", "\", "_"}

			ToUrl = str(0)
			For i As Integer = 0 To arr1.Length - 1
				ToUrl = ToUrl.Replace(arr1(i), arr2(i))
			Next
			Return ToUrl.Replace("-", " ")
		Else
			Return ""
		End If
	End Function
	Public Shared Function EncodeSearch(txtkey As String) As String
		txtkey = txtkey.Trim
		Dim arr1 As String() = New String() {".", ":", """", "`", "!", "'",
									 "@", "#", "$", "^", "&", "*",
									 "(", ")", "|", "{", "}", "?", "+",
									 "~", " ", "<", ">", "/", "\", "_"}
		Dim arr2 As String() = New String() {"-1A", "-2A", "-3A", "-4A", "-5A", "-6A",
									 "-1B", "-2B", "-3B", "-4B", "-5B", "-6B",
									 "-1C", "-2C", "-3C", "-4C", "-5C", "-6C", "-7C",
									 "-1D", "-", "-3D", "-4D", "-5D", "-6D", "-2D"}

		For i As Integer = 0 To arr1.Length - 1
			txtkey = txtkey.Replace(arr1(i), arr2(i))
		Next
		Return txtkey
	End Function
	Public Shared Sub GetHour(dr As DropDownList)
		dr.Items.Clear()
		For i As Integer = 0 To 23
			dr.Items.Add(New ListItem(i, i))
		Next
	End Sub
	Public Shared Sub GetDay(dr As DropDownList, Optional ByVal text As String = "")
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For i As Integer = 1 To 31
			dr.Items.Add(New ListItem(i, i))
		Next
	End Sub
	Public Shared Sub GetMonth(dr As DropDownList, Optional ByVal text As String = "")
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For i As Integer = 1 To 12
			dr.Items.Add(New ListItem(i, i))
		Next
	End Sub
	Public Shared Sub GetYear(dr As DropDownList, Optional ByVal text As String = "", Optional ByVal fYear As Integer = 2010, Optional ByVal tYear As Integer = 5)
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For i As Integer = fYear To Now.Year + tYear
			dr.Items.Add(New ListItem(i, i))
		Next
	End Sub
	Public Shared Sub GetMinute(dr As DropDownList)
		dr.Items.Clear()
		dr.Items.Add(New ListItem(0, 0))
		dr.Items.Add(New ListItem(1, 1))
		For i As Integer = 5 To 55
			dr.Items.Add(New ListItem(i, i))
			i += 4
		Next
		dr.Items.Add(New ListItem(59, 59))

	End Sub
	Public Shared Function WebConfig(keySetting As String) As String
		Return System.Configuration.ConfigurationManager.AppSettings(keySetting)
	End Function
	Public Shared Function ABC(column As Integer) As String
		Select Case column
			Case 0
				Return "A"
			Case 1
				Return "B"
			Case 2
				Return "C"
			Case 3
				Return "D"
			Case 4
				Return "E"
			Case 5
				Return "F"
			Case 6
				Return "G"
			Case 7
				Return "H"
			Case 8
				Return "I"
			Case 9
				Return "J"
			Case 10
				Return "K"
			Case 11
				Return "L"
			Case 12
				Return "M"
			Case 13
				Return "N"
			Case 14
				Return "O"
			Case 15
				Return "P"
			Case 16
				Return "Q"
			Case 17
				Return "R"
			Case 18
				Return "S"
			Case 19
				Return "T"
			Case 20
				Return "U"
			Case 21
				Return "V"
			Case 22
				Return "W"
			Case 23
				Return "X"
			Case 24
				Return "Y"
			Case 25
				Return "Z"
			Case 26
				Return "AA"
			Case 27
				Return "AB"
			Case 28
				Return "AC"
			Case 29
				Return "AD"
			Case 30
				Return "AE"
			Case 31
				Return "AF"
			Case 32
				Return "AG"
			Case 33
				Return "AH"
			Case 34
				Return "AI"
			Case 35
				Return "AJ"
			Case 36
				Return "AK"
			Case 37
				Return "AL"
			Case 38
				Return "AM"
			Case 39
				Return "AN"
			Case 40
				Return "AO"
			Case 41
				Return "AP"
			Case 42
				Return "AQ"
			Case 43
				Return "AR"
			Case 44
				Return "AS"
			Case 45
				Return "AT"
			Case 46
				Return "AU"
			Case 47
				Return "AV"
			Case 48
				Return "AW"
			Case 49
				Return "AX"
			Case 50
				Return "AY"
			Case 51
				Return "AZ"
			Case 52
				Return "BA"
			Case 53
				Return "BB"
			Case 54
				Return "BC"
			Case 55
				Return "BD"
			Case 56
				Return "BE"
			Case 57
				Return "BF"
			Case 58
				Return "BG"
			Case 59
				Return "BH"
			Case 60
				Return "BI"
			Case 61
				Return "BJ"
			Case 62
				Return "BK"
			Case 63
				Return "BL"
			Case 64
				Return "BM"
			Case 65
				Return "BN"
			Case 66
				Return "BO"
			Case 67
				Return "BP"
			Case 68
				Return "BQ"
			Case 69
				Return "BR"
			Case 70
				Return "BS"
			Case 71
				Return "BT"
			Case 72
				Return "BU"
			Case 73
				Return "BV"
			Case 74
				Return "BW"
			Case 75
				Return "BX"
			Case 76
				Return "BY"
			Case 77
				Return "BZ"
			Case 78
				Return "CA"
			Case 79
				Return "CB"
			Case 80
				Return "CC"
			Case 81
				Return "CD"
			Case 82
				Return "CE"
			Case 83
				Return "CF"
			Case 84
				Return "CG"
			Case 85
				Return "CH"
			Case 86
				Return "CI"
			Case 87
				Return "CJ"
			Case 88
				Return "CK"
			Case 89
				Return "CL"
			Case 90
				Return "CM"
			Case 91
				Return "CN"
			Case 92
				Return "CO"
			Case 93
				Return "CP"
			Case 94
				Return "CQ"
			Case 95
				Return "CR"
			Case 96
				Return "CS"
			Case 97
				Return "CT"
			Case 98
				Return "CU"
			Case 99
				Return "CV"
			Case Else
				Return "CW"
		End Select
	End Function
	Public Shared Function getABC(column As String) As Integer
		Select Case column
			Case "A"
				Return 0
			Case "B"
				Return 1
			Case "C"
				Return 2
			Case "D"
				Return 3
			Case "E"
				Return 4
			Case "F"
				Return 5
			Case "G"
				Return 6
			Case "H"
				Return 7
			Case "I"
				Return 8
			Case "J"
				Return 9
			Case "K"
				Return 10
			Case "L"
				Return 11
			Case "M"
				Return 12
			Case "N"
				Return 13
			Case "O"
				Return 14
			Case "P"
				Return 15
			Case "Q"
				Return 16
			Case "R"
				Return 17
			Case "S"
				Return 18
			Case "T"
				Return 19
			Case "U"
				Return 20
			Case "V"
				Return 21
			Case "W"
				Return 22
			Case "X"
				Return 23
			Case "Y"
				Return 24
			Case "Z"
				Return 25
			Case "AA"
				Return 26
			Case "AB"
				Return 27
			Case "AC"
				Return 28
			Case "AD"
				Return 29
			Case "AE"
				Return 30
			Case "AF"
				Return 31
			Case "AG"
				Return 32
			Case "AH"
				Return 33
			Case "AI"
				Return 34
			Case "AJ"
				Return 35
			Case "AK"
				Return 36
			Case "AL"
				Return 37
			Case "AM"
				Return 38
			Case "AN"
				Return 39
			Case "AO"
				Return 40
			Case "AP"
				Return 41
			Case "AQ"
				Return 42
			Case "AR"
				Return 43
			Case "AS"
				Return 44
			Case "AT"
				Return 45
			Case "AU"
				Return 46
			Case "AV"
				Return 47
			Case "AW"
				Return 48
			Case "AX"
				Return 49
			Case "AY"
				Return 50
			Case "AZ"
				Return 51
			Case "BA"
				Return 52
			Case "BB"
				Return 53
			Case "BC"
				Return 54
			Case "BD"
				Return 55
			Case "BE"
				Return 56
			Case "BF"
				Return 57
			Case "BG"
				Return 58
			Case "BH"
				Return 59
			Case "BI"
				Return 60
			Case "BJ"
				Return 61
			Case "BK"
				Return 62
			Case "BL"
				Return 63
			Case "BM"
				Return 64
			Case "BN"
				Return 65
			Case "BO"
				Return 66
			Case "BP"
				Return 67
			Case "BQ"
				Return 68
			Case "BR"
				Return 69
			Case "BS"
				Return 70
			Case "BT"
				Return 71
			Case "BU"
				Return 72
			Case "BV"
				Return 73
			Case "BW"
				Return 74
			Case "BX"
				Return 75
			Case "BY"
				Return 76
			Case "BZ"
				Return 77
			Case "CA"
				Return 78
			Case "CB"
				Return 79
			Case "CC"
				Return 80
			Case "CD"
				Return 81
			Case "CE"
				Return 82
			Case "CF"
				Return 83
			Case "CG"
				Return 84
			Case "CH"
				Return 85
			Case "CI"
				Return 86
			Case "CJ"
				Return 87
			Case "CK"
				Return 88
			Case "CL"
				Return 89
			Case "CM"
				Return 90
			Case "CN"
				Return 91
			Case "CO"
				Return 92
			Case "CP"
				Return 93
			Case "CQ"
				Return 94
			Case "CR"
				Return 95
			Case "CS"
				Return 96
			Case "CT"
				Return 97
			Case "CU"
				Return 98
			Case "CV"
				Return 99
			Case Else
				Return 100
		End Select
	End Function
	Public Shared Function IXnum(i As Integer) As String
		Select Case i
			Case 1
				Return "I"
			Case 2
				Return "II"
			Case 3
				Return "III"
			Case 4
				Return "IV"
			Case 5
				Return "V"
			Case 6
				Return "VI"
			Case 7
				Return "VII"
			Case 8
				Return "VIII"
			Case 9
				Return "IX"
			Case 10
				Return "X"
			Case 11
				Return "XI"
			Case 12
				Return "XII"
			Case 13
				Return "XIII"
			Case 14
				Return "XIV"
			Case 15
				Return "XV"
			Case 16
				Return "XVI"
			Case 17
				Return "XVII"
			Case 18
				Return "XVIII"
			Case 19
				Return "XIX"
			Case 20
				Return "XX"
			Case 21
				Return "XXI"
			Case 22
				Return "XXII"
			Case 23
				Return "XXIII"
			Case 24
				Return "XXIV"
			Case 25
				Return "XXV"
			Case 26
				Return "XXVI"
			Case 27
				Return "XXVII"
			Case 28
				Return "XXVIII"
			Case 29
				Return "XXIX"
			Case 30
				Return "XXX"
			Case 31
				Return "XXXI"
			Case 32
				Return "XXXII"
			Case 33
				Return "XXXIII"
			Case 34
				Return "XXXIV"
			Case 35
				Return "XXXV"
			Case 36
				Return "XXXVI"
			Case 37
				Return "XXXVII"
			Case 38
				Return "XXXVIII"
			Case 39
				Return "XXXIX"
			Case Else
				Return "XXXX"
		End Select
	End Function
	Public Shared Function BugLog(pid As Integer, val As String, tabName As String) As String
		Return "Hệ thống đang bận, vui lòng thử lại sau [CODE: " & flDnn.CMS_Buglog_Add(pid, flReg.AESEncrypt(val), tabName) & "]"
	End Function
	Public Shared Function Telephone(PortalID As Integer, userName As String) As String
		Telephone = flCache.GetCache("Telephone_" & userName) & ""
		If Telephone = "" Then
			Telephone = flDnn.DNN_User_Get_Telephone(PortalID, userName)
			flCache.SetCache("Telephone_" & userName, Telephone)
		End If
	End Function
	Public Shared Function GetPropertyName(PortalID As Integer, userName As String, proName As String) As String
		GetPropertyName = flCache.GetCache("GetPropertyName_" & userName & "_" & proName) & ""
		If GetPropertyName = "" Then
			GetPropertyName = flDnn.DNN_User_Get_Property(PortalID, userName, proName)
			If IsNothing(GetPropertyName) Then
				GetPropertyName = ""
			End If
			flCache.SetCache("GetPropertyName_" & userName & "_" & proName, GetPropertyName)
		End If
	End Function
	Public Shared Function ProvinND(pid As Integer, UserName As String, tabName As String) As String
		If UserName = "host" Or UserName = "admin" Then Return ""
		ProvinND = flCache.GetCache("ProvinID_" & tabName & "_" & UserName) & ""
		If ProvinND = "" Then
			Dim obj As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", UserName, tabName, pid)
			If IsNothing(obj) = False Then
				flCache.SetCache("ProvinID_" & tabName & "_" & UserName, obj.ProvinID)
				Return obj.ProvinID
			End If
		End If
	End Function
	Public Shared Function DistrictND(UserName As String, tabName As String) As String
		If UserName = "host" Or UserName = "admin" Then Return ""
		DistrictND = flCache.GetCache("DistrictID_" & tabName & "_" & UserName) & ""
		If DistrictND = "" Then
			Dim obj As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", UserName, tabName, flConnect.PortalId)
			If IsNothing(obj) = False Then
				flCache.SetCache("DistrictID_" & tabName & "_" & UserName, obj.DistrictID)
				Return obj.DistrictID
			End If
		End If
	End Function
	Public Shared Function WardND(UserName As String, tabName As String) As String
		If UserName = "host" Or UserName = "admin" Then Return ""
		WardND = flCache.GetCache("WardID_" & tabName & "_" & UserName) & ""
		If WardND = "" Then
			Dim obj As CMSUserPortalInfo = flDnn.CMSUserPortal_Get_By_User("", UserName, tabName, flConnect.PortalId)
			If IsNothing(obj) = False Then
				flCache.SetCache("WardID_" & tabName & "_" & UserName, obj.WardID)
				Return obj.WardID
			End If
		End If
	End Function
    Public Shared Function TruNgay(tuNgay As DateTime, denNgay As DateTime, Optional ByVal layAm As Boolean = True) As Integer
        If layAm = True Then
            Return (denNgay - tuNgay).Days
        Else
            If (denNgay - tuNgay).Days > 0 Then
                Return (denNgay - tuNgay).Days + 1
            Else
                If (denNgay - tuNgay).Days = 0 Then
                    Return 1
                Else
                    Return 0
                End If
            End If
        End If
    End Function
	Public Shared Function OffTime(startDate As DateTime, intEndDate As Integer) As DateTime
		If intEndDate = 0 Then
			Return flReg.DateNull
		Else
			Dim dateTemp, dateNew As DateTime
			Dim intD, intCount, intK As Integer
			intCount = 0
			intD = intEndDate
			Dim s As String = ""
			'---- Begin 1: Đếm có bao nhiêu T7 và CN trong khoảng thời gian 
			For i As Integer = 0 To intD - 1
				dateTemp = DateAdd(DateInterval.Day, i, startDate)
				If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
					intCount += 1 'Chu nhat 
					s += dateTemp.ToString("dd/MM/yyyy") & "_"
				ElseIf dateTemp.DayOfWeek = DayOfWeek.Saturday Then
					intCount += 1 'Thu 7
					s += dateTemp.ToString("dd/MM/yyyy") & "_"
				End If
				intK = flDnn.CMS_OffTime_Get_By_Dates(0, dateTemp) 'Nghi bu
				If intK > 0 Then
					intCount += intK
					s += dateTemp.ToString("dd/MM/yyyy") & "_"
				End If
			Next
			intD = intEndDate + intCount - 1
			'----- End 1

			'--- Begin 2: Kiểm tra ngày kết thúc có vào T7 và CN không?
			dateTemp = DateAdd(DateInterval.Day, intD, startDate)
			If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
				intD += 1
				s += dateTemp.ToString("dd/MM/yyyy") & "_"
			End If
			If dateTemp.DayOfWeek = DayOfWeek.Saturday Then
				intD += 2
				s += dateTemp.ToString("dd/MM/yyyy") & "_"
			End If

			dateNew = DateAdd(DateInterval.Day, intD, startDate)
			intK = flDnn.CMS_OffTime_Get_By_Dates(0, dateNew)
			If intK > 0 Then
				intD = intD + intK
				s += dateNew.ToString("dd/MM/yyyy") & "_"
			End If
			'--- End 2

			'--- Begin 3: Kiểm tra ngày kết thúc sau khi cộng ngày nghỉ lễ có vào T7 và CN không?
			dateTemp = DateAdd(DateInterval.Day, intD, startDate)
			If dateTemp.DayOfWeek = DayOfWeek.Sunday Then
				intD += 1
				s += dateTemp.ToString("dd/MM/yyyy") & "_"
			End If
			If dateTemp.DayOfWeek = DayOfWeek.Saturday Then
				intD += 2
				s += dateTemp.ToString("dd/MM/yyyy") & "_"
			End If
			'--- End 3

			intCount = 0
			For i As Integer = intEndDate To intD
				dateTemp = DateAdd(DateInterval.Day, i, startDate)
				If dateTemp.DayOfWeek = DayOfWeek.Sunday And s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
					intCount += 1 'Chu nhat 
				ElseIf dateTemp.DayOfWeek = DayOfWeek.Saturday And s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
					intCount += 1 'Thu 7
				End If
				If s.Contains(dateTemp.ToString("dd/MM/yyyy")) = False Then
					intCount += flDnn.CMS_OffTime_Get_By_Dates(0, dateTemp) 'Nghi bu
				End If
			Next
			Return DateAdd(DateInterval.Day, intD + intCount, startDate)
		End If
	End Function
	Public Shared Function GetRequestId(surl As String) As Integer
		surl = surl.Replace(".html", "").Substring(surl.LastIndexOf("-") + 1)
		If surl.Contains("?") Then surl = surl.Substring(0, surl.LastIndexOf("?"))
		Return flReg.WriteNumber(surl)
	End Function
	Public Shared Function ConvertUrlReferrer(uriStr As Uri, returnStr As String) As String
		If IsNothing(uriStr) Then
			ConvertUrlReferrer = "/" & returnStr
		Else
			ConvertUrlReferrer = uriStr.ToString() & ""
		End If
	End Function

End Class
Public Class flCache
	Public Shared Sub RemoveCache(CacheKey As String)
		DataCache.RemoveCache(CacheKey)
	End Sub
	Public Shared Function GetCache(CacheKey As String) As Object
		Return DataCache.GetCache(CacheKey)
	End Function
	Public Shared Sub SetCache(CacheKey As String, ByVal objObject As Object, Optional ByVal CacheSeconds As Integer = 0)
		If CacheSeconds > 0 Then
			DataCache.SetCache(CacheKey, objObject, Now.AddSeconds(CacheSeconds))
		Else
			DataCache.SetCache(CacheKey, objObject)
		End If
	End Sub
End Class
Public Class flDic

	Shared strOld, str(), strOld1, str1() As String
	Shared arrTemp, arrTemp1 As New ArrayList

	Public Shared Function DanhMuc_Name(PortalConnect As Integer, TenDanhMuc As String, ID As Integer, Optional EmptyStr As String = "Không yêu cầu") As String
		DanhMuc_Name = EmptyStr
		Dim obj As CMS_DanhMucInfo = flDnn.CMS_DanhMuc_Get(PortalConnect, TenDanhMuc, ID)
		If IsNothing(obj) = False Then
			DanhMuc_Name = obj.Name
		End If
	End Function
#Region "Danh muc hanh chinh"
	Public Shared Sub LoadRegionalTP_Year(yearID As Integer, pid As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn tỉnh - - -", Optional ByVal Types As String = "TP")
		dr.Items.Clear()
		If Types = "TP" And UserInfo.Username <> "host" Then
			strOld = flReg.ProvinND(pid, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalTP_Name(yearID, pid, str(i)).Replace("Thành phố ", "").Replace("Tỉnh ", ""), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalTP_Backup_List_Parent_Null_" & yearID)) Then
				arrTemp1 = flDnn.CMS_RegionalTP_Backup_List_Parent_Null(pid, yearID)
				flCache.SetCache("CMS_RegionalTP_Backup_List_Parent_Null_" & yearID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalTP_Backup_List_Parent_Null_" & yearID), ArrayList)
			End If
			If text = "ALL" Then
				dr.Items.Add(New ListItem("Tất cả tỉnh thành", 0))
			ElseIf text <> "" Then
				dr.Items.Add(New ListItem(text, ""))
			End If
			For Each Ci As CMS_RegionalTPInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False).Replace("Thành phố ", "").Replace("Tỉnh ", ""), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalQH_Year(yearID As Integer, pid As Integer, dr As DropDownList, tinhID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "QH")
		tinhID = flReg.WriteNumber(tinhID)
		dr.Items.Clear()
		If Types = "QH" And UserInfo.Username <> "host" Then
			strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalQH_Name(yearID, pid, str(i)), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & yearID & "_" & tinhID)) Then
				arrTemp1 = flDnn.CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP(pid, tinhID, yearID)
				flCache.SetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & yearID & "_" & tinhID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalQH_Backup_Get_By_CMS_RegionalTP_" & yearID & "_" & tinhID), ArrayList)
			End If
			If text <> "" Then dr.Items.Add(New ListItem(text, ""))
			For Each Ci As CMS_RegionalQHInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalXP_Year(yearID As Integer, pid As Integer, dr As DropDownList, quanHuyenID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "XP")
		quanHuyenID = flReg.WriteNumber(quanHuyenID)
		dr.Items.Clear()
		If Types = "XP" And UserInfo.Username <> "host" Then
			strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalXP_Name(yearID, pid, str(i)), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & yearID & "_" & quanHuyenID)) Then
				arrTemp1 = flDnn.CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH(pid, quanHuyenID, yearID)
				flCache.SetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & yearID & "_" & quanHuyenID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalXP_Backup_Get_By_CMS_RegionalQH_" & yearID & "_" & quanHuyenID), ArrayList)
			End If
			If text <> "" Then dr.Items.Add(New ListItem(text, ""))
			For Each Ci As CMS_RegionalXPInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalTO_Year(yearID As Integer, pid As Integer, dr As DropDownList, xaPhuongID As String, Optional ByVal text As String = "- - - Chọn - - -")
		xaPhuongID = flReg.WriteNumber(xaPhuongID)
		dr.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & yearID & "_" & xaPhuongID)) Then
			arrTemp1 = flDnn.CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP(pid, xaPhuongID, yearID)
			flCache.SetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & yearID & "_" & xaPhuongID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTO_Backup_Get_By_CMS_RegionalXP_" & yearID & "_" & xaPhuongID), ArrayList)
		End If
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_RegionalTOInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
	End Sub
	Public Shared Function RegionalTP_Name_Year(yearID As Integer, pid As Integer, id As String, Optional ByVal textNull As String = "Tất cả tỉnh/ thành phố", Optional ByVal replace As Boolean = False) As String
		RegionalTP_Name_Year = flCache.GetCache(yearID & "_RegionalTP_Name" & pid & "_" & id & "_" & replace) & ""
		If RegionalTP_Name_Year = "" And id <> "" Then
			Dim Info As CMS_RegionalTPInfo = flDnn.CMS_RegionalTP_Backup_Get(pid, flReg.WriteNumber(id), yearID)
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalTP_Name_Year = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalTP_Name_Year = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache(yearID & "_RegionalTP_Name_" & pid & "_" & id & "_" & replace, RegionalTP_Name_Year)
			Else
				RegionalTP_Name_Year = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalQH_Name_Year(yearID As Integer, pid As Integer, id As String, Optional ByVal textNull As String = "Tất cả quận/ huyện", Optional ByVal replace As Boolean = False) As String
		RegionalQH_Name_Year = flCache.GetCache(yearID & "_RegionalQH_Name" & pid & "_" & id & "_" & replace) & ""
		If RegionalQH_Name_Year = "" And id <> "" Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Backup_Get(pid, flReg.WriteNumber(id), yearID)
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalQH_Name_Year = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalQH_Name_Year = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache(yearID & "_RegionalQH_Name_" & pid & "_" & id & "_" & replace, RegionalQH_Name_Year)
			Else
				RegionalQH_Name_Year = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalXP_Name_Year(yearID As Integer, pid As Integer, id As String, Optional ByVal textNull As String = "Tất cả xã/ phường", Optional ByVal replace As Boolean = False) As String
		RegionalXP_Name_Year = flCache.GetCache(yearID & "_RegionalXP_Name" & pid & "_" & id & "_" & replace) & ""
		If RegionalXP_Name_Year = "" And id <> "" Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Backup_Get(pid, flReg.WriteNumber(id), yearID)
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalXP_Name_Year = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalXP_Name_Year = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache(yearID & "_RegionalXP_Name_" & pid & "_" & id & "_" & replace, RegionalXP_Name_Year)
			Else
				RegionalXP_Name_Year = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalTO_Name_Year(yearID As Integer, pid As Integer, id As String, Optional ByVal textNull As String = "Tất cả thôn/ tổ", Optional ByVal replace As Boolean = False) As String
		RegionalTO_Name_Year = flCache.GetCache(yearID & "_RegionalTO_Name" & pid & "_" & id & "_" & replace) & ""
		If RegionalTO_Name_Year = "" And id <> "" Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Backup_Get(pid, flReg.WriteNumber(id), yearID)
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalTO_Name_Year = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalTO_Name_Year = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache(yearID & "_RegionalTO_Name_" & pid & "_" & id & "_" & replace, RegionalTO_Name_Year)
			Else
				RegionalTO_Name_Year = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalTP_ID(pid As Integer, name As String) As Integer
		RegionalTP_ID = flReg.WriteNumber(flCache.GetCache("RegionalTP_ID_" & pid & "_" & name) & "")
		If RegionalTP_ID = 0 Then
			name = name.Trim()
			Dim Info As New CMS_RegionalTPInfo
			Info = flDnn.CMS_RegionalTP_Get_By_Name(pid, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_RegionalTP_Get_By_Name(pid, name)
			If IsNothing(Info) = False Then
				RegionalTP_ID = Info.Regional_ID
				flCache.SetCache("RegionalTP_ID_" & pid & "_" & name, RegionalTP_ID)
			End If
		End If
	End Function
	Public Shared Function RegionalQH_ID(pid As Integer, name As String) As Integer
		RegionalQH_ID = flReg.WriteNumber(flCache.GetCache("RegionalQH_ID_" & pid & "_" & name) & "")
		If RegionalQH_ID = 0 Then
			name = name.Trim()
			Dim Info As New CMS_RegionalQHInfo
			Info = flDnn.CMS_RegionalQH_Get_By_Name(pid, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_RegionalQH_Get_By_Name(pid, name)
			If IsNothing(Info) = False Then
				RegionalQH_ID = Info.Regional_ID
				flCache.SetCache("RegionalQH_ID_" & pid & "_" & name, RegionalQH_ID)
			End If
		End If
	End Function
	Public Shared Function RegionalXP_ID(pid As Integer, name As String) As Integer
		RegionalXP_ID = flReg.WriteNumber(flCache.GetCache("RegionalXP_ID_" & pid & "_" & name) & "")
		If RegionalXP_ID = 0 Then
			name = name.Trim()
			Dim Info As New CMS_RegionalXPInfo
			Info = flDnn.CMS_RegionalXP_Get_By_Name(pid, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_RegionalXP_Get_By_Name(pid, name)
			If IsNothing(Info) = False Then
				RegionalXP_ID = Info.Regional_ID
				flCache.SetCache("RegionalXP_ID_" & pid & "_" & name, RegionalXP_ID)
			End If
		End If
	End Function
	Public Shared Function RegionalTO_ID(pid As Integer, name As String) As Integer
		RegionalTO_ID = flReg.WriteNumber(flCache.GetCache("RegionalTO_ID_" & pid & "_" & name) & "")
		If RegionalTO_ID = 0 Then
			name = name.Trim()
			Dim Info As New CMS_RegionalTOInfo
			Info = flDnn.CMS_RegionalTO_Get_By_Name(pid, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_RegionalTO_Get_By_Name(pid, name)
			If IsNothing(Info) = False Then
				RegionalTO_ID = Info.Regional_ID
				flCache.SetCache("RegionalTO_ID_" & pid & "_" & name, RegionalTO_ID)
			End If
		End If
	End Function
	Public Shared Function RegionalTP_ID_ByCode(pid As Integer, code As String) As Integer
		RegionalTP_ID_ByCode = flReg.WriteNumber(flCache.GetCache("RegionalTP_ID_ByCode_" & pid & "_" & code) & "")
		If RegionalTP_ID_ByCode = 0 Then
			Dim Info As New CMS_RegionalTPInfo
			Info = flDnn.CMS_RegionalTP_Get_By_Code(pid, code.Trim())
			If IsNothing(Info) = False Then
				RegionalTP_ID_ByCode = Info.Regional_ID
				flCache.SetCache("RegionalTP_ID_ByCode_" & pid & "_" & code, RegionalTP_ID_ByCode)
			End If
		End If
	End Function
	Public Shared Function RegionalQH_ID_ByCode(pid As Integer, code As String) As Integer
		RegionalQH_ID_ByCode = flReg.WriteNumber(flCache.GetCache("RegionalQH_ID_ByCode_" & pid & "_" & code) & "")
		If RegionalQH_ID_ByCode = 0 Then
			Dim Info As New CMS_RegionalQHInfo
			Info = flDnn.CMS_RegionalQH_Get_By_Code(pid, code.Trim())
			If IsNothing(Info) = False Then
				RegionalQH_ID_ByCode = Info.Regional_ID
				flCache.SetCache("RegionalQH_ID_ByCode_" & pid & "_" & code, RegionalQH_ID_ByCode)
			End If
		End If
	End Function
	Public Shared Function RegionalXP_ID_ByCode(pid As Integer, code As String) As Integer
		RegionalXP_ID_ByCode = flReg.WriteNumber(flCache.GetCache("RegionalXP_ID_ByCode_" & pid & "_" & code) & "")
		If RegionalXP_ID_ByCode = 0 Then
			Dim Info As New CMS_RegionalXPInfo
			Info = flDnn.CMS_RegionalXP_Get_By_Code(pid, code.Trim())
			If IsNothing(Info) = False Then
				RegionalXP_ID_ByCode = Info.Regional_ID
				flCache.SetCache("RegionalXP_ID_ByCode_" & pid & "_" & code, RegionalXP_ID_ByCode)
			End If
		End If
	End Function
	Public Shared Function RegionalTO_ID_ByCode(pid As Integer, code As String) As Integer
		RegionalTO_ID_ByCode = flReg.WriteNumber(flCache.GetCache("RegionalTO_ID_ByCode_" & pid & "_" & code) & "")
		If RegionalTO_ID_ByCode = 0 Then
			Dim Info As New CMS_RegionalTOInfo
			Info = flDnn.CMS_RegionalTO_Get_By_Code(pid, code.Trim())
			If IsNothing(Info) = False Then
				RegionalTO_ID_ByCode = Info.Regional_ID
				flCache.SetCache("RegionalTO_ID_ByCode_" & pid & "_" & code, RegionalTO_ID_ByCode)
			End If
		End If
	End Function
	Public Shared Function RegionalTP_ID(pid As Integer, parentID As String, name As String) As Integer
		RegionalTP_ID = flReg.WriteNumber(flCache.GetCache("RegionalTP_ID_" & parentID & "_" & pid & "_" & name) & "")
		If RegionalTP_ID = 0 Then
			name = name.Trim()
			RegionalTP_ID = flDnn.CMS_RegionalTP_Get_Name_Parent(pid, parentID, flReg.RemoveScript(name))
			If RegionalTP_ID = 0 Then RegionalTP_ID = flDnn.CMS_RegionalTP_Get_Name_Parent(pid, parentID, name)
			flCache.SetCache("RegionalTP_ID_" & parentID & "_" & pid & "_" & name, RegionalTP_ID)
		End If
	End Function
	Public Shared Function RegionalQH_ID(pid As Integer, parentID As String, name As String) As Integer
		RegionalQH_ID = flReg.WriteNumber(flCache.GetCache("RegionalQH_ID_" & parentID & "_" & pid & "_" & name) & "")
		If RegionalQH_ID = 0 Then
			name = name.Trim()
			RegionalQH_ID = flDnn.CMS_RegionalQH_Get_Name_Parent(pid, parentID, flReg.RemoveScript(name))
			If RegionalQH_ID = 0 Then RegionalQH_ID = flDnn.CMS_RegionalQH_Get_Name_Parent(pid, parentID, name)
			flCache.SetCache("RegionalQH_ID_" & parentID & "_" & pid & "_" & name, RegionalQH_ID)
		End If
	End Function
	Public Shared Function RegionalXP_ID(pid As Integer, parentID As String, name As String) As Integer
		RegionalXP_ID = flReg.WriteNumber(flCache.GetCache("RegionalXP_ID_" & parentID & "_" & pid & "_" & name) & "")
		If RegionalXP_ID = 0 Then
			name = name.Trim()
			RegionalXP_ID = flDnn.CMS_RegionalXP_Get_Name_Parent(pid, parentID, flReg.RemoveScript(name))
			If RegionalXP_ID = 0 Then RegionalXP_ID = flDnn.CMS_RegionalXP_Get_Name_Parent(pid, parentID, name)
			flCache.SetCache("RegionalXP_ID_" & parentID & "_" & pid & "_" & name, RegionalXP_ID)
		End If
	End Function
	Public Shared Function RegionalTO_ID(pid As Integer, parentID As String, name As String) As Integer
		RegionalTO_ID = flReg.WriteNumber(flCache.GetCache("RegionalTO_ID_" & parentID & "_" & pid & "_" & name) & "")
		If RegionalTO_ID = 0 Then
			name = name.Trim()
			RegionalTO_ID = flDnn.CMS_RegionalTO_Get_Name_Parent(pid, parentID, flReg.RemoveScript(name))
			If RegionalTO_ID = 0 Then RegionalTO_ID = flDnn.CMS_RegionalTO_Get_Name_Parent(pid, parentID, name)
			flCache.SetCache("RegionalTO_ID_" & parentID & "_" & pid & "_" & name, RegionalTO_ID)
		End If
	End Function
	Public Shared Function RegionalTP_AreaID(pid As Integer, id As String) As Integer
		RegionalTP_AreaID = flReg.WriteNumber(flCache.GetCache("RegionalTP_AreaID_" & pid & "_" & id) & "")
		If RegionalTP_AreaID = 0 Then
			Dim Info As CMS_RegionalTPInfo = flDnn.CMS_RegionalTP_Get(pid, id)
			If IsNothing(Info) = False Then
				RegionalTP_AreaID = Info.AreaID
				flCache.SetCache("RegionalTP_AreaID_" & pid & "_" & id, RegionalTP_AreaID)
			End If
		End If
	End Function
	Public Shared Function RegionalQH_AreaID(pid As Integer, id As String) As Integer
		RegionalQH_AreaID = flReg.WriteNumber(flCache.GetCache("RegionalQH_AreaID_" & pid & "_" & id) & "")
		If RegionalQH_AreaID = 0 Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Get(pid, id)
			If IsNothing(Info) = False Then
				RegionalQH_AreaID = Info.AreaID
				flCache.SetCache("RegionalQH_AreaID_" & pid & "_" & id, RegionalQH_AreaID)
			End If
		End If
	End Function
	Public Shared Function RegionalXP_AreaID(pid As Integer, id As String) As Integer
		RegionalXP_AreaID = flReg.WriteNumber(flCache.GetCache("RegionalXP_AreaID_" & pid & "_" & id) & "")
		If RegionalXP_AreaID = 0 Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Get(pid, id)
			If IsNothing(Info) = False Then
				RegionalXP_AreaID = Info.AreaID
				flCache.SetCache("RegionalXP_AreaID_" & pid & "_" & id, RegionalXP_AreaID)
			End If
		End If
	End Function
	Public Shared Function RegionalTO_AreaID(pid As Integer, id As String) As Integer
		RegionalTO_AreaID = flReg.WriteNumber(flCache.GetCache("RegionalTO_AreaID_" & pid & "_" & id) & "")
		If RegionalTO_AreaID = 0 Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Get(pid, id)
			If IsNothing(Info) = False Then
				RegionalTO_AreaID = Info.AreaID
				flCache.SetCache("RegionalTO_AreaID_" & pid & "_" & id, RegionalTO_AreaID)
			End If
		End If
	End Function
	Public Shared Function ReplaceDiaDanh(tenDiaDanh As String) As String
		ReplaceDiaDanh = flCache.GetCache("ReplaceDiaDanh_" & flReg.NameUrl(flReg.RemoveScript(tenDiaDanh, False))) & ""
		If ReplaceDiaDanh = "" Then
			ReplaceDiaDanh = flReg.RemoveScript(tenDiaDanh, False)
			ReplaceDiaDanh = ReplaceDiaDanh.Replace("Tỉnh ", "").Replace("Thành phố ", "").Replace("Huyện ", "").Replace("Thành Phố ", "")
			ReplaceDiaDanh = ReplaceDiaDanh.Replace("Thị xã ", "").Replace("Thị Xã ", "").Replace("Xã ", "")
			ReplaceDiaDanh = ReplaceDiaDanh.Replace("Phường ", "").Replace("Thị trấn ", "").Replace("Thị Trấn ", "")
			If ReplaceDiaDanh.Length > 10 Then ReplaceDiaDanh = ReplaceDiaDanh.Replace("Quận ", "")

			flCache.SetCache("ReplaceDiaDanh_" & flReg.NameUrl(flReg.RemoveScript(tenDiaDanh, False)), ReplaceDiaDanh)
		End If
	End Function

	Public Shared Function TenDanhMucChung(pid As Integer, tenBang As String, id As Integer) As String
		TenDanhMucChung = ""
		Dim obDanhMuc = flDnn.CMS_DanhMuc_Get(pid, tenBang, id)
		If IsNothing(obDanhMuc) = False Then
			TenDanhMucChung = obDanhMuc.Name
		End If
		Return TenDanhMucChung
	End Function
	Public Shared Function RegionalTP_Name(pid As Integer, Id As String, Optional ByVal textNull As String = "Tất cả tỉnh/ tp", Optional ByVal replace As Boolean = False) As String
		RegionalTP_Name = flCache.GetCache("RegionalTP_Name" & pid & "_" & Id & "_" & replace) & ""
		If RegionalTP_Name = "" And Id <> "" Then
			Dim Info As CMS_RegionalTPInfo = flDnn.CMS_RegionalTP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalTP_Name = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalTP_Name = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache("RegionalTP_Name_" & pid & "_" & Id & "_" & replace, RegionalTP_Name)
			Else
				RegionalTP_Name = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalQH_Name(pid As Integer, Id As String, Optional ByVal textNull As String = "Tất cả quận/ huyện", Optional ByVal replace As Boolean = False) As String
		RegionalQH_Name = flCache.GetCache("RegionalQH_Name" & pid & "_" & Id & "_" & replace) & ""
		If RegionalQH_Name = "" And Id <> "" Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalQH_Name = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalQH_Name = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache("RegionalQH_Name_" & pid & "_" & Id & "_" & replace, RegionalQH_Name)
			Else
				RegionalQH_Name = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalXP_Name(pid As Integer, Id As String, Optional ByVal textNull As String = "Tất cả xã/ phường", Optional ByVal replace As Boolean = False) As String
		RegionalXP_Name = flCache.GetCache("RegionalXP_Name" & pid & "_" & Id & "_" & replace) & ""
		If RegionalXP_Name = "" And Id <> "" Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalXP_Name = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalXP_Name = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache("RegionalXP_Name_" & pid & "_" & Id & "_" & replace, RegionalXP_Name)
			Else
				RegionalXP_Name = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalTO_Name(pid As Integer, Id As String, Optional ByVal textNull As String = "Tất cả thôn/ tổ", Optional ByVal replace As Boolean = False) As String
		RegionalTO_Name = flCache.GetCache("RegionalTO_Name" & pid & "_" & Id & "_" & replace) & ""
		If RegionalTO_Name = "" And Id <> "" Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				If replace = True Then
					RegionalTO_Name = ReplaceDiaDanh(Info.Regional_Name)
				Else
					RegionalTO_Name = flReg.RemoveScript(Info.Regional_Name, False)
				End If
				flCache.SetCache("RegionalTO_Name_" & pid & "_" & Id & "_" & replace, RegionalTO_Name)
			Else
				RegionalTO_Name = textNull
			End If
		End If
	End Function
	Public Shared Function RegionalTP_Area(pid As Integer, Id As String) As String
		RegionalTP_Area = flCache.GetCache("RegionalTP_Area_" & pid & "_" & Id) & ""
		If RegionalTP_Area = "" And Id <> "" Then
			Dim Info As CMS_RegionalTPInfo = flDnn.CMS_RegionalTP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalTP_Area = flReg.RemoveScript(Info.AreaID, False)
				flCache.SetCache("RegionalTP_Area_" & pid & "_" & Id, RegionalTP_Area)
			Else
				RegionalTP_Area = Id
			End If
		End If
	End Function
	Public Shared Function RegionalQH_Area(pid As Integer, Id As String) As String
		RegionalQH_Area = flCache.GetCache("RegionalQH_Area_" & pid & "_" & Id) & ""
		If RegionalQH_Area = "" And Id <> "" Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalQH_Area = flReg.RemoveScript(Info.AreaID, False)
				flCache.SetCache("RegionalQH_Area_" & pid & "_" & Id, RegionalQH_Area)
			Else
				RegionalQH_Area = Id
			End If
		End If
	End Function
	Public Shared Function RegionalXP_Area(pid As Integer, Id As String) As String
		RegionalXP_Area = flCache.GetCache("RegionalXP_Area_" & pid & "_" & Id) & ""
		If RegionalXP_Area = "" And Id <> "" Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalXP_Area = flReg.RemoveScript(Info.AreaID, False)
				flCache.SetCache("RegionalXP_Area_" & pid & "_" & Id, RegionalXP_Area)
			Else
				RegionalXP_Area = Id
			End If
		End If
	End Function
	Public Shared Function RegionalTO_Area(pid As Integer, Id As String) As String
		RegionalTO_Area = flCache.GetCache("RegionalTO_Area_" & pid & "_" & Id) & ""
		If RegionalTO_Area = "" And Id <> "" Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalTO_Area = flReg.RemoveScript(Info.AreaID, False)
				flCache.SetCache("RegionalTO_Area_" & pid & "_" & Id, RegionalTO_Area)
			Else
				RegionalTO_Area = Id
			End If
		End If
	End Function
	Public Shared Function RegionalQH_Parent(pid As Integer, Id As String) As String
		RegionalQH_Parent = flCache.GetCache("Regional_Parent_" & pid & "_" & Id)
		If RegionalQH_Parent = "" Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalQH_Parent = flReg.RemoveScript(Info.Parent_ID, False)
				flCache.SetCache("Regional_Parent_" & pid & "_" & Id, RegionalQH_Parent)
			End If
		End If
	End Function
	Public Shared Function RegionalXP_Parent(pid As Integer, Id As String) As String
		RegionalXP_Parent = flCache.GetCache("Regional_Parent_" & pid & "_" & Id)
		If RegionalXP_Parent = "" Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalXP_Parent = flReg.RemoveScript(Info.Parent_ID, False)
				flCache.SetCache("Regional_Parent_" & pid & "_" & Id, RegionalXP_Parent)
			End If
		End If
	End Function
	Public Shared Function RegionalTO_Parent(pid As Integer, Id As String) As String
		RegionalTO_Parent = flCache.GetCache("Regional_Parent_" & pid & "_" & Id)
		If RegionalTO_Parent = "" Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalTO_Parent = flReg.RemoveScript(Info.Parent_ID, False)
				flCache.SetCache("Regional_Parent_" & pid & "_" & Id, RegionalTO_Parent)
			End If
		End If
	End Function
	Public Shared Function RegionalTP_Code(pid As Integer, Id As String) As String
		RegionalTP_Code = flCache.GetCache("RegionalTP_Code_" & pid & "_" & Id)
		If RegionalTP_Code = "" Then
			Dim Info As CMS_RegionalTPInfo = flDnn.CMS_RegionalTP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalTP_Code = flReg.RemoveScript(Info.Regional_Code, False)
				flCache.SetCache("RegionalTP_Code_" & pid & "_" & Id, RegionalTP_Code)
			End If
		End If
	End Function
	Public Shared Function RegionalQH_Code(pid As Integer, Id As String) As String
		RegionalQH_Code = flCache.GetCache("RegionalQH_Code_" & pid & "_" & Id)
		If RegionalQH_Code = "" Then
			Dim Info As CMS_RegionalQHInfo = flDnn.CMS_RegionalQH_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalQH_Code = flReg.RemoveScript(Info.Regional_Code, False)
				flCache.SetCache("RegionalQH_Code_" & pid & "_" & Id, RegionalQH_Code)
			End If
		End If
	End Function
	Public Shared Function RegionalXP_Code(pid As Integer, Id As String) As String
		RegionalXP_Code = flCache.GetCache("RegionalXP_Code_" & pid & "_" & Id)
		If RegionalXP_Code = "" Then
			Dim Info As CMS_RegionalXPInfo = flDnn.CMS_RegionalXP_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalXP_Code = flReg.RemoveScript(Info.Regional_Code, False)
				flCache.SetCache("RegionalXP_Code_" & pid & "_" & Id, RegionalXP_Code)
			End If
		End If
	End Function
	Public Shared Function RegionalTO_Code(pid As Integer, Id As String) As String
		RegionalTO_Code = flCache.GetCache("RegionalTO_Code_" & pid & "_" & Id)
		If RegionalTO_Code = "" Then
			Dim Info As CMS_RegionalTOInfo = flDnn.CMS_RegionalTO_Get(pid, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				RegionalTO_Code = flReg.RemoveScript(Info.Regional_Code, False)
				flCache.SetCache("RegionalTO_Code_" & pid & "_" & Id, RegionalTO_Code)
			End If
		End If
	End Function
	Public Shared Function RegionalTP_QHName(pid As Integer, tinhTP As String, quanHuyen As String) As String
		strOld = flCache.GetCache("RegionalTP_QHName_" & pid & "_" & tinhTP & "_" & quanHuyen) & ""
		If strOld = "" Then
			If tinhTP <> "" Then
				str = tinhTP.Split(",") : strOld = ""
				For i As Integer = 0 To str.Length - 1
					If flReg.WriteNumber(str(i)) > 0 Then
						strOld += flDic.RegionalTP_Name(pid, str(i), "", True) & "; "
					End If
				Next
			ElseIf quanHuyen <> "" Then
				str = quanHuyen.Split(",")
				strOld = flDic.RegionalQH_Name(pid, tinhTP, "", True) & ": "
				For i As Integer = 0 To str.Length - 1
					If flReg.WriteNumber(str(i)) > 0 Then
						strOld += flDic.RegionalQH_Name(pid, str(i), "", True) & "; "
					End If
				Next
			End If
			If strOld <> "" Then strOld = strOld.Substring(0, strOld.LastIndexOf(";")).Trim()
			flCache.SetCache("RegionalTP_QHName_" & pid & "_" & tinhTP & "_" & quanHuyen, strOld)
		End If
		Return strOld
	End Function
	Public Shared Sub LoadRegionalTP(pid As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn tỉnh - - -", Optional ByVal Types As String = "TP")
		dr.Items.Clear()
		If Types = "TP" And UserInfo.Username <> "host" Then
			strOld = flReg.ProvinND(pid, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalTP_Name(pid, str(i)).Replace("Thành phố ", "").Replace("Tỉnh ", ""), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid)) Then
				arrTemp1 = flDnn.CMS_RegionalTP_List_Parent_Null(pid)
				flCache.SetCache("CMS_RegionalTP_List_Parent_Null_" & pid, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid), ArrayList)
			End If
			If text = "ALL" Then
				dr.Items.Add(New ListItem("Tất cả tỉnh thành", 0))
			ElseIf text <> "" Then
				dr.Items.Add(New ListItem(text, ""))
			End If
			For Each Ci As CMS_RegionalTPInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False).Replace("Thành phố ", "").Replace("Tỉnh ", ""), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalQH(pid As Integer, dr As DropDownList, tinhID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "QH")
		tinhID = flReg.WriteNumber(tinhID)
		dr.Items.Clear()
		If Types = "QH" And UserInfo.Username <> "host" Then
			strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalQH_Name(pid, str(i)), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & tinhID)) Then
				arrTemp1 = flDnn.CMS_RegionalQH_Get_By_CMS_RegionalTP(pid, tinhID)
				flCache.SetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & tinhID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & tinhID), ArrayList)
			End If
			If text <> "" Then dr.Items.Add(New ListItem(text, ""))
			For Each Ci As CMS_RegionalQHInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalXP(pid As Integer, dr As DropDownList, quanHuyenID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "XP")
		quanHuyenID = flReg.WriteNumber(quanHuyenID)
		dr.Items.Clear()
		If Types = "XP" And UserInfo.Username <> "host" Then
			strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.RegionalXP_Name(pid, str(i)), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & quanHuyenID)) Then
				arrTemp1 = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, quanHuyenID)
				flCache.SetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & quanHuyenID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & quanHuyenID), ArrayList)
			End If
			If text <> "" Then dr.Items.Add(New ListItem(text, ""))
			For Each Ci As CMS_RegionalXPInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegionalTO(pid As Integer, dr As DropDownList, xaPhuongID As String, Optional ByVal text As String = "- - - Chọn - - -")
		xaPhuongID = flReg.WriteNumber(xaPhuongID)
		dr.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & xaPhuongID)) Then
			arrTemp1 = flDnn.CMS_RegionalTO_Get_By_CMS_RegionalXP(pid, xaPhuongID)
			flCache.SetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & xaPhuongID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & xaPhuongID), ArrayList)
		End If
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_RegionalTOInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
	End Sub
	Public Shared Sub LoadRegionalTP_ChecboxList(pid As Integer, dr As CheckBoxList)
		If IsNothing(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid)) Then
			arrTemp1 = flDnn.CMS_RegionalTP_List_Parent_Null(pid)
			flCache.SetCache("CMS_RegionalTP_List_Parent_Null_" & pid, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid), ArrayList)
		End If
		dr.Items.Clear()
		For Each Ci As CMS_RegionalTPInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.ProvinND(pid, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			dr.SelectedValue = strOld
			dr.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalTP_RadioButtonList(pid As Integer, dr As RadioButtonList)
		If IsNothing(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid)) Then
			arrTemp1 = flDnn.CMS_RegionalTP_List_Parent_Null(pid)
			flCache.SetCache("CMS_RegionalTP_List_Parent_Null_" & pid, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTP_List_Parent_Null_" & pid), ArrayList)
		End If
		dr.Items.Clear()
		For Each Ci As CMS_RegionalTPInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.ProvinND(pid, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			dr.SelectedValue = strOld
			dr.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalQH_RadioButtonList(pid As Integer, chkL As RadioButtonList, Parent_ID As String, Optional ByVal Types As String = "QH")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalQH_Get_By_CMS_RegionalTP(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalQHInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalXP_RadioButtonList(pid As Integer, chkL As RadioButtonList, Parent_ID As String, Optional ByVal Types As String = "XP")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalXPInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalTO_RadioButtonList(pid As Integer, chkL As RadioButtonList, Parent_ID As String)
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalTO_Get_By_CMS_RegionalXP(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalTOInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
	End Sub
	Public Shared Sub LoadRegionalQH_CheckBoxList(pid As Integer, chkL As CheckBoxList, Parent_ID As String, Optional ByVal Types As String = "QH")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalQH_Get_By_CMS_RegionalTP(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalQH_Get_By_CMS_RegionalTP_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalQHInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalXP_CheckBoxList(pid As Integer, chkL As CheckBoxList, Parent_ID As String, Optional ByVal Types As String = "XP")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalXP_Get_By_CMS_RegionalQH(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalXP_Get_By_CMS_RegionalQH_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalXPInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegionalTO_CheckBoxList(pid As Integer, chkL As CheckBoxList, Parent_ID As String)
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_RegionalTO_Get_By_CMS_RegionalXP(pid, Parent_ID)
			flCache.SetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_RegionalTO_Get_By_CMS_RegionalXP_" & pid & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalTOInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
	End Sub

#End Region
	Public Shared Sub ListUserName(drUser As DropDownList, UserName As String, Optional ByVal text As String = "- - - Chọn - - -")
		drUser.Items.Clear()
		If UserName = "host" Or UserName = "admin" Or UserName = "True" Then
			drUser.Items.Add(New ListItem(text, ""))
			arrTemp = flDnn.DNN_User_List_By_UserName(flConnect.PortalId, "")
		Else
			arrTemp = flDnn.DNN_User_List_By_UserName(flConnect.PortalId, UserName)
		End If
		For Each Cr As DnnInfo In arrTemp
			drUser.Items.Add(New ListItem(Cr.DisplayName, Cr.Username))
		Next
	End Sub
	Public Shared Sub ListUserName(pid As Integer, drUser As DropDownList, UserName As String, tabName As String, roleName As String)
		drUser.Items.Clear()
		If flDic.IsSuper(pid, UserName, tabName) = "true" And roleName = "" Then
			arrTemp1 = flDnn.DNN_User_List_By_UserName(0, "")
		Else
			arrTemp1 = flDnn.DNN_UserConfig_List_By_Search(0, tabName, "", 1, 1000, flReg.GetRolesID(tabName, roleName), 0, 0, 0)
		End If
		drUser.Items.Add(New ListItem(("- - - Chọn - - -"), ""))
		For Each Cr As DnnInfo In arrTemp1
			drUser.Items.Add(New ListItem(Cr.DisplayName & " (" & Cr.Username & ")", Cr.Username))
		Next
	End Sub
	Public Shared Sub ListUserName(drUser As DropDownList, tabName As String, roleName As String, ProvinID As Integer, DistrictID As Integer, WardID As Integer, Optional ByVal allText As String = "- - - Chọn - - -")
		drUser.Items.Clear()
		If allText <> "" Then drUser.Items.Add(New ListItem(allText, ""))
		str = roleName.Split(";")
		For i As Integer = 0 To str.Length - 1
			For Each Cr As DnnInfo In flDnn.DNN_UserConfig_List_By_Index_Role(0, ProvinID, DistrictID, WardID, tabName, flReg.GetRolesID(tabName, str(i)))
				drUser.Items.Add(New ListItem(Cr.DisplayName & " (" & Cr.Username & ")", Cr.Username))
			Next
		Next
	End Sub
	Public Shared Sub LoadUserAdmin(dr As DropDownList, PortalId As Integer, ProvinID As Integer, DistrictID As Integer, subMod As String, Optional ByVal text As String = "- - - Chọn - - -")
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As DnnInfo In flDnn.DNN_UserConfig_List_By_Index(PortalId, ProvinID, DistrictID, subMod)
			dr.Items.Add(New ListItem(Ci.DisplayName, Ci.Username))
		Next
	End Sub
	Public Shared Sub LoadSubMod(PortalId As Integer, dr As DropDownList, Optional ByVal getID As Boolean = True, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_SubMod_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_SubMod_List(PortalId)
			flCache.SetCache("CMS_SubMod_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_SubMod_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		If getID = True Then
			For Each Ci As CMS_SubModInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveHTML(Ci.SubMod_Name), Ci.SubMod_ID))
			Next
		Else
			For Each Ci As CMS_SubModInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveHTML(Ci.SubMod_Name), Ci.SubMod_Path))
			Next
		End If
	End Sub
	Public Shared Sub LoadAllSubMod(PortalId As Integer, dr As DropDownList, isActive As Integer, Optional ByVal getID As Boolean = True, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_SubMod_List_All_" & PortalId & isActive)) Then
			arrTemp1 = flDnn.CMS_SubMod_ListActive(PortalId, isActive)
			flCache.SetCache("CMS_SubMod_List_All_" & PortalId & isActive, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_SubMod_List_All_" & PortalId & isActive), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		If getID = True Then
			For Each Ci As CMS_SubModInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveHTML(Ci.SubMod_Name), Ci.SubMod_ID))
			Next
		Else
			For Each Ci As CMS_SubModInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveHTML(Ci.SubMod_Name), Ci.SubMod_Path))
			Next
		End If
	End Sub
	Private Shared Sub LoadRegional(PortalId As Integer, regional_ID As Integer, strO As String)
		For Each Cis As CMS_RegionalInfo In flDnn.CMS_Regional_Get_By_CMS_Regional(PortalId, regional_ID)
			If strO = "" Then strO = "|--- "
			strOld = strO & "|--- "
			Cis.Regional_Name = strOld & " " & flReg.RemoveScript(Cis.Regional_Name, False)
			arrTemp1.Add(Cis)
			Call LoadRegional(PortalId, Cis.Regional_ID, strOld)
		Next
	End Sub
	Public Shared Sub LoadRegional_Parent_Null(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn tỉnh - - -", Optional ByVal Types As String = "TP")
		dr.Items.Clear()
		If Types = "TP" And UserInfo.Username <> "host" Then
			strOld = flReg.ProvinND(PortalId, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
                    dr.Items.Add(New ListItem(flDic.Regional_Name(PortalId, str(i)).Replace("Thành phố ", "").Replace("Tỉnh ", ""), str(i)))
                End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId)) Then
				arrTemp1 = flDnn.CMS_Regional_List_Parent_Null(PortalId)
				flCache.SetCache("CMS_Regional_List_Parent_Null_" & PortalId, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId), ArrayList)
			End If
			If text = "ALL" Then
                dr.Items.Add(New ListItem("Tất cả tỉnh thành", 0))
            ElseIf text <> "" Then
                dr.Items.Add(New ListItem(text, ""))
            End If
			For Each Ci As CMS_RegionalInfo In arrTemp1
                dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False).Replace("Thành phố ", "").Replace("Tỉnh ", ""), Ci.Regional_ID))
            Next
		End If
	End Sub
	Public Shared Sub LoadRegional_Parent_ID(PortalId As Integer, dr As DropDownList, Parent_ID As String, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal Types As String = "[QH][XP][THON]")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		dr.Items.Clear()
		If Types = "QH" And UserInfo.Username <> "host" Then
			strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.Regional_Name(PortalId, str(i)), str(i)))
				End If
			Next
		ElseIf Types = "XP" And UserInfo.Username <> "host" Then
			strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) <> 0 Then
					dr.Items.Add(New ListItem(flDic.Regional_Name(PortalId, str(i)), str(i)))
				End If
			Next
		End If
		If dr.Items.Count = 0 Then
			If IsNothing(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID)) Then
				arrTemp1 = flDnn.CMS_Regional_Get_By_CMS_Regional(PortalId, Parent_ID)
				flCache.SetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID, arrTemp1)
			Else
				arrTemp1 = CType(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID), ArrayList)
			End If
			If text <> "" Then dr.Items.Add(New ListItem(text, ""))
			For Each Ci As CMS_RegionalInfo In arrTemp1
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
			Next
		End If
	End Sub
	Public Shared Sub LoadRegional_Parent_Null_ChecboxList(PortalId As Integer, dr As CheckBoxList)
		If IsNothing(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Regional_List_Parent_Null(PortalId)
			flCache.SetCache("CMS_Regional_List_Parent_Null_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		For Each Ci As CMS_RegionalInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.ProvinND(PortalId, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			dr.SelectedValue = strOld
			dr.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegional_Parent_Null_RadioButtonList(PortalId As Integer, dr As RadioButtonList)
		If IsNothing(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Regional_List_Parent_Null(PortalId)
			flCache.SetCache("CMS_Regional_List_Parent_Null_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Regional_List_Parent_Null_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		For Each Ci As CMS_RegionalInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		strOld = flReg.ProvinND(PortalId, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		If strOld <> "-1" And strOld <> "0" Then
			dr.SelectedValue = strOld
			dr.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegional_Parent_ID_RadioButtonList(PortalId As Integer, chkL As RadioButtonList, Parent_ID As String, Optional ByVal Types As String = "[QH][XP][THON]")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_Regional_Get_By_CMS_Regional(PortalId, Parent_ID)
			flCache.SetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		If Types = "QH" Then
			strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		ElseIf Types = "XP" Then
			strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		Else
			strOld = "0"
		End If
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadRegional_Parent_ID_CheckBoxList(PortalId As Integer, chkL As CheckBoxList, Parent_ID As String, Optional ByVal Types As String = "[QH][XP][THON]")
		Parent_ID = flReg.WriteNumber(Parent_ID)
		If IsNothing(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID)) Then
			arrTemp1 = flDnn.CMS_Regional_Get_By_CMS_Regional(PortalId, Parent_ID)
			flCache.SetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Regional_Get_By_CMS_Regional_" & PortalId & "_" & Parent_ID), ArrayList)
		End If
		chkL.Items.Clear()
		For Each Ci As CMS_RegionalInfo In arrTemp1
			chkL.Items.Add(New ListItem(flReg.RemoveScript(Ci.Regional_Name, False), Ci.Regional_ID))
		Next
		If Types = "QH" Then
			strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		ElseIf Types = "XP" Then
			strOld = flReg.WardND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
		Else
			strOld = "0"
		End If
		If strOld <> "-1" And strOld <> "0" Then
			chkL.SelectedValue = strOld
			chkL.Enabled = False
		End If
	End Sub
	Public Shared Sub LoadNation(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal isCode As Boolean = False)
		If IsNothing(flCache.GetCache("CMS_Nation_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Nation_List(PortalId)
			flCache.SetCache("CMS_Nation_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Nation_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_NationInfo In arrTemp1
			If isCode Then
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Nation_Code & "--" & Ci.Nation_Name, False), Ci.Nation_ID))

			Else
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Nation_Name, False), Ci.Nation_ID))
			End If
		Next
	End Sub
	Public Shared Sub LoadLanguage(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_Language_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Language_List(PortalId)
			flCache.SetCache("CMS_Language_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Language_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_LanguageInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Language_Name, False), Ci.Language_ID))
		Next
	End Sub
	Public Shared Sub LoadEducation(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal isCode As Boolean = False)
		If IsNothing(flCache.GetCache("CMS_Education_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Education_List(PortalId)
			flCache.SetCache("CMS_Education_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Education_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_EducationInfo In arrTemp1
			If isCode Then
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Education_Code & "--" & Ci.Education_Name, False), Ci.Education_ID))
			Else
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Education_Name, False), Ci.Education_ID))
			End If
		Next
	End Sub
	Public Shared Sub LoadCheckList(chkL As CheckBoxList, arr As ArrayList)
		chkL.Items.Clear()
		For Each cr As Object In arr
			chkL.Items.Add(New ListItem(cr.Name, cr.ID))
		Next
	End Sub
	Public Shared Sub LoadDropList(chkL As DropDownList, arr As ArrayList, Optional prefix As Boolean = False, Optional all As String = "")
		chkL.Items.Clear()
		If all <> "" Then chkL.Items.Add(New ListItem(all, 0))
		For Each cr As Object In arr
			If prefix Then
				chkL.Items.Add(New ListItem(cr.Code & "." & cr.Name, cr.ID))
			Else
				chkL.Items.Add(New ListItem(cr.Name, cr.ID))
			End If
		Next
	End Sub
	Public Shared Sub SetCheckList(chkL As CheckBoxList, arrValue As String)
		Dim item As ListItem = Nothing
		arrValue.Split(",")
		For i = 0 To arrValue.Count - 1
			If String.IsNullOrEmpty(arrValue(i)) = False Then
				item = chkL.Items.FindByValue(arrValue(i))
				If IsNothing(item) = False Then
					item.Selected = True
				End If
			End If
		Next
	End Sub
	Public Shared Function GetCheckList(chkL As CheckBoxList) As String
		GetCheckList = ""
		For Each cr As ListItem In chkL.Items
			If cr.Selected Then
				GetCheckList += cr.Value & ","
			End If
		Next
	End Function
	Public Shared Sub LoadRadioList(chkL As RadioButtonList, arr As ArrayList)
		chkL.Items.Clear()
		For Each cr As Object In arr
			chkL.Items.Add(New ListItem(cr.Name, cr.ID))
		Next
	End Sub
	Public Shared Sub LoadThoiGianThatNghiep(ByVal drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		drGroup.Items.Clear()
		If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
		drGroup.Items.Add(New ListItem("1. Từ 1 tháng đến dưới 3 tháng", ThoiGianThatNghiep.Duoi3Thang))
		drGroup.Items.Add(New ListItem("2. Từ 3 tháng đến dưới 6 tháng", ThoiGianThatNghiep.BaThangDen6Thang))
		drGroup.Items.Add(New ListItem("3. Từ 6 tháng đến dưới 1 năm", ThoiGianThatNghiep.SauThangDen1Nam))
		drGroup.Items.Add(New ListItem("4. Trên 1 năm", ThoiGianThatNghiep.Tren1Nam))
	End Sub
	Public Shared Sub LoadKhaNangSuDung(ByVal drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		drGroup.Items.Clear()
		If text <> "" Then drGroup.Items.Add(New ListItem(text, ""))
		drGroup.Items.Add(New ListItem("Tốt", KhaNangSuDung.Tot))
		drGroup.Items.Add(New ListItem("Khá", KhaNangSuDung.Kha))
		drGroup.Items.Add(New ListItem("Trung bình", KhaNangSuDung.TrungBinh))
	End Sub
	Public Shared Sub Load_Method(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		dr.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_Method_" & PortalId)) Then
			arrTemp = flDnn.CMS_Method_List(PortalId)
			flCache.SetCache("CMS_Method_" & PortalId, arrTemp)
		Else
			arrTemp = CType(flCache.GetCache("CMS_Method_" & PortalId), ArrayList)
		End If
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_MethodInfo In arrTemp
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Method_Code & "--" & Ci.Method_Name, False), Ci.Method_ID))
		Next
	End Sub
	Public Shared Sub LoadKhuCongNghiep(PortalId As Integer, dr As DropDownList, tinhTp As Integer, quanHuyen As Integer, Optional ByVal text As String = "- - - Chọn - - -")
		dr.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_KhuCongNghiep" & PortalId)) Then
			arrTemp = flDnn.CMS_KhuCongNghiep_List_ByTP(PortalId, tinhTp, quanHuyen, "")
			flCache.SetCache("CMS_KhuCongNghiep_" & PortalId & "_" & tinhTp, arrTemp)
		Else
			arrTemp = CType(flCache.GetCache("CMS_KhuCongNghiep_" & PortalId & "_" & tinhTp), ArrayList)
		End If
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_KhuCongNghiepInfo In arrTemp
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.IndustrialZone_Name, False), Ci.IndustrialZone_ID))
		Next
	End Sub
	'Public Shared Sub LoadTypeEco(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
	'	dr.Items.Clear()
	'	If IsNothing(flCache.GetCache("CMS_TypeEco_" & PortalId)) Then
	'		arrTemp = flDnn.CMS_TypeEco_List(PortalId)
	'		flCache.SetCache("CMS_TypeEco_" & PortalId, arrTemp)
	'	Else
	'		arrTemp = CType(flCache.GetCache("CMS_TypeEco_" & PortalId), ArrayList)
	'	End If
	'	If text <> "" Then dr.Items.Add(New ListItem(text, ""))
	'	For Each Ci As CMS_TypeEcoInfo In arrTemp
	'		dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.TypeEco_Code & "--" & Ci.TypeEco_Name, False), Ci.TypeEco_ID))
	'	Next
	'End Sub
	Public Shared Sub LoadArea(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal isCode As Boolean = False)
		If IsNothing(flCache.GetCache("CMS_Area_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Area_List(PortalId)
			flCache.SetCache("CMS_Area_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Area_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_AreaInfo In arrTemp1
			If isCode Then
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Area_Code & "--" & Ci.Area_Name, False), Ci.Area_ID))
			Else
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Area_Name, False), Ci.Area_ID))
			End If
		Next
	End Sub
	Public Shared Sub LoadRelation(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional ByVal isCode As Boolean = False)
		If IsNothing(flCache.GetCache("CMS_Relation_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Relation_List(PortalId)
			flCache.SetCache("CMS_Relation_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Relation_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_RelationInfo In arrTemp1
			If isCode Then
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Relation_Code & "--" & Ci.Relation_Name, False), Ci.Relation_ID))
			Else
				dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Relation_Name, False), Ci.Relation_ID))
			End If
		Next
	End Sub
	Public Shared Sub LoadPosition(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_Position_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Position_List(PortalId)
			flCache.SetCache("CMS_Position_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Position_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_PositionInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Position_Name, False), Ci.Position_ID))
		Next
	End Sub
	Public Shared Sub LoadReligion(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_Religion_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Religion_List(PortalId)
			flCache.SetCache("CMS_Religion_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Religion_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_ReligionInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Religion_Name, False), Ci.Religion_ID))
		Next
	End Sub
	Public Shared Sub LoadNational(PortalId As Integer, dr As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		If IsNothing(flCache.GetCache("CMS_National_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_National_List(PortalId)
			flCache.SetCache("CMS_National_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_National_List_" & PortalId), ArrayList)
		End If
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_NationalInfo In arrTemp1
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.National_Name, False), Ci.National_ID))
		Next
	End Sub
	Public Shared Sub LoadPlace(PortalId As Integer, drGroup As DropDownList, Optional ByVal text As String = "- - - Chọn - - -")
		drGroup.Items.Clear()
		If IsNothing(flCache.GetCache("CMS_Place_List_" & PortalId)) Then
			arrTemp1 = flDnn.CMS_Place_List(PortalId, PortalId)
			flCache.SetCache("CMS_Place_List_" & PortalId, arrTemp1)
		Else
			arrTemp1 = CType(flCache.GetCache("CMS_Place_List_" & PortalId), ArrayList)
		End If
		drGroup.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_PlaceInfo In arrTemp1
			drGroup.Items.Add(New ListItem(flReg.RemoveScript(Ci.Place_Name, False), Ci.Place_ID))
		Next
	End Sub
	Public Shared Sub LoadSex(drPages As DropDownList, Optional ByVal text As String = "- - - Chọn - - -", Optional hasCode As Boolean = False)
		drPages.Items.Clear()
		If text <> "" Then drPages.Items.Add(New ListItem(text, -1))
		If hasCode Then
			drPages.Items.Add(New ListItem("1--Nam", "1"))
			drPages.Items.Add(New ListItem("0--Nữ", "0"))
		Else
			drPages.Items.Add(New ListItem("Nam", "1"))
			drPages.Items.Add(New ListItem("Nữ", "0"))
		End If
	End Sub
	Public Shared Sub LoadPageSize(drPages As DropDownList, Optional ByVal viewPublic As Boolean = False)
		drPages.Items.Clear()
		If viewPublic = False Then
			drPages.Items.Add(New ListItem("35", "35"))
			drPages.Items.Add(New ListItem("50", "50"))
			drPages.Items.Add(New ListItem("70", "70"))
			drPages.Items.Add(New ListItem("100", "100"))
			drPages.Items.Add(New ListItem("200", "200"))
		Else
			drPages.Items.Add(New ListItem("10", "10"))
			drPages.Items.Add(New ListItem("20", "20"))
			drPages.Items.Add(New ListItem("30", "30"))
			drPages.Items.Add(New ListItem("50", "50"))
		End If
	End Sub
	Public Shared Function Religion_Name(PortalId As Integer, Id As String) As String
		Religion_Name = flCache.GetCache("Religion_Name_" & PortalId & "_" & Id) & ""
		If Religion_Name = "" And Id <> "" Then
			Dim Info As CMS_ReligionInfo = flDnn.CMS_Religion_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Religion_Name = flReg.RemoveScript(Info.Religion_Name, False)
				flCache.SetCache("Religion_Name_" & PortalId & "_" & Id, Religion_Name)
			End If
		End If
	End Function
	Public Shared Function Nation_Name(PortalId As Integer, Id As String) As String
		Nation_Name = flCache.GetCache("Nation_Name_" & PortalId & "_" & Id) & ""
		If Nation_Name = "" And Id <> "" Then
			Dim Info As CMS_NationInfo = flDnn.CMS_Nation_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Nation_Name = flReg.RemoveScript(Info.Nation_Name, False)
				flCache.SetCache("Nation_Name_" & PortalId & "_" & Id, Nation_Name)
			End If
		End If
	End Function
	Public Shared Function Nation_Code(PortalId As Integer, Id As String) As String
		Nation_Code = flCache.GetCache("Nation_Code_" & PortalId & "_" & Id) & ""
		If Nation_Code = "" And Id <> "" Then
			Dim Info As CMS_NationInfo = flDnn.CMS_Nation_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Nation_Code = flReg.RemoveScript(Info.Nation_Code, False)
				flCache.SetCache("Nation_Code_" & PortalId & "_" & Id, Nation_Code)
			End If
		End If
	End Function
	Public Shared Function Relation_Name(PortalId As Integer, Id As String) As String
		Relation_Name = flCache.GetCache("Relation_Name_" & PortalId & "_" & Id) & ""
		If Relation_Name = "" And Id <> "" Then
			Dim Info As CMS_RelationInfo = flDnn.CMS_Relation_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Relation_Name = flReg.RemoveScript(Info.Relation_Name, False)
				flCache.SetCache("Relation_Name_" & PortalId & "_" & Id, Relation_Name)
			End If
		End If
	End Function
	Public Shared Function National_Name(PortalId As Integer, Id As String) As String
		National_Name = flCache.GetCache("National_Name_" & PortalId & "_" & Id) & ""
		If National_Name = "" And Id <> "" Then
			Dim Info As CMS_NationalInfo = flDnn.CMS_National_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				National_Name = flReg.RemoveScript(Info.National_Name, False)
				flCache.SetCache("National_Name_" & PortalId & "_" & Id, National_Name)
			End If
		End If
	End Function
	Public Shared Function Sex_Name(Id As Integer, Optional ByVal getImg As Boolean = False) As String
		If getImg = False Then
            If Id = 0 Then
                Return "Nữ"
            ElseIf Id = 1 Then
                Return "Nam"
            Else
                Return "Không yêu cầu"
            End If
		Else
            If Id = 0 Then
                Return "<i title=""Nữ"" class=""fa fa-female green"" aria-hidden=""True""></i>&nbsp;"
            ElseIf Id = 1 Then
                Return "<i title=""Nam"" class=""fa fa-male blue"" aria-hidden=""True""></i>&nbsp;"
            Else
                Return "<i class=""fa fa-venus-mars"" aria-hidden=""true""></i>&nbsp;"
            End If
		End If
	End Function
    Public Shared Function Regional_Name(PortalId As Integer, Id As String, Optional ByVal textNull As String = "Tất cả tỉnh/ thành phố", Optional ByVal replace As Boolean = False) As String
        Regional_Name = flCache.GetCache("Regional_Name_" & PortalId & "_" & Id & "_" & replace) & ""
        If Regional_Name = "" And Id <> "" Then
            Dim Info As CMS_RegionalInfo = flDnn.CMS_Regional_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Regional_Name = flReg.RemoveScript(Info.Regional_Name, False)
                If replace = True Then
                    Regional_Name = Regional_Name.Replace("Tỉnh ", "").Replace("Thành phố ", "TP.")
                    Regional_Name = Regional_Name.Replace("Quận ", "Q.").Replace("Huyện ", "")
                    Regional_Name = Regional_Name.Replace("Thị Xã ", "TX.").Replace("Xã ", "")
                    Regional_Name = Regional_Name.Replace("Phường ", "P.").Replace("Thị trấn ", "TT.")
                End If
                flCache.SetCache("Regional_Name_" & PortalId & "_" & Id & "_" & replace, Regional_Name)
            Else
                Regional_Name = textNull
            End If
        End If
    End Function
    Public Shared Function Regional_Area(PortalId As Integer, Id As String) As String
		Regional_Area = flCache.GetCache("Regional_Area_" & PortalId & "_" & Id) & ""
		If Regional_Area = "" And Id <> "" Then
			Dim Info As CMS_RegionalInfo = flDnn.CMS_Regional_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Regional_Area = flReg.RemoveScript(Info.AreaID, False)
				flCache.SetCache("Regional_Area_" & PortalId & "_" & Id, Regional_Area)
			Else
				Regional_Area = Id
			End If
		End If
	End Function
    Public Shared Function RegionalName(PortalId As Integer, tinhTP As String, quanHuyen As String) As String
        strOld = flCache.GetCache("RegionalName_" & PortalId & "_" & tinhTP & "_" & quanHuyen) & ""
        If strOld = "" Then
            If tinhTP <> "" Then
                str = tinhTP.Split(",") : strOld = ""
                For i As Integer = 0 To str.Length - 1
                    If flReg.WriteNumber(str(i)) > 0 Then
                        strOld += flDic.Regional_Name(PortalId, str(i), "", True) & "; "
                    End If
                Next
            ElseIf quanHuyen <> "" Then
                str = quanHuyen.Split(",")
                strOld = flDic.Regional_Name(PortalId, tinhTP, "", True) & ": "
                For i As Integer = 0 To str.Length - 1
                    If flReg.WriteNumber(str(i)) > 0 Then
                        strOld += flDic.Regional_Name(PortalId, str(i), "", True) & "; "
                    End If
                Next
            End If
            If strOld <> "" Then strOld = strOld.Substring(0, strOld.LastIndexOf(";")).Trim()
            flCache.SetCache("RegionalName_" & PortalId & "_" & tinhTP & "_" & quanHuyen, strOld)
        End If
        Return strOld
    End Function
    Public Shared Function Regional_Parent(PortalId As Integer, Id As String) As String
		Regional_Parent = flCache.GetCache("Regional_Parent_" & PortalId & "_" & Id)
		If Regional_Parent = "" Then
			Dim Info As CMS_RegionalInfo = flDnn.CMS_Regional_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Regional_Parent = flReg.RemoveScript(Info.Parent_ID, False)
				flCache.SetCache("Regional_Parent_" & PortalId & "_" & Id, Regional_Parent)
			End If
		End If
	End Function
	Public Shared Function Regional_Code(PortalId As Integer, Id As String) As String
		Regional_Code = flCache.GetCache("Regional_Code_" & PortalId & "_" & Id)
		If Regional_Code = "" Then
			Dim Info As CMS_RegionalInfo = flDnn.CMS_Regional_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Regional_Code = flReg.RemoveScript(Info.Regional_Code, False)
				flCache.SetCache("Regional_Code_" & PortalId & "_" & Id, Regional_Code)
			End If
		End If
	End Function
    Public Shared Function Position_Name(PortalId As Integer, Id As String) As String
        Position_Name = flCache.GetCache("Position_Name_" & PortalId & "_" & Id) & ""
        If Position_Name = "" And Id <> "" Then
            Dim Info As CMS_PositionInfo = flDnn.CMS_Position_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Position_Name = flReg.RemoveScript(Info.Position_Name, False)
                flCache.SetCache("Position_Name_" & PortalId & "_" & Id, Position_Name)
            End If
        End If
    End Function
    Public Shared Function Position_Code(PortalId As Integer, Id As String) As String
        Position_Code = flCache.GetCache("Position_Code_" & PortalId & "_" & Id) & ""
        If Position_Code = "" And Id <> "" Then
            Dim Info As CMS_PositionInfo = flDnn.CMS_Position_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Position_Code = flReg.RemoveScript(Info.Position_Code, False)
                flCache.SetCache("Position_Code_" & PortalId & "_" & Id, Position_Code)
            End If
        End If
    End Function
    Public Shared Function SubMod_Name(PortalId As Integer, Id As Integer) As String
		SubMod_Name = flCache.GetCache("SubMod_Name_" & PortalId & "_" & Id) & ""
		If SubMod_Name = "" Then
			Dim Info As CMS_SubModInfo = flDnn.CMS_SubMod_Get(PortalId, Id)
			If IsNothing(Info) = False Then
				SubMod_Name = flReg.RemoveHTML(Info.SubMod_Name)
				flCache.SetCache("SubMod_Name_" & PortalId & "_" & Id, SubMod_Name)
			End If
		End If
	End Function
	Public Shared Function SubMod_ID(PortalId As Integer, tabName As String) As Integer
		SubMod_ID = flReg.WriteNumber(flCache.GetCache("SubMod_ID_" & PortalId & "_" & tabName))
		If SubMod_ID = 0 Then
			Dim Info As CMS_SubModInfo = flDnn.CMS_SubMod_Get_By_Path(PortalId, tabName)
			If IsNothing(Info) = False Then
				SubMod_ID = Info.SubMod_ID
				flCache.SetCache("SubMod_ID_" & PortalId & "_" & tabName, SubMod_ID)
			End If
		End If
	End Function
	Public Shared Function Language_Name(PortalId As Integer, Id As String) As String
		Language_Name = flCache.GetCache("Language_Name_" & PortalId & "_" & Id) & ""
		If Language_Name = "" And Id <> "" Then
			Dim Info As CMS_LanguageInfo = flDnn.CMS_Language_Get(PortalId, flReg.WriteNumber(Id))
			If IsNothing(Info) = False Then
				Language_Name = flReg.RemoveScript(Info.Language_Name, False)
				flCache.SetCache("Language_Name_" & PortalId & "_" & Id, Language_Name)
			End If
		End If
	End Function
    Public Shared Function Education_Name(PortalId As Integer, Id As String) As String
        Education_Name = flCache.GetCache("Education_Name_" & PortalId & "_" & Id) & ""
        If Education_Name = "" And Id <> "" Then
            Dim Info As CMS_EducationInfo = flDnn.CMS_Education_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Education_Name = flReg.RemoveScript(Info.Education_Name, False)
                flCache.SetCache("Education_Name_" & PortalId & "_" & Id, Education_Name)
            End If
        End If
    End Function
    Public Shared Function Education_Code(PortalId As Integer, Id As String) As String
        Education_Code = flCache.GetCache("Education_Code_" & PortalId & "_" & Id) & ""
        If Education_Code = "" And Id <> "" Then
            Dim Info As CMS_EducationInfo = flDnn.CMS_Education_Get(PortalId, flReg.WriteNumber(Id))
            If IsNothing(Info) = False Then
                Education_Code = flReg.RemoveScript(Info.Education_Code, False)
                flCache.SetCache("Education_Code_" & PortalId & "_" & Id, Education_Code)
            End If
        End If
    End Function
    Public Shared Function Place_Name(PortalId As Integer, Place_ID As String) As String
		Place_Name = flCache.GetCache("Place_Name" & PortalId & Place_ID) & ""
		If Place_Name = "" And Place_ID <> "" Then
			Dim Info As CMS_PlaceInfo = flDnn.CMS_Place_Get(PortalId, flReg.WriteNumber(Place_ID))
			If IsNothing(Info) = False Then
				Place_Name = flReg.RemoveScript(Info.Place_Name, False)
				flCache.SetCache("Place_Name" & PortalId & Place_ID, Place_Name)
			End If
		End If
	End Function
	Public Shared Function PhotoURLFile(username As String, PortalId As Integer) As String
		PhotoURLFile = flCache.GetCache("PhotoURLFile_" & username & "_" & PortalId) & ""
		If PhotoURLFile = "" Then
			Dim _user As UserInfo = UserController.GetUserByName(PortalId, username)
			If IsNothing(_user) = False Then
				PhotoURLFile = _user.Profile.PhotoURL.ToLower()
				If PhotoURLFile <> "/images/no_avatar.gif" And PhotoURLFile <> "" Then
					PhotoURLFile = PhotoURLFile.Substring(0, PhotoURLFile.LastIndexOf("?"))
					flCache.SetCache("PhotoURLFile_" & username & "_" & PortalId, PhotoURLFile.ToLower())
					Return PhotoURLFile
				Else
					Return "/image/images/noavatar.png"
				End If
			Else
				Return "/image/images/noavatar.png"
			End If
		End If
	End Function
	Public Shared Function Module_Parent(PortalID As Integer, subMod As String, ModuleSrc As String) As String
		Module_Parent = flCache.GetCache("Module_Parent" & ModuleSrc) & ""
		If Module_Parent = "" Then
			Dim mdInfo As CMS_ModuleInfo = flDnn.CMS_Module_Get(flConnect.DmConnect, subMod, flReg.Encrypt("1", ModuleSrc))
			If mdInfo IsNot Nothing Then
				Module_Parent = mdInfo.Parent_ID
				flCache.SetCache("Module_Parent" & ModuleSrc, Module_Parent)
			End If
		End If
	End Function
	Private Shared Function Parent_Name(PortalConnect As String, subMod As String, Parent_ID As String) As String
		Dim obj As CMS_ModuleInfo = flDnn.CMS_Module_Get_Parent_ID(PortalConnect, subMod, Parent_ID)
		If IsNothing(obj) = False Then Return "<span class='span-title'>" & obj.ModuleName & "</span>: "
		Return ""
	End Function
	Public Shared Function ModuleName(PortalConnect As String, subMod As String, ModuleSrc As String) As String
		Dim obj As CMS_ModuleInfo = flDnn.CMS_Module_Get(PortalConnect, subMod, flReg.Encrypt("1", ModuleSrc))
		If IsNothing(obj) = False Then Return Parent_Name(PortalConnect, obj.SubMod, obj.Parent_ID) & obj.ModuleName
		Return ""
	End Function
	Public Shared Function Module_ID(PortalID As Integer, subMod As String, ModuleSrc As String) As String
		Module_ID = flCache.GetCache("Module_ID" & ModuleSrc & subMod) & ""
		If Module_ID = "" Then
			Dim mdInfo As CMS_ModuleInfo = flDnn.CMS_Module_Get(flConnect.DmConnect, subMod, flReg.Encrypt("1", ModuleSrc))
			If mdInfo IsNot Nothing Then
				Module_ID = mdInfo.Module_ID
				flCache.SetCache("Module_ID" & Module_ID & subMod, Module_ID)
			End If
		End If
	End Function
	Public Shared Function GetLanguage() As String
		Return System.Threading.Thread.CurrentThread.CurrentCulture.ToString()
	End Function
	Public Shared Function FileName(FileID As String) As String
		For Each Cr As DnnInfo In flDnn.DNN_Files_Get_By_FileID(FileID)
			Return Cr.FileName
		Next
		Return ""
	End Function
	Public Shared Function FileID(FileName As String, IsSuperUser As Boolean) As String
		FileName = FileName.Substring(FileName.LastIndexOf("/") + 1)
		If IsSuperUser = True Then
			arrTemp = flDnn.DNN_Files_Get_By_FileName(-1, FileName)
		Else
			arrTemp = flDnn.DNN_Files_Get_By_FileName(flConnect.PortalId, FileName)
		End If
		For Each Cr As DnnInfo In arrTemp
			Return Cr.FileID
		Next
		Return ""
	End Function
	Public Shared Function Security(PortalConnect As String, UserName As String, subMod As String, src As String) As Boolean
		If UserName = "host" Or UserName = "admin" Or UserName = "-1" Then
			Return True
		Else
			Dim dicInfo As CMS_UserConfigInfo = flDnn.CMS_UserConfig_Get_By_ModuleSrc(PortalConnect, subMod, UserName, flReg.Encrypt("1", src), flReg.ProvinND(0, UserInfo.Username, subMod))
			If IsNothing(dicInfo) = False Then
				Return True
			Else
				Dim tbMo As CMS_ModuleInfo = flDnn.CMS_Module_Get(PortalConnect, subMod, flReg.Encrypt("1", src))
				If IsNothing(tbMo) = False Then
					If tbMo.IsAdmin = False And tbMo.IsUser = False And tbMo.Status = False Then
						Return True
					Else
						Return False
					End If
				Else
					Return False
				End If
			End If
		End If
	End Function
	Public Shared Function Address(PortalId As Integer, thon As String, phuong As String, quan As String, tinh As String) As String
		Address = ""
		phuong = Regional_Name(PortalId, phuong, "", True)
		quan = Regional_Name(PortalId, quan, "", True)
		tinh = Regional_Name(PortalId, tinh, "", True)
		thon = Regional_Name(PortalId, thon, "")
        If thon <> "" Then Address += thon & ", "
        If phuong <> "" Then Address += phuong
        If quan <> "" Then Address += ", " & quan
        If tinh <> "" Then Address += ", " & tinh
    End Function
	Public Shared Function Address(PortalId As Integer, soNha As String, thon As String, phuong As String, quan As String, tinh As String) As String
		Address = ""
		phuong = Regional_Name(PortalId, phuong, "", True)
		quan = Regional_Name(PortalId, quan, "", True)
		tinh = Regional_Name(PortalId, tinh, "", True)
		thon = Regional_Name(PortalId, thon, "")
		If soNha <> "" Then Address += soNha & ", "
		If thon <> "" Then Address += thon & ", "
		If phuong <> "" Then Address += phuong & ", "
		If quan <> "" Then Address += quan & ", "
		Address = Address & tinh
	End Function
	Public Shared Function IsSuper(pid As Integer, UserName As String, tabName As String) As String
		If UserName = "host" Or UserName = "admin" Then
			Return "true"
		Else
			If flReg.IsInRole(pid, UserName, tabName, "Manager") = True Then
				Return "true"
			Else
				Return UserName
			End If
		End If
	End Function
	Public Shared Function Sex_ID(name As String) As Integer
		If name = "Nữ" Then
			Return 0
		Else
			Return 1
		End If
	End Function
	Public Shared Function Regional_ID(PortalId As Integer, name As String) As Integer
		Regional_ID = flReg.WriteNumber(flCache.GetCache("Regional_ID_" & PortalId & "_" & name) & "")
		If Regional_ID = 0 Then
			name = name.Trim()
			Dim Info As New CMS_RegionalInfo
			Info = flDnn.CMS_Regional_Get_By_Name(PortalId, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_Regional_Get_By_Name(PortalId, name)
			If IsNothing(Info) = False Then
				Regional_ID = Info.Regional_ID
				flCache.SetCache("Regional_ID_" & PortalId & "_" & name, Regional_ID)
			End If
		End If
	End Function
	Public Shared Function Regional_ID_ByCode(PortalId As Integer, code As String) As Integer
		Regional_ID_ByCode = flReg.WriteNumber(flCache.GetCache("Regional_ID_ByCode_" & PortalId & "_" & code) & "")
		If Regional_ID_ByCode = 0 Then
			Dim Info As New CMS_RegionalInfo
			Info = flDnn.CMS_Regional_Get_By_Code(PortalId, code.Trim())
			If IsNothing(Info) = False Then
				Regional_ID_ByCode = Info.Regional_ID
				flCache.SetCache("Regional_ID_ByCode_" & PortalId & "_" & code, Regional_ID_ByCode)
			End If
		End If
	End Function
	Public Shared Function Regional_ID(PortalId As Integer, parentID As String, name As String) As Integer
		Regional_ID = flReg.WriteNumber(flCache.GetCache("Regional_ID_" & parentID & "_" & PortalId & "_" & name) & "")
		If Regional_ID = 0 Then
			name = name.Trim()
			Regional_ID = flDnn.CMS_Regional_Get_Name_Parent(PortalId, parentID, flReg.RemoveScript(name))
			If Regional_ID = 0 Then Regional_ID = flDnn.CMS_Regional_Get_Name_Parent(PortalId, parentID, name)
			flCache.SetCache("Regional_ID_" & parentID & "_" & PortalId & "_" & name, Regional_ID)
		End If
	End Function
	Public Shared Function Regional_AreaID(PortalId As Integer, id As String) As Integer
		Regional_AreaID = flReg.WriteNumber(flCache.GetCache("Regional_AreaID_" & PortalId & "_" & id) & "")
		If Regional_AreaID = 0 Then
			Dim Info As CMS_RegionalInfo = flDnn.CMS_Regional_Get(PortalId, id)
			If IsNothing(Info) = False Then
				Regional_AreaID = Info.AreaID
				flCache.SetCache("Regional_AreaID_" & PortalId & "_" & id, Regional_AreaID)
			End If
		End If
	End Function
	Public Shared Function Position_ID(PortalId As Integer, name As String) As Integer
		Position_ID = flReg.WriteNumber(flCache.GetCache("Position_ID_" & PortalId & "_" & name) & "")
		If Position_ID = 0 Then
			Dim Info As New CMS_PositionInfo
			Info = flDnn.CMS_Position_Get_By_Name(PortalId, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_Position_Get_By_Name(PortalId, name)
			If IsNothing(Info) = False Then
				Position_ID = Info.Position_ID
				flCache.SetCache("Position_ID_" & PortalId & "_" & name, Position_ID)
			End If
		End If
	End Function
	Public Shared Function Place_ID(PortalId As Integer, name As String) As Integer
		Place_ID = flReg.WriteNumber(flCache.GetCache("Place_ID_" & PortalId & "_" & name) & "")
		If Place_ID = 0 Then
			Dim Info As New CMS_PlaceInfo
			Info = flDnn.CMS_Place_Get_By_Name(PortalId, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_Place_Get_By_Name(PortalId, name)
			If IsNothing(Info) = False Then
				Place_ID = Info.Place_ID
				flCache.SetCache("Place_ID_" & PortalId & "_" & name, Place_ID)
			End If
		End If
	End Function
	Public Shared Function Nation_ID(PortalId As Integer, name As String) As Integer
		Nation_ID = flReg.WriteNumber(flCache.GetCache("Nation_ID_" & PortalId & "_" & name) & "")
		If Nation_ID = 0 Then
			Dim Info As New CMS_NationInfo
			Info = flDnn.CMS_Nation_Get_By_Name(PortalId, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_Nation_Get_By_Name(PortalId, name)
			If IsNothing(Info) = False Then
				Nation_ID = Info.Nation_ID
				flCache.SetCache("Nation_ID_" & PortalId & "_" & name, Nation_ID)
			End If
		End If
	End Function
	Public Shared Function Religion_ID(PortalId As Integer, name As String) As Integer
		Religion_ID = flReg.WriteNumber(flCache.GetCache("Religion_ID_" & PortalId & "_" & name) & "")
		If Religion_ID = 0 Then
			Dim Info As New CMS_ReligionInfo
			Info = flDnn.CMS_Religion_Get_By_Name(PortalId, flReg.RemoveScript(name))
			If IsNothing(Info) = True Then Info = flDnn.CMS_Religion_Get_By_Name(PortalId, name)
			If IsNothing(Info) = False Then
				Religion_ID = Info.Religion_ID
				flCache.SetCache("Religion_ID_" & PortalId & "_" & name, Religion_ID)
			End If
		End If
	End Function
	Public Shared Sub ActiveKTXH(tinhTP As Integer, quanHuyen As Integer)
		strOld = flCache.GetCache("ActiveKTXH_" & tinhTP & "_" & quanHuyen & "_" & flReg.UrlAlias) & ""
		If strOld = "" Then
			Dim obj As CMS_ActiveDomainInfo = flDnn.CMS_ActiveDomain_Check_Active(0, tinhTP, quanHuyen, flReg.UrlAlias)
			If IsNothing(obj) = False Then
				flCache.SetCache("ActiveKTXH_" & tinhTP & "_" & quanHuyen & "_" & flReg.UrlAlias, "done", SecondCache.M60)
			Else
				flCache.SetCache("ActiveKTXH_" & tinhTP & "_" & quanHuyen & "_" & "_" & flReg.UrlAlias, "watting", SecondCache.M60)
				Redirect("/404.aspx", True)
			End If
		ElseIf strOld = "watting" Then
			Redirect("/404.aspx", True)
		End If
	End Sub
	Public Shared Sub KTXHConnect(request As HttpRequest)
		If UserInfo.Username = "host" Then Exit Sub
		If flReg.WriteNumber(request.Item("tp")) > 0 Then
			If flReg.WriteNumber(request.Item("qh")) > 0 Then
				Call ActiveKTXH(request.Item("tp"), request.Item("qh"))
			Else
				strOld = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
				str = strOld.Split(";")
				For i As Integer = 0 To str.Length - 1
					If flReg.WriteNumber(str(i)) > 0 Then Call ActiveKTXH(request.Item("tp"), str(i))
				Next
			End If
		Else
			strOld = flReg.ProvinND(0, UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str = strOld.Split(";")

			strOld1 = flReg.DistrictND(UserInfo.Username, PortalSettings.Current.ActiveTab.TabName)
			str1 = strOld1.Split(";")
			For i As Integer = 0 To str.Length - 1
				If flReg.WriteNumber(str(i)) > 0 Then
					For j As Integer = 0 To str1.Length - 1
						If flReg.WriteNumber(str1(j)) > 0 Then Call ActiveKTXH(str(i), str1(j))
					Next
				End If
			Next
		End If
	End Sub
	Public Shared Sub LoadYear(dr As DropDownList, fromYear As Integer, toYear As Integer, Optional ByVal all As Boolean = True)
		dr.Items.Clear()
		If all = True Then dr.Items.Add(New ListItem("- - Chọn - -", 0))
		For i As Integer = fromYear To toYear
			dr.Items.Add(New ListItem(i, i))
		Next
		If all = False Then dr.SelectedValue = Now.Year
	End Sub
	Public Shared Sub LoadMonth(dr As DropDownList, Optional ByVal all As Boolean = True)
		dr.Items.Clear()
		If all = True Then dr.Items.Add(New ListItem("- - Chọn - -", 0))
		For i As Integer = 1 To 12
			dr.Items.Add(New ListItem(i, i))
		Next
		If all = False Then dr.SelectedValue = Now.Month
	End Sub
	Public Shared Sub LoadDay(dr As DropDownList, Optional ByVal all As Boolean = True)
		dr.Items.Clear()
		If all = True Then dr.Items.Add(New ListItem("- - Chọn - -", 0))
		For i As Integer = 1 To 31
			dr.Items.Add(New ListItem(i, i))
		Next
		If all = False Then dr.SelectedValue = Now.Day
	End Sub
	Public Shared Sub LoadDay(dr As DropDownList, nam As Integer, thang As Integer, Optional ByVal all As Boolean = True)
		dr.Items.Clear()
		If all = True Then dr.Items.Add(New ListItem("- - Chọn - -", 0))
		For i As Integer = 1 To DateTime.DaysInMonth(nam, thang)
			dr.Items.Add(New ListItem(i, i))
		Next
		If all = False Then dr.SelectedValue = Now.Day
	End Sub
	Public Shared Function getNgaySinh(pid As Integer, userName As String, Optional ByVal PortalConnect As String = "") As String
		getNgaySinh = flCache.GetCache("getNgaySinh_" & pid & "_" & userName) & ""
		If getNgaySinh = "" Then
			Dim ubj As CMSUserPortalInfo
			ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
			If IsNothing(ubj) Then
				ubj = flDnn.CMSUserPortal_Get_By_User(PortalConnect, userName, "", pid)
			End If
			If IsNothing(ubj) = False Then
				flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
				getNgaySinh = flReg.ReadDate(ubj.DateOfBirth, False)
				If getNgaySinh <> "" Then flCache.SetCache("getNgaySinh_" & pid & "_" & userName, getNgaySinh)
			End If
		End If
	End Function
	Public Shared Function getDiaChi(pid As Integer, userName As String, Optional ByVal PortalConnect As String = "") As String
		getDiaChi = flCache.GetCache("getDiaChi_" & pid & "_" & userName) & ""
		If getDiaChi = "" Then
			Dim ubj As CMSUserPortalInfo
			ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
			If IsNothing(ubj) Then
				ubj = flDnn.CMSUserPortal_Get_By_User(PortalConnect, userName, "", pid)
			End If
			If IsNothing(ubj) = False Then
				getDiaChi = ubj.Address
				flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
				If getDiaChi <> "" Then flCache.SetCache("getDiaChi_" & pid & "_" & userName, getDiaChi)
			End If
		End If
	End Function
	Public Shared Function getGioiTinh(pid As Integer, userName As String, Optional ByVal PortalConnect As String = "") As String
		getGioiTinh = flCache.GetCache("getGioiTinh_" & pid & "_" & userName) & ""
		If getGioiTinh = "" Then
			Dim ubj As CMSUserPortalInfo
			ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
			If IsNothing(ubj) Then
				ubj = flDnn.CMSUserPortal_Get_By_User(PortalConnect, userName, "", pid)
			End If

			If IsNothing(ubj) = False Then
				getGioiTinh = ubj.Gender
				flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
				If getGioiTinh <> "" Then flCache.SetCache("getGioiTinh_" & pid & "_" & userName, getGioiTinh)
			End If
		End If
	End Function
	Public Shared Function getTelephone(pid As Integer, userName As String, Optional ByVal PortalConnect As String = "") As String
		getTelephone = flCache.GetCache("getTelephone_" & pid & "_" & userName) & ""
		If getTelephone = "" Then
			Dim ubj As CMSUserPortalInfo
			ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
			If IsNothing(ubj) Then
				ubj = flDnn.CMSUserPortal_Get_By_User(PortalConnect, userName, "", pid)
			End If

			If IsNothing(ubj) = False Then
				getTelephone = ubj.Telephone
				flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
				If getTelephone <> "" Then flCache.SetCache("getTelephone_" & pid & "_" & userName, getTelephone)
			End If
		End If
	End Function
	Public Shared Function getEmail(pid As Integer, userName As String, Optional ByVal PortalConnect As String = "") As String
		getEmail = flCache.GetCache("getEmail_" & pid & "_" & userName) & ""
		If getEmail = "" Then
			Dim ubj As CMSUserPortalInfo
			ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
			If IsNothing(ubj) Then
				ubj = flDnn.CMSUserPortal_Get_By_User(PortalConnect, userName, "", pid)
			End If

			If IsNothing(ubj) = False Then
				getEmail = ubj.Email
				flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
				If getEmail <> "" Then flCache.SetCache("getEmail_" & pid & "_" & userName, getEmail)
			End If
		End If
	End Function
    Public Shared Function getHoTen(pid As Integer, userName As String, Optional ByVal portalConnnect As String = "") As String
        getHoTen = flCache.GetCache("getHoTen_" & pid & "_" & userName) & ""
        If getHoTen = "" Then
            Dim ubj As CMSUserPortalInfo
            ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
            If IsNothing(ubj) Then
                ubj = flDnn.CMSUserPortal_Get_By_User(portalConnnect, userName, "", pid)
            End If
            If IsNothing(ubj) = False Then
                flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
                getHoTen = ubj.DisplayName
                If getHoTen <> "" Then flCache.SetCache("getHoTen_" & pid & "_" & userName, getHoTen)
            End If
        End If
    End Function
    Public Shared Function getUserID(pid As Integer, userName As String, Optional ByVal portalConnnect As String = "") As String
        getUserID = flCache.GetCache("getUserID_" & pid & "_" & userName) & ""
        If getUserID = "" Then
            Dim ubj As CMSUserPortalInfo
            ubj = CType(flCache.GetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName), CMSUserPortalInfo)
            If IsNothing(ubj) Then
                ubj = flDnn.CMSUserPortal_Get_By_User(portalConnnect, userName, "", pid)
            End If
            If IsNothing(ubj) = False Then
                flCache.SetCache("CMSUserPortal_Get_By_User_" & pid & "_" & userName, ubj, SecondCache.M60) '30 phút
                getUserID = ubj.UserID
                If getUserID <> "" Then flCache.SetCache("getUserID_" & pid & "_" & userName, getUserID)
            End If
        End If
    End Function
    Public Shared Function getTuoi(ngaySinh As String) As String
		If (Now.Year - flReg.WriteDate(ngaySinh, False).Year) > 15 And flReg.WriteDate(ngaySinh, False).Year > 1945 Then
			Return (Now.Year - flReg.WriteDate(ngaySinh, False).Year)
		Else
			Return ""
		End If
	End Function
	Public Shared Function hideString(val As String, num As Integer, Optional ByVal index As String = "D,C") As String
		Try
			If val.Length > num Then
				If index = "D" Then
					Return "<span class='xhiend'>*****</span>" & val.Substring(num)
				Else
					Return val.Substring(0, val.Length - num) & "<span class='xhiend'>xxx</span>"
				End If
			ElseIf val.Length > 0 And val.Length < num Then
				If index = "D" Then
					Return "<span class='xhiend'>xxx</span>" & val.Substring(3)
				Else
					Return val.Substring(0, val.Length - 3) & "<span class='xhiend'>xxx</span>"
				End If
			Else
				Return ""
			End If
		Catch ex As Exception
			Return ""
		End Try
	End Function
	Public Shared Sub LoadRoles(dr As DropDownList, portalId As Integer, subMode As String, Optional ByVal text As String = "- - - Chọn - - -")
		dr.Items.Clear()
		If text <> "" Then dr.Items.Add(New ListItem(text, ""))
		For Each Ci As CMS_RolesInfo In flDnn.CMS_Roles_Get_By_CMS_SubMod(portalId, flReg.SubMod_ID(portalId, subMode))
			dr.Items.Add(New ListItem(flReg.RemoveScript(Ci.Roles_Name, False), Ci.Roles_ID))
		Next
	End Sub

End Class
Public Class helper
	Private Shared Sub ModuleAdd(CmsSqlServer As String, obj As CMS_ModuleInfo)
		DataProvider.Instance().CMS_Module_Add(CmsSqlServer, obj.SubMod, obj.Module_ID, obj.ModuleSrc, obj.ModuleName, obj.IsAdmin, obj.IsUser, obj.Status, obj.ctlView, obj.ctlEdit, obj.Img, obj.IsOrder, obj.Parent_ID)
	End Sub
	Private Shared Sub ModuleDelete(CmsSqlServer As String, module_ID As String)
		DataProvider.Instance().CMS_Module_Delete(CmsSqlServer, module_ID)
	End Sub
	Private Shared Function Security(code As String) As Boolean
		If flReg.Decrypt("1", code) = "@vbn" & Now.Day & "cns" & Now.Month Then
			Return True
		Else
			Return False
		End If
	End Function
	Public Shared Function UpdateModule(CmsSqlServer As String, arr As ArrayList, KeyCode As String) As Boolean
		If (Security(KeyCode) = True) Then
			For Each Cr As CMS_ModuleInfo In arr
				If Cr.IsDelete = False And Cr.ModuleSrc <> "" And Cr.ModuleName <> "" Then
					ModuleAdd(CmsSqlServer, Cr)
				Else
					ModuleDelete(CmsSqlServer, Cr.Module_ID)
				End If
			Next
			Return True
		Else
			Return False
		End If
	End Function
	Public Shared Function ctlLoadPage(CmsSqlServer As String, subMod As String, ctlEdit As String, ctlView As String, Optional ByVal foleder As String = "CMS") As String
		ctlLoadPage = flCache.GetCache("ctlLoadPage_" & CmsSqlServer & "_" & subMod & "_" & ctlEdit & "_" & ctlView) & ""
		If ctlLoadPage = "" Then
			Dim dicInfo As New CMS_ModuleInfo()
			If ctlEdit <> "" Then
				dicInfo = flDnn.CMS_Module_Get(CmsSqlServer, subMod, flReg.Encrypt("1", ctlEdit))
				If IsNothing(dicInfo) = False Then
					ctlLoadPage = "\\DesktopModules\\" & foleder & "\\" & dicInfo.ctlEdit
				End If
			Else
				dicInfo = flDnn.CMS_Module_Get(CmsSqlServer, subMod, flReg.Encrypt("1", ctlView))
				If IsNothing(dicInfo) = False Then
					ctlLoadPage = "\\DesktopModules\\" & foleder & "\\" & dicInfo.ctlView
				End If
			End If

			If ctlLoadPage = "" Then
				ctlLoadPage = "\\DesktopModules\\" & foleder & "\\Main\\CMS_HomeView.ascx"
			Else
				flCache.SetCache("ctlLoadPage_" & CmsSqlServer & "_" & subMod & "_" & ctlEdit & "_" & ctlView, ctlLoadPage)
			End If
		End If
	End Function
	Public Shared Function ResetPass(IdKey As String) As String
		Dim _user As New UserInfo()
		Dim arrTemp As New ArrayList()
		Dim HTTPAlias = flReg.UrlAlias()
		''Dim PortalName = "Cổng thông tin việc làm"
		Dim PortalName = flReg.WebConfig("TenDonVi")
		Dim PortalId = flConnect.PortalId
		Dim IsLang = "en-US"
		Dim str As String = ""
		Try
			If Security(IdKey) = True Then
				'Tài khoản host
				_user = UserController.GetUserByName(PortalId, "host")
				_user.Membership.Password = UserController.GeneratePassword()
				UserController.ResetPassword(_user, "")
				UserController.ResetPasswordToken(_user)
				flDnn.DNN_UpdateRestPassWord(IdKey)

				str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
				str += "Xin chào <strong>" & _user.DisplayName & ",</strong><p></p>"
				str += "Bạn đã sử dụng chức năng lấy lại mật khẩu của <strong>" & PortalName & "</strong><br/>"
				str += "Mật khẩu mới của bạn là: <strong>" & _user.Membership.Password & "</strong><br/>"
				str += "Vui lòng <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>đăng nhập</a>"
				str += " vào hệ thống và thay đổi lại mật khẩu truy cập của bạn. <p/><p></p>"
				str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"

				Dim subject As String = String.Format("Lấy lại mật khẩu - {0}", PortalName)
				Dim Content As String = ContentMail()
				Content = Content.Replace("[DisplayName]", _user.DisplayName)
				Content = Content.Replace("[PortalName]", PortalName)
				Content = Content.Replace("[HTTPAlias]", HTTPAlias)
				Content = Content.Replace("[Username]", _user.Username)
				Content = Content.Replace("[Email]", _user.Email)
				Content = Content.Replace("[Pass]", _user.Membership.Password)
				flDnn.DNN_SendMail("noreplyio.net@gmail.com", subject, Content)
			Else
				'Lấy lai mật khẩu
				arrTemp = flDnn.DNN_GetRestPassWord(IdKey, IsLang)
				If (arrTemp.Count > 0) Then
					'Có bản ghi lấy lại pas
					For Each Ci As DnnInfo In arrTemp
						'Vòng lặp kiểm tra
						PortalId = Ci.PortalID
						If ((Ci.IsReset = False) And (Ci.EndDate >= DateTime.Now)) Then
							'Kiểm tra link reset
							_user = UserController.GetUserByName(PortalId, Ci.Username)
							If ((_user.Email = Ci.Email) And (_user.IsDeleted = False)) Then
								'Kiểm tra tài khoản có bị khóa không
								_user.Membership.Password = UserController.GeneratePassword()
								UserController.ResetPassword(_user, "")
								UserController.ResetPasswordToken(_user)
								flDnn.DNN_UpdateRestPassWord(IdKey)
								str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
								str += "Xin chào <strong>" & _user.DisplayName & ",</strong><p></p>"
								str += "Bạn đã sử dụng chức năng lấy lại mật khẩu của <strong>" & PortalName & "</strong><br/>"
								str += "Mật khẩu mới của bạn là: <strong>" & _user.Membership.Password & "</strong><br/>"
								str += "Vui lòng <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>đăng nhập</a>"
								str += " vào hệ thống và thay đổi lại mật khẩu truy cập của bạn. <p/><p></p>"
								str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"

								Dim subject = String.Format("Lấy lại mật khẩu - {0}", PortalName)
								Dim Content = ContentMail()
								Content = Content.Replace("[DisplayName]", _user.DisplayName)
								Content = Content.Replace("[PortalName]", PortalName)
								Content = Content.Replace("[HTTPAlias]", HTTPAlias)
								Content = Content.Replace("[Username]", _user.Username)
								Content = Content.Replace("[Email]", _user.Email)
								Content = Content.Replace("[Pass]", _user.Membership.Password)
								flDnn.DNN_SendMail(_user.Email, subject, Content)
							Else
								'Tài khoản bị khóa
								str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
								str += "Xin chào <strong>" & _user.DisplayName & ",</strong><p></p>"
								str += "Bạn đã sử dụng chức năng lấy lại mật khẩu của <strong>" & PortalName & "</strong><br/>"
								str += "Thông tin bạn cung cấp để lấy lại mật khẩu không chính xác, vui lòng kiểm tra lại. <p/>"
								str += "Bấm <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>vào đây</a> để quay lại trang chủ.<p></p>"
								str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"
							End If
						Else
							'Link reset không đúng hoặc hết hạn
							str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
							str += "Xin chào <strong>" & Ci.Username & ",</strong><p></p>"
							str += "Bạn đã sử dụng chức năng lấy lại mật khẩu của <strong>" & PortalName & "</strong><br/>"
							str += "Thời hạn để lấy lại mật khẩu của đường dẫn này đã hết hạn, hoặc đường link đã được kích hoạt. Vui lòng kiểm tra lại. <p/><p></p>"
							str += "Bấm <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>vào đây</a> để quay lại trang chủ.<p></p>"
							str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"
						End If
					Next
				Else
					'Không có bản ghi nao
					str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
					str += "Not Found - Yêu cầu của bạn hệ thống không thấy, vui kiểm tra lại.<p></p>"
					str += "Bấm <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>vào đây</a> để quay lại trang chủ.<p></p>"
					str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"

				End If
			End If
		Catch ex As Exception
			'Lỗi lấy lại mật khẩu 
			str = "<div style='color: #444; font-size: 14px; font-family: arial;line-height: 24px;'>"
			str += "Not Found - Yêu cầu của bạn hệ thống chưa kịp xử lý, vui lòng quay lại sau.<p></p>"
			str += "Bấm <a style='font-size: 14px; font-family: arial;color: blue; font-weight: bold;' href='" & HTTPAlias & "'>vào đây</a> để quay lại trang chủ.<p></p>"
			str += "<p style='padding-top:10px'></p>Trân trọng,<br/>Ban quản trị</div>"

		End Try
		Return str
	End Function
	Public Shared Function ContentMail() As String
		Dim str As String = ""
		str = "<div style=""font-size: 14px; font-family: arial; border: 1px solid #ccc; padding: 10px;"">"
		str += "<div style=""padding:5px;padding-bottom:10px;"">Xin chào <span style=""font-weight: bold; color: green""> [DisplayName]</span>,</div>"
		str += "<div style=""padding5px;"">Bạn đã sử dụng chức năng lấy lại mật khẩu của <span style=""color green; font-weight: bold;"">[PortalName]</span></div>"
		str += "<div style=""padding5px;"">Tên tài khoản: <strong>[Username]</strong></div>"
		str += "<div style=""padding5px;"" > Địa chỉ email: <strong>[Email]</strong></div>"
		str += "<div style=""padding5px;"">Mật khẩu mới của bạn là: <strong>[Pass]</strong></div>"
		str += "<div style=""padding5px;"" > Vui lòng <a style=""font-weight:bold;"" href=""[HTTPAlias]"">đăng nhập</a> vào hệ thống và thay đổi lại mật khẩu truy cập của bạn.</div>"
		str += "<div style=""padding15px 5px;"">Trân trọng,</div>"
		str += "<div style=""padding:5px;font-weight: bold; color: green"">Ban quản trị</div>"
		Return str & "</div>"
	End Function
	Public Shared Function Module_ID(CmsSqlServer As String, subMod As String, ctlView As String) As String
		Module_ID = flCache.GetCache("Module_ID_" & CmsSqlServer & "_" & ctlView & subMod) & ""
		If Module_ID = "" Then
			Dim dicInfo = New CMS_ModuleInfo()
			If IsNothing(dicInfo) = False Then
				dicInfo = flDnn.CMS_Module_Get(CmsSqlServer, subMod, flReg.Encrypt("1", ctlView))
				Module_ID = dicInfo.Module_ID
			End If
			flCache.SetCache("Module_ID_" & CmsSqlServer & "_" & ctlView & subMod, Module_ID)
		End If
	End Function
	Private Shared charKhongDau() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
	Private Shared charKhongDau1() As String = {"a", "o", "e", "u", "i", "y", "d"}
	Public Shared Function KhongDau(_text As Object) As String
		If _text Is Nothing Then _text = ""
		If _text Is DBNull.Value Then _text = ""
		Dim str As String = _text.ToString.Replace("  ", " ").ToLower
		Dim strReturn As String = ""
		For i As Integer = 0 To str.Length - 1
			Dim iStr As String = str.Substring(i, 1)
			Dim rStr As String = iStr
			For j As Integer = 0 To charKhongDau.Length - 1
				If charKhongDau(j).IndexOf(iStr) >= 0 Then
					rStr = charKhongDau1(j)
					Exit For
				End If
			Next
			strReturn += rStr
		Next
		Return strReturn
	End Function
	Public Shared Function GetMaPhieu(portalId As Integer, idTinhTP As String, idHuyen As String, soThuTu As Integer) As String
		Dim _maPhieu = ""
		Try
			Dim _maTinh As String = flDic.RegionalTP_Code(portalId, idTinhTP)
			Dim _tenQH As String = helper.KhongDau(flDic.RegionalQH_Name(portalId, idHuyen).ToLower().Replace("quận", "").Replace("huyện", "").Replace("thành phố", "").Replace("thị xã", ""))
			Dim _tenKhongDau As String = ""
			If _tenQH <> "" Then
				Dim lstTenQH = _tenQH.Split(" ").ToList()
				For i As Integer = 0 To lstTenQH.Count - 1
					If lstTenQH(i) <> "" Then
						_tenKhongDau += lstTenQH(i).Substring(0, 1)
					End If
				Next i
			End If
			_maPhieu = _maTinh & _tenKhongDau.ToUpper() & Right("000" & soThuTu, 3)
		Catch ex As Exception
		End Try
		Return _maPhieu
	End Function
	Public Shared Function RandomEmail() As String
		RandomEmail = RandomString() & "@" & flReg.WebConfig("TenMien")
		Return RandomEmail
	End Function
	Public Shared Function RandomString(Optional len As Integer = 10) As String
		Dim str As String = "abcdefghijklmnopqrstuvwxyz0123456789"
		Dim r As New Random()
		Dim sb As New StringBuilder()
		For i As Integer = 1 To len
			Dim idx As Integer = r.Next(0, str.Length)
			sb.Append(str.Substring(idx, 1))
		Next
		RandomString = sb.ToString()
		Return RandomString
	End Function
End Class
Public Class bigCode

	Public Shared Function QRCode(code As String, UrlView As String, Optional ByVal ghepCode As Boolean = True) As String
		QRCode = flCache.GetCache("QRCodeImage_" & code) & ""
		If QRCode = "" Then
			Dim di1 As IO.DirectoryInfo = New IO.DirectoryInfo(Web.HttpContext.Current.Server.MapPath(flText.QR_CODE(0)))
			If Not di1.Exists Then di1.Create()
			Dim QRCodeEncoder As New QREncoder
			Dim QRCodeImage As Bitmap

			If code = "0000" Then
				QRCodeEncoder.Encode(ErrorCorrection.M, UrlView)
			ElseIf ghepCode = True Then
				QRCodeEncoder.Encode(ErrorCorrection.M, UrlView & code)
			Else
				QRCodeEncoder.Encode(ErrorCorrection.M, UrlView)
			End If

			QRCodeImage = QRCodeToBitmap.CreateBitmap(QRCodeEncoder, 3, 0)
			QRCodeImage.Save(Web.HttpContext.Current.Server.MapPath(flText.QR_CODE(0) & code & ".png"))
			flCache.SetCache("QRCodeImage_" & code, flText.QR_CODE(0) & code & ".png")
			Return flText.QR_CODE(0) & code & ".png"
		End If
	End Function
	Public Shared Function BARCode(code As String, Optional ByVal showText As Boolean = True) As String
		BARCode = flCache.GetCache("BarCodeImage_" & code) & ""
		If BARCode = "" Then
			Dim di1 As IO.DirectoryInfo = New IO.DirectoryInfo(Web.HttpContext.Current.Server.MapPath(flText.BAR_CODE(0)))
			If Not di1.Exists Then di1.Create()
			BarcodeSettings.ApplyKey("NNXRQ10XRU3-11R06-MFAUU-CYCC5")
			Dim settings As New BarcodeSettings()
			settings.Data = code
			settings.Data2D = code
			settings.Type = CType(System.Enum.Parse(GetType(BarCodeType), "Code128"), BarCodeType)
			settings.HasBorder = False
			settings.BorderDashStyle = CType(System.Enum.Parse(GetType(DashStyle), "Solid"), DashStyle)
			settings.TextFont = New Font("Tahoma", 8.5, FontStyle.Bold)
			settings.BarHeight = 10
			settings.ShowTextOnBottom = True
			settings.ShowText = showText
			Dim generator As New BarCodeGenerator(settings)
			Dim _barcode As System.Drawing.Image = generator.GenerateImage()
			_barcode.Save(Web.HttpContext.Current.Server.MapPath(flText.BAR_CODE(0) & code & ".png"))

			flCache.SetCache("BarCodeImage_" & code, flText.BAR_CODE(0) & code & ".png")
			Return flText.BAR_CODE(0) & code & ".png"
		End If
	End Function

End Class
Public Class Response
	Public Property data As Object
	Public Property status As Short
	Public Property message As String
End Class
Public Enum SecondCache
	S1 = 5
	S2 = 10
	S3 = 15
	S4 = 20
	S5 = 25
	S6 = 30
	S7 = 35
	S8 = 40
	S9 = 45
	S10 = 50

	M1 = 60
	M2 = 120
	M3 = 180
	M4 = 240
	M5 = 300
	M6 = 360
	M7 = 420
	M8 = 480
	M9 = 540
	M10 = 600
	M15 = 900
	M20 = 1200
	M25 = 1500
	M30 = 1800
	M35 = 2100

	M60 = 6000
End Enum
Public Enum ServiceStatus
	FAILED = 0
	NODATA
	SUCCESS
	EXCEPTION
End Enum
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
Public Class clsCompareFileInfo
	Implements IComparer
	Dim File1 As System.IO.FileInfo
	Dim File2 As System.IO.FileInfo
	Public Function Compare(x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
		File1 = DirectCast(x, System.IO.FileInfo)
		File2 = DirectCast(y, System.IO.FileInfo)
		Compare = DateTime.Compare(File2.CreationTime, File1.CreationTime)
	End Function
End Class
Public Enum ThoiGianThatNghiep
	Duoi3Thang = 1
	BaThangDen6Thang
	SauThangDen1Nam
	Tren1Nam
End Enum
Public Enum KhaNangSuDung
	Tot = 1
	Kha
	TrungBinh
End Enum