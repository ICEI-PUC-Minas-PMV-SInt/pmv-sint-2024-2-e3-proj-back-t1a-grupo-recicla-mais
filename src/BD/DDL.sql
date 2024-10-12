/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/10/2024 18:40:14 ******/

CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Senha] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Telefone] [int] NOT NULL,
	[Rua] [nvarchar](max) NOT NULL,
	[Numero] [nvarchar](max) NOT NULL,
	[Bairro] [nvarchar](max) NOT NULL,
	[Cidade] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Cep] [int] NOT NULL,
	[Complemento] [nvarchar](max) NULL,
	[DataNasc] [date] NULL,
	[DataCriac] [date] NULL,
	[RazaoSocial] [nvarchar](max) NULL,
	[NomeCompleto] [nvarchar](max) NULL,
	[CodAgente] [int] NULL,
	[Matricula] [int] NULL,
	[TipoUsuario] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
