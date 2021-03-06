USE [hair_salon]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 6/9/2017 4:22:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[stylist_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stylists]    Script Date: 6/9/2017 4:22:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([id], [name], [stylist_id]) VALUES (2, N'Thurston Moore', 1)
SET IDENTITY_INSERT [dbo].[clients] OFF
SET IDENTITY_INSERT [dbo].[stylists] ON 

INSERT [dbo].[stylists] ([id], [name]) VALUES (1, N'John Graves')
INSERT [dbo].[stylists] ([id], [name]) VALUES (2, N'John Graves')
SET IDENTITY_INSERT [dbo].[stylists] OFF
