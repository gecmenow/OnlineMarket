UPDATE p
SET p.Price *= 1.2
FROM Product AS p
INNER JOIN Provider pr ON p.ProviderId = pr.ProviderID
WHERE pr.ProviderID = 1
