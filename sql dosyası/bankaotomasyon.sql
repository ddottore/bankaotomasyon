USE [master]
GO
/****** Object:  Database [bankaotomasyon]    Script Date: 27.12.2022 11:24:09 ******/
CREATE DATABASE [bankaotomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bankaotomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bankaotomasyon.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bankaotomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bankaotomasyon_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [bankaotomasyon] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bankaotomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bankaotomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bankaotomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bankaotomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bankaotomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bankaotomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [bankaotomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bankaotomasyon] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [bankaotomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bankaotomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bankaotomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bankaotomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bankaotomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bankaotomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bankaotomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bankaotomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bankaotomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bankaotomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bankaotomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bankaotomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bankaotomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bankaotomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bankaotomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bankaotomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bankaotomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bankaotomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [bankaotomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bankaotomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bankaotomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bankaotomasyon] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [bankaotomasyon]
GO
/****** Object:  Table [dbo].[islem]    Script Date: 27.12.2022 11:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[islem](
	[islemno] [int] IDENTITY(1100,1) NOT NULL,
	[musteri_iban] [int] NULL,
	[islemyapanisim] [varchar](50) NULL,
	[islemyapansoyisim] [varchar](50) NULL,
	[yapilanislem] [varchar](50) NULL,
	[miktar] [varchar](max) NULL,
	[tarih] [smalldatetime] NULL,
 CONSTRAINT [PK_islem] PRIMARY KEY CLUSTERED 
(
	[islemno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[islemEng]    Script Date: 27.12.2022 11:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[islemEng](
	[islemno] [int] IDENTITY(1100,1) NOT NULL,
	[musteri_iban] [int] NULL,
	[islemyapanisim] [varchar](50) NULL,
	[islemyapansoyisim] [varchar](50) NULL,
	[yapilanislem] [varchar](50) NULL,
	[miktar] [varchar](max) NULL,
	[tarih] [smalldatetime] NULL,
 CONSTRAINT [PK_islemEng] PRIMARY KEY CLUSTERED 
(
	[islemno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 27.12.2022 11:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[musteri](
	[musteri_iban] [int] IDENTITY(1000,123) NOT NULL,
	[kullaniciAdi] [varchar](50) NOT NULL,
	[kullaniciSifre] [varchar](50) NOT NULL,
	[refKodu] [varchar](50) NOT NULL,
	[m_ad] [varchar](50) NOT NULL,
	[m_soyad] [varchar](50) NOT NULL,
	[m_yas] [varchar](50) NOT NULL,
	[m_tc] [varchar](50) NOT NULL,
	[m_bakiye] [int] NULL CONSTRAINT [DF_musteri_m_bakiye]  DEFAULT ((8500)),
	[m_puan] [int] NULL CONSTRAINT [DF_musteri_m_puan]  DEFAULT ((258)),
	[su] [int] NOT NULL,
	[dogalgaz] [int] NOT NULL,
	[elektrik] [int] NOT NULL,
	[email] [varchar](100) NULL,
 CONSTRAINT [PK_musteri] PRIMARY KEY CLUSTERED 
(
	[musteri_iban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sistem]    Script Date: 27.12.2022 11:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sistem](
	[askidapara] [int] NOT NULL,
	[atmpara] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yonetici]    Script Date: 27.12.2022 11:24:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[yonetici](
	[yoneticino] [int] IDENTITY(1,1) NOT NULL,
	[yoneticikullaniciadi] [varchar](50) NOT NULL,
	[yoneticisifre] [varchar](50) NOT NULL,
	[yoneticiadi] [varchar](50) NOT NULL,
	[yoneticisoyisim] [varchar](50) NOT NULL,
	[refkodu] [int] NOT NULL,
 CONSTRAINT [PK_yonetici] PRIMARY KEY CLUSTERED 
(
	[yoneticino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[islem]  WITH CHECK ADD  CONSTRAINT [FK_islem_musteri] FOREIGN KEY([musteri_iban])
REFERENCES [dbo].[musteri] ([musteri_iban])
GO
ALTER TABLE [dbo].[islem] CHECK CONSTRAINT [FK_islem_musteri]
GO
ALTER TABLE [dbo].[islemEng]  WITH CHECK ADD  CONSTRAINT [FK_islemEng_musteri] FOREIGN KEY([musteri_iban])
REFERENCES [dbo].[musteri] ([musteri_iban])
GO
ALTER TABLE [dbo].[islemEng] CHECK CONSTRAINT [FK_islemEng_musteri]
GO
USE [master]
GO
ALTER DATABASE [bankaotomasyon] SET  READ_WRITE 
GO
