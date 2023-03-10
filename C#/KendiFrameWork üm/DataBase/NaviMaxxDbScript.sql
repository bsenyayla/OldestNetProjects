USE [master]
GO
/****** Object:  Database [dbCrm]    Script Date: 11/29/2014 18:30:13 ******/
CREATE DATABASE [dbCrm] ON  PRIMARY 
( NAME = N'dbKronus', FILENAME = N'D:\Kronus\DataBase\dbNaviMAXX' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbKronus_log', FILENAME = N'D:\Kronus\DataBase\dbNaviMAXX_Log' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbCrm] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbCrm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbCrm] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbCrm] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbCrm] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbCrm] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbCrm] SET ARITHABORT OFF
GO
ALTER DATABASE [dbCrm] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbCrm] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbCrm] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbCrm] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbCrm] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbCrm] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbCrm] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbCrm] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbCrm] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbCrm] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbCrm] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbCrm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbCrm] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbCrm] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbCrm] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbCrm] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbCrm] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbCrm] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbCrm] SET  READ_WRITE
GO
ALTER DATABASE [dbCrm] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbCrm] SET  MULTI_USER
GO
ALTER DATABASE [dbCrm] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbCrm] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbCrm', N'ON'
GO
USE [dbCrm]
GO
/****** Object:  Table [dbo].[CrmDepartman]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrmDepartman](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Aciklama] [nvarchar](250) NULL,
	[ExtraStr1] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_Departman] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmBolum]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrmBolum](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](300) NULL,
	[DepartmanId] [uniqueidentifier] NULL,
	[BolumEmailGrup] [nvarchar](50) NULL,
	[ExtraStr1] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_Bolum] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmGorev]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrmGorev](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](300) NULL,
	[ExtraStr1] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_Gorev] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmFirmaLokasyon]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrmFirmaLokasyon](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](50) NULL,
	[FirmaId] [uniqueidentifier] NULL,
	[Il] [int] NULL,
	[Ilce] [int] NULL,
	[ExtraStr1] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_FirmaLokasyon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmFirma]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrmFirma](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](300) NULL,
	[CariKod] [nvarchar](10) NULL,
	[ExtraStr1] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](50) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_Firma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GnlMarka]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GnlMarka](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_GnlMarka] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GnlBanka]    Script Date: 11/29/2014 18:30:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GnlBanka](
	[Id] [char](6) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_GnlBanka] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateNextId]    Script Date: 11/29/2014 18:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GenerateNextId](@a char(1)) 
returns char(10) 
as 
begin 

	declare @i int
	
	select @i=1
	

	return 'P-' + 
   (char(@i / 26000 % 26 + 65) + 
	char(@i / 1000 % 26 + 65) + 
	char(@i / 100 % 10 + 48) + 
	char(@i / 10 % 10 + 48) + 
	char(@i % 10 + 48)) 
end
GO
/****** Object:  Table [dbo].[FrwYetkiGrup]    Script Date: 11/29/2014 18:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwYetkiGrup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Aciklama] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_YetkiGrup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwMenu]    Script Date: 11/29/2014 18:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](700) NULL,
	[Image] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[UstId] [int] NULL,
	[IsMenu] [bit] NULL,
	[NameSpace] [nvarchar](500) NULL,
	[Dll] [nvarchar](500) NULL,
	[Sira] [smallint] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwGeneralValues]    Script Date: 11/29/2014 18:30:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FrwGeneralValues](
	[Id] [char](6) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[UstId] [char](6) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_FrwGeneralValues] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_Table_AdUstId] ON [dbo].[FrwGeneralValues] 
(
	[Ad] ASC,
	[UstId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwGeneralContraint]    Script Date: 11/29/2014 18:30:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwGeneralContraint](
	[Id] [int] NOT NULL,
	[Enum] [nvarchar](30) NULL,
	[Deger] [nvarchar](20) NULL,
 CONSTRAINT [PK_FrwGeneralContraint] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwDevelopmentHistory]    Script Date: 11/29/2014 18:30:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwDevelopmentHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [nvarchar](300) NULL,
	[Tarih] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[FrwDevelopment]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FrwDevelopment]
@TABLE_NAME VARCHAR(100)
as
begin
  select 
	cl.name as [ColumnName],
	tp.name as [ColumnType]
  from sys.columns cl
  inner join sys.types tp on cl.system_type_id=tp.system_type_id and cl.user_type_id=tp.user_type_id
  where object_id=  (select id 
					from sysobjects
					where name =@TABLE_NAME)
  order by cl.column_id asc
end
GO
/****** Object:  UserDefinedFunction [dbo].[CustomerNumber]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[CustomerNumber](@i int) 
returns char(10) 
as 
begin 
	return 'P-' + 
   (char(@i / 26000 % 26 + 65) + 
	char(@i / 1000 % 26 + 65) + 
	char(@i / 100 % 10 + 48) + 
	char(@i / 10 % 10 + 48) + 
	char(@i % 10 + 48)) 
end
GO
/****** Object:  Table [dbo].[SrvYolcuVeli]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrvYolcuVeli](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YolcuId] [int] NOT NULL,
	[VeliTipi] [nchar](10) NULL,
	[Ad] [nvarchar](30) NULL,
	[Soyad] [nvarchar](20) NULL,
	[TcKimlikNo] [nvarchar](11) NULL,
	[FirmaAdi] [nvarchar](50) NULL,
	[YaptigiIs] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Telefon] [nvarchar](12) NULL,
	[Adres] [nchar](10) NULL,
	[Aciklama] [nvarchar](300) NULL,
 CONSTRAINT [PK_SrvYolcuVeli] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SrvYolcu]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SrvYolcu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjeId] [uniqueidentifier] NULL,
	[YolcuTipi] [char](9) NULL,
	[KimlikNo] [nvarchar](12) NULL,
	[Ad] [nvarchar](20) NULL,
	[Soyad] [nvarchar](20) NULL,
	[Durum] [smallint] NULL,
	[DogumTarihi] [date] NULL,
	[DogumYeri] [nvarchar](30) NULL,
	[Cinsiyet] [bit] NULL,
	[MedeniDurum] [char](1) NULL,
	[KanGrubu] [nchar](10) NULL,
	[EMail] [nvarchar](50) NULL,
	[TelefonNo] [nvarchar](12) NULL,
	[GsmNo] [nvarchar](12) NULL,
	[Sehir] [nchar](10) NULL,
	[Il] [nchar](10) NULL,
	[Ilce] [nchar](10) NULL,
	[Adres] [nchar](10) NULL,
	[Aciklama] [nvarchar](300) NULL,
 CONSTRAINT [PK_SrvYolcu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SrvTedarikci]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrvTedarikci](
	[Id] [uniqueidentifier] NOT NULL,
	[CariKod] [nvarchar](20) NULL,
	[CariAd] [nvarchar](20) NULL,
	[YetkiliKisi] [nvarchar](20) NULL,
	[VergiDairesi] [nvarchar](20) NULL,
	[VergiNo] [nvarchar](20) NULL,
	[Banka] [nvarchar](20) NULL,
	[Sube] [nvarchar](20) NULL,
	[HesapNo] [nvarchar](20) NULL,
	[IBAN] [nvarchar](20) NULL,
	[Telefon] [nvarchar](15) NULL,
	[Gsm] [nvarchar](15) NULL,
	[Fax] [nvarchar](15) NULL,
	[Adres] [nvarchar](300) NULL,
	[Aciklama] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [date] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [date] NULL,
 CONSTRAINT [PK_SrvTedarikci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SrvTable]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrvTable](
	[sdf] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SrvTable] PRIMARY KEY CLUSTERED 
(
	[sdf] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SrvPersonel]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SrvPersonel](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjeId] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](20) NULL,
	[Soyad] [nvarchar](20) NULL,
	[TcKimlikNo] [nvarchar](12) NULL,
	[DogumTarihi] [date] NULL,
	[DogumYeri] [nvarchar](20) NULL,
	[Email] [nvarchar](30) NULL,
	[Telefon] [nvarchar](15) NULL,
	[Gsm] [nchar](15) NULL,
	[Adres] [nvarchar](500) NULL,
	[KanGrubu] [nvarchar](10) NULL,
	[Il] [nvarchar](20) NULL,
	[Ilce] [nvarchar](20) NULL,
	[MedeniHali] [char](1) NULL,
	[Uyruk] [nchar](10) NULL,
	[La] [float] NULL,
	[Lo] [float] NULL,
 CONSTRAINT [PK_SrvPersonel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GnlModel]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GnlModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MarkaId] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_GnlModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmPersonel]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CrmPersonel](
	[Id] [uniqueidentifier] NOT NULL,
	[DomainName] [nvarchar](50) NULL,
	[CariKod] [nvarchar](25) NULL,
	[Ad] [nvarchar](15) NULL,
	[Soyad] [nvarchar](15) NULL,
	[DogumTarihi] [date] NULL,
	[TcKimlikNo] [nvarchar](11) NULL,
	[MedeniHali] [char](1) NULL,
	[Adres] [nvarchar](500) NULL,
	[Email] [nvarchar](50) NULL,
	[EmailIs] [nvarchar](50) NULL,
	[TelefonNo] [nvarchar](15) NULL,
	[GsmNo] [nvarchar](15) NULL,
	[TelefonNoIs] [nvarchar](15) NULL,
	[Cinsiyet] [char](1) NULL,
	[ProfilFoto] [nvarchar](300) NULL,
	[GirisTarihi] [datetime] NULL,
	[CikisTarihi] [datetime] NULL,
	[BirinciYonetici] [uniqueidentifier] NULL,
	[IkinciYonetici] [uniqueidentifier] NULL,
	[DepartmanId] [uniqueidentifier] NULL,
	[BolumId] [uniqueidentifier] NULL,
	[GorevId] [uniqueidentifier] NULL,
	[FirmaId] [uniqueidentifier] NULL,
	[FirmaLokasyonId] [uniqueidentifier] NULL,
	[EhliyetId] [uniqueidentifier] NULL,
	[CalismaSekli] [char](9) NULL,
	[OdemeTipi] [char](9) NULL,
	[ExtraStr1] [nvarchar](100) NULL,
	[Img_1] [nvarchar](300) NULL,
	[Img_2] [nvarchar](300) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_CrmPersonel] ON [dbo].[CrmPersonel] 
(
	[IsActive] ASC,
	[IsDeleted] DESC,
	[DomainName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwYetkiGrupMenu]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwYetkiGrupMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiGrupId] [int] NULL,
	[MenuId] [int] NULL,
	[Acilklama] [nchar](10) NULL,
 CONSTRAINT [PK_YetkiGrupMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrwYetkiGrupKullanici]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrwYetkiGrupKullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiGrupId] [int] NULL,
	[DomainName] [nvarchar](50) NULL,
 CONSTRAINT [PK_YetkiGrupKullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrmEhliyet]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CrmEhliyet](
	[Id] [uniqueidentifier] NOT NULL,
	[PersonelId] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[Soyad] [nvarchar](30) NOT NULL,
	[VerilisIl] [nchar](10) NULL,
	[VerilisIlce] [nchar](10) NULL,
	[BelgeNo] [nvarchar](10) NULL,
	[VerilisTarihi] [date] NULL,
	[Sinif] [char](3) NOT NULL,
	[Img_1] [nvarchar](300) NULL,
	[Img_2] [nvarchar](300) NULL,
 CONSTRAINT [PK_CrmEhliyet_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SrvProje]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SrvProje](
	[Id] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](30) NULL,
	[Kod] [nvarchar](10) NULL,
	[Tipi] [char](6) NULL,
	[ProjeLideri] [uniqueidentifier] NULL,
	[FirmaYetkilisi] [nvarchar](30) NULL,
	[FirmaYetkiliEmail] [nvarchar](30) NULL,
	[FirmaYetkiliTel] [nvarchar](15) NULL,
	[FirmaYetkiliFax] [nvarchar](15) NULL,
	[WebSitesi] [nvarchar](50) NULL,
	[Sirket] [nchar](10) NULL,
	[Grup] [nchar](10) NULL,
	[Sektor] [nchar](10) NULL,
	[Bolge] [nchar](10) NULL,
	[SozlesmeyiYapan] [uniqueidentifier] NULL,
	[SozlesmeBaslangicTarihi] [datetime] NULL,
	[SozlesmeBitisTarihi] [datetime] NULL,
	[FaturaHizmetKodu] [nvarchar](50) NULL,
	[IskontoOrani] [numeric](4, 2) NULL,
	[FaturaGunu] [int] NULL,
	[FaturaTipi] [int] NULL,
	[MusteriTemsilcisi] [uniqueidentifier] NULL,
	[HostesHakEdisTutari] [numeric](18, 2) NULL,
	[SoforHakEdisTutari] [numeric](18, 2) NULL,
	[AracBedelsizSeferSayisi] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [datetime] NULL,
 CONSTRAINT [PK_SrvProje_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SrvArac]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SrvArac](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Plaka] [nvarchar](9) NOT NULL,
	[LogoKodu] [nvarchar](10) NULL,
	[YolcuKapasitesi] [int] NULL,
	[Marka] [int] NULL,
	[ModelYili] [int] NULL,
	[Renk] [char](6) NULL,
	[TedarikciId] [uniqueidentifier] NULL,
	[GpsCihazId] [int] NULL,
	[AracSahibiAd] [nvarchar](50) NULL,
	[AracSahibiSoyad] [nvarchar](50) NULL,
	[Cinsi] [nchar](10) NULL,
	[Tipi] [int] NULL,
	[MotorNo] [nvarchar](30) NULL,
	[SasiNo] [nvarchar](30) NULL,
	[NetAgirlik] [int] NULL,
	[IstiapHaddi] [int] NULL,
	[MotorGucu] [int] NULL,
	[SilindirHacmi] [int] NULL,
	[MuayeneTarihi] [date] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreateUser] [nvarchar](20) NULL,
	[CreateDate] [date] NULL,
	[DeleteUser] [nvarchar](20) NULL,
	[DeleteDate] [date] NULL,
 CONSTRAINT [PK_SrvArac] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Sp_FwUtil]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[Sp_FwUtil]
@DomainName Varchar(50)='',
@TranType int=0
as		
BEGIN

-- MENÜNÜN HAZIRLANMASI ----------------------------------------------------------------------
	IF @TranType=1 
	BEGIN
		
		SELECT * 
		INTO #TMP_MENU
		FROM FrwMENU
		WHERE 	IsActive=1
		and		IsMenu=1
		and     Id IN 
						(
						select MenuId from FrwYetkiGrupMenu
						where YetkiGrupId IN (
										select YetkiGrupId from FrwYetkiGrupKullanici
										where DomainName=@DomainName)
										)


		SELECT * 
		FROM FrwMENU WHERE Id IN (
		SELECT distinct UstId 
		FROM #TMP_MENU)
		
		UNION 
		select * 
		FROM #TMP_MENU
		order by UstId asc,Sira asc
		
		
	END
END
GO
/****** Object:  Table [dbo].[SrvGuzergahMain]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrvGuzergahMain](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjeId] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](30) NULL,
	[Kod] [nvarchar](10) NULL,
	[Km] [int] NULL,
	[MusteriFiyat] [numeric](18, 2) NULL,
	[TedarikFiyat] [numeric](18, 2) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_SrvGuzergahMain] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SrvGuzergah]    Script Date: 11/29/2014 18:30:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SrvGuzergah](
	[Id] [uniqueidentifier] NOT NULL,
	[GuzergahMainId] [uniqueidentifier] NOT NULL,
	[Ad] [nvarchar](30) NULL,
	[Kod] [nvarchar](10) NULL,
	[KisiSayisi] [int] NULL,
	[Arac] [int] NOT NULL,
	[Sofor] [uniqueidentifier] NULL,
	[Hostes] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_SrvGuzergah] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Departman_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmDepartman] ADD  CONSTRAINT [DF_Departman_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Departman_IsDeleted]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmDepartman] ADD  CONSTRAINT [DF_Departman_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_CrmDepartman_CreateUser]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmDepartman] ADD  CONSTRAINT [DF_CrmDepartman_CreateUser]  DEFAULT (user_name()) FOR [CreateUser]
GO
/****** Object:  Default [DF_Departman_CreateDate]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmDepartman] ADD  CONSTRAINT [DF_Departman_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_Bolum_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmBolum] ADD  CONSTRAINT [DF_Bolum_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Bolum_IsDeleted]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmBolum] ADD  CONSTRAINT [DF_Bolum_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Bolum_CreateDate]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmBolum] ADD  CONSTRAINT [DF_Bolum_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_Gorev_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmGorev] ADD  CONSTRAINT [DF_Gorev_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Gorev_IsDeleted]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmGorev] ADD  CONSTRAINT [DF_Gorev_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Gorev_CreateDate]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmGorev] ADD  CONSTRAINT [DF_Gorev_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_FirmaLokasyon_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirmaLokasyon] ADD  CONSTRAINT [DF_FirmaLokasyon_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_FirmaLokasyon_IsDeleted]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirmaLokasyon] ADD  CONSTRAINT [DF_FirmaLokasyon_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_FirmaLokasyon_CreateDate]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirmaLokasyon] ADD  CONSTRAINT [DF_FirmaLokasyon_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_Firma_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirma] ADD  CONSTRAINT [DF_Firma_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Firma_IsDeleted]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirma] ADD  CONSTRAINT [DF_Firma_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Firma_CreateDate]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[CrmFirma] ADD  CONSTRAINT [DF_Firma_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_GnlMarka_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[GnlMarka] ADD  CONSTRAINT [DF_GnlMarka_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_GnlBanka_IsActive]    Script Date: 11/29/2014 18:30:15 ******/
ALTER TABLE [dbo].[GnlBanka] ADD  CONSTRAINT [DF_GnlBanka_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_YetkiGrup_IsActive]    Script Date: 11/29/2014 18:30:16 ******/
ALTER TABLE [dbo].[FrwYetkiGrup] ADD  CONSTRAINT [DF_YetkiGrup_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Menu_IsActive]    Script Date: 11/29/2014 18:30:16 ******/
ALTER TABLE [dbo].[FrwMenu] ADD  CONSTRAINT [DF_Menu_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Menu_IsMenu]    Script Date: 11/29/2014 18:30:17 ******/
ALTER TABLE [dbo].[FrwMenu] ADD  CONSTRAINT [DF_Menu_IsMenu]  DEFAULT ((0)) FOR [IsMenu]
GO
/****** Object:  Default [DF_Menu_Sira]    Script Date: 11/29/2014 18:30:17 ******/
ALTER TABLE [dbo].[FrwMenu] ADD  CONSTRAINT [DF_Menu_Sira]  DEFAULT ((0)) FOR [Sira]
GO
/****** Object:  Default [DF_FrwGeneralValues_Durum]    Script Date: 11/29/2014 18:30:17 ******/
ALTER TABLE [dbo].[FrwGeneralValues] ADD  CONSTRAINT [DF_FrwGeneralValues_Durum]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvTedarikci_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvTedarikci] ADD  CONSTRAINT [DF_SrvTedarikci_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvTedarikci_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvTedarikci] ADD  CONSTRAINT [DF_SrvTedarikci_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_SrvTedarikci_CreateUser]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvTedarikci] ADD  CONSTRAINT [DF_SrvTedarikci_CreateUser]  DEFAULT (user_name()) FOR [CreateUser]
GO
/****** Object:  Default [DF_SrvTedarikci_CreateDate]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvTedarikci] ADD  CONSTRAINT [DF_SrvTedarikci_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_GnlModel_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[GnlModel] ADD  CONSTRAINT [DF_GnlModel_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Personel_MedeniHali]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel] ADD  CONSTRAINT [DF_Personel_MedeniHali]  DEFAULT ('B') FOR [MedeniHali]
GO
/****** Object:  Default [DF_Personel_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel] ADD  CONSTRAINT [DF_Personel_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Personel_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel] ADD  CONSTRAINT [DF_Personel_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Personel_CreateDate]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel] ADD  CONSTRAINT [DF_Personel_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SrvProje_IskontoOrani]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_IskontoOrani]  DEFAULT ((0)) FOR [IskontoOrani]
GO
/****** Object:  Default [DF_SrvProje_FaturaGunu]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_FaturaGunu]  DEFAULT ((1)) FOR [FaturaGunu]
GO
/****** Object:  Default [DF_SrvProje_HostesHakEdisTutari]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_HostesHakEdisTutari]  DEFAULT ((0)) FOR [HostesHakEdisTutari]
GO
/****** Object:  Default [DF_SrvProje_SoforHakEdisTutari]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_SoforHakEdisTutari]  DEFAULT ((0)) FOR [SoforHakEdisTutari]
GO
/****** Object:  Default [DF_SrvProje_AracBedelsizSeferSayisi]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_AracBedelsizSeferSayisi]  DEFAULT ((0)) FOR [AracBedelsizSeferSayisi]
GO
/****** Object:  Default [DF_SrvProje_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvProje_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_SrvProje_CreateUser]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_CreateUser]  DEFAULT (N'sys') FOR [CreateUser]
GO
/****** Object:  Default [DF_SrvProje_CreateDate]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje] ADD  CONSTRAINT [DF_SrvProje_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SrvArac_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac] ADD  CONSTRAINT [DF_SrvArac_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvArac_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac] ADD  CONSTRAINT [DF_SrvArac_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_SrvArac_CreateUser]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac] ADD  CONSTRAINT [DF_SrvArac_CreateUser]  DEFAULT (user_name()) FOR [CreateUser]
GO
/****** Object:  Default [DF_SrvArac_CreateDate]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac] ADD  CONSTRAINT [DF_SrvArac_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SrvGuzergahMain_Km]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergahMain] ADD  CONSTRAINT [DF_SrvGuzergahMain_Km]  DEFAULT ((0)) FOR [Km]
GO
/****** Object:  Default [DF_SrvGuzergahMain_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergahMain] ADD  CONSTRAINT [DF_SrvGuzergahMain_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvGuzergahMain_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergahMain] ADD  CONSTRAINT [DF_SrvGuzergahMain_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_SrvGuzergah_IsActive]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah] ADD  CONSTRAINT [DF_SrvGuzergah_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SrvGuzergah_IsDeleted]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah] ADD  CONSTRAINT [DF_SrvGuzergah_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Check [CK_Personel]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [CK_Personel] CHECK  (([Cinsiyet]='E' OR [Cinsiyet]='K'))
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [CK_Personel]
GO
/****** Object:  Check [CK_Personel_MedeniHali]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [CK_Personel_MedeniHali] CHECK  (([MedeniHali]='E' OR [MedeniHali]='B'))
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [CK_Personel_MedeniHali]
GO
/****** Object:  ForeignKey [FK_GnlModel_GnlMarka]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[GnlModel]  WITH CHECK ADD  CONSTRAINT [FK_GnlModel_GnlMarka] FOREIGN KEY([MarkaId])
REFERENCES [dbo].[GnlMarka] ([Id])
GO
ALTER TABLE [dbo].[GnlModel] CHECK CONSTRAINT [FK_GnlModel_GnlMarka]
GO
/****** Object:  ForeignKey [FK_CrmPersonel_CrmBolum]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [FK_CrmPersonel_CrmBolum] FOREIGN KEY([BolumId])
REFERENCES [dbo].[CrmBolum] ([Id])
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [FK_CrmPersonel_CrmBolum]
GO
/****** Object:  ForeignKey [FK_CrmPersonel_CrmDepartman]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [FK_CrmPersonel_CrmDepartman] FOREIGN KEY([DepartmanId])
REFERENCES [dbo].[CrmDepartman] ([Id])
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [FK_CrmPersonel_CrmDepartman]
GO
/****** Object:  ForeignKey [FK_CrmPersonel_CrmFirma]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [FK_CrmPersonel_CrmFirma] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[CrmFirma] ([Id])
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [FK_CrmPersonel_CrmFirma]
GO
/****** Object:  ForeignKey [FK_CrmPersonel_CrmFirmaLokasyon]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [FK_CrmPersonel_CrmFirmaLokasyon] FOREIGN KEY([FirmaLokasyonId])
REFERENCES [dbo].[CrmFirmaLokasyon] ([Id])
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [FK_CrmPersonel_CrmFirmaLokasyon]
GO
/****** Object:  ForeignKey [FK_CrmPersonel_CrmGorev]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmPersonel]  WITH CHECK ADD  CONSTRAINT [FK_CrmPersonel_CrmGorev] FOREIGN KEY([GorevId])
REFERENCES [dbo].[CrmGorev] ([Id])
GO
ALTER TABLE [dbo].[CrmPersonel] CHECK CONSTRAINT [FK_CrmPersonel_CrmGorev]
GO
/****** Object:  ForeignKey [FK_YetkiGrupMenu_Menu]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[FrwYetkiGrupMenu]  WITH CHECK ADD  CONSTRAINT [FK_YetkiGrupMenu_Menu] FOREIGN KEY([MenuId])
REFERENCES [dbo].[FrwMenu] ([Id])
GO
ALTER TABLE [dbo].[FrwYetkiGrupMenu] CHECK CONSTRAINT [FK_YetkiGrupMenu_Menu]
GO
/****** Object:  ForeignKey [FK_YetkiGrupMenu_YetkiGrup]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[FrwYetkiGrupMenu]  WITH CHECK ADD  CONSTRAINT [FK_YetkiGrupMenu_YetkiGrup] FOREIGN KEY([YetkiGrupId])
REFERENCES [dbo].[FrwYetkiGrup] ([Id])
GO
ALTER TABLE [dbo].[FrwYetkiGrupMenu] CHECK CONSTRAINT [FK_YetkiGrupMenu_YetkiGrup]
GO
/****** Object:  ForeignKey [FK_YetkiGrupKullanici_YetkiGrup]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[FrwYetkiGrupKullanici]  WITH CHECK ADD  CONSTRAINT [FK_YetkiGrupKullanici_YetkiGrup] FOREIGN KEY([YetkiGrupId])
REFERENCES [dbo].[FrwYetkiGrup] ([Id])
GO
ALTER TABLE [dbo].[FrwYetkiGrupKullanici] CHECK CONSTRAINT [FK_YetkiGrupKullanici_YetkiGrup]
GO
/****** Object:  ForeignKey [FK_CrmEhliyet_CrmPersonel]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[CrmEhliyet]  WITH CHECK ADD  CONSTRAINT [FK_CrmEhliyet_CrmPersonel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[CrmEhliyet] CHECK CONSTRAINT [FK_CrmEhliyet_CrmPersonel]
GO
/****** Object:  ForeignKey [FK_SrvProje_FrwGeneralValues]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje]  WITH CHECK ADD  CONSTRAINT [FK_SrvProje_FrwGeneralValues] FOREIGN KEY([Tipi])
REFERENCES [dbo].[FrwGeneralValues] ([Id])
GO
ALTER TABLE [dbo].[SrvProje] CHECK CONSTRAINT [FK_SrvProje_FrwGeneralValues]
GO
/****** Object:  ForeignKey [FK_SrvProje_MusteriTemsilcisi]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje]  WITH CHECK ADD  CONSTRAINT [FK_SrvProje_MusteriTemsilcisi] FOREIGN KEY([MusteriTemsilcisi])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[SrvProje] CHECK CONSTRAINT [FK_SrvProje_MusteriTemsilcisi]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MusteriTemsilcisiEx' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SrvProje', @level2type=N'CONSTRAINT',@level2name=N'FK_SrvProje_MusteriTemsilcisi'
GO
/****** Object:  ForeignKey [FK_SrvProje_ProjeLideri]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje]  WITH CHECK ADD  CONSTRAINT [FK_SrvProje_ProjeLideri] FOREIGN KEY([ProjeLideri])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[SrvProje] CHECK CONSTRAINT [FK_SrvProje_ProjeLideri]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ProjeLideriU' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SrvProje', @level2type=N'CONSTRAINT',@level2name=N'FK_SrvProje_ProjeLideri'
GO
/****** Object:  ForeignKey [FK_SrvProje_SozlesmeyiYapan]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvProje]  WITH CHECK ADD  CONSTRAINT [FK_SrvProje_SozlesmeyiYapan] FOREIGN KEY([SozlesmeyiYapan])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[SrvProje] CHECK CONSTRAINT [FK_SrvProje_SozlesmeyiYapan]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SozlesmeyiYapanU' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SrvProje', @level2type=N'CONSTRAINT',@level2name=N'FK_SrvProje_SozlesmeyiYapan'
GO
/****** Object:  ForeignKey [FK_SrvArac_GnlMarka]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac]  WITH CHECK ADD  CONSTRAINT [FK_SrvArac_GnlMarka] FOREIGN KEY([Marka])
REFERENCES [dbo].[GnlMarka] ([Id])
GO
ALTER TABLE [dbo].[SrvArac] CHECK CONSTRAINT [FK_SrvArac_GnlMarka]
GO
/****** Object:  ForeignKey [FK_SrvArac_GnlModel]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac]  WITH CHECK ADD  CONSTRAINT [FK_SrvArac_GnlModel] FOREIGN KEY([Tipi])
REFERENCES [dbo].[GnlModel] ([Id])
GO
ALTER TABLE [dbo].[SrvArac] CHECK CONSTRAINT [FK_SrvArac_GnlModel]
GO
/****** Object:  ForeignKey [FK_SrvArac_SrvTedarikci]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvArac]  WITH CHECK ADD  CONSTRAINT [FK_SrvArac_SrvTedarikci] FOREIGN KEY([TedarikciId])
REFERENCES [dbo].[SrvTedarikci] ([Id])
GO
ALTER TABLE [dbo].[SrvArac] CHECK CONSTRAINT [FK_SrvArac_SrvTedarikci]
GO
/****** Object:  ForeignKey [FK_SrvGuzergahMain_SrvProje]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergahMain]  WITH CHECK ADD  CONSTRAINT [FK_SrvGuzergahMain_SrvProje] FOREIGN KEY([ProjeId])
REFERENCES [dbo].[SrvProje] ([Id])
GO
ALTER TABLE [dbo].[SrvGuzergahMain] CHECK CONSTRAINT [FK_SrvGuzergahMain_SrvProje]
GO
/****** Object:  ForeignKey [FK_SrvGuzergah_Hostes]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah]  WITH CHECK ADD  CONSTRAINT [FK_SrvGuzergah_Hostes] FOREIGN KEY([Hostes])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[SrvGuzergah] CHECK CONSTRAINT [FK_SrvGuzergah_Hostes]
GO
/****** Object:  ForeignKey [FK_SrvGuzergah_Sofor]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah]  WITH CHECK ADD  CONSTRAINT [FK_SrvGuzergah_Sofor] FOREIGN KEY([Sofor])
REFERENCES [dbo].[CrmPersonel] ([Id])
GO
ALTER TABLE [dbo].[SrvGuzergah] CHECK CONSTRAINT [FK_SrvGuzergah_Sofor]
GO
/****** Object:  ForeignKey [FK_SrvGuzergah_SrvArac]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah]  WITH CHECK ADD  CONSTRAINT [FK_SrvGuzergah_SrvArac] FOREIGN KEY([Arac])
REFERENCES [dbo].[SrvArac] ([Id])
GO
ALTER TABLE [dbo].[SrvGuzergah] CHECK CONSTRAINT [FK_SrvGuzergah_SrvArac]
GO
/****** Object:  ForeignKey [FK_SrvGuzergah_SrvGuzergahMain]    Script Date: 11/29/2014 18:30:19 ******/
ALTER TABLE [dbo].[SrvGuzergah]  WITH CHECK ADD  CONSTRAINT [FK_SrvGuzergah_SrvGuzergahMain] FOREIGN KEY([GuzergahMainId])
REFERENCES [dbo].[SrvGuzergahMain] ([Id])
GO
ALTER TABLE [dbo].[SrvGuzergah] CHECK CONSTRAINT [FK_SrvGuzergah_SrvGuzergahMain]
GO
