-- Trazer somente as marcas que Felipe cadastrou

select
		Nome

from Marcas
where UsuInc = 1;

-- Trazer somente as marcas que Giomar cadastrou

select
		Nome

from Marcas
where UsuInc = 2;

-- Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor

select
		Count(Nome) as 'Cadastros'

from Marcas
where UsuInc = 1
order by Count(Nome) desc;

-- Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior

select
		Count(Nome) as 'Cadastros'

from Marcas
where UsuInc = 2
order by Count(Nome) asc;

-- Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram

select
		Usuarios.Usuario,
		Count(Nome) as 'Cadastros'

From Marcas inner join Usuarios on Marcas.UsuInc = Usuarios.Id
group by Usuarios.Usuario;

-- Trazer somente os carros que Felipe cadastrou

select
		Modelo

from Carros
where UsuInc = 1;

-- Trazer somente os carros que Giomar cadastrou

select
		Modelo

from Carros
where UsuInc = 2;

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor

select
		COUNT(Modelo)

from Carros
where UsuInc = 1
order by COUNT(Modelo) desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior

select
		COUNT(Modelo)

from Carros
where UsuInc = 2
order by COUNT(Modelo) asc;

-- Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

select
		Usuarios.Usuario,
		Count(Modelo) as 'Cadastros'

From Carros inner join Usuarios on Carros.UsuInc = Usuarios.Id
group by Usuarios.Usuario;

--Trazer somente os carros das marcas que Felipe cadastrou

select
		cr.Modelo as 'Carros'

from Carros cr inner join Marcas mm on cr.Marca	= mm.Id
where mm.UsuInc = 1;

-- Trazer somente os carros das marcas que Giomar cadastrou

select
		cr.Modelo as 'Carros'

from Carros cr inner join Marcas mm on cr.Marca	= mm.Id
where mm.UsuInc = 2;

-- Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

select
		COUNT(cr.Modelo) as 'Cadastros'

from Carros cr inner join Marcas mm on cr.Marca	= mm.Id
where mm.UsuInc = 1
order by COUNT(cr.Modelo) desc;

-- Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior

select
		COUNT(cr.Modelo) as 'Cadastros'

from Carros cr inner join Marcas mm on cr.Marca	= mm.Id
where mm.UsuInc = 2
order by COUNT(cr.Modelo) asc;

-- Trazer o valor total de vendas 2019 isolado

select
		year(DatInc) 'Ano',
		SUM(Quantidade * Valor) 'Valor Total'
from Vendas
where year(DatInc) = 2019
group by year(DatInc);


-- Trazer a quantidade total de vendas 2019 isolado

select
		SUM(Quantidade)
from Vendas
where year(DatInc) = 2019;


-- Trazer o valor total de vendas em cada ano e ordernar do maior para o menor

select
		year(DatInc) 'Ano',
		SUM(Quantidade * Valor) 'Valor Total'
from Vendas
group by year(DatInc)
order by year(DatInc) desc;

-- Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor

select
		SUM(Quantidade)
from Vendas
group by year(DatInc)
order by SUM(Quantidade) desc;


-- Trazer o mês de cada ano que retornou a maior quantidade de vendas
-- 		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"

select
		YEAR(DatInc) 'Ano',
		MONTH(DatInc) 'Mês',
		SUM(Quantidade) 'Quantidade'
from Vendas
group by MONTH(DatInc), YEAR(DatInc)
order by SUM(Quantidade) desc;

		
--Trazer o mês de cada ano que retornou o maior valor de vendas
		-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"


select
		YEAR(DatInc) 'Ano',
		MONTH(DatInc) 'Mês',
		SUM(Quantidade * Valor) 'Valor'
from Vendas
group by MONTH(DatInc), YEAR(DatInc)
order by SUM(Quantidade) desc;


-- Trazer o valor total de vendas que Felipe realizou

select 
		Sum(Quantidade * Valor)

From Vendas 
where UsuInc = 1;

-- Trazer o valor total de vendas que Giomar realizou

select 
		Sum(Quantidade * Valor)

From Vendas 
where UsuInc = 2;

--Trazer a quantidade total de vendas que Felipe realizou

select 
		Sum(Quantidade)

From Vendas 
where UsuInc = 1;

-- Trazer a quantidade de vendas que Giomar realizou

select 
		Sum(Quantidade)

From Vendas 
where UsuInc = 2;

-- Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select 
		Usuarios.Usuario,
		Sum(Vendas.Quantidade) 'Quantidade'

From Vendas inner join Usuarios on Vendas.UsuInc = Usuarios.Id
group by Usuarios.Usuario
order by Sum(Quantidade) desc;

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select 
		Usuarios.Usuario,
		Sum(Vendas.Quantidade * Vendas.Valor)

From Vendas inner join Usuarios on Vendas.UsuInc = Usuarios.Id
group by Usuarios.Usuario
order by Sum(Valor) desc;

-- Trazer  a marca mais vendida de todos os anos
		-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"

select
		mr.Nome
from Vendas	vd  inner join Carros cr on vd.Carro = cr.Id
				inner join Marcas mr on cr.Marca = mr.Id
group by mr.Nome
order by SUM(vd.Quantidade) desc;

-- Trazer o valor total da marca mais vendida de todos os anos

select TOP 1 percent 
		mr.Nome as 'Marca',
		SUM(vd.Quantidade * vd.Valor) 'Total'
from Vendas	vd  inner join Carros cr on vd.Carro = cr.Id
				inner join Marcas mr on cr.Marca = mr.Id
group by mr.Nome
order by SUM(vd.Quantidade) desc;

-- Trazer a quantidade do carro mais vendido de todos os anos

select TOP 1 percent 
		cr.Modelo as 'Carro',
		SUM(vd.Quantidade) 'Total'
from Vendas	vd  inner join Carros cr on vd.Carro = cr.Id
				inner join Marcas mr on cr.Marca = mr.Id
group by cr.Modelo
order by SUM(vd.Quantidade) desc;

-- Trazer o valor do carro mais vendido de todos os anos

select TOP 1 percent 
		cr.Modelo as 'Carro',
		SUM(vd.Quantidade * vd.Valor) 'Valor'
from Vendas	vd  inner join Carros cr on vd.Carro = cr.Id
				inner join Marcas mr on cr.Marca = mr.Id
group by cr.Modelo
order by SUM(vd.Quantidade) desc;
