USE [master]
GO
/****** Object:  Database [QuanLyKhoHang]    Script Date: 5/22/2024 10:28:49 PM ******/
CREATE DATABASE [QuanLyKhoHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhoHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyKhoHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhoHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyKhoHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyKhoHang] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhoHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhoHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhoHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhoHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhoHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhoHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhoHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhoHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhoHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhoHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhoHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhoHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyKhoHang] SET QUERY_STORE = OFF
GO
USE [QuanLyKhoHang]
GO
/****** Object:  User [LAPTOP-2BO3HU09\Minh Trieu]    Script Date: 5/22/2024 10:28:49 PM ******/
CREATE USER [LAPTOP-2BO3HU09\Minh Trieu] FOR LOGIN [LAPTOP-2BO3HU09\Minh Trieu] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](500) NULL,
	[Password] [nvarchar](500) NOT NULL,
	[FullName] [nvarchar](500) NULL,
	[Address] [nvarchar](500) NULL,
	[TypeId] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[CompanyID] [int] NOT NULL,
	[AccountID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[TotalBill] [numeric](18, 0) NULL,
	[TotalPayment] [numeric](18, 0) NULL,
	[PaymentDueDate] [date] NULL,
	[Dividend] [numeric](18, 0) NULL,
	[Commission] [numeric](18, 0) NULL,
	[ReceiveCommissionID] [int] NULL,
	[ShippingCost] [numeric](18, 0) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Count] [int] NULL,
	[SalePrice] [numeric](18, 0) NULL,
	[VAT] [int] NOT NULL,
	[Dividend] [numeric](18, 0) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [varchar](15) NULL,
	[Fax] [varchar](50) NULL,
	[StartDate] [date] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Decentralization]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decentralization](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[TypeActID] [int] NOT NULL,
	[Del] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenditure]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenditure](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[StartDate] [date] NOT NULL,
	[Expenditure] [numeric](18, 0) NULL,
	[AccountID] [int] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenditureInfo]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenditureInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenditureID] [int] NOT NULL,
	[Price] [numeric](18, 0) NULL,
	[StartDate] [date] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FKey]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FKey](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TimeDateLine] [text] NULL,
	[Del] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Input]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Input](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Count] [int] NULL,
	[ImportPrice] [numeric](18, 0) NULL,
	[StartDate] [date] NOT NULL,
	[AccountID] [int] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameter]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Value] [int] NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentInfo]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[Payment] [numeric](18, 0) NULL,
	[StartDate] [date] NOT NULL,
	[StartNextDate] [date] NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Dimensions] [nvarchar](max) NULL,
	[UnitID] [int] NOT NULL,
	[Stock] [int] NULL,
	[StartDate] [date] NOT NULL,
	[InputSource] [nvarchar](max) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiveCommission]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiveCommission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Address] [nvarchar](max) NULL,
	[Phone] [varchar](15) NULL,
	[Fax] [varchar](50) NULL,
	[TypeReferrerID] [int] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Representative]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Representative](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Phone] [varchar](15) NULL,
	[CompanyID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalePrice]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalePrice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[SalePrice] [numeric](18, 0) NULL,
	[AccountID] [int] NOT NULL,
	[StartDate] [date] NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemError]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemError](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NameErr] [ntext] NULL,
	[NameFn] [nvarchar](200) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAccount]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAct]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeReferrer]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeReferrer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[StartDate] [date] NOT NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Del] [bit] NULL,
	[Note] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [UserName], [Password], [FullName], [Address], [TypeId], [StartDate], [Del], [Note]) VALUES (1, N'admin', N'1', N'Dương Minh Triều', N'TPHCM', 1, CAST(N'2024-05-22' AS Date), 0, N'giám đốc ')
INSERT [dbo].[Account] ([ID], [UserName], [Password], [FullName], [Address], [TypeId], [StartDate], [Del], [Note]) VALUES (2, N'mt276', N'123', N'Triều Minh', N'TPHCM', 2, CAST(N'2024-05-22' AS Date), 0, N'nhân viên nhập kho')
INSERT [dbo].[Account] ([ID], [UserName], [Password], [FullName], [Address], [TypeId], [StartDate], [Del], [Note]) VALUES (3, N'eni', N'1', N'Kim Anh', N'TPHCM', 2, CAST(N'2024-05-22' AS Date), 0, N'nhân viên nhập kho')
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([ID], [Name], [CompanyID], [AccountID], [StartDate], [TotalBill], [TotalPayment], [PaymentDueDate], [Dividend], [Commission], [ReceiveCommissionID], [ShippingCost], [Del], [Note]) VALUES (1, N'Hóa đơn', 2, 1, CAST(N'2024-05-22' AS Date), CAST(748000 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), NULL, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, CAST(0 AS Numeric(18, 0)), 0, N'')
INSERT [dbo].[Bill] ([ID], [Name], [CompanyID], [AccountID], [StartDate], [TotalBill], [TotalPayment], [PaymentDueDate], [Dividend], [Commission], [ReceiveCommissionID], [ShippingCost], [Del], [Note]) VALUES (2, N'Hóa đơn', 3, 1, CAST(N'2024-05-22' AS Date), CAST(748000 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), NULL, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, CAST(0 AS Numeric(18, 0)), 0, N'')
INSERT [dbo].[Bill] ([ID], [Name], [CompanyID], [AccountID], [StartDate], [TotalBill], [TotalPayment], [PaymentDueDate], [Dividend], [Commission], [ReceiveCommissionID], [ShippingCost], [Del], [Note]) VALUES (3, N'Hóa đơn', 4, 1, CAST(N'2024-05-22' AS Date), CAST(748000 AS Numeric(18, 0)), CAST(3123 AS Numeric(18, 0)), NULL, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, CAST(0 AS Numeric(18, 0)), 0, N'')
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([ID], [BillID], [ProductID], [Count], [SalePrice], [VAT], [Dividend], [Del], [Note]) VALUES (1, 1, 2, 2, CAST(340000 AS Numeric(18, 0)), 2, CAST(180000 AS Numeric(18, 0)), 0, N'')
INSERT [dbo].[BillInfo] ([ID], [BillID], [ProductID], [Count], [SalePrice], [VAT], [Dividend], [Del], [Note]) VALUES (2, 2, 2, 2, CAST(340000 AS Numeric(18, 0)), 2, CAST(180000 AS Numeric(18, 0)), 0, N'')
INSERT [dbo].[BillInfo] ([ID], [BillID], [ProductID], [Count], [SalePrice], [VAT], [Dividend], [Del], [Note]) VALUES (3, 3, 2, 2, CAST(340000 AS Numeric(18, 0)), 0, CAST(180000 AS Numeric(18, 0)), 0, N'')
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (1, N'Công ty TNHH PaoYeng', N'123-Đường số 10- khu công nghiệp tân tạo', N'0837662154', N'0821121233', CAST(N'2024-05-22' AS Date), 0, N'thường nhập hàng mủ')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (2, N'Công ty TNHH Bình Minh', N'12-Lò gốm - Quận 6 -tphcm', N'0821213455', N'0121212121', CAST(N'2024-05-22' AS Date), 0, N'chuyên kinh doanh nhựa')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (3, N'Công ty TNHH Tân Tân', N'145/13- tỉnh lộ 10 - bình chánh - tphcm', N'0812343553', N'0812134234', CAST(N'2024-05-22' AS Date), 0, N'công ty đậu ')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (4, N'Công ty TNHH NahaShi', N'121-Điện biên phủ - quận 3-tphcm', N'0812343434', N'1322323213', CAST(N'2024-05-22' AS Date), 0, N'mua hàng số lượng rất lớn')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (5, N'Công ty TNHH Phú Lạc Việt', N'12-Trần Bình Trọng', N'0812132447', N'1213213132', CAST(N'2024-05-22' AS Date), 0, N'ông khang làm giám đốc')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (6, N'Công ty TNHH Phân Bón Bình Điền', N'123-QL1- Bình chánh-tphcm', N'0812123123', N'0813123312', CAST(N'2024-05-22' AS Date), 0, N'đây là công ty phân bón')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (7, N'Công ty TNHH Mai Linh', N'1212314', N'1434243654', N'1431412312', CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (8, N'Công ty TNHH SinYahoo', N'123-Lý Thái Tổ-Q10-TPHCM', N'0921210121', N'0831341234', CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Company] ([ID], [Name], [Address], [Phone], [Fax], [StartDate], [Del], [Note]) VALUES (9, N'Công ty bánh kẹo Phạm Nguyên', N'12 -Trần đại nghĩa- khu công nghiệp Lê Minh Xuân', N'0812121237', N'2133213213', CAST(N'2024-05-22' AS Date), 0, N'công ty bánh kẹo')
SET IDENTITY_INSERT [dbo].[Company] OFF
GO
SET IDENTITY_INSERT [dbo].[Decentralization] ON 

INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (1, 1, 1, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (2, 1, 2, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (3, 1, 3, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (4, 1, 4, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (5, 1, 5, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (6, 1, 6, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (7, 1, 7, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (8, 1, 8, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (9, 1, 9, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (10, 1, 10, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (11, 1, 11, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (12, 1, 12, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (13, 1, 13, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (14, 1, 14, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (15, 1, 15, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (16, 1, 16, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (17, 1, 17, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (18, 1, 18, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (19, 1, 19, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (20, 1, 20, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (21, 2, 2, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (22, 2, 3, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (23, 2, 4, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (24, 2, 5, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (25, 2, 6, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (26, 2, 7, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (27, 2, 8, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (28, 2, 9, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (29, 2, 10, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (30, 2, 11, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (31, 2, 12, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (32, 2, 13, 0)
INSERT [dbo].[Decentralization] ([ID], [AccountID], [TypeActID], [Del]) VALUES (33, 2, 14, 0)
SET IDENTITY_INSERT [dbo].[Decentralization] OFF
GO
SET IDENTITY_INSERT [dbo].[Input] ON 

INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (1, 1, 1200000, CAST(13000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (2, 1, 12, CAST(50000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (3, 2, 123, CAST(1500000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'Bế cuộn')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (4, 2, 10, CAST(15000000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'Bế cuộn nhập mới')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (5, 4, 100, CAST(12000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (6, 1, 100, CAST(300000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (7, 1, 15, CAST(250000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (8, 2, 500, CAST(250000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
INSERT [dbo].[Input] ([ID], [ProductID], [Count], [ImportPrice], [StartDate], [AccountID], [Del], [Note]) VALUES (9, 3, 30, CAST(200000 AS Numeric(18, 0)), CAST(N'2024-05-22' AS Date), 1, 0, N'')
SET IDENTITY_INSERT [dbo].[Input] OFF
GO
SET IDENTITY_INSERT [dbo].[Parameter] ON 

INSERT [dbo].[Parameter] ([ID], [ProductID], [Value], [Del], [Note]) VALUES (1, 1, 5, 0, N'Giá trị nhỏ nhất')
INSERT [dbo].[Parameter] ([ID], [ProductID], [Value], [Del], [Note]) VALUES (2, 2, 3, 0, N'Giá trị nhỏ nhất')
INSERT [dbo].[Parameter] ([ID], [ProductID], [Value], [Del], [Note]) VALUES (3, 3, 3, 0, N'Giá trị nhỏ nhất')
SET IDENTITY_INSERT [dbo].[Parameter] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [Dimensions], [UnitID], [Stock], [StartDate], [InputSource], [Del], [Note]) VALUES (1, N'Bìa cứng', N'130x12', 2, 1200127, CAST(N'2024-05-22' AS Date), N'canada', 0, N'hàng trong nước')
INSERT [dbo].[Products] ([ID], [Name], [Dimensions], [UnitID], [Stock], [StartDate], [InputSource], [Del], [Note]) VALUES (2, N'Bế cuộn', N'13x 213', 1, 633, CAST(N'2024-05-22' AS Date), N'malaysia', 0, N'hàng nhập từ nước ngoài')
INSERT [dbo].[Products] ([ID], [Name], [Dimensions], [UnitID], [Stock], [StartDate], [InputSource], [Del], [Note]) VALUES (3, N'Chỉ bế', N'0.6 x 3.2', 2, 30, CAST(N'2024-05-22' AS Date), N'indonesia', 0, N'hàng nhập từ nước ngoài')
INSERT [dbo].[Products] ([ID], [Name], [Dimensions], [UnitID], [Stock], [StartDate], [InputSource], [Del], [Note]) VALUES (4, N'Keo dính chuột', N'12x12.00', 1, 0, CAST(N'2024-05-22' AS Date), N'malaisia', 0, N'hàng trong nước')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ReceiveCommission] ON 

INSERT [dbo].[ReceiveCommission] ([ID], [Name], [Address], [Phone], [Fax], [TypeReferrerID], [Del], [Note]) VALUES (1, N'Nguyễn Văn An', N'123-Điện Biên Phủ', N'0947294761', N'0837123433', 1, 0, N'')
SET IDENTITY_INSERT [dbo].[ReceiveCommission] OFF
GO
SET IDENTITY_INSERT [dbo].[Representative] ON 

INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (1, N'ông Trần Tiến', N'1231313231', 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (2, N'bà Trầm Bê', N'0921323244', 2, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (3, N'ông Khang Phú', N'0998121212', 3, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (4, N'bà Lý Thị Mạc', N'0812121237', 4, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (5, N'bà Nguyễn Tố Châu', N'1231332123', 5, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (6, N'ông Công Hậu', N'0947271638', 6, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (7, N'ông Cao Thắng', N'0921212347', 7, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (8, N'bà Nguyễn Mai', N'0947271638', 8, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[Representative] ([ID], [Name], [Phone], [CompanyID], [StartDate], [Del], [Note]) VALUES (9, N'ông Phạm Thắng', N'0921212734', 9, CAST(N'2024-05-22' AS Date), 0, N'')
SET IDENTITY_INSERT [dbo].[Representative] OFF
GO
SET IDENTITY_INSERT [dbo].[SalePrice] ON 

INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (1, 1, CAST(250000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (2, 2, CAST(250000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (3, 3, CAST(200000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (4, 1, CAST(250000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (5, 1, CAST(250000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (6, 2, CAST(250000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
INSERT [dbo].[SalePrice] ([ID], [ProductID], [SalePrice], [AccountID], [StartDate], [Del], [Note]) VALUES (7, 3, CAST(200000 AS Numeric(18, 0)), 1, CAST(N'2024-05-22' AS Date), 0, N'')
SET IDENTITY_INSERT [dbo].[SalePrice] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeAccount] ON 

INSERT [dbo].[TypeAccount] ([ID], [Name], [Del], [Note]) VALUES (1, N'Giám Đốc', 0, N'Giám đốc')
INSERT [dbo].[TypeAccount] ([ID], [Name], [Del], [Note]) VALUES (2, N'Nhân Viên Nhập Kho', 0, N'Nhân Viên Nhập Kho')
SET IDENTITY_INSERT [dbo].[TypeAccount] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeAct] ON 

INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (1, N'Decentralization', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (2, N'Sell', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (3, N'Warehouse', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (4, N'WarehouseManagement', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (5, N'PriceUpdate', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (6, N'AddCustomer', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (7, N'ListCustomer', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (8, N'AddReferrer', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (9, N'AddProduct', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (10, N'ListProduct', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (11, N'AddTypeReferrer', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (12, N'UpdateSystem', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (13, N'SendEmail', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (14, N'Statistics', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (15, N'ProductSell', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (16, N'ProductPriceStatistics', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (17, N'ProductPriceChart', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (18, N'DebtStatistics', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (19, N'BillStatistics', 0, N'')
INSERT [dbo].[TypeAct] ([ID], [Name], [Del], [Note]) VALUES (20, N'InputReport', 0, N'')
SET IDENTITY_INSERT [dbo].[TypeAct] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeReferrer] ON 

INSERT [dbo].[TypeReferrer] ([ID], [Name], [StartDate], [Del], [Note]) VALUES (1, N'Người Giới Thiệu Tự Do', CAST(N'2024-05-22' AS Date), 0, N'')
SET IDENTITY_INSERT [dbo].[TypeReferrer] OFF
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([ID], [Name], [Del], [Note]) VALUES (1, N'Tấm', 0, N'')
INSERT [dbo].[Unit] ([ID], [Name], [Del], [Note]) VALUES (2, N'Miếng', 0, N'')
SET IDENTITY_INSERT [dbo].[Unit] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((1)) FOR [Password]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [VAT]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Expenditure] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[ExpenditureInfo] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Input] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[PaymentInfo] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Representative] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[TypeReferrer] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [dbo].[TypeAccount] ([ID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([ID])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([ReceiveCommissionID])
REFERENCES [dbo].[ReceiveCommission] ([ID])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Decentralization]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Decentralization]  WITH CHECK ADD FOREIGN KEY([TypeActID])
REFERENCES [dbo].[TypeAct] ([ID])
GO
ALTER TABLE [dbo].[Expenditure]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[ExpenditureInfo]  WITH CHECK ADD FOREIGN KEY([ExpenditureID])
REFERENCES [dbo].[Expenditure] ([ID])
GO
ALTER TABLE [dbo].[Input]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Input]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Parameter]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[PaymentInfo]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([UnitID])
REFERENCES [dbo].[Unit] ([ID])
GO
ALTER TABLE [dbo].[ReceiveCommission]  WITH CHECK ADD FOREIGN KEY([TypeReferrerID])
REFERENCES [dbo].[TypeReferrer] ([ID])
GO
ALTER TABLE [dbo].[Representative]  WITH CHECK ADD FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([ID])
GO
ALTER TABLE [dbo].[SalePrice]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[SalePrice]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteRecordsBasedOnDelValue]    Script Date: 5/22/2024 10:28:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteRecordsBasedOnDelValue]
AS
BEGIN
	DELETE FROM dbo.Account WHERE DEL = 1
	DELETE FROM dbo.Bill WHERE DEL = 1
	DELETE FROM dbo.BillInfo WHERE DEL = 1
	DELETE FROM dbo.Company WHERE DEL = 1
	DELETE FROM dbo.Decentralization WHERE DEL = 1
	DELETE FROM dbo.Input WHERE DEL = 1
	DELETE FROM dbo.Parameter WHERE DEL = 1
	DELETE FROM dbo.PaymentInfo WHERE DEL = 1
	DELETE FROM dbo.Products WHERE DEL = 1
	DELETE FROM dbo.ReceiveCommission WHERE DEL = 1
	DELETE FROM dbo.Representative WHERE DEL = 1
	DELETE FROM dbo.SalePrice WHERE DEL = 1
	DELETE FROM dbo.TypeAccount WHERE DEL = 1
	DELETE FROM dbo.TypeAct WHERE DEL = 1
	DELETE FROM dbo.TypeReferrer WHERE DEL = 1
	DELETE FROM dbo.Unit WHERE DEL = 1
	DELETE FROM dbo.SystemError WHERE DEL = 1
	DELETE FROM dbo.FKey WHERE DEL = 1
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhoHang] SET  READ_WRITE 
GO
