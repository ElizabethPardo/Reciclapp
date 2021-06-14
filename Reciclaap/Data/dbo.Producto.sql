CREATE TABLE [dbo].[Producto] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Codigo]      INT           NULL,
    [Descripcion] VARCHAR (50)  NULL,
    [Precio]      DECIMAL (18)  NULL,
    [Descuento]   DECIMAL (18)  NULL,
    [Stock]       INT           NULL,
    [Puntos]      INT           NULL,
    [Foto]        VARCHAR (MAX) NULL,
    [Estado]      BIT           NULL,
    [LocalId]     INT           NOT NULL
	PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([LocalId]) REFERENCES [dbo].[Local] ([Id])
);

