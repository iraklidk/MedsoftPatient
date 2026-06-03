/* =====================================================================
   MedsoftDB - Full Build Script
   Generated from sm.ipynb for execution in SSMS
   ===================================================================== */

/* ---------------------------------------------------------------------
   [MedsoftDB] - Create database
   --------------------------------------------------------------------- */
USE [master]
GO

/****** Object:  Database [MedsoftDB]    Script Date: 03.06.2026 12:48:15 ******/
CREATE DATABASE [MedsoftDB]
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'MedsoftDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\MedsoftDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON
( NAME = N'MedsoftDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\MedsoftDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MedsoftDB] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedsoftDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MedsoftDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MedsoftDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MedsoftDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MedsoftDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MedsoftDB] SET ARITHABORT OFF
GO
ALTER DATABASE [MedsoftDB] SET AUTO_CLOSE ON
GO
ALTER DATABASE [MedsoftDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MedsoftDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MedsoftDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MedsoftDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MedsoftDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MedsoftDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MedsoftDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MedsoftDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MedsoftDB] SET  ENABLE_BROKER
GO
ALTER DATABASE [MedsoftDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MedsoftDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MedsoftDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MedsoftDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MedsoftDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MedsoftDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MedsoftDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MedsoftDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MedsoftDB] SET  MULTI_USER
GO
ALTER DATABASE [MedsoftDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MedsoftDB] SET DB_CHAINING OFF
GO
ALTER DATABASE [MedsoftDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [MedsoftDB] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [MedsoftDB] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [MedsoftDB] SET OPTIMIZED_LOCKING = OFF
GO
ALTER DATABASE [MedsoftDB] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO
ALTER DATABASE [MedsoftDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MedsoftDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

/* ---------------------------------------------------------------------
   Switch to MedsoftDB for object creation
   --------------------------------------------------------------------- */
USE [MedsoftDB]
GO

/* ---------------------------------------------------------------------
   [dbo].[IDList] - User Defined Table Type
   --------------------------------------------------------------------- */
/****** Object:  UserDefinedTableType [dbo].[IDList]    Script Date: 03.06.2026 12:48:16 ******/
CREATE TYPE [dbo].[IDList] AS TABLE(
	[ID] [int] NULL
)
GO

/* ---------------------------------------------------------------------
   [dbo].[ISOweek] - Function
   --------------------------------------------------------------------- */
/****** Object:  UserDefinedFunction [dbo].[ISOweek]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ISOweek] (@DATE DATETIME)
RETURNS INT
WITH EXECUTE AS CALLER
AS
BEGIN
    DECLARE @ISOweek INT;

    SET @ISOweek = DATEPART(wk, @DATE) + 1 -
        DATEPART(wk, CAST(DATEPART(yy, @DATE) AS CHAR(4)) + '0104');

    IF (@ISOweek = 0)
        SET @ISOweek = dbo.ISOweek(CAST(DATEPART(yy, @DATE) - 1 AS CHAR(4))
           + '12' + CAST(24 + DATEPART(DAY, @DATE) AS CHAR(2))) + 1;

    IF ((DATEPART(mm, @DATE) = 12)
        AND ((DATEPART(dd, @DATE) - DATEPART(dw, @DATE)) >= 28))
    SET @ISOweek = 1;

    RETURN (@ISOweek);
END;
GO

/* ---------------------------------------------------------------------
   [dbo].[Gender] - Table
   --------------------------------------------------------------------- */
/****** Object:  Table [dbo].[Gender]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/* ---------------------------------------------------------------------
   [dbo].[Insurance] - Table
   --------------------------------------------------------------------- */
/****** Object:  Table [dbo].[Insurance]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insurance](
	[InsuranceID] [int] NOT NULL,
	[InsuranceName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Insurance] PRIMARY KEY CLUSTERED
(
	[InsuranceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/* ---------------------------------------------------------------------
   [dbo].[Patient] - Table
   --------------------------------------------------------------------- */
/****** Object:  Table [dbo].[Patient]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Dob] [date] NULL,
	[GenderID] [int] NULL,
	[Phone] [nvarchar](20) NULL,
	[Address] [nvarchar](50) NULL,
	[PersonalNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[InsuranceID] [int] NULL,
PRIMARY KEY CLUSTERED
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/* ---------------------------------------------------------------------
   [DF_Patient_Status] - Default Constraint
   --------------------------------------------------------------------- */
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_Status]  DEFAULT ((1)) FOR [Status]
GO

/* ---------------------------------------------------------------------
   [dbo].[GetGenderList] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[GetGenderList]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetGenderList]
as
begin
	set nocount on
	select * from gender
end
GO

/* ---------------------------------------------------------------------
   [dbo].[GetInsuranceList] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[GetInsuranceList]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetInsuranceList]
as
begin
	set nocount on
	select * from Insurance
end
GO

/* ---------------------------------------------------------------------
   [dbo].[PatientDelete] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[PatientDelete]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientDelete]
    @IDlist dbo.IDList READONLY
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Patient
    SET status = 0
    WHERE ID IN (SELECT ID FROM @IDlist);
END
GO

/* ---------------------------------------------------------------------
   [dbo].[PatientGetById] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[PatientGetById]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PatientGetById]
	@PatientId int
as
begin
	set nocount on

	select * from patient
	where patient.ID = @PatientId
end
GO

/* ---------------------------------------------------------------------
   [dbo].[PatientGetByIdPrint] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[PatientGetByIdPrint]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PatientGetByIdPrint]
    @PatientId int
as
begin
    set nocount on;

    -- First result set
    select
        p.FullName,
        p.Dob,
        p.Phone,
        p.Address,
        p.PersonalNumber,
        p.Email,
        datediff(year, Dob, GETDATE()) as Age,
        g.GenderName
    from Patient p
    join gender g on p.GenderID = g.GenderID
    where ID = @PatientId

    -- Second result set
    select *
    from Patient
end
GO

/* ---------------------------------------------------------------------
   [dbo].[PatientListGet] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[PatientListGet]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientListGet]
    @PatientID INT = 0,
    @Gender INT = 0,
    @ActiveStatus INT = 1,
    @FullName NVARCHAR(200) = NULL,
    @PersonalNumber NVARCHAR(50) = NULL,
    @Address NVARCHAR(200) = NULL
AS
BEGIN
    SELECT * FROM Patient p
    JOIN Gender g ON g.GenderID = p.GenderID
    left JOIN Insurance i on i.InsuranceId = p.InsuranceID
    WHERE
        (@PatientID = 0 OR p.ID = @PatientID)
        AND (@Gender = 0 OR p.GenderID = @Gender)
        AND (@ActiveStatus = 2 OR p.Status = @ActiveStatus)
        AND (@FullName IS NULL OR p.FullName LIKE '%' + @FullName + '%')
        AND (@PersonalNumber IS NULL OR p.PersonalNumber LIKE '%' + @PersonalNumber + '%')
        AND (@Address IS NULL OR p.Address LIKE '%' + @Address + '%')
END
GO

/* ---------------------------------------------------------------------
   [dbo].[UpdatePatient] - Stored Procedure
   --------------------------------------------------------------------- */
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 03.06.2026 12:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdatePatient]
    @ID INT = NULL,
    @FullName NVARCHAR(50),
    @Dob DATE,
    @GenderID INT,
    @InsuranceID INT,
    @Phone NVARCHAR(20),
    @Address NVARCHAR(50),
    @PersonalNumber NVARCHAR(50),
    @Email NVARCHAR(50),
    @StatusCode INT OUTPUT
as
begin
	set nocount on

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Patient WHERE PersonalNumber = @PersonalNumber
              AND (@ID IS NULL OR ID <> @ID))
        BEGIN
            SET @StatusCode = 0;
            RETURN;
        END

        IF @ID IS NULL OR @ID = 0
        BEGIN
            INSERT INTO Patient
            (FullName, Dob, InsuranceID, GenderID, Phone, Address, PersonalNumber, Email)
            VALUES
            (@FullName, @Dob, @InsuranceID, @GenderID, @Phone, @Address, @PersonalNumber, @Email);

            SET @StatusCode = 1;
        END
        ELSE
        BEGIN
            UPDATE Patient
            SET
                FullName = @FullName,
                Dob = @Dob,
                GenderID = @GenderID,
                Phone = @Phone,
                InsuranceID = @InsuranceID,
                Address = @Address,
                PersonalNumber = @PersonalNumber,
                Email = @Email
            WHERE ID = @ID;

            SET @StatusCode = 2;
        END

    END TRY
    BEGIN CATCH
        SET @StatusCode = -2;
    END CATCH
END
GO

/* ---------------------------------------------------------------------
   Final - Set database to READ_WRITE
   --------------------------------------------------------------------- */
USE [master]
GO

ALTER DATABASE [MedsoftDB] SET  READ_WRITE
GO
