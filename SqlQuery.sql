SET IDENTITY_INSERT [dbo].[Screens] ON
INSERT INTO [dbo].[Screens] ([Id], [Name], [ScreenCapacity], [CreatedDate], [LastModifiedDate]) VALUES (1, N'Screen 1', 50, NULL, NULL)
INSERT INTO [dbo].[Screens] ([Id], [Name], [ScreenCapacity], [CreatedDate], [LastModifiedDate]) VALUES (2, N'Screen 2', 75, NULL, NULL)
INSERT INTO [dbo].[Screens] ([Id], [Name], [ScreenCapacity], [CreatedDate], [LastModifiedDate]) VALUES (3, N'Screen 3', 100, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Screens] OFF


SET IDENTITY_INSERT [dbo].[Movies] ON
INSERT INTO [dbo].[Movies] ([Id], [Title], [Description], [RunningTime],  [CreatedDate], [LastModifiedDate], [Price]) VALUES (1, N'The Godfather', N'An organized crime dynasty''s aging patriarch transfers control of his clandestine empire to his reluctant son.', N'03:15:00',  NULL, NULL, CAST(10.00 AS Decimal(8, 2)))
INSERT INTO [dbo].[Movies] ([Id], [Title], [Description], [RunningTime],  [CreatedDate], [LastModifiedDate], [Price]) VALUES (2, N'The Shawshank Redemption ', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', N'02:30:00',  NULL, NULL, CAST(10.00 AS Decimal(8, 2)))
INSERT INTO [dbo].[Movies] ([Id], [Title], [Description], [RunningTime],  [CreatedDate], [LastModifiedDate], [Price]) VALUES (3, N'Schindler''s List', N'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', N'02:10:00',  NULL, NULL, CAST(10.00 AS Decimal(8, 2)))
INSERT INTO [dbo].[Movies] ([Id], [Title], [Description], [RunningTime],  [CreatedDate], [LastModifiedDate], [Price]) VALUES (4, N'Raging Bull', N'The life of boxer Jake LaMotta, whose violence and temper that led him to the top in the ring destroyed his life outside of it.', N'02:09:00',  NULL, NULL, CAST(10.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Movies] OFF

SET IDENTITY_INSERT [dbo].[Shows] ON
INSERT INTO [dbo].[Shows] ([Id], [TimeStart], [TimeEnd], [MovieId], [ScreenId], [CreatedDate], [LastModifiedDate]) VALUES (1, N'2021-04-18 11:00:00', N'2021-04-25 14:00:00', 1, 1, NULL, NULL)
INSERT INTO [dbo].[Shows] ([Id], [TimeStart], [TimeEnd], [MovieId], [ScreenId], [CreatedDate], [LastModifiedDate]) VALUES (2, N'2021-04-12 12:00:00', N'2021-04-25 15:00:00', 2, 1, NULL, NULL)
INSERT INTO [dbo].[Shows] ([Id], [TimeStart], [TimeEnd], [MovieId], [ScreenId], [CreatedDate], [LastModifiedDate]) VALUES (3, N'2021-04-10 10:00:00', N'2021-05-05 13:00:00', 3, 2, NULL, NULL)
INSERT INTO [dbo].[Shows] ([Id], [TimeStart], [TimeEnd], [MovieId], [ScreenId], [CreatedDate], [LastModifiedDate]) VALUES (4, N'2021-04-15 18:00:00', N'2021-05-07 21:00:00', 4, 3, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Shows] OFF
