CREATE TABLE [dbo].[Professional]
(
	[Proid] INT NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR (50)	NOT NULL,
	[Email] VARCHAR (50) NOT NULL,
	[Profession] VARCHAR (50) NOT NULL,
	[About] VARCHAR (140), 
	[Phone] VARCHAR (15) NOT NULL, 
	[Street] VARCHAR (50) NOT NULL, 
	[City] VARCHAR (50) NOT NULL,
	[StateCode] VARCHAR (50) NOT NULL, 
	[Zip] VARCHAR (50) NOT NULL
)
