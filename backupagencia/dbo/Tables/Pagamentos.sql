CREATE TABLE [dbo].[Pagamentos] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Preco]        DECIMAL (18, 2) NOT NULL,
    [DescCompra]   NVARCHAR (MAX)  NOT NULL,
    [DataDeCompra] NVARCHAR (MAX)  NOT NULL,
    [PaganteId]    INT             NOT NULL,
    CONSTRAINT [PK_Pagamentos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pagamentos_Clientes_PaganteId] FOREIGN KEY ([PaganteId]) REFERENCES [dbo].[Clientes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Pagamentos_PaganteId]
    ON [dbo].[Pagamentos]([PaganteId] ASC);

