USE [GD1C2015]
GO

/****** ELIMINO LAS TABLAS SI YA EXISTEN ******/

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Cliente]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Cliente]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Domicilio]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Domicilio]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Documento]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Documento]



/****** CREO LA TABLA DOMICILIO Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/

GO
CREATE TABLE [LOS_METATECLA].[Domicilio](
	[Id_Domicilio] [int] IDENTITY(1,1) NOT NULL,
	[Dom_Calle] [varchar](255) NULL,
	[Dom_Nro] [numeric](18, 0) NULL,
	[Dom_Piso] [numeric](18, 0) NULL,
	[Dom_Depto] [varchar](10) NULL)
	
GO
ALTER TABLE [LOS_METATECLA].[Domicilio] ADD CONSTRAINT PK_ID_DOMICILIO
	PRIMARY KEY(Id_Domicilio)
	


/**** MIGRO ****/
GO

INSERT INTO LOS_METATECLA.Domicilio (Dom_Calle, Dom_Nro, Dom_Depto, Dom_Piso) 
SELECT Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Depto, Cli_Dom_Piso
FROM gd_esquema.Maestra


/****** CREO LA TABLA DOCUMENTO Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/

GO

CREATE TABLE [LOS_METATECLA].[Documento](
	[Doc_Tipo_Cod] [numeric](18, 0) NOT NULL,
	[Doc_Tipo_Desc] [varchar](255) NULL)
 
GO
ALTER TABLE [LOS_METATECLA].[Documento] ADD CONSTRAINT PK_ID_DOCUMENTO
	PRIMARY KEY(Doc_Tipo_Cod)

/**** MIGRO ****/
GO
INSERT INTO LOS_METATECLA.Documento (Doc_Tipo_Cod, Doc_Tipo_Desc)
SELECT DISTINCT Cli_Tipo_Doc_Cod
FROM gd_esquema.Maestra 
GROUP BY Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc


/****** CREO LA TABLA CLIENTE Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******/

GO
CREATE TABLE [LOS_METATECLA].[Cliente](
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NOT NULL,
	[Id_Domicilio] [int] NOT NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Domicilio] FOREIGN KEY([Id_Domicilio])
REFERENCES [LOS_METATECLA].[DOMICILIO](Id_Domicilio)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Documento] FOREIGN KEY([Cli_Tipo_Doc_Cod])
REFERENCES [LOS_METATECLA].[DOCUMENTO](Doc_Tipo_Cod)

/**** MIGRO  ****/
GO
INSERT INTO LOS_METATECLA.Cliente (Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod)
SELECT Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod
FROM gd_esquema.Maestra


