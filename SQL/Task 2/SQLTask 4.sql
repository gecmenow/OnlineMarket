SELECT *
FROM Region r
INNER JOIN Customers c ON c.Region = r.RegionDescription
WHERE c.City = 'London'