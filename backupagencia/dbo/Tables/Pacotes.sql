CREATE TABLE [dbo].[Pacotes] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [PrecoPorNoite] DECIMAL (18, 2) NOT NULL,
    [Titulo]        NVARCHAR (MAX)  NOT NULL,
    [Descricao]     NVARCHAR (MAX)  NOT NULL,
    [TextoDaPagina] NVARCHAR (MAX)  NOT NULL,
    [ImagemUrl]     NVARCHAR (MAX)  NOT NULL,
    [NumDeVendas]   INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Pacotes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

