use master
go
create database qlysach
go
use qlysach
go
create table  nhaxuatban
(
     Manxb nvarchar(20) not null primary key,
	 Tennxb nvarchar(100) not null,
	 soluongXB int
)
create table tacgia
(
  Matg nvarchar(20) not null primary key,
  Tentg nvarchar(100) not null
)
create table sach
(
  Masach nvarchar(20) not null primary key,
  Tensach nvarchar(50) not null,
  Namxb date,
  Soluong int,
  Dongia int,
  Matg nvarchar(20),
  Manxb nvarchar(20),
  constraint fk_sach_nhaxuatban foreign key(Manxb) references nhaxuatban(Manxb),
  constraint fk_sach_tacgia foreign key(Matg) references tacgia(Matg)
)

insert into nhaxuatban values
(1,N'thanh niên',10),
(2,N'tiền phong',34)

insert into tacgia values
(3,N'duy'),
(4,N'dũng')

insert into sach values
('s01',N'lý','2010/07/29',12,1000,3,1),
('s02',N'hóa','2012/05/12',15,1030,4,2),
('s03',N'sinh','2013/10/24',34,1500,3,2)

--hiển thị--
select*from nhaxuatban
select*from tacgia
select*from sach