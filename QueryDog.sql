select TipoDog, MONTH(DataVenda), TotVendas
		
from CachorroQuente
group by TipoDog, MONTH(DataVenda), TotVendas
order by TotVendas desc;