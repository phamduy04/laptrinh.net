 use master
 go
  create database qlydiem
 go
 use qlydiem
 go
 create table monhoc
 (
   Mamon nvarchar(10) not null primary key,
   Tenmon nvarchar(50) not null,
   Tinvchilythuyet int,
   Tinchithuchanh int
 )
  create table sinhvien
  (
    Masv nvarchar(10) not null primary key,
	Hoten nvarchar(50) not null,
	Ngaysinh date
  )
  create table dangki
  (
    Madk nvarchar(30) not null primary key,
	Masv nvarchar(10),
	Mamon nvarchar(10),
	Ngaydangki date,
	constraint fk_dangki_monhoc foreign key(Mamon) references monhoc(Mamon),
	constraint fk_dangki_sinhvien foreign key(Masv) references sinhvien(Masv)
  )

  insert into monhoc values
('ma01',N'lý',4,6), 
('ma02',N'hóa',3,7),
 ('ma03',N'sinh',5,5)

 insert into sinhvien values
 ('sv01',N'a','2000/07/14'),
  ('sv02',N'b','2003/02/12'),
   ('sv03',N'c','2001/10/06')

 insert into dangki values
 ('dk01','sv01','ma01','2010/09/15'),
  ('dk02','sv02','ma02','2014/06/25'),
   ('dk03','sv03','ma03','2017/02/18'),
    ('dk04','sv01','ma02','2011/04/10'),
	 ('dk05','sv03','ma01','2009/05/28')


-- hien thi--
select*from monhoc
select*from sinhvien
select*from dangki