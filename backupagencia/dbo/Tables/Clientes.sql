CREATE TABLE [dbo].[Clientes] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (MAX) NOT NULL,
    [Email]      NVARCHAR (MAX) NOT NULL,
    [Telefone]   NVARCHAR (MAX) NOT NULL,
    [Cpf]        NVARCHAR (MAX) NOT NULL,
    [Passaporte] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

