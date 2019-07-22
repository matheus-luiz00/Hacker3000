select
	cr.Modelo,
	count(lo.Cliente) 'Alugueis'
from Locacao lo
		inner join Carros cr on lo.Carro = cr.Id

where lo.Operacao=2 and YEAR(lo.DateInc) = 2015

group by cr.Modelo
order by count(lo.Cliente) desc