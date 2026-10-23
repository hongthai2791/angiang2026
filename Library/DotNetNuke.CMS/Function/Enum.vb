Public Enum mediaType
    Audio = 1
    Video
    Image
End Enum
Public Enum NewProcedure
    BaoDienTu = 0
    BaoIn_DienTu
    DienTu_BaoIn
End Enum
Public Enum NewHotFlag
    NongTrangChu
    NongChuyenMuc
End Enum
Public Enum HomeBlock
    TinThuong = 0
    NongTrangChu = -1
    NongChuyenMuc = -2
    PhongSuAnh = -3
End Enum
Public Enum LoaiWF
    TatCa = 0
    DanhChoPhongVien
    DanhChoLanhDaoPhong
End Enum
Public Enum NewsStatus
    DangBienSoan = 0
    ChoPheDuyet
    DaXuatBan
    BiTraLai
    HuyXuatBan
    ChoXuatBan
    TraLaiQT
End Enum
Public Enum CommentStatus
    Created = 1
    Pulished 'Gửi mail và xuất bản
    Deleted
    Watting 'Chờ duyệt
    SendMail 'Gửi mail không xuất bản
    Active 'Duyệt và gửi mail
End Enum
Public Enum WebLinkType
    NoiBo = 1
    Website
    Khac
End Enum
Public Enum MenuType
    TOP = 1
    BOTTOM
    LEFT
    RIGHT
    MOBILE
End Enum
Public Enum BlockFlag
    Web_News = 0
    Web_Album
    Web_Video
    Web_Audio
End Enum
Public Enum TheLoaiTin
    Text = 1
    Image
    Audio
    Video
    TextImage
    TextAudio
    TextVideo
    TextImageAudio
    TextImageVideo
    TextAudioVideo
    TextImageAudioVideo
End Enum
Public Enum SourcesType
    UPLOAD = 1
    FTP
End Enum
Public Enum CommentType
    NEWS = 1
    DOCUMENTS
    MEDIA
End Enum
Public Enum CategoryType
    News = 1
    Video
    Audio
    Album
    VanBan
    Menu
End Enum
Public Enum TNCacheKey
    DanhSachNguoiDung = 1
    DanhSachPhongBan
    DanhSachNguonTin
End Enum
Public Enum RoyFlag
    TinDich = 0
    Anh
    BaiViet
End Enum
Public Enum ServiceType
    TinTuc = 1
    Album
    Media
    Advertise
    FAQ
    FAQQuestion
    FAQAnswers
    Infomation
    NewsCategories
    WebLink
    Document
    Menu
    Feedback
    ConfigSystem
    Setup
End Enum
Public Enum QuestionStatus
    DaGui = 1
    ChoXuLy
    ChoDuyet
    DaDuyet
    TraLai
    HuyBo
    DaXuLy
End Enum
Public Enum HistoryType
    MacDinh = 0
    DonViXuLy
End Enum
Public Enum FlagEvent
    TheoNgay = 1
    TheoTuan
    TheoThang
End Enum
