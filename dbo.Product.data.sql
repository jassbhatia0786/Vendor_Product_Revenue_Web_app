SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [VendorId], [UnitPrice], [Name]) VALUES (1, 1, CAST(450.00 AS Decimal(18, 2)), N'Lawn Trimmer Robot')
INSERT INTO [dbo].[Product] ([Id], [VendorId], [UnitPrice], [Name]) VALUES (2, 2, CAST(400.00 AS Decimal(18, 2)), N' Dining table ')
SET IDENTITY_INSERT [dbo].[Product] OFF
