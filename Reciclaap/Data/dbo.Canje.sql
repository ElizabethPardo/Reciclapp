CREATE TABLE [dbo].[Canje]
(
	[Id] INT  IDENTITY (1, 1) NOT NULL, 
    [Fecha] DATETIME NULL, 
    [Descripcion] VARCHAR(MAX) NULL, 
    [Cant] INT NULL, 
    [UsuarioId] INT NOT NULL, 
    [ProductoId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuario] ([Id]),
	FOREIGN KEY ([ProductoId]) REFERENCES [dbo].[Producto] ([Id])
);
