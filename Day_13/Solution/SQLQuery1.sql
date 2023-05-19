USE [CDAC_DB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spInsert]
		@No = 102,
		@Name = N'Axta',
		@Address = N'Kurla'

SELECT	@return_value as 'Return Value'

GO
