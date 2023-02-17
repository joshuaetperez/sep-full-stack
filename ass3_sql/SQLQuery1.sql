USE Northwind
GO

--1. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City IN (
	SELECT e.City
	FROM Employees e
)

--2. List all cities that have Customers but no Employee.
--a. Use sub-query
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City NOT IN (
	SELECT e.City
	FROM Employees e
)
--b. Do not use sub-query
SELECT DISTINCT City
FROM Customers
EXCEPT 
SELECT DISTINCT City
FROM Employees

--3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalQuantity
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--4. List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProducts
FROM Customers c 
	LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
	INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

--5. List all Customer Cities that have at least two customers.
--a. Use union
--b. Use sub-query and no union
SELECT c.City, COUNT(DISTINCT c.CustomerID) AS NumOfCustomers
FROM Customers c 
GROUP BY c.City
HAVING COUNT(DISTINCT c.CustomerID) >= 2

--6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(DISTINCT od.ProductID) AS NumOfUniqueProducts
FROM Customers c 
	INNER JOIN Orders o ON c.CustomerID = o.CustomerID
	INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) > 1

--7. List all Customers who have ordered products, but have the �ship city� on the order different from their own customer cities.
SELECT DISTINCT c.ContactName
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice) AS AveragePrice, c.City
FROM Customers c
	INNER JOIN Orders o ON c.CustomerID = o.CustomerID
	INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
	INNER JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.ProductName, c.City
ORDER BY SUM(od.Quantity) DESC

--9. List all cities that have never ordered something but we have employees there.
--a. Use sub-query
SELECT e.City
FROM Employees e
WHERE e.City NOT IN (
	SELECT DISTINCT City
	FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID
)
--b. Do not use sub-query
SELECT DISTINCT City
FROM Employees
EXCEPT
SELECT DISTINCT City
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID

--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
-- and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT dt.EmployeeName, dt.MostOrderedCity, dt1.CityWithMostTotalQuantityProductsOrdered
FROM
(
	SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, o.ShipCity AS MostOrderedCity, ROW_NUMBER() OVER (PARTITION BY e.FirstName + ' ' + e.LastName ORDER BY COUNT(o.ShipCity) DESC) RN
	FROM Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID
	GROUP BY e.FirstName + ' ' + e.LastName, o.ShipCity
) dt 
INNER JOIN 
(
	SELECT dt.EmployeeName, dt.CityWithMostTotalQuantityProductsOrdered
	FROM
	(
		SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, o.ShipCity AS CityWithMostTotalQuantityProductsOrdered, SUM(od.Quantity) AS NumOfCityOrders, ROW_NUMBER() OVER (PARTITION BY e.FirstName + ' ' + e.LastName ORDER BY SUM(od.Quantity) DESC) RN
		FROM Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
		GROUP BY e.FirstName + ' ' + e.LastName, o.ShipCity
	) dt
	WHERE dt.RN = 1
) dt1 ON dt.EmployeeName = dt1.EmployeeName
WHERE dt.RN = 1


GO

--11. How do you remove the duplicates record of a table?
WITH CTE AS
(
	SELECT *, ROW_NUMBER() OVER (PARTITION BY key_value ORDER BY (SELECT NULL)) AS RN
	FROM TableToRemoveDuplicates
)
DELETE FROM CTE WHERE RN > 1
