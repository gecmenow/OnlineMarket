SELECT EmployeeID
FROM Employees e
WHERE e.Region = 'WA'
EXCEPT
SELECT EmployeeID
FROM Employees empl
WHERE empl.City = 'Seattle'
