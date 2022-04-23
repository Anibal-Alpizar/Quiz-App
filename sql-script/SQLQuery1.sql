USE [master]
GO
/****** Object:  Database [Electronics]    Script Date: 21/04/2022 05:54:37 a. m. ******/
CREATE DATABASE [Electronics]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Electronics', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Electronics.mdf' , SIZE = 11136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Electronics_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Electronics_log.ldf' , SIZE = 32960KB , MAXSIZE = 102400KB , FILEGROWTH = 1024KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Electronics] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Electronics].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Electronics] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Electronics] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Electronics] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Electronics] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Electronics] SET ARITHABORT OFF 
GO
ALTER DATABASE [Electronics] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Electronics] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Electronics] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Electronics] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Electronics] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Electronics] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Electronics] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Electronics] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Electronics] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Electronics] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Electronics] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Electronics] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Electronics] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Electronics] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Electronics] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Electronics] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Electronics] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Electronics] SET RECOVERY FULL 
GO
ALTER DATABASE [Electronics] SET  MULTI_USER 
GO
ALTER DATABASE [Electronics] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Electronics] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Electronics] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Electronics] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Electronics] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Electronics] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Electronics', N'ON'
GO
ALTER DATABASE [Electronics] SET QUERY_STORE = OFF
GO
USE [Electronics]
GO
/****** Object:  User [UTN]    Script Date: 21/04/2022 05:54:37 a. m. ******/
CREATE USER [UTN] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
USE [Electronics]
GO
/****** Object:  Sequence [dbo].[SecuenciaVisitas]    Script Date: 21/04/2022 05:54:37 a. m. ******/
CREATE SEQUENCE [dbo].[SecuenciaVisitas] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [Electronics]
GO
/****** Object:  Sequence [dbo].[SequenceNoFactura]    Script Date: 21/04/2022 05:54:37 a. m. ******/
CREATE SEQUENCE [dbo].[SequenceNoFactura] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  Table [dbo].[Certificate]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [varchar](200) NOT NULL,
	[Location] [varchar](40) NULL,
	[Congratulation] [varchar](20) NULL,
	[FinalMessage] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[IID] [int] IDENTITY(1,1) NOT NULL,
	[IStuden] [varchar](50) NOT NULL,
	[IPay] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[IID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QId] [int] IDENTITY(1,1) NOT NULL,
	[QDesc] [varchar](100) NOT NULL,
	[Q01] [varchar](100) NOT NULL,
	[Q02] [varchar](100) NOT NULL,
	[Q03] [varchar](100) NOT NULL,
	[Q04] [varchar](100) NOT NULL,
	[QA] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[QId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[RId] [int] IDENTITY(1,1) NOT NULL,
	[RCandidate] [varchar](1000) NOT NULL,
	[RScore] [int] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[RId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] NOT NULL,
	[DescripcionRol] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[SId] [int] IDENTITY(1,1) NOT NULL,
	[SName] [nchar](50) NOT NULL,
	[SAge] [int] NOT NULL,
	[SPass] [nchar](50) NOT NULL,
	[SScore] [int] NOT NULL,
	[SAdd] [nchar](50) NOT NULL,
	[SPhone] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Login] [char](20) NOT NULL,
	[IdRol] [int] NOT NULL,
	[Password] [char](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Certificate] ON 
GO
INSERT [dbo].[Certificate] ([Id], [Message], [Location], [Congratulation], [FinalMessage]) VALUES (1, N'CODE ADVANCED OTORGA EL PRESENTE CERTIFICADO A', N'Costa Rica', N'Congratulations', N'Se extiende el presente Certificado a peticion del(a) interesado(a), para los fines que estime conveniente.')
GO
SET IDENTITY_INSERT [dbo].[Certificate] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 
GO
INSERT [dbo].[Invoice] ([IID], [IStuden], [IPay]) VALUES (3, N'Pedro', N'$1000')
GO
INSERT [dbo].[Invoice] ([IID], [IStuden], [IPay]) VALUES (4, N'Daniel', N'$1200')
GO
INSERT [dbo].[Invoice] ([IID], [IStuden], [IPay]) VALUES (21, N'Joe', N'$1000')
GO
INSERT [dbo].[Invoice] ([IID], [IStuden], [IPay]) VALUES (22, N'Anibal', N'$1000')
GO
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (1, N'¿Cuáles son las amenazas más grandes que se hay?', N'Phishing', N'Insercion de datos', N'Ataque DOS', N'Coneccion con terceros', N'Phishing')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (2, N'¿Cual es el mejor sistema operativo para trabajar con Ciber-Seguridad?', N'Kali Linux', N'Windows', N'MacOs', N'Todas la anteriores', N'Kali Linux')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (3, N'¿Que es un firewall?', N'Diseñada para bloquear el acceso no autorizado', N'Un componente electronico', N'Un antivirus', N'Un sistema operativo', N'Diseñada para bloquear el acceso no autorizado')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (6, N'¿Aumentaron los incidentes informáticos durante la pandemia?', N'Sí', N'No', N'Dismuyeron', N'Ninguna de las anteriores', N'Sí')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (7, N'¿Qué es criptografía?', N'Son técnicas para proteger documentos y datos', N'Es un antivirus de Linux', N'Es un ataque similiar a DOS', N'Ninguna de las anteriores', N'Son técnicas para proteger documentos y datos')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (8, N'¿Que es Inyecciones SQL?', N'Inserta código malicioso en un servidor', N'Insertar tablas falsas en una base de datos', N'Todas las anteriores', N'Ninguna de las anteriores', N'Inserta código malicioso en un servidor')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (9, N'¿Que es un antivirus?', N'Es un programa que detecta y eliminar virus informáticos', N'Es una herramienta para la creacion de sistemas de manera local.', N'Es un sistema de almacenamiento en la nube', N'Ninguna de las anteriores', N'Es un programa que detecta y eliminar virus informáticos')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (10, N'¿Que debo de hacer si mi pc se infecta?', N'Guardar la informacion y formatear', N'Llevarla a un tecnico', N'Apagarla y esperar 5 segundos', N'Todas las anteriores', N'Guardar la informacino y formatear')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (11, N'¿Hay peligro al comprar en linea?', N'Si, debo de tener cuidado al ingresar mis datos', N'No, porque mi banco me respalda', N'Ninguna de las anteriores', N'No, es imposible que me roben la informacion', N'Si, debo de tener cuidado al ingresar mis datos')
GO
INSERT [dbo].[Questions] ([QId], [QDesc], [Q01], [Q02], [Q03], [Q04], [QA]) VALUES (12, N'¿Como evitar un virus?', N'Comprando el mejor antivirus', N'Tener cuidado en las paginas donde navego', N'Formatear la pc cada 2 dias.', N'Ningunas de las anteriores', N'Tener cuidado en las paginas donde navego')
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[Result] ON 
GO
INSERT [dbo].[Result] ([RId], [RCandidate], [RScore]) VALUES (1006, N'Messi', 10)
GO
INSERT [dbo].[Result] ([RId], [RCandidate], [RScore]) VALUES (1007, N'Anibal', 100)
GO
SET IDENTITY_INSERT [dbo].[Result] OFF
GO
INSERT [dbo].[Rol] ([IdRol], [DescripcionRol]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[Rol] ([IdRol], [DescripcionRol]) VALUES (2, N'Vendedor')
GO
INSERT [dbo].[Rol] ([IdRol], [DescripcionRol]) VALUES (3, N'Reportes')
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (25, N'Admin                                             ', 0, N'123                                               ', 0, N'null                                              ', N'000-000                                           ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1024, N'Reporter                                          ', 20, N'123                                               ', 0, N'null                                              ', N'8932-4389                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1025, N'Carlos                                            ', 89, N'Carlos                                            ', 0, N'Alemania                                          ', N'9089-8987                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1028, N'Anibal                                            ', 20, N'123                                               ', 0, N'España                                            ', N'9023-2309                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1029, N'Daniel                                            ', 32, N'123                                               ', 0, N'Israel                                            ', N'2389-4388                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1030, N'Roxana                                            ', 23, N'123                                               ', 0, N'Sudán                                             ', N'9032-4389                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1031, N'Toño                                              ', 43, N'123                                               ', 0, N'Mozambique                                        ', N'9090-9090                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1032, N'Sandra                                            ', 78, N'123                                               ', 0, N'México                                            ', N'9089-8976                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1033, N'Maria                                             ', 65, N'123                                               ', 0, N'Timor Oriental                                    ', N'3290-2390                                         ')
GO
INSERT [dbo].[Student] ([SId], [SName], [SAge], [SPass], [SScore], [SAdd], [SPhone]) VALUES (1034, N'Messi                                             ', 43, N'10                                                ', 0, N'Argentina                                         ', N'8978-8978                                         ')
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
INSERT [dbo].[Usuario] ([Login], [IdRol], [Password], [Nombre], [Estado]) VALUES (N'admin               ', 1, N'u6QXcpElu3jBzi22FNFdrw==                          ', N'Administrador', 1)
GO
INSERT [dbo].[Usuario] ([Login], [IdRol], [Password], [Nombre], [Estado]) VALUES (N'Anibal              ', 3, N'123                                               ', N'Anibal', 1)
GO
INSERT [dbo].[Usuario] ([Login], [IdRol], [Password], [Nombre], [Estado]) VALUES (N'maria               ', 2, N'u6QXcpElu3jBzi22FNFdrw==                          ', N'Maria', 1)
GO
INSERT [dbo].[Usuario] ([Login], [IdRol], [Password], [Nombre], [Estado]) VALUES (N'pedro               ', 3, N'u6QXcpElu3jBzi22FNFdrw==                          ', N'Pedro', 1)
GO
INSERT [dbo].[Usuario] ([Login], [IdRol], [Password], [Nombre], [Estado]) VALUES (N'utn                 ', 2, N'2PR07NWG3wVJMcqgry+0m1+QVrZtJlWI5gOqgn2LES8=      ', N'Usuario Generico UTN', 1)
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
/****** Object:  StoredProcedure [dbo].[MostrarCalificaiones]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarCalificaiones]
as
SELECT * FROM Result
GO
/****** Object:  StoredProcedure [dbo].[MostrarPreguntas]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarPreguntas]
as
SELECT * FROM Questions
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 21/04/2022 05:54:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarUsuarios]
as
SELECT * FROM Student
GO
USE [master]
GO
ALTER DATABASE [Electronics] SET  READ_WRITE 
GO
