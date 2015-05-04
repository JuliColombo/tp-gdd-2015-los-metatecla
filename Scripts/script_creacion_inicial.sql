USE [GD1C2015]
GO


/****** CREO LA TABLA DOMICILIO Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [LOS_METATECLA].[Domicilio](
	[Id_Domicilio] [int] IDENTITY(1,1) NOT NULL,
	[Dom_Calle] [varchar](255) NULL,
	[Dom_Nro] [numeric](18, 0) NULL,
	[Dom_Piso] [numeric](18, 0) NULL,
	[Dom_Depto] [varchar](10) NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[Id_Domicilio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

/**** MIGRO ****/
INSERT INTO LOS_METATECLA.Domicilio (Dom_Calle, Dom_Nro, Dom_Depto, Dom_Piso) 
SELECT Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Depto, Cli_Dom_Piso
FROM gd_esquema.Maestra


/****** CREO LA TABLA DOCUMENTO Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [LOS_METATECLA].[Documento](
	[Doc_Tipo_Cod] [numeric](18, 0) NOT NULL,
	[Doc_Tipo_Desc] [varchar](255) NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[Doc_Tipo_Cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
SET ANSI_PADDING OFF
GO


/**** MIGRO ****/
INSERT INTO LOS_METATECLA.Documento (Doc_Tipo_Cod, Doc_Tipo_Desc)
SELECT DISTINCT Cli_Tipo_Doc_Cod
FROM gd_esquema.Maestra 
GROUP BY Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc


/****** CREO LA TABLA CLIENTE Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [LOS_METATECLA].[Cliente](
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NOT NULL,
	[Id_Domicilio] [int] NOT NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [LOS_METATECLA].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Domicilio] FOREIGN KEY([Id_Domicilio])
REFERENCES [LOS_METATECLA].[Domicilio] ([Id_Domicilio])
GO

ALTER TABLE [LOS_METATECLA].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Documento] FOREIGN KEY([Cli_Tipo_Doc_Cod])
REFERENCES [LOS_METATECLA].[Documento] ([Doc_Tipo_Cod])
GO


GO
SET ANSI_PADDING OFF
GO

/**** MIGRO ****/
INSERT INTO LOS_METATECLA.Cliente (Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod)
SELECT Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod
FROM gd_esquema.Maestra


