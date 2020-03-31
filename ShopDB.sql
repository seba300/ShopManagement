USE [master]
GO
/****** Object:  Database [Shop]    Script Date: 24.03.2020 14:50:32 ******/
CREATE DATABASE [Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Shop] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Shop] SET  MULTI_USER 
GO
ALTER DATABASE [Shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop] SET QUERY_STORE = OFF
GO
USE [Shop]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[IDcategory] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Picture] [image] NULL,
	[Vat] [smallint] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[IDcategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[IDemployee] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Surname] [nvarchar](25) NOT NULL,
	[Position] [nvarchar](40) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[EmploymentDate] [datetime] NOT NULL,
	[Address] [nvarchar](60) NOT NULL,
	[City] [nvarchar](20) NOT NULL,
	[Region] [nvarchar](20) NOT NULL,
	[ZipCode] [nvarchar](10) NOT NULL,
	[PhoneNumber] [nvarchar](24) NOT NULL,
	[Photo] [image] NULL,
	[Comments] [nvarchar](max) NULL,
	[Chief] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDemployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order Details]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order Details](
	[IDorder] [int] NOT NULL,
	[IDproduct] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [float] NULL,
	[Vat] [smallint] NOT NULL,
	[Discount] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_Order Details] PRIMARY KEY CLUSTERED 
(
	[IDorder] ASC,
	[IDproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[IDorder] [int] IDENTITY(1,1) NOT NULL,
	[IDemployee] [int] NOT NULL,
	[SellDate] [date] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[IDorder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[IDproduct] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[UnitQuantity] [nvarchar](255) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[InventoryState] [float] NULL,
	[Discontinued] [bit] NOT NULL,
	[IDcategory] [int] NOT NULL,
	[Discount] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[IDproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.03.2020 14:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDemployee] [int] NOT NULL,
	[Login] [varchar](10) COLLATE Polish_CS_AS NOT NULL,
	[Password] [varchar](60) COLLATE Polish_CS_AS NOT NULL,
	[IDuser] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDuser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (1, N'Pieczywo', N'Chleb, Bułki, Słodkie pieczywo, Pieczywo tostowe', NULL, 8)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (2, N'Nabiał', N'Sery, Jogurty, Masło, Margaryna, Mleko, Kefiry, Śmietana, Desery mleczne', NULL, 12)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (3, N'Mięso', N'Kiełbasy, Konserwy mięsne, Parówki, Pasztety, Smalec i smarowidła', NULL, 20)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (4, N'Słodycze i przekąski', N'Batony, Wafelki, Ciastka, Ciasta, Cukierki, Czekolada, Czekoladki, Praliny, Żelki, Pianki, Chipsy, Chrupki, Paluszki, Orzeszki, Krakersy, Gumy do żucia, Lody, Desery', NULL, 5)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (5, N'Napoje', N'Soki, Nektary, Woda, Syropy, Napoje energetyczne', NULL, 8)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (6, N'Przyprawy', N'Przyprawy sypkie, Przyprawy w płynie, Marynaty i panierki, Kostki i buliony', NULL, 2)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (7, N'Kawa i herbata', N'Kawy, Herbaty', NULL, 2)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (8, N'Przetwory', N'Ketchupy, Majonezy, Musztardy, Oleje i oliwy, Dżemy i konfitury, Przetwory warzywne', NULL, 7)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (9, N'Sypkie', N'Makarony, Mąka, Płatki śniadaniowe, Ryż, Kasza', NULL, 7)
INSERT [dbo].[Categories] ([IDcategory], [CategoryName], [Description], [Picture], [Vat]) VALUES (10, N'Ryby i owoce morza', N'Ryby, Owoce morza, Konserwy rybne, Przetwory rybne', NULL, 15)
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (4, N'Piotr', N'Błaszczykowski', N'Sprzedawca', CAST(N'1990-01-01T00:00:00.000' AS DateTime), CAST(N'2019-09-30T00:00:00.000' AS DateTime), N'Zawadzkiego 14', N'Ćwiklice', N'Śląsk', N'43-229', N'986132456', NULL, NULL, NULL)
INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (5, N'Anna', N'Wichrowska', N'Sprzedawca', CAST(N'1978-01-01T00:00:00.000' AS DateTime), CAST(N'2000-02-03T00:00:00.000' AS DateTime), N'Szczekocińska 24', N'Pszczyna', N'Śląsk', N'43-200', N'342123456', NULL, NULL, NULL)
INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (6, N'Szymon', N'Piepiura', N'Sprzedawca', CAST(N'1998-12-11T00:00:00.000' AS DateTime), CAST(N'2000-02-03T00:00:00.000' AS DateTime), N'Szczekocińska 25', N'Pszczyna', N'Śląsk', N'43-200', N'341423326', NULL, NULL, NULL)
INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (7, N'Sebastian', N'Soliwa', N'Magazynier', CAST(N'1998-05-21T00:00:00.000' AS DateTime), CAST(N'2001-06-03T00:00:00.000' AS DateTime), N'Hallera 12', N'Pszczyna', N'Śląsk', N'43-200', N'241423122', NULL, NULL, NULL)
INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (8, N'Michał', N'Skokowski', N'Magazynier', CAST(N'2000-07-02T00:00:00.000' AS DateTime), CAST(N'2018-07-04T00:00:00.000' AS DateTime), N'Willowa 12', N'Ćwiklice', N'Śląsk', N'43-229', N'987456123', NULL, NULL, NULL)
INSERT [dbo].[Employees] ([IDemployee], [Name], [Surname], [Position], [BirthDate], [EmploymentDate], [Address], [City], [Region], [ZipCode], [PhoneNumber], [Photo], [Comments], [Chief]) VALUES (9, N'Aneta', N'Żmuda', N'Szef', CAST(N'1980-07-02T00:00:00.000' AS DateTime), CAST(N'1999-01-01T00:00:00.000' AS DateTime), N'Willowa 26', N'Ćwiklice', N'Śląsk', N'43-229', N'478625741', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (3, 12, 2.0000, 3, 15, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (3, 23, 59.9900, 1, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (4, 31, 2.9900, 2, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (5, 31, 2.9900, 3, 7, CAST(5.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (6, 40, 1.9900, 3, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (7, 3, 11.5000, 1.25, 20, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Order Details] ([IDorder], [IDproduct], [UnitPrice], [Quantity], [Vat], [Discount]) VALUES (8, 26, 3.0000, 2, 5, CAST(0.00 AS Decimal(4, 2)))
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (3, 4, CAST(N'2020-03-19' AS Date))
INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (4, 4, CAST(N'2020-03-19' AS Date))
INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (5, 5, CAST(N'2020-03-08' AS Date))
INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (6, 5, CAST(N'2020-03-01' AS Date))
INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (7, 6, CAST(N'2020-11-02' AS Date))
INSERT [dbo].[Orders] ([IDorder], [IDemployee], [SellDate]) VALUES (8, 6, CAST(N'2020-11-21' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (3, N'Porcja Rosołowa Wołowa', N'kg', 9.2000, 100, 0, 3, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (4, N'Mięso z jelenia', N'kg', 7.2200, 50, 0, 3, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (5, N'Pierś z kurczaka', N'kg', 13.2000, 16, 0, 3, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (6, N'Kiełbasa sołtysa', N'kg', 14.0000, 50, 0, 3, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (7, N'Mięso wołowe', N'kg', 21.2500, 64.2, 0, 3, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (8, N'Ośmiornica', N'kg', 32.9900, 15, 0, 10, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (9, N'Krewetki', N'kg', 14.9900, 30, 0, 10, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (10, N'Filety z makreli w puszce', N'szt', 3.9900, 30, 0, 10, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (11, N'Filety z dorsza', N'kg', 30.2000, 52.5, 0, 10, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (12, N'Szport w sosie pomidorowym w puszce', N'szt', 2.0000, 50, 0, 10, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (13, N'Chleb pełnoziarnisty', N'szt', 4.2000, 50, 0, 1, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (14, N'Chleb wiejski', N'szt', 4.4000, 50, 0, 1, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (15, N'Chleb graham', N'szt', 3.6000, 50, 0, 1, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (16, N'Kajzerka', N'szt', 0.2000, 100, 0, 1, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (17, N'Bagietka [200g]', N'szt', 1.9900, 30, 0, 1, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (18, N'Ser Gouda [250g]', N'szt', 3.9900, 50, 0, 2, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (19, N'Ser Edamski [250g]', N'szt', 2.9900, 50, 0, 2, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (20, N'Mleko [1L]', N'szt', 2.0000, 50, 0, 2, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (21, N'Ser Camembert [170g]', N'szt', 2.4000, 25, 0, 2, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (22, N'Serek twarogowy [100g]', N'szt', 1.0000, 25, 0, 2, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (23, N'Baton Cini Minis', N'sszt', 59.9900, 10000, 0, 4, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (24, N'Bezowe misie', N'szt', 2.0000, 100, 0, 4, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (25, N'Chałwa sezamowa', N'szt', 3.0000, 100, 0, 4, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (26, N'Wafle ryżowe', N'szt', 3.0000, 100, 0, 4, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (27, N'Princessa zebra', N'sszt', 60.0000, 10000, 0, 4, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (28, N'Ketchup Madero Łagodny', N'szt', 1.9900, 67, 0, 8, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (29, N'Ketchup Pudliszki Łagodny', N'szt', 2.9900, 62, 0, 8, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (30, N'Sos tatarski', N'szt', 2.9900, 54, 0, 8, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (31, N'Musztarda Madero', N'szt', 2.9900, 54, 0, 8, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (32, N'Sos Słodko-Kwaśny', N'szt', 3.9900, 70, 0, 8, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (33, N'Ustronianka Grappa', N'szt', 1.9900, 100, 0, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (34, N'Napój mleczny o smaku waniliowym', N'szt', 1.9900, 100, 0, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (35, N'Nestea', N'szt', 3.0000, 100, 0, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (36, N'Syrop kokosowy', N'szt', 9.9900, 19, 0, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (37, N'Sok multiwitamina', N'szt', 1.9900, 20, 0, 5, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (38, N'Świderki', N'szt', 1.9900, 20, 0, 9, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (39, N'Makaron dwujajeczny', N'szt', 1.9900, 20, 0, 9, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (40, N'Ryż biały', N'szt', 1.9900, 20, 0, 9, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (41, N'Kasza trójkolorowa', N'szt', 1.9900, 20, 0, 9, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (42, N'Płatki kukurydziane', N'szt', 2.9900, 34, 0, 9, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (43, N'Pieprz czarny', N'szt', 2.9900, 23, 0, 6, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (44, N'Sól', N'szt', 2.9900, 33, 0, 6, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (45, N'Przyprawa do potraw', N'szt', 3.9900, 50, 0, 6, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (46, N'Bułka tarta', N'szt', 1.9900, 50, 0, 6, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (47, N'Proszek do pieczenia', N'szt', 0.9900, 50, 0, 6, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (48, N'Kawa rozpuszczalna Nescafe', N'szt', 11.9900, 50, 0, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (49, N'Kawa Parzona Nescafe', N'szt', 9.9900, 50, 0, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (50, N'Inka', N'szt', 4.9900, 50, 0, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (51, N'Mięta', N'szt', 5.9900, 50, 0, 7, CAST(0.00 AS Decimal(4, 2)))
INSERT [dbo].[Products] ([IDproduct], [ProductName], [UnitQuantity], [UnitPrice], [InventoryState], [Discontinued], [IDcategory], [Discount]) VALUES (52, N'Herbata czarna', N'szt', 6.9900, 50, 0, 7, CAST(0.00 AS Decimal(4, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([IDemployee], [Login], [Password], [IDuser]) VALUES (4, N'PBLASZCZYK', N'Haslo123', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Order Details] ADD  CONSTRAINT [DF_OrdersPosition_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD  CONSTRAINT [FK_OrdersPosition_Orders] FOREIGN KEY([IDorder])
REFERENCES [dbo].[Orders] ([IDorder])
GO
ALTER TABLE [dbo].[Order Details] CHECK CONSTRAINT [FK_OrdersPosition_Orders]
GO
ALTER TABLE [dbo].[Order Details]  WITH CHECK ADD  CONSTRAINT [FK_OrdersPosition_Products] FOREIGN KEY([IDproduct])
REFERENCES [dbo].[Products] ([IDproduct])
GO
ALTER TABLE [dbo].[Order Details] CHECK CONSTRAINT [FK_OrdersPosition_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([IDemployee])
REFERENCES [dbo].[Employees] ([IDemployee])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([IDcategory])
REFERENCES [dbo].[Categories] ([IDcategory])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([IDemployee])
REFERENCES [dbo].[Employees] ([IDemployee])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [Shop] SET  READ_WRITE 
GO
