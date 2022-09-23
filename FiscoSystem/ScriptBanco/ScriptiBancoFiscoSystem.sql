USE [master]
GO

/****** Object:  Database [FiscoSystem]    Script Date: 20/09/2022 19:34:42 ******/
DROP DATABASE [FiscoSystem]
GO

/****** Object:  Database [FiscoSystem]    Script Date: 20/09/2022 19:34:42 ******/
CREATE DATABASE [FiscoSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FiscoSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FiscoSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FiscoSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FiscoSystem_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FiscoSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FiscoSystem] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FiscoSystem] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FiscoSystem] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FiscoSystem] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FiscoSystem] SET ARITHABORT OFF 
GO

ALTER DATABASE [FiscoSystem] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FiscoSystem] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FiscoSystem] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FiscoSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FiscoSystem] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FiscoSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FiscoSystem] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FiscoSystem] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FiscoSystem] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FiscoSystem] SET  ENABLE_BROKER 
GO

ALTER DATABASE [FiscoSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FiscoSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FiscoSystem] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FiscoSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FiscoSystem] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FiscoSystem] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [FiscoSystem] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FiscoSystem] SET RECOVERY FULL 
GO

ALTER DATABASE [FiscoSystem] SET  MULTI_USER 
GO

ALTER DATABASE [FiscoSystem] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FiscoSystem] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FiscoSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FiscoSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FiscoSystem] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FiscoSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [FiscoSystem] SET QUERY_STORE = OFF
GO

ALTER DATABASE [FiscoSystem] SET  READ_WRITE 
GO

