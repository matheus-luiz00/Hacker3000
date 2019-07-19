select 
	Alunos.Nome,
	(Sum(AlunoTurma.Nota)/4) as 'Nota',
	(select IIF((Sum(CONVERT(Money,AlunoTurma.Presenca))/4) >=0.75, 'Aprovado', 'Reprovado') as 'Frequência' from AlunoTurma) as 'Frequência'

from Alunos inner join AlunoTurma on Alunos.Id = AlunoTurma.Aluno
where Alunos.Id = AlunoTurma.Aluno
group by Alunos.Id, Alunos.Nome