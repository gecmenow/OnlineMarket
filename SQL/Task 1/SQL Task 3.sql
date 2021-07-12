USE [master]
GO

/****** Object:  Database [KramDeliveryFood]    Script Date: 22.06.2021 14:40:04 ******/
CREATE DATABASE [KramDeliveryFood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KramDeliveryFood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KramDeliveryFood.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KramDeliveryFood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KramDeliveryFood_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KramDeliveryFood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [KramDeliveryFood] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET ARITHABORT OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [KramDeliveryFood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [KramDeliveryFood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET  DISABLE_BROKER 
GO

ALTER DATABASE [KramDeliveryFood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [KramDeliveryFood] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET RECOVERY FULL 
GO

ALTER DATABASE [KramDeliveryFood] SET  MULTI_USER 
GO

ALTER DATABASE [KramDeliveryFood] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [KramDeliveryFood] SET DB_CHAINING OFF 
GO

ALTER DATABASE [KramDeliveryFood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [KramDeliveryFood] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [KramDeliveryFood] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [KramDeliveryFood] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [KramDeliveryFood] SET QUERY_STORE = OFF
GO

ALTER DATABASE [KramDeliveryFood] SET  READ_WRITE 
GO


