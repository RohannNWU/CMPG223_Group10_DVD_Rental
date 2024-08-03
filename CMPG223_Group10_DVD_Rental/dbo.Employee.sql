USE [DVDRentals]
GO

/****** Object: Table [dbo].[Employee] Script Date: 2024/08/03 14:30:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Employee];


GO
CREATE TABLE [dbo].[Employee] (
    [Employee_ID]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (25) NOT NULL,
    [Surname]        NVARCHAR (25) NOT NULL,
    [Date_of_Birth]  NVARCHAR (13) NOT NULL,
    [Contact_Number] NVARCHAR (10) NOT NULL
);


