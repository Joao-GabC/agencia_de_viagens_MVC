CREATE TABLE [dbo].[Funcionarios] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Nome]         NVARCHAR (MAX) NOT NULL,
    [Departamento] NVARCHAR (MAX) NOT NULL,
    [Email]        NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Funcionarios] PRIMARY KEY CLUSTERED ([Id] ASC)
);

