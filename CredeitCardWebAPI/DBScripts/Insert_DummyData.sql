USE [CreditCardDB]
GO
SET IDENTITY_INSERT [dbo].[CardDetails] ON 
GO
INSERT [dbo].[CardDetails] ([CardDetailId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardTypeId], [CardNumber], [AnnualCharge], [CreditLimit]) VALUES (1, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'Tarun', 1, N'XXXX-1525', 2000, 2000000)
GO
INSERT [dbo].[CardDetails] ([CardDetailId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardTypeId], [CardNumber], [AnnualCharge], [CreditLimit]) VALUES (2, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'Tarun', 2, N'XXXX-7596', 6000, 4000000)
GO
INSERT [dbo].[CardDetails] ([CardDetailId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardTypeId], [CardNumber], [AnnualCharge], [CreditLimit]) VALUES (3, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'Tarun', 3, N'XXXX-356', 8000, 6000000)
GO
SET IDENTITY_INSERT [dbo].[CardDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[CardMasterTypes] ON 
GO
INSERT [dbo].[CardMasterTypes] ([CardTypeId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardType]) VALUES (1, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'tarun', N'MoneyBack')
GO
INSERT [dbo].[CardMasterTypes] ([CardTypeId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardType]) VALUES (2, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'tarun', N'Platinum')
GO
INSERT [dbo].[CardMasterTypes] ([CardTypeId], [IsActive], [IsDeleted], [CreatedBy], [CreatedDate], [UpdatedDate], [UpdatedBy], [CardType]) VALUES (3, 1, 0, N'Tarun', CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), CAST(N'2021-04-09T02:20:49.8630000' AS DateTime2), N'tarun', N'Titanium')
GO
SET IDENTITY_INSERT [dbo].[CardMasterTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON 
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [Password]) VALUES (1, N'Admin', N'12345')
GO
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
GO
ALTER TABLE [dbo].[CardDetails]  WITH CHECK ADD  CONSTRAINT [FK_CardDetails_CardMasterTypes_CardTypeId] FOREIGN KEY([CardTypeId])
REFERENCES [dbo].[CardMasterTypes] ([CardTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CardDetails] CHECK CONSTRAINT [FK_CardDetails_CardMasterTypes_CardTypeId]
GO
