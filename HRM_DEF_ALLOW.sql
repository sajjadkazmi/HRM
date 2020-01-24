USE HRM
GO

/****** Object:  Table [dbo].[HRM_DEF_ALLOW]    Script Date: 02/01/2020 21:20:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HRM_DEF_ALLOW](
	[BAS] [numeric](18, 2) NULL,
	[MED] [numeric](18, 2) NULL,
	[HRENT] [numeric](18, 2) NULL,
	[UTIL] [numeric](18, 2) NULL,
	[CONV] [numeric](18, 2) NULL,
	[PFUND] [numeric](18, 2) NULL,
	[LFA] [numeric](18, 2) NULL,
	[LOYALTY] [numeric](18, 0) NULL,
	TDA	numeric(18,2) NULL,
	MOB numeric(18,2) NULL,
	FUEL numeric(18,2) null
) ON [PRIMARY]

GO


