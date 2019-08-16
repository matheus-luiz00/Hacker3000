USE [SistemaEscolar]
GO

/****** Object: Table [dbo].[Turmas] Script Date: 19/07/2019 17:00:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Turmas] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (50) NOT NULL,
    [Professor] INT          NOT NULL,
    [Inicio]    DATE         NOT NULL,
    [Fim]       DATE         NOT NULL
);


