USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Generos] Script Date: 19/07/2019 10:17:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Generos] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Tipo]      VARCHAR (200)  NOT NULL,
    [Descricao] VARCHAR (1000) NOT NULL
);


