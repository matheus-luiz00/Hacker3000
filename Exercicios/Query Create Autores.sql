USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Autores] Script Date: 19/07/2019 10:14:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Autores] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (100)  NOT NULL,
    [Descricao] VARCHAR (1000) NULL
);


