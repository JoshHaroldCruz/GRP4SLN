USE [Test]
GO

/****** Object: Table [dbo].[Products] Script Date: 4/24/2024 2:32:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE if exists [dbo].[Products];


GO
CREATE TABLE [dbo].[Products] (
    [Id]    INT  identity(1,1)   NOT NULL ,
    [Name]  VARCHAR (MAX) NULL,
    [Price] DECIMAL (18)  NULL
);


