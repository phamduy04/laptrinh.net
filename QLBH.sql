use master
go
create database QLBH
go
use QLBH
go
create table HangSX
(
  MaHang nvarchar(20) not null primary key,
  TenHang nvarchar(50) not null,
  DiaChi nvarchar(50),
  SoDT nchar(12)
)
create table SanPham
(
  MaSP nvarchar(20) not null primary key,
  TenSP nvarchar(50),
  MauSac nvarchar(50),
  Soluong int,
  GiaBan float,
  MaHang nvarchar(20),
  constraint fk_SanPham_HangSX foreign key(MaHang) references HangSX(MaHang)
)

insert into HangSX values
('ma01',N'táo',N'abc','012'),
('ma02',N'lê',N'abcd','0123'),
('ma03',N'quýt',N'abcde','01234')

insert into SanPham values
('sp01',N'ô tô',N'đỏ',12,1000,'ma01'),
('sp02',N'xe máy',N'đen',32,1500,'ma03'),
('sp03',N'máy bay',N'xanh',20,1060,'ma02')

--hiển thị--
select*from HangSX
select*from SanPham