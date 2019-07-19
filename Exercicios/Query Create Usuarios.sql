USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Usuarios] Script Date: 19/07/2019 10:17:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Login]  VARCHAR (50)  NOT NULL,
    [Senha]  VARCHAR (50)  NOT NULL,
    [Email]  VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL
);


