Imports DotNetNuke.ANALY
Imports DotNetNuke.EPORTAL
Imports Telerik.Web.UI
Namespace DesktopModules.Modules
    Partial Class PTDB
        Inherits Entities.Modules.PortalModuleBase

        Dim arrTemp, arrTemp2 As New ArrayList
        Dim node, node2 As RadTreeNode
        Dim drBox As DropDownList
        Dim lit As Literal
        Dim str(), keyStr, pathTemp, fileSave As String
        Public TitleChart, XYear, DonViTinh, DataChart1 As String

        Dim ObjControler As New AnalyController
        Dim dicInfo As New HT_DisplayHomeInfo

        Dim dicAInfo As DataAnalyInfo
        Private Sub PTDB_Load(sender As Object, e As EventArgs) Handles Me.Load

            Try
                If Not Page.IsPostBack Then

                    For Each ctl As HT_DisplayHomeInfo In ObjControler.HT_DisplayHome_List()
                        LoadData(ctl.GroupID, ctl.TargetID, ctl.YearFrom, ctl.YearTo, ctl.Method, ctl.TypeChart, ctl.TotalYear)
                        Exit For
                    Next
                End If

            Catch ex As Exception
                lbTitle.Text = ex.ToString()
            End Try
        End Sub

        Private Sub LoadData(groupId As Integer, targetId As Integer, year1 As Integer, year2 As Integer, phuongPhapDuBao As Integer, chart_type As Integer, soNam As Integer)
            Dim stt As Integer = 1
            Dim tarInfo As CMS_TargetsInfo
            arrTemp = New ArrayList
            keyStr = flCheck.Target_Des(Me.PortalId, flReg.WriteNumber(targetId))
            lbTitle.Text = "KẾT QUẢ DỰ BÁO CHỈ TIÊU " & flReg.RemoveHTML(keyStr.ToUpper) & " TỪ NĂM " & year1 & " ĐẾN NĂM " & year2
            TitleChart = "Biểu đồ dự báo chỉ tiêu " & flReg.RemoveHTML(keyStr)
            DonViTinh = flCheck.UnitType_Name(Me.PortalId, flCheck.Target_UnitType(Me.PortalId, targetId))

            For i = year1 To year2
                dicAInfo = New DataAnalyInfo
                dicAInfo.STT = stt
                dicAInfo.YearID = i
                dicAInfo.Data1 = 0
                dicAInfo.IsFlag = 0
                tarInfo = ObjControler.CMS_Targets_Get(Me.PortalId, flReg.WriteNumber(targetId))
                If IsNothing(tarInfo) = False Then
                    With tarInfo
                        dicAInfo.Data1 = flReg.WriteNumber(ObjControler.CMS_Data_Get_By_Years(Me.PortalId, flReg.WebConfig("TinhTP"), tarInfo.Group_ID, tarInfo.Targets_ID, i))
                        arrTemp.Add(dicAInfo)
                        stt += 1
                    End With
                End If
            Next

            'higchart
            If phuongPhapDuBao = 2 Then

                Call BT_ForceCastHQ(arrTemp, arrTemp.Count, year2 + 1, soNam, 0)
            Else


                Call BT_ForceCast(arrTemp, arrTemp.Count + 1, year2 + 1, soNam, 0)

            End If
            grdAnalytic.DataSource = arrTemp
            grdAnalytic.DataBind()
            DataChart1 = "" : XYear = ""
            Select Case chart_type
                Case ChartType.DuongKhuVuc
                    For i = 0 To arrTemp.Count - 1
                        XYear += "'" & IIf(arrTemp(i).IsFlag = 0, arrTemp(i).YearID, arrTemp(i).YearID & "*") & "',"
                        DataChart1 += arrTemp(i).Data1 & ","
                    Next
                Case Else
                    For i = 0 To arrTemp.Count - 1
                        DataChart1 += "{"
                        DataChart1 += "name :   """ & IIf(arrTemp(i).IsFlag = 0, arrTemp(i).YearID, arrTemp(i).YearID & "*") & ""","
                        DataChart1 += "y :   " & arrTemp(i).Data1 & ","
                        DataChart1 += "},"
                    Next
            End Select
            Select Case chart_type
                Case ChartType.DuongKhuVuc
                    pnchart3.Visible = True
                    pnchart2.Visible = False
                    pnchart1.Visible = False
                Case ChartType.Duong

                    pnchart3.Visible = False
                    pnchart2.Visible = True
                    pnchart1.Visible = False
                Case Else
                    pnchart3.Visible = False
                    pnchart2.Visible = False
                    pnchart1.Visible = True
            End Select
        End Sub
        Private Sub BT_ForceCast(arrTempD As ArrayList, instanceStart As Integer, yearInstance As Integer, sonam As Integer, index As Integer)
            Try

                If arrTempD.Count <= 0 Then
                    Exit Sub
                End If
                Dim valueB As Double 'gia tri b
                Dim valueA As Double 'gia tri a
                Dim btFore As Double
                'BT_ForceCast= a+bx
                'a=aver(y)-b(aver(x))
                'b=((x1-aver(x))*(y1=aver(y))+...+(xN-aver(x))*(yN=aver(y)) )/((x1-aver(x)*(x1-aver(x))+..+(xN-aver(x)*(xN-aver(x)))
                dicAInfo = New DataAnalyInfo
                'tinh gia tri b
                Dim avgT As Double = 0
                Dim avgM As Double = 0
                Dim avgY As Double = 0
                Dim avgX As Double = 0
                For j = index To arrTempD.Count - 1
                    avgX += arrTempD(j).STT
                    avgY += arrTempD(j).Data1
                Next
                avgX = avgX / (instanceStart - (index + 1))
                avgY = avgY / (instanceStart - (index + 1))
                For i = index To arrTempD.Count - 1
                    avgT += (arrTempD(i).STT - avgX) * (arrTempD(i).Data1 - avgY)
                    avgM += ((arrTempD(i).STT - avgX) * (arrTempD(i).STT - avgX))

                Next
                valueB = avgT / avgM
                'tinh gia tri a
                valueA = avgY - (valueB * avgX)
                btFore = valueA + (valueB * instanceStart)
                dicAInfo.STT = arrTempD.Count + 1
                dicAInfo.YearID = yearInstance
                dicAInfo.Data1 = btFore
                dicAInfo.IsFlag = 1
                arrTempD.Add(dicAInfo)
                If sonam > 1 Then Call BT_ForceCast(arrTempD, arrTempD.Count + 1, yearInstance + 1, sonam - 1, index + 1)
            Catch ex As Exception
                dicAInfo.STT = arrTempD.Count + 1
                dicAInfo.YearID = yearInstance
                dicAInfo.Data1 = 0
                dicAInfo.IsFlag = 1
                arrTempD.Add(dicAInfo)
                If sonam > 1 Then Call BT_ForceCast(arrTempD, arrTempD.Count + 1, yearInstance + 1, sonam - 1, index + 1)
            End Try
        End Sub
        Private Sub BT_ForceCastHQ(arrTempD As ArrayList, instanceStart As Integer, yearInstance As Integer, sonam As Integer, index As Integer)
            Try

                If arrTempD.Count <= 0 Then
                    Exit Sub
                End If
                Dim valueB As Double 'gia tri b
                Dim valueA As Double 'gia tri a
                Dim btFore As Double
                'BT_ForceCast= a+bx
                'a=aver(y)-b(aver(x))
                'b=((x1-aver(x))*(y1=aver(y))+...+(xN-aver(x))*(yN=aver(y)) )/((x1-aver(x)*(x1-aver(x))+..+(xN-aver(x)*(xN-aver(x)))
                dicAInfo = New DataAnalyInfo
                'tinh gia tri b
                Dim avgT As Double = 0
                Dim avgM As Double = 0
                Dim avgY As Double = 0
                Dim avgX As Double = 0
                Dim subY As Double = 0
                Dim subX As Double = 0
                For j = index To arrTempD.Count - 1
                    avgX += j
                    avgY += arrTempD(j).Data1
                Next
                avgX = avgX / (arrTempD.Count - 1)
                avgY = avgY / (arrTempD.Count - 1)

                'For i = index To arrTempD.Count - 1
                '    subY +=
                '    subX +=
                'Next

                For i = index To arrTempD.Count - 1
                    avgT += (arrTempD(i).STT - avgX) * (arrTempD(i).Data1 - avgY)
                    avgM += ((arrTempD(i).STT - avgX) * (arrTempD(i).STT - avgX))

                Next

                valueB = avgT / avgM
                'tinh gia tri a
                valueA = avgY - (valueB * avgX)
                btFore = valueA + (valueB * instanceStart)
                dicAInfo.STT = arrTempD.Count + 1
                dicAInfo.YearID = yearInstance
                dicAInfo.Data1 = btFore
                dicAInfo.IsFlag = 1
                arrTempD.Add(dicInfo)
                If sonam > 1 Then Call BT_ForceCast(arrTempD, arrTempD.Count + 1, yearInstance + 1, sonam - 1, index + 1)
            Catch ex As Exception
                dicAInfo.STT = arrTempD.Count + 1
                dicAInfo.YearID = yearInstance
                dicAInfo.Data1 = 0
                dicAInfo.IsFlag = 1
                arrTempD.Add(dicInfo)
                If sonam > 1 Then Call BT_ForceCast(arrTempD, arrTempD.Count + 1, yearInstance + 1, sonam - 1, index + 1)
            End Try
        End Sub
        Protected Sub grdAnalytic_ItemDataBound(sender As Object, e As DataGridItemEventArgs) Handles grdAnalytic.ItemDataBound
            If e.Item.ItemIndex < 0 Then Exit Sub
            lit = e.Item.FindControl("IsOrder")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "STT")

            lit = e.Item.FindControl("txtYear")
            lit.Text = DataBinder.Eval(e.Item.DataItem, "YearID")

            lit = e.Item.FindControl("Data1")
            lit.Text = flReg.FormatPrice(Math.Round(DataBinder.Eval(e.Item.DataItem, "Data1"), 0))
            If flReg.WriteNumber(DataBinder.Eval(e.Item.DataItem, "IsFlag")) = 1 Then
                e.Item.BackColor = Color.YellowGreen
            End If
        End Sub
    End Class
End Namespace

