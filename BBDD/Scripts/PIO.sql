USE [master]
GO
/****** Object:  Database [PIO]    Script Date: 23/03/2023 10:14:38 a. m. ******/
CREATE DATABASE [PIO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PIO', FILENAME = N'C:\Documents\AP6\Database\PIO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PIO_log', FILENAME = N'C:\Documents\AP6\Database\PIO_log.ldf' , SIZE = 504KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PIO] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PIO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PIO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PIO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PIO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PIO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PIO] SET ARITHABORT OFF 
GO
ALTER DATABASE [PIO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PIO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PIO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PIO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PIO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PIO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PIO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PIO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PIO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PIO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PIO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PIO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PIO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PIO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PIO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PIO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PIO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PIO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PIO] SET  MULTI_USER 
GO
ALTER DATABASE [PIO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PIO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PIO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PIO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PIO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PIO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PIO] SET QUERY_STORE = OFF
GO
USE [PIO]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[CategoriaID] [int] NOT NULL,
	[CategoriaNombre] [nvarchar](60) NOT NULL,
	[CategoriaDescripcion] [ntext] NULL,
	[CategoriaInactiva] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[DepartamentoID] [int] NOT NULL,
	[DepartamentoNombre] [nvarchar](30) NOT NULL,
	[DepartamentoInactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoLegajo] [int] NOT NULL,
	[EmpleadoNombre] [nvarchar](15) NOT NULL,
	[EmpleadoApellido] [nvarchar](15) NOT NULL,
	[EmpleadoUsuario] [nvarchar](15) NOT NULL,
	[EmpleadoContraseña] [nvarchar](15) NOT NULL,
	[EmpleadoFechaNacimiento] [datetime] NULL,
	[EmpleadoFechaContratacion] [datetime] NULL,
	[EmpleadoDireccionCalle] [nvarchar](15) NULL,
	[EmpleadoDireccionNumero] [int] NULL,
	[EmpleadoDireccionCiudad] [nvarchar](15) NULL,
	[EmpleadoTelefono] [nvarchar](15) NULL,
	[EmpleadoFoto] [image] NULL,
	[EmpleadoJefe] [int] NULL,
	[EmpleadoInactivo] [bit] NOT NULL,
	[DepartamentoID] [int] NOT NULL,
	[RolID] [int] NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden Detalles]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden Detalles](
	[OrdenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[ProductoPrecioUnitario] [money] NOT NULL,
	[Cantidad] [smallint] NOT NULL,
	[Descuento] [real] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrdenID] ASC,
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[OrdenID] [int] IDENTITY(1,1) NOT NULL,
	[OrdenFecha] [datetime] NOT NULL,
	[OrdenEstado] [char](10) NOT NULL,
	[OrdenEliminada] [bit] NOT NULL,
	[EmpleadoID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoNombre] [nvarchar](40) NOT NULL,
	[ProductoDescripcion] [ntext] NULL,
	[ProductoCantidadPorUnidad] [nvarchar](20) NULL,
	[ProductoPrecioUnitario] [money] NOT NULL,
	[ProductoDiscontinuado] [bit] NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[ProveedorID] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ProveedorID] [int] NOT NULL,
	[ProveedorNombre] [nvarchar](15) NOT NULL,
	[ProveedorDireccionCalle] [nvarchar](15) NULL,
	[ProveedorDireccionNumero] [int] NULL,
	[ProveedorDireccionCiudad] [nvarchar](15) NULL,
	[ProveedorTelefono] [nvarchar](24) NULL,
	[ProveedorEmail] [nvarchar](24) NULL,
	[ProveedorInactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolID] [int] NOT NULL,
	[RolNombre] [nvarchar](30) NOT NULL,
	[RolInactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (1, N'Archivar documentos
', N'Archivar se define como ''guardar papeles en un archivo''. La elaboración de documentos y su custodia todavía es la principal tarea de muchas oficinas. Para ello existen dos posibilidades: archivar documentos perforando el papel, o bien sin taladrarlos. Para conservar papeles perforados se usan los archivadores y las carpetas de anillas. El archivador, a diferencia de la carpeta, incluye una palanca para abrir las anillas: es una solución de archivo más eficaz y por eso se usa mucho en las oficinas. En cambio, la carpeta de anillas se prefiere, por ejemplo, como organizador escolar. Si no se quiere perforar el documento, los materiales de oficina que nos van a permitir hacerlo son aún más variados. Las carpetas con fundas de plástico protegen los documentos y nos permiten hojearlos con facilidad. Las carpetas de proyectos son idóneas para guardar planos y presentar proyectos profesionales. Los dosieres con pinza son útiles para presentar unos pocos papeles de manera directa y sencilla. En las carpetas colgantes se pueden organizar todo tipo de expedientes, estas cuelgan de las guías de un fichero metálico. Los sobres de plástico y los maletines portafolios son una buena solución para proteger y transportar los papeles del día a día.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (2, N'Borrar trazos de lápiz
', N'Como se verá más adelante en el verbo «Escribir», los trazos de los lápices de grafito se pueden borrar. El material que se usa para ello es la goma de borrar, que puede ser de caucho o plástica. Las gomas de borrar Milan 430 son de caucho. Son muy blandas, útiles y económicas para borrar trazos de grafito y portaminas. Los borradores de vinilo de marcas como Staedtler (Mars Plastic), Faber-Castell o Rotring no producen apenas residuos al borrar y son idóneos para dibujo técnico. Este producto también se encuentra en versión lápiz: el portagomas. Este borrador mecánico es similar a un portaminas y contiene en su interior un cilindro de goma de borrar que se puede sustituir cuando se gasta.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (3, N'Corregir textos escritos con bolígrafo
', N'A diferencia de los lápices, y a menos que sean borrables, los bolígrafos tienen tinta que no se puede eliminar del papel. Para corregir los errores en los textos escritos con estos instrumentos de escritura se usan los correctores típex. Estos pueden ser líquidos o de cinta. Hoy se usa, sobre todo, el típex de cinta porque no requiere esperar a que seque y permite corregir de manera inmediata los errores. Los correctores de oficina evolucionaron a partir de los usados en máquinas de escribir. La marca Tipp-Ex, castellanizada como típex, fue la primera en introducir un producto que permitía rectificar los errores cometidos con máquinas de escribir. Para ello se superponía una hoja de Tipp-Ex sobre el papel y se pulsaba la tecla de la máquina que corresponde con la letra que se quiere suprimir. Con el impacto de esta, el dorso del Tipp-Ex se transfería al papel dejando sobre la tinta una capa blanca que eliminaba el error.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (4, N'Cortar papel, cartulina y plástico
', N'Cortar es ''dividir en dos o más partes un objeto usando un útil afilado''. Los materiales de oficina se pueden separar con tijeras, cúter, guillotinas y cizallas de rodillo. La tijera es el útil formado por dos hojas afiladas cruzadas que se articulan sobre un eje. Dichas cuchillas disponen de dos anillos en sus extremos en los que se meten los dedos. Con las tijeras de oficina se puede cortar papel, cartulina, cartón y plástico flexible. El cúter es un instrumento con forma de cuchillo que sirve para hacer incisiones en materiales blandos de oficina o productos de manualidades. Cuando se requiere, por ejemplo, eliminar un fragmento en el interior de un folio de papel respetando el perímetro no se usan las tijeras, sino el cúter. Los escalpelos de precisión son una variante de este cortador que incluyen una cuchilla ultrafilada con la que se logran cortes muy finos en papel, cartulina, corcho, goma EVA y otros materiales. Dejando de lado los materiales de mano, encontramos la guillotina, una pequeña máquina de oficina que sirve para cortar papel y fotografías en línea recta. Una variante de esta herramienta es la cizalla de cuchilla circular. Con las mejores cizallas, además de cortes rectos, también se pueden obtener efectos especiales como los bordes ondulados o en zig-zag.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (5, N'Destruir archivos
', N'Toda oficina requiere deshacerse de aquellos papeles que ya no son útiles periódicamente. Puesto que estos contienen información sensible de sus clientes y proveedores, la destrucción de los documentos debe hacerse de manera que se preserve la confidencialidad de las personas. Y para ello se usan las destructoras de papel. Según el volumen de papeles que en ellas se vayan a procesar diaria o semanalmente, se pueden comprar trituradoras de archivos más o menos potentes. Estas máquinas se clasifican según el número simultáneo de hojas que pueden triturar y según el tiempo durante el que pueden operar antes de reposar para permitir que sus cuchillas se enfríen (ciclo de trabajo).', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (6, N'Encuadernar documentos
', N'La encuadernación de documentos sirve para presentar de manera eficaz la información a los clientes, proveedores, alumnos, etc. Para esta tarea se requiere la máquina de encuadernar y el consumible que esta use. Con las encuadernadoras térmicas y las de presión se consigue que los cuadernillos tengan el aspecto de un libro. Más económicas son las de espiral metálica o canutillo de plástico, las cuales perforan los documentos y los agrupan usando un gusanillo con anillas.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (7, N'Escribir', N'En las oficinas de antes se escribía, sobre todo, con máquina de escribir. Hoy se golpean los teclados del ordenador para transcribir la información. Sin embargo, en ambos casos se siguen usando bolígrafos, plumas estilográficas, rotuladores, marcadores, lápices y portaminas cuando se trata de escribir a mano. La estilográfica fue uno de los primeros instrumentos modernos para escribir con tinta, antes de su invención se usaban plumas de aves. Con las primeras plumas no se podía escribir más que unas pocas palabras y para ello se sumergían una y otra vez en el tintero. Después, aparecieron las plumas con depósito recargable y, más tarde, las de cartucho desechable. La llegada del bolígrafo hizo que dejásemos de escribir con estilográfica. La conveniencia de un depósito que almacenaba suficiente tinta para poder escribir durante meses, el secado rápido del trazo y el hecho de que no perdiese tinta del depósito fueron algunos de los aspectos clave por los que el uso de este instrumento de escritura terminó por imponerse. Sin embargo, no fue un proceso sencillo, los primeros prototipos de bolígrafos no funcionaban bien y perdían tinta. Hasta que no se inventó el modelo que combinaba la acción de la gravedad y la capilaridad en el mecanismo de flujo no fue realmente eficaz. Las tintas de los primeros bolígrafos (basadas en aceite) eran más espesas y pesadas. Todavía se usan. Las encontramos, por ejemplo, en el Bic Cristal. Se disfruta de una escritura más fluida si se opta por comprar un bolígrafo con tinta líquida o de gel. Cuando la punta del bolígrafo no es metálica, sino de fibra, lo llamamos rotulador. La tinta de los rotuladores puede ser permanente o no serlo y se fabrica en una gran gama de colores. En manualidades infantiles, los rotuladores escolares sirven para dibujar y colorear. También existen rotuladores con tinta pigmentada para trazar las líneas en dibujo técnico. El marcador fluorescente es una variante con punta biselada del rotulador que sirve para subrayar textos. Hasta que no se inventó una tinta fluorescente y transparente no se pudo disfrutar de estos materiales y era necesario usar bolígrafos para subrayar los renglones, o bien lápices de grafito. Entre los materiales de oficina para escribir no pueden faltar los lápices de grafito. Estos son muy diferentes a los bolígrafos: no contienen tinta y su mina es afilable. Tiene algunas ventajas frente al bolígrafo: (1) el lápiz se puede borrar, (2) no hay riesgo de derrame de tinta, (3) al no contenerla nunca se secan, (4) se pueden afilar para reducir el grosor de trazo, (5) con ellos se puede escribir en cualquier posición, al no depender de la gravedad. Según una conocida leyenda urbana, durante la carrera espacial, los americanos invirtieron una gran suma de dinero para fabricar un bolígrafo que permitiera a sus astronautas escribir en el espacio. Los rusos, enfrentados al mismo problema, decidieron usar un lápiz.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (8, N'Explicar una idea en público
', N'Cuando se trata de explicar una idea a los compañeros de trabajo o de anotar un esquema que resuma las ideas que va a tratar el profesor en clase, no sirve el papel. ¿Qué usamos entonces? Las pizarras blancas para marcadores, o las verdes para tizas. Por su tamaño, la pizarra es uno de los sistemas más efectivos para la comunicación visual. Es idónea para exponer ideas en público. Y es económica: las mejores pizarras ofrecen más de 20 años de garantía y el precio de los rotuladores (o el de las tizas) es muy asequible. ¿Qué pizarra comprar? Las blancas no magnéticas son las más baratas, pero también las menos duraderas. Los modelos de chapa de acero pintada, o mejor, vitrificada, son mucho más resistentes y le brindan al ponente la posibilidad de usar imanes para que sus explicaciones sean más fructíferas. En cuanto al útil de escritura, si la pizarra es para rotulador, este ha de ser especial, hablamos del marcador de borrado en seco. En cambio, si es para tiza, habrá que tener en cuenta que hay personas que son alérgicas al polvo de tiza; las mejores tizas incorporan un aditivo antipolvo eficaz que puede reducir las molestias asociadas al polvo de tiza que se genera al borrar la pizarra.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (9, N'Grapar papeles', N'Grapar es ''unir dos o más piezas de papel usando una pieza metálica doblada por sus extremos''. Los materiales de oficina necesarios para esta tarea son las grapas y grapadoras. Las grapadoras pueden ser de bolsillo, sobremesa o tenaza. Se clasifican según la capacidad de grapado (cuántas hojas son capaces de unir) y la profundidad de entrada del papel (distancia a la que pueden situar las grapas desde el borde del documento). Para grapar grandes cantidades de folios, las grapadoras de alta capacidad son las más efectivas. También existen grapadoras eléctricas, que no requieren esfuerzo por parte del usuario y mejoran el rendimiento de la oficina.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (10, N'Imprimir información
', N'En la oficina moderna ya no se escribe a máquina, en su lugar, se imprimen los documentos en impresoras. El papel más usado en estos equipos es el de formato A4 con gramaje de 80 g. El gramaje es la medida que nos indica el peso del papel en relación a su área. El papel es más grueso y consistente cuanto más pesado sea.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (11, N'Organizar ideas en paredes
', N'Los cuadernos, las agendas y las notas post-it son materiales de oficina eficaces para no olvidarse de nada y organizar las tareas de la semana. Pero hay ideas que necesitan más visibilidad. Hablamos de las tareas que se han de coordinar con los compañeros de trabajo, los horarios y calendarios o la información expuesta la público. Para lo anterior, una de las soluciones más efectivas es el tablero de anuncios. Si se cuelga de la pared una pizarra de corcho y disponemos de las agujas y chinchetas adecuadas para ello, podremos tener a la vista todas aquellas ideas a las que recurrimos con frecuencia o las tareas planificadas que no debemos olvidar. Las pizarras de corcho pueden estar enmarcadas con listones de madera de pino o con aluminio. Estos últimos son más resistentes. En el precio de ella influye, además, la rigidez del tablero y el espesor del corcho. En cuanto a las chinchetas y agujas, las primeras son más cortas y con cabeza plana o redondeada; las agujas son mucho más largas pero la mayor parte de su longitud se debe a su cabeza de plástico, la cual aumenta la visibilidad de la chincheta y facilita su manipulación.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (12, N'Perforar folios', N'Como ya vimos, para archivar papeles una de las soluciones posibles consistía en perforar estos para su conservación en archivadores o carpetas de anillas. Pues bien, los folios se taladran con perforadoras de papel. Los taladros de papel contienen dos o más punzones metálicos afilados y una palanca que los empuja a través de los archivos. Como las grapadoras, se clasifican según su capacidad de perforación.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (13, N'Pegar material de oficina
', N'Para pegar papel y otros materiales de oficina se usan los adhesivos y pegamentos. Estos pueden ser líquidos, sólidos o con forma de cinta. Entre los pegamentos líquidos encontramos el universal, que sirve para pegar casi todos los materiales; la cola blanca escolar se usa para pegar cartulina y papel; el adhesivo de cianoacrilato es instantáneo y pega en segundos; el adhesivo de contacto es algo diferente: se aplica a las superficies por separado y se deja secar, al juntar las piezas, estas se adhieren por contacto. El pegamento sólido de oficina más usado es el de barra. El adhesivo de barra también es imprescindible para uso escolar. Sirve para pegar papel, cartulina y cartón. Una manera más limpia y rápida de pegar ciertos materiales en la oficina es con cintas adhesivas. El celo es una película transparente con la que se pueden pegar papeles. Para usar el celo de manera eficaz se ha de ubicar en un dispensador de cinta adhesiva. Parecida al celo, pero con adhesivo por ambas caras, la cinta de doble cara es útil para montar y fijar diferentes materiales.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (14, N'Plastificar hojas
', N'Cuando se necesita proteger un documento contra los líquidos y las manchas de grasa, se plastifica. Se usa para ello la plastificadora, una máquina de oficina que derrite los bordes de plástico de una funda en la que se inserta el papel. Una vez plastificado, el documento es impermeable y se puede exponer en exteriores.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (15, N'Plegar papel o cartas
', N'En Europa se usa el formato de papel A4 para imprimir los documentos de oficina tales como albaranes, facturas, presupuestos y cartas a clientes. En EE.UU, por el contrario, se sigue usando el formato imperial US Letter. Se puede enviar un documento A4 por correo sin plegar usando los sobres de la serie C de la norma DIN que define los formatos de papel. Por ejemplo, el sobre que permite enviar un folio A4 sin plegarlo es el sobre DIN C4. Lo anterior es útil para enviar un fajo de documentos A4 grapados, sin embargo, cuando se trata de enviar solo una hoja, se puede reducir el tamaño del sobre plegando el A4 en tres partes, en forma de Z. En tal caso, la carta plegada se envía con un sobre de formato americano. Aquellas oficinas que semanalmente envíen cientos de cartas querrán comprar una plegadora de papel automática para simplificar esta tarea. Las plegadoras poseen una bandeja de alimentación, un dispositivo que dobla el papel y una cesta de salida en la que se almacenan las cartas plegadas.', 0)
GO
INSERT [dbo].[Categorias] ([CategoriaID], [CategoriaNombre], [CategoriaDescripcion], [CategoriaInactiva]) VALUES (16, N'Recordar ideas', N'En los laboratorios de la compañía americana 3M, Spencer Silver descubrió por accidente un adhesivo de baja pegajosidad. Aunque en un primer momento no supo que hacer con él, otro hecho accidental le ayudo a sacar partido comercial a este adhesivo. Un amigo suyo que perdía continuamente los papeles que guardaba en su libro de salmos le sirvió de inspiración para fabricar las famosas notas Post-it. Que sean amarillas también fue accidental: era el papel que tenían a mano por aquel entonces. En las notas Post-it se pueden anotar todo tipo de información para evitar olvidarla: avisos telefónicos, recordatorios, números de referencia, listas de la compra...', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (1, N'Recepción', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (2, N'Atención al Público', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (3, N'Publicidad', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (4, N'Editorial', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (5, N'Clasificados', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (6, N'Diseño', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (7, N'Infomerciales', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (8, N'Sistemas', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (9, N'Correctores', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (10, N'Paginación', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (11, N'Fotografía', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (12, N'Página Web', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (13, N'Policiales', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (14, N'Periodistas', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (15, N'Directorio', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (16, N'Administración', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (17, N'Contabilidad', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (18, N'Cuentas Corrientes', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (19, N'Personal', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (20, N'Facturación', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (21, N'Productores', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (22, N'Ventas', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (23, N'Radio', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (24, N'Streaming', 0)
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [DepartamentoNombre], [DepartamentoInactivo]) VALUES (25, N'Compras', 0)
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (1, 10222, N'Andrea', N'Aparicio', N'aaparicio', N'aaparicio', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 25, 4)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (2, 10130, N'Ana', N'Aramayo', N'aaramayo', N'aaramayo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (3, 10007, N'Azucena', N'Barcelo', N'abarcelo', N'abarcelo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (4, 10146, N'Anahí', N'Fadell', N'afadell', N'afadell', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 7, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (5, 10017, N'Alfredo', N'Franco', N'afranco', N'afranco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 22, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (6, 10226, N'Amelia', N'Gutierrez', N'agutierrez', N'agutierrez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (7, 10139, N'Alfredo', N'Mamani', N'amamani', N'amamani', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 2, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (8, 10086, N'Augusto', N'Scheurer', N'ascheurer', N'ascheurer', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (9, 10219, N'Alfredo', N'Severich', N'aseverich', N'aseverich', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (10, 10159, N'Alvaro', N'Tejeda', N'atejeda', N'atejeda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (11, 10173, N'Abigail', N'Teran', N'ateran', N'ateran', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (12, 10211, N'Blanca', N'Marconiz', N'bmarconiz', N'bmarconiz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 9, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (13, 10214, N'Cristian', N'Aisama', N'caisama', N'caisama', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 9, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (14, 10138, N'Carolina', N'Alderete', N'calderete', N'calderete', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (15, 10115, N'Carmen', N'Amador', N'camador', N'camador', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (16, 10215, N'Cecilia', N'Bianco', N'cbianco', N'cbianco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (17, 10058, N'Carlos', N'Catacata', N'ccatacata', N'ccatacata', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (18, 10127, N'Carlos', N'Ferraro', N'cferraro', N'cferraro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 14, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (19, 10178, N'Carlos', N'Franco', N'cfranco', N'cfranco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (20, 10087, N'Claudio', N'Igarzabal', N'cigarzabal', N'cigarzabal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (21, 10202, N'Cesar', N'Martinez', N'cmartinez', N'cmartinez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (22, 10200, N'Carmen', N'Quispe', N'cquispe', N'cquispe', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (23, 10232, N'Carlos', N'Ramirez', N'cramirez', N'cramirez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (24, 10163, N'Cecilia', N'Reque', N'creque', N'creque', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (25, 10198, N'Carolina', N'Segovia', N'csegovia', N'csegovia', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (26, 10062, N'Dionicio', N'Alvarez', N'dalvarez', N'dalvarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (27, 10102, N'Dario', N'Bonutto', N'dbonutto', N'dbonutto', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 13, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (28, 10101, N'Dante', N'Dominguez', N'ddominguez', N'ddominguez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 7, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (29, 10040, N'Daniel', N'Echazu', N'dechazu', N'dechazu', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 6, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (30, 10091, N'Diego', N'Reimundin', N'dreimundin', N'dreimundin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (31, 25825, N'Diego', N'Salas', N'dsalas', N'dsalas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 6, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (32, 10174, N'Diego', N'Suarez', N'dsuarez', N'dsuarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (33, 10207, N'Daiana', N'Tejerina', N'dtejerina', N'dtejerina', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 5, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (34, 10066, N'Elizabeth', N'Alfaro', N'ealfaro', N'ealfaro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (35, 10210, N'Enrique', N'Alzogaray', N'ealzogaray', N'ealzogaray', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (36, 10009, N'Edgar', N'Caballero', N'ecaballero', N'ecaballero', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (37, 10158, N'Enrique', N'Calisaya', N'ecalisaya', N'ecalisaya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 14, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (38, 10212, N'Erica', N'Cari', N'ecari', N'ecari', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (39, 10121, N'Edith', N'Cruz', N'ecruz', N'ecruz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 13, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (40, 10224, N'Eduardo', N'Ochoa', N'eochoa', N'eochoa', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (41, 10209, N'Fabian', N'Alvarez', N'falvarez', N'falvarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 5, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (42, 10109, N'Fernando', N'Chavez', N'fchavez', N'fchavez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (43, 10165, N'Francisco', N'Corbacho', N'fcorbacho', N'fcorbacho', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (44, 10108, N'Franco', N'Girotti', N'fgirotti', N'fgirotti', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (45, 10128, N'Francisco', N'Palacios', N'fpalacios', N'fpalacios', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (46, 10228, N'Gustavo', N'Cajal', N'gcajal', N'gcajal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (47, 10015, N'German', N'Fernandez', N'gfernandez', N'gfernandez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 6, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (48, 10231, N'Guillermo', N'Saavedra', N'gsaavedra', N'gsaavedra', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 14, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (49, 10027, N'Gustavo', N'Toconas', N'gtoconas', N'gtoconas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (50, 10136, N'Gerardo', N'Tordoya', N'gtordoya', N'gtordoya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 8, 1)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (51, 10155, N'Gustavo', N'Vedia', N'gvedia', N'gvedia', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (52, 10018, N'Hugo', N'Fernandez', N'hfernandez', N'hfernandez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (53, 10221, N'Hugo', N'Krasnobroda', N'hkrasnobroda', N'hkrasnobroda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 22, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (54, 10118, N'Ignacio', N'Igarzabal', N'iigarzabal', N'iigarzabal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (55, 10218, N'Ivana', N'Juarez', N'ijuarez', N'ijuarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (56, 10177, N'Julio', N'Achaval', N'jachaval', N'jachaval', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (57, 10100, N'Jorge', N'Albarracin', N'jalbarracin', N'jalbarracin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (58, 10204, N'Jorge', N'Ale', N'jale', N'jale', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (59, 10045, N'Juan', N'Fernandez', N'jfernandez', N'jfernandez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 9, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (60, 10199, N'Juliana', N'Juarez', N'jjuarez', N'jjuarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 7, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (61, 10075, N'Jacqueline', N'Mendez', N'jmendez', N'jmendez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 8, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (62, 10181, N'Jorge', N'Mir', N'jmir', N'jmir', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 17, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (63, 10175, N'Julio', N'Richa', N'jricha', N'jricha', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 22, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (64, 10233, N'Juan', N'Rojas', N'jrojas', N'jrojas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 14, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (65, 10194, N'Juan', N'Saenz', N'jsaenz', N'jsaenz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (66, 10016, N'Laura', N'Ballatore', N'lballatore', N'lballatore', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 15, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (67, 10223, N'Luis', N'Caraballo', N'lcaraballo', N'lcaraballo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 11, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (68, 10225, N'Lucas', N'Delgado', N'ldelgado', N'ldelgado', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (69, 10124, N'Luis', N'Herrera', N'lherrera', N'lherrera', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (70, 10188, N'Luis', N'Lamas', N'llamas', N'llamas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 2, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (71, 10028, N'Liliana', N'Madrid', N'lmadrid', N'lmadrid', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (72, 10135, N'Luis', N'Manzara', N'lmanzara', N'lmanzara', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 14, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (73, 10208, N'Laura', N'Perea', N'lperea', N'lperea', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (74, 10157, N'Luis', N'Sanchez', N'lsanchez', N'lsanchez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 13, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (75, 10095, N'Lidia', N'Sueldo', N'lsueldo', N'lsueldo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 7, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (76, 10192, N'Luis', N'Tolaba', N'ltolaba', N'ltolaba', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (77, 10203, N'Maria', N'Alvarez', N'malvarez', N'malvarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (78, 10008, N'Maria', N'Balzarini', N'mbalzarini', N'mbalzarini', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (79, 10176, N'Marcelo', N'Betinotti', N'mbetinotti', N'mbetinotti', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (80, 10110, N'Manuel', N'Caballero', N'mcaballero', N'mcaballero', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (81, 10186, N'Mayra', N'Cardozo', N'mcardozo', N'mcardozo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (82, 10113, N'Maria', N'Cid', N'mcid', N'mcid', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (83, 10230, N'Maria', N'Duran', N'mduran', N'mduran', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (84, 10195, N'Maria', N'Galian', N'mgalian', N'mgalian', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (85, 10140, N'María', N'Garzon', N'mgarzon', N'mgarzon', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (86, 10193, N'Maria', N'Halle', N'mhalle', N'mhalle', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (87, 10189, N'Maria', N'Haquim', N'mhaquim', N'mhaquim', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (88, 10079, N'Mariana', N'Mamani', N'mmamani', N'mmamani', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (89, 10064, N'Maria', N'Mariscal', N'mmariscal', N'mmariscal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (90, 10184, N'Miguel', N'Montenegro', N'mmontenegro', N'mmontenegro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (91, 10068, N'Maria', N'Montero', N'mmontero', N'mmontero', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 17, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (92, 10041, N'Marcela', N'Navas', N'mnavas', N'mnavas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (93, 10006, N'Mauricio', N'Prinzo', N'mprinzo', N'mprinzo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (94, 10227, N'Mauro', N'Rodriguez', N'mrodriguez', N'mrodriguez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 11, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (95, 10011, N'Mario', N'Sagredo', N'msagredo', N'msagredo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (96, 10162, N'Miguel', N'Salazar', N'msalazar', N'msalazar', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 17, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (97, 10152, N'Norma', N'Batallanos', N'nbatallanos', N'nbatallanos', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (98, 10134, N'Napoleon', N'Diaz', N'ndiaz', N'ndiaz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (99, 10191, N'Nestor', N'Paredes', N'nparedes', N'nparedes', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 11, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (100, 13054, N'Nora', N'Ruiz', N'nruiz', N'nruiz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (101, 10234, N'Natalia', N'Taborda', N'ntaborda', N'ntaborda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (102, 10197, N'Oscar', N'Aisama', N'oaisama', N'oaisama', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (103, 10217, N'Oscar', N'Dominguez', N'odominguez', N'odominguez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (104, 10213, N'Paula', N'Alanoca', N'palanoca', N'palanoca', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (105, 10129, N'Pablo', N'Claros', N'pclaros', N'pclaros', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (106, 10046, N'Patricia', N'Genovese', N'pgenovese', N'pgenovese', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (107, 10220, N'Paola', N'Krogulec', N'pkrogulec', N'pkrogulec', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 18, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (108, 10149, N'Patricia', N'Subiaurre', N'psubiaurre', N'psubiaurre', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 9, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (109, 10148, N'Pamela', N'Tolaba', N'ptolaba', N'ptolaba', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 8, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (110, 10125, N'Rodrigo', N'Alvarez', N'ralvarez', N'ralvarez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 6, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (111, 10092, N'Roberto', N'Amador', N'ramador', N'ramador', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (112, 10179, N'Ricardo', N'Balceda', N'rbalceda', N'rbalceda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (113, 11092, N'Ricardo', N'Dubin', N'rdubin', N'rdubin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 3, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (114, 10099, N'Rosana', N'Herrera', N'rherrera', N'rherrera', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 12, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (115, 11036, N'Ruben', N'Rivarola', N'rrivarola', N'rrivarola', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (116, 10023, N'Rene', N'Salas', N'rsalas', N'rsalas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 1, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (117, 10205, N'Ricardo', N'Tezanos', N'rtezanos', N'rtezanos', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 20, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (118, 25826, N'Rodolfo', N'Tordoya', N'rtordoya', N'rtordoya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 11, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (119, 10153, N'Silvia', N'Asurduy', N'sasurduy', N'sasurduy', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 11, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (120, 10144, N'Sebastian', N'Castro', N'scastro', N'scastro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 5, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (121, 10161, N'Silvana', N'Copas', N'scopas', N'scopas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (122, 10229, N'Silvana', N'Franco', N'sfranco', N'sfranco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 16, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (123, 10190, N'Silvio', N'Guanuco', N'sguanuco', N'sguanuco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (124, 10187, N'Silvia', N'Herrera', N'sherrera', N'sherrera', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 19, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (125, 10032, N'Sonia', N'Huanuco', N'shuanuco', N'shuanuco', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 21, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (126, 10145, N'Sergio', N'Mendez', N'smendez', N'smendez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 6, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (127, 10201, N'Silvia', N'Quispe', N'squispe', N'squispe', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 10, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (128, 10206, N'Sandra', N'Torrico', N'storrico', N'storrico', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 13, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (129, 10054, N'Sergio', N'Velazquez', N'svelazquez', N'svelazquez', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 9, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (130, 10143, N'Valeria', N'Alfaro', N'valfaro', N'valfaro', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 3)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (131, 10182, N'Victor', N'Azize', N'vazize', N'vazize', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 23, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (132, 10183, N'Valeria', N'Gaya', N'vgaya', N'vgaya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 24, 2)
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [EmpleadoLegajo], [EmpleadoNombre], [EmpleadoApellido], [EmpleadoUsuario], [EmpleadoContraseña], [EmpleadoFechaNacimiento], [EmpleadoFechaContratacion], [EmpleadoDireccionCalle], [EmpleadoDireccionNumero], [EmpleadoDireccionCiudad], [EmpleadoTelefono], [EmpleadoFoto], [EmpleadoJefe], [EmpleadoInactivo], [DepartamentoID], [RolID]) VALUES (133, 10216, N'Virginia', N'Quinteros', N'vquinteros', N'vquinteros', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 8, 2)
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 12, 274.1800, 8, 0.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 31, 352.0900, 3, 0.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 34, 175.0000, 8, 0.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 73, 387.0000, 8, 0.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 100, 228.7300, 7, 0.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 102, 112.6400, 4, 1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 112, 178.3600, 4, 1.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (1, 156, 120.7300, 9, 1.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 7, 643.4500, 4, 1.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 9, 93.6400, 10, 1.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 21, 659.8200, 7, 1.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 22, 95.0900, 9, 1.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 82, 292.0900, 7, 1.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 99, 367.7300, 7, 1.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 116, 732.7300, 4, 1.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 145, 880.8200, 7, 2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 146, 807.6400, 6, 2.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 151, 590.3600, 2, 2.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 160, 568.2700, 4, 2.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (2, 168, 540.5500, 3, 2.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (3, 42, 440.4500, 10, 2.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (3, 95, 213.8200, 3, 2.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (3, 96, 768.8200, 3, 2.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (3, 109, 798.2700, 6, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (3, 159, 874.0000, 1, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (4, 14, 244.4500, 3, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (4, 134, 859.2700, 10, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (4, 154, 268.4500, 10, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 6, 15.8200, 3, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 25, 95.6400, 1, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 43, 477.6400, 6, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 66, 457.4500, 9, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 70, 377.5500, 7, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 110, 148.7300, 9, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (5, 135, 358.7300, 5, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 43, 876.9100, 4, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 61, 97.4500, 3, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 70, 147.6400, 10, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 81, 259.4500, 1, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 120, 570.8200, 4, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (6, 136, 584.5500, 6, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 71, 392.4500, 10, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 92, 397.0000, 1, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 100, 157.0900, 2, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 124, 795.0000, 8, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 133, 32.7300, 1, 0.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (7, 166, 607.1800, 8, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (8, 89, 286.5500, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (8, 163, 599.9100, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (9, 19, 574.5500, 4, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (9, 74, 433.6400, 5, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (9, 116, 563.7300, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (9, 134, 368.7300, 8, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (9, 147, 837.6400, 6, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 4, 851.0000, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 29, 653.6400, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 36, 69.7300, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 84, 487.0000, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 96, 247.9100, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 124, 679.6400, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (10, 167, 225.9100, 4, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (11, 51, 500.4500, 6, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (11, 138, 839.5500, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (11, 181, 147.8200, 5, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (12, 21, 681.8200, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (12, 70, 197.4500, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (12, 88, 832.5500, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (12, 153, 322.4500, 4, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (13, 62, 875.1800, 8, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (13, 92, 290.4500, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (13, 113, 113.5500, 10, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (13, 119, 802.1800, 5, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (14, 24, 813.7300, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (15, 46, 68.7300, 4, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (15, 49, 302.8200, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (15, 98, 786.6400, 8, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (15, 154, 676.0000, 10, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (16, 64, 607.0000, 3, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (16, 67, 688.8200, 9, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (16, 69, 504.4500, 1, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (16, 72, 318.5500, 5, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (16, 116, 575.9100, 5, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (17, 57, 655.5500, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (17, 61, 707.4500, 6, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (17, 101, 192.6400, 9, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (17, 105, 800.0900, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (17, 157, 666.2700, 9, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (18, 2, 853.7300, 2, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (18, 70, 95.5500, 6, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (18, 96, 739.6400, 10, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (19, 40, 132.6400, 8, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (19, 99, 573.4500, 4, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (19, 143, 768.6400, 7, 5.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (19, 165, 738.1800, 10, 9.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (20, 93, 75.0000, 4, 9.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (20, 95, 343.7300, 8, 10)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (20, 113, 506.5500, 10, 10.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 35, 282.4500, 1, 10.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 39, 9.2700, 6, 10.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 55, 240.5500, 5, 10.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 71, 629.3600, 1, 10.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 74, 465.9100, 5, 10.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 94, 300.5500, 5, 10.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 144, 58.0900, 9, 10.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 162, 814.2700, 10, 10.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 174, 696.2700, 2, 11)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (21, 181, 653.1800, 9, 11.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (22, 40, 648.4500, 2, 11.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (23, 26, 238.8200, 9, 11.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (23, 133, 289.6400, 9, 11.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (24, 103, 770.4500, 4, 11.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (24, 147, 499.1800, 6, 11.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (24, 157, 55.8200, 1, 11.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (24, 171, 366.2700, 9, 11.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 22, 778.8200, 6, 11.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 25, 284.1800, 3, 12)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 28, 136.5500, 6, 12.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 32, 173.8200, 3, 12.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 90, 869.8200, 5, 12.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 117, 295.9100, 9, 12.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 128, 53.1800, 10, 12.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 151, 222.1800, 5, 12.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (25, 154, 77.0900, 3, 12.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (26, 61, 887.5500, 5, 12.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (26, 72, 601.4500, 9, 12.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (26, 125, 842.4500, 6, 13)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (26, 152, 547.0000, 8, 13.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (26, 181, 776.2700, 5, 13.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (27, 110, 549.8200, 10, 13.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (27, 122, 74.2700, 9, 13.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (27, 143, 831.0000, 4, 13.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (27, 154, 43.1800, 4, 13.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (28, 23, 527.4500, 7, 13.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (28, 38, 19.7300, 6, 13.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (28, 133, 817.3600, 2, 13.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (28, 137, 511.6400, 2, 14)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (28, 156, 481.4500, 8, 14.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (29, 50, 223.0000, 1, 14.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (29, 166, 209.5500, 10, 14.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 4, 393.5500, 7, 14.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 52, 571.1800, 3, 14.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 69, 173.8200, 9, 14.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 73, 884.0900, 2, 14.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 102, 750.0000, 2, 14.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 113, 122.4500, 7, 14.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (30, 136, 811.9100, 1, 15)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 25, 124.6400, 9, 15.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 44, 708.1800, 4, 15.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 46, 66.0900, 2, 15.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 77, 294.0900, 5, 15.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 89, 545.8200, 7, 15.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (31, 97, 763.6400, 9, 15.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (32, 40, 433.7300, 3, 15.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (32, 50, 557.3600, 2, 15.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (32, 87, 482.8200, 6, 15.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (32, 156, 26.3600, 8, 16)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (33, 43, 648.3600, 3, 16.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (33, 87, 870.5500, 2, 16.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (33, 147, 545.1800, 3, 16.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (34, 10, 326.7300, 4, 16.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (35, 41, 34.3600, 2, 16.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (35, 76, 556.2700, 1, 16.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (35, 78, 666.0000, 6, 16.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (35, 109, 668.9100, 3, 16.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (35, 144, 599.5500, 1, 16.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (36, 31, 57.6400, 3, 17)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (36, 34, 340.9100, 4, 17.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (36, 114, 297.9100, 4, 17.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (36, 118, 616.8200, 6, 17.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (36, 154, 590.1800, 5, 17.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 7, 219.5500, 1, 17.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 18, 616.9100, 8, 17.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 27, 130.7300, 9, 17.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 32, 258.4500, 3, 17.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 91, 550.7300, 6, 17.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 120, 307.0000, 8, 18)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 127, 284.0000, 1, 18.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (37, 167, 450.0000, 4, 18.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 33, 218.0900, 6, 18.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 83, 840.0000, 2, 18.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 87, 203.4500, 4, 18.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 92, 535.9100, 5, 18.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 103, 73.5500, 8, 18.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (38, 169, 384.6400, 10, 18.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 12, 636.5500, 1, 18.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 37, 34.1800, 4, 19)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 66, 28.4500, 8, 19.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 91, 537.7300, 2, 19.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 113, 392.3600, 10, 19.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 140, 97.3600, 8, 19.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 151, 307.0000, 3, 19.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (39, 160, 723.3600, 6, 19.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (40, 13, 253.1800, 7, 19.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (40, 158, 42.3600, 10, 19.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (40, 179, 91.7300, 4, 19.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (41, 89, 610.1800, 10, 20)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (41, 108, 747.8200, 3, 20.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (41, 125, 490.6400, 2, 20.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (41, 134, 723.4500, 3, 20.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (41, 171, 192.9100, 8, 20.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 4, 874.3600, 2, 20.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 5, 681.6400, 3, 20.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 11, 155.4500, 3, 20.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 59, 775.0000, 9, 20.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 96, 825.4500, 5, 20.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 104, 182.6400, 1, 21)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 107, 557.8200, 9, 21.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 130, 383.3600, 7, 21.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 141, 529.1800, 8, 21.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 146, 76.2700, 5, 21.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 153, 805.1800, 4, 21.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (42, 162, 602.4500, 6, 21.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (43, 23, 276.8200, 10, 21.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (43, 80, 114.0000, 2, 21.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (44, 99, 794.5500, 7, 21.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (44, 135, 830.9100, 2, 22)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (45, 43, 182.3600, 9, 22.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (45, 47, 376.8200, 4, 22.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (45, 66, 888.7300, 5, 22.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (45, 133, 787.0900, 7, 22.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (46, 24, 77.8200, 4, 22.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (47, 70, 681.9100, 3, 22.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (47, 118, 30.8200, 9, 22.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (47, 149, 472.5500, 9, 22.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (47, 166, 56.6400, 6, 22.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 30, 413.4500, 5, 23)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 45, 361.3600, 5, 23.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 54, 531.6400, 10, 23.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 57, 316.7300, 3, 23.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 78, 851.2700, 9, 23.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (48, 178, 227.0000, 7, 23.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (49, 56, 610.2700, 5, 23.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (49, 102, 630.3600, 4, 23.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (50, 22, 840.7300, 3, 23.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (50, 36, 384.9100, 6, 23.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (50, 51, 281.3600, 6, 24)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (50, 92, 152.7300, 5, 24.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (50, 179, 856.6400, 2, 24.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 1, 497.0000, 9, 24.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 11, 675.0000, 2, 24.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 33, 170.6400, 1, 24.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 43, 721.9100, 6, 24.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 59, 783.6400, 8, 24.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 72, 541.0000, 6, 24.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 109, 602.7300, 7, 24.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 152, 547.7300, 6, 25)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (51, 158, 803.1800, 4, 25.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 30, 586.2700, 8, 25.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 53, 387.3600, 3, 25.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 56, 867.9100, 5, 25.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 65, 568.1800, 4, 25.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 99, 670.0000, 6, 25.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 155, 719.9100, 3, 25.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 157, 135.6400, 3, 25.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 161, 63.4500, 4, 25.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (52, 162, 544.8200, 5, 26)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (53, 127, 855.4500, 5, 26.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (53, 133, 734.6400, 6, 26.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (53, 139, 721.2700, 8, 26.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 45, 717.9100, 1, 26.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 63, 655.7300, 8, 26.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 69, 93.3600, 7, 26.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 92, 77.0900, 1, 26.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 119, 855.1800, 8, 26.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 125, 710.8200, 1, 26.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 147, 793.5500, 7, 27)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (54, 178, 146.2700, 3, 27.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (55, 8, 490.0900, 4, 27.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (55, 9, 12.8200, 3, 27.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (55, 43, 138.1800, 9, 27.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (55, 116, 154.4500, 4, 27.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (55, 117, 82.4500, 6, 27.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (56, 78, 434.0000, 2, 27.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (56, 114, 390.0900, 7, 27.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (57, 3, 30.7300, 2, 27.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (57, 67, 731.2700, 7, 28)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (57, 136, 223.2700, 6, 28.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (57, 146, 73.1800, 5, 28.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (57, 161, 834.4500, 9, 28.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 2, 480.1800, 9, 28.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 13, 104.3600, 2, 28.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 19, 313.4500, 3, 28.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 30, 74.7300, 5, 28.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 39, 395.2700, 4, 28.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 50, 543.0000, 9, 28.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 115, 84.1800, 2, 29)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 119, 503.5500, 6, 29.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (58, 156, 603.3600, 2, 29.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 32, 22.4500, 2, 29.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 41, 295.0000, 6, 29.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 71, 833.6400, 9, 29.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 89, 270.7300, 6, 29.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 99, 105.8200, 7, 29.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 135, 565.8200, 7, 29.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 138, 131.8200, 4, 29.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (59, 180, 476.1800, 4, 30)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (60, 53, 268.5500, 7, 30.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (60, 160, 890.1800, 9, 30.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 31, 770.5500, 8, 30.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 55, 85.3600, 1, 30.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 120, 158.2700, 3, 30.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 137, 10.0900, 3, 30.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 160, 865.3600, 5, 30.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (61, 178, 397.0900, 4, 30.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 23, 520.0000, 2, 30.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 24, 17.9100, 5, 31)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 25, 732.0000, 3, 31.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 67, 415.9100, 10, 31.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 69, 690.9100, 6, 31.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 77, 171.9100, 7, 31.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 92, 562.0000, 6, 31.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 104, 588.6400, 5, 31.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 106, 239.0900, 4, 31.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 116, 14.6400, 10, 31.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 143, 280.3600, 2, 31.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (62, 177, 634.4500, 4, 32)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 47, 619.7300, 10, 32.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 67, 728.1800, 7, 32.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 73, 693.8200, 9, 32.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 80, 839.7300, 7, 32.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 109, 482.4500, 6, 32.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 133, 289.7300, 5, 32.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (63, 162, 535.6400, 2, 32.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (64, 21, 253.3600, 2, 32.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (64, 25, 190.6400, 8, 32.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 5, 646.0900, 4, 33)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 30, 348.0000, 5, 33.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 48, 471.4500, 7, 33.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 59, 714.8200, 7, 33.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 117, 594.1800, 9, 33.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 145, 402.4500, 10, 33.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 166, 264.6400, 8, 33.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (65, 180, 95.4500, 3, 33.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (66, 55, 556.9100, 6, 33.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (66, 59, 454.7300, 4, 33.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (66, 159, 470.1800, 4, 34)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (66, 163, 439.0900, 2, 34.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (67, 3, 596.0900, 4, 34.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (67, 28, 392.6400, 7, 34.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (68, 13, 329.3600, 4, 34.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (68, 43, 30.4500, 5, 34.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (68, 49, 373.3600, 10, 34.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (68, 149, 293.3600, 6, 34.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (68, 173, 739.1800, 3, 34.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (69, 73, 124.0000, 9, 34.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (69, 174, 556.1800, 9, 35)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 15, 82.5500, 3, 35.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 30, 695.0000, 4, 35.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 39, 511.1800, 8, 35.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 47, 385.6400, 3, 35.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 72, 820.7300, 2, 35.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (70, 145, 202.6400, 7, 35.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (71, 34, 227.2700, 7, 35.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (71, 44, 113.3600, 1, 35.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (71, 45, 125.8200, 2, 35.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (71, 100, 844.0000, 9, 36)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 6, 27.9100, 7, 36.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 28, 649.1800, 6, 36.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 63, 599.3600, 9, 36.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 90, 608.4500, 3, 36.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 92, 227.8200, 3, 36.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 100, 117.8200, 4, 36.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 123, 217.1800, 5, 36.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (72, 138, 552.3600, 5, 36.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (73, 118, 100.6400, 9, 36.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 13, 284.0900, 9, 37)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 15, 441.2700, 9, 37.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 95, 493.1800, 6, 37.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 114, 655.0000, 5, 37.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 127, 272.0000, 8, 37.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 167, 99.0900, 10, 37.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (74, 169, 495.4500, 4, 37.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (75, 99, 272.4500, 4, 37.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (75, 127, 351.8200, 1, 37.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (75, 172, 569.6400, 5, 37.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 47, 328.2700, 8, 38)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 79, 589.8200, 5, 38.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 118, 419.8200, 6, 38.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 138, 886.8200, 6, 38.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 166, 828.1800, 1, 38.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (76, 167, 626.0900, 1, 38.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 3, 743.2700, 2, 38.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 11, 731.6400, 2, 38.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 33, 561.9100, 5, 38.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 35, 663.8200, 2, 38.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 70, 650.9100, 6, 39)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (77, 181, 235.1800, 9, 39.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 61, 216.2700, 3, 39.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 109, 734.2700, 4, 39.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 124, 610.5500, 6, 39.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 159, 58.4500, 7, 39.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 173, 217.2700, 5, 39.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (78, 174, 605.0900, 1, 39.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (79, 154, 801.0900, 6, 39.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (80, 111, 369.9100, 10, 39.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (80, 154, 616.0000, 6, 40)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (81, 69, 715.4500, 5, 40.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (81, 71, 49.6400, 7, 40.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (81, 165, 425.6400, 4, 40.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 4, 338.1800, 3, 40.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 55, 334.2700, 2, 40.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 99, 839.8200, 10, 40.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 115, 233.0000, 6, 40.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 116, 468.7300, 5, 40.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (82, 122, 855.6400, 3, 40.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 8, 347.5500, 10, 41)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 23, 570.0000, 6, 41.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 40, 132.3600, 4, 41.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 86, 310.8200, 10, 41.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 114, 305.9100, 3, 41.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 128, 403.0000, 3, 41.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (83, 177, 90.9100, 5, 41.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (84, 14, 903.2700, 7, 41.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (84, 88, 74.0000, 1, 41.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (84, 116, 657.1800, 7, 41.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (84, 130, 385.7300, 1, 42)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 17, 264.7300, 3, 42.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 26, 504.3600, 8, 42.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 35, 489.3600, 9, 42.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 46, 121.6400, 3, 42.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 81, 463.3600, 1, 42.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 107, 698.9100, 2, 42.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 132, 249.1800, 10, 42.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (85, 164, 49.9100, 6, 42.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (86, 30, 852.5500, 10, 42.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (86, 168, 738.1800, 9, 43)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (87, 57, 477.5500, 9, 43.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (87, 148, 75.2700, 8, 43.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (87, 167, 309.0000, 6, 43.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (87, 179, 445.8200, 8, 43.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 47, 163.1800, 8, 43.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 80, 88.4500, 6, 43.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 92, 11.2700, 4, 43.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 100, 134.0000, 7, 43.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 157, 458.0900, 8, 43.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (88, 177, 212.0000, 5, 44)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (89, 21, 559.8200, 5, 44.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (89, 56, 640.3600, 7, 44.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (90, 20, 592.0000, 2, 44.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (90, 25, 208.8200, 8, 44.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (90, 101, 201.6400, 10, 44.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (90, 114, 569.2700, 3, 44.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 10, 28.1800, 9, 44.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 25, 277.3600, 10, 44.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 70, 98.3600, 8, 44.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 86, 844.0900, 4, 45)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 124, 455.8200, 4, 45.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (91, 138, 668.5500, 8, 45.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 11, 558.5500, 2, 45.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 26, 532.3600, 10, 45.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 117, 174.4500, 10, 45.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 118, 644.4500, 4, 45.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 124, 729.0000, 2, 45.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 168, 513.0000, 10, 45.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (92, 176, 717.5500, 9, 45.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (93, 18, 217.9100, 2, 46)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (93, 29, 783.5500, 6, 46.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (93, 96, 524.8200, 6, 46.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (93, 161, 59.6400, 9, 46.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (94, 10, 80.2700, 7, 46.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (94, 25, 781.3600, 6, 46.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (94, 27, 618.0900, 6, 46.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (94, 29, 783.0900, 10, 46.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (95, 48, 399.0000, 9, 46.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (95, 81, 858.0900, 5, 46.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (95, 87, 228.5500, 2, 47)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (95, 149, 852.3600, 4, 47.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 1, 16.0900, 1, 47.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 9, 329.9100, 10, 47.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 15, 900.4500, 3, 47.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 65, 600.5500, 8, 47.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 143, 297.3600, 8, 47.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 146, 738.0000, 8, 47.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (96, 165, 377.5500, 10, 47.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 7, 678.4500, 10, 47.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 28, 514.3600, 2, 48)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 31, 308.5500, 5, 48.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 79, 209.6400, 10, 48.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 104, 149.6400, 10, 48.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 129, 150.7300, 3, 48.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (97, 150, 171.3600, 1, 48.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 18, 751.4500, 8, 48.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 32, 714.8200, 4, 48.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 49, 392.0900, 7, 48.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 59, 533.6400, 3, 48.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 70, 552.0000, 10, 49)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (98, 111, 174.1800, 9, 49.1)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (99, 142, 737.4500, 4, 49.2)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (99, 151, 664.0000, 10, 49.3)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (99, 170, 648.7300, 1, 49.4)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 31, 344.9100, 2, 49.5)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 46, 401.9100, 3, 49.6)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 66, 197.0000, 8, 49.7)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 99, 354.4500, 7, 49.8)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 102, 230.2700, 3, 49.9)
GO
INSERT [dbo].[Orden Detalles] ([OrdenID], [ProductoID], [ProductoPrecioUnitario], [Cantidad], [Descuento]) VALUES (100, 104, 29.9100, 4, 50)
GO
SET IDENTITY_INSERT [dbo].[Ordenes] ON 
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (1, CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'Pendiente ', 0, 1)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (2, CAST(N'2022-01-25T00:00:00.000' AS DateTime), N'Enviado   ', 0, 2)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (3, CAST(N'2020-12-07T00:00:00.000' AS DateTime), N'Enviado   ', 0, 3)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (4, CAST(N'2021-03-10T00:00:00.000' AS DateTime), N'Enviado   ', 0, 4)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (5, CAST(N'2021-08-05T00:00:00.000' AS DateTime), N'Enviado   ', 0, 5)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (6, CAST(N'2022-05-15T00:00:00.000' AS DateTime), N'Pendiente ', 0, 6)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (7, CAST(N'2021-05-18T00:00:00.000' AS DateTime), N'Completado', 0, 7)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (8, CAST(N'2020-07-21T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 8)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (9, CAST(N'2021-02-21T00:00:00.000' AS DateTime), N'Pendiente ', 0, 9)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (10, CAST(N'2021-03-23T00:00:00.000' AS DateTime), N'Completado', 0, 10)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (11, CAST(N'2021-06-05T00:00:00.000' AS DateTime), N'Completado', 0, 11)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (12, CAST(N'2020-07-04T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 12)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (13, CAST(N'2020-02-15T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 13)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (14, CAST(N'2020-07-28T00:00:00.000' AS DateTime), N'Completado', 0, 14)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (15, CAST(N'2020-03-26T00:00:00.000' AS DateTime), N'Pendiente ', 0, 15)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (16, CAST(N'2020-01-02T00:00:00.000' AS DateTime), N'Enviado   ', 0, 16)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (17, CAST(N'2021-01-04T00:00:00.000' AS DateTime), N'Enviado   ', 0, 17)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (18, CAST(N'2020-04-13T00:00:00.000' AS DateTime), N'Enviado   ', 0, 18)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (19, CAST(N'2021-12-25T00:00:00.000' AS DateTime), N'Pendiente ', 0, 19)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (20, CAST(N'2021-07-03T00:00:00.000' AS DateTime), N'Enviado   ', 0, 20)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (21, CAST(N'2021-07-15T00:00:00.000' AS DateTime), N'Pendiente ', 0, 21)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (22, CAST(N'2020-11-26T00:00:00.000' AS DateTime), N'Pendiente ', 0, 22)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (23, CAST(N'2021-06-07T00:00:00.000' AS DateTime), N'Pendiente ', 0, 23)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (24, CAST(N'2020-10-01T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 24)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (25, CAST(N'2021-09-22T00:00:00.000' AS DateTime), N'Completado', 0, 25)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (26, CAST(N'2021-07-22T00:00:00.000' AS DateTime), N'Enviado   ', 0, 26)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (27, CAST(N'2020-03-18T00:00:00.000' AS DateTime), N'Enviado   ', 0, 27)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (28, CAST(N'2020-11-02T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 28)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (29, CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'Pendiente ', 0, 29)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (30, CAST(N'2022-01-13T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 30)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (31, CAST(N'2021-07-04T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 31)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (32, CAST(N'2021-10-17T00:00:00.000' AS DateTime), N'Enviado   ', 0, 32)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (33, CAST(N'2020-09-22T00:00:00.000' AS DateTime), N'Completado', 0, 33)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (34, CAST(N'2020-02-11T00:00:00.000' AS DateTime), N'Enviado   ', 0, 34)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (35, CAST(N'2021-03-19T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 35)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (36, CAST(N'2021-07-18T00:00:00.000' AS DateTime), N'Completado', 0, 36)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (37, CAST(N'2021-08-02T00:00:00.000' AS DateTime), N'Completado', 0, 37)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (38, CAST(N'2020-08-21T00:00:00.000' AS DateTime), N'Completado', 0, 38)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (39, CAST(N'2020-02-26T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 39)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (40, CAST(N'2022-03-19T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 40)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (41, CAST(N'2021-05-09T00:00:00.000' AS DateTime), N'Completado', 0, 41)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (42, CAST(N'2020-08-29T00:00:00.000' AS DateTime), N'Pendiente ', 0, 42)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (43, CAST(N'2021-11-16T00:00:00.000' AS DateTime), N'Pendiente ', 0, 43)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (44, CAST(N'2020-05-22T00:00:00.000' AS DateTime), N'Completado', 0, 44)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (45, CAST(N'2022-01-08T00:00:00.000' AS DateTime), N'Completado', 0, 45)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (46, CAST(N'2021-08-01T00:00:00.000' AS DateTime), N'Enviado   ', 0, 46)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (47, CAST(N'2020-09-09T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 47)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (48, CAST(N'2020-10-02T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 48)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (49, CAST(N'2021-12-05T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 49)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (50, CAST(N'2021-04-08T00:00:00.000' AS DateTime), N'Completado', 0, 50)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (51, CAST(N'2021-03-07T00:00:00.000' AS DateTime), N'Completado', 0, 51)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (52, CAST(N'2020-03-09T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 52)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (53, CAST(N'2020-09-27T00:00:00.000' AS DateTime), N'Enviado   ', 0, 53)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (54, CAST(N'2021-08-22T00:00:00.000' AS DateTime), N'Completado', 0, 54)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (55, CAST(N'2020-08-04T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 55)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (56, CAST(N'2021-08-12T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 56)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (57, CAST(N'2021-03-07T00:00:00.000' AS DateTime), N'Pendiente ', 0, 57)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (58, CAST(N'2021-10-05T00:00:00.000' AS DateTime), N'Enviado   ', 0, 58)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (59, CAST(N'2021-06-12T00:00:00.000' AS DateTime), N'Completado', 0, 59)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (60, CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'Pendiente ', 0, 60)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (61, CAST(N'2020-12-30T00:00:00.000' AS DateTime), N'Enviado   ', 0, 61)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (62, CAST(N'2022-01-19T00:00:00.000' AS DateTime), N'Completado', 0, 62)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (63, CAST(N'2021-11-23T00:00:00.000' AS DateTime), N'Completado', 0, 63)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (64, CAST(N'2021-06-29T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 64)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (65, CAST(N'2020-07-03T00:00:00.000' AS DateTime), N'Pendiente ', 0, 65)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (66, CAST(N'2022-05-27T00:00:00.000' AS DateTime), N'Pendiente ', 0, 66)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (67, CAST(N'2020-08-03T00:00:00.000' AS DateTime), N'Pendiente ', 0, 67)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (68, CAST(N'2021-08-31T00:00:00.000' AS DateTime), N'Completado', 0, 68)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (69, CAST(N'2020-03-11T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 69)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (70, CAST(N'2022-03-06T00:00:00.000' AS DateTime), N'Enviado   ', 0, 70)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (71, CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'Completado', 0, 71)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (72, CAST(N'2020-05-10T00:00:00.000' AS DateTime), N'Pendiente ', 0, 72)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (73, CAST(N'2021-08-17T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 73)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (74, CAST(N'2022-05-29T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 74)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (75, CAST(N'2020-11-09T00:00:00.000' AS DateTime), N'Completado', 0, 75)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (76, CAST(N'2021-07-14T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 76)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (77, CAST(N'2020-01-20T00:00:00.000' AS DateTime), N'Completado', 0, 77)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (78, CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'Completado', 0, 78)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (79, CAST(N'2022-06-14T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 79)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (80, CAST(N'2021-11-07T00:00:00.000' AS DateTime), N'Completado', 0, 80)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (81, CAST(N'2020-10-18T00:00:00.000' AS DateTime), N'Completado', 0, 81)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (82, CAST(N'2020-06-03T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 82)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (83, CAST(N'2020-06-02T00:00:00.000' AS DateTime), N'Pendiente ', 0, 83)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (84, CAST(N'2021-03-15T00:00:00.000' AS DateTime), N'Completado', 0, 84)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (85, CAST(N'2021-05-25T00:00:00.000' AS DateTime), N'Completado', 0, 85)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (86, CAST(N'2021-05-18T00:00:00.000' AS DateTime), N'Pendiente ', 0, 86)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (87, CAST(N'2021-12-07T00:00:00.000' AS DateTime), N'Pendiente ', 0, 87)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (88, CAST(N'2022-05-23T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 88)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (89, CAST(N'2021-10-20T00:00:00.000' AS DateTime), N'Enviado   ', 0, 89)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (90, CAST(N'2021-10-22T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 90)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (91, CAST(N'2020-01-24T00:00:00.000' AS DateTime), N'Pendiente ', 0, 91)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (92, CAST(N'2020-09-16T00:00:00.000' AS DateTime), N'Completado', 0, 92)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (93, CAST(N'2021-09-16T00:00:00.000' AS DateTime), N'Enviado   ', 0, 93)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (94, CAST(N'2020-11-25T00:00:00.000' AS DateTime), N'Completado', 0, 94)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (95, CAST(N'2020-04-11T00:00:00.000' AS DateTime), N'Pendiente ', 0, 95)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (96, CAST(N'2021-10-14T00:00:00.000' AS DateTime), N'Pendiente ', 0, 96)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (97, CAST(N'2020-07-18T00:00:00.000' AS DateTime), N'Pendiente ', 0, 97)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (98, CAST(N'2020-06-23T00:00:00.000' AS DateTime), N'Pendiente ', 0, 98)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (99, CAST(N'2022-03-29T00:00:00.000' AS DateTime), N'Enviado   ', 0, 99)
GO
INSERT [dbo].[Ordenes] ([OrdenID], [OrdenFecha], [OrdenEstado], [OrdenEliminada], [EmpleadoID]) VALUES (100, CAST(N'2021-09-13T00:00:00.000' AS DateTime), N'Aprobado  ', 0, 100)
GO
SET IDENTITY_INSERT [dbo].[Ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (1, N'Archivadores de cartón', N'Archivadores de cartón', NULL, 181.0900, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (2, N'Archivadores de plástico', N'Archivadores de plástico', NULL, 157.2700, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (3, N'Archivadores ecológicos', N'Archivadores ecológicos', NULL, 170.6400, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (4, N'Cajetines para archivadores', N'Cajetines para archivadores', NULL, 105.0000, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (5, N'Complementos para archivadores', N'Complementos para archivadores', NULL, 103.2700, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (6, N'Separadores de pestañas', N'Separadores de pestañas', NULL, 156.0000, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (7, N'Carpetas de cartón marrón de dos anillas', N'Carpetas de cartón marrón de dos anillas', NULL, 150.1800, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (8, N'Carpetas de cartón marrón cuero de cuatr', N'Carpetas de cartón marrón cuero de cuatro anillas', NULL, 113.2700, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (9, N'Carpetas de colores Exacompta con 2 anil', N'Carpetas de colores Exacompta con 2 anillas', NULL, 143.6400, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (10, N'Carpetas Exacompta polipropileno 4 anill', N'Carpetas Exacompta polipropileno 4 anillas', NULL, 133.8200, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (11, N'Carpeta de 4 anillas redondas de 25 mm e', N'Carpeta de 4 anillas redondas de 25 mm en tamaño cuarto de colores surtidos', NULL, 146.0900, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (12, N'Carpetas de dos anillas formato Din A4', N'Carpetas de dos anillas formato Din A4', NULL, 165.4500, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (13, N'Carpetas folio 2 anillas con lomo liso', N'Carpetas folio 2 anillas con lomo liso', NULL, 94.8200, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (14, N'Carpetas folio 2 anillas con lomo liso', N'Carpetas folio 2 anillas con lomo liso', NULL, 175.0000, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (15, N'Carpetas con 2 anillas pequeñas de 15 mm', N'Carpetas con 2 anillas pequeñas de 15 mm', NULL, 180.4500, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (16, N'Carpetas de dos anillas folio con ollao ', N'Carpetas de dos anillas folio con ollao y compresor', NULL, 179.5500, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (17, N'Carpetas de cuatro anillas formato Folio', N'Carpetas de cuatro anillas formato Folio', NULL, 171.1800, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (18, N'Carpeta de dos anillas mixtas de 25 mm D', N'Carpeta de dos anillas mixtas de 25 mm Din A4 transparente', NULL, 100.5500, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (19, N'Carpetas con tarjetero de 4 anillas', N'Carpetas con tarjetero de 4 anillas', NULL, 151.2700, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (20, N'Carpetas A4 PVC, cuatro anillas mixtas', N'Carpetas A4 PVC, cuatro anillas mixtas', NULL, 92.3600, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (21, N'Carpeta roja A4 de dos anillas de 25 mm ', N'Carpeta roja A4 de dos anillas de 25 mm con bolsa, tarjetero y ribete negro', NULL, 114.9100, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (22, N'Carpetas A5, dos o cuatro anillas', N'Carpetas A5, dos o cuatro anillas', NULL, 111.2700, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (23, N'Carpetas Folio, cuatro anillas redondas', N'Carpetas Folio, cuatro anillas redondas', NULL, 134.3600, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (24, N'Carpeta para papel continuo Elba de 10 p', N'Carpeta para papel continuo Elba de 10 pulgadas (250 mm)', NULL, 131.9100, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (25, N'Carpetas con fundas de plástico fijas o ', N'Carpetas con fundas de plástico fijas o móviles', NULL, 150.0900, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (26, N'Carpetas de proyectos', N'Carpetas de proyectos', NULL, 117.7300, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (27, N'Carpetas colgantes', N'Carpetas colgantes', NULL, 169.4500, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (28, N'Sobres de plástico con cierre de cremall', N'Sobres de plástico con cierre de cremallera, velcro o broche', NULL, 175.1800, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (29, N'Maletines clasificadores portadocumentos', N'Maletines clasificadores portadocumentos', NULL, 91.0000, 0, 1, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (30, N'Milan 445, goma de borrar blanda', N'Tipo miga de pan', NULL, 13.8200, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (31, N'Milan 430, goma de borrar suave, miga de', N'Muy blanda. Verde, blanca o rosa', NULL, 12.6400, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (32, N'Milan Nata 624, goma de borrar compacta', N'Con celofán protector de color rosa', NULL, 21.6400, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (33, N'Milan 420, goma de borrar', N'Milan 420, goma de borrar', NULL, 21.2700, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (34, N'Gomas de borrar escolares para lápiz', N'Gomas de borrar escolares para lápiz', NULL, 21.0000, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (35, N'Goma para borrar lápiz Liderpapel 40x20x', N'Goma para borrar lápiz Liderpapel 40x20x12 mm', NULL, 12.9100, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (36, N'Faber-Castell, goma de borrar sin PVC', N'Faber-Castell, goma de borrar sin PVC', NULL, 17.9100, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (37, N'Milan Nata 612, goma de borrar con bisel', N'Milan Nata 612, goma de borrar con bisel', NULL, 11.2700, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (38, N'Staedtler Noris 526 B30, goma de borrar ', N'Staedtler Noris 526 B30, goma de borrar rasoplast', NULL, 9.5500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (39, N'Staedtler Rasoplast, borrador compacto p', N'La versión dura de Mars Plastic', NULL, 25.5500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (40, N'Staedtler Mars Plastic 526 50, goma de b', N'Para uso escolar y dibujo técnico', NULL, 20.1800, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (41, N'Faber-Castell Perfection 7058, lápiz bor', N'Para borrar tinta china. Con pincel integrado', NULL, 13.3600, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (42, N'Goma Maped Duo para grafito y bolígrafo ', N'Goma Maped Duo para grafito y bolígrafo borrable', NULL, 18.4500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (43, N'Milan 403, goma de borrar gigante', N'Milan 403, goma de borrar gigante', NULL, 16.4500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (44, N'Portagomas Staedtler Mars plastic', N'Portagomas retráctil para dibujo técnico', NULL, 14.5500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (45, N'Portagomas Tombow para goma rectangular ', N'Portagomas Tombow para goma rectangular 2.5 × 5 mm', NULL, 9.4500, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (46, N'Portagomas Tombow para goma cilíndrica d', N'Portagomas Tombow para goma cilíndrica de 2.3 mm', NULL, 24.3600, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (47, N'Recambio portagomas Staedtler Mars', N'Bolsa de 10 gomas de repuesto', NULL, 19.1800, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (48, N'Maped, caja 18 gomas de borrar para carb', N'Maped, caja 18 gomas de borrar para carboncillo', NULL, 9.3600, 0, 2, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (49, N'Correctores', N'Correctores', NULL, 80.7300, 0, 3, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (50, N'Gomas de borrar', N'Gomas de borrar', NULL, 76.6400, 0, 3, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (51, N'Tijeras de oficina', N'Tijeras de oficina', NULL, 876.5500, 0, 4, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (52, N'Cúter y bisturí de precisión', N'Cúter y bisturí de precisión', NULL, 328.6400, 0, 4, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (53, N'Guillotinas para cortar fotos, papel y c', N'Guillotinas para cortar fotos, papel y cartulina', NULL, 732.0000, 0, 4, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (54, N'Cizallas de papel', N'Cizallas de papel', NULL, 450.0900, 0, 4, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (55, N'Corte en tiras 6 mm. Seguridad P1', N'Corte en tiras 6 mm. Seguridad P1', NULL, 1694.6400, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (56, N'Rexel Alpha, destructora 5 h., 10 l', N'Para uso personal. 5 hojas. 10 litros', NULL, 1728.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (57, N'Q6CC2, destructora corte en partículas', N'Destructora personal 6 hojas / 11 litros', NULL, 3952.5500, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (58, N'Fellowes 36C, destructora de papel', N'Ciclo de trabajo de 2 minutos', NULL, 3573.0000, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (59, N'HSM Shredstar x5, destructora compacta, ', N'Silenciosa, ideal para el hogar y pequeñas oficinas', NULL, 2473.6400, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (60, N'KF17972, destructora 8 h. y 15 l', N'Destructora económica para uso personal', NULL, 1495.5500, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (61, N'Rexel Prostyle+5, destructora 5 h. y 7.5', N'Tritura hasta 5 folios. Papelera de 7.5 litros', NULL, 1518.0000, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (62, N'KF17974, destructora hasta 10 h.', N'Papelera con ventana de nivel', NULL, 3092.4500, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (63, N'Rexel Duo, destructora grafito 10 h.', N'Trituradora silenciosa perfecta para casa', NULL, 2189.0000, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (64, N'HSM Shredstar x10, trituradora de 20 l', N'Destruye hasta 10 hojas. 20 litros de capacidad', NULL, 2133.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (65, N'HSM Shredstar x8, destructora 8 h.', N'8 hojas, partículas 4.5x30 mm, 18 litros', NULL, 2090.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (66, N'Fellowes 53C, destructora de papel 10 h.', N'La trituradora ideal para particulares', NULL, 1609.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (67, N'Destructora Q-Connect KF15551, 12 hojas', N'Con ranura independiente para CD', NULL, 1585.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (68, N'Trituradora de papel KF15547 hasta 8h', N'Trituradora de papel KF15547 hasta 8h', NULL, 3899.6400, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (69, N'Destructora Rexel Prostyle+ 12', N'Destrucción simultánea de 12 hojas', NULL, 3906.5500, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (70, N'Destructora antiatascos de 12 h', N'Papelera de 14 litros, con ruedas', NULL, 2822.3600, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (71, N'HSM Shredstar x13, trituradora 13 h.', N'Hasta 13 hojas y 23 litros de papelera. Din P-4', NULL, 3654.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (72, N'HSM Shredstar X15, destructora 15 h.', N'Alto rendimiento. 15 hojas. Partícula 4x37 mm', NULL, 3648.2700, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (73, N'Fellowes PS-79CI, destructora 14 h.', N'Fellowes PS-79CI, destructora 14 h.', NULL, 2112.2700, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (74, N'Fellowes 92CS, destructora 18 h.', N'18 Hojas. Partículas de 4x38 mm', NULL, 2401.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (75, N'Destructora potente para uso intensivo, ', N'Destructora potente para uso intensivo, hasta 20 h, 26 litros', NULL, 2248.2700, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (76, N'Fellowes 99ci', N'Con tecnología antiatascos 100% efectiva', NULL, 2482.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (77, N'Fellowes 1050HS, destructora alta seguri', N'Destruye un A4 en 15.000 micropartículas', NULL, 2313.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (78, N'Fellowes 3250mc', N'Fellowes 3250mc', NULL, 2345.8200, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (79, N'Fellowes 425ci', N'Fellowes 425ci', NULL, 4525.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (80, N'Aceite lubricante para destructoras 350 ', N'Para el mantenimiento de las cuchillas de corte', NULL, 3206.1800, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (81, N'Hojas lubricantes para destructoras', N'Hojas lubricantes para destructoras', NULL, 3123.8200, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (82, N'50 Bolsas para destructoras 94 litros', N'Para destructoras Fellowes', NULL, 4530.9100, 0, 5, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (83, N'Encuadernadora multifunción Fellowes Lyr', N'Grapa, perfora y encuaderna', NULL, 1701.4500, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (84, N'Alicate para encuadernar con espiral', N'Para cortar y doblar el extremo de la espiral', NULL, 1263.5500, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (85, N'Fellowes Star+ 150', N'Encuaderna hasta 150 hojas con canutillo plástico', NULL, 1771.8200, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (86, N'Fellowes Metal 25 — Encuadernadora espir', N'Fellowes Metal 25 — Encuadernadora espiral', NULL, 1093.7300, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (87, N'Encuadernadora espiral Q-Connect 450 hoj', N'Capacidad perforación de 10 hojas', NULL, 1677.6400, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (88, N'Fellowes Metal 50, encuadernadora espira', N'Regulación margen. 12 hojas. Cuadernos hasta 450h', NULL, 1213.7300, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (89, N'Fellowes Pulsar+ 300, encuadernadora de ', N'Encuaderna hasta 300 hojas A4 de 80 gr.', NULL, 1764.0900, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (90, N'Yosan, Encuadernadora de espiral, 450 ho', N'Máquina de encuadernar de alta capacidad', NULL, 999.0000, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (91, N'Fellowes metal 50R — Encuadernadora espi', N'Fellowes metal 50R — Encuadernadora espiral con insertador', NULL, 947.2700, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (92, N'Encuadernadora Wire Fellowes Quasar', N'Para canutillos Wire y 130 hojas A4', NULL, 1081.1800, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (93, N'GBC C200E, encuadernadora eléctrica', N'GBC C200E, encuadernadora eléctrica', NULL, 1060.0900, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (94, N'Fellowes Metal 100 para espiral metálica', N'Perfora hasta 20 hojas y encuaderna 450', NULL, 1419.7300, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (95, N'GBC Coilbind P59 — Encuadernadora de esp', N'GBC Coilbind P59 — Encuadernadora de espiral', NULL, 952.7300, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (96, N'Leitz Impressbind 280, encuadernadora de', N'Encuadernadora presión channel', NULL, 1359.5500, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (97, N'Yosan P164, encuadernadora eléctrica', N'Con pedal. Alto rendimiento. Manos libres', NULL, 1196.9100, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (98, N'Fellowes E200R, encuadernadora eléctrica', N'Máquina de encuadernar con pedal automático', NULL, 1495.2700, 0, 6, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (99, N'Plumas estilográficas', N'Plumas estilográficas', NULL, 23.7300, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (100, N'Bolígrafos baratos', N'Bolígrafos baratos', NULL, 44.0000, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (101, N'Bolígrafos Bic', N'Bolígrafos Bic', NULL, 32.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (102, N'Bolígrafos borrables', N'Bolígrafos borrables', NULL, 12.8200, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (103, N'Bolígrafos con base', N'Bolígrafos con base', NULL, 39.8200, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (104, N'Bolígrafos Paper Mate', N'Bolígrafos Paper Mate', NULL, 27.2700, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (105, N'Bolígrafos Pentel', N'Bolígrafos Pentel', NULL, 16.2700, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (106, N'Bolígrafos Pilot', N'Bolígrafos Pilot', NULL, 30.3600, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (107, N'Bolígrafos Stabilo', N'Bolígrafos Stabilo', NULL, 42.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (108, N'Bolígrafos uni-ball', N'Bolígrafos uni-ball', NULL, 30.9100, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (109, N'Recambios para bolígrafos', N'Recambios para bolígrafos', NULL, 33.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (110, N'Bolígrafo BIC Cristal', N'Bolígrafo BIC Cristal', NULL, 24.3600, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (111, N'Marcadores fluorescentes', N'Marcadores fluorescentes', NULL, 44.7300, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (112, N'Rotuladores calibrados', N'Rotuladores calibrados', NULL, 10.7300, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (113, N'Rotuladores de billetes', N'Rotuladores de billetes', NULL, 35.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (114, N'Rotuladores Edding', N'Rotuladores Edding', NULL, 41.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (115, N'Rotuladores especiales', N'Rotuladores especiales', NULL, 28.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (116, N'Rotuladores flipchart', N'Rotuladores flipchart', NULL, 14.0900, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (117, N'Rotuladores para pizarras', N'Rotuladores para pizarras', NULL, 35.7300, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (118, N'Rotuladores permanentes', N'Rotuladores permanentes', NULL, 13.0000, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (119, N'Rotuladores pizarra vidrio', N'Rotuladores pizarra vidrio', NULL, 44.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (120, N'Rotuladores punta dura', N'Rotuladores punta dura', NULL, 22.3600, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (121, N'Rotuladores Q-Connect', N'Rotuladores Q-Connect', NULL, 36.7300, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (122, N'Rotuladores Stabilo', N'Rotuladores Stabilo', NULL, 40.0000, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (123, N'Rotuladores Staedtler', N'Rotuladores Staedtler', NULL, 26.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (124, N'Marcadores fluorescentes', N'Marcadores fluorescentes', NULL, 42.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (125, N'Lápices de grafito', N'Lápices de grafito', NULL, 24.4500, 0, 7, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (126, N'Pizarras blancas', N'Pizarras blancas', NULL, 2009.8200, 0, 8, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (127, N'Pizarras para tiza', N'Pizarras para tiza', NULL, 1865.3600, 0, 8, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (128, N'Rotuladores borrables en seco para pizar', N'Rotuladores borrables en seco para pizarras', NULL, 1212.4500, 0, 8, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (129, N'Clavadoras', N'Clavadoras', NULL, 537.6400, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (130, N'Grapadoras de bolsillo', N'Grapadoras de bolsillo', NULL, 460.2700, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (131, N'Grapadoras de brazo largo', N'Grapadoras de brazo largo', NULL, 557.2700, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (132, N'Grapadoras de escritorio', N'Grapadoras de escritorio', NULL, 590.5500, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (133, N'Grapadoras de gruesos', N'Grapadoras de gruesos', NULL, 237.3600, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (134, N'Grapadoras de tenaza', N'Grapadoras de tenaza', NULL, 601.0900, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (135, N'Grapadoras El Casco', N'Grapadoras El Casco', NULL, 190.1800, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (136, N'Grapadoras eléctricas', N'Grapadoras eléctricas', NULL, 439.5500, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (137, N'Grapadoras de bolsillo', N'Grapadoras de bolsillo', NULL, 352.5500, 0, 9, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (138, N'Impresora térmica Safescan TP-230', N'Competente impresora térmica de alta velocidad (60 mm/s) conectable a las contadoras de dinero Safescan para imprimir completos reportes que detallan la suma total de dinero contado y un balance individual de cada denominación.', NULL, 1683.4500, 0, 10, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (139, N'Pizarras y tableros de anuncios de corch', N'Pizarras y tableros de anuncios de corcho', NULL, 13.1800, 0, 11, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (140, N'Chinchetas cortas de latón o acero', N'Chinchetas cortas de latón o acero', NULL, 13.6400, 0, 11, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (141, N'Agujas de señalización para mapas y plan', N'Agujas de señalización para mapas y planos', NULL, 31.0000, 0, 11, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (142, N'Perforadora de papel para 10 hojas', N'La más barata', NULL, 1503.8200, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (143, N'Perforador de papel barato 20 hojas', N'Colores: azul, rojo o negro', NULL, 1385.8200, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (144, N'Taladro con regleta deslizante para 27 h', N'Perforadora negra con abertura de 2.7 mm', NULL, 298.7300, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (145, N'Perforadora con base y empuñadura antide', N'Taladra 20 o 30 hojas (según modelo)', NULL, 1320.3600, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (146, N'Taladradora Petrus 52 Retro', N'Para dar un toque vintage a la oficina', NULL, 1471.4500, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (147, N'Taladrado de papel Petrus 52', N'La Petrus 52 en su versión clásica', NULL, 591.2700, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (148, N'Perforadora metalizada Petrus 52 WoW', N'El taladro original de Petrus, metalizado', NULL, 407.8200, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (149, N'Perforadora de papel Maped Essentials Me', N'Una de las 4-taladros más baratas', NULL, 543.3600, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (150, N'Perforadora económica de papel de 4 tala', N'Taladro económico de 4 agujeros', NULL, 461.9100, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (151, N'Taladro Maped Essentials para 45 hojas', N'Con base antideslizante', NULL, 1657.3600, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (152, N'Petrus 62 Wow en cuatro colores metaliza', N'Grapa 10 hojas más que la Petrus 52', NULL, 359.5500, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (153, N'Taladradora de papel Petrus 65', N'La versión actual de la mítica Petrus', NULL, 795.0900, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (154, N'Taladradora Petrus 95 Negro', N'Punzones ultrafilados, para 40 hojas', NULL, 1050.9100, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (155, N'Perforadora de papel Maped Easy 65 h', N'Ergonómica, perfora sin apenas esfuerzo', NULL, 667.6400, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (156, N'Taladradora de oficina Q-Connect KF01237', N'Perfora hasta 65 hojas', NULL, 1513.0000, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (157, N'Taladro Novus B270 para 70 h', N'Taladro profesional de oficina de magnesio', NULL, 349.7300, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (158, N'Taladradora Rapid HDC65', N'Gris y naranja. Perfora hasta 65 hojas', NULL, 805.9100, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (159, N'Perforadora de gran capacidad KF18766', N'Capacidad de perforación de hasta 100 hojas', NULL, 105.3600, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (160, N'Perforadora 4 punzones Petrus 505', N'Perforador de 4 agujeros de alta eficacia', NULL, 1068.0000, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (161, N'Taladradora Novus B2200 para 200 h', N'Una de las mejores en su categoría', NULL, 190.0900, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (162, N'Taladro con punzones móviles Petrus 514', N'Con distancia regulable entre sus punzones', NULL, 587.2700, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (163, N'Perforadora Maped Expert 150 alta capaci', N'Perfora sin esfuerzo hasta 15 mm de grosor (~150 h)', NULL, 739.8200, 0, 12, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (164, N'Pegamento de barra', N'Pegamento de barra', NULL, 118.0000, 0, 13, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (165, N'Rollos de celo', N'Rollos de celo', NULL, 97.0000, 0, 13, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (166, N'Dispensadores de celo', N'Dispensadores de celo', NULL, 194.2700, 0, 13, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (167, N'Plastificadora A4 de 2 rodillos', N'Ideal para uso doméstico. Muy barata', NULL, 4249.1800, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (168, N'Rollo para plastificadora Foton de 125 µ', N'Rollo para plastificadora Foton de 125 µ', NULL, 2683.4500, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (169, N'Rollo para plastificadora Foton de 75 µ', N'Rollo para plastificadora Foton de 75 µ', NULL, 4387.6400, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (170, N'Plastificadora de 75-125 micras A3', N'Plastificadora muy económica para Din A3', NULL, 6027.4500, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (171, N'Plastificadora Fellowes Pixel A4', N'Para fundas de 80 y 125 micras', NULL, 3258.0000, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (172, N'Plastificadora frío y caliente de 4 rodi', N'Plastificadora frío y caliente de 4 rodillos', NULL, 6620.9100, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (173, N'Plastificadora A3 Fellowes Pixel', N'Tiempo de calentamiento 3 minutos', NULL, 1741.4500, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (174, N'GBC Fusion 3000L A3', N'Para documentos de hasta 297x420 mm', NULL, 5997.6400, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (175, N'Plastificadora Fellowes Neptune A3', N'Plastificadora Fellowes Neptune A3', NULL, 959.7300, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (176, N'Plastificadora Fellowes Venus 2 A3', N'Plastificadora Fellowes Venus 2 A3', NULL, 5086.9100, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (177, N'Plastificadora automática GBC Foton 30', N'Plastificadora automática GBC Foton 30', NULL, 3738.0000, 0, 14, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (178, N'Plegadora de papel eléctrica Martin Yale', N'Plegadora de papel para formatos A4 y A5.', NULL, 6400.8200, 0, 15, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (179, N'Marcapáginas adhesivos', N'Marcapáginas adhesivos', NULL, 37.3600, 0, 16, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (180, N'Notas adhesivas baratas', N'Notas adhesivas baratas', NULL, 44.1800, 0, 16, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (181, N'Notas Post-It', N'Notas Post-It', NULL, 19.5500, 0, 16, 1)
GO
INSERT [dbo].[Productos] ([ProductoID], [ProductoNombre], [ProductoDescripcion], [ProductoCantidadPorUnidad], [ProductoPrecioUnitario], [ProductoDiscontinuado], [CategoriaID], [ProveedorID]) VALUES (183, N'TEST', N'Prueba', NULL, 0.0900, 0, 16, 1)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
INSERT [dbo].[Proveedores] ([ProveedorID], [ProveedorNombre], [ProveedorDireccionCalle], [ProveedorDireccionNumero], [ProveedorDireccionCiudad], [ProveedorTelefono], [ProveedorEmail], [ProveedorInactivo]) VALUES (1, N'Boreal Suminist', NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Roles] ([RolID], [RolNombre], [RolInactivo]) VALUES (1, N'Administrador de Sistemas
', 0)
GO
INSERT [dbo].[Roles] ([RolID], [RolNombre], [RolInactivo]) VALUES (2, N'Empleado de Departamento
', 0)
GO
INSERT [dbo].[Roles] ([RolID], [RolNombre], [RolInactivo]) VALUES (3, N'Jefe de Departamento
', 0)
GO
INSERT [dbo].[Roles] ([RolID], [RolNombre], [RolInactivo]) VALUES (4, N'Encargado de Compras
', 0)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Empleados]    Script Date: 23/03/2023 10:14:38 a. m. ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [IX_Empleados] UNIQUE NONCLUSTERED 
(
	[EmpleadoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_CategoriaInactiva]  DEFAULT ((0)) FOR [CategoriaInactiva]
GO
ALTER TABLE [dbo].[Departamentos] ADD  CONSTRAINT [DF_Departamentos_DepartamentoInactivo]  DEFAULT ((0)) FOR [DepartamentoInactivo]
GO
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF_Empleados_EmpleadoInactivo]  DEFAULT ((0)) FOR [EmpleadoInactivo]
GO
ALTER TABLE [dbo].[Orden Detalles] ADD  CONSTRAINT [DF_Orden Detalles_Descuento]  DEFAULT ((0)) FOR [Descuento]
GO
ALTER TABLE [dbo].[Ordenes] ADD  CONSTRAINT [DF_Ordenes_Estado]  DEFAULT ('Pendiente') FOR [OrdenEstado]
GO
ALTER TABLE [dbo].[Ordenes] ADD  CONSTRAINT [DF_Ordenes_OrdenEliminada]  DEFAULT ((0)) FOR [OrdenEliminada]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_ProductoDiscontinuado]  DEFAULT ((0)) FOR [ProductoDiscontinuado]
GO
ALTER TABLE [dbo].[Proveedores] ADD  CONSTRAINT [DF_Proveedores_ProveedorEliminado]  DEFAULT ((0)) FOR [ProveedorInactivo]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF_Roles_RolInactivo]  DEFAULT ((0)) FOR [RolInactivo]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Departamentos] FOREIGN KEY([DepartamentoID])
REFERENCES [dbo].[Departamentos] ([DepartamentoID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Departamentos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Roles] FOREIGN KEY([RolID])
REFERENCES [dbo].[Roles] ([RolID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Roles]
GO
ALTER TABLE [dbo].[Orden Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Orden Detalles_Ordenes] FOREIGN KEY([OrdenID])
REFERENCES [dbo].[Ordenes] ([OrdenID])
GO
ALTER TABLE [dbo].[Orden Detalles] CHECK CONSTRAINT [FK_Orden Detalles_Ordenes]
GO
ALTER TABLE [dbo].[Orden Detalles]  WITH CHECK ADD  CONSTRAINT [FK_Orden Detalles_Productos] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Productos] ([ProductoID])
GO
ALTER TABLE [dbo].[Orden Detalles] CHECK CONSTRAINT [FK_Orden Detalles_Productos]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Empleados] FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Empleados]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categorias] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categorias] ([CategoriaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Items_Categorias]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Items_Proveedores] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedores] ([ProveedorID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Items_Proveedores]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [CHK_OrdenEstado] CHECK  (([OrdenEstado]='Pendiente' OR [OrdenEstado]='Enviado' OR [OrdenEstado]='Completado' OR [OrdenEstado]='Aprobado'))
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [CHK_OrdenEstado]
GO
/****** Object:  StoredProcedure [dbo].[ABM_Categorias]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Categorias]
(
    @CategoriaID CHAR(4),
    @Nombre      VARCHAR(50),
    @Descripcion VARCHAR(MAX),
    @Instruccion NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Categorias
        (
            CategoriaID,
            Nombre,
            Descripcion
        )
        VALUES
        (
		    @CategoriaID,
			@Nombre,
			@Descripcion
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Categorias
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Categorias
        SET   Nombre      = @Nombre,
              Descripcion = @Descripcion
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Categorias
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Departamentos]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Departamentos]
(
    @DepartamentoID CHAR(4),
    @Nombre         VARCHAR(50),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Departamentos
        (
            DepartamentoID,
            Nombre
        )
        VALUES
        (
		    @DepartamentoID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Departamentos
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Departamentos
        SET   Nombre      = @Nombre
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Departamentos
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Empleados]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Empleados]
(
    @Legajo         INTEGER,
    @Nombre         VARCHAR(50),
	@Apellido       VARCHAR(50),
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50),
	@DepartamentoID CHAR(4),
	@RolID          CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Empleados
        (
            Legajo,
            Nombre,
	        Apellido,
	        Usuario,
	        Contraseña,
	        DepartamentoID,
	        RolID
        )
        VALUES
        (
		    @Legajo,
            @Nombre,
	        @Apellido,
	        @Usuario,
	        @Contraseña,
	        @DepartamentoID,
	        @RolID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Empleados
        WHERE Legajo = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Empleados
        SET    Nombre         = @Nombre,
	           Apellido       = @Apellido,
	           Usuario        = @Usuario,
	           Contraseña     = @Contraseña,
	           DepartamentoID = @DepartamentoID,
	           RolID          = @RolID
        WHERE Legajo          = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Empleados
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Items]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Items]
(
    @ItemID         INTEGER,
    @CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@Descripcion    VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Items
        (
            CategoriaID,
	        Nombre,
	        Descripcion,
	        PrecioUnitario,
	        ProveedorID
        )
        VALUES
        (
            @CategoriaID,
	        @Nombre,
	        @Descripcion,
	        @PrecioUnitario,
	        @ProveedorID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Items
        WHERE ItemID = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Items
        SET    CategoriaID    = @CategoriaID,
	           Nombre         = @Nombre,
	           Descripcion    = @Descripcion,
	           PrecioUnitario = @PrecioUnitario,
	           ProveedorID    = @ProveedorID
        WHERE  ItemID         = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Items
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Ordenes]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Ordenes]
(
    @OrdenID     INTEGER,
    @Legajo      INTEGER,
	@Fecha       DATE,
	@Estado      CHAR(10),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Ordenes
        (
            Legajo,
	        Fecha,
	        Estado
        )
        VALUES
        (
            @Legajo,
	        @Fecha,
	        @Estado
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes
        SET    Legajo  = @Legajo,
	           Fecha   = @Fecha,
	           Estado  = @Estado
        WHERE  OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Ordenes
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Ordenes_Items]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Ordenes_Items]
    --Ordenes
	@Legajo         INTEGER,
	@Fecha          DATE,
	@Estado         CHAR(10),
	--Items
	@CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
	--Ordenes_Items
	@Id             INTEGER,
    @OrdenID        INTEGER,
    @ItemID         INTEGER,
    @Cantidad       INTEGER,
	--Procedimiento Almacenado
    @Instruccion    CHAR(6)
AS
BEGIN

    DECLARE @ID_ORDEN int
    DECLARE @ID_ITEM int

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS
	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar ítems
	--a una orden. No se han hecho más pruebas.
	--Parámetros necesarios: creo que todos.

    IF @Instruccion = 'Insert'
    BEGIN

	    --Busco por empleado que pide (por el momento, hasta mejorar el diseño).
        SELECT @ID_ORDEN = OrdenID
	    FROM Ordenes
	    WHERE Legajo = @Legajo

	    --Busco por nombre del producto (por el momento, hasta mejorar el diseño).
	    SELECT @ID_ITEM = ItemID
	    FROM Items
	    WHERE Nombre = @Nombre

        IF (@ID_ORDEN IS NULL)
        BEGIN
            INSERT INTO Ordenes
			(
			    Legajo,
				Fecha,
				Estado
			)
		    VALUES
			(
			    @Legajo,
				@Fecha,
				@Estado
			)
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END

        IF (@ID_ITEM IS NULL)
        BEGIN
            INSERT INTO Items
			(
			    CategoriaID,
				Nombre,
				PrecioUnitario,
				ProveedorID
			)
		    VALUES
			(
			    @CategoriaID,
				@Nombre,
				@PrecioUnitario,
				@ProveedorID
			)
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END

	    INSERT INTO Ordenes_Items
        VALUES (@ID_ORDEN, @ID_ITEM, @Cantidad)

    END

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS
	--USO: 
	--Las tablas son de órdenes y sus ítems.
	--Si deseo borrar la órden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACIÓN QUE SE HARÁ.
	--EN UN FUTURO, SE PODRÍA AJUSTAR PARA QUE:
	--Si no deseo borrar la órden, Id = 0
	--Si deseo borrar un ítem de la orden, proveo su ID.
	--Si no deseo borrar un ítem, Id = 0
	--Parámetros necesarios: ID de la órden.

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES
    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de artículos pedida.
	--Parámetros necesarios: ID del ítem.

	IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes_Items
        SET Cantidad = @Cantidad
        WHERE OrdenID = @OrdenID AND ItemID = @ItemID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS
	--Por el momento (incluso creo que esta sección es un "huevo de pascua")
	--la operación de listado implica a los ítems de una órden.
	--Parámetros necesarios: ID de la órden.
	
	IF @Instruccion = 'Select'
    BEGIN
        SELECT Legajo,
               Fecha,
			   Estado,
			   Nombre,
			   Descripcion,
			   PrecioUnitario
        FROM Items
            JOIN Ordenes_Items 
			ON Ordenes_Items.ItemID  = Items.ItemID
            JOIN Ordenes
			ON Ordenes_Items.OrdenID = Ordenes.OrdenID
        WHERE Ordenes.OrdenID = @OrdenID
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Proveedores]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Proveedores]
(
    @ProveedorID CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Proveedores
        (
	        ProveedorID,
			Nombre
        )
        VALUES
        (
	        @ProveedorID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Proveedores
        WHERE ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Proveedores
        SET    Nombre      = @Nombre
        WHERE  ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Proveedores
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Roles]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Roles]
(
    @RolID       CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Roles
        (
	        RolID,
			Nombre
        )
        VALUES
        (
	        @RolID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Roles
        WHERE RolID = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Roles
        SET    Nombre = @Nombre
        WHERE  RolID  = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Roles
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_StudentCourses]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_StudentCourses]
    @StudentId INTEGER,
    @StudentName VARCHAR(50),
    @CourseId INTEGER,
    @CourseName VARCHAR(50),
    @StatementType NVARCHAR(20)
AS
BEGIN

    DECLARE @Student_Id int
    DECLARE @Course_Id int

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Insert'
    BEGIN
        INSERT Students
        (
            StudentName
        )
        SELECT DISTINCT
            @StudentName
        FROM Students
        WHERE NOT EXISTS
        (
            SELECT * FROM Students WHERE StudentId = @StudentId
        )

        IF @StudentId = 0
        BEGIN
            SELECT @Student_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Student_Id = @StudentId
        END

        INSERT Courses
        (
            CourseName
        )
        SELECT DISTINCT
            @CourseName
        FROM Courses
        WHERE NOT EXISTS
        (
            SELECT * FROM Courses WHERE CourseId = @CourseId
        )

        IF @CourseId = 0
        BEGIN
            SELECT @Course_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Course_Id = @CourseId
        END

        INSERT INTO StudentCourses
        VALUES
        (@Student_Id, @Course_Id)
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Select'
    BEGIN
        SELECT StudentName,
               CourseName
        FROM Courses
            JOIN StudentCourses
                ON Courses.CourseId = StudentCourses.CourseId
            JOIN Students
                ON Students.StudentId = StudentCourses.StudentId
        WHERE Students.StudentId = @StudentId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Update'
    BEGIN
        UPDATE Students
        SET StudentName = @StudentName
        WHERE StudentId = @StudentId

        UPDATE Courses
        SET CourseName = @CourseName
        WHERE CourseId = @CourseId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)
    
	IF @StatementType = 'Delete'
    BEGIN
        IF @StudentId <> 0
		BEGIN
		    DELETE FROM Students
            WHERE StudentId = @StudentId
		END

		IF @CourseId <> 0
		BEGIN
            DELETE FROM Courses
            WHERE CourseId = @CourseId
		END
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaParaReporte]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ConsultaParaReporte]
	@Desde DATE,
	@Hasta DATE

AS

SELECT o.OrdenID,
       o.Fecha,
       c.Nombre + ', ' + c.Apellido AS Empleado,
       Producto = STUFF(
                  (
                      SELECT ' - ' + 'x' + CONVERT(VARCHAR(10), oi2.Cantidad) + ' ' + Items.Nombre
                      FROM Ordenes_Items oi2
                          INNER JOIN Items
                              ON Items.ItemID = oi2.ItemID
                      WHERE oi2.OrdenID = oi1.OrdenID
                      FOR XML PATH('')
                  ),
                  1,
                  2,
                  ''
                       ),
       SUM(PrecioUnitario * Cantidad) AS Total
FROM Ordenes o
    INNER JOIN Empleados c
        ON c.Legajo = o.Legajo
    INNER JOIN Ordenes_Items oi1
        ON oi1.OrdenID = o.OrdenID
WHERE o.Fecha
BETWEEN @Desde AND @Hasta
GROUP BY o.OrdenID,
         oi1.OrdenID,
         o.Fecha,
         c.Nombre,
         c.Apellido
ORDER BY o.OrdenID ASC

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 23/03/2023 10:14:38 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Login]
(
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50)
)

AS
BEGIN
	SELECT COUNT(*) FROM Empleados WHERE Usuario = @Usuario AND Contraseña = @Contraseña
END
GO
USE [master]
GO
ALTER DATABASE [PIO] SET  READ_WRITE 
GO
