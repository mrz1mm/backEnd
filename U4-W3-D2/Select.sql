SELECT * FROM Products;
SELECT * FROM Products where UnitsInStock >= 40;
SELECT * FROM Employees where City = 'London';
SELECT * FROM Orders order by Freight DESC;
SELECT * FROM Orders where Freight > 90 and Freight < 200;
SELECT * FROM Products where CategoryID = 1;
SELECT * FROM [Order Details] where Discount > 0;
SELECT * FROM Orders where CustomerId = 'BOTTM' and Freight > 50;