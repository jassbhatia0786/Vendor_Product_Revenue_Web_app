SET IDENTITY_INSERT [dbo].[Vendor] ON
INSERT INTO [dbo].[Vendor] ([Id], [VendorName], [VendorWebstore]) VALUES (1, N'Tech Hub', N'http://www.techhub.com')
INSERT INTO [dbo].[Vendor] ([Id], [VendorName], [VendorWebstore]) VALUES (2, N'Wood Works', N'http://woodworks.com')
SET IDENTITY_INSERT [dbo].[Vendor] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [VendorId], [UnitPrice], [Name]) VALUES (1, 1, CAST(450.00 AS Decimal(18, 2)), N'Lawn Trimmer Robot')
INSERT INTO [dbo].[Product] ([Id], [VendorId], [UnitPrice], [Name]) VALUES (2, 2, CAST(400.00 AS Decimal(18, 2)), N' Dining table ')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[StoreFront] ON
INSERT INTO [dbo].[StoreFront] ([Id], [StoreFrontName], [StoreFrontUrl]) VALUES (1, N'Wilson Furniture', N'http://wisonfurniture.com')
INSERT INTO [dbo].[StoreFront] ([Id], [StoreFrontName], [StoreFrontUrl]) VALUES (2, N'Gadget Store ', N'http://wwww.gadgetstore.com')
SET IDENTITY_INSERT [dbo].[StoreFront] OFF
SET IDENTITY_INSERT [dbo].[Revenue] ON
INSERT INTO [dbo].[Revenue] ([Id], [ProductId], [StoreFrontId], [Quantity]) VALUES (1, 2, 1, 2)
INSERT INTO [dbo].[Revenue] ([Id], [ProductId], [StoreFrontId], [Quantity]) VALUES (2, 1, 2, 5)
SET IDENTITY_INSERT [dbo].[Revenue] OFF
