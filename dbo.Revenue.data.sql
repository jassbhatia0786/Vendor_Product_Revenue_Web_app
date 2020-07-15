SET IDENTITY_INSERT [dbo].[Revenue] ON
INSERT INTO [dbo].[Revenue] ([Id], [ProductId], [StoreFrontId], [Quantity]) VALUES (1, 2, 1, 2)
INSERT INTO [dbo].[Revenue] ([Id], [ProductId], [StoreFrontId], [Quantity]) VALUES (2, 1, 2, 5)
SET IDENTITY_INSERT [dbo].[Revenue] OFF
