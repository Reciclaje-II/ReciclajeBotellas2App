USE [BDRecilajeBotellas]
GO
/****** Object:  Schema [swlnreciclado_SQLLogin_1]    Script Date: 5/9/2023 16:42:45 ******/
CREATE SCHEMA [swlnreciclado_SQLLogin_1]
GO
/****** Object:  Table [dbo].[RCampania]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RCampania](
	[NombreCampania] [varchar](60) NOT NULL,
	[DescripcionCampania] [text] NOT NULL,
	[FechaInicioCampania] [date] NOT NULL,
	[FechaFinCampania] [date] NOT NULL,
	[EstadoCampania] [char](2) NOT NULL,
	[SedeCampania] [varchar](15) NOT NULL,
	[FechaRegistroCampania] [datetime] NULL,
	[FechaModificacionCampania] [datetime] NULL,
 CONSTRAINT [PK_RCampania] PRIMARY KEY CLUSTERED 
(
	[NombreCampania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RCampaniaOrganizacion]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RCampaniaOrganizacion](
	[CampaniaCampaniaOrganizacion] [varchar](60) NOT NULL,
	[OrganizacionCampaniaOrganizacion] [varchar](80) NOT NULL,
	[FechaRegistroCampaniaOrganizacion] [datetime] NOT NULL,
	[IdCampaniaOrganizacion] [int] IDENTITY(1,1) NOT NULL,
	[EstadoCampaniaOrganizacion] [char](2) NOT NULL,
	[FechaModificacionCampaniaOrganizacion] [datetime] NULL,
 CONSTRAINT [PK_RCampaniaOrganizacion] PRIMARY KEY CLUSTERED 
(
	[IdCampaniaOrganizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RContenedor]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RContenedor](
	[CodigoUsuario] [varchar](14) NOT NULL,
	[IdMaquinaContenedor] [tinyint] NOT NULL,
	[GramosContenedor] [decimal](7, 2) NOT NULL,
	[FechaRegistroContenedor] [datetime] NOT NULL,
	[IdContenedor] [int] IDENTITY(1,1) NOT NULL,
	[EstadoContenedor] [char](2) NULL,
	[FechaModificacionContenedor] [datetime] NULL,
 CONSTRAINT [PK_Contenedor] PRIMARY KEY CLUSTERED 
(
	[IdContenedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RMaquina]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RMaquina](
	[IdMaquina] [tinyint] IDENTITY(1,1) NOT NULL,
	[DescripcionMaquina] [text] NOT NULL,
	[EstadoMaquina] [char](2) NOT NULL,
	[FechaModificacionMaquina] [datetime] NULL,
	[FechaRegistroMaquina] [datetime] NULL,
 CONSTRAINT [PK_Maquina] PRIMARY KEY CLUSTERED 
(
	[IdMaquina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROrganizacion]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROrganizacion](
	[NombreOrganizacion] [varchar](80) NOT NULL,
	[DescripcionOrganizacion] [text] NOT NULL,
	[EstadoOrganizacion] [char](2) NULL,
	[FechaRegistroOrganizacion] [datetime] NULL,
	[FechaModificacionOrganizacion] [datetime] NULL,
 CONSTRAINT [PK_Organizacion] PRIMARY KEY CLUSTERED 
(
	[NombreOrganizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RUsuario]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUsuario](
	[CodigoUsuario] [varchar](14) NOT NULL,
	[CreditosUsuario] [numeric](6, 0) NOT NULL,
	[RolUsuario] [varchar](14) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RUsuarioNetvalle]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RUsuarioNetvalle](
	[CodigoUsuarioNetvalle] [varchar](14) NOT NULL,
	[NombresUsuarioNetvalle] [varchar](60) NOT NULL,
	[ApellidosUsuarioNetvalle] [varchar](60) NOT NULL,
	[CargoUsuarioNetvalle] [varchar](14) NOT NULL,
	[TarjetaUsuarioNetvalle] [varchar](14) NOT NULL,
	[SedeUsuarioNetvalle] [varchar](15) NOT NULL,
	[FechaRegistroUsuarioNetvalle] [datetime] NULL,
	[FechaModificacionUsuarioNetvalle] [datetime] NULL,
	[EstadoUsuarioNetvalle] [char](2) NULL,
 CONSTRAINT [PK_UsuarioNetvalle] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuarioNetvalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RVoto]    Script Date: 5/9/2023 16:42:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RVoto](
	[CodigoUsuario] [varchar](14) NOT NULL,
	[CampaniaVoto] [varchar](60) NOT NULL,
	[OrganizacionVoto] [varchar](80) NOT NULL,
	[FechaRegistroVoto] [datetime] NOT NULL,
	[DonacionVoto] [numeric](6, 0) NOT NULL,
	[EstadoVoto] [char](2) NOT NULL,
	[FechaModificacionVoto] [datetime] NULL,
	[IdVoto] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RVoto] PRIMARY KEY CLUSTERED 
(
	[IdVoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[RCampania] ([NombreCampania], [DescripcionCampania], [FechaInicioCampania], [FechaFinCampania], [EstadoCampania], [SedeCampania], [FechaRegistroCampania], [FechaModificacionCampania]) VALUES (N'CB-REFUGIO DE ANIMALES-2_2023', N'Ayuda a mascotas en situacion de calle', CAST(N'2023-08-03' AS Date), CAST(N'2023-09-03' AS Date), N'AC', N'COCHABAMBA', CAST(N'2023-03-08T09:35:46.000' AS DateTime), CAST(N'2023-03-08T09:35:46.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RCampaniaOrganizacion] ON 

INSERT [dbo].[RCampaniaOrganizacion] ([CampaniaCampaniaOrganizacion], [OrganizacionCampaniaOrganizacion], [FechaRegistroCampaniaOrganizacion], [IdCampaniaOrganizacion], [EstadoCampaniaOrganizacion], [FechaModificacionCampaniaOrganizacion]) VALUES (N'CB-REFUGIO DE ANIMALES-2_2023', N'una mano una patita', CAST(N'2023-08-03T09:35:46.450' AS DateTime), 1002, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RCampaniaOrganizacion] ([CampaniaCampaniaOrganizacion], [OrganizacionCampaniaOrganizacion], [FechaRegistroCampaniaOrganizacion], [IdCampaniaOrganizacion], [EstadoCampaniaOrganizacion], [FechaModificacionCampaniaOrganizacion]) VALUES (N'CB-REFUGIO DE ANIMALES-2_2023', N'una mano una patita 2', CAST(N'2023-08-03T09:35:46.450' AS DateTime), 1003, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
SET IDENTITY_INSERT [dbo].[RCampaniaOrganizacion] OFF
GO
SET IDENTITY_INSERT [dbo].[RContenedor] ON 

INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 3, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VMR0031107', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 4, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VMR0031107', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 5, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GOL0032646', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 6, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GOL0032646', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 7, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TVN0033163', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 8, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ACM0031929', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 9, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 10, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PBM0033554', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 11, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CMJ1010582', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 12, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FFM0033692', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 13, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BCJ1009876', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 14, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CFA0034184', 1, CAST(150.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 15, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 16, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MAC0033675', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 17, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZVA0034314', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 18, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TVB0031379', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 19, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ASY0033459', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 20, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MCS0030352', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 21, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CPE0028860', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 22, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MUJ0034054', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 23, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FPM0029894', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T09:35:46.450' AS DateTime), 24, N'AC', CAST(N'2023-08-03T09:35:46.450' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 25, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BVM0033328', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 26, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CJP0028425', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 27, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SMD0025695', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 28, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LTL0033708', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 29, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STF0032816', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 30, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PLM1010617', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 31, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'QAS0030770', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-03T12:03:54.667' AS DateTime), 32, N'AC', CAST(N'2023-08-03T12:03:54.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TAC0033923', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 33, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LAS0032355', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 34, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LAS0032355', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 35, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LCE0032181', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 36, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LCE0032181', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 37, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PVN0028998', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 38, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 39, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'OCR0031574', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 40, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CSL1009878', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 41, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ALB0031565', 1, CAST(250.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 42, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZRJ0032409', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T13:16:19.567' AS DateTime), 43, N'AC', CAST(N'2023-08-03T13:16:19.567' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PVN0028998', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-03T17:17:37.733' AS DateTime), 44, N'AC', CAST(N'2023-08-03T17:17:37.733' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T09:50:24.790' AS DateTime), 45, N'AC', CAST(N'2023-08-04T09:50:24.790' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 46, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 47, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(350.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 48, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 49, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 50, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 51, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(450.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 52, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 53, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TLM0029990', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 54, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ASM5001681', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T11:15:30.677' AS DateTime), 55, N'AC', CAST(N'2023-08-04T11:15:30.677' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-04T12:59:09.917' AS DateTime), 56, N'AC', CAST(N'2023-08-04T12:59:09.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T12:59:09.917' AS DateTime), 57, N'AC', CAST(N'2023-08-04T12:59:09.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'QMA1010884', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-04T12:59:09.917' AS DateTime), 58, N'AC', CAST(N'2023-08-04T12:59:09.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVA2019246', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T12:59:09.917' AS DateTime), 59, N'AC', CAST(N'2023-08-04T12:59:09.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LAD2019288', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-04T12:59:09.917' AS DateTime), 60, N'AC', CAST(N'2023-08-04T12:59:09.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BFN1010270', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-08T16:31:25.303' AS DateTime), 1002, N'AC', CAST(N'2023-08-08T16:31:25.303' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BFN1010270', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-08T16:31:25.303' AS DateTime), 1003, N'AC', CAST(N'2023-08-08T16:31:25.303' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'APN0028250', 1, CAST(250.00 AS Decimal(7, 2)), CAST(N'2023-08-08T16:31:25.303' AS DateTime), 1004, N'AC', CAST(N'2023-08-08T16:31:25.303' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-10T14:40:28.627' AS DateTime), 1005, N'AC', CAST(N'2023-08-10T14:40:28.627' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T08:55:59.577' AS DateTime), 1006, N'AC', CAST(N'2023-08-11T08:55:59.577' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-11T08:55:59.577' AS DateTime), 1007, N'AC', CAST(N'2023-08-11T08:55:59.577' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GFJ1010562', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T11:02:53.360' AS DateTime), 1008, N'AC', CAST(N'2023-08-11T11:02:53.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T11:02:53.360' AS DateTime), 1009, N'AC', CAST(N'2023-08-11T11:02:53.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T11:02:53.360' AS DateTime), 1010, N'AC', CAST(N'2023-08-11T11:02:53.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T12:14:16.497' AS DateTime), 1011, N'AC', CAST(N'2023-08-11T12:14:16.497' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'JTF0032089', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T12:14:16.497' AS DateTime), 1012, N'AC', CAST(N'2023-08-11T12:14:16.497' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RLF0033311', 1, CAST(150.00 AS Decimal(7, 2)), CAST(N'2023-08-11T12:14:16.497' AS DateTime), 1013, N'AC', CAST(N'2023-08-11T12:14:16.497' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'QAS0030770', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-11T12:14:16.497' AS DateTime), 1014, N'AC', CAST(N'2023-08-11T12:14:16.497' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'QAS0030770', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T13:31:10.280' AS DateTime), 1015, N'AC', CAST(N'2023-08-11T13:31:10.280' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LSA0029837', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T13:57:54.113' AS DateTime), 1016, N'AC', CAST(N'2023-08-11T13:57:54.113' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T13:57:54.113' AS DateTime), 1017, N'AC', CAST(N'2023-08-11T13:57:54.113' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BQM0031388', 1, CAST(400.00 AS Decimal(7, 2)), CAST(N'2023-08-11T13:57:54.113' AS DateTime), 1018, N'AC', CAST(N'2023-08-11T13:57:54.113' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BQM0031388', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T13:57:54.113' AS DateTime), 1019, N'AC', CAST(N'2023-08-11T13:57:54.113' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BQM0031388', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-11T15:31:41.807' AS DateTime), 1020, N'AC', CAST(N'2023-08-11T15:31:41.807' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-11T16:25:12.543' AS DateTime), 1021, N'AC', CAST(N'2023-08-11T16:25:12.543' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-11T16:25:12.543' AS DateTime), 1022, N'AC', CAST(N'2023-08-11T16:25:12.543' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(110.00 AS Decimal(7, 2)), CAST(N'2023-08-11T16:25:12.543' AS DateTime), 1023, N'AC', CAST(N'2023-08-11T16:25:12.543' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-14T08:35:55.200' AS DateTime), 1024, N'AC', CAST(N'2023-08-14T08:35:55.200' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1025, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1026, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(140.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1027, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(30.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1028, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1029, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1030, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'APM0033556', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-14T10:13:02.043' AS DateTime), 1031, N'AC', CAST(N'2023-08-14T10:13:02.043' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-25T09:27:54.953' AS DateTime), 2005, N'AC', CAST(N'2023-08-25T09:27:54.953' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T11:08:09.437' AS DateTime), 2006, N'AC', CAST(N'2023-08-25T11:08:09.437' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T11:08:09.437' AS DateTime), 2007, N'AC', CAST(N'2023-08-25T11:08:09.437' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SMF0031914', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T12:10:34.660' AS DateTime), 2008, N'AC', CAST(N'2023-08-25T12:10:34.660' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CBA0029937', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T12:42:44.753' AS DateTime), 2009, N'AC', CAST(N'2023-08-25T12:42:44.753' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'UQB1010537', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T13:39:34.237' AS DateTime), 2010, N'AC', CAST(N'2023-08-25T13:39:34.237' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PI0028776', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T14:50:58.847' AS DateTime), 2011, N'AC', CAST(N'2023-08-25T14:50:58.847' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2012, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2013, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2014, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2015, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
GO
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(110.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2016, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2017, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2018, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-25T15:36:25.360' AS DateTime), 2019, N'AC', CAST(N'2023-08-25T15:36:25.360' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(300.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3005, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3006, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3007, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3008, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3009, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3010, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3011, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-28T08:46:34.323' AS DateTime), 3012, N'AC', CAST(N'2023-08-28T08:46:34.323' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'EMJ0033301', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-28T11:55:33.240' AS DateTime), 3013, N'AC', CAST(N'2023-08-28T11:55:33.240' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'EMJ0033301', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-28T11:55:33.240' AS DateTime), 3014, N'AC', CAST(N'2023-08-28T11:55:33.240' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STF0032816', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T12:35:42.443' AS DateTime), 3015, N'AC', CAST(N'2023-08-28T12:35:42.443' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STF0032816', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T12:35:42.443' AS DateTime), 3016, N'AC', CAST(N'2023-08-28T12:35:42.443' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STF0032816', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T12:35:42.443' AS DateTime), 3017, N'AC', CAST(N'2023-08-28T12:35:42.443' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-08-28T13:20:39.427' AS DateTime), 3018, N'AC', CAST(N'2023-08-28T13:20:39.427' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-28T14:45:46.897' AS DateTime), 3019, N'AC', CAST(N'2023-08-28T14:45:46.897' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GFC0032235', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-28T15:10:58.977' AS DateTime), 3020, N'AC', CAST(N'2023-08-28T15:10:58.977' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GFC0032235', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-28T15:10:58.977' AS DateTime), 3021, N'AC', CAST(N'2023-08-28T15:10:58.977' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-28T15:10:58.977' AS DateTime), 3022, N'AC', CAST(N'2023-08-28T15:10:58.977' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-29T08:58:04.160' AS DateTime), 3023, N'AC', CAST(N'2023-08-29T08:58:04.160' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-29T11:05:09.353' AS DateTime), 3024, N'AC', CAST(N'2023-08-29T11:05:09.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(310.00 AS Decimal(7, 2)), CAST(N'2023-08-29T11:05:09.353' AS DateTime), 3025, N'AC', CAST(N'2023-08-29T11:05:09.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(300.00 AS Decimal(7, 2)), CAST(N'2023-08-29T11:05:09.353' AS DateTime), 3026, N'AC', CAST(N'2023-08-29T11:05:09.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(240.00 AS Decimal(7, 2)), CAST(N'2023-08-29T11:05:09.353' AS DateTime), 3027, N'AC', CAST(N'2023-08-29T11:05:09.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(80.00 AS Decimal(7, 2)), CAST(N'2023-08-29T11:05:09.353' AS DateTime), 3028, N'AC', CAST(N'2023-08-29T11:05:09.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MZI0034039', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T13:22:28.503' AS DateTime), 3029, N'AC', CAST(N'2023-08-29T13:22:28.503' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SGB0033389', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T13:22:28.503' AS DateTime), 3030, N'AC', CAST(N'2023-08-29T13:22:28.503' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-29T13:22:28.503' AS DateTime), 3031, N'AC', CAST(N'2023-08-29T13:22:28.503' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-29T15:03:32.320' AS DateTime), 4005, N'AC', CAST(N'2023-08-29T15:03:32.320' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T15:03:32.320' AS DateTime), 4006, N'AC', CAST(N'2023-08-29T15:03:32.320' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-08-29T15:03:32.320' AS DateTime), 4007, N'AC', CAST(N'2023-08-29T15:03:32.320' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T15:03:32.320' AS DateTime), 4008, N'AC', CAST(N'2023-08-29T15:03:32.320' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T15:03:32.320' AS DateTime), 4009, N'AC', CAST(N'2023-08-29T15:03:32.320' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T16:06:53.217' AS DateTime), 4010, N'AC', CAST(N'2023-08-29T16:06:53.217' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RMA1010551', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-29T16:06:53.217' AS DateTime), 4011, N'AC', CAST(N'2023-08-29T16:06:53.217' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-29T16:06:53.217' AS DateTime), 4012, N'AC', CAST(N'2023-08-29T16:06:53.217' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LVM0031907', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-29T16:06:53.217' AS DateTime), 4013, N'AC', CAST(N'2023-08-29T16:06:53.217' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-30T08:56:05.667' AS DateTime), 5005, N'AC', CAST(N'2023-08-30T08:56:05.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T08:56:05.667' AS DateTime), 5006, N'AC', CAST(N'2023-08-30T08:56:05.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(20.00 AS Decimal(7, 2)), CAST(N'2023-08-30T08:56:05.667' AS DateTime), 5007, N'AC', CAST(N'2023-08-30T08:56:05.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T08:56:05.667' AS DateTime), 5008, N'AC', CAST(N'2023-08-30T08:56:05.667' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T10:26:51.067' AS DateTime), 5009, N'AC', CAST(N'2023-08-30T10:26:51.067' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(160.00 AS Decimal(7, 2)), CAST(N'2023-08-30T10:26:51.067' AS DateTime), 5010, N'AC', CAST(N'2023-08-30T10:26:51.067' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T11:19:53.900' AS DateTime), 5011, N'AC', CAST(N'2023-08-30T11:19:53.900' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T11:19:53.900' AS DateTime), 5012, N'AC', CAST(N'2023-08-30T11:19:53.900' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T11:19:53.900' AS DateTime), 5013, N'AC', CAST(N'2023-08-30T11:19:53.900' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CBA0029937', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5014, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MHA0030917', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5015, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MHA0030917', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5016, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RAD0030233', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5017, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'JSV0029741', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5018, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZCE5000936', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5019, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SAR0029947', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5020, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(110.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5021, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(180.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5022, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5023, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CVI5001819', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T12:31:15.957' AS DateTime), 5024, N'AC', CAST(N'2023-08-30T12:31:15.957' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CFA0034184', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T14:44:11.953' AS DateTime), 5025, N'AC', CAST(N'2023-08-30T14:44:11.953' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'OTR5001093', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T14:44:11.953' AS DateTime), 5026, N'AC', CAST(N'2023-08-30T14:44:11.953' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CCR0025530', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T14:44:11.953' AS DateTime), 5027, N'AC', CAST(N'2023-08-30T14:44:11.953' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZSA1010695', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5028, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5029, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5030, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5031, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5032, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5033, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5034, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5035, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5036, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5037, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(1.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5038, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5039, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5040, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5041, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-30T15:49:37.563' AS DateTime), 5042, N'AC', CAST(N'2023-08-30T15:49:37.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T09:14:49.563' AS DateTime), 5043, N'AC', CAST(N'2023-08-31T09:14:49.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T09:14:49.563' AS DateTime), 5044, N'AC', CAST(N'2023-08-31T09:14:49.563' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'FVS0029774', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T10:20:16.840' AS DateTime), 5045, N'AC', CAST(N'2023-08-31T10:20:16.840' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(390.00 AS Decimal(7, 2)), CAST(N'2023-08-31T11:29:08.987' AS DateTime), 5046, N'AC', CAST(N'2023-08-31T11:29:08.987' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(260.00 AS Decimal(7, 2)), CAST(N'2023-08-31T11:29:08.987' AS DateTime), 5047, N'AC', CAST(N'2023-08-31T11:29:08.987' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(370.00 AS Decimal(7, 2)), CAST(N'2023-08-31T11:29:08.987' AS DateTime), 5048, N'AC', CAST(N'2023-08-31T11:29:08.987' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBF0034003', 1, CAST(440.00 AS Decimal(7, 2)), CAST(N'2023-08-31T11:29:08.987' AS DateTime), 5049, N'AC', CAST(N'2023-08-31T11:29:08.987' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MHA0030917', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-31T11:29:08.987' AS DateTime), 5050, N'AC', CAST(N'2023-08-31T11:29:08.987' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(160.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5051, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(130.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5052, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(140.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5053, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(230.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5054, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(260.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5055, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ZIC0031845', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-31T12:40:04.047' AS DateTime), 5056, N'AC', CAST(N'2023-08-31T12:40:04.047' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T14:13:06.000' AS DateTime), 5057, N'AC', CAST(N'2023-08-31T14:13:06.000' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T16:27:34.767' AS DateTime), 5058, N'AC', CAST(N'2023-08-31T16:27:34.767' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-08-31T16:27:34.767' AS DateTime), 5059, N'AC', CAST(N'2023-08-31T16:27:34.767' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T16:27:34.767' AS DateTime), 5060, N'AC', CAST(N'2023-08-31T16:27:34.767' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-08-31T16:27:34.767' AS DateTime), 5061, N'AC', CAST(N'2023-08-31T16:27:34.767' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SMF0031914', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-01T11:09:28.523' AS DateTime), 5062, N'AC', CAST(N'2023-09-01T11:09:28.523' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BQP2019457', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T11:09:28.523' AS DateTime), 5063, N'AC', CAST(N'2023-09-01T11:09:28.523' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RAD0030233', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T12:47:31.737' AS DateTime), 5064, N'AC', CAST(N'2023-09-01T12:47:31.737' AS DateTime))
GO
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MSJ0032778', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T12:47:31.737' AS DateTime), 5065, N'AC', CAST(N'2023-09-01T12:47:31.737' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'GFC0032235', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5066, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PIS0032282', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5067, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5068, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5069, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'TRC0029674', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5070, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(170.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5071, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5072, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'EGA0031071', 1, CAST(60.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5073, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PCD5000480', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T13:53:53.107' AS DateTime), 5074, N'AC', CAST(N'2023-09-01T13:53:53.107' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CCR0025530', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-01T15:29:17.917' AS DateTime), 5075, N'AC', CAST(N'2023-09-01T15:29:17.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CCR0025530', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T15:29:17.917' AS DateTime), 5076, N'AC', CAST(N'2023-09-01T15:29:17.917' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ODD0033308', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T16:23:46.103' AS DateTime), 5077, N'AC', CAST(N'2023-09-01T16:23:46.103' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-01T17:32:33.353' AS DateTime), 5078, N'AC', CAST(N'2023-09-01T17:32:33.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T17:32:33.353' AS DateTime), 5079, N'AC', CAST(N'2023-09-01T17:32:33.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BBG0026642', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T17:32:33.353' AS DateTime), 5080, N'AC', CAST(N'2023-09-01T17:32:33.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'SGB0033389', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-01T17:32:33.353' AS DateTime), 5081, N'AC', CAST(N'2023-09-01T17:32:33.353' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T08:37:28.207' AS DateTime), 5082, N'AC', CAST(N'2023-09-04T08:37:28.207' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MBR0030140', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5083, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(580.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5084, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5085, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(200.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5086, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(100.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5087, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'AFA0031046', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-04T10:15:36.707' AS DateTime), 5088, N'AC', CAST(N'2023-09-04T10:15:36.707' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5089, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5090, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5091, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ARD0031847', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5092, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RAD0030233', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5093, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'CVI5001819', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5094, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ROA1010505', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-04T11:52:36.633' AS DateTime), 5095, N'AC', CAST(N'2023-09-04T11:52:36.633' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T09:15:10.030' AS DateTime), 5096, N'AC', CAST(N'2023-09-05T09:15:10.030' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VRJ2019150', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5097, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MLI0033466', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5098, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ERD0031655', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5099, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'RAD0030233', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5100, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STS0029678', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5101, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VLN1010459', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T12:01:09.533' AS DateTime), 5102, N'AC', CAST(N'2023-09-05T12:01:09.533' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VAP0031740', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T13:35:04.087' AS DateTime), 5103, N'AC', CAST(N'2023-09-05T13:35:04.087' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'PRJ0030099', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T13:35:04.087' AS DateTime), 5104, N'AC', CAST(N'2023-09-05T13:35:04.087' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'ADC0029584', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T13:35:04.087' AS DateTime), 5105, N'AC', CAST(N'2023-09-05T13:35:04.087' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A00094LMT', 1, CAST(160.00 AS Decimal(7, 2)), CAST(N'2023-09-05T14:26:45.277' AS DateTime), 5106, N'AC', CAST(N'2023-09-05T14:26:45.277' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T14:26:45.277' AS DateTime), 5107, N'AC', CAST(N'2023-09-05T14:26:45.277' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T14:26:45.277' AS DateTime), 5108, N'AC', CAST(N'2023-09-05T14:26:45.277' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'1A01983ARM', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T14:26:45.277' AS DateTime), 5109, N'AC', CAST(N'2023-09-05T14:26:45.277' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'VRJ2019150', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T14:26:45.277' AS DateTime), 5110, N'AC', CAST(N'2023-09-05T14:26:45.277' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LVM0031907', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5111, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'LVM0031907', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5112, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'STS0029678', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5113, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MAM0029981', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5114, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'MAM0029981', 1, CAST(10.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5115, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
INSERT [dbo].[RContenedor] ([CodigoUsuario], [IdMaquinaContenedor], [GramosContenedor], [FechaRegistroContenedor], [IdContenedor], [EstadoContenedor], [FechaModificacionContenedor]) VALUES (N'BFN1010270', 1, CAST(50.00 AS Decimal(7, 2)), CAST(N'2023-09-05T16:03:41.467' AS DateTime), 5116, N'AC', CAST(N'2023-09-05T16:03:41.467' AS DateTime))
SET IDENTITY_INSERT [dbo].[RContenedor] OFF
GO
SET IDENTITY_INSERT [dbo].[RMaquina] ON 

INSERT [dbo].[RMaquina] ([IdMaquina], [DescripcionMaquina], [EstadoMaquina], [FechaModificacionMaquina], [FechaRegistroMaquina]) VALUES (1, N'Reciclae', N'ok', CAST(N'2023-04-24T22:15:22.160' AS DateTime), CAST(N'2023-04-24T22:15:22.160' AS DateTime))
SET IDENTITY_INSERT [dbo].[RMaquina] OFF
GO
INSERT [dbo].[ROrganizacion] ([NombreOrganizacion], [DescripcionOrganizacion], [EstadoOrganizacion], [FechaRegistroOrganizacion], [FechaModificacionOrganizacion]) VALUES (N'una mano una patita', N'Refugio para los animales', N'AC', CAST(N'2023-03-08T09:35:46.000' AS DateTime), CAST(N'2023-03-08T09:35:46.000' AS DateTime))
INSERT [dbo].[ROrganizacion] ([NombreOrganizacion], [DescripcionOrganizacion], [EstadoOrganizacion], [FechaRegistroOrganizacion], [FechaModificacionOrganizacion]) VALUES (N'una mano una patita 2', N'Refugio2', N'AC', CAST(N'2023-03-08T09:35:46.000' AS DateTime), CAST(N'2023-03-08T09:35:46.000' AS DateTime))
GO
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'1A00094LMT', CAST(1996 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'1A00329CSJ', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'1A00581SSG', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'1A01743SFL', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'1A01983ARM', CAST(320 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'AAA0031133', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ACS0032471', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ADC0029584', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'AFA0031046', CAST(1220 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ALB0031565', CAST(250 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'APM0033556', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'APN0028250', CAST(250 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ARD0031847', CAST(1160 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ASM5001681', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ASY0033459', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BBF0034003', CAST(1710 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BBG0026642', CAST(260 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BEK0033676', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BFN1010270', CAST(150 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BQM0031388', CAST(500 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BQP2019457', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BVM0031361', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BVM0033328', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'BVR5001132', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CBA0029937', CAST(60 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CCB0030067', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CCR0025530', CAST(110 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CDB0034346', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CFA0034184', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CGL5001349', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CHM0031867', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CJP0028425', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CLS0032909', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CPE0028860', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CPJ0029768', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CQH0034216', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CSL1009878', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'CVI5001819', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'DGE0028460', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'EGA0031071', CAST(60 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'EMJ0033301', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ERD0031655', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'FAF0033841', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'FCA0033428', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'FPM0029894', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'FVA2019246', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'FVS0029774', CAST(710 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'GCP0033197', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'GFC0032235', CAST(160 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'GFJ1010562', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'HVJ0033927', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ITH0033916', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'JKF0025173', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'JSV0029741', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'JTF0032089', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LAD2019288', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LAS0032355', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LCE0032181', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LSA0029837', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LTL0033708', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'LVM0031907', CAST(110 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MAC0033675', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MAM0029981', CAST(60 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MBR0030140', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MCJ0033702', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MCS0030352', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MHA0030917', CAST(110 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MHM0031469', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MLI0033466', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MPN0031406', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MSJ0032778', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MUJ0034054', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'MZI0034039', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'OCR0031574', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ODD0033308', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'OTR5001093', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PCD5000480', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PGI0033546', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PI0028776', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PIS0032282', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PLM1010617', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PMY3005445', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PRC0029343', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PRJ0030099', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PTM0031384', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'PVN0028998', CAST(150 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'QAS0030770', CAST(250 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'QMA1010884', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RAD0030233', CAST(200 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RCA0028192', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RCA0034174', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RLC5001752', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RLF0033311', CAST(150 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RMA1010551', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ROA1010505', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'RPR0032580', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SAP0027763', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SAR0029947', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SDD0031489', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SFJ5001331', CAST(0 AS Numeric(6, 0)), N'Usuario')
GO
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SGB0033389', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SMD0025695', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'SMF0031914', CAST(20 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'STF0032816', CAST(80 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'STS0029678', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'TAC0033923', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'TLM0029990', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'TRC0029674', CAST(890 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'TVB0031379', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'UQB1010537', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'VAP0031740', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'VLN1010459', CAST(10 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'VMM0031901', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'VRJ2019150', CAST(100 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'VUS0032480', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'YRC0031199', CAST(0 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ZCE5000936', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ZIC0031845', CAST(2000 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ZRJ0032409', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ZSA1010695', CAST(50 AS Numeric(6, 0)), N'Usuario')
INSERT [dbo].[RUsuario] ([CodigoUsuario], [CreditosUsuario], [RolUsuario]) VALUES (N'ZVA0034314', CAST(50 AS Numeric(6, 0)), N'Usuario')
GO
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'1A00094LMT', N'TEDDY', N'LOPEZ MONJE', N'Administrador', N'00055840443649', N'Cochabamba', CAST(N'2023-08-10T17:30:02.917' AS DateTime), CAST(N'2023-08-10T17:30:02.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'1A00329CSJ', N'JOSE', N'CRESPO SAUCEDO', N'Administrador', N'00055840426426', N'Cochabamba', CAST(N'2023-08-11T13:57:54.113' AS DateTime), CAST(N'2023-08-11T13:57:54.113' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'1A00581SSG', N'GASTON', N'SILVA SANCHEZ', N'Administrador', N'00055840356199', N'Cochabamba', CAST(N'2023-08-10T14:40:28.627' AS DateTime), CAST(N'2023-08-10T14:40:28.627' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'1A01743SFL', N'LINDSAY', N'SOLA FERNANDEZ', N'Administrador', N'00055840387979', N'Cochabamba', CAST(N'2023-08-10T14:40:28.627' AS DateTime), CAST(N'2023-08-10T14:40:28.627' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'1A01983ARM', N'MARLENE', N'APAZA RIOS', N'Administrador', N'00055840455564', N'Cochabamba', CAST(N'2023-08-10T14:40:28.627' AS DateTime), CAST(N'2023-08-10T14:40:28.627' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'AAA0031133', N'ALEJANDRA', N'ALIENDRE ALANES', N'Estudiante', N'00077314431519', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ACS0032471', N'SHEILA', N'AVILA CHAVEZ', N'Estudiante', N'00077317543535', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ADC0029584', N'CRISTHIAN', N'AVILA DELGADILLO', N'Estudiante', N'00060135464984', N'Cochabamba', CAST(N'2023-09-05T13:35:04.087' AS DateTime), CAST(N'2023-09-05T13:35:04.087' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'AFA0031046', N'ANDREA', N'AREVALO FUENTES', N'Estudiante', N'00077314432302', N'Cochabamba', CAST(N'2023-08-30T10:26:51.067' AS DateTime), CAST(N'2023-08-30T10:26:51.067' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ALB0031565', N'BENJAMIN', N'ALCOBA LOAYZA', N'Estudiante', N'00060135449088', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'APM0033556', N'MAK', N'AYALA PALOMINO', N'Estudiante', N'00077317565045', N'Cochabamba', CAST(N'2023-08-04T08:30:44.057' AS DateTime), CAST(N'2023-08-04T08:30:44.057' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'APN0028250', N'NAYELI', N'ANCE PUMA', N'Estudiante', N'00055840426429', N'Cochabamba', CAST(N'2023-08-08T16:31:25.303' AS DateTime), CAST(N'2023-08-08T16:31:25.303' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ARD0031847', N'DIEGO', N'AREVALO ROJAS', N'Estudiante', N'00077314469828', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ASM5001681', N'MARIAN', N'ALBA SANCHEZ', N'Estudiante', N'00077317560233', N'Cochabamba', CAST(N'2023-08-04T11:15:30.677' AS DateTime), CAST(N'2023-08-04T11:15:30.677' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ASY0033459', N'YENIFER', N'ARCE SARAVIA', N'Estudiante', N'00077317550588', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BBF0034003', N'FILIPPO', N'BONGIORNO BARRIOS', N'Estudiante', N'00077317567569', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BBG0026642', N'GUSTAVO', N'BARBERY BLANCO', N'Estudiante', N'00055840442225', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BEK0033676', N'KRISHNA', N'BOBADILLA ESPINOLA', N'Estudiante', N'00317837755042', N'Cochabamba', CAST(N'2023-08-28T12:35:42.443' AS DateTime), CAST(N'2023-08-28T12:35:42.443' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BFN1010270', N'NAYRA', N'BECERRA FERNANDEZ', N'Estudiante', N'00060135457784', N'Cochabamba', CAST(N'2023-08-08T16:31:25.303' AS DateTime), CAST(N'2023-08-08T16:31:25.303' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BQM0031388', N'MAYA', N'BALLON QUEREJAZU', N'Estudiante', N'00077314440669', N'Cochabamba', CAST(N'2023-08-11T13:57:54.113' AS DateTime), CAST(N'2023-08-11T13:57:54.113' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BQP2019457', N'POL', N'BALLESTEROS QUIROGA', N'Estudiante', N'00055840444710', N'Cochabamba', CAST(N'2023-09-01T11:09:28.523' AS DateTime), CAST(N'2023-09-01T11:09:28.523' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BVM0031361', N'MOISES', N'BEJARANO VACAFLOR', N'Estudiante', N'00077314444618', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BVM0033328', N'MARCELO', N'BERRIOS VILLA', N'Estudiante', N'00077317538449', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'BVR5001132', N'RAMIRO', N'BORDA VILLARROEL', N'Estudiante', N'00060135450291', N'Cochabamba', CAST(N'2023-08-10T14:40:28.627' AS DateTime), CAST(N'2023-08-10T14:40:28.627' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CBA0029937', N'ANDRES', N'CASTEL BELMONTE', N'Estudiante', N'00322132588732', N'Cochabamba', CAST(N'2023-08-25T12:42:44.753' AS DateTime), CAST(N'2023-08-25T12:42:44.753' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CCB0030067', N'BRANDON', N'COCA CRESPO', N'Estudiante', N'00060135481787', N'Cochabamba', CAST(N'2023-08-25T15:36:25.360' AS DateTime), CAST(N'2023-08-25T15:36:25.360' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CCR0025530', N'RUTH', N'CRUZ CANAVIRI', N'Estudiante', N'00055840435311', N'Cochabamba', CAST(N'2023-08-30T14:44:11.953' AS DateTime), CAST(N'2023-08-30T14:44:11.953' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CDB0034346', N'BRANDON', N'CARTAGENA DELGADILLO', N'Estudiante', N'00317837755086', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CFA0034184', N'AZUCENA', N'CALI FLORES', N'Estudiante', N'00322132541639', N'Cochabamba', CAST(N'2023-08-03T16:38:38.957' AS DateTime), CAST(N'2023-08-03T16:38:38.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CGL5001349', N'LUIS', N'COPA GUARACHI', N'Estudiante', N'00060135512410', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CHM0031867', N'MARIA', N'CCOPA HUAMAN', N'Estudiante', N'00077317575354', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CJP0028425', N'PABLO', N'CALDERON JORDAN', N'Estudiante', N'00055840435924', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CLS0032909', N'SHARON', N'CHIPANA LOPEZ', N'Estudiante', N'00077317569397', N'Cochabamba', CAST(N'2023-08-28T16:57:55.690' AS DateTime), CAST(N'2023-08-28T16:57:55.690' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CPE0028860', N'ERICK', N'CHAMBI PUMA', N'Estudiante', N'00055840379322', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CPJ0029768', N'JHOSELIN', N'COARITE PAUCARA', N'Estudiante', N'00077317573426', N'Cochabamba', CAST(N'2023-09-05T16:03:41.467' AS DateTime), CAST(N'2023-09-05T16:03:41.467' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CQH0034216', N'HEYDI', N'CHURA QUISPE', N'Estudiante', N'00317837769678', N'Cochabamba', CAST(N'2023-08-29T16:06:53.217' AS DateTime), CAST(N'2023-08-29T16:06:53.217' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CSL1009878', N'LEIDY', N'CASTELLON SANCHEZ', N'Estudiante', N'00055840395491', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'CVI5001819', N'IGNACIO', N'CALVO VELASCO', N'Estudiante', N'00317837723528', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'DGE0028460', N'ELIANA', N'DELGADILLO GONZALEZ', N'Estudiante', N'00055840440349', N'Cochabamba', CAST(N'2023-08-28T16:57:55.690' AS DateTime), CAST(N'2023-08-28T16:57:55.690' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'EGA0031071', N'ALVARO', N'ECHEVERRIA GARCIA', N'Estudiante', N'00077314437728', N'Cochabamba', CAST(N'2023-09-01T13:53:53.107' AS DateTime), CAST(N'2023-09-01T13:53:53.107' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'EMJ0033301', N'JOISE', N'ESPINOLA MORALES', N'Estudiante', N'00317837723451', N'Cochabamba', CAST(N'2023-08-28T11:55:33.240' AS DateTime), CAST(N'2023-08-28T11:55:33.240' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ERD0031655', N'DANIELA', N'ESTRADA RODRIGUEZ', N'Estudiante', N'00060135450359', N'Cochabamba', CAST(N'2023-09-05T12:01:09.533' AS DateTime), CAST(N'2023-09-05T12:01:09.533' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'FAF0033841', N'FERMARTH', N'FARFAN ABASTOFLOR', N'Estudiante', N'00077317560657', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'FCA0033428', N'ALEJANDRO', N'FLORES CARDENAS', N'Estudiante', N'00077317560445', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'FPM0029894', N'MANUEL', N'FLORES PRADA', N'Estudiante', N'00077314452635', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'FVA2019246', N'ANA', N'FERNANDEZ VERGARA', N'Estudiante', N'00055840429575', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'FVS0029774', N'SEBASTIAN', N'FUENTES VILLARROEL', N'Estudiante', N'00060135436015', N'Cochabamba', CAST(N'2023-08-04T11:15:30.677' AS DateTime), CAST(N'2023-08-04T11:15:30.677' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'GCP0033197', N'PATRICIA', N'GOMEZ CATACORA', N'Estudiante', N'00077317545060', N'Cochabamba', CAST(N'2023-08-11T12:14:16.497' AS DateTime), CAST(N'2023-08-11T12:14:16.497' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'GFC0032235', N'CARLOS', N'GARCIA FORONDA', N'Estudiante', N'00077314446633', N'Cochabamba', CAST(N'2023-08-28T15:10:58.977' AS DateTime), CAST(N'2023-08-28T15:10:58.977' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'GFJ1010562', N'JOSE', N'GUTIERREZ FUENTES', N'Estudiante', N'00077317564760', N'Cochabamba', CAST(N'2023-08-11T11:02:53.360' AS DateTime), CAST(N'2023-08-11T11:02:53.360' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'HVJ0033927', N'JOSE', N'HUAMÁN VARGAS', N'Estudiante', N'00077317553803', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ITH0033916', N'HEIDY', N'IBAÑEZ TRONCOSO', N'Estudiante', N'00077317543005', N'Cochabamba', CAST(N'2023-08-29T16:06:53.217' AS DateTime), CAST(N'2023-08-29T16:06:53.217' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'JKF0025173', N'FLAVIA', N'JORDAN KOLLROS', N'Estudiante', N'00077317577154', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'JSV0029741', N'VALENTINA', N'JALDIN SIERRA', N'Estudiante', N'00060135446370', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'JTF0032089', N'FRANCISCA', N'JARA TORRES', N'Estudiante', N'00077314455481', N'Cochabamba', CAST(N'2023-08-11T12:14:16.497' AS DateTime), CAST(N'2023-08-11T12:14:16.497' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LAD2019288', N'DANIEL', N'LIMA ALCALA', N'Estudiante', N'00055840415543', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LAS0032355', N'SEBASTIAN', N'LIBERA ARRAZOLA', N'Estudiante', N'00077314224404', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LCE0032181', N'ELIZABETH', N'LOVON CRUZ', N'Estudiante', N'00322132678402', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LSA0029837', N'ALDAIR', N'LOPEZ SANCHEZ', N'Estudiante', N'00077314462523', N'Cochabamba', CAST(N'2023-08-11T13:57:54.113' AS DateTime), CAST(N'2023-08-11T13:57:54.113' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LTL0033708', N'LUCIANA', N'LOPEZ TORRICO', N'Estudiante', N'00077317562538', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'LVM0031907', N'MARIO', N'LAZARTE VEGA', N'Estudiante', N'00077316176529', N'Cochabamba', CAST(N'2023-08-29T16:06:53.217' AS DateTime), CAST(N'2023-08-29T16:06:53.217' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MAC0033675', N'CRISTIAN', N'MAMANI APAZA', N'Estudiante', N'00077317562319', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MAM0029981', N'MICAELA', N'MENDOZA ALANIS', N'Estudiante', N'00060135509979', N'Cochabamba', CAST(N'2023-09-05T16:03:41.467' AS DateTime), CAST(N'2023-09-05T16:03:41.467' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MBR0030140', N'RUBEN', N'MUÑOZ BASCOPE', N'Estudiante', N'00060135451217', N'Cochabamba', CAST(N'2023-09-04T10:15:36.707' AS DateTime), CAST(N'2023-09-04T10:15:36.707' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MCJ0033702', N'JUAN', N'MACHACA COA', N'Estudiante', N'00077317554149', N'Cochabamba', CAST(N'2023-09-05T11:02:24.987' AS DateTime), CAST(N'2023-09-05T11:02:24.987' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MCS0030352', N'SEBASTIAN', N'MONTAÑO CRUZ', N'Estudiante', N'00060135447114', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MHA0030917', N'ANGEL', N'MENDOZA HERRERA', N'Estudiante', N'00077314471217', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MHM0031469', N'MARIO', N'MENDOZA HIDALGO', N'Estudiante', N'00077317574337', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MLI0033466', N'ISABEL', N'MERCADO LOZA', N'Estudiante', N'00077317542801', N'Cochabamba', CAST(N'2023-09-05T12:01:09.533' AS DateTime), CAST(N'2023-09-05T12:01:09.533' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MPN0031406', N'NATALIA', N'MEJIA PALMA', N'Estudiante', N'00077314435416', N'Cochabamba', CAST(N'2023-08-11T13:57:54.113' AS DateTime), CAST(N'2023-08-11T13:57:54.113' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MSJ0032778', N'JOHANN', N'MEJIA SOTO', N'Estudiante', N'00077317564010', N'Cochabamba', CAST(N'2023-09-01T12:47:31.737' AS DateTime), CAST(N'2023-09-01T12:47:31.737' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MUJ0034054', N'JOSEPH', N'MARAÑON UZQUEDA', N'Estudiante', N'00077317557490', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'MZI0034039', N'ISADORA', N'MORALES ZUÑIGA', N'Estudiante', N'00077317545407', N'Cochabamba', CAST(N'2023-08-29T13:22:28.503' AS DateTime), CAST(N'2023-08-29T13:22:28.503' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'OCR0031574', N'RUT', N'ORELLANA CAYO', N'Estudiante', N'00077314460233', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ODD0033308', N'DIEGO', N'OLMOS DELGADO', N'Estudiante', N'00077317554284', N'Cochabamba', CAST(N'2023-09-01T16:23:46.103' AS DateTime), CAST(N'2023-09-01T16:23:46.103' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'OTR5001093', N'RAMIRO', N'ORELLANA TORRICO', N'Estudiante', N'00317837713418', N'Cochabamba', CAST(N'2023-08-30T14:44:11.953' AS DateTime), CAST(N'2023-08-30T14:44:11.953' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PCD5000480', N'DIEGO', N'PAZ CORTEZ', N'Estudiante', N'00055840403089', N'Cochabamba', CAST(N'2023-09-01T13:53:53.107' AS DateTime), CAST(N'2023-09-01T13:53:53.107' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PGI0033546', N'IGNACIO', N'PINTO GARCIA', N'Estudiante', N'00077317560164', N'Cochabamba', CAST(N'2023-08-29T17:15:08.567' AS DateTime), CAST(N'2023-08-29T17:15:08.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PI0028776', N'ENRIQUE', N'PEREZ IVAN', N'Estudiante', N'00077317543716', N'Cochabamba', CAST(N'2023-08-25T14:50:58.847' AS DateTime), CAST(N'2023-08-25T14:50:58.847' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PIS0032282', N'SANTIAGO', N'POLO IÑIGUEZ', N'Estudiante', N'00077314433180', N'Cochabamba', CAST(N'2023-09-01T13:53:53.107' AS DateTime), CAST(N'2023-09-01T13:53:53.107' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PLM1010617', N'MARINA', N'PEREDO LIZARAZU', N'Estudiante', N'00060135509901', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PMY3005445', N'YAMIRA', N'PINEDA MARTINEZ', N'Estudiante', N'00077317561325', N'Cochabamba', CAST(N'2023-08-28T15:10:58.977' AS DateTime), CAST(N'2023-08-28T15:10:58.977' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PRC0029343', N'CARLA', N'PIZARRO RAMOS', N'Estudiante', N'00055840450619', N'Cochabamba', CAST(N'2023-08-03T16:38:38.957' AS DateTime), CAST(N'2023-08-03T16:38:38.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PRJ0030099', N'JAIDER', N'PINTO RIBERA', N'Estudiante', N'00077316191278', N'Cochabamba', CAST(N'2023-08-29T16:06:53.217' AS DateTime), CAST(N'2023-08-29T16:06:53.217' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PTM0031384', N'MEGAN', N'PEÑARANDA TORRICO', N'Estudiante', N'00060135502933', N'Cochabamba', CAST(N'2023-08-11T13:57:54.113' AS DateTime), CAST(N'2023-08-11T13:57:54.113' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'PVN0028998', N'NICOLAS', N'PAIRUMANI VELASQUEZ', N'Estudiante', N'00343601458216', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'QAS0030770', N'SAUL', N'QUISPE ARO', N'Estudiante', N'00060135391249', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'QMA1010884', N'ALAN', N'QUISPE MAMANI', N'Estudiante', N'00322132580485', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RAD0030233', N'DANIEL', N'RODRIGUEZ ARIZAGA', N'Estudiante', N'00060135384323', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RCA0028192', N'ANGELA', N'REYES CHOQUE', N'Estudiante', N'00055840354830', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RCA0034174', N'ALDO', N'RODRIGUEZ CURI', N'Estudiante', N'00322132566466', N'Cochabamba', CAST(N'2023-08-25T15:36:25.360' AS DateTime), CAST(N'2023-08-25T15:36:25.360' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RLC5001752', N'CYNTHIA', N'RUIZ LIZARRAGA', N'Estudiante', N'00077317571784', N'Cochabamba', CAST(N'2023-08-25T10:25:29.273' AS DateTime), CAST(N'2023-08-25T10:25:29.273' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RLF0033311', N'FABIANA', N'ROJAS LIZARRAGA', N'Estudiante', N'00077317550558', N'Cochabamba', CAST(N'2023-08-11T12:14:16.497' AS DateTime), CAST(N'2023-08-11T12:14:16.497' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RMA1010551', N'ALEJANDRO', N'ROCABADO MEDRANO', N'Estudiante', N'00060135436049', N'Cochabamba', CAST(N'2023-08-29T16:06:53.217' AS DateTime), CAST(N'2023-08-29T16:06:53.217' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ROA1010505', N'ALISON', N'RAMIREZ OVIEDO', N'Estudiante', N'00077317549969', N'Cochabamba', CAST(N'2023-09-04T11:52:36.633' AS DateTime), CAST(N'2023-09-04T11:52:36.633' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'RPR0032580', N'RUTH', N'RAMIREZ PACO', N'Estudiante', N'00077317571214', N'Cochabamba', CAST(N'2023-08-04T11:15:30.677' AS DateTime), CAST(N'2023-08-04T11:15:30.677' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SAP0027763', N'PABLO', N'SANCHEZ ALMENDRAS', N'Estudiante', N'00055840402015', N'Cochabamba', CAST(N'2023-08-03T16:38:38.957' AS DateTime), CAST(N'2023-08-03T16:38:38.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SAR0029947', N'RAUL', N'SALINAS ACHA', N'Estudiante', N'00077317549740', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SDD0031489', N'CASTILLO', N'SULLCA DEL', N'Estudiante', N'00060135499285', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SFJ5001331', N'JUAN', N'SERRANO FLORES', N'Estudiante', N'00322132565117', N'Cochabamba', CAST(N'2023-08-28T11:31:23.577' AS DateTime), CAST(N'2023-08-28T11:31:23.577' AS DateTime), N'AC')
GO
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SGB0033389', N'BENJAMIN', N'MURILLO GONZALEZ', N'Estudiante', N'00077317548298', N'Cochabamba', CAST(N'2023-08-29T13:22:28.503' AS DateTime), CAST(N'2023-08-29T13:22:28.503' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SMD0025695', N'DAVID', N'SANCHEZ MURIEL', N'Estudiante', N'00317837759635', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'SMF0031914', N'FERNANDA', N'SEGOVIA MONTENEGRO', N'Estudiante', N'00077314445758', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'STF0032816', N'FABRIZIO', N'SILVA THOMPSON', N'Estudiante', N'00077317575046', N'Cochabamba', CAST(N'2023-08-03T12:03:54.667' AS DateTime), CAST(N'2023-08-03T12:03:54.667' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'STS0029678', N'SEBASTIAN', N'SILES TORRICO', N'Estudiante', N'00077317559054', N'Cochabamba', CAST(N'2023-09-05T12:01:09.533' AS DateTime), CAST(N'2023-09-05T12:01:09.533' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'TAC0033923', N'CHRISTIAN', N'TERRAZA ALMENDRA', N'Estudiante', N'00077317570068', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'TLM0029990', N'TORRE', N'TICONA LA', N'Estudiante', N'00060135495460', N'Cochabamba', CAST(N'2023-08-04T11:15:30.677' AS DateTime), CAST(N'2023-08-04T11:15:30.677' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'TRC0029674', N'CAMILA', N'TAPIA ROCABADO', N'Estudiante', N'00060135484023', N'Cochabamba', CAST(N'2023-08-14T08:35:55.200' AS DateTime), CAST(N'2023-08-14T08:35:55.200' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'TVB0031379', N'BRUNO', N'TRIVEÑO VALENZUELA', N'Estudiante', N'00077314452337', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'UQB1010537', N'BILLY', N'USCA QUITO', N'Estudiante', N'00077314433833', N'Cochabamba', CAST(N'2023-08-25T13:39:34.237' AS DateTime), CAST(N'2023-08-25T13:39:34.237' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'VAP0031740', N'PAOLA', N'VILLARROEL ARISPE', N'Estudiante', N'00077314453899', N'Cochabamba', CAST(N'2023-09-05T13:35:04.087' AS DateTime), CAST(N'2023-09-05T13:35:04.087' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'VLN1010459', N'NATALIA', N'VILLARROEL LOPEZ', N'Estudiante', N'00060135461070', N'Cochabamba', CAST(N'2023-09-05T12:01:09.533' AS DateTime), CAST(N'2023-09-05T12:01:09.533' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'VMM0031901', N'MARVIN', N'VELASCO MAMANI', N'Estudiante', N'00322132547225', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'VRJ2019150', N'JHONNY', N'VIZA RAMOS', N'Estudiante', N'00343601804334', N'Cochabamba', CAST(N'2023-08-25T12:42:44.753' AS DateTime), CAST(N'2023-08-25T12:42:44.753' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'VUS0032480', N'SERGIO', N'VARGAS URQUIZU', N'Estudiante', N'00077317575390', N'Cochabamba', CAST(N'2023-08-04T12:59:09.917' AS DateTime), CAST(N'2023-08-04T12:59:09.917' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'YRC0031199', N'CRISTIAN', N'YUCRA RUEDA', N'Estudiante', N'00077314453359', N'Cochabamba', CAST(N'2023-09-04T14:42:57.033' AS DateTime), CAST(N'2023-09-04T14:42:57.033' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ZCE5000936', N'EMMA', N'ZELADA CONDE', N'Estudiante', N'00322132588855', N'Cochabamba', CAST(N'2023-08-30T12:31:15.957' AS DateTime), CAST(N'2023-08-30T12:31:15.957' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ZIC0031845', N'CATALINA', N'ZEPEDA IBARRA', N'Estudiante', N'00077314452563', N'Cochabamba', CAST(N'2023-08-28T13:20:39.427' AS DateTime), CAST(N'2023-08-28T13:20:39.427' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ZRJ0032409', N'JHONN', N'ZUÑIGA ROJAS', N'Estudiante', N'00322132738124', N'Cochabamba', CAST(N'2023-08-03T13:16:19.567' AS DateTime), CAST(N'2023-08-03T13:16:19.567' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ZSA1010695', N'ALVARO', N'ZURITA SALAS', N'Estudiante', N'00077317565740', N'Cochabamba', CAST(N'2023-08-30T15:49:37.563' AS DateTime), CAST(N'2023-08-30T15:49:37.563' AS DateTime), N'AC')
INSERT [dbo].[RUsuarioNetvalle] ([CodigoUsuarioNetvalle], [NombresUsuarioNetvalle], [ApellidosUsuarioNetvalle], [CargoUsuarioNetvalle], [TarjetaUsuarioNetvalle], [SedeUsuarioNetvalle], [FechaRegistroUsuarioNetvalle], [FechaModificacionUsuarioNetvalle], [EstadoUsuarioNetvalle]) VALUES (N'ZVA0034314', N'ALEJANDRA', N'ZURITA VALENCIA', N'Estudiante', N'00317837770443', N'Cochabamba', CAST(N'2023-08-03T09:35:46.450' AS DateTime), CAST(N'2023-08-03T09:35:46.450' AS DateTime), N'AC')
GO
SET IDENTITY_INSERT [dbo].[RVoto] ON 

INSERT [dbo].[RVoto] ([CodigoUsuario], [CampaniaVoto], [OrganizacionVoto], [FechaRegistroVoto], [DonacionVoto], [EstadoVoto], [FechaModificacionVoto], [IdVoto]) VALUES (N'FVS0029774', N'CB-REFUGIO DE ANIMALES-2_2023', N'una mano una patita', CAST(N'2023-08-31T14:13:06.000' AS DateTime), CAST(0 AS Numeric(6, 0)), N'VA', CAST(N'2023-08-31T14:13:06.000' AS DateTime), 2002)
SET IDENTITY_INSERT [dbo].[RVoto] OFF
GO
ALTER TABLE [dbo].[RCampania] ADD  CONSTRAINT [DF_Campaña_Estado]  DEFAULT ((1)) FOR [EstadoCampania]
GO
/****** Object:  StoredProcedure [dbo].[RCampania_A]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_A]
@nombreCampania VARCHAR(60),
@descripcionCampania TEXT,
@fechaInicioCampania DATE,
@fechaFinCampania DATE,
@sedeCampania VARCHAR(15),
@estadoCampania CHAR(2),
@fechaModificacionCampania DATETIME
AS
BEGIN
		UPDATE RCampania 
		SET DescripcionCampania=@descripcionCampania,FechaInicioCampania=@fechaInicioCampania,FechaFinCampania=@fechaFinCampania,
		FechaModificacionCampania=@fechaModificacionCampania,SedeCampania=@sedeCampania
		WHERE NombreCampania=@nombreCampania AND EstadoCampania=@estadoCampania
END
GO
/****** Object:  StoredProcedure [dbo].[RCampania_A_Estado]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_A_Estado]
@nombreCampania VARCHAR(60),
@estadoCampaniaF CHAR(2),
@fechaModificacionCampania DATETIME
AS
BEGIN
	UPDATE RCampania 
	SET EstadoCampania= @estadoCampaniaF, FechaModificacionCampania=@fechaModificacionCampania 
	WHERE NombreCampania=@nombreCampania
END
GO
/****** Object:  StoredProcedure [dbo].[RCampania_A_Estado_Cancelado]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_A_Estado_Cancelado]
@nombreCampania VARCHAR(60),
@estadoCampania CHAR(2),
@fechaModificacionCampania DATETIME
AS
BEGIN
		UPDATE RCampania 
		SET FechaModificacionCampania=@fechaModificacionCampania, EstadoCampania=@estadoCampania
		WHERE NombreCampania=@nombreCampania
END
GO
/****** Object:  StoredProcedure [dbo].[RCampania_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_I]
@nombreCampania VARCHAR(60),
@descripcionCampania TEXT,
@fechaInicioCampania DATE,
@fechaFinCampania DATE,
@sedeCampania VARCHAR(15),
@estadoCampania CHAR(2),
@fechaModificacionCampania DATETIME,
@fechaRegistroCampania DATETIME

AS
BEGIN
INSERT INTO RCampania (NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, 
	EstadoCampania, SedeCAmpania, FechaRegistroCampania, FechaModificacionCampania)
	VALUES (@nombreCampania, @descripcionCampania, @fechaInicioCampania, @fechaFinCampania, @estadoCampania,@sedeCampania, 
	@fechaModificacionCampania, @fechaModificacionCampania)
END
GO
/****** Object:  StoredProcedure [dbo].[RCampania_O]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_O]

AS
BEGIN
SELECT NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, EstadoCampania, SedeCampania, FechaRegistroCampania, FechaModificacionCampania
FROM  RCampania 

END
GO
/****** Object:  StoredProcedure [dbo].[RCampania_O_Sede]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampania_O_Sede]
@sedeCampania VARCHAR(15),
@estadoCampania CHAR(2)
AS
BEGIN
SELECT NombreCampania, DescripcionCampania, FechaInicioCampania, FechaFinCampania, EstadoCampania, SedeCampania, FechaRegistroCampania, FechaModificacionCampania
FROM RCampania
WHERE SedeCampania = @sedeCampania AND EstadoCampania = @estadoCampania
END
GO
/****** Object:  StoredProcedure [dbo].[RCampaniaOrganizacion_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampaniaOrganizacion_I] 
@campaniaCampaniaOrganizacion VARCHAR(60),
@organizacionCampaniaOrganizacion VARCHAR(80) ,
@estadoCampaniaOrganizacion CHAR(2),
@fechaRegistroCampaniaOrganizacion DATETIME,
@fechaModificacionCampaniaOrganizacion DATETIME
AS
BEGIN
	INSERT INTO RCampaniaOrganizacion(CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion,EstadoCampaniaOrganizacion,
	FechaModificacionCampaniaOrganizacion,FechaRegistroCampaniaOrganizacion)
	 VALUES (@campaniaCampaniaOrganizacion, @organizacionCampaniaOrganizacion,@estadoCampaniaOrganizacion, 
	 @fechaRegistroCampaniaOrganizacion, @fechaModificacionCampaniaOrganizacion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[RCampaniaOrganizacion_O_Campania]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RCampaniaOrganizacion_O_Campania]
@campaniaCampaniaOrganizacion VARCHAR(60)
AS
BEGIN
SELECT CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion, FechaRegistroCampaniaOrganizacion,IdCampaniaOrganizacion,EstadoCampaniaOrganizacion, FechaModificacionCampaniaOrganizacion
FROM RCampaniaOrganizacion
WHERE CampaniaCampaniaOrganizacion = @campaniaCampaniaOrganizacion
END
GO
/****** Object:  StoredProcedure [dbo].[RContenedor_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RContenedor_I](
@codigoUsuario VARCHAR(14),
@maquinaContenedor TINYINT, 
@gramosContenedor VARCHAR(14),
@fechaRegistroContenedor DATETIME,
@estadoContenedor CHAR(2),
@fechaModificacionContenedor DATETIME)

AS
BEGIN 
    INSERT INTO RContenedor(CodigoUsuario, IdMaquinaContenedor, GramosContenedor, FechaRegistroContenedor,
			FechaModificacionContenedor,EstadoContenedor)
	VALUES(@codigoUsuario, @maquinaContenedor, CONVERT(DECIMAL(7,2), @gramosContenedor), @fechaRegistroContenedor,
	@fechaModificacionContenedor,@estadoContenedor)
END

GO
/****** Object:  StoredProcedure [dbo].[RContenedor_O_Codigo]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RContenedor_O_Codigo](@codigoUsuario VARCHAR(14))AS

BEGIN 
    SELECT CodigoUsuario,IdMaquinaContenedor,GramosContenedor,FechaRegistroContenedor, IdContenedor, EstadoContenedor, FechaModificacionContenedor 
	FROM RContenedor WHERE CodigoUsuario = @codigoUsuario

END
GO
/****** Object:  StoredProcedure [dbo].[RImagen_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RImagen_I] 
@nombreImagen VARCHAR(80), 
@tipoImagen TINYINT, 
@organizacionImagen VARCHAR(80),
@estadoImagen CHAR(2),
@fechaRegistroImagen DATETIME,
@fechaModificacion DATETIME
AS
BEGIN
	INSERT INTO RImagen(NombreImagen, TipoImagen, OrganizacionImagen,EstadoImagen,
	FechaModificacionImagen,FechaRegistroImagen)
	VALUES (@nombreImagen, @tipoImagen,@organizacionImagen,@estadoImagen,@fechaModificacion,@fechaRegistroImagen)
END
GO
/****** Object:  StoredProcedure [dbo].[RImagen_O_Organizacion]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RImagen_O_Organizacion]
@organizacionImagen VARCHAR(80), @tipoImagen TINYINT
AS
BEGIN
SELECT NombreImagen, OrganizacionImagen
FROM RImagen
WHERE OrganizacionImagen = @organizacionImagen AND TipoImagen = @tipoImagen
END
GO
/****** Object:  StoredProcedure [dbo].[ROrganizacion_A]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ROrganizacion_A] 
@nombreOrganizacion VARCHAR(80),
@descripcionOrganizacion TEXT ,
@fechaModificacionOrganizacion DATETIME,
@estadoOrganizacion CHAR(2)
AS
BEGIN
	UPDATE ROrganizacion SET DescripcionOrganizacion=@descripcionOrganizacion, 
	FechaModificacionOrganizacion=@fechaModificacionOrganizacion, 
	EstadoOrganizacion=@estadoOrganizacion WHERE NombreOrganizacion=@NombreOrganizacion	
END
GO
/****** Object:  StoredProcedure [dbo].[ROrganizacion_E_Nombre]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ROrganizacion_E_Nombre]
@nombreOrganizacion VARCHAR(80),
@estadoOrganizacion CHAR(2),
@fechaActualizacion DATETIME
AS
BEGIN
	UPDATE ROrganizacion SET EstadoOrganizacion=@estadoOrganizacion, FechaModificacionOrganizacion=@fechaActualizacion WHERE NombreOrganizacion=@nombreOrganizacion
END
GO
/****** Object:  StoredProcedure [dbo].[ROrganizacion_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ROrganizacion_I] 
@nombreOrganizacion VARCHAR(80),
@descripcionOrganizacion TEXT,
@estadoOrganizacion CHAR(2),
@fechaRegistroOrganizacion DATETIME,
@fechaModificacionOrganizacion DATETIME
AS
BEGIN
	INSERT INTO ROrganizacion (NombreOrganizacion, DescripcionOrganizacion, EstadoOrganizacion,FechaRegistroOrganizacion,FechaModificacionOrganizacion)
	VALUES (@nombreOrganizacion, @descripcionOrganizacion,@estadoOrganizacion ,@fechaRegistroOrganizacion,@fechaModificacionOrganizacion)
END
GO
/****** Object:  StoredProcedure [dbo].[ROrganizacion_O_Nombre]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ROrganizacion_O_Nombre]
@nombreOrganizacion VARCHAR(80)
AS
BEGIN
SELECT NombreOrganizacion, DescripcionOrganizacion, EstadoOrganizacion
FROM ROrganizacion
WHERE NombreOrganizacion = @nombreOrganizacion
END
GO
/****** Object:  StoredProcedure [dbo].[ROrganizaciones_O]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ROrganizaciones_O] 
@estadoOrganizacion CHAR(2)
AS
BEGIN
	SELECT NombreOrganizacion, DescripcionOrganizacion, EstadoOrganizacion, FechaRegistroOrganizacion,FechaModificacionOrganizacion FROM ROrganizacion WHERE EstadoOrganizacion=@estadoOrganizacion
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuario_A_Creditos_Codigo]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuario_A_Creditos_Codigo] 
@codigoUsuario VARCHAR(14),
@creditosUsuario NUMERIC(6,0)
AS
BEGIN 
    UPDATE RUsuario SET CreditosUsuario=(CreditosUsuario+@creditosUsuario) WHERE CodigoUsuario=@codigoUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuario_O_Codigo]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuario_O_Codigo] 
@codigoUsuario VARCHAR(14)
AS
BEGIN
	SELECT CodigoUsuario, CreditosUsuario, RolUsuario FROM RUsuario WHERE CodigoUsuario=@codigoUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarioNetvalle_O_Codigo]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarioNetvalle_O_Codigo]
@codigoUsuarioNetvalle VARCHAR(14)
AS
BEGIN
	SELECT CodigoUsuarioNetvalle, NombresUsuarioNetvalle, ApellidosUsuarioNetvalle, CargoUsuarioNetvalle, TarjetaUsuarioNetvalle, SedeUsuarioNetvalle FROM RUsuarioNetvalle WHERE CodigoUsuarioNetvalle=@codigoUsuarioNetvalle
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarioNetvalle_O_Tarjeta]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarioNetvalle_O_Tarjeta]
(@tarjetaUsuarioNetvalle VARCHAR(16)) 
AS 
BEGIN
	SELECT R.CodigoUsuarioNetvalle, R.NombresUsuarioNetvalle, R.ApellidosUsuarioNetvalle, R.CargoUsuarioNetvalle, 
	R.TarjetaUsuarioNetvalle, R.SedeUsuarioNetvalle 
	FROM RUsuarioNetvalle R 
	WHERE TarjetaUsuarioNetvalle = @tarjetaUsuarioNetvalle
END

GO
/****** Object:  StoredProcedure [dbo].[RUsuarioNetvalle_O_Top_Sede_Codigo]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarioNetvalle_O_Top_Sede_Codigo] 
@sedeUsuarioNetvalle VARCHAR(15), 
@codigoUsuarioNetvalle VARCHAR(14)
AS
BEGIN
	SELECT CodigoUsuarioNetvalle, NombresUsuarioNetvalle, ApellidosUsuarioNetvalle, CargoUsuarioNetvalle, TarjetaUsuarioNetvalle, SedeUsuarioNetvalle FROM RUsuarioNetvalle WHERE SedeUsuarioNetvalle=@sedeUsuarioNetvalle AND CodigoUsuarioNetvalle=@codigoUsuarioNetvalle
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarioNetvalle_RUsuaro_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarioNetvalle_RUsuaro_I] 
@roleUsuario VARCHAR(14),
@codigoUsuarioNetvalle VARCHAR(14),
@nombresUsuarioNetvalle VARCHAR(60),
@apellidosUsuarioNetvalle VARCHAR(60),
@cargoUsuarioNetvalle VARCHAR(14),
@tarjetaUsuarioNetvalle VARCHAR(14),
@sedeUsuarioNetvalle VARCHAR(15),
@fechaModificacionUsuarioNetvalle DATETIME,
@fechaRegistroUsuarioNetvalle DATETIME,
@estadoUsuarioNetvalle CHAR(2),
@creditosUsuario VARCHAR(10)
AS
BEGIN

BEGIN TRY
    BEGIN TRANSACTION;

    INSERT INTO RUsuarioNetvalle (CodigoUsuarioNetvalle,NombresUsuarioNetvalle,ApellidosUsuarioNetvalle,
	CargoUsuarioNetvalle,TarjetaUsuarioNetvalle,SedeUsuarioNetvalle,FechaModificacionUsuarioNetvalle,FechaRegistroUsuarioNetvalle
	,EstadoUsuarioNetvalle) 
	VALUES (@codigoUsuarioNetvalle,@nombresUsuarioNetvalle,@apellidosUsuarioNetvalle,@cargoUsuarioNetvalle,
	@tarjetaUsuarioNetvalle,@sedeUsuarioNetvalle,@fechaModificacionUsuarioNetvalle,@fechaRegistroUsuarioNetvalle,@estadoUsuarioNetvalle)
	INSERT INTO RUsuario (CodigoUsuario,RolUsuario,CreditosUsuario) VALUES (@codigoUsuarioNetvalle,@roleUsuario,CONVERT(NUMERIC(10,2), @creditosUsuario))

    COMMIT TRANSACTION;

    PRINT 'Transacción completada exitosamente.';
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;

    PRINT 'Error en la transacción: ' + ERROR_MESSAGE();
END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarios_A_Creditos_Sede]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarios_A_Creditos_Sede]
@codigoUsuarioNetvalle VARCHAR(14)
AS
BEGIN
	UPDATE RUsuario SET CreditosUsuario=0 WHERE CodigoUsuario=@codigoUsuarioNetvalle
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarios_O_Sede]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarios_O_Sede] 
@sedeUsuarioNetvalle VARCHAR(15)
AS
BEGIN
	SELECT CodigoUsuario, CreditosUsuario, RolUsuario from RUsuario R
	INNER JOIN RUsuarioNetvalle RU ON R.CodigoUsuario = RU.CodigoUsuarioNetvalle
	WHERE RU.SedeUsuarioNetvalle = @sedeUsuarioNetvalle
END
GO
/****** Object:  StoredProcedure [dbo].[RUsuarios_O_Top_Creditos]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RUsuarios_O_Top_Creditos]
@sedeUsuarioNetvalle VARCHAR(15)
AS
BEGIN
	select TOP 10 CodigoUsuario, CreditosUsuario, RolUsuario from RUsuario R
	INNER JOIN RUsuarioNetvalle RU ON R.CodigoUsuario = RU.CodigoUsuarioNetvalle
	WHERE RU.SedeUsuarioNetvalle = @sedeUsuarioNetvalle
	ORDER BY 2 DESC
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_A]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_A] 
@codigoUsuario VARCHAR(14), 
@donacionVoto NUMERIC(6,0),
@fechaModificacionVoto DATETIME
AS
BEGIN
	UPDATE RVoto SET DonacionVoto=@donacionVoto, fechaModificacionVoto=@fechaModificacionVoto WHERE CodigoUsuario=@codigoUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_I]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_I] 
@codigoUsuario VARCHAR(14),
@nombreCampania VARCHAR(30),
@nombreOrganizacion VARCHAR(60),
@fechaRegistroVoto DATETIME,
@fechaModificacionVoto DATETIME,
@estadoVoto CHAR(2),
@donacionVoto numeric(6,0)
AS
BEGIN
	INSERT INTO RVoto ( CodigoUsuario, CampaniaVoto, OrganizacionVoto,FechaRegistroVoto, FechaModificacionVoto, DonacionVoto, EstadoVoto)
	VALUES ( @codigoUsuario, @nombreCampania, @nombreOrganizacion, @fechaRegistroVoto ,@fechaModificacionVoto, @donacionVoto, @estadoVoto)
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_O_Codigo_Campania]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_O_Codigo_Campania]
@codigoUsuario VARCHAR(14),
@nombreCampania VARCHAR(60)
AS
BEGIN
	SELECT CodigoUsuario, CampaniaVoto, OrganizacionVoto, FechaRegistroVoto, DonacionVoto, EstadoVoto, FechaModificacionVoto, IdVoto FROM RVoto 
	WHERE CodigoUsuario=@codigoUsuario AND CampaniaVoto=@nombreCampania
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_O_Donacion_Maxima]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_O_Donacion_Maxima] 
@nombreCampania VARCHAR(60),
@estadoVoto VARCHAR(20)
AS
BEGIN
	SELECT TOP 1 CodigoUsuario, CampaniaVoto, OrganizacionVoto, FechaRegistroVoto, DonacionVoto, 
	EstadoVoto, FechaModificacionVoto 
	FROM RVoto 
	WHERE CampaniaVoto=@nombreCampania AND DonacionVoto=(SELECT MAX(DonacionVoto) FROM RVoto WHERE CampaniaVoto=@nombreCampania)
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_O_Donacion_Total]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_O_Donacion_Total]
@nombreCampaniaVoto VARCHAR(60)
AS
BEGIN
	SELECT SUM(DonacionVoto) FROM RVoto WHERE CampaniaVoto=@nombreCampaniaVoto
END
GO
/****** Object:  StoredProcedure [dbo].[RVoto_O_Organizacion]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVoto_O_Organizacion] 
@nombreCampania VARCHAR(60),
@estadoVoto CHAR(2)
AS
BEGIN
	SELECT OrganizacionVoto FROM RVoto 
	WHERE CampaniaVoto=@nombreCampania AND EstadoVoto=@estadoVoto 
	GROUP BY OrganizacionVoto 
	ORDER BY COUNT(OrganizacionVoto) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[RVotos_O_Campania]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVotos_O_Campania] 
@nombeCampaniaVoto VARCHAR(60),
@estadoVoto VARCHAR(20)
AS
BEGIN
	SELECT COUNT(*) FROM RVoto WHERE CampaniaVoto=@nombeCampaniaVoto AND EstadoVoto=@estadoVoto
END
GO
/****** Object:  StoredProcedure [dbo].[RVotos_O_Campania_Organizacion]    Script Date: 5/9/2023 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RVotos_O_Campania_Organizacion]
@campaniaVoto VARCHAR(60),
@nombreOrganizacionVoto VARCHAR(80),
@estadoVoto CHAR(2)
AS
BEGIN
	SELECT COUNT(*) FROM RVoto WHERE CampaniaVoto=@campaniaVoto AND OrganizacionVoto=@nombreOrganizacionVoto AND EstadoVoto=@estadoVoto
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de la campaña que se esta creando' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'NombreCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descriocion general de cual es la funcion o el motivo de la campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'DescripcionCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando iniciara la campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'FechaInicioCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de finalizacion de la campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'FechaFinCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Activa ="AC"
Finalizada ="FI"
Cancelada="CA"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'EstadoCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se esta registando una campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'FechaRegistroCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se realiza una modificacion en cualquiera de las columnas de la tabla campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampania', @level2type=N'COLUMN',@level2name=N'FechaModificacionCampania'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de las campañas que se generan ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'CampaniaCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Organizaciones que se almacenan en cada campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'OrganizacionCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se esta registrando de una campaña' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'FechaRegistroCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cuantas veces se esta generando una campaña
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'IdCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Activa ="AC"
Cancelada="CA"
Finalizada="FI"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'EstadoCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se modifico algun datos en alguna de las columas de la tabla
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RCampaniaOrganizacion', @level2type=N'COLUMN',@level2name=N'FechaModificacionCampaniaOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo Usuario referencia a la llave primaria de la Tabla RUsuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'CodigoUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IdMaquinaContendor referencia a la llave primaria de la Tabla RMaquina' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'IdMaquinaContenedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gramos contenedor registra el peso de las botellas que se insertaran en los equipos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'GramosContenedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FechaRegistroContenedor cuando se creo un nuevo contendor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'FechaRegistroContenedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IdContendor las veces que ese esta registrando botellas en el contenedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'IdContenedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FechaModificacionContendor actializacion de fecha cuando el contendor cambia algun parametro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RContenedor', @level2type=N'COLUMN',@level2name=N'FechaModificacionContenedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'llave primaria autoincremental de cuantos equipos o maquinas se estan registrando
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RMaquina', @level2type=N'COLUMN',@level2name=N'IdMaquina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre o dato para identificar al equipo registrado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RMaquina', @level2type=N'COLUMN',@level2name=N'DescripcionMaquina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'no hay un estado especifico por que no se esta realizando el registro de una maquina desde la aplicacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RMaquina', @level2type=N'COLUMN',@level2name=N'EstadoMaquina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se modifico algun parametro en alguna de las columas de la tabla RMaquina
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RMaquina', @level2type=N'COLUMN',@level2name=N'FechaModificacionMaquina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se creo una maquina' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RMaquina', @level2type=N'COLUMN',@level2name=N'FechaRegistroMaquina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de la organzacion que se crea' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ROrganizacion', @level2type=N'COLUMN',@level2name=N'NombreOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion general sobre la organizacion creada
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ROrganizacion', @level2type=N'COLUMN',@level2name=N'DescripcionOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Activa ="AC"
Cancelada="CA"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ROrganizacion', @level2type=N'COLUMN',@level2name=N'EstadoOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se creo una organizacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ROrganizacion', @level2type=N'COLUMN',@level2name=N'FechaRegistroOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se modifico algun dato en alguna de las columnas de la tabla organizacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ROrganizacion', @level2type=N'COLUMN',@level2name=N'FechaModificacionOrganizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo Usuario llave de identificacion de los usuarios ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuario', @level2type=N'COLUMN',@level2name=N'CodigoUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Los creditos son los puntos que se alamcenan cuando el usuario ha insertado una botella en el equipo de reciclaje, los creditos se asignaran en la configuracion del equipo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuario', @level2type=N'COLUMN',@level2name=N'CreditosUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario
Gerente
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuario', @level2type=N'COLUMN',@level2name=N'RolUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CodigoUsuarioNetvalle llave primaria que acepta las iniciales del nombre y apellidos y un codigo numerico de siete numeros aleatorios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'CodigoUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estudiante
Administrativo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'CargoUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo numerico de catorce digitos que estan en la tarjeta de estudiantes y docentes ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'TarjetaUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'emision de donde se emitio la tarjeta del erstudiante o del docente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'SedeUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cuando se creo un nuevo usuario netvalle
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'FechaRegistroUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cuando se actualizo algun dato del usuairo netvalle
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'FechaModificacionUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Activo ="AC"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RUsuarioNetvalle', @level2type=N'COLUMN',@level2name=N'EstadoUsuarioNetvalle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Utiliza la llave primaria que se creo en RUsuarioNetvalle para identificar que usuario esta realizando un voto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'CodigoUsuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de la campaña donde se esta realizando el voto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'CampaniaVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre de la organizacion por la que el usuario realizo una votacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'OrganizacionVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se realizo la votacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'FechaRegistroVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Son los creditos que se le asignaran al usuario cuando haga su votacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'DonacionVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valido ="VA"
Finalizada="FI"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'EstadoVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de cuando se realiza una modificacion en alguna de las columnas de la tabla RVoto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'FechaModificacionVoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'llave primaria incremental de cuantas veces se realizaron votaciones
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RVoto', @level2type=N'COLUMN',@level2name=N'IdVoto'
GO
