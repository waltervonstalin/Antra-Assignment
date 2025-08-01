--The AdventureWorks2019 database
--1.How many products can you find in the Production.Product table?
select distinct count(p.ProductID) as productnumbers
from Production.Product as p;

--2.Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
select count(p.ProductSubcategoryID) as productnumbers
from Production.Product as p;

--3.How many Products reside in each SubCategory? Write a query to display the results with the following titles.
select sc.ProductSubcategoryID, count(p.ProductID) as countedproducts
from Production.ProductSubcategory as sc 
left join Production.Product as p on sc.ProductSubcategoryID = p.ProductSubcategoryID
group by sc.ProductSubcategoryID;

--4.How many products that do not have a product subcategory.
select count(p.ProductID) as 'products without subcategory'
from Production.Product as p
where p.ProductSubcategoryID is null; 

--5.Write a query to list the sum of products quantity in the Production.ProductInventory table.
select p.ProductID,sum(p.Quantity) as 'products quantity'
from Production.ProductInventory as p
group by p.ProductID;

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
select p.ProductID,sum(p.Quantity) as 'The sum'
from Production.ProductInventory as p
group by p.ProductID,p.LocationID
having p.LocationID = 40 and sum(p.Quantity) <= 100
order by p.ProductID asc;

--7.Write a query to list the sum of products with the shelf information in the Production.ProductInventory table 
--and LocationID set to 40 and limit the result to include just summarized quantities less than 100
select p.Shelf,p.ProductID,sum(p.Quantity) as 'The sum'
from Production.ProductInventory as p
group by p.Shelf,p.ProductID,p.LocationID
having p.LocationID = 40 and sum(p.Quantity) <= 100
order by p.ProductID asc;

--8.Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
select p.ProductID,avg(p.Quantity) as 'The Average Quantity'
from Production.ProductInventory as p
group by p.ProductID,p.LocationID
having p.LocationID = 10
order by p.ProductID asc;

--9.Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
select p.ProductID,p.Shelf,avg(p.Quantity) as 'The Avg'
from Production.ProductInventory as p 
group by p.ProductID,p.Shelf
order by p.ProductID asc;

--10.Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
select p.ProductID,p.Shelf,avg(p.Quantity) as 'The Avg'
from Production.ProductInventory as p 
group by p.ProductID,p.Shelf
having p.Shelf != 'N/A'
order by p.ProductID asc;

--11. List the members (rows) and average list price in the Production.Product table. 
--This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
select Class,Color, count(*) as 'The count',avg(ListPrice) as 'AvgPrice'
from Production.Product
where Class is not null and Color is not null
group by Class,Color
union
select Color,Class,count(*) as 'The count',avg(ListPrice) as 'AvgPrice'
from Production.Product
where Color is not null and Class is not null
group by Color,Class

--12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables.
--Join them and produce a result set similar to the following.
select pc.name as 'Country', ps.name as 'Province'
from Person.CountryRegion as pc
left join person.StateProvince as ps on pc.CountryRegionCode = ps.CountryRegionCode
group by pc.name,ps.name;

--13.Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables 
--and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
select pc.name as 'Country', ps.name as 'Province'
from Person.CountryRegion as pc
left join person.StateProvince as ps on pc.CountryRegionCode = ps.CountryRegionCode
group by pc.name,ps.name
having pc.name in ('Germany','Canada')


--NorthWind database
--14.List all Products that has been sold at least once in last 27 years.
select distinct od.ProductID
from[Order Details] od
JOIN Orders o ON od.OrderID = o.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, '2025-07-31');

--15. List top 5 locations (Zip Code) where the products sold most.
select top 5 c.PostalCode
from [Order Details] as o1
left join Orders as o2 on o1.OrderID = o2.OrderID
left join Customers as c on c.CustomerID = o2.CustomerID
group by c.PostalCode
having c.PostalCode is not null
order by sum(o1.Quantity) desc;

--16. List top 5 locations (Zip Code) where the products sold most in last 27 years.
select top 5 c.PostalCode
from [Order Details] as o1
left join Orders as o2 on o1.OrderID = o2.OrderID
left join Customers as c on c.CustomerID = o2.CustomerID
where o2.OrderDate >=DATEADD(YEAR, -27, '2025-07-31')
group by c.PostalCode
having c.PostalCode is not null
order by sum(o1.Quantity) desc;

--17. List all city names and number of customers in that city. 
select City, count(CustomerID) as 'Customer Numbers'
from Customers
group by City
order by city asc; 

--18.List city names which have more than 2 customers, and number of customers in that city
select City, count(CustomerID) as 'Customer Numbers'
from Customers
group by City
having count(CustomerID) > 2
order by city asc; 

--19.List the names of customers who placed orders after 1/1/98 with order date.
select distinct cus.ContactName
from Customers as cus 
left join Orders as ord on cus.CustomerID = ord.CustomerID
where ord.OrderDate >=DATEADD(DAY,0,'1998-01-01');

--20.List the names of all customers with most recent order dates
select cus.ContactName
from Customers as cus 
left join Orders as ord on cus.CustomerID = ord.CustomerID
order by ord.OrderDate desc;

--21.Display the names of all customers  along with the  count of products they bought
select distinct cus.ContactName,sum(qua.Quantity) as 'The Sum'
from customers as cus 
left join Orders as ord on cus.CustomerID = ord.CustomerID
left join [Order Details] as qua on ord.OrderID = qua.OrderID
group by cus.ContactName
order by cus.ContactName asc;

--22. Display the customer ids who bought more than 100 Products with count of products.
select distinct cus.CustomerID
from customers as cus 
left join Orders as ord on cus.CustomerID = ord.CustomerID
left join [Order Details] as qua on ord.OrderID = qua.OrderID
group by cus.CustomerID
having sum(qua.Quantity) > 100
order by cus.CustomerID asc;

--23. List all of the possible ways that suppliers can ship their products. Display the results as below
select sup.CompanyName as 'Supplier Company Name',ship.CompanyName as 'Shipping Company Name'
from Suppliers as sup 
left join Shippers as ship on sup.SupplierID = ship.ShipperID
group by sup.CompanyName, ship.CompanyName

--24.Display the products order each day. Show Order date and Product Name.
select pro.ProductName,ord.OrderDate
from Products as pro
left join [Order Details] as orde on orde.ProductID = pro.ProductID
left join Orders as ord on ord.OrderID = orde.OrderID
order by ord.OrderDate asc;

--25.Displays pairs of employees who have the same job title.
select e1.FirstName+' '+e1.LastName as 'Name', e1.Title as 'Job Title',e2.FirstName+' '+e2.LastName as 'Name'
from employees as e1
left join Employees as e2 on e1.Title = e2.Title
group by e1.Title,e1.EmployeeID,e2.EmployeeID,e1.FirstName,e1.LastName,e2.FirstName,e2.LastName
having e1.EmployeeID < e2.EmployeeID

--26.Display all the Managers who have more than 2 employees reporting to them.
select man.FirstName+' '+man.LastName as 'Manager', count(e.EmployeeID) as 'Employees Number'
from Employees as e
left join Employees as man on e.ReportsTo = man.EmployeeID
group by man.FirstName,man.LastName
having count(e.EmployeeID)>2
order by count(e.EmployeeID) desc;

--27. Display the customers and suppliers by city. The results should have the following columns
select cus.City as 'City',cus.CompanyName as 'Name',cus.ContactName as 'Contact Name', 'Customer' as 'Type'
from Customers as cus
union
select sup.City as 'City',sup.CompanyName as 'Name',sup.ContactName as 'Contact Name', 'Supplier' as 'Type'
from Suppliers as sup
order by City