USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Livros] Script Date: 19/07/2019 10:17:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Livros] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Registro]    INT            NOT NULL,
    [Titulo]      VARCHAR (1200) NOT NULL,
    [Isbn]        VARCHAR (15)   NOT NULL,
    [Genero]      INT            NOT NULL,
    [Editora]     INT            NOT NULL,
    [Sinopse]     NVARCHAR (MAX) NULL,
    [Observacoes] VARCHAR (1000) NULL,
    [UsuInc]      INT            NOT NULL,
    [UsuAlt]      INT            NOT NULL,
    [DatInc]      DATETIME       NOT NULL,
    [DatAlt]      DATETIME       NOT NULL
);


