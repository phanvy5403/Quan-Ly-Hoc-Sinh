﻿CREATE DATABASE QUANLYHOCSINH

USE QUANLYHOCSINH

CREATE TABLE HOCSINH
(	MaHocSinh nvarchar(50) not null,
	HoTen nvarchar(50),
	GioiTinh nvarchar(5),
	NgaySinh datetime,
	DiaChi nvarchar(50),
	QueQuan nvarchar(50),
	DanToc nvarchar(50),
	TonGiao nvarchar(50),
	SDT nvarchar(50),
	Email nvarchar(50),
	constraint pk_hs primary key(MaHocSinh)
)

CREATE TABLE KHOI	
(	MaKhoi nvarchar(50) not null,
	TenKhoi nvarchar(50),
	constraint pk_mk primary key(MaKhoi)
)

CREATE TABLE LOP
(	MaLop nvarchar(50) not null,
	TenLop nvarchar(50),
	MaKhoi nvarchar(50) not null,
	SiSo tinyint,
	NamHoc nvarchar(9),
	constraint pk_ml primary key(MaLop),
)

CREATE TABLE MONHOC
(	MaMonHoc nvarchar(50) not null,
	TenMonHoc nvarchar(50),
	constraint pk_mmh primary key(MaMonHoc)
)

CREATE TABLE CTLOP
(	MaHocSinh nvarchar(50) not null,
	MaLop nvarchar(50) not null,
	constraint pk_ctl primary key(MaHocSinh,MaLop)
)

CREATE TABLE DIEM
(	MaDiem nvarchar(50) not null,
	MaMonHoc nvarchar(50),
	MaHocSinh nvarchar(50),
	NamHoc nvarchar(9),
	HocKy nvarchar(20),
	DiemTX float,
	DiemGK float,
	DiemCK float,
	DiemTB float,
	XepLoai nchar(10),
	constraint pk_md primary key(MaDiem)
)

CREATE TABLE THAMSO
(	TuoiToiThieu tinyint default 15,
	TuoiToiDa tinyint default 20,
	SiSoToiDa smallint default 40,
	TsTX float default 0.3,
	TsGK float default 0.2,
	tsCK float default 0.5,
	LoaiGioi float default 8,
	LoaiKha float default 6.5,
	LoaiTb float default 5,
	LoaiYeu float default 3.5
)

ALTER TABLE LOP ADD CONSTRAINT fk_mk FOREIGN KEY(MaKhoi) REFERENCES KHOI(MaKhoi)
ALTER TABLE CTLOP ADD CONSTRAINT fk_ctl_hs FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh)
ALTER TABLE CTLOP ADD CONSTRAINT fk_ctl_ml FOREIGN KEY(MaLop) REFERENCES LOP(MaLop)
ALTER TABLE DIEM ADD CONSTRAINT fk_diem_hs FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh)
ALTER TABLE DIEM ADD CONSTRAINT fk_diem_mmh FOREIGN KEY(MaMonHoc) REFERENCES MonHoc(MaMonHoc)

set dateformat DMY
--HOC SINH
INSERT INTO HOCSINH VALUES ('22111000','Nguyen Van A','Nam','01/01/2006','731 Tran Hung Dao, Q5, TpHCM','TpHCM','Kinh','Khong','0972030034','NguyenVanA@gmail.com')
INSERT INTO HOCSINH VALUES ('22110001',N'Nguyễn Hoài Nam','Nam','15/06/2006',N'23/5 Nguyễn Trãi, Q5, TpHCM','TpHCM','Kinh',N'Không','0908256478','NamNguyen@gmail.com')
INSERT INTO HOCSINH VALUES ('22112023',N'Trần Ngọc Hân',N'Nữ','28/10/2006',N'227 Nguyễn Văn Cừ, Q5, TpHCM','TpHCM','Kinh',N'Không','0863173826','TranNgocHan@gmail.com')
INSERT INTO HOCSINH VALUES ('22111016',N'Lê Hoài Thương',N'Nữ','24/11/2006',N'873 Lê Hồng Phong, Q5, TpHCM','TpHCM','Kinh',N'Không','0938435756','HoaiThuong2411@gmail.com')
INSERT INTO HOCSINH VALUES ('22110054',N'Hà Duy Lập','Nam','16/01/2006',N'45/2 An Dương Vương, Q5, TpHCM','TpHCM','Kinh','Không','0938776266','DuyLapHa@gmail.com')

INSERT INTO HOCSINH VALUES ('22100018',N'Lê Hà Vinh','Nam','31/12/2007',N'50/341 Lê Đại Hành, Q5, TpHCM','TpHCM','Kinh',N'Không','0973012434','Vinhle@gmail.com')
INSERT INTO HOCSINH VALUES ('22100100',N'Lê Nhật Minh','Nam','25/04/2007',N'34 Trương Định, Q5, TpHCM','TpHCM','Kinh',N'Không','0975126056','LeNhatMinh@gmail.com')
INSERT INTO HOCSINH VALUES ('22100113',N'Phan Thị Thanh',N'Nữ','16/04/2007',N'74/3 Nguyễn Trãi, Q5, TpHCM','TpHCM','Kinh',N'Không','0972030034','Phanthithanh@gmail.com')
INSERT INTO HOCSINH VALUES ('22101000',N'Nguyễn Văn Tâm','Nam','17/09/2007',N'63 Trần Hưng Đạo, Q5, TpHCM','TpHCM','Kinh',N'Không','0912137367','NguyenVanTam@gmail.com')
INSERT INTO HOCSINH VALUES ('22100010',N'Trần Ngọc Linh',N'Nữ','01/01/2007',N'47/3 An Dương Vương, Q5, TpHCM','TpHCM','Kinh',N'Không','0972156266','Tranngoclinh@gmail.com')

INSERT INTO HOCSINH VALUES ('22120224',N'Lê Thị Phi Yến',N'Nữ','13/08/2005',N'728 Trần Hưng Đạo, Q5, TpHCM','TpHCM','Kinh',N'Không','0872133246','Yenle@gmail.com')
INSERT INTO HOCSINH VALUES ('22120331',N'Ngô Thanh Tuấn','Nam','15/07/2005',N'202 Lê Hồng Phong, Q5, TpHCM','TpHCM','Kinh',N'Không','0868025976','Ngothanhtuan@gmail.com')
INSERT INTO HOCSINH VALUES ('22120247',N'Nguyễn Thị Trúc Thanh',N'Nữ','11/11/2005',N'58 Trương Định, Q5, TpHCM','TpHCM','Kinh',N'Không','0975987687','Thanhnguyen@gmail.com')
INSERT INTO HOCSINH VALUES ('22120016',N'Trần Minh Long','Nam','12/12/2005',N'231 Nguyễn Văn Cừ, Q5, TpHCM','TpHCM','Kinh',N'Không','0363250168','Tranminhlong@gmail.com')
INSERT INTO HOCSINH VALUES ('22120112',N'Trần Quang Minh','Nam','01/01/2005','24/122 Lê Đại Hành, Q5, TpHCM','TpHCM','Kinh',N'Không','0969251332','QuangMinh@gmail.com')


--KHOI
INSERT INTO KHOI VALUES ('2210','10')
INSERT INTO KHOI VALUES ('2211','11')
INSERT INTO KHOI VALUES ('2212','12')

--LOP
INSERT INTO LOP VALUES ('2210A1','10A1','2210',40,2022)
INSERT INTO LOP VALUES ('2210A2','10A2','2210',39,2022)
INSERT INTO LOP VALUES ('2210A3','10A3','2210',40,2022)
INSERT INTO LOP VALUES ('2210A4','10A4','2210',39,2022)

INSERT INTO LOP VALUES ('2211A1','11A1','2211',35,2022)
INSERT INTO LOP VALUES ('2211A2','11A2','2211',38,2022)
INSERT INTO LOP VALUES ('2211A3','11A3','2211',40,2022)

INSERT INTO LOP VALUES ('2212A1','12A1','2212',33,2022)
INSERT INTO LOP VALUES ('2212A2','12A2','2212',34,2022)

--CTLOP
INSERT INTO CTLOP VALUES ('22111000','2211A1')
INSERT INTO CTLOP VALUES ('22110001','2211A1')
INSERT INTO CTLOP VALUES ('22112023','2211A2')
INSERT INTO CTLOP VALUES ('22111016','2211A2')
INSERT INTO CTLOP VALUES ('22110054','2211A3')

INSERT INTO CTLOP VALUES ('22100018','2210A1')
INSERT INTO CTLOP VALUES ('22100100','2210A1')
INSERT INTO CTLOP VALUES ('22100113','2210A2')
INSERT INTO CTLOP VALUES ('22101000','2210A2')
INSERT INTO CTLOP VALUES ('22100010','2210A3')

INSERT INTO CTLOP VALUES ('22120224','2212A1')
INSERT INTO CTLOP VALUES ('22120331','2212A1')
INSERT INTO CTLOP VALUES ('22120247','2212A1')
INSERT INTO CTLOP VALUES ('22120016','2212A2')
INSERT INTO CTLOP VALUES ('22120112','2212A2')


--MON
INSERT INTO MONHOC VALUES ('TO10',N'Toán 10')
INSERT INTO MONHOC VALUES ('NV10',N'Ngữ văn 10')
INSERT INTO MONHOC VALUES ('AV10',N'Anh văn 10')
INSERT INTO MONHOC VALUES ('VL10',N'Vật lí 10')
INSERT INTO MONHOC VALUES ('HO10',N'Hóa học 10')
INSERT INTO MONHOC VALUES ('SI10',N'Sinh học 10')
INSERT INTO MONHOC VALUES ('LS10',N'Lịch sử 10')
INSERT INTO MONHOC VALUES ('DL10',N'Địa lí 10')
INSERT INTO MONHOC VALUES ('TI10',N'Tin học 10')
INSERT INTO MONHOC VALUES ('GD10',N'GDCD 10')
INSERT INTO MONHOC VALUES ('CN10',N'Công nghệ 10')
INSERT INTO MONHOC VALUES ('QP10',N'GDQP 10')
INSERT INTO MONHOC VALUES ('TD10',N'Thể dục 10')

INSERT INTO MONHOC VALUES ('TO11',N'Toán 11')
INSERT INTO MONHOC VALUES ('NV11',N'Ngữ văn 11')
INSERT INTO MONHOC VALUES ('AV11',N'Anh văn 11')
INSERT INTO MONHOC VALUES ('VL11',N'Vật lí 11')
INSERT INTO MONHOC VALUES ('HO11',N'Hóa học 11')
INSERT INTO MONHOC VALUES ('SI11',N'Sinh học 11')
INSERT INTO MONHOC VALUES ('LS11',N'Lịch sử 11')
INSERT INTO MONHOC VALUES ('DL11',N'Địa lí 11')
INSERT INTO MONHOC VALUES ('TI11',N'Tin học 11')
INSERT INTO MONHOC VALUES ('GD11',N'GDCD 11')
INSERT INTO MONHOC VALUES ('CN11',N'Công nghệ 11')
INSERT INTO MONHOC VALUES ('QP11',N'GDQP 11')
INSERT INTO MONHOC VALUES ('TD11',N'Thể dục 11')

INSERT INTO MONHOC VALUES ('TO112',N'Toán 12')
INSERT INTO MONHOC VALUES ('NV12',N'Ngữ văn 12')
INSERT INTO MONHOC VALUES ('AV12',N'Anh văn 12')
INSERT INTO MONHOC VALUES ('VL12',N'Vật lí 12')
INSERT INTO MONHOC VALUES ('HO12',N'Hóa học 12')
INSERT INTO MONHOC VALUES ('SI12',N'Sinh học 12')
INSERT INTO MONHOC VALUES ('LS12',N'Lịch sử 12')
INSERT INTO MONHOC VALUES ('DL12',N'Địa lí 12')
INSERT INTO MONHOC VALUES ('TI12',N'Tin học 12')
INSERT INTO MONHOC VALUES ('GD12',N'GDCD 12')
INSERT INTO MONHOC VALUES ('CN12',N'Công nghệ 12')
INSERT INTO MONHOC VALUES ('QP12',N'GDQP 12')
INSERT INTO MONHOC VALUES ('TD12',N'Thể dục 12')

--DIEM
INSERT INTO DIEM VALUES ('1','TO10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('2','NV10','22100100','2022','1',7,7,7,7,'KHA')
INSERT INTO DIEM VALUES ('3','AV10','22100100','2022','1',8,8,8,8,'GIOI')
INSERT INTO DIEM VALUES ('4','VL10','22100100','2022','1',9,8,9,9,'GIOI')
INSERT INTO DIEM VALUES ('5','HO10','22100100','2022','1',7,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('6','SI10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('7','LS10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('8','DL10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('9','TI10','22100100','2022','1',9,10,10,9,'GIOI')
INSERT INTO DIEM VALUES ('10','GD10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('11','CN10','22100100','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('12','QP10','22100100','2022','1',8,8,8,8,'GIOI')
INSERT INTO DIEM VALUES ('13','TD10','22100100','2022','1',8,8,8,8,'GIOI')

INSERT INTO DIEM VALUES ('41','TO10','22100100','2022','2',9,8.7,9.5,9,'GIOI')
INSERT INTO DIEM VALUES ('42','NV10','22100100','2022','2',6,6,7,7,'KHA')
INSERT INTO DIEM VALUES ('43','AV10','22100100','2022','2',8,8,8,8,'GIOI')
INSERT INTO DIEM VALUES ('44','VL10','22100100','2022','2',9,8,9,9,'GIOI')
INSERT INTO DIEM VALUES ('45','HO10','22100100','2022','2',7,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('46','SI10','22100100','2022','2',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('47','LS10','22100100','2022','2',9,6.9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('48','DL10','22100100','2022','2',9,7,8,9,'GIOI')
INSERT INTO DIEM VALUES ('49','TI10','22100100','2022','2',9,10,10,9,'GIOI')
INSERT INTO DIEM VALUES ('50','GD10','22100100','2022','2',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('51','CN10','22100100','2022','2',9,8,8,9,'GIOI')
INSERT INTO DIEM VALUES ('52','QP10','22100100','2022','2',8,8,8,8,'GIOI')
INSERT INTO DIEM VALUES ('53','TD10','22100100','2022','2',8,8,8,8,'GIOI')

INSERT INTO DIEM VALUES ('21','TO10','22100113','2022','1',9,8,9,9,'GIOI')
INSERT INTO DIEM VALUES ('22','NV10','22100113','2022','1',6,6,7,7,'KHA')
INSERT INTO DIEM VALUES ('23','AV10','22100113','2022','1',8.5,9,8,8,'GIOI')
INSERT INTO DIEM VALUES ('24','VL10','22100113','2022','1',9,8,9,9,'GIOI')
INSERT INTO DIEM VALUES ('25','HO10','22100113','2022','1',7,9,8,9,'GIOI')
INSERT INTO DIEM VALUES ('26','SI10','22100113','2022','1',9,8.5,8.5,9,'GIOI')
INSERT INTO DIEM VALUES ('27','LS10','22100113','2022','1',8,8,8,9,'GIOI')
INSERT INTO DIEM VALUES ('28','DL10','22100113','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('29','TI10','22100113','2022','1',6,5,7,9,'GIOI')
INSERT INTO DIEM VALUES ('30','GD10','22100113','2022','1',9,9,9,9,'GIOI')
INSERT INTO DIEM VALUES ('31','CN10','22100113','2022','1',7,7,7,7,'GIOI')
INSERT INTO DIEM VALUES ('32','QP10','22100113','2022','1',8,8,8,8,'GIOI')
INSERT INTO DIEM VALUES ('33','TD10','22100113','2022','1',8,8,8,8,'GIOI')

UPDATE DIEM
SET NamHoc = '2022-2023'

UPDATE DIEM 
SET DiemTB = 0.3*DiemTX+0.2*DiemGK+0.5*DiemCK
--THAM SO
INSERT INTO THAMSO VALUES(15,20,40,0.3,0.2,0.5,8,6.5,5,3.5)

