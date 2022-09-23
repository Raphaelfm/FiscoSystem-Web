USE [FiscoSystem]
GO

/****** Object:  Table [dbo].[TabelaNCM]    Script Date: 20/09/2022 19:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TabelaNCM]') AND type in (N'U'))
DROP TABLE [dbo].[TabelaNCM]
GO

/****** Object:  Table [dbo].[TabelaNCM]    Script Date: 20/09/2022 19:38:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TabelaNCM](
	[NcmId] [int] IDENTITY(1,1) NOT NULL,
	[CodigoNcm] [nvarchar](8) NULL,
	[DescricaoNcm] [nvarchar](1200) NULL,
	[UnNcm] [nvarchar](3) NULL,
	[Usuario] [nvarchar](45) NULL,
	[Terminal] [nvarchar](45) NULL,
	[Data] [datetime2](7) NULL,
	[Nivel1] [nvarchar](4) NULL,
	[Nivel2] [nvarchar](5) NULL,
	[Nivel3] [nvarchar](6) NULL,
	[Versao] [int] NOT NULL,
 CONSTRAINT [PK_TabelaNCM] PRIMARY KEY CLUSTERED 
(
	[NcmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

