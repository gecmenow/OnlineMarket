DECLARE @newIdidentifier VARCHAR(50)

SELECT @newIdidentifier = [dbo].[RandID] ('Categories', NEWID())
INSERT INTO Categories
VALUES (@newIdidentifier, 'Hot-Dogs')

