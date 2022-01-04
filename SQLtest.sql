CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Products
VALUES
(1, 'Skoda'),
(2, 'Bmw'),
(3, 'Tom Soyer'),
(4, 'Clr via C#'),
(5, 'Tomato'),
(6, 'Onion'),
(7, 'Nokia');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'Cars'),
(2, 'Books'),
(3, 'Vegetables');

CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 2),
(5, 3),
(6, 3);

SELECT P."Name" as Product, C."Name" as Category
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;