--Select
--ANSII Standart
Select * from Customers;
Select ContactName,CompanyName,City from Customers;
Select ContactName Adi , CompanyName SirketAdi, City Sehir from Customers ; --Select with  alians
select * from Customers where City = 'London';
select * from Customers where City = 'Berlin';

--case insensitive
Select * from Products;
select * from Products where CategoryId = 1 or CategoryId = 3;
select * from Products where CategoryId = 1 and UnitPrice >= 10;

select * from Products order by CategoryID,ProductName,UnitPrice; --asecnding -- descending

select * from Products where CategoryID=1 order by UnitPrice desc;

select count(*) Adet from Products; -- count Products

select CategoryID,count(*) from Products group by CategoryID;

select CategoryId,count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10;


select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10;
--Inner Join iki tablodada eslesenleri getirir
--DTO Data Transformation Object
Select * from Products p left join [Order Details] od on p.ProductID = od.ProductID;--solda olup sagda olmayanlarida getir

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null ;
select * from Customers c right join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null ;

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID;
