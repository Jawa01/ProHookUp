CREATE TABLE [dbo].[Customer]
(
	[Customerid] INT  PRIMARY KEY NOT NULL,
	[FirstName]	VARCHAR (50) NOT NULL,
	[LastName] VARCHAR (50)	NOT NULL,
	[Email]	VARCHAR (100) NOT NULL,
	[Phone] VARCHAR (15) NOT NULL,
	[Street] VARCHAR (50) NOT NULL,
	[City] VARCHAR (50) NOT NULL, 
	[Statecode] VARCHAR (2) NOT NULL, 
	[Zip] VARCHAR (5) NOT NULL,
)
