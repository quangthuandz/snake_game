USE [master]
GO
/****** Object:  Database [Project_PRN211]    Script Date: 8/11/2023 10:14:20 AM ******/
CREATE DATABASE [Project_PRN211]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_PRN211', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Project_PRN211.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_PRN211_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Project_PRN211_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Project_PRN211] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_PRN211].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_PRN211] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_PRN211] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_PRN211] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_PRN211] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_PRN211] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_PRN211] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_PRN211] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_PRN211] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_PRN211] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_PRN211] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_PRN211] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_PRN211] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_PRN211] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_PRN211] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_PRN211] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project_PRN211] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_PRN211] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_PRN211] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_PRN211] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_PRN211] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_PRN211] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_PRN211] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_PRN211] SET RECOVERY FULL 
GO
ALTER DATABASE [Project_PRN211] SET  MULTI_USER 
GO
ALTER DATABASE [Project_PRN211] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_PRN211] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_PRN211] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_PRN211] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_PRN211] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_PRN211] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project_PRN211', N'ON'
GO
ALTER DATABASE [Project_PRN211] SET QUERY_STORE = ON
GO
ALTER DATABASE [Project_PRN211] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Project_PRN211]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 8/11/2023 10:14:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[GameID] [int] NOT NULL,
	[Name] [nchar](45) NOT NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 8/11/2023 10:14:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemId] [int] NOT NULL,
	[ItemName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8/11/2023 10:14:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[Email] [nchar](45) NOT NULL,
	[Password] [nchar](45) NOT NULL,
	[Name] [nchar](45) NOT NULL,
	[IsAdmin] [int] NOT NULL,
	[Money] [int] NULL,
	[NumberOfAdvertisement] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGame]    Script Date: 8/11/2023 10:14:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGame](
	[UserGameID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[GameID] [int] NOT NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_UserGame] PRIMARY KEY CLUSTERED 
(
	[UserGameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserItem]    Script Date: 8/11/2023 10:14:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserItem](
	[UserItemId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quatity] [int] NULL,
 CONSTRAINT [PK_UserItem] PRIMARY KEY CLUSTERED 
(
	[UserItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Game] ([GameID], [Name]) VALUES (1, N'Normal                                       ')
INSERT [dbo].[Game] ([GameID], [Name]) VALUES (2, N'Medium                                       ')
INSERT [dbo].[Game] ([GameID], [Name]) VALUES (3, N'Special                                      ')
GO
INSERT [dbo].[Item] ([ItemId], [ItemName], [Description]) VALUES (1, N'Shield', N'Protection')
INSERT [dbo].[Item] ([ItemId], [ItemName], [Description]) VALUES (2, N'Speed', N'Move faster')
INSERT [dbo].[Item] ([ItemId], [ItemName], [Description]) VALUES (3, N'X2Live', N'Reborn')
GO
INSERT [dbo].[User] ([UserID], [Email], [Password], [Name], [IsAdmin], [Money], [NumberOfAdvertisement]) VALUES (1, N'quangthuan210103@gmail.com                   ', N'123                                          ', N'Thuan                                        ', 1, 400, NULL)
INSERT [dbo].[User] ([UserID], [Email], [Password], [Name], [IsAdmin], [Money], [NumberOfAdvertisement]) VALUES (2, N'thuanlaptrinh@gmail.com                      ', N'123                                          ', N'quang                                        ', 0, 2900, 1)
INSERT [dbo].[User] ([UserID], [Email], [Password], [Name], [IsAdmin], [Money], [NumberOfAdvertisement]) VALUES (3, N'thuandqhe170881@fpt.edu.vn                   ', N'123                                          ', N'Dinh                                         ', 0, 600, NULL)
INSERT [dbo].[User] ([UserID], [Email], [Password], [Name], [IsAdmin], [Money], [NumberOfAdvertisement]) VALUES (4, N'thuanquang                                   ', N'123                                          ', N'QT                                           ', 0, 700, NULL)
GO
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (1, 1, 2, 0)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (2, 1, 1, 0)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (3, 3, 1, 1)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (4, 3, 2, 2)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (5, 2, 2, 5)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (6, 2, 1, 56)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (7, 2, 3, 7)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (8, 1, 3, 0)
INSERT [dbo].[UserGame] ([UserGameID], [UserID], [GameID], [Score]) VALUES (9, 3, 3, 0)
GO
INSERT [dbo].[UserItem] ([UserItemId], [UserId], [ItemId], [Quatity]) VALUES (0, 2, 1, 5)
INSERT [dbo].[UserItem] ([UserItemId], [UserId], [ItemId], [Quatity]) VALUES (1, 2, 2, 0)
INSERT [dbo].[UserItem] ([UserItemId], [UserId], [ItemId], [Quatity]) VALUES (2, 2, 3, 0)
GO
ALTER TABLE [dbo].[UserGame]  WITH CHECK ADD  CONSTRAINT [FK_UserGame_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Game] ([GameID])
GO
ALTER TABLE [dbo].[UserGame] CHECK CONSTRAINT [FK_UserGame_Game]
GO
ALTER TABLE [dbo].[UserGame]  WITH CHECK ADD  CONSTRAINT [FK_UserGame_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserGame] CHECK CONSTRAINT [FK_UserGame_User]
GO
ALTER TABLE [dbo].[UserItem]  WITH CHECK ADD  CONSTRAINT [FK_Item_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserItem] CHECK CONSTRAINT [FK_Item_User]
GO
ALTER TABLE [dbo].[UserItem]  WITH CHECK ADD  CONSTRAINT [FK_UserItem_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([ItemId])
GO
ALTER TABLE [dbo].[UserItem] CHECK CONSTRAINT [FK_UserItem_Item]
GO
USE [master]
GO
ALTER DATABASE [Project_PRN211] SET  READ_WRITE 
GO
