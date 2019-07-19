select
		TipoDog,
		Sum(TotVendas) as 'Vendas',
		Month(DataVenda) as 'Mes'

from CachorroQuente
group by TipoDog, Month(DataVenda)
order by Vendas desc