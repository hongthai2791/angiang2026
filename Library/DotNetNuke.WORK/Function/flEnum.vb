Public Enum FlagUser
    TatCa = 0
    NhaTuyenDung
    NguoiTimViec
    QuanTri
End Enum
Public Enum CommentStatus
    Created = 1
    Pulished 'Gửi mail và xuất bản
    Deleted
    Watting 'Chờ duyệt
    SendMail 'Gửi mail không xuất bản
    Active 'Duyệt và gửi mail
End Enum
Public Enum CommentType
    NEWS = 1
    DOCUMENTS
    MEDIA
End Enum
Public Enum GenderType
    Nu = 0
    Nam
    KhongYeuCau
End Enum
Public Enum FlagEvent
    TheoNgay = 1
    TheoTuan
    TheoThang
End Enum

Public Enum StatusType
    DaXem = 0
    DaLienHe
    DaPhongVan
    DaTest
    TrungTuyen
    TuChoi
End Enum
Public Enum StatusWork
    DaDuyet = 1
    TuyenGap
    TuyenNhanh
    TinNoiBat
End Enum
Public Enum StatusBus
    TatCa = 0
    DoanhNghiep
    NguoiTimViec
End Enum
Public Enum JobView
    DoanhNghiepLuu = 0
    NguoiTimViecLuu
    DN_DanhSachDen
    DN_DaXem
    NLD_DaXem
End Enum
Public Enum WorkFlag
    WebFrom = 0
    WinFrom
End Enum
Public Enum LoaiUngVien
	ChuaDangKy = 0
	DaDangKy
End Enum

