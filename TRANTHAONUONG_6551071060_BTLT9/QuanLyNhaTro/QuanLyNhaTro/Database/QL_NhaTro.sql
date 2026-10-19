/* =====================================================================
   Câu 2 - Quản lý nhà trọ
   Tạo CSDL QL_NhaTro, 2 bảng PhongTro / KhachThue (có khóa ngoại),
   6 phòng và 5 khách mẫu. Có thể chạy lại nhiều lần.
   Mã tỉnh / phường-xã lấy theo API https://provinces.open-api.vn/api/v2/
   ===================================================================== */
IF DB_ID(N'QL_NhaTro') IS NULL
    CREATE DATABASE QL_NhaTro;
GO

USE QL_NhaTro;
GO

IF OBJECT_ID(N'dbo.KhachThue', N'U') IS NOT NULL DROP TABLE dbo.KhachThue;
IF OBJECT_ID(N'dbo.PhongTro',  N'U') IS NOT NULL DROP TABLE dbo.PhongTro;
GO

CREATE TABLE dbo.PhongTro
(
    MaPhong   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PhongTro PRIMARY KEY,
    TenPhong  NVARCHAR(20)  NOT NULL,
    GiaThue   DECIMAL(18,0) NOT NULL,
    TinhTrang NVARCHAR(20)  NOT NULL CONSTRAINT DF_PhongTro_TinhTrang DEFAULT (N'Trống'),
    CONSTRAINT CK_PhongTro_TinhTrang CHECK (TinhTrang IN (N'Trống', N'Đang thuê'))
);
GO

CREATE TABLE dbo.KhachThue
(
    MaKhach        INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_KhachThue PRIMARY KEY,
    HoTen          NVARCHAR(100) NOT NULL,
    GioiTinh       NVARCHAR(5)   NOT NULL,
    NgaySinh       DATE          NOT NULL,
    SoDienThoai    VARCHAR(15)   NOT NULL,
    MaTinh         INT           NULL,
    TenTinh        NVARCHAR(100) NULL,
    MaPhuongXa     INT           NULL,
    TenPhuongXa    NVARCHAR(100) NULL,
    DaDangKyTamTru BIT           NOT NULL CONSTRAINT DF_KhachThue_TamTru DEFAULT (0),
    MaPhong        INT           NOT NULL,
    CONSTRAINT FK_KhachThue_PhongTro FOREIGN KEY (MaPhong) REFERENCES dbo.PhongTro (MaPhong)
);
GO

INSERT INTO dbo.PhongTro (TenPhong, GiaThue, TinhTrang) VALUES
(N'P01', 1500000, N'Đang thuê'),
(N'P02', 1600000, N'Đang thuê'),
(N'P03', 1800000, N'Đang thuê'),
(N'P04', 2000000, N'Đang thuê'),
(N'P05', 1700000, N'Đang thuê'),
(N'P06', 1900000, N'Trống');
GO

INSERT INTO dbo.KhachThue
    (HoTen, GioiTinh, NgaySinh, SoDienThoai, MaTinh, TenTinh, MaPhuongXa, TenPhuongXa, DaDangKyTamTru, MaPhong)
VALUES
(N'Trần Thị Bình',   N'Nữ',  '2003-08-20', '0876543210', 38, N'Tỉnh Thanh Hóa',   14758, N'Phường Hàm Rồng', 0, (SELECT MaPhong FROM dbo.PhongTro WHERE TenPhong = N'P01')),
(N'Lê Văn Cường',    N'Nam', '2002-11-03', '0901234567', 38, N'Tỉnh Thanh Hóa',   14797, N'Phường Hạc Thành', 0, (SELECT MaPhong FROM dbo.PhongTro WHERE TenPhong = N'P02')),
(N'Nguyễn Văn An',   N'Nam', '2004-05-12', '0912345678',  1, N'Thành phố Hà Nội', 4,     N'Phường Ba Đình',  1, (SELECT MaPhong FROM dbo.PhongTro WHERE TenPhong = N'P03')),
(N'Phạm Minh Đức',   N'Nam', '2001-02-17', '0987654321',  1, N'Thành phố Hà Nội', 70,    N'Phường Hoàn Kiếm',1, (SELECT MaPhong FROM dbo.PhongTro WHERE TenPhong = N'P04')),
(N'Hoàng Thị Dung',  N'Nữ',  '2003-09-09', '0765432109',  1, N'Thành phố Hà Nội', 82,    N'Phường Cửa Nam',  0, (SELECT MaPhong FROM dbo.PhongTro WHERE TenPhong = N'P05'));
GO

SELECT * FROM dbo.PhongTro;
SELECT * FROM dbo.KhachThue;
GO
