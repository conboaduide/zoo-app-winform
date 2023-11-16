<<<<<<< HEAD
drop database [ZooManagement]
USE [master]
GO
/****** Object:  Database [ZooManagement]    Script Date: 11/15/2023 9:34:35 PM ******/
CREATE DATABASE [ZooManagement]

USE [ZooManagement]
GO

CREATE TABLE [dbo].[animal](
	[id] [int] NOT NULL,
	[name] [varchar](50) NULL,
	[species] [varchar](50) NULL,
	[location] [varchar](50) NULL,
	[class] [varchar](50) NULL,
	[createdDate] [date] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_animal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[animal_cage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animalId] [int] NULL,
	[cageId] [int] NULL,
	[moveInDate] [date] NULL,
	[moveOutDate] [date] NULL,
 CONSTRAINT [PK_aninal_cage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[animal_trainer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animalId] [int] NULL,
	[zooTrainerId] [int] NULL,
 CONSTRAINT [PK_animal_trainer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[cage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[capacity] [int] NOT NULL,
	[createdDate] [date] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_cage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NOT NULL,
	[createdDate] [date] NULL,
	[total] [money] NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[order_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderId] [int] NOT NULL,
	[ticketId] [int] NOT NULL,
	[price] [money] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_order_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ticket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[price] [money] NOT NULL,
	[status] [bit] NOT NULL,
	[createdDate] [date] NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role] [int] NOT NULL,
	[email] [varchar](50) NULL,
	[status] [bit] NOT NULL,
	[createdDate] [date] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[animal] ADD  CONSTRAINT [DF_animal_createdDate]  DEFAULT (getdate()) FOR [createdDate]
GO
ALTER TABLE [dbo].[animal_cage] ADD  CONSTRAINT [DF_aninal_cage_moveInDate]  DEFAULT (getdate()) FOR [moveInDate]
GO
ALTER TABLE [dbo].[cage] ADD  CONSTRAINT [DF_cage_createdDate]  DEFAULT (getdate()) FOR [createdDate]
GO
ALTER TABLE [dbo].[order] ADD  CONSTRAINT [DF_order_createdDate]  DEFAULT (getdate()) FOR [createdDate]
GO
ALTER TABLE [dbo].[ticket] ADD  CONSTRAINT [DF_ticket_createdDate]  DEFAULT (getdate()) FOR [createdDate]
GO
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_createdDate]  DEFAULT (getdate()) FOR [createdDate]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_CustomerId_UserId] FOREIGN KEY([id])
REFERENCES [dbo].[order] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_CustomerId_UserId]
GO
=======
drop database ZooManagement
>>>>>>> 66ae16fc8805599f030ee39e90b96dc916ee17f6
