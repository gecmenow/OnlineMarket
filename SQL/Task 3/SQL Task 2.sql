SELECT CategoryName, MAX(Products.UnitPrice) as price
FROM Categories
INNER JOIN Products ON Categories.CategoryID = Products.CategoryID
GROUP BY Categories.CategoryName