SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductsCategories PC
ON P.Id = PC.Product_Id
LEFT JOIN Categories C
ON PC.Category_Id = C.Id;