USE [master]
GO
/****** Object:  Database [mealdb]    Script Date: 12/14/2020 1:21:46 PM ******/
CREATE DATABASE [mealdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mealdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mealdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mealdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mealdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mealdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mealdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mealdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mealdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mealdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mealdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mealdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [mealdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mealdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mealdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mealdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mealdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mealdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mealdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mealdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mealdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mealdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mealdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mealdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mealdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mealdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mealdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mealdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mealdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mealdb] SET RECOVERY FULL 
GO
ALTER DATABASE [mealdb] SET  MULTI_USER 
GO
ALTER DATABASE [mealdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mealdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mealdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mealdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mealdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'mealdb', N'ON'
GO
ALTER DATABASE [mealdb] SET QUERY_STORE = OFF
GO
USE [mealdb]
GO
/****** Object:  Table [dbo].[class]    Script Date: 12/14/2020 1:21:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[classid] [int] IDENTITY(1,1) NOT NULL,
	[classname] [nvarchar](50) NULL,
 CONSTRAINT [PK_class] PRIMARY KEY CLUSTERED 
(
	[classid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item]    Script Date: 12/14/2020 1:21:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[itemid] [int] IDENTITY(1,1) NOT NULL,
	[itemname] [nvarchar](50) NULL,
	[itemunitprice] [int] NULL,
	[storeid] [int] NULL,
	[itemimage] [nvarchar](50) NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[itemid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[odetail]    Script Date: 12/14/2020 1:21:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odetail](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[odelete] [bit] NULL,
	[ono] [int] NULL,
	[odate] [date] NULL,
	[oclass] [nvarchar](50) NULL,
	[operson] [nvarchar](50) NULL,
	[ostore] [nvarchar](50) NULL,
	[oitem] [nvarchar](50) NULL,
	[oqty] [int] NULL,
	[ounitprice] [int] NULL,
	[oitemtotal] [int] NULL,
	[oclassid] [int] NULL,
	[opersonid] [int] NULL,
	[ostoreid] [int] NULL,
	[oitemid] [int] NULL,
 CONSTRAINT [PK_odetail] PRIMARY KEY CLUSTERED 
(
	[oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[person]    Script Date: 12/14/2020 1:21:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person](
	[personid] [int] IDENTITY(1,1) NOT NULL,
	[personno] [int] NULL,
	[personname] [nvarchar](50) NULL,
	[classid] [int] NULL,
	[personpassword] [nvarchar](50) NULL,
	[pauthority] [int] NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[personid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[store]    Script Date: 12/14/2020 1:21:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[store](
	[storeid] [int] IDENTITY(1,1) NOT NULL,
	[storename] [nvarchar](50) NULL,
 CONSTRAINT [PK_store] PRIMARY KEY CLUSTERED 
(
	[storeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([classid], [classname]) VALUES (1, N'1年1班')
INSERT [dbo].[class] ([classid], [classname]) VALUES (2, N'1年2班')
INSERT [dbo].[class] ([classid], [classname]) VALUES (3, N'1年3班')
SET IDENTITY_INSERT [dbo].[class] OFF
GO
SET IDENTITY_INSERT [dbo].[item] ON 

INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (2, N'香酥腿排飯', 70, 1, N'item220201022234342.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (3, N'特製鯖魚飯', 80, 1, N'item320201022234413.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (4, N'椒麻雞飯', 70, 1, N'item420201022234533.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (5, N'烤肉飯', 65, 1, N'item520201022234543.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (6, N'滷香爌肉飯', 75, 1, N'item620201022234552.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (7, N'蒲燒魚腹飯', 90, 1, N'item720201022234601.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (8, N'瓜子蒸肉飯', 80, 1, N'item820201022234612.JPG')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (9, N'蔬菜便當', 60, 1, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (10, N'叉燒飯', 80, 2, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (11, N'燒鴨飯', 80, 2, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (12, N'蔥油雞飯', 80, 2, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (13, N'香腸飯', 80, 2, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (14, N'三寶飯', 85, 2, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (15, N'乾麵', 40, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (16, N'湯麵', 40, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (17, N'麻醬麵', 45, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (18, N'餛飩麵', 50, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (19, N'炸醬麵', 45, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (20, N'榨菜肉絲麵', 45, 3, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (21, N'菲力牛排', 120, 4, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (22, N'脆皮雞排', 100, 4, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (23, N'豬排', 100, 4, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (24, N'鐵板麵', 50, 4, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (2008, N'12', 123, 1012, N'item200820201023013821.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (2009, N'456', 456, 1012, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (2011, N'159', 100, 1012, N'demo.png')
INSERT [dbo].[item] ([itemid], [itemname], [itemunitprice], [storeid], [itemimage]) VALUES (2012, N'147', 10, 1012, N'demo.png')
SET IDENTITY_INSERT [dbo].[item] OFF
GO
SET IDENTITY_INSERT [dbo].[odetail] ON 

INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (1, 1, NULL, CAST(N'2020-10-13' AS Date), N'1年1班', N'大雄', N'牛老大牛排館', N'菲力牛排', 1, 120, 120, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (2, 0, NULL, CAST(N'2020-10-13' AS Date), N'1年1班', N'小叮噹', N'牛老大牛排館', N'脆皮雞排', 1, 100, 100, NULL, 2, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (3, 1, NULL, CAST(N'2020-10-13' AS Date), N'1年1班', N'小叮噹', N'牛老大牛排館', N'脆皮雞排', 1, 100, 100, NULL, 2, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (4, 1, NULL, CAST(N'2020-10-13' AS Date), N'1年3班', N'小智', N'好便宜麵店', N'湯麵', 1, 40, 40, NULL, 7, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (5, 1, NULL, CAST(N'2020-10-13' AS Date), N'1年2班', N'小丸子', N'好好味燒臘便當', N'三寶飯', 1, 85, 85, NULL, 4, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (6, 1, NULL, CAST(N'2020-10-16' AS Date), N'1年3班', N'小智', N'好便宜麵店', N'炸醬麵', 1, 45, 45, NULL, 7, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (7, 1, NULL, CAST(N'2020-10-16' AS Date), N'1年3班', N'皮卡丘', N'好好味燒臘便當', N'燒鴨飯', 1, 80, 80, NULL, 8, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (8, 1, NULL, CAST(N'2020-10-16' AS Date), N'1年1班', N'大雄', N'好好味燒臘便當', N'香腸飯', 1, 80, 80, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (9, 1, NULL, CAST(N'2020-10-17' AS Date), N'1年1班', N'小叮噹', N'好好吃自助餐', N'烤肉飯', 1, 65, 65, NULL, 2, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (10, 1, NULL, CAST(N'2020-10-17' AS Date), N'1年1班', N'小叮噹', N'好好吃自助餐', N'蔬菜便當', 1, 60, 60, NULL, 2, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (11, 1, NULL, CAST(N'2020-10-17' AS Date), N'1年1班', N'胖虎', N'好好吃自助餐', N'烤肉飯', 1, 65, 65, NULL, 3, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (12, 1, NULL, CAST(N'2020-10-17' AS Date), N'1年1班', N'大雄', N'好好吃自助餐', N'瓜子蒸肉飯', 1, 80, 80, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (13, 1, NULL, CAST(N'2020-10-19' AS Date), N'1年1班', N'大雄', N'好好吃自助餐', N'烤肉飯', 1, 65, 65, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (14, 1, NULL, CAST(N'2020-10-19' AS Date), N'1年1班', N'大雄', N'好好吃自助餐', N'滷香爌肉飯', 1, 75, 75, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (15, 1, NULL, CAST(N'2020-10-21' AS Date), N'1年1班', N'大雄', N'好便宜麵店', N'榨菜肉絲麵', 1, 45, 45, NULL, 1, NULL, NULL)
INSERT [dbo].[odetail] ([oid], [odelete], [ono], [odate], [oclass], [operson], [ostore], [oitem], [oqty], [ounitprice], [oitemtotal], [oclassid], [opersonid], [ostoreid], [oitemid]) VALUES (1014, 1, NULL, CAST(N'2020-10-23' AS Date), N'1年1班', N'胖虎', N'好好吃自助餐', N'蔬菜便當', 1, 60, 60, NULL, 3, NULL, NULL)
SET IDENTITY_INSERT [dbo].[odetail] OFF
GO
SET IDENTITY_INSERT [dbo].[person] ON 

INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (1, 10101, N'大雄', 1, N'0000', 1)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (2, 10102, N'小叮噹', 1, N'1234', 11)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (3, 10103, N'胖虎', 1, N'1234', 101)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (4, 10201, N'小丸子', 2, N'1234', 1)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (5, 10202, N'小玉', 2, N'1234', 11)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (6, 10203, N'永澤', 2, N'1234', 101)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (7, 10301, N'小智', 3, N'1234', 1)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (8, 10302, N'皮卡丘', 3, N'1234', 11)
INSERT [dbo].[person] ([personid], [personno], [personname], [classid], [personpassword], [pauthority]) VALUES (9, 10303, N'小火龍', 3, N'1234', 101)
SET IDENTITY_INSERT [dbo].[person] OFF
GO
SET IDENTITY_INSERT [dbo].[store] ON 

INSERT [dbo].[store] ([storeid], [storename]) VALUES (1, N'好好吃自助餐')
INSERT [dbo].[store] ([storeid], [storename]) VALUES (2, N'好好味燒臘便當')
INSERT [dbo].[store] ([storeid], [storename]) VALUES (3, N'好便宜麵店')
INSERT [dbo].[store] ([storeid], [storename]) VALUES (4, N'牛老大牛排館')
INSERT [dbo].[store] ([storeid], [storename]) VALUES (1012, N'123')
SET IDENTITY_INSERT [dbo].[store] OFF
GO
USE [master]
GO
ALTER DATABASE [mealdb] SET  READ_WRITE 
GO
