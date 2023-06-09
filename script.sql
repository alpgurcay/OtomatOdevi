USE [master]
GO
/****** Object:  Database [otomatsql]    Script Date: 19.05.2023 23:06:08 ******/
CREATE DATABASE [otomatsql]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'otomatsql', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\otomatsql.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'otomatsql_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\otomatsql_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [otomatsql] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [otomatsql].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [otomatsql] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [otomatsql] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [otomatsql] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [otomatsql] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [otomatsql] SET ARITHABORT OFF 
GO
ALTER DATABASE [otomatsql] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [otomatsql] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [otomatsql] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [otomatsql] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [otomatsql] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [otomatsql] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [otomatsql] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [otomatsql] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [otomatsql] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [otomatsql] SET  DISABLE_BROKER 
GO
ALTER DATABASE [otomatsql] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [otomatsql] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [otomatsql] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [otomatsql] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [otomatsql] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [otomatsql] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [otomatsql] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [otomatsql] SET RECOVERY FULL 
GO
ALTER DATABASE [otomatsql] SET  MULTI_USER 
GO
ALTER DATABASE [otomatsql] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [otomatsql] SET DB_CHAINING OFF 
GO
ALTER DATABASE [otomatsql] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [otomatsql] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [otomatsql] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [otomatsql] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'otomatsql', N'ON'
GO
ALTER DATABASE [otomatsql] SET QUERY_STORE = ON
GO
ALTER DATABASE [otomatsql] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [otomatsql]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19.05.2023 23:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Urunler] [nvarchar](50) NULL,
	[Fiyat] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Products] ([Urunler], [Fiyat]) VALUES (N'Su', 5)
INSERT [dbo].[Products] ([Urunler], [Fiyat]) VALUES (N'Kola', 20)
INSERT [dbo].[Products] ([Urunler], [Fiyat]) VALUES (N'Cikolata', 15)
GO
USE [master]
GO
ALTER DATABASE [otomatsql] SET  READ_WRITE 
GO
