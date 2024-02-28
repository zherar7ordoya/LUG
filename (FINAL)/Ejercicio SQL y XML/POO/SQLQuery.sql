USE [master]
GO

/****** Object:  Database [Final]    Script Date: 28/2/2024 08:18:05 ******/
CREATE DATABASE [Final]
GO

ALTER DATABASE [Final]

SET COMPATIBILITY_LEVEL = 150
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
BEGIN
	EXEC [Final].[dbo].[sp_fulltext_database] @action = 'enable'
END
GO

ALTER DATABASE [Final]

SET ANSI_NULL_DEFAULT OFF
GO

ALTER DATABASE [Final]

SET ANSI_NULLS OFF
GO

ALTER DATABASE [Final]

SET ANSI_PADDING OFF
GO

ALTER DATABASE [Final]

SET ANSI_WARNINGS OFF
GO

ALTER DATABASE [Final]

SET ARITHABORT OFF
GO

ALTER DATABASE [Final]

SET AUTO_CLOSE OFF
GO

ALTER DATABASE [Final]

SET AUTO_SHRINK OFF
GO

ALTER DATABASE [Final]

SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [Final]

SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [Final]

SET CURSOR_DEFAULT GLOBAL
GO

ALTER DATABASE [Final]

SET CONCAT_NULL_YIELDS_NULL OFF
GO

ALTER DATABASE [Final]

SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [Final]

SET QUOTED_IDENTIFIER OFF
GO

ALTER DATABASE [Final]

SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [Final]

SET DISABLE_BROKER
GO

ALTER DATABASE [Final]

SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [Final]

SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [Final]

SET TRUSTWORTHY OFF
GO

ALTER DATABASE [Final]

SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [Final]

SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [Final]

SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [Final]

SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [Final]

SET RECOVERY SIMPLE
GO

ALTER DATABASE [Final]

SET MULTI_USER
GO

ALTER DATABASE [Final]

SET PAGE_VERIFY CHECKSUM
GO

ALTER DATABASE [Final]

SET DB_CHAINING OFF
GO

ALTER DATABASE [Final]

SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)
GO

ALTER DATABASE [Final]

SET TARGET_RECOVERY_TIME = 60 SECONDS
GO

ALTER DATABASE [Final]

SET DELAYED_DURABILITY = DISABLED
GO

ALTER DATABASE [Final]

SET ACCELERATED_DATABASE_RECOVERY = OFF
GO

ALTER DATABASE [Final]

SET QUERY_STORE = OFF
GO

USE [Final]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente] (
	[Codigo] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[FechaNacimiento] [date] NULL,
	[Email] [varchar](50) NULL,
	CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Codigo] ASC) WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
		) ON [PRIMARY]
	) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Renta]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Renta] (
	[Codigo] [int] NOT NULL,
	[Codigo_Cliente] [int] NULL,
	[Codigo_Vehiculo] [int] NULL,
	[DiasRentados] [int] NULL,
	[Importe] [decimal](6, 2) NULL,
	CONSTRAINT [PK_Renta] PRIMARY KEY CLUSTERED ([Codigo] ASC) WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
		) ON [PRIMARY]
	) ON [PRIMARY]
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	1,
	N'Juan',
	N'Perez',
	12345678,
	CAST(N'1990-01-15' AS DATE),
	N'juan@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	2,
	N'Maria',
	N'Gomez',
	98765432,
	CAST(N'1985-05-20' AS DATE),
	N'maria@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	3,
	N'Carlos',
	N'Lopez',
	45678901,
	CAST(N'1993-11-08' AS DATE),
	N'carlos@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	4,
	N'Ana',
	N'Rodriguez',
	78901234,
	CAST(N'1980-07-03' AS DATE),
	N'ana@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	5,
	N'Pedro',
	N'Martinez',
	56789012,
	CAST(N'1992-04-25' AS DATE),
	N'pedro@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	6,
	N'Laura',
	N'Hernandez',
	34567890,
	CAST(N'1988-09-12' AS DATE),
	N'laura@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	7,
	N'Hector',
	N'Diaz',
	90123456,
	CAST(N'1995-02-28' AS DATE),
	N'hector@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	8,
	N'Silvia',
	N'Fernandez',
	23456789,
	CAST(N'1983-06-10' AS DATE),
	N'silvia@gmail.com'
	)
GO

INSERT [dbo].[Cliente] (
	[Codigo],
	[Nombre],
	[Apellido],
	[DNI],
	[FechaNacimiento],
	[Email]
	)
VALUES (
	9,
	N'Gerardo',
	N'Tordoya',
	12345678,
	CAST(N'1987-08-26' AS DATE),
	N'gerardo@tordoya.ar'
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	1,
	1,
	1,
	2,
	CAST(200.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	2,
	2,
	2,
	1,
	CAST(100.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	3,
	3,
	3,
	3,
	CAST(800.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	4,
	4,
	2,
	2,
	CAST(200.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	5,
	5,
	5,
	1,
	CAST(50.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	6,
	6,
	6,
	1,
	CAST(150.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	7,
	7,
	7,
	3,
	CAST(150.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	8,
	8,
	8,
	2,
	CAST(150.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	9,
	9,
	7,
	4,
	CAST(100.00 AS DECIMAL(6, 2))
	)
GO

INSERT [dbo].[Renta] (
	[Codigo],
	[Codigo_Cliente],
	[Codigo_Vehiculo],
	[DiasRentados],
	[Importe]
	)
VALUES (
	10,
	9,
	1,
	1,
	CAST(100.00 AS DECIMAL(6, 2))
	)
GO

ALTER TABLE [dbo].[Renta]
	WITH CHECK ADD CONSTRAINT [FK_Cliente_Renta] FOREIGN KEY ([Codigo_Cliente]) REFERENCES [dbo].[Cliente]([Codigo])
GO

ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Cliente_Renta]
GO

/****** Object:  StoredProcedure [dbo].[ClienteAgregar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[ClienteAgregar]
	-- Add the parameters for the stored procedure here
	@Codigo INT,
	@Nombre VARCHAR(15),
	@Apellido VARCHAR(15),
	@DNI INT,
	@FechaNacimiento DATE,
	@Email VARCHAR(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	INSERT INTO Cliente (
		Codigo,
		Nombre,
		Apellido,
		DNI,
		FechaNacimiento,
		Email
		)
	VALUES (
		@Codigo,
		@Nombre,
		@Apellido,
		@DNI,
		@FechaNacimiento,
		@Email
		);
END
GO

/****** Object:  StoredProcedure [dbo].[ClienteBorrar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[ClienteBorrar]
	-- Add the parameters for the stored procedure here
	@Codigo INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	DELETE
	FROM Cliente
	WHERE Codigo = @Codigo;
END
GO

/****** Object:  StoredProcedure [dbo].[ClienteModificar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[ClienteModificar]
	-- Add the parameters for the stored procedure here
	@Codigo INT,
	@Nombre VARCHAR(15),
	@Apellido VARCHAR(15),
	@DNI INT,
	@FechaNacimiento DATE,
	@Email VARCHAR(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	UPDATE Cliente
	SET Nombre = @Nombre,
		Apellido = @Apellido,
		DNI = @DNI,
		FechaNacimiento = @FechaNacimiento,
		Email = @Email
	WHERE Codigo = @Codigo;
END
GO

/****** Object:  StoredProcedure [dbo].[ClientesConsultar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[ClientesConsultar]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	SELECT *
	FROM Cliente;
END
GO

/****** Object:  StoredProcedure [dbo].[RentaAgregar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[RentaAgregar]
	-- Add the parameters for the stored procedure here
	@Codigo INT,
	@Codigo_Cliente INT,
	@Codigo_Vehiculo INT,
	@DiasRentados INT,
	@Importe DECIMAL(6, 2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	INSERT INTO Renta (
		Codigo,
		Codigo_Cliente,
		Codigo_Vehiculo,
		DiasRentados,
		Importe
		)
	VALUES (
		@Codigo,
		@Codigo_Cliente,
		@Codigo_Vehiculo,
		@DiasRentados,
		@Importe
		);
END
GO

/****** Object:  StoredProcedure [dbo].[RentaBorrar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[RentaBorrar]
	-- Add the parameters for the stored procedure here
	@Codigo INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	DELETE
	FROM Renta
	WHERE Codigo = @Codigo;
END
GO

/****** Object:  StoredProcedure [dbo].[RentaModificar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[RentaModificar]
	-- Add the parameters for the stored procedure here
	@Codigo INT,
	@Codigo_Cliente INT,
	@Codigo_Vehiculo INT,
	@DiasRentados INT,
	@Importe DECIMAL(6, 2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	UPDATE Renta
	SET Codigo_Cliente = @Codigo_Cliente,
		Codigo_Vehiculo = @Codigo_Vehiculo,
		DiasRentados = @DiasRentados,
		Importe = @Importe
	WHERE Codigo = @Codigo;
END
GO

/****** Object:  StoredProcedure [dbo].[RentasConsultar]    Script Date: 28/2/2024 08:18:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2024-02-12
-- Description:	(auto-documentado)
-- =============================================
CREATE PROCEDURE [dbo].[RentasConsultar]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	SELECT *
	FROM Renta;
END
GO

USE [master]
GO

ALTER DATABASE [Final]

SET READ_WRITE
GO
