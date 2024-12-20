CREATE PROCEDURE [dbo].[CreateUser]

--[Pseudo] NVARCHAR(50) NOT NULL,
--	[Email] NVARCHAR(250) NOT NULL,
--	[Password] VARBINARY(64) NOT NULL,
	@Pseudo NVARCHAR(50),
	@Email NVARCHAR(250),
	@Password NVARCHAR(50)
AS
BEGIN
	
	DECLARE @Salt NVARCHAR(60)
	DECLARE @Pepper NVARCHAR(100)
	DECLARE @HashedPassword VARBINARY(64)

	SET @Pepper = dbo.GetPepper()
	SET @Salt = CONVERT(NVARCHAR(60),NEWID())
	SET @HashedPassword = HASHBYTES('SHA2_512', CONCAT(@Password, @Salt, @Pepper))


	INSERT INTO [User_] (Pseudo, Email, Password, Salt)
	OUTPUT inserted.Id
	VALUES (@Pseudo, @Email, @HashedPassword, @Salt)



END
