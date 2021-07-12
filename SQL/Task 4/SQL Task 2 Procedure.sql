CREATE PROC RandID (@tableName Varchar(MAX), @newID VARCHAR(50) OUTPUT)
AS
Begin
	DECLARE @tbName VARCHAR(MAX)
	DECLARE @myid uniqueidentifier  
	SET @myid = NEWID()  
	SET @newID = LEFT(@tableName, 1) + '_' + convert(varchar(MAX), @myid)
End