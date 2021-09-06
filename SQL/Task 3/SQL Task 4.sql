SELECT Region.RegionDescription
FROM Employees
INNER JOIN EmployeeTerritories ON Employees.EmployeeID = EmployeeTerritories.EmployeeID
INNer JOIn Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
RIGHT JOIN Region ON Territories.RegionID = Region.RegionID
WHERE Employees.EmployeeID IS NULL