CREATE TABLE [dbo].[NotaDeEntrada] (
    [Id]            INT             NOT NULL,
    [IdFornecedor]  INT             NOT NULL,
    [Numero]        NCHAR (20)      NOT NULL,
    [DataEmissao]   DATE            NOT NULL,
    [DataEntrada]   DATE            NOT NULL,
    CONSTRAINT [PK_NotaDeEntrada_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_NotaDeEntrada_ToFornecedor] FOREIGN KEY ([IdFornecedor]) REFERENCES [dbo].[Fornecedor] ([Id]),
    CONSTRAINT [FK_NotaDeEntrada_ToProduto] FOREIGN KEY ([IdProduto]) REFERENCES [dbo].[Produto] ([Id])
);

