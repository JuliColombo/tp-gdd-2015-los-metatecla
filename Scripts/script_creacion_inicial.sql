USE [GD1C2015]
GO

/************************************************************************************************************/
/*********************************** ELIMINO LAS TABLAS SI YA EXISTEN ***************************************/
/************************************************************************************************************/

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[AgregarFuncionalidadNueva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [LOS_METATECLA].[AgregarFuncionalidadNueva]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[AgregarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [LOS_METATECLA].[AgregarFuncionalidadARol]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[AgregarNuevoRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [LOS_METATECLA].[AgregarNuevoRol]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[actualizar_saldo_cuenta_retiro]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [LOS_METATECLA].[actualizar_saldo_cuenta_retiro]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[actualizar_saldo_cuenta_deposito]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [LOS_METATECLA].[actualizar_saldo_cuenta_deposito]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Usuario_Rol]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Usuario_Rol]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Funcionalidad_Rol]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Funcionalidad_Rol]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Funcionalidad]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Funcionalidad]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Rol]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Rol]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Usuario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Usuario]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Item_Factura]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Item_Factura]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Factura]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Factura]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Cheque]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Cheque]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Retiro]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Retiro]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Transferencia]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Transferencia]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Deposito]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Deposito]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Cuenta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Cuenta]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Tipo_Cuenta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Tipo_Cuenta]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Estado_Cuenta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Estado_Cuenta]

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
object_id(N'[LOS_METATECLA].[PAIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[PAIS]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Emisor]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Emisor]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Banco]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Banco]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Moneda]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Moneda]

GO
if exists (select * from dbo.sysobjects where id =
object_id(N'[LOS_METATECLA].[Log_Intentos]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [LOS_METATECLA].[Log_Intentos]



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

/****** <<CLIENTE>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Cliente](
	[Cli_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Cli_Tipo_Doc_Cod] numeric(18, 0) NOT NULL,
	[Cli_Nro_Doc] [numeric] (18, 0) NOT NULL,
	[Cli_Pais_Codigo] [numeric](18, 0) NOT NULL,
	[Id_Domicilio] [int] NOT NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL,
	[Cli_Estado] [varchar](255) NULL)
	
GO
ALTER TABLE [LOS_METATECLA].[Cliente] ADD CONSTRAINT PK_CLIENTE
	PRIMARY KEY(Cli_Id)

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Domicilio] FOREIGN KEY([Id_Domicilio])
REFERENCES [LOS_METATECLA].[DOMICILIO](Id_Domicilio)
ON DELETE CASCADE

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Documento] FOREIGN KEY([Cli_Tipo_Doc_Cod])
REFERENCES [LOS_METATECLA].[DOCUMENTO](Doc_Tipo_Cod)
ON DELETE CASCADE

GO
ALTER TABLE [LOS_METATECLA].[Cliente]  ADD  CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY([Cli_Pais_Codigo])
REFERENCES [LOS_METATECLA].[PAIS](Pais_Codigo)
ON DELETE CASCADE

/***/

GO
INSERT INTO LOS_METATECLA.Cliente (Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod, Cli_Pais_Codigo, Cli_Nro_Doc, Id_Domicilio)
SELECT m.Cli_Apellido, m.Cli_Fecha_Nac, Cli_Mail, m.Cli_Nombre, m.Cli_Tipo_Doc_Cod, m.Cli_Pais_Codigo, m.Cli_Nro_Doc, d.Id_Domicilio
FROM LOS_METATECLA.Domicilio d, gd_esquema.Maestra m
WHERE (m.Cli_Dom_Calle = d.Dom_Calle AND m.Cli_Dom_Nro = d.Dom_Nro AND m.Cli_Dom_Piso = d.Dom_Piso AND m.Cli_Dom_Depto = d.Dom_Depto)
GROUP BY Cli_Apellido, Cli_Fecha_Nac, Cli_Mail, Cli_Nombre, Cli_Tipo_Doc_Cod, Cli_Pais_Codigo, Cli_Nro_Doc, Id_Domicilio

GO
UPDATE LOS_METATECLA.Cliente SET Cli_Estado = 'habilitado' 
/****** <<MONEDA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Moneda](
	[Moneda_Desc] [varchar] (255) NOT NULL,
	[Id_Moneda] [int] IDENTITY(0,1) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Moneda] ADD CONSTRAINT PK_MONEDA
	PRIMARY KEY(Id_Moneda)
	

/***/

GO

INSERT INTO [LOS_METATECLA].[Moneda] (Moneda_Desc)
VALUES('Dólar'), ('Euro'), ('Real'), ('Yen')



/****** <<TIPO_CUENTA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Tipo_Cuenta](
	[Tipo_Dias] [int] NOT NULL,
	[Tipo_Costo] [numeric] (18,2) NOT NULL,
	[Tipo_Desc] [varchar] (255) NULL,
	[Tipo_Moneda] [int] NOT NULL,
	[Id_Tipo] [int] IDENTITY(1,1) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Tipo_Cuenta] ADD CONSTRAINT PK_TIPO_CUENTA
	PRIMARY KEY(Id_Tipo)
	
GO
ALTER TABLE [LOS_METATECLA].[Tipo_Cuenta]  ADD  CONSTRAINT [FK_Tipo_Cuenta_Moneda] FOREIGN KEY([Tipo_Moneda])
	REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)
	

/***/

GO

INSERT INTO [LOS_METATECLA].[Tipo_Cuenta] (Tipo_Dias, Tipo_Costo, Tipo_Desc, Tipo_Moneda)
VALUES(150, 0, 'Gratuita', 0), (90, 30.0, 'Bronce', 0), (60, 40.7, 'Plata', 0), (30, 60.8, 'Oro', 0)


/****** <<ESTADO_CUENTA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Estado_Cuenta](
	[Estado_Desc] [varchar] (255) NOT NULL,
	[Id_Estado] [int] IDENTITY(1,1) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Estado_Cuenta] ADD CONSTRAINT PK_ESTADO_CUENTA
	PRIMARY KEY(Id_Estado)
	

/***/

GO

INSERT INTO [LOS_METATECLA].[Estado_Cuenta] (Estado_Desc)
VALUES('Pendiente de activación'), ('Habilitada'), ('Inhabilitada'), ('Cerrada')


/****** <<CUENTA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Cuenta](
	[Cuenta_Numero] Numeric(18,0) NOT NULL,
	[Cuenta_Fecha_Creacion] datetime NULL,
	[Cuenta_Estado] int NOT NULL,
	[Cuenta_Pais_Codigo] numeric(18,0) NOT NULL,
	[Cuenta_Fecha_Cierre] datetime NULL,
	[Cuenta_Cliente_id] int NOT NULL,
	[Cuenta_Moneda] int NOT NULL,
	[Cuenta_Tipo] int NOT NULL,
	[Cuenta_Saldo] numeric(18,2))
	
GO
ALTER TABLE [LOS_METATECLA].[Cuenta] ADD CONSTRAINT PK_ID_CUENTA
	PRIMARY KEY(Cuenta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Pais] FOREIGN KEY([Cuenta_Pais_Codigo])
REFERENCES [LOS_METATECLA].[PAIS](Pais_Codigo)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Cliente] FOREIGN KEY([Cuenta_Cliente_id])
REFERENCES [LOS_METATECLA].[CLIENTE](Cli_id)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Tipo] FOREIGN KEY([Cuenta_Tipo])
REFERENCES [LOS_METATECLA].[TIPO_CUENTA](Id_Tipo)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Estado] FOREIGN KEY([Cuenta_Estado])
REFERENCES [LOS_METATECLA].[ESTADO_CUENTA](Id_Estado)

GO
ALTER TABLE [LOS_METATECLA].[Cuenta]  ADD  CONSTRAINT [FK_Cuenta_Moneda] FOREIGN KEY([Cuenta_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)



/***/
/*El 2 indica que la cuenta esta habilitada, el 1 que la cuenta es gratuita, y el 0 que la moneda utilizada es el dolar*/
GO
INSERT INTO LOS_METATECLA.Cuenta (Cuenta_Numero, Cuenta_Estado, Cuenta_Fecha_Cierre, Cuenta_Fecha_Creacion, Cuenta_Pais_Codigo, Cuenta_Cliente_id, Cuenta_Tipo, Cuenta_Moneda, Cuenta_Saldo)
SELECT m.Cuenta_Numero, 2, m.Cuenta_Fecha_Cierre, m.Cuenta_Fecha_Creacion, m.Cuenta_Pais_Codigo, c.Cli_Id, 1, 0, 0
FROM gd_esquema.Maestra m, LOS_METATECLA.Cliente c
WHERE c.Cli_Nro_Doc = m.Cli_Nro_Doc
GROUP BY Cuenta_Numero, Cuenta_Estado, Cuenta_Fecha_Cierre, Cuenta_Fecha_Creacion, Cuenta_Pais_Codigo, c.Cli_Id


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
	[Id_Cliente_Propietario] int NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Tarjeta] ADD CONSTRAINT PK_NRO_TARJETA
	PRIMARY KEY(Tarjeta_Numero)
	
GO
ALTER TABLE [LOS_METATECLA].[Tarjeta]  ADD  CONSTRAINT [FK_Cliente_Tarjeta] FOREIGN KEY([Id_Cliente_Propietario])
REFERENCES [LOS_METATECLA].[CLIENTE](Cli_id)

GO
ALTER TABLE [LOS_METATECLA].[Tarjeta]  ADD  CONSTRAINT [FK_Emisor_Tarjeta] FOREIGN KEY([Tarjeta_Emisor_Id])
REFERENCES [LOS_METATECLA].[EMISOR](Id_Emisor)

/***/

GO

INSERT INTO [LOS_METATECLA].[Tarjeta] (Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg,Id_Cliente_Propietario, Tarjeta_Emisor_Id) 
SELECT DISTINCT m.Tarjeta_Numero, m.Tarjeta_Fecha_Emision, m.Tarjeta_Fecha_Vencimiento, m.Tarjeta_Codigo_Seg, c.Cli_Id, e.Id_Emisor
FROM gd_esquema.Maestra m, LOS_METATECLA.Cliente c, LOS_METATECLA.Emisor e
WHERE Tarjeta_Numero IS NOT NULL AND m.Cli_Nro_Doc = c.Cli_Nro_Doc AND m.Tarjeta_Emisor_Descripcion = e.Emisor_Descripcion
GROUP BY Tarjeta_Numero, Tarjeta_Codigo_Seg, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, c.Cli_Id, e.Id_Emisor


/****** <<BANCO>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Banco](
	[Banco_Nombre] [varchar] (255) NULL,
	[Banco_Direccion] [varchar] (255) NULL,
	[Banco_Codigo] [numeric] (18,0) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Banco] ADD CONSTRAINT PK_BANCO
	PRIMARY KEY(Banco_Codigo)
	

/***/

GO

INSERT INTO [LOS_METATECLA].[Banco] (Banco_Codigo, Banco_Direccion, Banco_Nombre)
SELECT DISTINCT Banco_Cogido, Banco_Direccion, Banco_Nombre
FROM gd_esquema.Maestra
WHERE Banco_Cogido IS NOT NULL


/****** <<RETIRO>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Retiro](
	[Retiro_Importe] [numeric] (18,2) NULL,
	[Retiro_Moneda] [int] NOT NULL,
	[Retiro_Fecha] [datetime] NULL,
	[Retiro_Codigo] [numeric] (18,0) NOT NULL,
	[Numero_Cuenta] [numeric] (18,0) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Retiro] ADD CONSTRAINT PK_RETIRO
	PRIMARY KEY(Retiro_Codigo)
	
GO
ALTER TABLE [LOS_METATECLA].[Retiro]  ADD  CONSTRAINT [FK_Cuenta_Retiro] FOREIGN KEY([Numero_Cuenta])
REFERENCES [LOS_METATECLA].[CUENTA](Cuenta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Retiro]  ADD  CONSTRAINT [FK_Retiro_Moneda] FOREIGN KEY([Retiro_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)

/**************************** <<TRIGGER DE RETIRO PARA SALDO DE CUENTAS>> ******************************/

GO
CREATE TRIGGER actualizar_saldo_cuenta_retiro ON
[LOS_METATECLA].Retiro
FOR INSERT
AS
BEGIN
	
	UPDATE LOS_METATECLA.Cuenta
	SET Cuenta_Saldo = Cuenta_Saldo + (SELECT
						SUM(-Retiro_Importe)
						FROM Inserted
						WHERE Numero_Cuenta = Cuenta_Numero
						GROUP BY Numero_Cuenta)
	
END
	
GO

/***/

GO

INSERT INTO [LOS_METATECLA].[Retiro] (Retiro_Codigo, Retiro_Importe, Retiro_Fecha, Numero_Cuenta, Retiro_Moneda)
SELECT DISTINCT m.Retiro_Codigo, m.Retiro_Importe, m.Retiro_Fecha, c.Cuenta_Numero, 0
FROM gd_esquema.Maestra m, LOS_METATECLA.Cuenta c
WHERE Retiro_Codigo IS NOT NULL AND m.Cuenta_Numero = c.Cuenta_Numero


/****** <<CHEQUE>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Cheque](
	[Cheque_Importe] [numeric] (18,2) NULL,
	[Cheque_Moneda] [int] NOT NULL,
	[Cheque_Fecha] [datetime] NULL,
	[Cheque_Numero] [numeric] (18,0) NOT NULL,
	[Banco_Codigo] [numeric] (18,0) NOT NULL,
	[Retiro_Codigo] [numeric] (18,0) NOT NULL,
	[Cliente_id] [int] NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Cheque] ADD CONSTRAINT PK_CHEQUE
	PRIMARY KEY(Cheque_Numero)
	
GO
ALTER TABLE [LOS_METATECLA].[Cheque]  ADD  CONSTRAINT [FK_Cheque_Banco] FOREIGN KEY([Banco_Codigo])
REFERENCES [LOS_METATECLA].[BANCO](Banco_Codigo)

GO
ALTER TABLE [LOS_METATECLA].[Cheque]  ADD  CONSTRAINT [FK_Cheque_Retiro] FOREIGN KEY([Retiro_Codigo])
REFERENCES [LOS_METATECLA].[RETIRO](Retiro_Codigo)

GO
ALTER TABLE [LOS_METATECLA].[Cheque]  ADD  CONSTRAINT [FK_Cheque_Cliente] FOREIGN KEY([Cliente_id])
REFERENCES [LOS_METATECLA].[CLIENTE](Cli_id)

GO
ALTER TABLE [LOS_METATECLA].[Cheque]  ADD  CONSTRAINT [FK_Cheque_Moneda] FOREIGN KEY([Cheque_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)

/***/

GO

INSERT INTO [LOS_METATECLA].[Cheque] (Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Codigo, Retiro_Codigo, Cliente_id, Cheque_Moneda)
SELECT DISTINCT m.Cheque_Numero, m.Cheque_Fecha, m.Cheque_Importe, m.Banco_Cogido, m.Retiro_Codigo, Cli_id, 0
FROM gd_esquema.Maestra m, LOS_METATECLA.Banco b, LOS_METATECLA.Retiro r, LOS_METATECLA.Cliente c
WHERE Cheque_Numero IS NOT NULL AND b.Banco_Codigo = m.Banco_Cogido AND r.Retiro_Codigo = m.Retiro_Codigo AND c.Cli_Nro_Doc = m.Cli_Nro_Doc
GROUP BY Cli_id, m.Retiro_Codigo, m.Banco_Cogido, m.Cheque_Importe, m.Cheque_Fecha, m.Cheque_Numero



/****** <<TRANSFERENCIA>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Transferencia](
	[Id_Transferencia] [int] IDENTITY(1,1) NOT NULL,
	[Transferencia_Fecha] [datetime] NULL,
	[Transferencia_Importe] [numeric] (18,2) NULL,
	[Transferencia_Moneda] [int] NOT NULL,
	[Transferencia_Costo] [numeric] (18,2) NULL,
	[Cuenta_Origen] [numeric] (18,0) NOT NULL,
	[Cuenta_Destino] [numeric] (18,0) NOT NULL)
	
	
GO
ALTER TABLE [LOS_METATECLA].[Transferencia] ADD CONSTRAINT PK_TRANSFERENCIA
	PRIMARY KEY(Id_Transferencia)
	
GO
ALTER TABLE [LOS_METATECLA].[Transferencia]  ADD  CONSTRAINT [FK_Transf_Cuenta_Destino] FOREIGN KEY([Cuenta_Destino])
REFERENCES [LOS_METATECLA].[CUENTA](Cuenta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Transferencia]  ADD  CONSTRAINT [FK_Transf_Cuenta_Origen] FOREIGN KEY([Cuenta_Origen])
REFERENCES [LOS_METATECLA].[CUENTA](Cuenta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Transferencia]  ADD  CONSTRAINT [FK_Transferencia_Moneda] FOREIGN KEY([Transferencia_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)
	
/**/

GO

INSERT INTO [LOS_METATECLA].[Transferencia] (Transferencia_Costo, Transferencia_Fecha, Transferencia_Importe, Cuenta_Destino, Cuenta_Origen, Transferencia_Moneda)
SELECT DISTINCT Trans_Costo_Trans, Transf_Fecha, Trans_Importe, Cuenta_Dest_Numero, Cuenta_Numero, 0
FROM gd_esquema.Maestra
WHERE Trans_Importe IS NOT NULL
--GROUP BY Trans_Costo_Trans, Transf_Fecha, Trans_Importe, Cuenta_Dest_Numero, Cuenta_Numero


/****** <<DEPOSITO>> ******/
GO
CREATE TABLE [LOS_METATECLA].[Deposito](
Deposito_Codigo NUMERIC(18,0) PRIMARY KEY,
Deposito_Fecha DATETIME ,
Deposito_Importe NUMERIC(18,2) NOT NULL,
Deposito_Moneda INT NOT NULL,
Tipo_Moneda varchar(10)/*Aca no se que tipo poner*/,
Tarjeta_Numero varchar(16) NOT NULL,
Numero_Cuenta NUMERIC(18,0) NOT NULL)

GO

ALTER TABLE LOS_METATECLA.Deposito ADD CONSTRAINT FK_Deposito_Cuenta FOREIGN KEY (Numero_Cuenta) 
REFERENCES LOS_METATECLA.Cuenta(Cuenta_Numero)

GO

ALTER TABLE LOS_METATECLA.Deposito ADD CONSTRAINT FK_Deposito_Tarjeta FOREIGN KEY (Tarjeta_Numero)
REFERENCES LOS_METATECLA.Tarjeta(Tarjeta_Numero)

GO
ALTER TABLE [LOS_METATECLA].[Deposito]  ADD  CONSTRAINT [FK_Deposito_Moneda] FOREIGN KEY([Deposito_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)


/***/

/**************************** <<TRIGGER DE DEPOSITO PARA SALDO DE CUENTAS>> ******************************/

GO
CREATE TRIGGER actualizar_saldo_cuenta_deposito ON
[LOS_METATECLA].Deposito
FOR INSERT
AS
BEGIN
	
	UPDATE LOS_METATECLA.Cuenta
	SET Cuenta_Saldo = Cuenta_Saldo  + (SELECT
						SUM(Deposito_Importe)
						FROM Inserted
						WHERE Numero_Cuenta = Cuenta_Numero
						GROUP BY Numero_Cuenta)
	
END
	
GO

/***/
GO

INSERT INTO LOS_METATECLA.Deposito (Deposito_Codigo,Deposito_Fecha,Deposito_Importe,Tarjeta_Numero,Numero_Cuenta, Deposito_Moneda)
SELECT DISTINCT ms.Deposito_Codigo, ms.Deposito_Fecha, ms.Deposito_Importe, tj.Tarjeta_Numero,cta.Cuenta_Numero, 0
FROM gd_esquema.Maestra ms, LOS_METATECLA.Tarjeta tj, LOS_METATECLA.Cuenta cta
WHERE ms.Deposito_Codigo IS NOT NULL AND tj.Tarjeta_Numero = ms.Tarjeta_Numero AND cta.Cuenta_Numero = ms.Cuenta_Numero


/****** <<FACTURA>> ******/
GO
CREATE TABLE [LOS_METATECLA].[Factura](
Factura_Numero [numeric] (18,0) NOT NULL,
Factura_Fecha [datetime] NULL,
Factura_Moneda [int] NOT NULL,
Cli_id [int] NULL)

GO
ALTER TABLE [LOS_METATECLA].[Factura] ADD CONSTRAINT PK_FACTURA
	PRIMARY KEY(Factura_Numero)

GO

ALTER TABLE LOS_METATECLA.Factura ADD CONSTRAINT FK_Factura_Cliente FOREIGN KEY (Cli_id) 
REFERENCES LOS_METATECLA.Cliente(Cli_id)


GO
ALTER TABLE [LOS_METATECLA].[Factura]  ADD  CONSTRAINT [FK_Factura_Moneda] FOREIGN KEY([Factura_Moneda])
REFERENCES [LOS_METATECLA].[MONEDA](Id_Moneda)



/***/

GO

INSERT INTO LOS_METATECLA.Factura (Factura_Fecha, Factura_Numero, Cli_id, Factura_Moneda)
SELECT DISTINCT Factura_Fecha, Factura_Numero, Cli_id, 0
FROM gd_esquema.Maestra m, LOS_METATECLA.Cliente c
WHERE Factura_Numero IS NOT NULL AND m.Cli_Nro_Doc = c.Cli_Nro_Doc


/****** <<ITEM_FACTURA>> ******/
GO
CREATE TABLE [LOS_METATECLA].[Item_Factura](
Id_Item [int] IDENTITY(1,1) NOT NULL,
Item_Desc [varchar] (255),
Item_Importe [numeric] (18,2),
Factura_Numero [numeric] (18,0))
	

GO
ALTER TABLE [LOS_METATECLA].[Item_Factura] ADD CONSTRAINT PK_ITEM_FACTURA
	PRIMARY KEY(Id_Item)

GO

ALTER TABLE LOS_METATECLA.Item_Factura ADD CONSTRAINT FK_Id_Factura_Factura FOREIGN KEY (Factura_Numero) 
REFERENCES LOS_METATECLA.Factura(Factura_Numero)



/***/

GO

INSERT INTO LOS_METATECLA.Item_Factura (Item_Desc, Factura_Numero, Item_Importe)
SELECT DISTINCT Item_Factura_Descr, Factura_Numero, Item_Factura_Importe
FROM gd_esquema.Maestra 
WHERE Item_Factura_Descr IS NOT NULL

GO

/**************************** <<CREO TABLAS PARA EL MANEJO DE ROLES Y FUNCIONALIDADES>> ******************************/

CREATE TABLE LOS_METATECLA.Rol(
	Id_Rol	   NUMERIC(18,0) IDENTITY(0,1) PRIMARY KEY,
	Nombre	   VARCHAR(100) NOT NULL UNIQUE,
	Habilitado BIT			 NOT NULL)

GO

CREATE TABLE LOS_METATECLA.Funcionalidad(
	Id_Funcionalidad NUMERIC(18,0) IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL UNIQUE)

GO

CREATE TABLE LOS_METATECLA.Funcionalidad_Rol ( 
	Id_Funcionalidad NUMERIC(18,0) NOT NULL, 
	Id_Rol NUMERIC(18,0) NOT NULL) 

GO

ALTER TABLE LOS_METATECLA.Funcionalidad_Rol ADD CONSTRAINT FK_Funcionalidad FOREIGN KEY (Id_Funcionalidad) REFERENCES LOS_METATECLA.Funcionalidad(Id_Funcionalidad)

GO

ALTER TABLE LOS_METATECLA.Funcionalidad_Rol ADD CONSTRAINT FK_Rol FOREIGN KEY (Id_Rol) REFERENCES LOS_METATECLA.Rol(Id_Rol)

GO
ALTER TABLE [LOS_METATECLA].[Funcionalidad_Rol] ADD CONSTRAINT PK_FUNC_ROL
	PRIMARY KEY(Id_Funcionalidad, Id_Rol)

GO

/**************************** <<STORED PROCEDURE PARA ROLES Y FUNCIONALIDADES>> ******************************/

CREATE PROCEDURE LOS_METATECLA.AgregarFuncionalidadARol(@nombrerol NVARCHAR(100), @funcionalidad nvarchar(100)) AS
BEGIN
	INSERT INTO LOS_METATECLA.Funcionalidad_Rol (Id_Rol,Id_Funcionalidad)
		VALUES ((SELECT Id_Rol FROM LOS_METATECLA.Rol WHERE UPPER(Nombre) = UPPER(@nombrerol)),
		        (SELECT Id_Funcionalidad FROM LOS_METATECLA.Funcionalidad WHERE UPPER(Nombre) = UPPER(@funcionalidad)))
END



GO

/****** <<USUARIO>> ******/

GO
CREATE TABLE [LOS_METATECLA].[Usuario](
	/*[Id_User] [int] (18,0)IDENTITY,*/
	[Id_User] [int] NOT NULL,
	[User_Username] [varchar](255) NOT NULL,/* deberia ser UNIQUE*/
	[User_Password] [varchar](255) NOT NULL,
	[User_Habilitado] [bit] NOT NULL,
	[User_Intentos_Fallidos] [int] NOT NULL,
	/*[User_Fecha_Creacion] [datetime] NULL,
	[User_Ultima_Fecha_Modif] [datetime] NULL,
	[User_Respuesta_Secreta] [varchar](255) NULL,
	[User_Pregunta_Secreta] [varchar](255) NULL*/)
	
GO
ALTER TABLE [LOS_METATECLA].[Usuario] ADD CONSTRAINT PK_USUARIO
	PRIMARY KEY(Id_User)

GO

ALTER TABLE LOS_METATECLA.Usuario ADD CONSTRAINT FK_Cliente FOREIGN KEY (Id_User) REFERENCES LOS_METATECLA.Cliente(Cli_id)

GO


/***/

GO
INSERT INTO LOS_METATECLA.Usuario (Id_User, User_Username, User_Password, User_Habilitado, User_Intentos_Fallidos)
SELECT c.Cli_id, c.Cli_Nombre, 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1, 0
FROM LOS_METATECLA.Cliente c
GROUP BY c.Cli_Id, c.Cli_Nombre

/****** <<USUARIO_ROL>> ******/
CREATE TABLE LOS_METATECLA.Usuario_Rol ( 
	Id_Usuario int NOT NULL, 
	Id_Rol NUMERIC(18,0) NOT NULL) 

GO
ALTER TABLE [LOS_METATECLA].[Usuario_Rol] ADD CONSTRAINT PK_USU_ROL
	PRIMARY KEY(Id_Usuario, Id_Rol)

ALTER TABLE LOS_METATECLA.Usuario_Rol ADD CONSTRAINT FK_USUARIO_ROL_USU FOREIGN KEY (Id_Usuario) REFERENCES LOS_METATECLA.Usuario(Id_User)

GO

ALTER TABLE LOS_METATECLA.Usuario_Rol ADD CONSTRAINT FK_ROL_ROL_USU FOREIGN KEY (Id_Rol) REFERENCES LOS_METATECLA.Rol(Id_Rol)

GO


/****** <<LOG_INTENTOS>> ******/
CREATE TABLE LOS_METATECLA.Log_Intentos ( 
	Id_Log NUMERIC(18,0) IDENTITY(0,1) NOT NULL, 
	Desc_Log VARCHAR (255) NOT NULL)
	/*FALTARIA AGREGAR LA FECHA*/ 

GO
ALTER TABLE [LOS_METATECLA].[Log_Intentos] ADD CONSTRAINT PK_LOG
	PRIMARY KEY(Id_Log)


