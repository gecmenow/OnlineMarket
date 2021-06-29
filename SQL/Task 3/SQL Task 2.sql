SELECT CategoryName
FROM Categories
WHERE CategoryID = (SELECT CategoryID From Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products)) 