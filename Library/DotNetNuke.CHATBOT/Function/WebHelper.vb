Imports System.Collections.Specialized
Imports System.Globalization
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Entities.Users
Imports DotNetNuke.Security
Imports DotNetNuke.Security.Membership
Imports DotNetNuke.Services.Authentication
Imports DotNetNuke.UI.Utilities


Public NotInheritable Class WebHelper
        'Public Shared TCVN3CharCode As List(Of Integer) = "184, 181, 182, 183, 185, 168, 190, 187, 188, 189, 198,169, 202, 199, 200, 201, 203, 208, 204, 206, 207, 209, 170, 213, 210, 211, 212, 214, 221, 215, 216, 220, 222,	 227, 223, 225, 226, 228, 171, 232, 229, 230, 231, 233, 	 172, 237, 234, 235, 236, 238, 243, 239, 241, 242, 244, 	 173, 248, 245, 246, 247, 249, 253, 250, 251, 252, 254, 	 174, 184, 181, 182, 183, 185, 161, 190, 187, 188, 189, 198, 	 162, 202, 199, 200, 201, 203, 208, 204, 206, 207, 209, 163, 	 213, 210, 211, 212, 214, 221, 215, 216, 220, 222, 227, 223, 	 225, 226, 228, 164, 232, 229, 230, 231, 233, 165, 237, 234, 	 235, 236, 238, 243, 239, 241, 242, 244, 166, 248, 245, 246, 	 247, 249, 253, 250, 251, 252, 254, 167".Split(",").Select(Function(x) Integer.Parse(x.Trim)).ToList
        'Public Shared UnicodeCharCode As List(Of Integer) = "225, 224, 7843,227, 7841,259, 7855,7857,7859,7861,7863,226, 7845,7847,7849,7851,7853,233, 232, 7867,7869,7865,234, 7871,7873,7875,7877,7879,237, 236, 7881,297, 7883,243, 242, 	7887,245, 7885,244, 7889,7891,7893,7895,7897,417, 7899,7901,	7903,7905,7907,250, 249, 7911,361, 7909,432, 7913,7915,7917,	7919,7921,253, 7923,7927,7929,7925,273, 193, 192, 7842,195, 	7840,258, 7854,7856,7858,7860,7862,194, 7844,7846,7848,7850,	7852,201, 200, 7866,7868,7864,202, 7870,7872,7874,7876,7878,	205, 204, 7880,296, 7882,211, 210, 7886,213, 7884,212, 7888,	7890,7892,7894,7896,416, 7898,7900,7902,7904,7906,218, 217, 	7910,360, 7908,431, 7912,7914,7916,7918,7920,221, 7922,	7926,7928,7924,272".Split(",").Select(Function(x) Integer.Parse(x.Trim)).ToList
        Public Shared DATA_FOLDER_PATH As String = Hosting.HostingEnvironment.MapPath("/data")
        Private Shared charKhongDau() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
        Private Shared charKhongDau1() As String = {"a", "o", "e", "u", "i", "y", "d"}
        Public Shared Sub Log_File(strlog As String, Optional filename As String = "", Optional foldername As String = "", Optional strsep As String = "")
            Dim basefolder = DATA_FOLDER_PATH & "\logs"
            Dim default_filename = "log.txt"
            Dim default_sep = "--------------------------------------------------------------------------------------------------"

            If strsep = "" Then strsep = default_sep
            If filename = "" Then filename = default_filename
            foldername = IIf(foldername = "", DateTime.Now.ToString("yyyy_MM"), foldername & "\" & DateTime.Now.ToString("yyyy_MM"))
            Dim folderpath = IIf(foldername <> "", basefolder + "\" + foldername, basefolder)
            Ensure_Folder(folderpath)

            Dim filepath = folderpath + "\" + Path.GetFileName(filename).Replace(Path.GetExtension(filename), "") + "_" + DateTime.Now.ToString("dd") + Path.GetExtension(filename)

            Dim sw = File.AppendText(filepath)
            sw.WriteLine("--> " & DateTime.Now.ToString("dd/MM/yyyy hh:mm"))
            sw.WriteLine(strlog)
            sw.WriteLine(strsep)
            sw.WriteLine()
            sw.WriteLine()
            sw.Close()
        End Sub
        Public Shared Sub Calc_Total_Horizontal(dt As System.Data.DataTable, str_col_name As String, Optional total_col_name As String = "")
            Dim dr = dt.NewRow
            Dim list_col_name = str_col_name.Split(";").Where(Function(x) x.Trim <> "").ToList

            If total_col_name <> "" Then dr(total_col_name) = "Tổng"
            dt.Rows.Add(dr)

            For i = 0 To dt.Columns.Count - 1 Step 1
                Dim col_name = dt.Columns(i).ColumnName
                Dim col_data_type = dt.Columns(i).DataType
                Dim can_sum = False

                If list_col_name.Count > 0 Then
                    can_sum = list_col_name.Contains(col_name)
                Else
                    can_sum = col_data_type Is GetType(Int16) Or col_data_type Is GetType(Int32) Or col_data_type Is GetType(Int64) Or col_data_type Is GetType(Integer) Or col_data_type Is GetType(Double) Or col_data_type Is GetType(Decimal)
                End If

                If can_sum Then
                    dr(col_name) = dt.AsEnumerable.Sum(Function(x) WebHelper.Double_Parse(IIf(WebHelper.Double_Parse(x(col_name)) > 0.0, x(col_name), 0.0)))
                End If
            Next
        End Sub
        Public Shared Sub Calc_Total_Vertical(dt As System.Data.DataTable, str_col_name As String, total_col_name As String)
            Dim list_col_name = str_col_name.Split(";").Where(Function(x) x.Trim <> "").ToList
            For i = 0 To dt.Rows.Count - 1 Step 1
                Dim row = dt.Rows(i)
                Dim total = 0.0
                For col_index = 0 To list_col_name.Count - 1 Step 1
                    total += WebHelper.Double_Parse(row(list_col_name(col_index)))
                Next
                row(total_col_name) = total
            Next
        End Sub
        Public Shared Sub Ensure_Folder(path As String)
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
        End Sub
        Public Shared Function KiemTraSoTien(sotien As Integer, sodoituong As Integer) As Boolean
            If (sotien < 0) _
                Or (sotien > 0 And sotien < 180) _
                Or (Not (sotien Mod 90 = 0 Or sotien Mod 135 = 0 Or sotien Mod 110 = 0 Or sotien Mod 160 = 0 Or sotien Mod 170 = 0 Or sotien Mod 100 = 0 Or sotien Mod 175 = 0 Or sotien Mod 120 = 0 Or sotien Mod 150 = 0)) _
                Or (sotien <> 9999 And (sotien / sodoituong > 1500)) Then Return False
            Return True
        End Function
        Public Shared Function WriteFile(filepath As String, str As String) As Boolean
            Dim result = False
            File.WriteAllText(filepath, str, Encoding.UTF8)
            result = True
            Return result
        End Function
        Public Shared Function ReadFile(filepath As String) As String
            Dim result As String = ""
            result = File.ReadAllText(filepath)
            Return result
        End Function
        Public Shared Function GenerateIframeDownloadHtmlCode(sFileUrl As String, Optional sFilename As String = "") As String
            Dim sResult As String = ""
            If sFilename = "" Then
                sFilename = System.IO.Path.GetFileName(sFileUrl)
            End If
            sResult = String.Format("<iframe src='/sp/download.aspx?fn={0}&fu={1}'></iframe>", HttpUtility.UrlEncode(WebHelper.Base64Encode(sFilename)), HttpUtility.UrlEncode(WebHelper.Base64Encode(sFileUrl)))
            Return sResult
        End Function

        Public Shared Function String_Captionlize(str As Object) As String
            Dim s As String = ""
            If str Is DBNull.Value Or str Is Nothing Then s = "" Else s = str.ToString
            s = String.Join(" ", s.Split(" ").Where(Function(x) x <> "").Select(Function(x) x.Trim)).Trim
            Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower.Replace("  ", " "))
        End Function
        Public Shared Function ChuanHoaTextNgay(strNgay As Object, Optional fullFormat As Boolean = False) As String
            If strNgay Is Nothing Then strNgay = ""
            strNgay = IIf(strNgay Is DBNull.Value, "", strNgay)
            Dim arrSep = "-|/|.".Split("|")
            Dim result As String = strNgay
            For Each sep In arrSep
                result = result.Replace(sep, "/")
            Next

            result = "///" & result

            Dim ngay = ""
            Dim thang = ""
            Dim nam = ""
            Dim arrNgaySinh = result.Split("/").Reverse.ToList

            ngay = arrNgaySinh(2)
            thang = arrNgaySinh(1)
            nam = arrNgaySinh(0)

            ngay = IIf(ngay = "0", "", ngay)
            ngay = IIf(ngay.Length = 1, "0" & ngay, ngay)
            If fullFormat Then
                ngay = IIf(ngay = "", "01/", ngay & "/")
            Else
                ngay = IIf(ngay = "", "", ngay & "/")
            End If


            thang = IIf(thang = "0", "", thang)
            thang = IIf(thang.Length = 1, "0" & thang, thang)
            If fullFormat Then
                thang = IIf(thang = "", "01/", thang & "/")
            Else
                thang = IIf(thang = "", "", thang & "/")
            End If

            nam = IIf(nam.Length > 0 And nam.Length <> 4, "", nam)
            If fullFormat Then
                nam = IIf(nam = "", "1800", nam)
            Else
                nam = IIf(nam = "", "", nam)
            End If

            If nam = "" Then
                thang = ""
                ngay = ""
            End If
            If thang = "" Then
                ngay = ""
            End If

            result = ngay & thang & nam
            If fullFormat Then
                result = result.Replace("00/", "01/")
            Else
                result = result.Replace("00/", "")
            End If

            If result = "01/01/1800" Then
                Return ""
            End If
            Return result
        End Function
#Region "Notification"
        Public Shared MinDate As DateTime = Convert.ToDateTime("1800-01-01")
        Public Shared MinDateText As String = "01/01/1800"
        Public Shared MaxDate As DateTime = Convert.ToDateTime("2900-01-01")
        Public Shared MaxDateText As String = "01/01/2800"
        Public Enum NotifyType
            Info = 1
            Success = 2
            Warning = 3
            Danger = 4
        End Enum
        Public Enum NotifyPosition
            Top = 1
            Bottom = 2
        End Enum
        Public Enum NotifyAlign
            Left = 1
            Center = 2
            Right = 3
        End Enum
        Public Shared Sub Notify(mes As String, Optional ntype As NotifyType = NotifyType.Success, Optional position As NotifyPosition = NotifyPosition.Bottom, Optional align As NotifyAlign = NotifyAlign.Right, Optional time As Integer = 3000)
            ClientAPI.RegisterStartUpScript(DirectCast(HttpContext.Current.Handler, System.Web.UI.Page), Guid.NewGuid.ToString, String.Format("<script>$.notify('{0}','{1}','{2}','{3}',{4});</script>", mes, ntype.ToString.ToLower.Replace("danger", "error"), position.ToString.ToLower, align.ToString.ToLower, time))
        End Sub
        Public Enum PopoverPlacement
            Top = 1
            Right = 2
            Bottom = 3
            Left = 4
        End Enum
        Public Shared Sub Popover(selector As String, mes As String, Optional livetime As Integer = 5000, Optional placement As PopoverPlacement = PopoverPlacement.Top)
            Dim script = String.Format("<script>popover('{0}','{1}','{2}','{3}','');</script>", selector, mes, livetime, placement.ToString.ToLower)
            ClientAPI.RegisterStartUpScript(DirectCast(HttpContext.Current.Handler, System.Web.UI.Page), Guid.NewGuid.ToString, script)
        End Sub
        Public Shared Function Base64Encode(plainText As String) As String
            Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)
            Return System.Convert.ToBase64String(plainTextBytes)
        End Function
        Public Shared Function Base64Decode(base64EncodedData As String) As String
            Dim base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData)
            Return System.Text.Encoding.UTF8.GetString(base64EncodedBytes)
        End Function
#End Region
#Region "DDL"
        ''' <summary>
        ''' Get selected value of  dropdown list, checkbock list, radio button list, listbox
        ''' </summary>
        ''' <param name="ddl"></param>
        ''' <param name="seperator">Use to join multiple value</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DDL_GetSelectedValues(ddl As Object, Optional seperator As String = ";") As String
            Dim result As String = ""

            'Get selected list
            Dim listSelected = DirectCast(ddl.Items, ListItemCollection).Cast(Of ListItem).Where(Function(x) x.Selected = True)

            'Convert selected value to string 
            result = String.Join(seperator, listSelected.Select(Function(x) x.Value).ToArray).Trim(seperator)

            'Get default value if no item selected
            Dim defaultvalue As String = ddl.Attributes("default-value")

            'Get default value if all item selected
            Dim default_all_value As String = ddl.Attributes("default-all-value")

            'If no selected item return default value if it defined
            If String.IsNullOrEmpty(result) Then
                result = IIf(String.IsNullOrEmpty(defaultvalue), "", defaultvalue)
            End If

            'If all item is selected return default all value if it defined
            If listSelected.Count = ddl.Items.Count Then
                result = IIf(String.IsNullOrEmpty(default_all_value), result, defaultvalue)
            End If

            Return result
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ddl"></param>
        ''' <param name="value">Value to set. Multipleable </param>
        ''' <param name="seperator">Use to split multiple value</param>
        ''' <remarks></remarks>
        Public Shared Sub DDL_SetSelectedValue(ddl As Object, value As String, Optional seperator As String = ";")
            DDL_SelectedValue(ddl, value, seperator)
        End Sub

        ''' <summary>
        ''' Set selected value of  dropdown list, checkbock list, radio button list, listbox
        ''' </summary>
        ''' <param name="ddl"></param>
        ''' <param name="value">Value to set. Multipleable </param>
        ''' <param name="seperator">Use to split multiple value</param>
        ''' <remarks></remarks>
        Public Shared Sub DDL_SelectedValue(ddl As Object, value As String, Optional seperator As String = ";")
            Try
                ddl.SelectedIndex = -1
                value = value & ""
                Dim listValue = value.Split(seperator)
                For Each li As ListItem In ddl.Items
                    li.Selected = listValue.Contains(li.Value)
                Next

                Dim defaut_no_selectd_value = ddl.Attributes("default-value")
                If Not String.IsNullOrEmpty(defaut_no_selectd_value) AndAlso value = defaut_no_selectd_value Then
                    For Each li As ListItem In ddl.Items
                        li.Selected = False
                    Next
                End If

                Dim defaut_all_selectd_value = ddl.Attributes("default-all-value")
                If Not String.IsNullOrEmpty(defaut_all_selectd_value) AndAlso value = defaut_all_selectd_value Then
                    For Each li As ListItem In ddl.Items
                        li.Selected = True
                    Next
                End If
                Return
            Catch ex As Exception
            End Try
        End Sub


        ''' <summary>
        ''' Use bind data to dropdown list, checkbock list, radio button list, listbox
        ''' </summary>
        ''' <param name="ddl"></param>
        ''' <param name="source"></param>
        ''' <param name="dataTextField"></param>
        ''' <param name="dataValueField"></param>
        ''' <param name="headertext"></param>
        ''' <param name="headervalue"></param>
        ''' <param name="seperator">If seperator is not empty convert item text as format : item.Value + seperator + item.Text</param>
        ''' <param name="defaut_no_selectd_value">Set value returned if no item was selected</param>
        ''' <param name="defaut_all_selectd_value">Set value returned if all item was selected .</param>
        ''' <remarks></remarks>
        Public Shared Sub DDL_BindData(ddl As Object, source As [Object], dataTextField As String, dataValueField As String, Optional headertext As String = Nothing, Optional headervalue As String = "", Optional seperator As String = "", Optional defaut_no_selectd_value As String = "", Optional defaut_all_selectd_value As String = "")
            Try
                ddl.Items.Clear()
                ddl.SelectedIndex = -1
                ddl.SelectedValue = Nothing
                ddl.DataTextField = dataTextField
                ddl.DataValueField = dataValueField
                ddl.DataSource = source
                ddl.DataBind()

                'If seperator is not empty convert item text as format : item.Value + seperator + item.Text
                If Not String.IsNullOrEmpty(seperator) Then
                    For Each leesin As ListItem In ddl.Items
                        leesin.Text = String.Format("{0}{1}{2}", leesin.Value, seperator, leesin.Text)
                    Next
                End If

                'Set value returned if no item was selected
                If Not String.IsNullOrEmpty(defaut_no_selectd_value) Then ddl.Attributes("default-value") = defaut_no_selectd_value

                'Set value returned if all item was selected
                If Not String.IsNullOrEmpty(defaut_all_selectd_value) Then ddl.Attributes("default-all-value") = defaut_all_selectd_value

                'Remove item that have value equal headervalue
                Dim li As ListItem = ddl.Items.FindByValue(headervalue)
                If li IsNot Nothing Then ddl.Items.Remove(li)

                'Add header item to control
                If Not String.IsNullOrEmpty(headertext) Then ddl.Items.Insert(0, New ListItem(headertext, headervalue))

            Catch ex As Exception

            End Try
        End Sub
        Public Shared Sub DDL_BindData_Ma(ddl As Object, source As [Object], dataTextField As String, dataValueField As String, Optional headertext As String = Nothing, Optional headervalue As String = "", Optional seperator As String = "", Optional defaut_no_selectd_value As String = "", Optional defaut_all_selectd_value As String = "")
            Try
                ddl.Items.Clear()
                ddl.SelectedIndex = -1
                ddl.SelectedValue = Nothing
                ddl.DataTextField = dataTextField
                ddl.DataValueField = dataValueField
                ddl.DataSource = source
                ddl.DataBind()

                'If seperator is not empty convert item text as format : item.Value + seperator + item.Text
                If Not String.IsNullOrEmpty(seperator) Then
                    For Each leesin As ListItem In ddl.Items
                        leesin.Text = String.Format("{0}{1}", seperator, leesin.Text)
                    Next
                End If

                'Set value returned if no item was selected
                If Not String.IsNullOrEmpty(defaut_no_selectd_value) Then ddl.Attributes("default-value") = defaut_no_selectd_value

                'Set value returned if all item was selected
                If Not String.IsNullOrEmpty(defaut_all_selectd_value) Then ddl.Attributes("default-all-value") = defaut_all_selectd_value

                'Remove item that have value equal headervalue
                Dim li As ListItem = ddl.Items.FindByValue(headervalue)
                If li IsNot Nothing Then ddl.Items.Remove(li)

                'Add header item to control
                If Not String.IsNullOrEmpty(headertext) Then ddl.Items.Insert(0, New ListItem(headertext, headervalue))

            Catch ex As Exception

            End Try
        End Sub


        ''' <summary>
        ''' Return item.Text by item.Value from dropdown list, list box, checkboxk list, radio list
        ''' </summary>
        ''' <param name="ddl"></param>
        ''' <param name="values"></param>
        ''' <param name="defaultvalue">Return defaultvalue if found nothing</param>
        ''' <param name="seperator">Use to split multiple value</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DDL_GetTexts(ddl As Object, values As Object, Optional defaultvalue As String = "", Optional seperator As String = ";") As String
            Dim listValue = values.ToString.Split(seperator)
            Dim result As String = String.Join(seperator, DirectCast(ddl.Items, ListItemCollection).Cast(Of ListItem).Where(Function(x) listValue.Contains(x.Value)).Select(Function(x) x.Text).ToArray).Trim(seperator)
            Return result
        End Function
        Public Shared Function DDL_GetText(ddl As DropDownList, value As Object, Optional defaultvalue As String = "") As String
            If value Is DBNull.Value Then
                Return defaultvalue
            End If
            Dim li = ddl.Items.FindByValue(value)
            If li Is Nothing Then
                Return defaultvalue
            Else
                Return li.Text
            End If
        End Function
        Public Shared Sub DDL_BindData(rdo As RadioButtonList, source As [Object], dataTextField As String, dataValueField As String)
            rdo.Items.Clear()
            rdo.SelectedIndex = -1
            rdo.SelectedValue = Nothing
            rdo.DataTextField = dataTextField
            rdo.DataValueField = dataValueField
            rdo.DataSource = source
            rdo.DataBind()
        End Sub
        Public Shared Sub DDL_BindData(ddl As Object, source As List(Of ListItem))
            ddl.DataTextField = "Text"
            ddl.DataValueField = "Value"
            ddl.DataSource = source
            ddl.DataBind()
        End Sub
#End Region
        Public Shared Sub SetChecked(chk As Object, val As Object)
            If val Is Nothing Then val = False
            If val Is DBNull.Value Then val = False
            val = val.ToString.ToUpper

        End Sub

#Region "Format, Convert"
        Public Shared Function GetDataRowValue(colname As String, dr As DataRow, Optional defautlValue As String = "") As Object
            If dr Is Nothing Then
                Return defautlValue
            End If
            If Not dr.Table.Columns.Contains(colname) Then
                Return defautlValue
            End If
            If dr(colname) Is DBNull.Value Then
                Return defautlValue
            End If
            Return dr(colname)
        End Function
        Public Shared Function DATE_Parse(sDate As String, Optional format As String = "dd/MM/yyyy", Optional defaultval As Object = Nothing) As DateTime
            If sDate Is Nothing Then Return defaultval
            If sDate Is DBNull.Value Then Return defaultval
            If sDate = "" Then Return defaultval
            Try
                Return DateTime.ParseExact(sDate, format, Nothing)
            Catch ex As Exception

            End Try
            If defaultval IsNot Nothing Then Return defaultval
            Return New DateTime
        End Function
        Public Shared Function DATE_Format(obj As Object, Optional seperator As String = " / ", Optional formatText As String = "{0:dd/MM/yyyy}") As String
            Try
                If obj Is DBNull.Value OrElse obj < MinDate Then
                    Return "--"
                End If
                Dim result As String = String.Format(formatText, obj)
                If result = String.Format(formatText, MinDate) Then
                    result = ""
                End If
                Return result.Replace("/", seperator)
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Shared Function DATETIME_Format(obj As Object, Optional seperator As String = " / ", Optional strformat As String = "dd/MM/yyyy HH:mm", Optional defaultValue As String = "") As String
            If obj Is Nothing Then Return defaultValue
            If obj Is DBNull.Value Then Return defaultValue
            If Not (TypeOf obj Is DateTime) Then Return defaultValue
            If obj < MinDate Then Return defaultValue
            Dim tmp As DateTime = obj
            Dim result As String = tmp.ToString(strformat)
            If result = MinDate.ToString(strformat) Then result = defaultValue
            Return result.Replace("/", seperator)
        End Function
        Public Shared Function Double_Format(obj As Object, Optional nullValue As Boolean = True, Optional defaultValue As Object = "") As String
            Try
                If obj Is DBNull.Value Then Return defaultValue
                If obj Is Nothing Then Return defaultValue
                If obj.ToString = "" Then Return defaultValue
                If Not IsNumeric(obj.ToString) Then Return defaultValue
                Dim xReturn As String = IIf(CType(obj, Double) <> 0 And CType(obj, Double) <> -1, Double.Parse(obj).ToString("N2", CultureInfo.CreateSpecificCulture("vi-VN")), defaultValue).ToString.TrimEnd("0").TrimEnd(",")
                If nullValue Then If Double.Parse(obj) = CDbl(0) Or Double.Parse(obj) = CDbl(-1) Then Return defaultValue
                Return xReturn
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Shared Function Double_Parse(obj As Object, Optional iferror As Double = 0) As Double
            Try
                If obj Is DBNull.Value Then Return iferror
                If obj Is Nothing Then Return iferror
                If obj.ToString = "" Then Return iferror
                If Not IsNumeric(obj.ToString) Then Return iferror
                Return Double.Parse(obj, CultureInfo.CreateSpecificCulture("vi-VN").NumberFormat)
            Catch ex As Exception
                Throw New Exception(String.Format("Can not convert string: {0} to number", obj))
            End Try
        End Function
        Public Shared Function String_Parse(obj As Object, Optional defaulval As String = "") As String
            If obj Is Nothing Then Return defaulval
            If obj Is DBNull.Value Then Return defaulval
            Return obj.ToString
        End Function
        Public Shared Function CutText(sStr As String, Optional number As Integer = 100) As String
            sStr = Uri.UnescapeDataString(sStr)
            sStr = sStr.Replace("_"c, " "c)
            If number >= sStr.Length Then
                Return sStr
            End If
            Dim last As Integer = sStr.LastIndexOf(" "c, number)
            If IsDBNull(last) = False Then
                Return sStr.Substring(0, last).Replace("_"c, " "c) & "..."
            End If
            Dim sResult As String = If(sStr.Length > number, sStr.Substring(0, number - 1), sStr)

            Return sResult
        End Function
        Public Shared Function CutTextByFixedCharacters(str As String, index As Integer) As String
            If (String.IsNullOrEmpty(str)) Then
                Return ""
            End If
            If (str.Length > index) Then
                str = str.Substring(0, index)
                str = str.Substring(0, str.LastIndexOf(" ", System.StringComparison.Ordinal)) + "..."
            End If
            Return str
        End Function
        Public Shared Sub SetCookie(cookieName As String, value As Object)
            Dim hc As New HttpCookie(cookieName)
            hc.Expires = DateTime.Now.AddYears(1)
            hc.Value = value
            HttpContext.Current.Response.Cookies.Add(hc)
        End Sub
        Public Shared Function GetCookie(cookieName As String) As Object
            Dim hc = HttpContext.Current.Request.Cookies(cookieName)
            If hc IsNot Nothing Then
                Return hc.Value
            Else
                Return ""
            End If
        End Function
        Public Shared Function KhongDau_v1(_text As Object) As String
            If _text Is Nothing Then _text = ""
            If _text Is DBNull.Value Then _text = ""
            'Dim regex As New Regex("\\p{IsCombiningDiacriticalMarks}+")
            'Dim temp As String = _text.Normalize(NormalizationForm.FormD)
            '_text = regex.Replace(temp, String.Empty).Replace("\u0111", "d").Replace("\u0110", "D")
            Dim sb As New StringBuilder()
            _text = _text.Replace("&", "and")
            _text = Regex.Replace(_text, "Đ|đ|đ|Đ", "d", RegexOptions.IgnoreCase)
            _text = _text.Normalize(NormalizationForm.FormKD)
            For i As Integer = 0 To _text.Length - 1
                If Char.IsWhiteSpace(_text.Chars(i)) Then
                    sb.Append(" "c)
                ElseIf Char.GetUnicodeCategory(_text.Chars(i)) <> UnicodeCategory.NonSpacingMark AndAlso Not Char.IsPunctuation(_text.Chars(i)) AndAlso Not Char.IsSymbol(_text.Chars(i)) Then
                    sb.Append(_text.Chars(i))
                End If
            Next
            Dim sReturn As String = sb.ToString.Replace(" ", " ")
            sReturn = sReturn.Trim(" ".ToCharArray)

            Return sReturn.ToLower
        End Function
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
        Public Shared Function Highlight(keysearch As String, InputTxt As String, StartTag As String, EndTag As String) As String
            Dim ResultStr As String = InputTxt
            Dim strArr As String() = keysearch.Trim.Split(" ")

            Return strArr.Aggregate(ResultStr, Function(current, word) Regex.Replace(current, "\b(" & Regex.Escape(word) & ")\b", StartTag & "$1" & EndTag, RegexOptions.IgnoreCase))
        End Function
        Public Shared Function SetUrlQueryParameter(key As String, value As String, Optional url As String = "") As String
            If String.IsNullOrEmpty(url) Then
                url = DirectCast(HttpContext.Current.Items("UrlRewrite:OriginalUrl"), String) ' HttpContext.Current.Request.Url.AbsoluteUri  '
            End If

            Dim separateUrl As String() = url.Split(Convert.ToChar("?"))
            If separateUrl.Count() > 1 Then
                Dim queryString As NameValueCollection = System.Web.HttpUtility.ParseQueryString(separateUrl(1))
                queryString(key) = value
                If value = "" Then
                    queryString.Remove(key)
                End If
                url = separateUrl(0) & "?" & Convert.ToString(queryString)
            Else
                url = separateUrl(0) & "?" & key & "=" & value
            End If

            Return url
        End Function
        Public Shared Function GetSortParamUrl(headertext As String, key As String, value As String) As String
            Dim url = DirectCast(HttpContext.Current.Items("UrlRewrite:OriginalUrl"), String)
            Dim separateUrl As String() = url.Split(Convert.ToChar("?"))
            Const _template As String = "<th class='text-center {0}'><a href='{1}' class='hidden-print'>{2}</a><span class='visible-print'>{2}</span></th>"
            Dim _sort As String = "sorting"
            If separateUrl.Count() > 1 Then
                Dim queryString As NameValueCollection = HttpUtility.ParseQueryString(separateUrl(1))
                Dim currentVal = queryString(key)
                If Not String.IsNullOrEmpty(currentVal) Then
                    If currentVal.EndsWith("_D") Then currentVal = currentVal.Substring(0, currentVal.Length - 2)
                    If currentVal.Equals(value) Then
                        If Not queryString(key).EndsWith("_D") Then
                            currentVal = currentVal + "_D"
                            _sort = "sorting_asc"
                        Else
                            _sort = "sorting_desc"
                        End If
                        queryString(key) = currentVal
                    Else
                        queryString(key) = value
                    End If
                Else
                    queryString(key) = value
                End If

                url = separateUrl(0) & "?" & Convert.ToString(queryString)
            Else
                url = separateUrl(0) & "?" & key & "=" & value
            End If

            Return String.Format(_template, _sort, url, headertext)
        End Function
        Public Shared Function GetValueFromMask(maskednumber As String) As String
            Return Regex.Replace(maskednumber, "[^\d]", "")
        End Function
        Public Shared Function ChuyenTienThanhChu(Baonhieu As Decimal) As String
            Dim KetQua, SoTien As String
            Dim nhom, chu As String
            Dim dich, s1 As String
            Dim s2, s3 As String
            Dim i, j As Byte
            Dim Vitri As Byte
            Dim s As Double
            Dim hang() As String = {"Không", "trăm", "mươi", "gì đó"}
            Dim doc() As String = {"Không", "tỷ", "triệu", "ngàn", "đồng", "xu"}
            Dim dem() As String = {"Không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
            On Error Resume Next
            If Baonhieu = 0 Then
                KetQua = "Không đồng"
            Else
                If System.Math.Abs(Baonhieu) > 999999999999.99 Then
                    KetQua = "Số quá lớn"
                Else
                    If Baonhieu < 0 Then
                        KetQua = "Trừ" & Space(1)
                    Else
                        KetQua = Space(0)
                    End If
                    SoTien = Format(System.Math.Abs(Baonhieu), "###########0.00")
                    SoTien = Microsoft.VisualBasic.Right(Space(12) & SoTien, 15)
                    For i = 1 To 5
                        nhom = Mid(SoTien, i * 3 - 2, 3)
                        If nhom <> Space(3) Then
                            Select Case nhom
                                Case "000"
                                    If i = 4 Then
                                        chu = "đồng" & Space(1)
                                    Else
                                        chu = Space(0)
                                    End If
                                Case ".00", ",00"
                                    chu = "chẵn"
                                Case Else
                                    s1 = Microsoft.VisualBasic.Left(nhom, 1)
                                    s2 = Mid(nhom, 2, 1)
                                    s3 = Microsoft.VisualBasic.Right(nhom, 1)
                                    chu = Space(0)
                                    hang(3) = doc(i)
                                    For j = 1 To 3
                                        dich = Space(0)
                                        s = Val(Mid(nhom, j, 1))
                                        If s > 0 Then
                                            dich = dem(s) & Space(1) & hang(j) & Space(1)
                                        End If
                                        Select Case j
                                            Case 2 And s = 1
                                                dich = "mười" & Space(1)
                                            Case 3 And s = 0 And nhom <> Space(2) & "0"
                                                dich = hang(j) & Space(1)
                                            Case 3 And s = 5 And s2 <> Space(1) And s2 <> "0"
                                                dich = "l" & Mid(dich, 2)
                                            Case 2 And s = 0 And s3 <> "0"
                                                If (s1 >= "1" And s1 <= "9") Or (s1 = "0" And i = 4) Then
                                                    dich = "lẻ" & Space(1)
                                                End If
                                        End Select
                                        chu = chu & dich
                                    Next j
                            End Select
                            Vitri = InStr(1, chu, "mươi một", CompareMethod.Text)
                            If Vitri > 0 Then Mid(chu, Vitri, 9) = "mươi mốt"
                            KetQua = KetQua & chu
                        End If
                    Next i
                End If
            End If
            Return UCase(Microsoft.VisualBasic.Left(KetQua, 1)) & Mid(KetQua, 2)
        End Function
#End Region
#Region "Common function"
        Public Shared Function GetHTML(ph As PlaceHolder) As String
            'Dim p As Page = New Page()

            'Dim form As HtmlForm = New HtmlForm()
            'form.Name = "form1"
            'p.Controls.Add(form)
            'form.Controls.Add(ph)

            ph.Visible = True
            Dim sb As New StringBuilder()
            Dim sw As New System.IO.StringWriter(sb)
            Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
            ph.RenderControl(hw)
            ph.Visible = False
            Return sb.ToString
        End Function
        Public Shared Function DNN_GetModuleSetting(page As PortalModuleBase, key As String) As String
            Try
                Return page.ModuleConfiguration.ModuleSettings(key).ToString()
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Shared Sub DNN_UpdateModuleSetting(page As PortalModuleBase, settingName As String, settingValue As String)
            Dim objModules As New ModuleController()
            objModules.UpdateModuleSetting(page.ModuleId, settingName, settingValue)
        End Sub
        Public Shared Function GenerateQueryStringParameters(request As HttpRequest, queryStringKeys As String()) As String
            Dim queryString = New StringBuilder(64)
            For Each key As String In queryStringKeys
                If Not String.IsNullOrEmpty(request.QueryString(key)) Then
                    If queryString.Length > 0 Then
                        queryString.Append("&")
                    End If

                    queryString.Append(key).Append("=").Append(request.QueryString(key))
                End If
            Next

            Return queryString.ToString()
        End Function
        Public Shared Sub ExecuteStartUpScript(script As String, Optional delay As Integer = 0)
            If delay = 0 Then
                ClientAPI.RegisterStartUpScript(HttpContext.Current.Handler, Guid.NewGuid().ToString, String.Format("<script>{0}</script>", script))
            Else
                ClientAPI.RegisterStartUpScript(HttpContext.Current.Handler, Guid.NewGuid().ToString, "<script>setTimeout(function(){" & script & "}," & delay & ")</script>")
            End If
        End Sub
        Public Shared Function TAB_GetUrlByTabId(tabID As Integer, key As String) As String
            Try
                Return DotNetNuke.Common.Globals.NavigateURL(tabID, "", key)
            Catch ex As Exception
                Return "#"
            End Try
        End Function
        Public Shared Sub ShowExceptionForDeveloper(lblMessage As System.Web.UI.WebControls.Label, ex As Exception, Optional force As Boolean = True)
            If ex.Message.Contains("Timeout") Or force Then
                WebHelper.Notify("Hệ thống đang bận. Vui lòng thử lại sau ít phút hoặc liên hệ quản trị hệ thống!", WebHelper.NotifyType.Warning, WebHelper.NotifyPosition.Top, WebHelper.NotifyAlign.Center)
            End If
            If DotNetNuke.Entities.Portals.PortalSettings.Current.UserInfo.IsInRole("Administrators") Or DotNetNuke.Entities.Portals.PortalSettings.Current.UserInfo.IsSuperUser Or HttpContext.Current.Request.QueryString("mode") = "dev" Then
                lblMessage.Text = String.Format("{0}<hr/>{1}<hr/>{2}", ex.Message.Replace("line", "<span style='color:red;'>line</span>"), ex.StackTrace, ex.Source)
                lblMessage.Visible = True
            End If
        End Sub

        Public Shared Function Query(key As String, Optional defaultValue As Object = "") As String
            Query = HttpContext.Current.Request(key)
            If defaultValue Is Nothing Then defaultValue = ""
            Return HttpUtility.HtmlDecode(IIf(String.IsNullOrEmpty(Query), defaultValue, Query))
        End Function
        Public Shared Function Form(key As String, Optional defaultValue As Object = "") As String
            Dim obj = HttpContext.Current.Request.Form(key)
            Return HttpUtility.HtmlDecode(IIf(String.IsNullOrEmpty(obj), defaultValue, obj))
        End Function
        Public Shared Function GetLanguage() As String
            Return System.Threading.Thread.CurrentThread.CurrentCulture.ToString()
        End Function
#End Region
        Public Shared Function MatKhau_SinhNgauNhien() As String
            Randomize()
            Dim x As Long
            x = Convert.ToInt64(Rnd() * 1000000)
            Dim str As String = x.ToString
            While str.Length < 6
                str = "0" & str
            End While
            While str.Length > 6
                str = str.Substring(0, 6)
            End While
            Return str
        End Function
        Public Shared Sub LoadCheckBoxList(ddl As CheckBoxList, source As Object, SelectedId As String)
            With ddl
                .DataSource = source
                .DataTextField = "Ten"
                .DataValueField = "Id"
                .DataBind()
                Dim lst As ListItem = .Items.FindByValue(SelectedId)
                If Not lst Is Nothing AndAlso lst.Value.Length > 0 Then
                    lst.Selected = True
                End If
            End With
        End Sub
        Public Shared Function CompressString(text As String) As String
            Dim buffer__1 As Byte() = Encoding.UTF8.GetBytes(text)
            Dim memoryStream = New MemoryStream()
            Using gZipStream = New GZipStream(memoryStream, CompressionMode.Compress, True)
                gZipStream.Write(buffer__1, 0, buffer__1.Length)
            End Using

            memoryStream.Position = 0

            Dim compressedData = New Byte(memoryStream.Length - 1) {}
            memoryStream.Read(compressedData, 0, compressedData.Length)

            Dim gZipBuffer = New Byte(compressedData.Length + 3) {}
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length)
            Buffer.BlockCopy(BitConverter.GetBytes(buffer__1.Length), 0, gZipBuffer, 0, 4)
            Return Convert.ToBase64String(gZipBuffer)
        End Function
        Public Shared Function DecompressString(compressedText As String) As String
            Dim gZipBuffer As Byte() = Convert.FromBase64String(compressedText)
            Using memoryStream = New MemoryStream()
                Dim dataLength As Integer = BitConverter.ToInt32(gZipBuffer, 0)
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4)

                Dim buffer = New Byte(dataLength - 1) {}

                memoryStream.Position = 0
                Using gZipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
                    gZipStream.Read(buffer, 0, buffer.Length)
                End Using

                Return Encoding.UTF8.GetString(buffer)
            End Using
        End Function
        Public Shared Function GetListFileHoNgheo(MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThonTo As Integer, Optional tenthon As String = "") As List(Of String)
            Dim path As String = ""

            If tenthon <> "" Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), tenthon))
            ElseIf MaThonTo > 0 Then
                Dim _xThon As Integer = MaThonTo Mod 100
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), CInt(_xThon).ToString("D2")))
            ElseIf MaXa > 0 Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C/{1}/{2}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5")))
            ElseIf MaHuyen > 0 Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C/{1}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3")))
            End If
            Dim result As List(Of String) = GetListFile(path)

            If result.Count <= 0 Then
                If tenthon <> "" Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), tenthon))
                ElseIf MaThonTo > 0 Then
                    Dim _xThon As Integer = MaThonTo Mod 100
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), CInt(_xThon).ToString("D2")))
                ElseIf MaXa > 0 Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C/{1}/{2}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5")))
                ElseIf MaHuyen > 0 Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C/{1}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3")))
                End If
            End If
            result = GetListFile(path)

            Return result
        End Function
        Public Shared Function GetListFileBTXH(MaTinh As Integer, MaHuyen As Integer, MaXa As Integer, MaThonTo As Integer, Optional tenthon As String = "") As List(Of String)
            Dim path As String = ""

            If tenthon <> "" Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C1/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), tenthon))
            ElseIf MaThonTo > 0 Then
                Dim _xThon As Integer = MaThonTo Mod 100
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C1/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), CInt(_xThon).ToString("D2")))
            ElseIf MaXa > 0 Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C1/{1}/{2}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5")))
            ElseIf MaHuyen > 0 Then
                path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/FileDanHSach/{0}/C1/{1}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3")))
            End If
            Dim result As List(Of String) = GetListFile(path)
            If result.Count <= 0 Then
                If tenthon <> "" Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C1/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), tenthon))
                ElseIf MaThonTo > 0 Then
                    Dim _xThon As Integer = MaThonTo Mod 100
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C1/{1}/{2}/{3}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5"), CInt(_xThon).ToString("D2")))
                ElseIf MaXa > 0 Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C1/{1}/{2}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3"), CInt(MaXa).ToString("D5")))
                ElseIf MaHuyen > 0 Then
                    path = System.Web.HttpContext.Current.Server.MapPath(String.Format("/Image_DL2/{0}/C1/{1}/", CInt(MaTinh).ToString("D2"), CInt(MaHuyen).ToString("D3")))
                End If
            End If
            result = GetListFile(path)

            If result.Count <= 0 Then

            End If

            Return result
        End Function
        Public Shared Function GetListFile(initial As String, Optional filter As String = "*.pdf", Optional Recursive As Boolean = False) As List(Of String)
            Dim result As New List(Of String)
            If initial <> "" And Directory.Exists(initial) Then
                If Recursive Then
                    Dim stack As New Stack(Of String)
                    stack.Push(initial)
                    Do While (stack.Count > 0)
                        Dim dir As String = stack.Pop
                        Try
                            result.AddRange(Directory.GetFiles(dir, filter))
                            Dim directoryName As String
                            For Each directoryName In Directory.GetDirectories(dir)
                                stack.Push(directoryName)
                            Next
                        Catch ex As Exception
                        End Try
                    Loop
                Else
                    result.AddRange(Directory.GetFiles(initial, filter))
                End If
            End If

            Return result
        End Function

        Public Function LoadDataFromString(str As String, Optional pattern As String = "<i>(.*)</i>") As Hashtable
            Dim result As New Hashtable

            Dim regex = New Regex(pattern)
            Dim match = regex.Match(str)
            If match.Success Then
                Dim val = match.Groups(1).Value
                Dim tmp = val.Split("|").Where(Function(x) x.Trim <> "").Select(Function(x) x)
                For Each s In tmp
                    Dim arr = s.Split("=")
                    result(arr(0).Trim) = arr(1).Trim
                Next
            End If

            Return result
        End Function
        Public Function SaveDataToString(str As String, saveData As Hashtable, Optional pattern As String = "<i>(.*)</i>") As String
            Dim tmp As New List(Of String)
            For Each key In saveData.Keys
                tmp.Add(String.Format("{0}={1}", key, saveData(key)))
            Next
            Dim strSave = String.Join("|", tmp).Trim("|")
            strSave = String.Format("<i>{0}</i>", strSave)
            Dim regex = New Regex(pattern)
            Dim match = regex.Match(str)
            If match.Success Then
                Return regex.Replace(str, strSave)
            End If
            Return str & " " & strSave
        End Function
        Public Shared Function FormatCheckOptionInt(chk As Object) As String
            Try
                Return IIf(CType(chk, Boolean), "<span style='color:green' class='glyphicon glyphicon-ok'></span>", "<span style='color:red' class='glyphicon glyphicon-remove'></span>")
            Catch ex As Exception
                Return "<span style='color:red' class='glyphicon glyphicon-remove'></span>"
            End Try
        End Function
        Public Shared Function FilterSecurity(inputText As String) As String
            Dim pSecurity As New PortalSecurity
            Return pSecurity.InputFilter(inputText, PortalSecurity.FilterFlag.NoScripting)
        End Function
        Public Shared Function User_ProcessLogin(_Username As String, _Password As String, _Remember As Boolean) As String
            Dim status As New DotNetNuke.Security.Membership.UserLoginStatus()
            Dim obj = UserController.ValidateUser(PortalSettings.Current.PortalId, _Username, _Password, "DNN", PortalSettings.Current.PortalName, AuthenticationLoginBase.GetIPAddress(), status)
            If status = UserLoginStatus.LOGIN_SUCCESS OrElse status = UserLoginStatus.LOGIN_SUPERUSER Then
                UserController.UserLogin(PortalSettings.Current.PortalId, obj, PortalSettings.Current.PortalName, AuthenticationLoginBase.GetIPAddress(), False)
                Dim eventArgs As New UserAuthenticatedEventArgs(obj, _Username, status, "DNN")
                eventArgs.Authenticated = True

                Return ""
            ElseIf status = UserLoginStatus.LOGIN_USERLOCKEDOUT Then
                Return "Tài khoản này đã bị khóa. Hãy đợi 10 phút trước khi thử đăng nhập lại."
            Else
                Return "Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng kiểm tra lại!"
            End If

        End Function
        Public Shared Sub User_SignOut()
            Dim ps As PortalSecurity = New PortalSecurity()
            ps.SignOut()
            HttpContext.Current.Response.Redirect(HttpContext.Current.Request.RawUrl)
        End Sub
    End Class
