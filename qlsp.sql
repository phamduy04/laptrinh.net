use master
 go
create database qlsp
 go
 use qlsp
 go
 create table sanpham																		
 (
    Masp varchar(20) not null primary key,
	Tensp nvarchar(30)  not null,
	Soluong int,
	Sodienthoai varchar(12)
 )
 insert into sanpham values
('ma01','tulanh',10,123),
('ma02','tivi',12,1234),
('ma03','dieuhoa',9,12345),
('ma04','quat',13,123456)

--- hiển thị--
select*from sanpham