USE [GD1C2015]
GO

/************************************************************************************************************/
/*********************************** ELIMINO LAS TABLAS SI YA EXISTEN ***************************************/
/************************************************************************************************************/

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Tarjeta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Tarjeta]

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

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Cuenta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Cuenta]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[PAIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[PAIS]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Deposito]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Deposito]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Emisor]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Emisor]

/************************************************************************************************************/
/*********************** CREO LAS TABLAS Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******************************/
/************************************************************************************************************/

/****** <<DOMICILIO>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Domicilio](
	[Dom_Calle] [varchar](255) NULL,
	[Dom_Nro] [numeric](18, 0) NULL,
	[Dom_Piso] [numeric](18, 0) NULL,
	[Dom_Depto] [varchar](10) NULL,
	[Id_Domicilio] [int] IDENTITY(1,1) NOT NULL)
	
GO
ALTER TABLE [LOS_METATECLA].[Domicilio] ADD CONSTRAINT PK_ID_DOMICILIO
	PRIMARY KEY(Id_Domicilio)
	
/***/
GO

INSERT INTO [LOS_METATECLA].[Domicilio] (Dom_Calle, Dom_Nro, Dom_Piso, Dom_Depto) 
SELECT DISTINCT Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto
FROM gd_esquema.Maestra



/****** <<DOCUMENTO>> ******/

GO

CREATE TABLE [LOS_METATECLA].[Documento](
	[Doc_Tipo_Cod] [numeric](18, 0) NOT NULL,
	[Doc_Tipo_Desc] [varchar](255) NULL)
 
GO
ALTER TABLE [LOS_METATECLA].[Documento] ADD CONSTRAINT PK_ID_DOCUMENTO
	PRIMARY KEY(Doc_Tipo_Cod)

/***/

GO
INSERT INTO [LOS_METATECLA].[Documento] (Doc_Tipo_Cod, Doc_Tipo_Desc)
SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc
FROM gd_esquema.Maestra 
GROUP BY Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc


/****** <<PAIS>> ******/

GO

CREATE TABLE [LOS_METATECLA].[PAIS](
	[Pais_Codigo] [numeric](18, 0) NOT NULL,
	[Pais_Desc] [varchar](250) NULL)
 
GO
ALTER TABLE [LOS_METATECLA].[PAIS] ADD CONSTRAINT PK_ID_PAIS
	PRIMARY KEY(Pais_Codigo)

/***/

GO
INSERT INTO [LOS_METATECLA].[PAIS] (Pais_Codigo, Pais_Desc)
SELECT DISTINCT Cli_Pais_Codigo as Pais_Cod, Cli_Pais_Desc
FROM gd_esquema.Maestra 
UNION 
SELECT DISTINCT Cuenta_Pais_Codigo as Pais_Cod, Cuenta_Pais_Desc
FROM gd_esquema.Maestra 
UNION 
SELECT DISTINCT Cuenta_Dest_Pais_Codigo as Pais_Cod, Cuenta_Dest_Pais_Desc
FROM gd_esquema.Maestra
WHERE Cuenta_Dest_Pais_Codigo IS NOT NULL
ORDER BY Pais_Cod

/****** <<CUENTA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Cuenta](
	[Cuenta_Numero] Numeric(18,0) NOT NULL,
	[Cuenta_Fecha_Creacion] datetime NULL,
	[Cuenta_Estado] varchar(255) NULL,
	[Cuenta_Pais_Codigo] numeric(18,0) NULL,
	[Cuenta_Fecha_Cierre] datetime NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Cuenta] ADD CONSTRAINT PK_ID_CUENTA
	PRIMARY KEY(Cuenta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Pais] FOREIGN KEY([Cuenta_Pais_Codigo])
REFERENCES [LOS_METATECLA].[PAIS](Pais_Codigo)


/***/

GO
INSERT INTO LOS_METATECLA.Cuenta (Cuenta_Numero, Cuenta_Estado, Cuenta_Fecha_Cierre, Cuenta_Fecha_Creacion, Cuenta_Pais_Codigo)
SELECT Cuenta_Numero, Cuenta_Estado, Cuenta_Fecha_Cierre, Cuenta_Fecha_Creacion, Cuenta_Pais_Codigo
FROM gd_esquema.Maestra
GROUP BY Cuenta_Numero, Cuenta_Estado, Cuenta_Fecha_Cierre, Cuenta_Fecha_Creacion, Cuenta_Pais_Codigo, Cuenta_Numero

/****** <<CLIENTE>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Cliente](
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NOT NULL,
	[Cli_Nro_Doc] [numeric] (18, 0) NOT NULL UNIQUE,
	[Cli_Pais_Codigo] [numeric](18, 0) NOT NULL,
	[Id_Domicilio] [int] NOT NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL)
	
GO
ALTER TABLE [LOS_METATECLA].[Cliente] ADD CONSTRAINT PK_ID_CLIENTE
	PRIMARY KEY(Cli_Nro_Doc)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Domicilio] FOREIGN KEY([Id_Domicilio])
REFERENCES [LOS_METATECLA].[DOMICILIO](Id_Domicilio)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Documento] FOREIGN KEY([Cli_Tipo_Doc_Cod])
REFERENCES [LOS_METATECLA].[DOCUMENTO](Doc_Tipo_Cod)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY([Cli_Pais_Codigo])
REFERENCES [LOS_METATECLA].[PAIS](Pais_Codigo)

/***/

GO
INSERT INTO LOS_METATECLA.Cliente (Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod, Cli_Pais_Codigo, Cli_Nro_Doc, Id_Domicilio)
SELECT m.Cli_Apellido, m.Cli_Fecha_Nac, Cli_Mail, m.Cli_Nombre, m.Cli_Tipo_Doc_Cod, m.Cli_Pais_Codigo, m.Cli_Nro_Doc, d.Id_Domicilio
FROM LOS_METATECLA.Domicilio d, gd_esquema.Maestra m
WHERE (m.Cli_Dom_Calle = d.Dom_Calle AND m.Cli_Dom_Nro = d.Dom_Nro AND m.Cli_Dom_Piso = d.Dom_Piso AND m.Cli_Dom_Depto = d.Dom_Depto)
GROUP BY Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod, Cli_Pais_Codigo, Cli_Nro_Doc, Id_Domicilio


/****** <<EMISOR>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Emisor](
	[Emisor_Descripcion] [varchar] (255) NULL,
	[Id_Emisor] [int] IDENTITY(1,1) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Emisor] ADD CONSTRAINT PK_EMISOR
	PRIMARY KEY(Id_Emisor)
	

/***/

GO

INSERT INTO [LOS_METATECLA].[Emisor] (Emisor_Descripcion)
SELECT DISTINCT Tarjeta_Emisor_Descripcion
FROM gd_esquema.Maestra
WHERE Tarjeta_Emisor_Descripcion IS NOT NULL


/****** <<TARJETA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Tarjeta](
	[Tarjeta_Numero] [varchar](16) NOT NULL,
	[Tarjeta_Fecha_Emision] [datetime] NULL,
	[Tarjeta_Fecha_Vencimiento] [datetime] NULL,
	[Tarjeta_Codigo_Seg] [varchar] (3) NULL,
	[Tarjeta_Emisor_Id] [int] NOT NULL,
	[Id_Cliente_Propietario] numeric(18,0) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Tarjeta] ADD CONSTRAINT PK_NRO_TARJETA
	PRIMARY KEY(Tarjeta_Numero)
	
GO
ALTER TABLE [LOS_METATECLA].[Tarjeta]  ADD  CONSTRAINT [FK_Cliente_Tarjeta] FOREIGN KEY([Id_Cliente_Propietario])
REFERENCES [LOS_METATECLA].[CLIENTE](Cli_Nro_Doc)

GO
ALTER TABLE [LOS_METATECLA].[Tarjeta]  ADD  CONSTRAINT [FK_Emisor_Tarjeta] FOREIGN KEY([Tarjeta_Emisor_Id])
REFERENCES [LOS_METATECLA].[EMISOR](Id_Emisor)

/***/

GO

INSERT INTO [LOS_METATECLA].[Tarjeta] (Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg,Id_Cliente_Propietario, Tarjeta_Emisor_Id) 
SELECT DISTINCT m.Tarjeta_Numero, m.Tarjeta_Fecha_Emision, m.Tarjeta_Fecha_Vencimiento, m.Tarjeta_Codigo_Seg, c.Cli_Nro_Doc, e.Id_Emisor
FROM gd_esquema.Maestra m, LOS_METATECLA.Cliente c, LOS_METATECLA.Emisor e
WHERE Tarjeta_Numero IS NOT NULL AND m.Cli_Nro_Doc = c.Cli_Nro_Doc AND m.Tarjeta_Emisor_Descripcion = e.Emisor_Descripcion
GROUP BY Tarjeta_Numero, Tarjeta_Codigo_Seg, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, c.Cli_Nro_Doc, e.Id_Emisor









