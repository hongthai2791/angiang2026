Public Class AppInfo
    Public Property tinhTP As Integer
    Public Property quanHuyen As Integer
    Public Property appKey As String = ""
    Public Property appID As String = ""
    Public Property hoVaTen As String = ""
    Public Property dienThoai As String = ""
    Public Property gioiTinh As Integer
    Public Property isLevel As Integer
    Public Property isPoint As Integer
    Public Property ngaySinh As String = ""
    Public Property thangSinh As String = ""
    Public Property namSinh As String = ""
    Public Property avatar As String = ""
    Public Property tenTinh As String = ""
    Public Property tenHuyen As String = ""
    Public Property logoAvatar As String = ""
    Public Property logoPath As String = ""
    Public Property createDate As String = ""
End Class
Public Class GroupInfo
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property des As String = ""
    Public Property total As Integer
    Public Property bool As Boolean
End Class
Public Class GroupDInfo
    Public Property iD As Integer
    Public Property uID As String = ""
    Public Property groupID As Integer
    Public Property images As String = ""
    Public Property icon As String = ""
    Public Property name As String = ""
    Public Property nameEdit As String = ""
    Public Property writer As String = ""
    Public Property isActive As Boolean
    Public Property isLike As Integer
    Public Property total As Integer
    Public Property bool As Boolean
    Public Property blike As Boolean
End Class
Public Class ChapterInfo
    Public Property iD As Integer
    Public Property storyID As Integer
    Public Property name As String = ""
    Public Property storyName As String = ""
    Public Property contents As String = ""
    Public Property isView As Integer
    Public Property isComment As Integer
    Public Property isPublic As Boolean
    Public Property pages As Integer
    Public Property total As Integer
End Class
Public Class StoryInfo
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property logo As String = ""
    Public Property categoryName As String = ""
    Public Property description As String = ""
    Public Property author As String = ""
    Public Property status As String = ""
    Public Property source As String = ""
    Public Property isView As Integer
    Public Property isLike As Integer
    Public Property isComment As Integer
    Public Property isPublic As Boolean
    Public Property isChapter As Integer
    Public Property chapter As Integer
    Public Property updatedDate As String = ""
    Public Property createdDate As String = ""
    Public Property total As Integer
    Public Property chapterList As ArrayList

End Class
Public Class StoryCInfo
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property logo As String = ""
    Public Property des As String = ""
    Public Property total As Integer
    Public Property storyList As ArrayList
End Class
Public Class StoryFBInfo
    Public Property iD As Integer
    Public Property storyID As Integer
    Public Property appID As String = ""
    Public Property contents As String = ""
    Public Property writer As String = ""
    Public Property createdDate As String = ""
    Public Property updatedDate As String = ""
    Public Property total As Integer
End Class
Public Class VideoInfo

    Public Property videoID As Integer
    Public Property portalID As Integer
    Public Property cateID As Integer
    Public Property cateName As String = ""
    Public Property titles As String = ""
    Public Property toUrl As String = ""
    Public Property images As String = ""
    Public Property summary As String = ""
    Public Property writer As String = ""
    Public Property isYoutube As Boolean
    Public Property mediaUrl As String = ""
    Public Property isView As Integer
    Public Property isLike As Integer
    Public Property publishedDate As String = ""
    Public Property total As Integer
End Class
Public Class AdMobInfo
    Public Property iD As Integer
    Public Property a_Version As String = ""
    Public Property a_LinkUp As String = ""
    Public Property i_LinkUp As String = ""
    Public Property a_ID As String = ""
    Public Property a_BieuNgu As String = ""
    Public Property a_TangThuong As String = ""
    Public Property a_NangCao As String = ""
    Public Property a_Testing As Boolean
    Public Property i_Version As String = ""
    Public Property i_ID As String = ""
    Public Property i_BieuNgu As String = ""
    Public Property i_TangThuong As String = ""
    Public Property i_NangCao As String = ""
    Public Property description As String = ""
    Public Property i_Testing As Boolean
    Public Property portalID As Integer

End Class
Public Class AdvertiseInfo
    Public Property advertise_ID As String = ""
    Public Property advertise_Name As String = ""
    Public Property images As String = ""
    Public Property urlApp As String = ""
    Public Property urlAndroid As String = ""
    Public Property urlIos As String = ""
    Public Property urlWeb As String = ""
    Public Property target As String = ""
End Class
Public Class RandomInfo
    Public Property iD1 As Integer
    Public Property name1 As String = ""
    Public Property logo1 As String = ""

    Public Property iD2 As Integer
    Public Property name2 As String = ""
    Public Property logo2 As String = ""
End Class
Public Class FrPostInfo
    Public Property post_ID As Integer
    Public Property portalID As Integer
    Public Property postShareID As Integer
    Public Property groupID As String = ""
    Public Property groupLogo As String = ""
    Public Property groupName As String = ""
    Public Property appID As String = ""
    Public Property appToken As String = ""
    Public Property brithDay As String = ""
    Public Property isBrithDay As Boolean
    Public Property logoBrithDay As String = ""
    Public Property contents As String = ""
    Public Property contentFull As String = ""
    Public Property title As String = ""
    Public Property contentEdit As String = ""
    Public Property createdDate As String = ""
    Public Property publicAll As Boolean
    Public Property onlyMe As Boolean
    Public Property isLock As Boolean
    Public Property friends As Boolean
    Public Property avatar As String = ""
    Public Property fullName As String = ""
    Public Property isLike As Integer
    Public Property isShare As Integer
    Public Property isType As Integer
    Public Property isComment As Integer
    Public Property myLike As Boolean
    Public Property myShare As Boolean
    Public Property total As Integer
    Public Property imgTotal As Integer
    Public Property imgTop As String = ""
    Public Property loiChuc As String = ""
    Public Property fileImg As ArrayList
    Public Property fileVideo As ArrayList
    Public Property commentList As ArrayList
    Public Property postShare As FrPostShareInfo
    Public Property frGroup As FrGroupInfo
End Class
Public Class FrPostShareInfo
    Public Property post_ID As Integer
    Public Property appID As String = ""
    Public Property contents As String = ""
    Public Property contentFull As String = ""
    Public Property createdDate As String = ""
    Public Property avatar As String = ""
    Public Property fullName As String = ""
    Public Property shareImg As ArrayList
    Public Property shareVideo As ArrayList
End Class
Public Class FrFileAttachInfo
    Public Property attach_ID As String = ""
    Public Property fileAttach As String = ""
    Public Property isOrder As Integer
    Public Property total As Integer
End Class
Public Class FrCommentInfo
    Public Property commentID As Integer
    Public Property postID As Integer
    Public Property appID As String = ""
    Public Property appName As String = ""
    Public Property avatar As String = ""
    Public Property contents As String = ""
    Public Property reply As String = ""
    Public Property createdDate As String = ""
    Public Property total As Integer

End Class
Public Class FrLikesInfo
    Public Property likesID As Integer
    Public Property appID As String = ""
    Public Property appName As String = ""
    Public Property avatar As String = ""
    Public Property createdDate As String = ""
    Public Property total As Integer

End Class
Public Class FrSharePostInfo
    Public Property sharePost_ID As Integer
    Public Property avatar As String = ""
    Public Property createdDate As String = ""
    Public Property shareAppID As String = ""
    Public Property shareAppName As String = ""
    Public Property total As Integer
End Class
Public Class FrShareUserInfo
    Public Property post_ID As Integer
    Public Property appID As String = ""
    Public Property appName As String = ""
    Public Property appLogo As String = ""
    Public Property total As Integer

End Class
Public Class FrNotifyInfo
    Public Property iD As Integer
    Public Property portalID As Integer
    Public Property fromApp As String = ""
    Public Property toApp As String = ""
    Public Property contents As String = ""
    Public Property createdDate As String = ""
    Public Property toLink As String = ""
    Public Property idKey As String = ""
    Public Property total As Integer
    Public Property allPuclic As Boolean
    Public Property appID As String = ""
    Public Property flags As String = ""

End Class
Public Class FrGroupInfo
    Public Property groupID As Integer
    Public Property isYear As Integer
    Public Property isType As Integer
    Public Property typeName As String = ""
    Public Property groupName As String = ""
    Public Property groupLogo As String = ""
    Public Property des As String = ""
    Public Property isStatus As Integer
    Public Property total As Integer
    Public Property isUse As Integer
    Public Property uTotal As Integer
    Public Property pTotal As Integer
    Public Property listGroup As ArrayList

End Class
Public Class FrGroupUInfo

    Public Property iD As Integer
    Public Property groupID As Integer
    Public Property appID As String = ""
    Public Property appName As String = ""
    Public Property appLogo As String = ""
    Public Property createdDate As String = ""
    Public Property total As Integer
    Public Property isBoss As Boolean
    Public Property isLock As Boolean

End Class
Public Class FoodInfo
    Public Property logo As String = ""
    Public Property iD As Integer
    Public Property foodCID As Integer
    Public Property foodCName As String = ""
    Public Property name As String = ""
    Public Property trophic As String = ""
    Public Property pregnantStatus As Byte
    Public Property pregnantDes As String = ""
    Public Property postpartumStatus As Byte
    Public Property postpartumDes As String = ""
    Public Property breastfeedingStatus As Byte
    Public Property breastfeedingDes As String = ""
    Public Property babyStatus As Byte
    Public Property babyDes As String = ""
    Public Property nguon As String = ""
    Public Property isPublic As Boolean
    Public Property total As Integer
End Class
Public Class FoodCInfo

    Public Property iD As Integer
    Public Property name As String = ""
    Public Property des As String = ""
    Public Property logo As String = ""
    Public Property portalID As Integer
    Public Property createDate As String = ""
    Public Property createUser As String = ""
    Public Property updateDate As String = ""
    Public Property updateUser As String = ""
    Public Property total As Integer
End Class
Public Class RegionalInfo
    Public Property regional_ID As String = ""
    Public Property regional_Name As String = ""
End Class
Public Class RelationInfo
    Public Property relation_ID As String = ""
    Public Property relation_Name As String = ""
End Class
Public Class CategoryInfo
    Public Property categoryID As Integer
    Public Property categoryName As String = ""
    Public Property description As String = ""
    Public Property isActive As Boolean
    Public Property portalID As Integer
    Public Property parentId As Integer
    Public Property orders As Integer
    Public Property isType As Integer
    Public Property total As Integer
    Public Property tabPath As String = ""
    Public Property tabID As Integer
    Public Property imagePath As String = ""
End Class
Public Class NewsInfo
    Public Property newsID As Integer
    Public Property portalID As Integer
    Public Property cateID As Integer
    Public Property introduction As String = ""
    Public Property titles As String = ""
    Public Property toUrl As String = ""
    Public Property imagePath As String = ""
    Public Property summary As String = ""
    Public Property contents As String = ""
    Public Property links As String = ""
    Public Property tags As String = ""
    Public Property writerName As String = ""
    Public Property isLike As Integer
    Public Property isView As Integer
    Public Property publishedDate As String = ""
    Public Property total As Integer
End Class
Public Class clinicInfo
    Public Property portalID As Integer
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property description As String = ""
    Public Property workTime As String = ""
    Public Property doctors As String = ""
    Public Property hospital As String = ""
    Public Property mobile As String = ""
    Public Property isType As String = ""
    Public Property tinhTP As String = ""
    Public Property quanHuyen As String = ""
    Public Property xaPhuong As String = ""
    Public Property duongPho As String = ""
    Public Property latitude As Double
    Public Property longitude As Double
    Public Property km_New As Double
    Public Property logo As String = ""
    Public Property total As Integer
    Public Property rAVG As Double
    Public Property rMyApp As Integer
    Public Property rTotal As Integer
    Public Property cTotal As Integer
    Public Property r5 As Integer
    Public Property r4 As Integer
    Public Property r3 As Integer
    Public Property r2 As Integer
    Public Property r1 As Integer

End Class
Public Class cookingCInfo
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property des As String = ""
    Public Property logo As String = ""
    Public Property portalID As Integer
    Public Property total As Integer
End Class
Public Class cookingInfo
    Public Property iD As Integer
    Public Property portalID As Integer
    Public Property logo As String = ""
    Public Property name As String = ""
    Public Property cookTime As Integer
    Public Property difficultLevel As String = ""
    Public Property mealType As String = ""
    Public Property cookingType As String = ""
    Public Property tasteType As String = ""
    Public Property spiceType As String = ""
    Public Property material As String = ""
    Public Property making As String = ""
    Public Property isView As Integer
    Public Property total As Integer
    Public Property cookingC As ArrayList
End Class
Public Class cookingDInfo
    Public Property iD As Integer
    Public Property name As String = ""
    Public Property isType As Integer
    Public Property total As Integer
End Class
Public Class crushInfo
    Public Property iD As Integer
    Public Property appID As String = ""
    Public Property hoTen As String = ""
    Public Property logo As String = ""
    Public Property logoPath As String = ""
    Public Property dienThoai As String = ""
    Public Property namSinh As Integer
    Public Property gioiTinh As String = ""
    Public Property portalID As Integer
    Public Property isReg As Boolean
    Public Property createdDate As String = ""
    Public Property updatedDate As String = ""
    Public Property total As Integer
End Class
Public Class CookingOInfo

    Public Property iD As Integer
    Public Property cookingID As Integer
    Public Property cateID As Integer
    Public Property cateName As String = ""
    Public Property total As Integer
End Class
Public Class frPostGroupInfo
    Public Property post_ID As Integer
    Public Property groupName As String = ""
    Public Property groupLogo As String = ""
    Public Property groupID As Integer
    Public Property total As Integer
End Class
Public Class clinicRInfo
    Public Property iD As Integer
    Public Property portalID As Integer
    Public Property appID As String = ""
    Public Property clinicID As Integer
    Public Property isRate As Integer
    Public Property createdUser As String = ""
    Public Property createdDate As String = ""
    Public Property updatedUser As String = ""
    Public Property updatedDate As String = ""
    Public Property total As Integer
End Class
Public Class clinicCInfo
    Public Property portalID As Integer
    Public Property iD As Integer
    Public Property clinicID As Integer
    Public Property appID As String = ""
    Public Property contents As String = ""
    Public Property reply As String = ""
    Public Property isLock As Boolean
    Public Property lockedUser As String = ""
    Public Property lockedDate As String = ""
    Public Property createdDate As String = ""
    Public Property updatedDate As String = ""
    Public Property isDelete As Boolean
    Public Property deletedDate As String = ""
    Public Property total As Integer
End Class
Public Class doanHinhInfo
    Public Property iD As String = ""
    Public Property tenCauHoi As String = ""
    Public Property hinhAnh As String = ""
    Public Property dapAnVI As String = ""
    Public Property dapAnEN As String = ""
    Public Property dong1 As Integer
    Public Property dong2 As Integer
    Public Property soKyTu As Integer
    Public Property phimNhap As String = ""
    Public Property kyTuSai As String = ""
    Public Property mucDo As Integer
    Public Property soDiem As Integer
    Public Property moDapAn As Integer
    Public Property moChuCai As Integer
    Public Property boChuCai As Integer
End Class
Public Class valueInfo
    Public Property name As String = ""
    Public Property value As String = ""

End Class
Public Class vacXinInfo
    Public Property iD As Integer
    Public Property tenVacXin As String = ""
    Public Property tiemPhong As String = ""
    Public Property denLichTiem As String = ""
    Public Property benh As String = ""
    Public Property noiDung As String = ""
    Public Property phanUngPhu As String = ""
    Public Property batBuoc As Boolean
    Public Property mui1 As Integer
    Public Property mui2 As Integer
    Public Property mui3 As Integer
    Public Property mui4 As Integer
    Public Property mui5 As Integer
    Public Property trangThai As Integer
    Public Property mtotal As Integer
    Public Property thangtuoi As String = ""

End Class
Public Class muiTiemInfo
    Public Property muiTiemID As Integer
    Public Property vacXin_iD As Integer
    Public Property muiTiem As Integer
    Public Property thangTuoi As String = ""
    Public Property moTa As String = ""
    Public Property tinhTrang As Integer
End Class
Public Class treEmInfo
    Public Property iD As Integer
    Public Property logo As String = ""
    Public Property paths As String = ""
    Public Property tenBe As String = ""
    Public Property tenONha As String = ""
    Public Property groupID As Integer
    Public Property pLoai As Integer
    Public Property soKB As Integer
    Public Property trangThai As Integer
    Public Property ngaySinh As String = ""
    Public Property sinhD As String = ""
    Public Property sinhM As String = ""
    Public Property sinhY As String = ""
    Public Property ngayDuSinh As String = ""
    Public Property duSinhD As String = ""
    Public Property duSinhM As String = ""
    Public Property duSinhY As String = ""
    Public Property gioiTinh As Integer
    Public Property ghiChu As String = ""
    Public Property total As Integer
    Public Property chieuCao As String = ""
    Public Property canNang As String = ""
    Public Property tuoi As String = ""
    Public Property thangTuoi As Integer
End Class
Public Class tiemChungInfo
    Public Property iD As Integer
    Public Property treEm_ID As Integer
    Public Property vacXin_ID As Integer
    Public Property tiemPhong As String = ""
    Public Property muiTiem As String = ""
    Public Property ngayTiem As String = ""
    Public Property thangTiem As String = ""
    Public Property namTiem As String = ""
    Public Property trangThai As Integer
    Public Property LoGo As String = ""


End Class
Public Class mocRangInfo
    Public Property iD As Integer
    Public Property tEID As Integer
    Public Property hinhAnh As String = ""
    Public Property ngayMoc As String = ""
    Public Property ngay As String = ""
    Public Property thang As String = ""
    Public Property nam As String = ""
    Public Property rangSo As Integer
    Public Property trangThai As Integer
    Public Property ghiChu As String = ""
End Class
Public Class rangInfo
    Public Property c1 As Integer
    Public Property c2 As Integer
    Public Property c3 As Integer
    Public Property c4 As Integer
    Public Property c5 As Integer
    Public Property c6 As Integer
    Public Property c7 As Integer
    Public Property c8 As Integer
    Public Property c9 As Integer
    Public Property c10 As Integer
    Public Property c11 As Integer
    Public Property c12 As Integer
    Public Property c13 As Integer
    Public Property c14 As Integer
    Public Property c15 As Integer
    Public Property c16 As Integer
    Public Property c17 As Integer
    Public Property c18 As Integer
    Public Property c19 As Integer
    Public Property c20 As Integer

End Class
Public Class khamThaiInfo
    Public Property iD As Integer
    Public Property teID As Integer
    Public Property thaiTuan As String = ""
    Public Property noiDung As String = ""
    Public Property tinhTrang As Integer
End Class
Public Class khamThaiDInfo
    Public Property iD As Integer
    Public Property teID As Integer
    Public Property khamThai_ID As Integer
    Public Property thaiTuan As String = ""
    Public Property noiDung As String = ""
    Public Property tinhTrang As Integer
    Public Property ngayKham As String
    Public Property thangKham As String
    Public Property namKham As String
End Class
Public Class anhBeInfo
    Public Property iD As Integer
    Public Property appID As String = ""
    Public Property treEm_ID As Integer
    Public Property ngayDang As String
    Public Property ghiChu As String = ""
    Public Property total As Integer
    Public Property anhBeD As ArrayList
End Class
Public Class anhBeDInfo
    Public Property iD As Integer
    Public Property aID As Integer
    Public Property hinhAnh As String = ""
    Public Property duongDan As String = ""
    Public Property total As Integer
End Class
Public Class theoDoiTEInfo
    Public Property iD As Integer
    Public Property appID As String = ""
    Public Property tEID As Integer
    Public Property thangTuan As Integer
    Public Property chieuCao As Double
    Public Property canNang As Double
    Public Property createdDate As String
End Class
Public Class cuDapInfo
    Public Property iD As Integer
    Public Property createdDate As String = ""
    Public Property lanDem As Integer
    Public Property mCD As Integer
    Public Property tlCD As String
    Public Property cuDap As Integer
    Public Property dap1 As Double
    Public Property dap2 As Double
    Public Property dap3 As Double
End Class
Public Class cuDapDInfo
    Public Property iD As Integer
    Public Property loai As Integer
    Public Property lanDem As Integer
    Public Property gioDem As String = ""
    Public Property phutDem As String = ""
    Public Property cuDapD As ArrayList
End Class
Public Class SurveyInfo
    Public Property survey_ID As Integer
    Public Property titles As String = ""
    Public Property contents As String = ""
    Public Property loGo As String = ""
    Public Property isType As Integer
    Public Property totalVote As Integer
    Public Property appReply As String
    Public Property surveyR As ArrayList
End Class
Public Class SurveyRInfo
    Public Property reply_ID As Integer
    Public Property titles As String = ""
    Public Property isReply As Integer
    Public Property isRate As Double
End Class
Public Class caoNangInfo
    Public Property month As Integer
    Public Property teCao As Double
    Public Property teNang As Double
    Public Property thap As Double
    Public Property binhThuong As Double
    Public Property cao As Double
End Class
Public Class babyHeightInfo
    Public Property iD As Integer
    Public Property month As Integer
    Public Property lowerLimit As String = ""
    Public Property normal As String = ""
    Public Property upperLimit As String = ""
    Public Property isSex As String = ""
    Public Property total As Integer
End Class
Public Class babyWeightInfo
    Public Property iD As Integer
    Public Property month As Integer
    Public Property underWeight As String = ""
    Public Property riskUnderWeight As String = ""
    Public Property normal As String = ""
    Public Property riskOverWeight As String = ""
    Public Property overWeight As String = ""
    Public Property isSex As Integer
    Public Property total As Integer
End Class
Public Class khamBenhInfo
    Public Property iD As Integer
    Public Property soKB_ID As Integer
    Public Property ngayKham As String = ""
    Public Property dKham As String = ""
    Public Property mKham As String = ""
    Public Property yKham As String = ""
    Public Property trieuChung As String = ""
    Public Property chuanDoan As String = ""
    Public Property donThuoc As String = ""
    Public Property chiPhi As Double
    Public Property ghiChu As String = ""
End Class
Public Class soKBInfo
    Public Property iD As Integer
    Public Property tEID As Integer
    Public Property hoTen As String = ""
    Public Property ngaySinh As String = ""
    Public Property dSinh As String = ""
    Public Property mSinh As String = ""
    Public Property ySinh As String = ""
    Public Property hinhAnh As String = ""
    Public Property tienSu As String = ""
    Public Property manCam As String = ""
    Public Property total As Integer
End Class
Public Class productInfo
    Public Property iD As Integer
    Public Property nhomSP As Integer
    Public Property tenNhomSP As String = ""
    Public Property brandID As Integer
    Public Property brandName As String = ""
    Public Property maSP As String = ""
    Public Property tenSP As String = ""
    Public Property anhDaiDien As String = ""
    Public Property giaBan As Double
    Public Property giaKM As Double
    Public Property sales As Double
    Public Property dVT As String = ""
    Public Property vAT As Double
    Public Property tichDiem As Double
    Public Property thuocTinh As String = ""
    Public Property moTa As String = ""
    Public Property isShop As Integer
    Public Property isView As Integer
    Public Property isComment As Integer
    Public Property isShare As Integer
    Public Property total As Integer
    Public Property productImg As ArrayList
    Public Property rAVG As Double
    Public Property rMyApp As Integer
    Public Property rTotal As Integer
    Public Property cTotal As Integer
    Public Property r5 As Integer
    Public Property r4 As Integer
    Public Property r3 As Integer
    Public Property r2 As Integer
    Public Property r1 As Integer
End Class
Public Class productBrandInfo
    Public Property iD As Integer
    Public Property thuongHieu As String = ""
    Public Property xuatXu As String = ""
    Public Property quiUoc As String = ""
    Public Property anhDaiDien As String = ""
    Public Property moTa As String = ""
    Public Property total As Integer
End Class
Public Class productCommentInfo
    Public Property iD As Integer
    Public Property productID As Integer
    Public Property appID As String = ""
    Public Property applogo As String = ""
    Public Property appName As String = ""
    Public Property contents As String = ""
    Public Property reply As String = ""
    Public Property createdDate As String = ""
    Public Property total As Integer
End Class
Public Class productGroupInfo
    Public Property iD As Integer
    Public Property tenNhom As String = ""
    Public Property anhDaiDien As String = ""
    Public Property ghiChu As String = ""
    Public Property parentID As Integer
    Public Property productList As ArrayList
End Class
Public Class productImgInfo
    Public Property iD As Integer
    Public Property productID As Integer
    Public Property paths As String = ""
End Class
Public Class productRateInfo
    Public Property iD As Integer
    Public Property appID As String = ""
    Public Property productID As Integer
    Public Property isRate As Decimal
    Public Property total As Integer
End Class
Public Class gameImgInfo
    Public Property isLevel As Integer
    Public Property adPoint As Integer
    Public Property isCup As Integer
    Public Property appID As String = ""
    Public Property appName As String = ""
    Public Property appLogo As String = ""
    Public Property appMobile As String = ""
End Class
Public Class shopByInfo
    Public Property iD As Integer
    Public Property maDonHang As String = ""
    Public Property appID As String = ""
    Public Property hoTen As String = ""
    Public Property mobile As String = ""
    Public Property telephone As String = ""
    Public Property diaChi As String = ""
    Public Property ghiChu As String = ""
    Public Property tongTien As Double
    Public Property tongVAT As Double
    Public Property portalID As Integer
    Public Property tinhTrang As Integer
    Public Property tenTinhTrang As String = ""
    Public Property ghDonViVC As String = ""
    Public Property ghNgayGiao As String = ""
    Public Property ghNguoiGiao As String = ""
    Public Property ghMaVC As String = ""
    Public Property ghCuocVC As Double
    Public Property ghCOD As Boolean
    Public Property ghTienThuHo As Double
    Public Property ghGhiChu As String = ""
    Public Property lyDoHuyDon As String = ""
    Public Property nguoiHuyDon As String = ""
    Public Property ngayHuyDon As String = ""
    Public Property CreatedDate As String = ""
    Public Property total As Integer
    Public Property shopPro As ArrayList
End Class
Public Class shopProInfo
    Public Property iD As Integer
    Public Property productID As Integer
    Public Property maSP As String = ""
    Public Property tenSP As String = ""
    Public Property anhDaiDien As String = ""
    Public Property donGia As Double
    Public Property soLuong As Double
    Public Property vAT As Double
    Public Property total As Integer
End Class
Public Class voucherAppInfo
    Public Property iD As Integer
    Public Property voucherID As Integer
    Public Property brandID As Integer
    Public Property brandName As String = ""
    Public Property appID As String = ""
    Public Property suDung As Boolean
    Public Property isSend As Boolean
    Public Property anhDaiDien As String = ""
    Public Property conLai As String = ""
    Public Property diemDoi As Double
    Public Property dieuKien As Double
    Public Property mucGiam As Double
    Public Property tuNgay As String = ""
    Public Property denNgay As String = ""
End Class
Public Class NotiSendInfo
    Public Property notiSend_ID As String
    Public Property titles As String
    Public Property contents As String
    Public Property fullContents As String
    Public Property idKey As String
    Public Property sendDate As String
    Public Property readDate As String
    Public Property tinhTrang As Integer
    Public Property logo As String
    Public Property fcmContent As String
    Public Property flags As String
    Public Property appID As String
    Public Property xemThem As Boolean
    Public Property total As Integer
End Class
Public Class lichNgayInfo
    Public Property t2 As String
    Public Property t3 As String
    Public Property t4 As String
    Public Property t5 As String
    Public Property t6 As String
    Public Property t7 As String
    Public Property cn As String
End Class