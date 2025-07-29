CREATE TABLE [dbo].[Reservas] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Titulo]       NVARCHAR (MAX)  NOT NULL,
    [DataInicio]   DATETIME2 (7)   NOT NULL,
    [DataFim]      DATETIME2 (7)   NOT NULL,
    [PrecoTotal]   DECIMAL (18, 2) NOT NULL,
    [ReservanteId] INT             NOT NULL,
    CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reservas_Clientes_ReservanteId] FOREIGN KEY ([ReservanteId]) REFERENCES [dbo].[Clientes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Reservas_ReservanteId]
    ON [dbo].[Reservas]([ReservanteId] ASC);

