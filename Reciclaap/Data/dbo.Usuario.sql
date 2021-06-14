﻿CREATE TABLE [dbo].[Usuario] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]    VARCHAR (50)  NULL,
    [Apellido]  VARCHAR (50)  NULL,
    [Telefono]  VARCHAR (50)  NULL,
    [Direccion] VARCHAR (50)  NULL,
    [Email]     VARCHAR (50)  NULL,
    [Clave]     VARCHAR (MAX) NULL,
    [Rol]       INT           NULL,
    [Foto]      VARCHAR (MAX) NULL,
    [Estado]    BIT           NULL,
    [Puntos]    INT           NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
);

