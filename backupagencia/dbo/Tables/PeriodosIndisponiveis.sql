CREATE TABLE [dbo].[PeriodosIndisponiveis] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [DataInicio] DATE NOT NULL,
    [DataFim]    DATE NOT NULL,
    [PacoteId]   INT  NOT NULL,
    CONSTRAINT [PK_PeriodosIndisponiveis] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PeriodosIndisponiveis_Pacotes_PacoteId] FOREIGN KEY ([PacoteId]) REFERENCES [dbo].[Pacotes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_PeriodosIndisponiveis_PacoteId]
    ON [dbo].[PeriodosIndisponiveis]([PacoteId] ASC);

