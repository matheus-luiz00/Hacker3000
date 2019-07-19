USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Editoras] Script Date: 19/07/2019 10:16:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Editoras] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (200)  NOT NULL,
    [Descricao] VARCHAR (1000) NULL
);


