create database PracDisconnected;
USE PracDisconnected;

CREATE TABLE Employees
(
Empno int Primary Key,
Ename varchar(50),
Salary money,
Hiredate date
)

drop table Employees;

select * from Employees;