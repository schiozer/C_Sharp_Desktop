CREATE TABLE [dbo].[ProdutoNotaDeEntrada]
(
	[Id] INT NOT NULL CONSTRAINT [PK_Produto_Id] PRIMARY KEY CLUSTERED, 
    [IdNotaDeEntrada] INT NOT NULL, 
    [IdProduto] INT NOT NULL, 
    [PrecoCustoCompra] DECIMAL(18, 2) NOT NULL, 
    [Qtde] NUMERIC NOT NULL, 
    CONSTRAINT [FK_ProdutoNotaDeEntrada_To_Produto] FOREIGN KEY ([IdProduto]) REFERENCES [Produto]([Id]), 
    CONSTRAINT [FK_ProdutoNotaDeEntrada_ToNotaDeEntrada] FOREIGN KEY ([IdNotaDeEntrada]) REFERENCES [NotaDeEntrada]([Id])
)
