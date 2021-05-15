use master
go
create database qlsv
go
use qlsv
go
create table Lop
(
   Malop nchar(10) not null primary key,
   Tenlop nvarchar(20) not null,
   Phong nchar(10) 
)

insert into Lop values
('L1','Tin k24','203'),
('L2','Tin k25','201'),
('L3','Tin k26','204'),
('L4','Tin k27','205')

select*from Lop

select * from Lop where Tenlop like N'%tin%';