DECLARE	@newID varchar(50)

EXECUTE [dbo].[RandID]
		@tableName = N'Categories',
		@newID = @newID OUTPUT

INSERT INTO  [dbo].[Categories]
VALUES
(@newID, 'Drinks')

