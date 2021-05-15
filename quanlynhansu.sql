use master
go
 create database qlyns
go
 use qlyns
 go 
 create table Departments
 (
    DepartmentID int not null primary key,
	DepartmentName nvarchar(250) not null,
	Desription nvarchar(250)
 )
 create table Employees
 (
    EmployeeID int not null primary key,
	DepartmentID int,
	FirstName nvarchar(100) not null,
	LastName nvarchar(50) not null,
	FullName nvarchar(100) not null,
	Gender char(10),
	Birthday datetime,
	Address nvarchar(100)
	constraint fk_Employees_Departments foreign key(DepartmentID) references Departments(DepartmentID)
 )

 insert into Departments values
 ('01','ab','bc'),
  ('02','bc','cd'),
   ('03','cd','de')

insert into Employees values
(2,'01','ab','bc','cd','nam','2010-08-19','duy'),
  (3,'02','abc','bcd','cde','nu','2011-05-10','dung'),
   (4,'01','abcd','bcde','cdef','nam','2012-10-09','ha')

--hiển thị--
select*from Departments
select*from Employees