CREATE TABLE [dbo].[DaPuntos]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Fecha] DATETIME NULL, 
    [Puntos] INT NULL, 
    [Descripcion] VARCHAR(MAX) NULL, 
    [UsuarioId] INT NOT NULL, 
    [LocalId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuario] ([Id]),
    FOREIGN KEY ([LocalId]) REFERENCES [dbo].[Local] ([Id])

	);
