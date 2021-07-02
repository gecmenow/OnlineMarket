CREATE FUNCTION RandID (@tableName Varchar(MAX), @myid uniqueidentifier = NEWID)
RETURNS VARCHAR(50)
BEGIN
	DECLARE @newIdentificator Varchar(50)
	SET @newIdentificator = LEFT(@tableName, 1) + '_' + convert(varchar(MAX), @myid)
	RETURN @newIdentificator
END