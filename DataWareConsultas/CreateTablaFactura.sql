USE [DigitalWare]
GO

/****** Object:  Table [dbo].[CatFactura]    Script Date: 30/10/2020 13:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatFactura](
	[IdFactura] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[TotalCompra] [float] NULL,
	[FechaCompra] [datetime] NOT NULL,
 CONSTRAINT [PK_CatFactura] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatFactura]  WITH CHECK ADD  CONSTRAINT [FK_CatFactura_CatCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[CatCliente] ([IdCliente])
GO

ALTER TABLE [dbo].[CatFactura] CHECK CONSTRAINT [FK_CatFactura_CatCliente]
GO

ALTER TABLE [dbo].[CatFactura]  WITH CHECK ADD  CONSTRAINT [FK_CatFactura_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[CatProducto] ([IdProducto])
GO

ALTER TABLE [dbo].[CatFactura] CHECK CONSTRAINT [FK_CatFactura_Producto]
GO


