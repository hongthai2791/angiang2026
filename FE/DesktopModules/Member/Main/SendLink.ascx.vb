Namespace Modules.Main
    Partial Class View
        Inherits Entities.Modules.PortalModuleBase
        Public _tabName As String
        Public _logIn As String

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            If Request.Item("nop-hs") & "" <> "" Then
                If Me.UserInfo.IsInRole("business") = True Then
                    _tabName = "business"
                    _logIn = "home?ctl=logoff&nop-hs=" & Request.Item("nop-hs")
                    lbTbao.Text = "Chức năng dành cho Người lao động, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Người lao động để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("users") = True Then
                    Response.Redirect("/users/edit/us-works/itemid/" & WORK.flCheck.getWork_ID(Me.PortalId, WORK.flNotify.GetRequestId(Request.Item("nop-hs"))), True)
                Else
                    Response.Redirect("/home/nop-hs/" & Request.Item("nop-hs"), True)
                End If
            ElseIf Request.Item("nop-hsvl") & "" <> "" Then
                If Me.UserInfo.IsInRole("business") = True Then
                    _tabName = "business"
                    _logIn = "home?ctl=logoff&nop-hsvl=" & Request.Item("nop-hsvl")
                    lbTbao.Text = "Chức năng dành cho Người lao động, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Người lao động để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("users") = True Then
                    Response.Redirect("/users/edit/us-mark-list/itemid/" & Request.Item("nop-hsvl") & "/idw/" & Request.Item("idw") & "/idb/" & Request.Item("idb") & "/idtab/" & Request.Item("idtab"), True)
                Else
                    Response.Redirect("/home/nop-hsvl/" & Request.Item("nop-hsvl") & "/idw/" & Request.Item("idw") & "/idb/" & Request.Item("idb") & "/idtab/" & Request.Item("idtab"), True)
                End If
            ElseIf Request.Item("luu-hs") & "" <> "" Then
                If Me.UserInfo.IsInRole("business") = True Then
                    Response.Redirect("/business/edit/bus-jobuser/itemid/" & WORK.flCheck.JobUser_ID(Me.PortalId, WORK.flNotify.GetRequestId(Request.Item("luu-hs"))), True)
                ElseIf Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&luu-hs=" & Request.Item("luu-hs")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                Else
                    Response.Redirect("/home/luu-hs/" & Request.Item("luu-hs"), True)
                End If
            ElseIf Request.Item("xem-nn") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&xem-nn=" & Request.Item("xem-nn")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Dim itemid As Integer = WORK.flNotify.GetRequestId(Request.Item("xem-nn"))
                    If itemid > 0 Then
                        Dim url As String = Request.Item("xem-nn").Replace(itemid, "")
                        Response.Redirect("/business/edit/bus-jobuser-career/caid/" & url.Remove(url.Length - 1) & "/itemid/" & itemid, True)
                    Else
                        Response.Redirect("/business/edit/bus-jobuser-career/caid/" & Request.Item("xem-nn"), True)
                    End If
                Else
                    Response.Redirect("/home/xem-nn/" & Request.Item("xem-nn"), True)
                End If
            ElseIf Request.Item("vl") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&vl=" & Request.Item("vl")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Dim itemid As Integer = WORK.flNotify.GetRequestId(Request.Item("vl"))
                    If itemid > 0 Then
                        Dim url As String = Request.Item("vl").Replace(itemid, "")
                        Response.Redirect("/business/view/" & url.Remove(url.Length - 1) & "/itemid/" & itemid, True)
                    Else
                        Response.Redirect("/business/view/" & Request.Item("vl"), True)
                    End If
                Else
                    Response.Redirect("/home/vl/" & Request.Item("vl"), True)
                End If
            ElseIf Request.Item("svl") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&svl=" & Request.Item("svl")
                    Response.Redirect("/users/view/us-mark-list", True)
                    'Response.Redirect("/users/edit/us-mark-list/itemid/" & Request.Item("svl"), True)
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Dim itemid As Integer = WORK.flNotify.GetRequestId(Request.Item("svl"))
                    If itemid > 0 Then
                        Dim url As String = Request.Item("svl").Replace(itemid, "")
                        'Response.Redirect("/business/view/" & url.Remove(url.Length - 1) & "/itemid/" & itemid, True)
                        Response.Redirect("/business/view/bus-mark-list", True)
                    Else
                        Response.Redirect("/business/view/bus-mark-list", True)
                    End If
                Else
                    Response.Redirect("/home/svl/" & Request.Item("svl"), True)
                End If
            ElseIf Request.Item("tuyen-dung") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&tuyen-dung=" & Request.Item("tuyen-dung")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Response.Redirect("/business/edit/bus-works-list/tp/1", True)
                Else
                    Response.Redirect("/home/tuyen-dung/" & Request.Item("tuyen-dung"), True)
                End If
            ElseIf Request.Item("tim-kiem") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&tim-kiem=" & Request.Item("tim-kiem")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Response.Redirect("/business/view/bus-profile-suit", True)
                Else
                    Response.Redirect("/home/tim-kiem/" & Request.Item("tim-kiem"), True)
                End If
            ElseIf Request.Item("kham-pha") & "" <> "" Then
                If Me.UserInfo.IsInRole("users") = True Then
                    _tabName = "users"
                    _logIn = "home?ctl=logoff&kham-pha=" & Request.Item("kham-pha")
                    lbTbao.Text = "Chức năng dành cho Nhà tuyển dụng, vui lòng <a class=""noti-hotline"" style=""color: blue"" href=""/" & _logIn & """>đăng nhập</a> bằng tài khoản Nhà tuyển dụng để tiếp tục"
                ElseIf Me.UserInfo.IsInRole("business") = True Then
                    Response.Redirect("/business/view/bus-jobuser", True)
                Else
                    Response.Redirect("/home/kham-pha/" & Request.Item("kham-pha"), True)
                End If
            Else
                Response.Redirect("/", True)
            End If
        End Sub

    End Class

End Namespace
