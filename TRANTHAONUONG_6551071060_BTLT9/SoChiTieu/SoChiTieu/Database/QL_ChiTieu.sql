IF DB_ID(N'QL_ChiTieu') IS NULL
    CREATE DATABASE QL_ChiTieu;
GO
USE QL_ChiTieu;
GO
IF OBJECT_ID(N'dbo.ChiTieu', N'U') IS NOT NULL DROP TABLE dbo.ChiTieu;
GO
CREATE TABLE dbo.ChiTieu
(
    MaCT INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ChiTieu PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL CONSTRAINT CK_ChiTieu_SoTien CHECK (SoTien > 0),
    GhiChu NVARCHAR(200) NULL
);
GO
INSERT INTO dbo.ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu) VALUES
('2026-10-01', N'Ăn sáng', N'Ăn uống', 25000, N'Bánh mì và sữa'),
('2026-10-02', N'Xe buýt đi học', N'Đi lại', 15000, N'Vé xe buýt'),
('2026-10-03', N'Mua vở', N'Học tập', 42000, N'Vở ghi bài'),
('2026-10-04', N'Uống trà sữa', N'Giải trí', 35000, NULL),
('2026-10-05', N'Ăn trưa', N'Ăn uống', 40000, N'Cơm phần'),
('2026-10-06', N'In tài liệu', N'Học tập', 18000, N'Tài liệu môn học'),
('2026-10-07', N'Đổ xăng', N'Đi lại', 60000, N'Xăng xe máy'),
('2026-10-08', N'Xem phim', N'Giải trí', 90000, N'Vé xem phim'),
('2026-10-09', N'Mua nước uống', N'Ăn uống', 12000, NULL),
('2026-10-10', N'Đồ dùng cá nhân', N'Khác', 55000, N'Khăn giấy và vật dụng');
GO
