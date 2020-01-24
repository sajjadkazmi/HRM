USE HRM
GO

/****** Object:  Table [dbo].[HRM_MASTER_REF]    Script Date: 31/12/2019 20:42:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[HRM_MASTER_REF](
	[USER_CODE] [numeric](18, 0) NOT NULL,
	[CODE] [numeric](5, 0) NOT NULL,
	[NAME] [varchar](max) NULL DEFAULT (''),
	[PROF] [varchar](max) NULL DEFAULT (''),
	[COMPANY] [varchar](max) NULL DEFAULT (''),
	[REL] [numeric](10, 0) NULL DEFAULT ((0)),
	[REL_NOY] [numeric](3, 0) NULL DEFAULT ((0)),
	[PHONE] [varchar](80) NULL DEFAULT (''),
	[CELL] [varchar](80) NULL DEFAULT (''),
	[EMAIL] [varchar](80) NULL DEFAULT (''),
 CONSTRAINT [PK_PMS_REFERENCE] PRIMARY KEY CLUSTERED 
(
	[USER_CODE] DESC,
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

