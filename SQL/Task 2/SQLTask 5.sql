SELECT *
FROM Region r
RIGHT JOIN Employees e ON e.Region = r.RegionDescription
WHERE e.City != 'London'