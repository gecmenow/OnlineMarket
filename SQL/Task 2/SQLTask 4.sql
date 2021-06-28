SELECT *
FROM Customers
WHERE Region = 'Eastern'
UNION
SELECT *
FROM Customers
WHERE City = 'Lulea'