select 
		MONTH(lo.DateInc) 'Mês',
		Count(lo.Id) 'Locacoes'

from Locacao lo
		inner join Carros cr on lo.Carro = cr.Id

where lo.Operacao = 2 AND YEAR(lo.DateInc) = 2015
group by MONTH(lo.DateInc)
order by Locacoes desc