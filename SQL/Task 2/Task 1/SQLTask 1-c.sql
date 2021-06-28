CREATE TABLE Product_D(
	[ProductId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProviderId] [int] NOT NULL,
	[ShortDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product_D] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product_D]  WITH CHECK ADD  CONSTRAINT [FK_Product_D_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO

ALTER TABLE [dbo].[Product_D] CHECK CONSTRAINT [FK_Product_D_CategoryId]
GO

ALTER TABLE [dbo].[Product_D]  WITH CHECK ADD  CONSTRAINT [FK_Product_D_Provider] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Provider] ([ProviderID])
GO

ALTER TABLE [dbo].[Product_D] CHECK CONSTRAINT [FK_Product_D_Provider]
GO

INSERT INTO Product_D
SELECT *
FROM Product

