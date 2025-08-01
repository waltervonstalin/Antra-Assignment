--1.List all cities that have both Employees and Customers.
select distinct e.city
from Employees as e 
left join Customers as c on e.City = c.City
where e.city is not null and c.city is not null;

--2.List all cities that have Customers but no Employee.Use sub-query.
select distinct c.city 
from Customers as c
where c.city not in(
    select e.city
    from Employees as e 
    where e.city is not null 
);

--2.List all cities that have Customers but no Employee.Do not use sub-query.
select distinct c.city
from Customers as c 
left join Employees as e on e.city = c.city
where e.city is null and c.city is not null;

--3.List all products and their total order quantities throughout all orders.
select p.ProductName, sum(o.Quantity) as 'Total Order Quantities'
from Products as p 
left join [Order Details] as o on p.ProductID = o.ProductID
group by p.ProductName
order by p.ProductName asc;

--4.List all Customer Cities and total products ordered by that city.
select c.city, sum(ordtil.Quantity) as 'Total Products'
from Customers as c
left join Orders as ord on c.CustomerID = ord.CustomerID
left join [Order Details] as ordtil on ord.OrderID = ordtil.OrderID
group by c.City
order by c.city asc;

--5.List all Customer Cities that have at least two customers.
select city
from Customers
where city is not NULL
group by City
having count(CustomerID) >= 2
order by City;

--6.List all Customer Cities that have ordered at least two different kinds of products.
select distinct c.city
from Customers as c 
left join Orders as ord on c.CustomerID = ord.CustomerID
left join [Order Details] as ordtail on ord.OrderID = ordtail.OrderID
group by c.City
having count(ProductID) >= 2
order by c.city;

--7.List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
select distinct c.ContactName
from Customers as c 
left join Orders as ord on ord.CustomerID = c.CustomerID
where c.City != ord.ShipCity;

--8.List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
with productsales as(
    select top 5 p.ProductID,sum(od.Quantity) as 'Total Quantity',p.ProductName, avg(od.UnitPrice*(1-od.Discount)) as 'Average Price'
    from [Order Details] as od
    left join Products as p on od.ProductID = p.ProductID
    group by p.ProductID,p.ProductName
    order by sum(od.quantity) desc
),
productcitysalses as(
    select ps.ProductID,c.City,sum(od.Quantity) as 'City Quantity', ROW_NUMBER() over(partition by ps.ProductID order by sum(od.quantity) desc) as 'City Rank'
    from productsales as ps 
    left join [Order Details] as od on ps.ProductID = od.ProductID
    left join Orders as o on od.OrderID = o.OrderID
    left join Customers c on o.CustomerID = c.CustomerID
    group by ps.ProductID,c.City
)
select ps.ProductName,ps.[Total Quantity],ps.[Average Price],pcs.City,pcs.[City Quantity]
from productsales as ps
left join productcitysalses as pcs on pcs.ProductID = ps.ProductID
where pcs.[City Rank] = 1
order by ps.[Total Quantity] desc;

--9.List all cities that have never ordered something but we have employees there.Use sub-query
select distinct e.City
from Employees as e
where e.city not in(
    select distinct c.City
    from Customers as c 
    left join Orders as o on o.CustomerID = c.CustomerID
    where c.city is not null
) and e.city is not null;

--9.List all cities that have never ordered something but we have employees there.Do not Use sub-query
select distinct City
from Employees
where City is not NULL
EXCEPT
select distinct c.City
from Customers as c 
left join Orders as o on o.CustomerID = c.CustomerID
where c.city is not null;

--10.List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is,
--and also the city of most total quantity of products ordered from. (tip: join  sub-query)
with employeessales as(
    select top 1 e.city,count(o.OrderID) as 'Order Count'
    from Employees as e 
    left join Orders o on e.EmployeeID = o.EmployeeID
    group by e.City
    order by count(o.OrderID) desc 
),
cityorders as(
    select top 1 c.City, sum(od.Quantity) as 'Total Quantity'
    from Customers as c 
    left join orders as o on o.CustomerID = c.CustomerID
    left join [Order Details] as od on o.OrderID = od.OrderID
    group by c.City
    order by sum(od.Quantity) desc 
)
select es.City as 'Employee city with most sales',es.[Order Count],co.City as 'Customer city with most sales',co.[Total Quantity]
from employeessales as es
cross join cityorders as co;

--11.How do you remove the duplicates record of a table?
--The first way to remove duplicates record of a table is to use row_number() function with cte recursive
--Another way is to use delete function with join for some simple cases
--We could also use the group by function to select records in a temporarily table and drop this table