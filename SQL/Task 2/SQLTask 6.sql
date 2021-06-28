SELECT Country, Region, COUNT(*) AS SuppliersCount
FROM Suppliers s
WHERE s.Region IS NOT NULL
GROUP BY Country, Region
HAVING COUNT(*) > 1