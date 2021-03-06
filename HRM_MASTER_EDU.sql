USE HRM
GO

/****** Object:  Table [dbo].[HRM_MASTER_EDU]    Script Date: 31/12/2019 20:39:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[HRM_MASTER_EDU](
	[USER_CODE] [numeric](18, 0) NOT NULL,
	[CODE] int CONSTRAINT [DF_HRM_MASTER_EDU_CODE]  DEFAULT ((0)),
	[EDU_CODE] [numeric](10, 0) NULL CONSTRAINT [DF_HRM_MASTER_EDU_DEGREE]  DEFAULT ((0)),
	[UNI_CODE] [numeric](10, 0) NULL CONSTRAINT [DF_HRM_MASTER_EDU_INSTITUE]  DEFAULT ((0)),
	[GRADE] [varchar](20) NULL CONSTRAINT [DF_HRM_MASTER_EDU_GRADE]  DEFAULT (''),
	[PASS_YEAR] [varchar](4) NULL CONSTRAINT [DF_HRM_MASTER_EDU_CELL]  DEFAULT (''),
 CONSTRAINT [PK_HRM_MASTER_EDU] PRIMARY KEY CLUSTERED 
(
	[USER_CODE] DESC,
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


