SELECT Region,Country, COUNT(*) AS SuppliersCount
FROM Suppliers s
WHERE s.Region = 'Quebec'
GROUP BY Region,Country
HAVING COUNT(SupplierID) > 1