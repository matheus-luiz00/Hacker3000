USE [SistemaEscolar]
GO

/****** Object: Table [dbo].[AlunoTurma] Script Date: 19/07/2019 17:00:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AlunoTurma] (
    [Aluno]    INT  NOT NULL,
    [Turma]    INT  NOT NULL,
    [Presenca] BIT  NOT NULL,
    [Nota]     INT  NOT NULL,
    [Dia]      DATE NULL
);


