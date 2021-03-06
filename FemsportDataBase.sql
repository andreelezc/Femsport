USE [master]
GO
/****** Object:  Database [FemsportDataBase]    Script Date: 30/9/2018 03:05:00 ******/
CREATE DATABASE [FemsportDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FemsportDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FemsportDataBase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FemsportDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\FemsportDataBase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FemsportDataBase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FemsportDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FemsportDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FemsportDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FemsportDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FemsportDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FemsportDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [FemsportDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FemsportDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FemsportDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FemsportDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FemsportDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FemsportDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FemsportDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FemsportDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FemsportDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FemsportDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FemsportDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FemsportDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FemsportDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FemsportDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FemsportDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FemsportDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FemsportDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FemsportDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FemsportDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [FemsportDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FemsportDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FemsportDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FemsportDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FemsportDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FemsportDataBase]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[DNI] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[email] [varchar](30) NOT NULL,
	[pais] [varchar](20) NOT NULL,
	[provincia] [varchar](20) NOT NULL,
	[localidad] [varchar](20) NOT NULL,
	[direccion] [varchar](20) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[CUIT] [varchar](20) NOT NULL,
	[id_tipoEmpleado] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[DNI] [varchar](10) NOT NULL,
	[direccion] [varchar](20) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[pais] [varchar](20) NOT NULL,
	[provincia] [varchar](20) NOT NULL,
	[localidad] [varchar](20) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[fechaIngreso] [datetime] NOT NULL,
	[imagen] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CUIT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaCabecera]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaCabecera](
	[id_cabeceraFactura] [int] NOT NULL,
	[DNI] [varchar](10) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fechaVenta] [datetime] NOT NULL,
	[formaPago] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cabeceraFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaDetalle]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaDetalle](
	[id_cabeceraFactura] [int] NOT NULL,
	[codigo] [varchar](30) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cabeceraFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[id_marca] [int] NOT NULL,
	[descripcion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[codigo] [varchar](30) NOT NULL,
	[id_marca] [int] NOT NULL,
	[id_tipoProducto] [int] NOT NULL,
	[precio] [decimal](8, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[stockMinimo] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[talle] [varchar](10) NOT NULL,
	[estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoEmpleado]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEmpleado](
	[id_tipoEmpleado] [int] NOT NULL,
	[Descripcion] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[id_tipoProducto] [int] NOT NULL,
	[Nombre] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 30/9/2018 03:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] NOT NULL,
	[CUIT] [varchar](20) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (getdate()) FOR [fechaIngreso]
GO
ALTER TABLE [dbo].[FacturaCabecera] ADD  DEFAULT (getdate()) FOR [fechaVenta]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_TipoEmpleado] FOREIGN KEY([id_tipoEmpleado])
REFERENCES [dbo].[TipoEmpleado] ([id_tipoEmpleado])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_TipoEmpleado]
GO
ALTER TABLE [dbo].[FacturaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_FacturaCabecera_Clientes] FOREIGN KEY([DNI])
REFERENCES [dbo].[Clientes] ([DNI])
GO
ALTER TABLE [dbo].[FacturaCabecera] CHECK CONSTRAINT [FK_FacturaCabecera_Clientes]
GO
ALTER TABLE [dbo].[FacturaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_FacturaCabecera_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[FacturaCabecera] CHECK CONSTRAINT [FK_FacturaCabecera_Usuarios]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalle_FacturaCabecera] FOREIGN KEY([id_cabeceraFactura])
REFERENCES [dbo].[FacturaCabecera] ([id_cabeceraFactura])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK_FacturaDetalle_FacturaCabecera]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalle_Productos] FOREIGN KEY([codigo])
REFERENCES [dbo].[Productos] ([codigo])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK_FacturaDetalle_Productos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marcas] ([id_marca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProducto] FOREIGN KEY([id_tipoProducto])
REFERENCES [dbo].[TipoProducto] ([id_tipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProducto]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([CUIT])
REFERENCES [dbo].[Empleados] ([CUIT])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
USE [master]
GO
ALTER DATABASE [FemsportDataBase] SET  READ_WRITE 
GO
