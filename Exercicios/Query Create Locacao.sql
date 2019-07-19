USE [SistemaBibliotecaDB]
GO

/****** Object: Table [dbo].[Locacao] Script Date: 19/07/2019 10:17:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Locacao] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [Livro]     INT      NOT NULL,
    [Usuario]   INT      NOT NULL,
    [Tipo]      INT      NOT NULL,
    [Devolucao] DATETIME NOT NULL,
    [Ativo]     BIT      NOT NULL,
    [UsuInc]    INT      NOT NULL,
    [UsuAlt]    INT      NOT NULL,
    [DataInc]   DATETIME NOT NULL,
    [DataAlt]   DATETIME NOT NULL
);


