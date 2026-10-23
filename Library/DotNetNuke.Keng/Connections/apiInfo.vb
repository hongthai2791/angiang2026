Public Class PostInfo
    Public Property post_ID As Integer
    Public Property postShareID As Integer
    Public Property appID As String
    Public Property contents As String
    Public Property contentFull As String
    Public Property createdDate As String
    Public Property publicAll As Boolean
    Public Property onlyMe As Boolean
    Public Property friends As Boolean
    Public Property avatar As String
    Public Property fullName As String
    Public Property isLike As Integer
    Public Property isShare As Integer
    Public Property isComment As Integer
    Public Property myLike As Boolean
    Public Property myShare As Boolean
    Public Property total As Integer
    Public Property fileImg As ArrayList
    Public Property fileVideo As ArrayList
    Public Property postShare As PostShareInfo
End Class
Public Class PostShareInfo
    Public Property post_ID As Integer
    Public Property appID As String
    Public Property contents As String
    Public Property contentFull As String
    Public Property createdDate As String
    Public Property avatar As String
    Public Property fullName As String
    Public Property shareImg As ArrayList
    Public Property shareVideo As ArrayList
End Class
Public Class FileAttachInfo
    Public Property attach_ID As String
    Public Property fileAttach As String
    Public Property isOrder As Integer
    Public Property total As Integer
End Class
Public Class CommentInfo
    Public Property postID As String
    Public Property appID As String
    Public Property appName As String
    Public Property avatar As String
    Public Property contents As String
    Public Property createdDate As String
    Public Property total As Integer

End Class
Public Class LikesInfo
    Public Property likesID As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property avatar As String
    Public Property createdDate As String
    Public Property friends As Boolean
    Public Property total As Integer

End Class
Public Class SharePostInfo
    Public Property sharePost_ID As Integer
    Public Property avatar As String
    Public Property createdDate As String
    Public Property shareAppID As String
    Public Property shareAppName As String
    Public Property friends As Boolean
    Public Property total As Integer
End Class
Public Class LeaveOfAbsInfo

    Public Property leaveOfAbs_ID As String
    Public Property businessID As Integer
    Public Property businessName As String
    Public Property employeeCode As String
    Public Property employeeName As String
    Public Property departmentCode As String
    Public Property appID As String
    Public Property appToken As String
    Public Property fromDate As String
    Public Property toDate As String
    Public Property reason As String
    Public Property comments As String
    Public Property receiveID As String
    Public Property receiveName As String
    Public Property fcmToken As String
    Public Property reAppID As String
    Public Property receiveDep As String
    Public Property notiName As String
    Public Property createdDate As String
    Public Property isActive As Integer
    Public Property activeDate As String
    Public Property total As Integer
    Public Property reCount As Integer
    Public Property unActive As Integer
    Public Property isCancel As Boolean
    Public Property reasonUnActive As String
    Public Property unActiveDate As String
    Public Property reasonCancel As String
    Public Property cancelDate As String
    Public Property reasonUnCancel As String
    Public Property unCancelDate As String
    Public Property acCancelDate As String
    Public Property cancelSendReason As String
    Public Property cancelSendDate As String
    Public Property tokenManager As ArrayList
End Class
Public Class ChatBoxInfo
    Public Property Total As Integer
    Public Property years As Integer
    Public Property months As Integer
    Public Property days As Integer
    Public Property arrChat As ArrayList

End Class
Public Class ChatInfo
    Public Property years As Integer
    Public Property months As Integer
    Public Property days As Integer
    Public Property chat_ID As String
    Public Property fromAppID As String
    Public Property toAppID As String
    Public Property fromAvatar As String
    Public Property toAvatar As String
    Public Property fromName As String
    Public Property toName As String
    Public Property contents As String
    Public Property isStatus As Integer
    Public Property statusName As String
    Public Property createdDate As String
    Public Property timeChat As String
    Public Property isFile As String
    Public Property total As Integer
    Public Property groupID As Integer
End Class
Public Class friendInfo
    Public Property appID As String
    Public Property appName As String
    Public Property statusName As String
    Public Property createdDate As String
    Public Property total As Integer
    Public Property statusID As Integer
End Class
Public Class userHeartInfo
    Public Property iD As Integer
    Public Property appID As String
    Public Property toAppID As String
    Public Property hoTen As String
    Public Property tuoi As String
    Public Property gioiTinh As Boolean
    Public Property moiQT As Boolean
    Public Property gioiThieu As String
    Public Property tinhTP As Integer
    Public Property quanHuyen As Integer
    Public Property xaPhuong As Integer
    Public Property duongPho As String
    Public Property ngheNghiep As String
    Public Property congTy As String
    Public Property chieuCao As String
    Public Property dangVoc As String
    Public Property tonGiao As String
    Public Property mauToc As String
    Public Property mauMat As String
    Public Property nhomMau As String
    Public Property cacMoiQH As String
    Public Property conCai As String
    Public Property hutThuoc As String
    Public Property uongRB As String
    Public Property cheDoAn As ArrayList
    Public Property cheDoAnStr As String
    Public Property hocVan As String
    Public Property tinhCach As ArrayList
    Public Property phongCachTT As ArrayList
    Public Property soThich As ArrayList
    Public Property tinhCachStr As String
    Public Property phongCachTTStr As String
    Public Property soThichStr As String
    Public Property tuVi As String
    Public Property anhDaiDien As String
    Public Property logoPath As String
    Public Property ghiChu As String
    Public Property ghiChustr As String
    Public Property isOnline As Boolean
    Public Property isOnlineName As String
    Public Property viTri As String
    Public Property namSinh As String
    Public Property thangSinh As String
    Public Property ngaySinh As String
    Public Property thuNhap As String
    Public Property lastComment As String
    Public Property fromAppID As String
    Public Property total As Integer
End Class
Public Class userChatRunInfo
    Public Property fromAppID As String
    Public Property fromAppName As String
    Public Property fromAppLogo As String
    Public Property fromFcmToken As String
    Public Property toAppID As String
    Public Property toAppName As String
    Public Property toAppLogo As String
    Public Property toFcmToken As String
End Class
Public Class catedetailInfo
    Public Property cateDetail_ID
    Public Property cateDetail_Name
End Class
Public Class appFriend
    Public Property total As Integer
    Public Property satatus As Integer
    Public Property friends As Boolean
    Public Property friendName As String
    Public Property logoAvatar As String
    Public Property hoVaTen As String
    Public Property ngaySinh As String
    Public Property soBHXH As String
    Public Property soCMND As String
    Public Property appID As String
    Public Property gioiTinh As Integer
End Class
Public Class RelationShipInfo
    Public Property iD As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property status As Integer
    Public Property trangThai As String
    Public Property createdDate As String
    Public Property isFriend As Integer
    Public Property total As Integer
End Class
Public Class questionInfo
    Public Property appID As String
    Public Property businessID As String
    Public Property businessName As String
    Public Property departmentCode As String
    Public Property employeeCode As String
    Public Property years As String
    Public Property months As String
    Public Property isType As Integer
    Public Property total As Integer
    Public Property quesAnswer As ArrayList
End Class
Public Class answerInfo
    Public Property question_ID As String
    Public Property question As String
    Public Property quDate As String
    Public Property answer As String
    Public Property anDate As String
    Public Property frequent As Boolean
    Public Property status As Integer
    Public Property total As Integer
End Class
Public Class employeeInfo
    Public Property employee_ID As String
    Public Property employeeName As String
    Public Property appID As String
    Public Property appLogo As String
    Public Property status As String
    Public Property isManager As String
    Public Property businessID As String
    Public Property employeeCode As String
    Public Property departmentCode As String
    Public Property fcmToken As String
    Public Property createdDate As String
    Public Property total As Integer
    Public Property isNew As Integer
    Public Property isUsers As Integer
    Public Property chatDate As DateTime
    Public Property groupID As Integer
End Class
Public Class NotifyInfo
    Public Property iD As Integer
    Public Property fromApp As String
    Public Property toApp As String
    Public Property contents As String
    Public Property createdDate As String
    Public Property toLink As String
    Public Property idKey As String
    Public Property total As Integer
End Class
Public Class RoomInfo
    Public Property tokenManager As ArrayList
    Public Property roomID As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property tieuDe As String
    Public Property noiDung As String
    Public Property loaiPhong As String
    Public Property tenPhong As String
    Public Property soPhong As Integer
    Public Property sucChua As Integer
    Public Property gioiTinh As String
    Public Property dienTich As Double
    Public Property giaPhong As String
    Public Property datCoc As String
    Public Property tienDien As String
    Public Property tienNuoc As String
    Public Property tienMang As String
    Public Property tinhTP As String
    Public Property quanHuyen As String
    Public Property xaPhuong As String
    Public Property duongPho As String
    Public Property dienThoaiLH As String
    Public Property gioMoCua As String
    Public Property gioDongCua As String
    Public Property isStatus As Integer
    Public Property createDate As String
    Public Property UpdateUser As String
    Public Property UpdateDate As String
    Public Property total As Integer
    Public Property roomC As ArrayList
    Public Property roomU As ArrayList
    Public Property roomF As ArrayList
End Class
Public Class RoomCInfo
    Public Property roomID As String
    Public Property appID As String
    Public Property appLogo As String
    Public Property reply As String
    Public Property appName As String
    Public Property contents As String
    Public Property createdDate As String
    Public Property total As Integer
End Class
Public Class RoomFInfo
    Public Property attach_ID As String
    Public Property roomID As Integer
    Public Property fileAttach As String
    Public Property fileType As Integer
    Public Property isOrder As Integer
    Public Property total As Integer
End Class
Public Class RoomUInfo
    Public Property iD As Integer
    Public Property roomID As Integer
    Public Property utilityID As Integer
    Public Property utilityLogo As String
    Public Property utilityName As String
    Public Property total As Integer

End Class
Public Class ShareUserInfo
    Public Property post_ID As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property appFriend As Boolean
    Public Property total As Integer

End Class
Public Class CalenderInfo
    Public Property iD As Integer
    Public Property busID As Integer
    Public Property calName As String
    Public Property years As Integer
    Public Property calender As String
    Public Property createdDate As String
    Public Property total As Integer

End Class
Public Class FrPostInfo
    Public Property post_ID As Integer
    Public Property uID As Integer
    Public Property postShareID As Integer
    Public Property groupID As String
    Public Property groupLogo As String
    Public Property groupName As String
    Public Property appID As String
    Public Property appToken As String
    Public Property brithDay As String
    Public Property isBrithDay As Boolean
    Public Property logoBrithDay As String
    Public Property contents As String
    Public Property contentFull As String
    Public Property title As String
    Public Property contentEdit As String
    Public Property createdDate As String
    Public Property publicAll As Boolean
    Public Property onlyMe As Boolean
    Public Property friends As Boolean
    Public Property avatar As String
    Public Property fullName As String
    Public Property isLike As Integer
    Public Property isShare As Integer
    Public Property isComment As Integer
    Public Property myLike As Boolean
    Public Property myShare As Boolean
    Public Property total As Integer
    Public Property imgTotal As Integer
    Public Property imgTop As String
    Public Property loiChuc As String
    Public Property fileImg As ArrayList
    Public Property fileVideo As ArrayList
    Public Property postShare As FrPostShareInfo
    Public Property frGroup As FrGroupInfo
End Class
Public Class FrPostShareInfo
    Public Property post_ID As Integer
    Public Property appID As String
    Public Property contents As String
    Public Property contentFull As String
    Public Property createdDate As String
    Public Property avatar As String
    Public Property fullName As String
    Public Property shareImg As ArrayList
    Public Property shareVideo As ArrayList
End Class
Public Class FrFileAttachInfo
    Public Property attach_ID As String
    Public Property fileAttach As String
    Public Property isOrder As Integer
    Public Property total As Integer
End Class
Public Class FrCommentInfo
    Public Property postID As String
    Public Property appID As String
    Public Property appName As String
    Public Property avatar As String
    Public Property contents As String
    Public Property reply As String
    Public Property createdDate As String
    Public Property total As Integer

End Class
Public Class FrLikesInfo
    Public Property likesID As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property avatar As String
    Public Property createdDate As String
    Public Property total As Integer

End Class
Public Class FrSharePostInfo
    Public Property sharePost_ID As Integer
    Public Property avatar As String
    Public Property createdDate As String
    Public Property shareAppID As String
    Public Property shareAppName As String
    Public Property total As Integer
End Class
Public Class FrShareUserInfo
    Public Property post_ID As Integer
    Public Property eID As String
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property total As Integer

End Class
Public Class FrNotifyInfo
    Public Property iD As Integer
    Public Property uID As Integer
    Public Property fromApp As String
    Public Property toApp As String
    Public Property contents As String
    Public Property createdDate As String
    Public Property toLink As String
    Public Property idKey As String
    Public Property total As Integer
    Public Property allPuclic As Boolean
    Public Property appID As String
    Public Property flags As String

End Class
Public Class SalaryInfo

    Public Property salary_ID As String
    Public Property yearID As Integer
    Public Property monthID As String
    Public Property employeeCode As String
    Public Property departmentCode As String
    Public Property businessID As Integer
    Public Property chucDanh As String
    Public Property luongThang As String
    Public Property gioLamThem As String
    Public Property troCapDem As String
    Public Property phuCap As String
    Public Property dCTang As String
    Public Property dCGiam As String
    Public Property dMVS As String
    Public Property baoHiem As String
    Public Property phiCongDoan As String
    Public Property thuePIT As String
    Public Property thucLinh As String
    Public Property isOrder As Integer
    Public Property createdDate As String
    Public Property updatedDate As String
    Public Property isSent As Boolean
    Public Property isLock As Boolean
    Public Property total As Integer

End Class
Public Class TimeKeepInfo

    Public Property timeKeep_ID As String
    Public Property yearID As Integer
    Public Property monthID As String
    Public Property employeeCode As String
    Public Property employeeName As String
    Public Property departmentCode As String
    Public Property businessID As Integer
    Public Property nCTT As String
    Public Property phepP As String
    Public Property dacBietSP As String
    Public Property kLRo As String
    Public Property oTNgay As String
    Public Property oTDem As String
    Public Property gioCaDem As String
    Public Property vMRS As String
    Public Property hoTro As String = ""
    Public Property tCChuyenCan As String = ""
    Public Property tCKyNang As String = ""
    Public Property tCBanhMy As String = ""
    Public Property nghiLe As String
    Public Property soACN As String
    Public Property soACD As String
    Public Property ngayPhepCL As String
    Public Property isOrder As Integer
    Public Property createdDate As String
    Public Property updatedDate As String
    Public Property isSent As Boolean
    Public Property isLock As Boolean
    Public Property total As Integer
End Class
Public Class MissionInfo
    Public Property isDeleted As Boolean
    Public Property mission_ID As Integer
    Public Property appID As String
    Public Property appName As String
    Public Property uID As Integer
    Public Property dID As String
    Public Property eID As String
    Public Property eID_Name As String
    Public Property toDID As String
    Public Property toEID As String
    Public Property toEID_Name As String
    Public Property mission_Purpose As String
    Public Property mission_Departure As String
    Public Property mission_Arrival As String
    Public Property startDate As String
    Public Property startDay As String
    Public Property endDate As String
    Public Property isTimeKeep As Boolean
    Public Property reCar As Integer
    Public Property reCarName As String
    Public Property manageID As String
    Public Property manageDep As String
    Public Property manageActive As Boolean
    Public Property manageAcDate As String
    Public Property isApproval As Boolean
    Public Property approvalDate As String
    Public Property approvalUser As String
    Public Property carID As Integer
    Public Property carName As String
    Public Property driverName As String
    Public Property driverPhone As String
    Public Property driverNumber As String
    Public Property firstKm As String
    Public Property firstDate As String
    Public Property firstUser As String
    Public Property lastKm As String
    Public Property lastDate As String
    Public Property lastUser As String
    Public Property createdDate As String
    Public Property total As Integer
    Public Property isCancel As Boolean
    Public Property maCount As Integer
    Public Property unActive As Integer
    Public Property manageAppID As String
    Public Property toAppID As String
    Public Property appToken As String
    Public Property toToken As String
    Public Property manageToken As String
    Public Property tokenManager As ArrayList

End Class
Public Class meetingRoom
    Public Property mR_ID As Integer
    Public Property mR_Name As String
    Public Property mrHour As ArrayList
End Class
Public Class MeetingHourInfo
    Public Property hourName As String
    Public Property hour00 As String
    Public Property hour00_ID As String
    Public Property hour00_MeID As String
    Public Property hour00_eID As String
    Public Property hour00_Name As String
    Public Property hour00_End As String
    Public Property hour30 As String
    Public Property hour30_ID As String
    Public Property hour30_MeID As String
    Public Property hour30_eID As String
    Public Property hour30_Name As String
    Public Property hour30_End As String
End Class
Public Class meetingTimeInfo
    Public Property mt_ID As String
    Public Property mt_Name As String
End Class
Public Class MeetingInfo

    Public Property meeting_ID As Integer
    Public Property appID As String
    Public Property uID As Integer
    Public Property dID As String
    Public Property eID As String
    Public Property eName As String
    Public Property mR_ID As Integer
    Public Property mR_Name As String
    Public Property meetingName As String
    Public Property leaderName As String
    Public Property startDate As String
    Public Property endDate As String
    Public Property createdDate As String
    Public Property total As Integer

End Class
Public Class FrGroupInfo
    Public Property iD As Integer
    Public Property uID As Integer
    Public Property eID As String
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property name As String
    Public Property title As String
    Public Property logo As String
    Public Property des As String
    Public Property isStatus As Integer
    Public Property createdDate As String
    Public Property updatedDate As String
    Public Property total As Integer
    Public Property uTotal As Integer
    Public Property pTotal As Integer
End Class
Public Class FrGroupUInfo

    Public Property iD As Integer
    Public Property groupID As Integer
    Public Property eID As String
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property createdDate As String
    Public Property total As Integer
    Public Property isBoss As Boolean

End Class
Public Class ngayDayPhongInfo
    Public Property t2 As String
    Public Property t2_Cls As String
    Public Property t3 As String
    Public Property t3_Cls As String
    Public Property t4 As String
    Public Property t4_Cls As String
    Public Property t5 As String
    Public Property t5_Cls As String
    Public Property t6 As String
    Public Property t6_Cls As String
    Public Property t7 As String
    Public Property t7_Cls As String
    Public Property cn As String
    Public Property cn_Cls As String

End Class
Public Class groupChatInfo
    Public Property iD As Integer
    Public Property uID As Integer
    Public Property eID As String
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property name As String
    Public Property title As String
    Public Property logo As String
    Public Property isStatus As Integer
    Public Property createdDate As String
    Public Property updatedDate As String
    Public Property total As Integer
    Public Property isUsers As Integer
    Public Property fcmToken As ArrayList
End Class
Public Class groupChatUInfo

    Public Property iD As Integer
    Public Property groupID As Integer
    Public Property eID As String
    Public Property appID As String
    Public Property appName As String
    Public Property appLogo As String
    Public Property createdDate As String
    Public Property isBoss As Boolean
    Public Property total As Integer

End Class
Public Class fcmTokenInfo
    Public Property appID As String
    Public Property token As String
End Class
