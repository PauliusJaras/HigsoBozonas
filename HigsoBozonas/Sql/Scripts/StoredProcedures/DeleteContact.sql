CREATE PROCEDURE [dbo].[DeleteContact]
(@id smallint)
AS
BEGIN 
	DELETE FROM [dbo].Contacts
	WHERE id = @id
END
GO