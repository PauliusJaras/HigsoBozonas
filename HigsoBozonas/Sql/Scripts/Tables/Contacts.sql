CREATE TABLE [dbo].[Contacts](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](50) NOT NULL,
	[phone_number] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL
) ON [PRIMARY]
GO