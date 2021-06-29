SELECT Region.RegionID, RegionDescription
FROM Region
LEFT JOIN Territories ON Region.RegionID = Territories.RegionID
LEFT JOIN EmployeeTerritories ON Territories.TerritoryID = EmployeeTerritories.TerritoryID
LEFT JOIN Employees ON EmployeeTerritories.EmployeeID = Employees.EmployeeID
WHERE Employees.EmployeeID IS NULL
