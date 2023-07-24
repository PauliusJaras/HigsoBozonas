CREATE PROCEDURE [dbo].[AddContact]
(@full_name varchar(50),
@phone_number varchar(50),
@birthday date)
AS
BEGIN 
	INSERT INTO [dbo].Contacts
	(full_name, phone_number, birthday) VALUES (@full_name, @phone_number, @birthday)
END
GO
