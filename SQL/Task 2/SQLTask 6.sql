SELECT COUNT(*) AS SuppliersCount
FROM Suppliers s
WHERE s.Region IS NOT NULL
HAVING COUNT(SupplierID) > 1