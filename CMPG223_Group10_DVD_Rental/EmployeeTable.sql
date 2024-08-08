CREATE TABLE [dbo].[Employee](
	[Employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Surname] [nvarchar](25) NOT NULL,
	[Date_of_Birth] [nvarchar](13) NOT NULL,
	[Contact_Number] [nvarchar](10) NOT NULL,
	[Username] [nvarchar](7) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Role] [nvarchar](13) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)
);

