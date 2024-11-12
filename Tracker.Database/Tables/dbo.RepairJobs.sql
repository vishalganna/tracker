CREATE TABLE [dbo].[RepairJobs](
	[Id] [int] IDENTITY(10000000,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Cost] [int] NOT NULL,
	[Received] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerPhone] [varchar](10) NULL,
	[Comments] [nvarchar](200) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_RepairJobs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]