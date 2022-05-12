SELECT * FROM [TABELA DE PRODUTOS] 
/*LIKE É UMA PESQUISA, PARECIDO COM O CTRL+F*/

/*selecionando todo os itens que contém a palavra Litros no nome do produto, tanto no inicio tanto no final*/
SELECT * FROM [TABELA DE PRODUTOS] WHERE [NOME DO PRODUTO] LIKE '%Litros%'

/*selecionando todos os itens que o nome começa com Litros*/
SELECT * FROM [TABELA DE PRODUTOS] WHERE [NOME DO PRODUTO] LIKE 'Litros%'

SELECT * FROM [TABELA DE PRODUTOS] WHERE [NOME DO PRODUTO] LIKE 'Linha%'

SELECT * FROM [TABELA DE PRODUTOS] WHERE [NOME DO PRODUTO] LIKE '%Litros%' AND [SABOR] = 'Laranja'

SELECT * FROM [dbo].[TABELA DE CLIENTES] WHERE [NOME] LIKE '%Mattos';