CREATE PROCEDURE InsertToTableFromXML @Request XML
AS
BEGIN TRANSACTION
	BEGIN TRY
	   DECLARE @tblXMLResult TABLE
 	   (
 		ProviderID uniqueidentifier,
 		Name VARCHAR(50),
 		PhoneNumber VARCHAR(50),
 		Address VARCHAR(50)
 	   ) 
 	   INSERT @tblXMLResult
 	   (
 		ProviderID,
 		Name ,
 		PhoneNumber,
 		Address 
 	   ) 
 	   SELECT     
 		 Results.Providers.value('ProviderID[1]','uniqueidentifier') AS ProviderID,
 		 Results.Providers.value('Name[1]','NVARCHAR(50)') AS Name,
 		 Results.Providers.value('PhoneNumber[1]','VARCHAR(50)') AS PhoneNumber,
 		 Results.Providers.value('Address[1]','VARCHAR(50)') AS Address
 
 		 FROM @Request.nodes('Results/Providers') Results(Providers)

		 MERGE Providers AS T_Base
		 USING @tblXMLResult AS T_Source
		 ON (T_Base.ProviderID = T_Source.ProviderID)
		 WHEN MATCHED THEN
			UPDATE SET ProviderID = T_Source.ProviderID, 
						Name = T_Source.Name, 	
						PhoneNumber = T_Source.PhoneNumber, 
						Address = T_Source.Address
		WHEN NOT MATCHED THEN
			INSERT (ProviderID, Name, PhoneNumber, Address)
			VALUES (T_Source.ProviderID, T_Source.Name, T_Source.PhoneNumber, T_Source.Address)
		OUTPUT $action AS [Operation], 
							Inserted.ProviderID, 
							Inserted.Name,
							Inserted.PhoneNumber,
							Inserted.Address;
	END TRY
	BEGIN CATCH
		ROLLBACK
		EXEC sp_XML_removedocument @Request
	END CATCH
COMMIT