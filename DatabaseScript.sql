USE [master]
GO
/****** Object:  Database [CenterManager]    Script Date: 9/21/2022 12:21:04 PM ******/
CREATE DATABASE [CenterManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CenterManager', FILENAME = N'E:\CenterManager\CenterManager.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CenterManager_log', FILENAME = N'E:\CenterManager\CenterManager_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CenterManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CenterManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CenterManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CenterManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CenterManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CenterManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CenterManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [CenterManager] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CenterManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CenterManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CenterManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CenterManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CenterManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CenterManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CenterManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CenterManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CenterManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CenterManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CenterManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CenterManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CenterManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CenterManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CenterManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CenterManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CenterManager] SET RECOVERY FULL 
GO
ALTER DATABASE [CenterManager] SET  MULTI_USER 
GO
ALTER DATABASE [CenterManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CenterManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CenterManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CenterManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CenterManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CenterManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CenterManager] SET QUERY_STORE = OFF
GO
USE [CenterManager]
GO
/****** Object:  User [User]    Script Date: 9/21/2022 12:21:05 PM ******/
CREATE USER [User] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LecID] [int] NOT NULL,
	[GroupID] [int] NULL,
	[StudentID] [int] NULL,
	[Attend] [bit] NOT NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Attendance] UNIQUE NONCLUSTERED 
(
	[LecID] ASC,
	[StudentID] ASC,
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Class] [int] NULL,
	[Price_for_St] [float] NULL,
	[Price] [float] NULL,
	[Quantity] [int] NOT NULL,
	[Total] [float] NULL,
	[SubjectID] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Class_Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamDetails]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ExamID] [int] NOT NULL,
	[Mark] [float] NOT NULL,
 CONSTRAINT [PK_ExamDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[GroupID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[NumberOfQuestions] [int] NOT NULL,
	[FinalMark] [float] NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ClassID] [int] NULL,
	[FromHour] [nvarchar](max) NOT NULL,
	[ToHour] [nvarchar](max) NOT NULL,
	[Price] [float] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Saturday] [bit] NOT NULL,
	[Sunday] [bit] NOT NULL,
	[Monday] [bit] NOT NULL,
	[Tuesday] [bit] NOT NULL,
	[Wednesday] [bit] NOT NULL,
	[Thursday] [bit] NOT NULL,
	[Friday] [bit] NOT NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lectures]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lectures](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LecNumber] [int] NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Lectures] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[ID] [int] NOT NULL,
	[ProgramName] [nvarchar](max) NOT NULL,
	[BackColor] [nvarchar](7) NULL,
	[TitleColor] [nvarchar](7) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STCode] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ST_Phone] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Parent_Number] [nvarchar](max) NOT NULL,
	[Is_for_Contact] [bit] NOT NULL,
	[IsMale] [bit] NOT NULL,
	[ClassID] [int] NULL,
	[School] [nvarchar](max) NOT NULL,
	[Study_Level] [tinyint] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Student] UNIQUE NONCLUSTERED 
(
	[STCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentBooks]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentBooks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[STID] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[Discount] [real] NOT NULL,
	[BeforeDiscount] [real] NOT NULL,
	[AfterDiscount] [real] NOT NULL,
	[Paid] [real] NOT NULL,
	[Remainder] [real] NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_StudentBooks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_StudentBooks] UNIQUE NONCLUSTERED 
(
	[BookID] ASC,
	[STID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentExam]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentExam](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STID] [int] NOT NULL,
	[ExamID] [int] NOT NULL,
	[QID] [int] NULL,
	[Mark] [float] NOT NULL,
 CONSTRAINT [PK_StudentExam] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_StudentExam] UNIQUE NONCLUSTERED 
(
	[STID] ASC,
	[ExamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsGroups]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsGroups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
 CONSTRAINT [PK_StudentsGroups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[CardNumber] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[PermissionsID] [int] NOT NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersPermissions]    Script Date: 9/21/2022 12:21:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersPermissions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MainPage] [bit] NOT NULL,
	[Students] [bit] NOT NULL,
	[AddStudent] [bit] NOT NULL,
	[Subjects] [bit] NOT NULL,
	[EditClasses] [bit] NOT NULL,
	[ShowStudents] [bit] NOT NULL,
	[Groups] [bit] NOT NULL,
	[AddGroup] [bit] NOT NULL,
	[StudentGroups] [bit] NOT NULL,
	[ViewAllGroups] [bit] NOT NULL,
	[Attendance] [bit] NOT NULL,
	[TakeAttendance] [bit] NOT NULL,
	[ViewAttendance] [bit] NOT NULL,
	[Books] [bit] NOT NULL,
	[AddBook] [bit] NOT NULL,
	[ViewBooks] [bit] NOT NULL,
	[StudentBooks] [bit] NOT NULL,
	[Exams] [bit] NOT NULL,
	[AddExam] [bit] NOT NULL,
	[ViewExams] [bit] NOT NULL,
	[CorrentExams] [bit] NOT NULL,
	[Users] [bit] NOT NULL,
	[AddUser] [bit] NOT NULL,
	[EditUsers] [bit] NOT NULL,
 CONSTRAINT [PK_UsersPermissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudentsGroups]    Script Date: 9/21/2022 12:21:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_StudentsGroups] ON [dbo].[StudentsGroups]
(
	[GroupID] ASC,
	[STID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Groups]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Lectures] FOREIGN KEY([LecID])
REFERENCES [dbo].[Lectures] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Lectures]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Classes] FOREIGN KEY([Class])
REFERENCES [dbo].[Classes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Classes]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Subjects]
GO
ALTER TABLE [dbo].[ExamDetails]  WITH CHECK ADD  CONSTRAINT [FK_ExamDetails_Exams] FOREIGN KEY([ExamID])
REFERENCES [dbo].[Exams] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExamDetails] CHECK CONSTRAINT [FK_ExamDetails_Exams]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Groups]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Classes]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Subjects]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Classes]
GO
ALTER TABLE [dbo].[StudentBooks]  WITH CHECK ADD  CONSTRAINT [FK_StudentBooks_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([ID])
GO
ALTER TABLE [dbo].[StudentBooks] CHECK CONSTRAINT [FK_StudentBooks_Books]
GO
ALTER TABLE [dbo].[StudentBooks]  WITH CHECK ADD  CONSTRAINT [FK_StudentBooks_Student] FOREIGN KEY([STID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentBooks] CHECK CONSTRAINT [FK_StudentBooks_Student]
GO
ALTER TABLE [dbo].[StudentExam]  WITH CHECK ADD  CONSTRAINT [FK_StudentExam_ExamDetails] FOREIGN KEY([QID])
REFERENCES [dbo].[ExamDetails] ([ID])
GO
ALTER TABLE [dbo].[StudentExam] CHECK CONSTRAINT [FK_StudentExam_ExamDetails]
GO
ALTER TABLE [dbo].[StudentExam]  WITH CHECK ADD  CONSTRAINT [FK_StudentExam_Exams] FOREIGN KEY([ExamID])
REFERENCES [dbo].[Exams] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentExam] CHECK CONSTRAINT [FK_StudentExam_Exams]
GO
ALTER TABLE [dbo].[StudentExam]  WITH CHECK ADD  CONSTRAINT [FK_StudentExam_Student] FOREIGN KEY([STID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentExam] CHECK CONSTRAINT [FK_StudentExam_Student]
GO
ALTER TABLE [dbo].[StudentsGroups]  WITH CHECK ADD  CONSTRAINT [FK_StudentsGroups_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])
GO
ALTER TABLE [dbo].[StudentsGroups] CHECK CONSTRAINT [FK_StudentsGroups_Groups]
GO
ALTER TABLE [dbo].[StudentsGroups]  WITH CHECK ADD  CONSTRAINT [FK_StudentsGroups_Student] FOREIGN KEY([STID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentsGroups] CHECK CONSTRAINT [FK_StudentsGroups_Student]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersPermissions] FOREIGN KEY([PermissionsID])
REFERENCES [dbo].[UsersPermissions] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersPermissions]
GO
USE [master]
GO
ALTER DATABASE [CenterManager] SET  READ_WRITE 
GO
