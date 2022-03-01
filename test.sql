-- create a table
CREATE TABLE Products (
  id INTEGER PRIMARY KEY,
  name TEXT NOT NULL
);
-- insert some values
INSERT INTO Products 
VALUES 
    (1, 'Мука'), 
    (2,'Книга'),
    (3, 'ASUS');

CREATE TABLE Categories (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL
);

INSERT INTO Categories 
VALUE 
    (1,'Хлеб'),
    (2, 'Энциклопедия'),
    (3, 'Материнская плата');

CREATE TABLE ProductCategories (
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);
INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 2);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
-- fetch some values
SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;