USE [DigitalWare]
GO

/****** Object:  Table [dbo].[CatInventarioP]    Script Date: 30/10/2020 13:11:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatInventarioP](
	[IdInventario] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[PInventario] [int] NOT NULL,
 CONSTRAINT [PK_CatInventarioP] PRIMARY KEY CLUSTERED 
(
	[IdInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatInventarioP]  WITH CHECK ADD  CONSTRAINT [FK_CatInventarioP_CatProducto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[CatProducto] ([IdProducto])
GO

ALTER TABLE [dbo].[CatInventarioP] CHECK CONSTRAINT [FK_CatInventarioP_CatProducto]
GO


