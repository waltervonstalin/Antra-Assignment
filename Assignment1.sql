-- Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter. 
select p.ProductID,p.Name,p.Color,p.ListPrice
from Production.Product as p

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, excludes the rows that ListPrice is 0.
select p.ProductID,p.Name,p.Color,p.ListPrice
from Production.Product as p
where p.ListPrice != 0;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column.
select p.ProductID,p.Name,p.Color,p.ListPrice
from Production.Product as p
where p.Color is NULL;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.
select p.ProductID,p.Name,p.Color,p.ListPrice
from Production.Product as p
where p.Color is not NULL;

--Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table
--the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
select p.ProductID,p.Name,p.Color,p.ListPrice
from Production.Product as p
where p.Color is not NULL and p.ListPrice>0;

--Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.
select p.Name,p.Color
from Production.Product as p
where p.Color is not NULL;

--Write a query that generates the following result set  from Production.Product
select p.Name,p.Color
from Production.Product as p
where p.Name like '%Crankarm' or p.Name like 'Chainring%'
order by p.name desc;

--Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500
select p.ProductID,p.Name
from Production.Product as p
where p.ProductID between 400 and 500;

--Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table restricted to the colors black and blue
select p.ProductID,p.Name,p.Color
from Production.Product as p
where p.color = 'black' or p.Color = 'blue';

--Write a query to get a result set on products that begins with the letter S. 
select *
from Production.Product as p
where p.name like 'S%';

--Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. Order the result set by the Name column. 
select p.Name, p.ListPrice
from Production.Product as p
where p.Name like 'S%'
order by p.Name asc;

--Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. Order the result set by the Name column. The products name should start with either 'A' or 'S'
select p.Name, p.ListPrice
from Production.Product as p
where p.Name like 'S%' or p.Name like 'A%'
order by p.Name asc;

--Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. 
--After this zero or more letters can exists. Order the result set by the Name column.
select *
from Production.Product as p
where p.Name like 'Spo[^k]%'
order by p.Name asc;

--Write a query that retrieves unique colors from the table Production.Product. Order the results  in descending  manner.
select distinct p.Color
from Production.Product as p
where p.Color is not NULL
order by p.Color desc;