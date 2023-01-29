
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2015 23:17:44
-- Generated from EDMX file: D:\KronusSoft\Server\Kronus.Server.Entity\dbCrm.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bosCRM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_YetkiGrupKullanici_YetkiGrup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FrwYetkiGrupKullanici] DROP CONSTRAINT [FK_YetkiGrupKullanici_YetkiGrup];
GO
IF OBJECT_ID(N'[dbo].[FK_YetkiGrupMenu_YetkiGrup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FrwYetkiGrupMenu] DROP CONSTRAINT [FK_YetkiGrupMenu_YetkiGrup];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvProje_FrwGeneralValues]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvProjes] DROP CONSTRAINT [FK_SrvProje_FrwGeneralValues];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvGuzergahMain_SrvProje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvGuzergahMains] DROP CONSTRAINT [FK_SrvGuzergahMain_SrvProje];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvGuzergah_SrvGuzergahMain]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvGuzergahs] DROP CONSTRAINT [FK_SrvGuzergah_SrvGuzergahMain];
GO
IF OBJECT_ID(N'[dbo].[FK_GnlModel_GnlMarka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GnlModels] DROP CONSTRAINT [FK_GnlModel_GnlMarka];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvArac_GnlMarka]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvAracs] DROP CONSTRAINT [FK_SrvArac_GnlMarka];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvArac_GnlModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvAracs] DROP CONSTRAINT [FK_SrvArac_GnlModel];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvArac_SrvTedarikci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvAracs] DROP CONSTRAINT [FK_SrvArac_SrvTedarikci];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvGuzergah_SrvArac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvGuzergahs] DROP CONSTRAINT [FK_SrvGuzergah_SrvArac];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmPersonel_CrmBolum]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmPersonel] DROP CONSTRAINT [FK_CrmPersonel_CrmBolum];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmPersonel_CrmDepartman]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmPersonel] DROP CONSTRAINT [FK_CrmPersonel_CrmDepartman];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmPersonel_CrmFirma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmPersonel] DROP CONSTRAINT [FK_CrmPersonel_CrmFirma];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmPersonel_CrmFirmaLokasyon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmPersonel] DROP CONSTRAINT [FK_CrmPersonel_CrmFirmaLokasyon];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmPersonel_CrmGorev]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmPersonel] DROP CONSTRAINT [FK_CrmPersonel_CrmGorev];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvGuzergah_Hostes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvGuzergahs] DROP CONSTRAINT [FK_SrvGuzergah_Hostes];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvGuzergah_Sofor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvGuzergahs] DROP CONSTRAINT [FK_SrvGuzergah_Sofor];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvProje_MusteriTemsilcisi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvProjes] DROP CONSTRAINT [FK_SrvProje_MusteriTemsilcisi];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvProje_ProjeLideri]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvProjes] DROP CONSTRAINT [FK_SrvProje_ProjeLideri];
GO
IF OBJECT_ID(N'[dbo].[FK_SrvProje_SozlesmeyiYapan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SrvProjes] DROP CONSTRAINT [FK_SrvProje_SozlesmeyiYapan];
GO
IF OBJECT_ID(N'[dbo].[FK_CrmEhliyet_CrmPersonel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CrmEhliyet] DROP CONSTRAINT [FK_CrmEhliyet_CrmPersonel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CrmBolum]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmBolum];
GO
IF OBJECT_ID(N'[dbo].[CrmDepartman]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmDepartman];
GO
IF OBJECT_ID(N'[dbo].[CrmFirma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmFirma];
GO
IF OBJECT_ID(N'[dbo].[CrmFirmaLokasyon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmFirmaLokasyon];
GO
IF OBJECT_ID(N'[dbo].[CrmGorev]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmGorev];
GO
IF OBJECT_ID(N'[dbo].[FrwYetkiGrup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FrwYetkiGrup];
GO
IF OBJECT_ID(N'[dbo].[FrwYetkiGrupKullanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FrwYetkiGrupKullanici];
GO
IF OBJECT_ID(N'[dbo].[FrwYetkiGrupMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FrwYetkiGrupMenu];
GO
IF OBJECT_ID(N'[dbo].[SrvTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvTable];
GO
IF OBJECT_ID(N'[dbo].[FrwGeneralContraints]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FrwGeneralContraints];
GO
IF OBJECT_ID(N'[dbo].[FrwGeneralValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FrwGeneralValues];
GO
IF OBJECT_ID(N'[dbo].[SrvPersonels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvPersonels];
GO
IF OBJECT_ID(N'[dbo].[SrvProjes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvProjes];
GO
IF OBJECT_ID(N'[dbo].[SrvGuzergahMains]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvGuzergahMains];
GO
IF OBJECT_ID(N'[dbo].[SrvGuzergahs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvGuzergahs];
GO
IF OBJECT_ID(N'[dbo].[SrvTedarikcis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvTedarikcis];
GO
IF OBJECT_ID(N'[dbo].[GnlMarkas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GnlMarkas];
GO
IF OBJECT_ID(N'[dbo].[GnlModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GnlModels];
GO
IF OBJECT_ID(N'[dbo].[SrvAracs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SrvAracs];
GO
IF OBJECT_ID(N'[dbo].[GnlBankas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GnlBankas];
GO
IF OBJECT_ID(N'[dbo].[CrmPersonel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmPersonel];
GO
IF OBJECT_ID(N'[dbo].[CrmEhliyet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CrmEhliyet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CrmBolum'
CREATE TABLE [dbo].[CrmBolum] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(50)  NULL,
    [Aciklama] nvarchar(300)  NULL,
    [DepartmanId] uniqueidentifier  NULL,
    [BolumEmailGrup] nvarchar(50)  NULL,
    [ExtraStr1] nvarchar(50)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'CrmDepartman'
CREATE TABLE [dbo].[CrmDepartman] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(100)  NULL,
    [Aciklama] nvarchar(250)  NULL,
    [ExtraStr1] nvarchar(50)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'CrmFirma'
CREATE TABLE [dbo].[CrmFirma] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(50)  NULL,
    [Aciklama] nvarchar(300)  NULL,
    [CariKod] nvarchar(10)  NULL,
    [ExtraStr1] nvarchar(50)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(50)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(50)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'CrmFirmaLokasyon'
CREATE TABLE [dbo].[CrmFirmaLokasyon] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(50)  NULL,
    [Aciklama] nvarchar(50)  NULL,
    [FirmaId] uniqueidentifier  NULL,
    [Il] int  NULL,
    [Ilce] int  NULL,
    [ExtraStr1] nvarchar(50)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'CrmGorev'
CREATE TABLE [dbo].[CrmGorev] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(50)  NULL,
    [Aciklama] nvarchar(300)  NULL,
    [ExtraStr1] nvarchar(50)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'FrwYetkiGrup'
CREATE TABLE [dbo].[FrwYetkiGrup] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(100)  NULL,
    [Aciklama] nvarchar(500)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'FrwYetkiGrupKullanici'
CREATE TABLE [dbo].[FrwYetkiGrupKullanici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [YetkiGrupId] int  NULL,
    [DomainName] nvarchar(50)  NULL
);
GO

-- Creating table 'FrwYetkiGrupMenu'
CREATE TABLE [dbo].[FrwYetkiGrupMenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [YetkiGrupId] int  NULL,
    [MenuId] int  NULL,
    [Acilklama] nchar(10)  NULL
);
GO

-- Creating table 'SrvTable'
CREATE TABLE [dbo].[SrvTable] (
    [sdf] nchar(10)  NOT NULL
);
GO

-- Creating table 'FrwGeneralContraints'
CREATE TABLE [dbo].[FrwGeneralContraints] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Enum] nvarchar(30)  NULL,
    [Deger] nvarchar(20)  NULL
);
GO

-- Creating table 'FrwGeneralValues'
CREATE TABLE [dbo].[FrwGeneralValues] (
    [Id] char(6)  NOT NULL,
    [Ad] nvarchar(20)  NOT NULL,
    [UstId] char(6)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'SrvPersonels'
CREATE TABLE [dbo].[SrvPersonels] (
    [Id] uniqueidentifier  NOT NULL,
    [ProjeId] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(20)  NULL,
    [Soyad] nvarchar(20)  NULL,
    [TcKimlikNo] nvarchar(12)  NULL,
    [DogumTarihi] datetime  NULL,
    [DogumYeri] nvarchar(20)  NULL,
    [Email] nvarchar(30)  NULL,
    [Telefon] nvarchar(15)  NULL,
    [Gsm] nchar(15)  NULL,
    [Adres] nvarchar(500)  NULL,
    [KanGrubu] nvarchar(10)  NULL,
    [Il] nvarchar(20)  NULL,
    [Ilce] nvarchar(20)  NULL,
    [MedeniHali] char(1)  NULL,
    [Uyruk] nchar(10)  NULL,
    [La] float  NULL,
    [Lo] float  NULL
);
GO

-- Creating table 'SrvProjes'
CREATE TABLE [dbo].[SrvProjes] (
    [Id] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(30)  NULL,
    [Kod] nvarchar(10)  NULL,
    [Tipi] char(6)  NULL,
    [ProjeLideri] uniqueidentifier  NULL,
    [FirmaYetkilisi] nvarchar(30)  NULL,
    [FirmaYetkiliEmail] nvarchar(30)  NULL,
    [FirmaYetkiliTel] nvarchar(15)  NULL,
    [FirmaYetkiliFax] nvarchar(15)  NULL,
    [WebSitesi] nvarchar(50)  NULL,
    [Sirket] nchar(10)  NULL,
    [Grup] nchar(10)  NULL,
    [Sektor] nchar(10)  NULL,
    [Bolge] nchar(10)  NULL,
    [SozlesmeyiYapan] uniqueidentifier  NULL,
    [SozlesmeBaslangicTarihi] datetime  NULL,
    [SozlesmeBitisTarihi] datetime  NULL,
    [FaturaHizmetKodu] nvarchar(50)  NULL,
    [IskontoOrani] decimal(4,2)  NULL,
    [FaturaGunu] int  NULL,
    [FaturaTipi] int  NULL,
    [MusteriTemsilcisi] uniqueidentifier  NULL,
    [HostesHakEdisTutari] decimal(18,2)  NULL,
    [SoforHakEdisTutari] decimal(18,2)  NULL,
    [AracBedelsizSeferSayisi] int  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'SrvGuzergahMains'
CREATE TABLE [dbo].[SrvGuzergahMains] (
    [Id] uniqueidentifier  NOT NULL,
    [ProjeId] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(30)  NULL,
    [Kod] nvarchar(10)  NULL,
    [Km] int  NULL,
    [MusteriFiyat] decimal(18,2)  NULL,
    [TedarikFiyat] decimal(18,2)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL
);
GO

-- Creating table 'SrvGuzergahs'
CREATE TABLE [dbo].[SrvGuzergahs] (
    [Id] uniqueidentifier  NOT NULL,
    [GuzergahMainId] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(30)  NULL,
    [Kod] nvarchar(10)  NULL,
    [KisiSayisi] int  NULL,
    [Arac] int  NOT NULL,
    [Sofor] uniqueidentifier  NULL,
    [Hostes] uniqueidentifier  NULL,
    [IsActive] bit  NOT NULL,
    [IsDeleted] bit  NOT NULL
);
GO

-- Creating table 'SrvTedarikcis'
CREATE TABLE [dbo].[SrvTedarikcis] (
    [Id] uniqueidentifier  NOT NULL,
    [CariKod] nvarchar(20)  NULL,
    [CariAd] nvarchar(20)  NULL,
    [YetkiliKisi] nvarchar(20)  NULL,
    [VergiDairesi] nvarchar(20)  NULL,
    [VergiNo] nvarchar(20)  NULL,
    [Banka] nvarchar(20)  NULL,
    [Sube] nvarchar(20)  NULL,
    [HesapNo] nvarchar(20)  NULL,
    [IBAN] nvarchar(20)  NULL,
    [Telefon] nvarchar(15)  NULL,
    [Gsm] nvarchar(15)  NULL,
    [Fax] nvarchar(15)  NULL,
    [Adres] nvarchar(300)  NULL,
    [Aciklama] nvarchar(500)  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'GnlMarkas'
CREATE TABLE [dbo].[GnlMarkas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(50)  NOT NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'GnlModels'
CREATE TABLE [dbo].[GnlModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MarkaId] int  NOT NULL,
    [Ad] nvarchar(50)  NOT NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'SrvAracs'
CREATE TABLE [dbo].[SrvAracs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Plaka] nvarchar(9)  NOT NULL,
    [LogoKodu] nvarchar(10)  NULL,
    [YolcuKapasitesi] int  NULL,
    [Marka] int  NULL,
    [ModelYili] int  NULL,
    [Renk] char(6)  NULL,
    [TedarikciId] uniqueidentifier  NULL,
    [GpsCihazId] int  NULL,
    [AracSahibiAd] nvarchar(50)  NULL,
    [AracSahibiSoyad] nvarchar(50)  NULL,
    [Cinsi] nchar(10)  NULL,
    [Tipi] int  NULL,
    [MotorNo] nvarchar(30)  NULL,
    [SasiNo] nvarchar(30)  NULL,
    [NetAgirlik] int  NULL,
    [IstiapHaddi] int  NULL,
    [MotorGucu] int  NULL,
    [SilindirHacmi] int  NULL,
    [MuayeneTarihi] datetime  NULL,
    [IsActive] bit  NULL,
    [IsDeleted] bit  NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL,
    [DeleteDate] datetime  NULL
);
GO

-- Creating table 'GnlBankas'
CREATE TABLE [dbo].[GnlBankas] (
    [Id] char(6)  NOT NULL,
    [Ad] nvarchar(50)  NOT NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'CrmPersonel'
CREATE TABLE [dbo].[CrmPersonel] (
    [Id] uniqueidentifier  NOT NULL,
    [DomainName] nvarchar(50)  NULL,
    [CariKod] nvarchar(25)  NULL,
    [Ad] nvarchar(15)  NULL,
    [Soyad] nvarchar(15)  NULL,
    [DogumTarihi] datetime  NULL,
    [TcKimlikNo] nvarchar(11)  NULL,
    [MedeniHali] char(1)  NULL,
    [Adres] nvarchar(500)  NULL,
    [Email] nvarchar(50)  NULL,
    [EmailIs] nvarchar(50)  NULL,
    [TelefonNo] nvarchar(15)  NULL,
    [GsmNo] nvarchar(15)  NULL,
    [TelefonNoIs] nvarchar(15)  NULL,
    [Cinsiyet] char(1)  NULL,
    [ProfilFoto] nvarchar(300)  NULL,
    [GirisTarihi] datetime  NULL,
    [CikisTarihi] datetime  NULL,
    [BirinciYonetici] uniqueidentifier  NULL,
    [IkinciYonetici] uniqueidentifier  NULL,
    [DepartmanId] uniqueidentifier  NULL,
    [BolumId] uniqueidentifier  NULL,
    [GorevId] uniqueidentifier  NULL,
    [FirmaId] uniqueidentifier  NULL,
    [FirmaLokasyonId] uniqueidentifier  NULL,
    [EhliyetId] uniqueidentifier  NULL,
    [CalismaSekli] char(9)  NULL,
    [OdemeTipi] char(9)  NULL,
    [ExtraStr1] nvarchar(100)  NULL,
    [Img_1] nvarchar(300)  NULL,
    [Img_2] nvarchar(300)  NULL,
    [IsActive] bit  NOT NULL,
    [IsDeleted] bit  NOT NULL,
    [CreateUser] nvarchar(20)  NULL,
    [CreateDate] datetime  NULL,
    [DeleteDate] datetime  NULL,
    [DeleteUser] nvarchar(20)  NULL
);
GO

-- Creating table 'CrmEhliyet'
CREATE TABLE [dbo].[CrmEhliyet] (
    [Id] uniqueidentifier  NOT NULL,
    [PersonelId] uniqueidentifier  NOT NULL,
    [Ad] nvarchar(30)  NOT NULL,
    [Soyad] nvarchar(30)  NOT NULL,
    [VerilisIl] nchar(10)  NULL,
    [VerilisIlce] nchar(10)  NULL,
    [BelgeNo] nvarchar(10)  NULL,
    [VerilisTarihi] datetime  NULL,
    [Sinif] char(3)  NOT NULL,
    [Img_1] nvarchar(300)  NULL,
    [Img_2] nvarchar(300)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CrmBolum'
ALTER TABLE [dbo].[CrmBolum]
ADD CONSTRAINT [PK_CrmBolum]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmDepartman'
ALTER TABLE [dbo].[CrmDepartman]
ADD CONSTRAINT [PK_CrmDepartman]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmFirma'
ALTER TABLE [dbo].[CrmFirma]
ADD CONSTRAINT [PK_CrmFirma]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmFirmaLokasyon'
ALTER TABLE [dbo].[CrmFirmaLokasyon]
ADD CONSTRAINT [PK_CrmFirmaLokasyon]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmGorev'
ALTER TABLE [dbo].[CrmGorev]
ADD CONSTRAINT [PK_CrmGorev]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FrwYetkiGrup'
ALTER TABLE [dbo].[FrwYetkiGrup]
ADD CONSTRAINT [PK_FrwYetkiGrup]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FrwYetkiGrupKullanici'
ALTER TABLE [dbo].[FrwYetkiGrupKullanici]
ADD CONSTRAINT [PK_FrwYetkiGrupKullanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FrwYetkiGrupMenu'
ALTER TABLE [dbo].[FrwYetkiGrupMenu]
ADD CONSTRAINT [PK_FrwYetkiGrupMenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [sdf] in table 'SrvTable'
ALTER TABLE [dbo].[SrvTable]
ADD CONSTRAINT [PK_SrvTable]
    PRIMARY KEY CLUSTERED ([sdf] ASC);
GO

-- Creating primary key on [Id] in table 'FrwGeneralContraints'
ALTER TABLE [dbo].[FrwGeneralContraints]
ADD CONSTRAINT [PK_FrwGeneralContraints]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FrwGeneralValues'
ALTER TABLE [dbo].[FrwGeneralValues]
ADD CONSTRAINT [PK_FrwGeneralValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvPersonels'
ALTER TABLE [dbo].[SrvPersonels]
ADD CONSTRAINT [PK_SrvPersonels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvProjes'
ALTER TABLE [dbo].[SrvProjes]
ADD CONSTRAINT [PK_SrvProjes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvGuzergahMains'
ALTER TABLE [dbo].[SrvGuzergahMains]
ADD CONSTRAINT [PK_SrvGuzergahMains]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvGuzergahs'
ALTER TABLE [dbo].[SrvGuzergahs]
ADD CONSTRAINT [PK_SrvGuzergahs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvTedarikcis'
ALTER TABLE [dbo].[SrvTedarikcis]
ADD CONSTRAINT [PK_SrvTedarikcis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GnlMarkas'
ALTER TABLE [dbo].[GnlMarkas]
ADD CONSTRAINT [PK_GnlMarkas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GnlModels'
ALTER TABLE [dbo].[GnlModels]
ADD CONSTRAINT [PK_GnlModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SrvAracs'
ALTER TABLE [dbo].[SrvAracs]
ADD CONSTRAINT [PK_SrvAracs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GnlBankas'
ALTER TABLE [dbo].[GnlBankas]
ADD CONSTRAINT [PK_GnlBankas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [PK_CrmPersonel]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CrmEhliyet'
ALTER TABLE [dbo].[CrmEhliyet]
ADD CONSTRAINT [PK_CrmEhliyet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [YetkiGrupId] in table 'FrwYetkiGrupKullanici'
ALTER TABLE [dbo].[FrwYetkiGrupKullanici]
ADD CONSTRAINT [FK_YetkiGrupKullanici_YetkiGrup]
    FOREIGN KEY ([YetkiGrupId])
    REFERENCES [dbo].[FrwYetkiGrup]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_YetkiGrupKullanici_YetkiGrup'
CREATE INDEX [IX_FK_YetkiGrupKullanici_YetkiGrup]
ON [dbo].[FrwYetkiGrupKullanici]
    ([YetkiGrupId]);
GO

-- Creating foreign key on [YetkiGrupId] in table 'FrwYetkiGrupMenu'
ALTER TABLE [dbo].[FrwYetkiGrupMenu]
ADD CONSTRAINT [FK_YetkiGrupMenu_YetkiGrup]
    FOREIGN KEY ([YetkiGrupId])
    REFERENCES [dbo].[FrwYetkiGrup]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_YetkiGrupMenu_YetkiGrup'
CREATE INDEX [IX_FK_YetkiGrupMenu_YetkiGrup]
ON [dbo].[FrwYetkiGrupMenu]
    ([YetkiGrupId]);
GO

-- Creating foreign key on [Tipi] in table 'SrvProjes'
ALTER TABLE [dbo].[SrvProjes]
ADD CONSTRAINT [FK_SrvProje_FrwGeneralValues]
    FOREIGN KEY ([Tipi])
    REFERENCES [dbo].[FrwGeneralValues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvProje_FrwGeneralValues'
CREATE INDEX [IX_FK_SrvProje_FrwGeneralValues]
ON [dbo].[SrvProjes]
    ([Tipi]);
GO

-- Creating foreign key on [ProjeId] in table 'SrvGuzergahMains'
ALTER TABLE [dbo].[SrvGuzergahMains]
ADD CONSTRAINT [FK_SrvGuzergahMain_SrvProje]
    FOREIGN KEY ([ProjeId])
    REFERENCES [dbo].[SrvProjes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvGuzergahMain_SrvProje'
CREATE INDEX [IX_FK_SrvGuzergahMain_SrvProje]
ON [dbo].[SrvGuzergahMains]
    ([ProjeId]);
GO

-- Creating foreign key on [GuzergahMainId] in table 'SrvGuzergahs'
ALTER TABLE [dbo].[SrvGuzergahs]
ADD CONSTRAINT [FK_SrvGuzergah_SrvGuzergahMain]
    FOREIGN KEY ([GuzergahMainId])
    REFERENCES [dbo].[SrvGuzergahMains]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvGuzergah_SrvGuzergahMain'
CREATE INDEX [IX_FK_SrvGuzergah_SrvGuzergahMain]
ON [dbo].[SrvGuzergahs]
    ([GuzergahMainId]);
GO

-- Creating foreign key on [MarkaId] in table 'GnlModels'
ALTER TABLE [dbo].[GnlModels]
ADD CONSTRAINT [FK_GnlModel_GnlMarka]
    FOREIGN KEY ([MarkaId])
    REFERENCES [dbo].[GnlMarkas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GnlModel_GnlMarka'
CREATE INDEX [IX_FK_GnlModel_GnlMarka]
ON [dbo].[GnlModels]
    ([MarkaId]);
GO

-- Creating foreign key on [Marka] in table 'SrvAracs'
ALTER TABLE [dbo].[SrvAracs]
ADD CONSTRAINT [FK_SrvArac_GnlMarka]
    FOREIGN KEY ([Marka])
    REFERENCES [dbo].[GnlMarkas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvArac_GnlMarka'
CREATE INDEX [IX_FK_SrvArac_GnlMarka]
ON [dbo].[SrvAracs]
    ([Marka]);
GO

-- Creating foreign key on [Tipi] in table 'SrvAracs'
ALTER TABLE [dbo].[SrvAracs]
ADD CONSTRAINT [FK_SrvArac_GnlModel]
    FOREIGN KEY ([Tipi])
    REFERENCES [dbo].[GnlModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvArac_GnlModel'
CREATE INDEX [IX_FK_SrvArac_GnlModel]
ON [dbo].[SrvAracs]
    ([Tipi]);
GO

-- Creating foreign key on [TedarikciId] in table 'SrvAracs'
ALTER TABLE [dbo].[SrvAracs]
ADD CONSTRAINT [FK_SrvArac_SrvTedarikci]
    FOREIGN KEY ([TedarikciId])
    REFERENCES [dbo].[SrvTedarikcis]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvArac_SrvTedarikci'
CREATE INDEX [IX_FK_SrvArac_SrvTedarikci]
ON [dbo].[SrvAracs]
    ([TedarikciId]);
GO

-- Creating foreign key on [Arac] in table 'SrvGuzergahs'
ALTER TABLE [dbo].[SrvGuzergahs]
ADD CONSTRAINT [FK_SrvGuzergah_SrvArac]
    FOREIGN KEY ([Arac])
    REFERENCES [dbo].[SrvAracs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvGuzergah_SrvArac'
CREATE INDEX [IX_FK_SrvGuzergah_SrvArac]
ON [dbo].[SrvGuzergahs]
    ([Arac]);
GO

-- Creating foreign key on [BolumId] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [FK_CrmPersonel_CrmBolum]
    FOREIGN KEY ([BolumId])
    REFERENCES [dbo].[CrmBolum]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmPersonel_CrmBolum'
CREATE INDEX [IX_FK_CrmPersonel_CrmBolum]
ON [dbo].[CrmPersonel]
    ([BolumId]);
GO

-- Creating foreign key on [DepartmanId] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [FK_CrmPersonel_CrmDepartman]
    FOREIGN KEY ([DepartmanId])
    REFERENCES [dbo].[CrmDepartman]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmPersonel_CrmDepartman'
CREATE INDEX [IX_FK_CrmPersonel_CrmDepartman]
ON [dbo].[CrmPersonel]
    ([DepartmanId]);
GO

-- Creating foreign key on [FirmaId] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [FK_CrmPersonel_CrmFirma]
    FOREIGN KEY ([FirmaId])
    REFERENCES [dbo].[CrmFirma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmPersonel_CrmFirma'
CREATE INDEX [IX_FK_CrmPersonel_CrmFirma]
ON [dbo].[CrmPersonel]
    ([FirmaId]);
GO

-- Creating foreign key on [FirmaLokasyonId] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [FK_CrmPersonel_CrmFirmaLokasyon]
    FOREIGN KEY ([FirmaLokasyonId])
    REFERENCES [dbo].[CrmFirmaLokasyon]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmPersonel_CrmFirmaLokasyon'
CREATE INDEX [IX_FK_CrmPersonel_CrmFirmaLokasyon]
ON [dbo].[CrmPersonel]
    ([FirmaLokasyonId]);
GO

-- Creating foreign key on [GorevId] in table 'CrmPersonel'
ALTER TABLE [dbo].[CrmPersonel]
ADD CONSTRAINT [FK_CrmPersonel_CrmGorev]
    FOREIGN KEY ([GorevId])
    REFERENCES [dbo].[CrmGorev]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmPersonel_CrmGorev'
CREATE INDEX [IX_FK_CrmPersonel_CrmGorev]
ON [dbo].[CrmPersonel]
    ([GorevId]);
GO

-- Creating foreign key on [Hostes] in table 'SrvGuzergahs'
ALTER TABLE [dbo].[SrvGuzergahs]
ADD CONSTRAINT [FK_SrvGuzergah_Hostes]
    FOREIGN KEY ([Hostes])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvGuzergah_Hostes'
CREATE INDEX [IX_FK_SrvGuzergah_Hostes]
ON [dbo].[SrvGuzergahs]
    ([Hostes]);
GO

-- Creating foreign key on [Sofor] in table 'SrvGuzergahs'
ALTER TABLE [dbo].[SrvGuzergahs]
ADD CONSTRAINT [FK_SrvGuzergah_Sofor]
    FOREIGN KEY ([Sofor])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvGuzergah_Sofor'
CREATE INDEX [IX_FK_SrvGuzergah_Sofor]
ON [dbo].[SrvGuzergahs]
    ([Sofor]);
GO

-- Creating foreign key on [MusteriTemsilcisi] in table 'SrvProjes'
ALTER TABLE [dbo].[SrvProjes]
ADD CONSTRAINT [FK_SrvProje_MusteriTemsilcisi]
    FOREIGN KEY ([MusteriTemsilcisi])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvProje_MusteriTemsilcisi'
CREATE INDEX [IX_FK_SrvProje_MusteriTemsilcisi]
ON [dbo].[SrvProjes]
    ([MusteriTemsilcisi]);
GO

-- Creating foreign key on [ProjeLideri] in table 'SrvProjes'
ALTER TABLE [dbo].[SrvProjes]
ADD CONSTRAINT [FK_SrvProje_ProjeLideri]
    FOREIGN KEY ([ProjeLideri])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvProje_ProjeLideri'
CREATE INDEX [IX_FK_SrvProje_ProjeLideri]
ON [dbo].[SrvProjes]
    ([ProjeLideri]);
GO

-- Creating foreign key on [SozlesmeyiYapan] in table 'SrvProjes'
ALTER TABLE [dbo].[SrvProjes]
ADD CONSTRAINT [FK_SrvProje_SozlesmeyiYapan]
    FOREIGN KEY ([SozlesmeyiYapan])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SrvProje_SozlesmeyiYapan'
CREATE INDEX [IX_FK_SrvProje_SozlesmeyiYapan]
ON [dbo].[SrvProjes]
    ([SozlesmeyiYapan]);
GO

-- Creating foreign key on [PersonelId] in table 'CrmEhliyet'
ALTER TABLE [dbo].[CrmEhliyet]
ADD CONSTRAINT [FK_CrmEhliyet_CrmPersonel]
    FOREIGN KEY ([PersonelId])
    REFERENCES [dbo].[CrmPersonel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CrmEhliyet_CrmPersonel'
CREATE INDEX [IX_FK_CrmEhliyet_CrmPersonel]
ON [dbo].[CrmEhliyet]
    ([PersonelId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------