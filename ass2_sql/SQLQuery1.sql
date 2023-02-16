USE AdventureWorks2019
GO

-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(ProductID)
FROM Production.Product

-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(ProductSubcategoryID)
FROM Production.Product

-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
--    ProductSubcategoryID CountedProducts
--    -------------------- ---------------
SELECT ProductSubcategoryID, COUNT(ProductSubcategoryID) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

-- 4.  How many products that do not have a product subcategory.
SELECT COUNT(*)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

-- 5.  Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity)
FROM Production.ProductInventory

-- 6.  Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
--     ProductID    TheSum
--     -----------  ----------
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
--    Shelf        ProductID     TheSum
--    ----------   -----------   -----------
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT AVG(Quantity)
FROM Production.ProductInventory
WHERE LocationID = 10

-- 9. Write query  to see the average quantity of products by shelf from the table Production.ProductInventory
--    ProductID   Shelf      TheAvg
--    ----------- ---------- -----------
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

-- 10.  Write query  to see the average quantity of products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
--    ProductID   Shelf      TheAvg
--    ----------- ---------- -----------
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf

-- 11.  List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
--    Color    Class     TheCount      AvgPrice
--    -------  ------    -----------   ----------
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

-- 12. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables. Join them and produce a result set similar to the following.
--    Country      Province
--    ---------    ----------
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr INNER JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

-- 13. Write a query that lists the country and province names from person.CountryRegion and person.StateProvince tables and list the countries filter them by Germany and Canada.
-- Join them and produce a result set similar to the following.
--    Country     Province
--    ---------   ---------
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr INNER JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada')

-- ----------------------------------------

USE Northwind
GO

-- 14.  List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductName
FROM dbo.Products p INNER JOIN dbo.[Order Details] od ON p.ProductID = od.ProductID INNER JOIN dbo.Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate > dateadd(YEAR,-25, GETDATE())

-- 15.  List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS TotalSold
FROM dbo.Products p INNER JOIN dbo.[Order Details] od ON p.ProductID = od.ProductID INNER JOIN dbo.Orders o ON od.OrderID = o.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

-- 16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS TotalSold
FROM dbo.Products p INNER JOIN dbo.[Order Details] od ON p.ProductID = od.ProductID INNER JOIN dbo.Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate > dateadd(YEAR,-25, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.Quantity) DESC

-- 17.   List all city names and number of customers in that city.
SELECT City, COUNT(City) AS NumOfCustomers
FROM dbo.Customers
GROUP BY City

-- 18.  List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(City) AS NumOfCustomers
FROM dbo.Customers
GROUP BY City
HAVING COUNT(City) > 2

-- 19.  List the names of customers who placed orders after 1/1/98 with order date.
SELECT c.ContactName
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1/1/98'

-- 20.  List the names of all customers with most recent order dates
SELECT c.ContactName, MAX(o.OrderDate) AS MostRecentOrderDate
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName

-- 21.  Display the names of all customers along with the count of products they bought
SELECT c.ContactName, COUNT(od.ProductID) AS ProductCount
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

-- 22.  Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.ProductID) >  100

-- 23.  List all of the possible ways that suppliers can ship their products. Display the results as below
--    Supplier Company Name       Shipping Company Name
--    ------------------------    -----------------------
SELECT DISTINCT su.CompanyName AS "Supplier Company Name", sh.CompanyName AS "Shipping Company Name"
FROM dbo.Shippers sh 
	INNER JOIN dbo.Orders o ON sh.ShipperID = o.ShipVia 
	INNER JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID 
	INNER JOIN dbo.Products p ON od.ProductID = p.ProductID 
	INNER JOIN dbo.Suppliers su ON p.SupplierID = su.SupplierID

--24.  Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM dbo.Orders o 
	INNER JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID 
	INNER JOIN dbo.Products p ON od.ProductID = p.ProductID 

--25.  Displays pairs of employees who have the same job title.
SELECT e1.FirstName + ' ' + e2.LastName AS Employee1, e2.FirstName + ' ' + e2.LastName AS Employee2
FROM dbo.Employees e1 INNER JOIN dbo.Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID != e2.EmployeeID

--26.  Display all the Managers who have more than 2 employees reporting to them.
SELECT m.FirstName + ' ' + m.LastName AS Managers
FROM dbo.Employees m INNER JOIN dbo.Employees e ON m.EmployeeID = e.ReportsTo
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(m.FirstName + ' ' + m.LastName) > 2

--27.  Display the customers and suppliers by city. The results should have the following columns
--City
--Name
--Contact Name,
--Type (Customer or Supplier)
SELECT City, CompanyName, ContactName, 'Customer' AS "Type (Customer or Supplier)"
FROM dbo.Customers
UNION
SELECT City, CompanyName, ContactName, 'Supplier' AS "Type (Customer or Supplier)"
FROM dbo.Suppliers