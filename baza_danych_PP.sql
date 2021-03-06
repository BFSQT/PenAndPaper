USE [P&P]
GO
/****** Object:  Table [dbo].[Konta]    Script Date: 14/06/2021 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Konta](
	[Id] [int] NOT NULL,
	[Login] [nvarchar](15) NULL,
	[Haslo] [nvarchar](20) NULL,
	[Mail] [nvarchar](30) NULL,
	[Nr_telefonu] [int] NULL,
	[Rodzaj_konta] [nvarchar](10) NULL,
 CONSTRAINT [pk_Id2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statystyki_pokoju]    Script Date: 14/06/2021 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statystyki_pokoju](
	[Nr_rzutu] [int] NOT NULL,
	[Id] [int] NULL,
	[Rodzaj_konta] [nvarchar](10) NULL,
	[Rzut_koscia] [int] NULL,
 CONSTRAINT [pk_Id3] PRIMARY KEY CLUSTERED 
(
	[Nr_rzutu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Konta] ([Id], [Login], [Haslo], [Mail], [Nr_telefonu], [Rodzaj_konta]) VALUES (1, N'OdkurzaczTomka', N'Haslo123', N'odkurzacztomka@gmail.com', 123456789, N'Gracz')
INSERT [dbo].[Konta] ([Id], [Login], [Haslo], [Mail], [Nr_telefonu], [Rodzaj_konta]) VALUES (2, N'CheekiBreeki', N'D123', N'CheekiBreeki@wp.com', 222888777, N'Gracz')
GO
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (1, 1, N'Gracz', 41)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (2, 1, N'Gracz', 92)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (3, 1, N'Gracz', 40)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (4, 0, NULL, -4)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (5, 0, NULL, 48)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (6, 0, NULL, 0)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (7, 0, NULL, 48)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (8, 0, NULL, 39)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (9, 0, NULL, 47)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (10, 0, NULL, 52)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (11, 0, NULL, 44)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (12, 0, NULL, -8)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (13, 0, NULL, 15)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (14, 0, NULL, 22)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (15, 0, NULL, 16)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (16, 0, NULL, 73)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (17, 0, NULL, 1)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (18, 0, NULL, -3)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (19, 0, NULL, 77)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (20, 0, NULL, -11)
INSERT [dbo].[statystyki_pokoju] ([Nr_rzutu], [Id], [Rodzaj_konta], [Rzut_koscia]) VALUES (21, 0, NULL, 77)
GO
