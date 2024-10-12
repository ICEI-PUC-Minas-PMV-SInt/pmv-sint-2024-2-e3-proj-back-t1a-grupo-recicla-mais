/****** Object:  Table [dbo].[Usuarios] DML ******/
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Login], [Senha], [Email], [Telefone], [Rua], [Numero], [Bairro], [Cidade], [Estado], [Cep], [Complemento], [DataNasc], [DataCriac], [RazaoSocial], [NomeCompleto], [CodAgente], [Matricula], [TipoUsuario]) VALUES (1, N'user1', N'user1@', N'user1@gmail.com', 712805653, N'Praça da República', N'32', N'República', N'São Paulo', N'SP', 1045001, NULL, CAST(N'1212-12-12' AS Date), NULL, NULL, NULL, NULL, NULL, N'Munícipe')
INSERT [dbo].[Usuarios] ([Id], [Login], [Senha], [Email], [Telefone], [Rua], [Numero], [Bairro], [Cidade], [Estado], [Cep], [Complemento], [DataNasc], [DataCriac], [RazaoSocial], [NomeCompleto], [CodAgente], [Matricula], [TipoUsuario]) VALUES (2, N'user2', N'user2@', N'user2@gmail.com', 248997848, N'Avenida Desembargador Moreira', N'322', N'Aldeota', N'Fortaleza', N'CE', 60170001, N'apto 202', NULL, CAST(N'0012-12-12' AS Date), N'user2', NULL, NULL, NULL, N'Empresa')

ALTER DATABASE [DatabaseC] SET  READ_WRITE 
GO
