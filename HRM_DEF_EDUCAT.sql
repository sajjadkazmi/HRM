USE HRM
GO

/****** Object:  Table [dbo].[ADM_DEF_EDUCAT]    Script Date: 02/01/2020 21:19:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[HRM_DEF_EDUCAT](
	[CODE] [numeric](10, 0) NOT NULL,
	[DESC] [varchar](max) NULL DEFAULT (''),
	[AUTH_STATUS] [varchar](1) NULL DEFAULT ('P'),
	[AUTH_DATE] [datetime] NULL,
	[AUTH_BY] [numeric](18, 0) NULL DEFAULT ((0)),
	[AUTH_REMARKS] [varchar](max) NULL DEFAULT (''),
	[INACTIVE] [numeric](1, 0) NULL DEFAULT ((0))
 CONSTRAINT [PK_HRM_DEF_EDUCAT] PRIMARY KEY CLUSTERED 
(
	[CODE] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

