SELECT LastName, FirstName, TerritoryDescription, RegionDescription
FROM Employees
INNER JOIN EmployeeTerritories ON Employees.EmployeeID = EmployeeTerritories.EmployeeID
INNer JOIn Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
INNER JOIN Region ON Territories.RegionID = Region.RegionID