use master
go
create database qly_ban_hang
go
use qly_ban_hang 
go
create table HangSX
(
  MaHang nchar(20) not null primary key,
  TenHang nvarchar(50) not null,
  DiaChi nvarchar(100) not null,
  SoDT char(12)
)

create table SanPham
(
  MaSP nchar(20) not null primary key,
  TenSP nvarchar(50) not null,
  MauSac nvarchar(50),
  SoLuong int,
  GiaBan money,
   MaHang nchar(20),
   constraint fk_SanPham_HangSX foreign key(MaHang) references HangSX (MaHang)
)

 insert into HangSX values
 ('ma01',N'hoa quả',N'ab',12),
  ('ma02',N'điện máy',N'abc',123),
   ('ma03',N'dân dụng',N'abcd',1234)

insert into SanPham values
('sp01',N'táo',N'đỏ',10,1000,'ma02'),
('sp02',N'ti vi',N'đen',12,1040,'ma01'),
('sp03',N'xoong',N'trắng',14,1200,'ma03')

 ---hiển thị--
 select*from HangSX
 select*from SanPham