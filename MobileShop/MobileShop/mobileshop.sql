USE [mobileshop]
GO
/****** Object:  Table [dbo].[customerPurchase]    Script Date: 20.04.2021 20:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerPurchase](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[cname] [varchar](250) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[contact] [varchar](max) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[caddress] [varchar](350) NOT NULL,
	[company] [varchar](250) NOT NULL,
	[model] [varchar](250) NOT NULL,
	[imei] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[newMobile]    Script Date: 20.04.2021 20:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[newMobile](
	[mid] [int] IDENTITY(1,1) NOT NULL,
	[cname] [varchar](250) NOT NULL,
	[mname] [varchar](250) NOT NULL,
	[ram] [varchar](250) NOT NULL,
	[internal] [varchar](250) NOT NULL,
	[expandable] [varchar](250) NOT NULL,
	[display] [varchar](250) NOT NULL,
	[rear] [varchar](250) NOT NULL,
	[front] [varchar](250) NOT NULL,
	[finger] [varchar](250) NOT NULL,
	[sim] [varchar](250) NOT NULL,
	[network] [varchar](250) NOT NULL,
	[price] [varchar](max) NOT NULL,
 CONSTRAINT [PK_newMobile] PRIMARY KEY CLUSTERED 
(
	[mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customerPurchase] ON 

INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (1, N'Melda', N'Female', N'5444343434', N'm456@hotmail.com', N'Turkey', N'Samsung', N'A32', N'5555-6464-5526-4562')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (2, N'Ahmet', N'Male', N'5333333333', N'ahmet456@hotmail.com', N'Ankara/Turkey', N'Apple', N'8', N'3')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (3, N'Aylin', N'Female', N'5432344343', N'aylin123@gmail.com', N'Basaksehir/Istanbul', N'Apple', N'6', N'3335-7774-4446-876')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (4, N'Elzem', N'Female', N'5311231212', N'elzem_56@hotmail.com', N'Adıyaman', N'Apple', N'11', N'4444-4444-4444-4444')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (5, N'Aynur', N'Female', N'5888888888', N'aynur456@gmail.com', N'Basaksehir', N'Apple', N'6', N'333-3333-3333-3333')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (6, N'Can', N'Male', N'5377777777', N'can_234@gmail.com', N'Kucukcekmece/Istanbul', N'Samsung', N'Galaxy 3', N'1111-1234-3213-5555')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (7, N'Meryem', N'Female', N'5309866767', N'meryem_235@hotmail.com', N'Istanbul', N'Apple', N'11', N'7654-2345-0000-7894')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (8, N'Rabia', N'Female', N'5372344343', N'rabiac@gmail.com', N'Istanbul ', N'Apple', N'8', N'7777-0000-7777-0000')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (9, N'Furkan', N'Male', N'5476565656', N'furkannn@gmail.com', N'Artvin', N'Samsung', N'A32', N'7171-6666-5555-4444')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (10, N'Burak', N'Male', N'5311118787', N'ahmetburak4@gmail.com', N'Elazıg', N'Samsung', N'Galaxy 3', N'6666')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (11, N'Kadir', N'Male', N'5772581414', N'kadirc34@hotmail.com', N'Kurtkoy/Turkey', N'Samsung', N'A32', N'2323-2323-3232-2323')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (12, N'Hayri', N'Male', N'5311233234', N'hyri456@hotmail.com', N'Ankara', N'Apple', N'7', N'2222-3333-6666-9999')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (13, N'Pınar', N'Female', N'5300000000', N'pina3564@hotmail.com', N'Bahcelievler', N'Apple', N'11', N'6666')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (14, N'gg', N'Male', N'g', N'g', N'g', N'Samsung', N'A32', N'dtg')
INSERT [dbo].[customerPurchase] ([cid], [cname], [gender], [contact], [email], [caddress], [company], [model], [imei]) VALUES (15, N'Feride', N'Female', N'5344444444', N'feride545@hotmail.com', N'Hatay', N'Samsung', N'Ice 6', N'3333')
SET IDENTITY_INSERT [dbo].[customerPurchase] OFF
GO
SET IDENTITY_INSERT [dbo].[newMobile] ON 

INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (1, N'Samsung', N'A32', N'3 GB', N'16 GB', N'32 GB', N'5.5 inch', N'10 MP', N'3 MP', N'Yes', N'Dual Sim', N'2G, 3G,', N'1250')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (2, N'Apple', N'8', N'8 GB', N'64 GB', N'64 GB', N'6.0 inch', N'15 MP', N'10 MP', N'Yes', N'Dual Sim', N'2G,3G&4G VOLT', N'2000')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (3, N'Apple', N'6', N'4 GB', N'16 GB', N'32 GB', N'5.5 inch', N'10 MP', N'8 MP', N'Yes', N'Dual Sim', N'2G, 3G,', N'1200')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (4, N'Apple', N'11', N'8 GB', N'64 GB', N'128 GB', N'6.5 inch', N'15 MP', N'20 MP', N'Yes', N'Triple Sim', N'2G,3G&4G VOLT', N'2000')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (5, N'Samsung', N'Galaxy 3', N'3 GB', N'16 GB', N'15 GB', N'5.0 inch', N'5 MP', N'8 MP', N'No', N'One Sim', N'2 G', N'700')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (6, N'Apple', N'4', N'2 GB', N'8 GB', N'15 GB', N'5.0 inch', N'5 MP', N'2 MP', N'Yes', N'One Sim', N'2 G', N'560')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (8, N'Apple', N'7', N'4 GB', N'16 GB', N'64 GB', N'6.0 inch', N'12 MP', N'24 MP', N'Yes', N'Dual Sim', N'2G,3G&4G VOLT', N'1125')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (10, N'Samsung', N'X345', N'3 GB', N'32 GB', N'32 GB', N'5.5 inch', N'11 MP', N'10 MP', N'Yes', N'Dual Sim', N'2G, 3G,', N'769')
INSERT [dbo].[newMobile] ([mid], [cname], [mname], [ram], [internal], [expandable], [display], [rear], [front], [finger], [sim], [network], [price]) VALUES (11, N'Samsung', N'Ice 6', N'3 GB', N'8 GB', N'15 GB', N'5.5 inch', N'10 MP', N'8 MP', N'Yes', N'Dual Sim', N'2 G', N'660')
SET IDENTITY_INSERT [dbo].[newMobile] OFF
GO
