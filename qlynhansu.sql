use master 
go
 create database QLNS
 go
use QLNS
go
 create table Departments
 (
    DepartmentID int not null primary key,
	DepartmentName nvarchar(250),
	Description nvarchar(250)
 )
 create table Employees
 (
   EmployeeID int not null primary key,
   DepartmentID int ,
   FisrtName nvarchar(100),
   LastName nvarchar(50),
   FullName nvarchar(100),
   Gender char(10),
   Birthday datetime,
    ADDRESSD nvarchar(100),

   constraint fk_Employees_Departments foreign key(DepartmentID) references  Departments(DepartmentID)
 )
 insert into Departments values
 (1,'a','b'),
 (2,'b','c')
 insert into Employees values
 (2,1,'ab','bc','cd','nam','2010-08-19','duy'),
  (3,2,'abc','bcd','cde','nu','2011-05-10','dung'),
   (4,1,'abcd','bcde','cdef','nam','2012-10-09','ha')

   --- hien thi --
   select*from Departments
 select*from Employees