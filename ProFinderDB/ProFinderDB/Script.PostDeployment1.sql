/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
	MERGE INTO Customer AS Target
	USING (Values
		( 1, 'Jane', 'Doe', 'janeDoe@gmail.com', '423-123-3212', '426 Grubb Rd.', 'Kingsport', 'TN', '37660'),
		(2, 'Jimmy', 'Dahl', 'JDahl@hotmail.com', '423-321-6545', '553 Cherwin Pl', 'Johnson City', 'TN', '37654')
		)
	AS SOURCE ( Customerid, FirstName, LastName, Email, Phone, Street, City, StateCode, Zip)
	ON Target.Customerid = SOURCE.Customerid
	WHEN NOT MATCHED BY TARGET THEN
	INSERT (Customerid, FirstName, LastName, Email, Phone, Street, City, StateCode, Zip)
	VALUES (Customerid, Firstname, LastName, Email, Phone, Street, City, StateCode, Zip);

	MERGE INTO Professional AS Target
	USING (Values
		( 1, 'James', 'Donovan', 'JamDon@gmail.com', 'Plumber', ' I am a plumber','423-123-3212', '425 Grubb Rd.', 'Kingsport', 'TN', '37660'),
		(2, 'Amanda', 'Hugenkis', 'topheavy@hotmail.com', 'MatchMaker',  ' I am the love nurse',  '423-987-8599', '602 Love Ln', 'Memphis ', 'TN', '37014')
		)
	AS SOURCE ( Proid, FirstName, LastName, Email, Profession, About, Phone, Street, City, StateCode, Zip)
	ON Target.Proid = SOURCE.Proid
	WHEN NOT MATCHED BY TARGET THEN
	INSERT (Proid, FirstName, LastName, Email,Profession, About, Phone, Street, City, StateCode, Zip)
	VALUES (Proid, Firstname, LastName, Email, Profession, About,  Phone, Street, City, StateCode, Zip);