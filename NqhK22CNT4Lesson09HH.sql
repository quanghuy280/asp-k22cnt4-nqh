USE [NqhK22CNT4Lesson09HH]
GO
/****** Object:  Table [dbo].[nqhKetQua]    Script Date: 6/26/2024 3:08:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nqhKetQua](
	[NqhMaSV] [nvarchar](50) NOT NULL,
	[NqhMaMH] [nchar](10) NULL,
	[NqhDiem] [numeric](18, 0) NULL,
 CONSTRAINT [PK_nqhKetQua] PRIMARY KEY CLUSTERED 
(
	[NqhMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nqhKhoa]    Script Date: 6/26/2024 3:08:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nqhKhoa](
	[NqhMaKH] [nchar](10) NOT NULL,
	[NqhTenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_nqhKhoa] PRIMARY KEY CLUSTERED 
(
	[NqhMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nqhMonHoc]    Script Date: 6/26/2024 3:08:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nqhMonHoc](
	[NqhMaMH] [nchar](10) NULL,
	[NqhTenMH] [nvarchar](50) NULL,
	[NqhSotiet] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nqhSinhVien]    Script Date: 6/26/2024 3:08:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nqhSinhVien](
	[NqhMaSV] [nvarchar](50) NULL,
	[NqhHoSV] [nvarchar](50) NULL,
	[NqhTenSV] [nvarchar](50) NULL,
	[NqhPhai] [bit] NULL,
	[NqhNgaySinh] [date] NULL,
	[NqhNoiSinh] [nvarchar](50) NULL,
	[NqhMaKH] [nchar](10) NULL,
	[NqhHocBong] [nvarchar](50) NULL,
	[NqhDiemTrungBinh] [numeric](18, 2) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[nqhKetQua] ([NqhMaSV], [NqhMaMH], [NqhDiem]) VALUES (N'2210900103', N'22123553  ', CAST(8 AS Numeric(18, 0)))
INSERT [dbo].[nqhKetQua] ([NqhMaSV], [NqhMaMH], [NqhDiem]) VALUES (N'2210900105', N'22123456  ', CAST(9 AS Numeric(18, 0)))
GO
INSERT [dbo].[nqhMonHoc] ([NqhMaMH], [NqhTenMH], [NqhSotiet]) VALUES (N'22123456  ', N'Toán', N'5         ')
GO
INSERT [dbo].[nqhSinhVien] ([NqhMaSV], [NqhHoSV], [NqhTenSV], [NqhPhai], [NqhNgaySinh], [NqhNoiSinh], [NqhMaKH], [NqhHocBong], [NqhDiemTrungBinh]) VALUES (N'2210900105', N'Nguyễn Quang', N'Huy', 1, CAST(N'2004-05-28' AS Date), N'thanhhoa', N'CNT4      ', N'Không', CAST(8.90 AS Numeric(18, 2)))
INSERT [dbo].[nqhSinhVien] ([NqhMaSV], [NqhHoSV], [NqhTenSV], [NqhPhai], [NqhNgaySinh], [NqhNoiSinh], [NqhMaKH], [NqhHocBong], [NqhDiemTrungBinh]) VALUES (N'2210900103', N'Vũ Thế', N'Sơn', 1, CAST(N'2005-06-02' AS Date), N'ninhbinh', N'CNT3      ', N'Không', CAST(7.90 AS Numeric(18, 2)))
GO
