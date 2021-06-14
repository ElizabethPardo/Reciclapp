CREATE TABLE [dbo].[Local] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [CuilCuit]  VARCHAR (MAX) NULL,
    [Nombre]    VARCHAR (50)  NULL,
    [Telefono]  VARCHAR (50)  NULL,
    [Direccion] VARCHAR (50)  NULL,
    [Horarios]  VARCHAR (50)  NULL,
    [Rubro]     VARCHAR (50)  NULL,
    [Estado]    BIT           NULL,
    [Foto]      VARCHAR (MAX) NULL
	 PRIMARY KEY CLUSTERED ([Id] ASC)
);

