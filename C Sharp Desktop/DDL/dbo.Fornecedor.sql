CREATE TABLE [dbo].[Fornecedor] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [CNPJ] NCHAR (14) NOT NULL,
    [Nome] NCHAR (50) NOT NULL,
    [IdCidade] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Fornecedor_To_Cidade] FOREIGN KEY ([IdCidade]) REFERENCES [Cidade]([IdCidade])
);

