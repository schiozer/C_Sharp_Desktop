CREATE TABLE [dbo].[Produto]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Descricao] NCHAR(50) NOT NULL, 
    [PrecoDeCusto] NUMERIC(18, 2) NOT NULL, 
    [PrecoDeVenda] NUMERIC(18, 2) NOT NULL, 
    [Estoque] NUMERIC NOT NULL
)
