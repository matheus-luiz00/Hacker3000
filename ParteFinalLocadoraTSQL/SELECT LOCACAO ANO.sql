select 
		YEAR(lo.DateInc) 'Ano',
		Count(lo.Id) 'Locacoes'

from Locacao lo
		inner join Carros cr on lo.Carro = cr.Id

where lo.Operacao = 2
group by YEAR(lo.DateInc)
order by Locacoes desc