CREATE PROCEDURE [dbo].[EditContact]
(@id smallint,
@full_name varchar(50),
@phone_number varchar(50),
@birthday date)
AS
BEGIN 
	UPDATE [dbo].Contacts
	SET full_name = @full_name, phone_number = @phone_number, birthday = @birthday
	WHERE id = @id
END
GO