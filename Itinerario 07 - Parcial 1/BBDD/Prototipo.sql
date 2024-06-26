USE [master]
GO
/****** Object:  Database [Prototipo]    Script Date: 20/5/2022 14:32:49 ******/
CREATE DATABASE [Prototipo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Prototipo', FILENAME = N'C:\Users\zherar7ordoya\Prototipo.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Prototipo_log', FILENAME = N'C:\Users\zherar7ordoya\Prototipo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Prototipo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Prototipo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Prototipo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Prototipo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Prototipo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Prototipo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Prototipo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Prototipo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Prototipo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Prototipo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Prototipo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Prototipo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Prototipo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Prototipo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Prototipo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Prototipo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Prototipo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Prototipo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Prototipo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Prototipo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Prototipo] SET  MULTI_USER 
GO
ALTER DATABASE [Prototipo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Prototipo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Prototipo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Prototipo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Prototipo]
GO
/****** Object:  Table [dbo].[Cliente_Tarjeta]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente_Tarjeta](
	[CodTarjeta] [int] NULL,
	[CodCliente] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[FechaNacimiento] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DescuentoOtorgado]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DescuentoOtorgado](
	[Codigo] [int] NULL,
	[NumeroTarjeta] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[MontoDescuento] [decimal](8, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paises](
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincias](
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 20/5/2022 14:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[Vencimiento] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Rubro] [varchar](50) NULL,
	[TipoNacProv] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[Saldo] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Cliente_Tarjeta] ([CodTarjeta], [CodCliente]) VALUES (1, 4)
INSERT [dbo].[Cliente_Tarjeta] ([CodTarjeta], [CodCliente]) VALUES (3, 5)
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (4, N'Gerardo', N'Tordoya', 30400500, N'26/10/1985 00:00:00')
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (5, N'Bob', N'Esponja', 44555666, N'5/3/2013 00:00:00')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (NULL, 1003, N'Nacional', CAST(375.00 AS Decimal(8, 2)))
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (1, N'Afganistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (2, N'Islas Gland')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (3, N'Albania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (4, N'Alemania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (5, N'Andorra')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (6, N'Angola')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (7, N'Anguilla')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (8, N'Antártida')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (9, N'Antigua y Barbuda')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (10, N'Antillas Holandesas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (11, N'Arabia Saudí')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (12, N'Argelia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (13, N'Argentina')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (14, N'Armenia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (15, N'Aruba')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (16, N'Australia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (17, N'Austria')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (18, N'Azerbaiyán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (19, N'Bahamas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (20, N'Bahréin')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (21, N'Bangladesh')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (22, N'Barbados')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (23, N'Bielorrusia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (24, N'Bélgica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (25, N'Belice')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (26, N'Benin')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (27, N'Bermudas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (28, N'Bhután')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (29, N'Bolivia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (30, N'Bosnia y Herzegovina')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (31, N'Botsuana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (32, N'Isla Bouvet')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (33, N'Brasil')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (34, N'Brunéi')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (35, N'Bulgaria')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (36, N'Burkina Faso')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (37, N'Burundi')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (38, N'Cabo Verde')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (39, N'Islas Caimán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (40, N'Camboya')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (41, N'Camerún')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (42, N'Canadá')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (43, N'República Centroafricana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (44, N'Chad')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (45, N'República Checa')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (46, N'Chile')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (47, N'China')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (48, N'Chipre')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (49, N'Isla de Navidad')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (50, N'Ciudad del Vaticano')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (51, N'Islas Cocos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (52, N'Colombia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (53, N'Comoras')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (54, N'República Democrática del Congo')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (55, N'Congo')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (56, N'Islas Cook')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (57, N'Corea del Norte')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (58, N'Corea del Sur')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (59, N'Costa de Marfil')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (60, N'Costa Rica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (61, N'Croacia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (62, N'Cuba')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (63, N'Dinamarca')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (64, N'Dominica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (65, N'República Dominicana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (66, N'Ecuador')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (67, N'Egipto')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (68, N'El Salvador')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (69, N'Emiratos Árabes Unidos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (70, N'Eritrea')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (71, N'Eslovaquia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (72, N'Eslovenia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (73, N'España')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (74, N'Islas ultramarinas de Estados Unidos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (75, N'Estados Unidos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (76, N'Estonia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (77, N'Etiopía')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (78, N'Islas Feroe')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (79, N'Filipinas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (80, N'Finlandia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (81, N'Fiyi')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (82, N'Francia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (83, N'Gabón')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (84, N'Gambia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (85, N'Georgia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (86, N'Islas Georgias del Sur y Sandwich del Sur')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (87, N'Ghana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (88, N'Gibraltar')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (89, N'Granada')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (90, N'Grecia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (91, N'Groenlandia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (92, N'Guadalupe')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (93, N'Guam')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (94, N'Guatemala')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (95, N'Guayana Francesa')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (96, N'Guinea')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (97, N'Guinea Ecuatorial')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (98, N'Guinea-Bissau')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (99, N'Guyana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (100, N'Haití')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (101, N'Islas Heard y McDonald')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (102, N'Honduras')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (103, N'Hong Kong')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (104, N'Hungría')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (105, N'India')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (106, N'Indonesia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (107, N'Irán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (108, N'Iraq')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (109, N'Irlanda')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (110, N'Islandia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (111, N'Israel')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (112, N'Italia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (113, N'Jamaica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (114, N'Japón')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (115, N'Jordania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (116, N'Kazajstán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (117, N'Kenia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (118, N'Kirguistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (119, N'Kiribati')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (120, N'Kuwait')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (121, N'Laos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (122, N'Lesotho')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (123, N'Letonia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (124, N'Líbano')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (125, N'Liberia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (126, N'Libia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (127, N'Liechtenstein')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (128, N'Lituania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (129, N'Luxemburgo')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (130, N'Macao')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (131, N'ARY Macedonia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (132, N'Madagascar')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (133, N'Malasia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (134, N'Malawi')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (135, N'Maldivas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (136, N'Malí')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (137, N'Malta')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (138, N'Islas Malvinas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (139, N'Islas Marianas del Norte')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (140, N'Marruecos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (141, N'Islas Marshall')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (142, N'Martinica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (143, N'Mauricio')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (144, N'Mauritania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (145, N'Mayotte')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (146, N'México')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (147, N'Micronesia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (148, N'Moldavia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (149, N'Mónaco')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (150, N'Mongolia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (151, N'Montserrat')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (152, N'Mozambique')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (153, N'Myanmar')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (154, N'Namibia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (155, N'Nauru')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (156, N'Nepal')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (157, N'Nicaragua')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (158, N'Níger')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (159, N'Nigeria')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (160, N'Niue')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (161, N'Isla Norfolk')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (162, N'Noruega')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (163, N'Nueva Caledonia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (164, N'Nueva Zelanda')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (165, N'Omán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (166, N'Países Bajos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (167, N'Pakistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (168, N'Palau')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (169, N'Palestina')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (170, N'Panamá')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (171, N'Papúa Nueva Guinea')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (172, N'Paraguay')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (173, N'Perú')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (174, N'Islas Pitcairn')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (175, N'Polinesia Francesa')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (176, N'Polonia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (177, N'Portugal')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (178, N'Puerto Rico')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (179, N'Qatar')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (180, N'Reino Unido')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (181, N'Reunión')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (182, N'Ruanda')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (183, N'Rumania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (184, N'Rusia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (185, N'Sahara Occidental')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (186, N'Islas Salomón')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (187, N'Samoa')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (188, N'Samoa Americana')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (189, N'San Cristóbal y Nevis')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (190, N'San Marino')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (191, N'San Pedro y Miquelón')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (192, N'San Vicente y las Granadinas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (193, N'Santa Helena')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (194, N'Santa Lucía')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (195, N'Santo Tomé y Príncipe')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (196, N'Senegal')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (197, N'Serbia y Montenegro')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (198, N'Seychelles')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (199, N'Sierra Leona')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (200, N'Singapur')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (201, N'Siria')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (202, N'Somalia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (203, N'Sri Lanka')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (204, N'Suazilandia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (205, N'Sudáfrica')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (206, N'Sudán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (207, N'Suecia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (208, N'Suiza')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (209, N'Surinam')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (210, N'Svalbard y Jan Mayen')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (211, N'Tailandia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (212, N'Taiwán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (213, N'Tanzania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (214, N'Tayikistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (215, N'Territorio Británico del Océano Índico')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (216, N'Territorios Australes Franceses')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (217, N'Timor Oriental')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (218, N'Togo')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (219, N'Tokelau')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (220, N'Tonga')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (221, N'Trinidad y Tobago')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (222, N'Túnez')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (223, N'Islas Turcas y Caicos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (224, N'Turkmenistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (225, N'Turquía')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (226, N'Tuvalu')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (227, N'Ucrania')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (228, N'Uganda')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (229, N'Uruguay')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (230, N'Uzbekistán')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (231, N'Vanuatu')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (232, N'Venezuela')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (233, N'Vietnam')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (234, N'Islas Vírgenes Británicas')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (235, N'Islas Vírgenes de los Estados Unidos')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (236, N'Wallis y Futuna')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (237, N'Yemen')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (238, N'Yibuti')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (239, N'Zambia')
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (240, N'Zimbabue')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (1, N'Buenos Aires')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (2, N'Buenos Aires-GBA')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (3, N'Capital Federal')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (4, N'Catamarca')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (5, N'Chaco')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (6, N'Chubut')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (7, N'Córdoba')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (8, N'Corrientes')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (9, N'Entre Ríos')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (10, N'Formosa')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (11, N'Jujuy')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (12, N'La Pampa')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (13, N'La Rioja')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (14, N'Mendoza')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (15, N'Misiones')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (16, N'Neuquén')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (17, N'Río Negro')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (18, N'Salta')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (19, N'San Juan')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (20, N'San Luis')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (21, N'Santa Cruz')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (22, N'Santa Fe')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (23, N'Santiago del Estero')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (24, N'Tierra del Fuego')
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (25, N'Tucumán')
SET IDENTITY_INSERT [dbo].[Tarjetas] ON 

INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1, 1001, N'18/5/2024 16:07:35', N'Alta', N'Indumentaria', N'Argentina', N'Jujuy', CAST(25000 AS Decimal(18, 0)))
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (2, 1002, N'18/5/2024 16:07:35', N'Baja', N'Libre', N'Australia', NULL, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (3, 1003, N'18/5/2022 17:22:16', N'Alta', N'Indumentaria', N'Argentina', N'Buenos Aires', CAST(49500 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Tarjetas] OFF
USE [master]
GO
ALTER DATABASE [Prototipo] SET  READ_WRITE 
GO
