
CREATE DATABASE SQL_Customers;
use SQL_Customers;
create Table Customers
(
Cust_Id int,
Cust_Name nvarchar(50),

);
insert into Customers(Cust_Id,Cust_Name)
values
(1,'Arpit'),
(2,'Shruti'),
(3,'Akash'),
(4,'VEE'),
(5,'Cena');
select * from Customers; 