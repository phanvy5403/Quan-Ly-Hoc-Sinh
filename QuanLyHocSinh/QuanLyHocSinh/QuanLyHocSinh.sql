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
	HoTenCha nvarchar (50),
	NamSinh_Cha int,
	CCCD_Cha nvarchar (50),
	SDT_Cha nvarchar (10),
	NgheNghiep_Cha nvarchar (50),
	HoTenMe nvarchar (50),
	NamSinh_Me int,
	CCCD_Me nvarchar (50),
	SDT_Me nvarchar (10),
	NgheNghiep_Me nvarchar (50),
	HoTen_NguoiGH nvarchar (50),
	NamSinh_NguoiGH int,
	CCCD_NguoiGH nvarchar (50),
	SDT_NguoiGH nvarchar (10),
	NgheNghiep_NguoiGH nvarchar (50),
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
(	MaCTL nvarchar(50) not null,
	MaHocSinh nvarchar(50) not null,
	MaLop nvarchar(50) not null,
	constraint pk_ctl primary key(MaCTL)
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
ALTER TABLE DIEM ADD CONSTRAINT fk_diem_hs FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH (MaHocSinh)
ALTER TABLE DIEM ADD CONSTRAINT fk_diem_mmh FOREIGN KEY(MaMonHoc) REFERENCES MONHOC (MaMonHoc)

set dateformat DMY
--HOC SINH
INSERT INTO HOCSINH VALUES ('22111000',N'Nguyễn Văn Tài','Nam','01/01/2006','731 Tran Hung Dao, Q5, TpHCM','TpHCM','Kinh','Khong','0972030034','NguyenVanA@gmail.com','Nguyễn Anh Hùng',1970,'096302000894','0932178385',N'Giáo viên','Thái Văn Nga',1974,'096102000745','0873965179',N'Công nhân - Viên chức',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22110001',N'Nguyễn Hoài Nam','Nam','15/06/2006',N'23/5 Nguyễn Trãi, Q5, TpHCM','TpHCM','Kinh',N'Không','0908256478','NamNguyen@gmail.com','Nguyễn Trần Hoài Bảo',1982,'096301020365','0937198354',N'Kinh doanh','Nguyễn Thị An',1982,'096102001863','0854867351',N'Giáo viên',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22112023',N'Trần Ngọc Hân',N'Nữ','28/10/2006',N'227 Nguyễn Văn Cừ, Q5, TpHCM','TpHCM','Kinh',N'Không','0863173826','TranNgocHan@gmail.com','Trần Minh Nghĩa',1978,'096302000983','0987398213',N'Nhân viên ngân hàng','Trần Minh Anh',1981,'096202001254','0743854789',N'Giảng viên',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22111016',N'Lê Hoài Thương',N'Nữ','24/11/2006',N'873 Lê Hồng Phong, Q5, TpHCM','TpHCM','Kinh',N'Không','0938435756','HoaiThuong2411@gmail.com','Lê Trần Chính Nghĩa',1984,'096302011475','0987365152',N'Kinh doanh','Nguyễn Trần Thanh Mai',1982,'096102000421','0824377471',N'Giáo viên',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22110054',N'Hà Duy Lập','Nam','16/01/2006',N'45/2 An Dương Vương, Q5, TpHCM','TpHCM','Kinh','Không','0938776266','DuyLapHa@gmail.com','Hà Minh Duy',1987,'096301020782','0862351986',N'Kinh doanh','Trần Nguyễn Minh Vy',1983,'096102000129','0782468312',N'Nội trợ',NULL,NULL,NULL,NULL,NULL)

INSERT INTO HOCSINH VALUES ('22100018',N'Lê Hà Vinh','Nam','31/12/2007',N'50/341 Lê Đại Hành, Q5, TpHCM','TpHCM','Kinh',N'Không','0973012434','Vinhle@gmail.com','Lê Thanh Hiếu',1982,'096301000893','0486932215',N'Nhân viên IT','Nguyễn Hà Vy',1983,'096302000368','0983652142',N'Nhà sáng tạo nội dung',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22100100',N'Lê Nhật Minh','Nam','25/04/2007',N'34 Trương Định, Q5, TpHCM','TpHCM','Kinh',N'Không','0975126056','LeNhatMinh@gmail.com','Lê Nguyễn Minh Long',1977,'096302001721','0486932215',N'Nhân viên IT','Nguyễn Thị Thu Hà',1980,'096302023896','0632982121',N'Giám đốc R&D',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22100113',N'Phan Thị Thanh',N'Nữ','16/04/2007',N'74/3 Nguyễn Trãi, Q5, TpHCM','TpHCM','Kinh',N'Không','0972030034','Phanthithanh@gmail.com','Phan Thanh Binh',1982,'096301004398','0923542362',N'Nhân viên phát triển phần mềm','Phan Thanh Thảo',1982,'096302004236','0723658323',N'Bác sĩ',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22101000',N'Nguyễn Văn Tâm','Nam','17/09/2007',N'63 Trần Hưng Đạo, Q5, TpHCM','TpHCM','Kinh',N'Không','0912137367','NguyenVanTam@gmail.com','Nguyễn Thành Hiếu',1974,'096301002627','0723623475',N'Kỹ sư','Châu Nguyễn Minh Nguyệt',1979,'096302005332','0736144288',N'Nhân viên ngân hàng',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22100010',N'Trần Ngọc Linh',N'Nữ','01/01/2007',N'47/3 An Dương Vương, Q5, TpHCM','TpHCM','Kinh',N'Không','0972156266','Tranngoclinh@gmail.com',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Nguyền Hồ Thanh Thủy',1975,'096203004785','0936123487',N'Y tá')

INSERT INTO HOCSINH VALUES ('22120224',N'Lê Thị Phi Yến',N'Nữ','13/08/2005',N'728 Trần Hưng Đạo, Q5, TpHCM','TpHCM','Kinh',N'Không','0872133246','Yenle@gmail.com','Lê Trần Trung Tín',1974,'096301002627','0723623475',N'Kỹ sư','Châu Nguyễn Minh Nguyệt',1979,'096302005332','0736144288',N'Nhân viên ngân hàng',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22120331',N'Ngô Thanh Tuấn','Nam','15/07/2005',N'202 Lê Hồng Phong, Q5, TpHCM','TpHCM','Kinh',N'Không','0868025976','Ngothanhtuan@gmail.com','Ngô Minh Quân',1973,'096301002627','0723623475',N'Kỹ sư','Nguyễn Lai Như Thảo',1975,'096302005332','0736144288',N'Giáo viên',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22120247',N'Nguyễn Thị Trúc Thanh',N'Nữ','11/11/2005',N'58 Trương Định, Q5, TpHCM','TpHCM','Kinh',N'Không','0975987687','Thanhnguyen@gmail.com','Nguyễn Phan Anh Hùng',1977,'096301002627','0723623475',N'Giảng viên','Mai Nguyễn Minh Châu',1982,'096302005332','0736144288',N'Nhân viên bán hàng',NULL,NULL,NULL,NULL,NULL)
INSERT INTO HOCSINH VALUES ('22120016',N'Trần Minh Long','Nam','12/12/2005',N'231 Nguyễn Văn Cừ, Q5, TpHCM','TpHCM','Kinh',N'Không','0363250168','Tranminhlong@gmail.com',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Nguyền Thanh Tuấn',1979,'096203007556','0836992312',N'Bác sĩ')
INSERT INTO HOCSINH VALUES ('22120112',N'Trần Quang Minh','Nam','01/01/2005','24/122 Lê Đại Hành, Q5, TpHCM','TpHCM','Kinh',N'Không','0969251332','QuangMinh@gmail.com','Trần Phan Chí Nhân',1983,'096303007889','0783224757',N'Bác sĩ','Nguyễn Hồ Thu Mai',1983,'096302002111','0825337222',N'Bác sĩ',NULL,NULL,NULL,NULL,NULL)



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

UPDATE LOP
SET NamHoc = '2022-2023'

--CTLOP
INSERT INTO CTLOP VALUES ('1','22111000','2211A1')
INSERT INTO CTLOP VALUES ('2','22110001','2211A1')
INSERT INTO CTLOP VALUES ('3','22112023','2211A2')
INSERT INTO CTLOP VALUES ('4','22111016','2211A2')
INSERT INTO CTLOP VALUES ('5','22110054','2211A3')

INSERT INTO CTLOP VALUES ('6','22100018','2210A1')
INSERT INTO CTLOP VALUES ('7','22100100','2210A1')
INSERT INTO CTLOP VALUES ('8','22100113','2210A2')
INSERT INTO CTLOP VALUES ('9','22101000','2210A2')
INSERT INTO CTLOP VALUES ('10','22100010','2210A3')

INSERT INTO CTLOP VALUES ('11','22120224','2212A1')
INSERT INTO CTLOP VALUES ('12','22120331','2212A1')
INSERT INTO CTLOP VALUES ('13','22120247','2212A1')
INSERT INTO CTLOP VALUES ('14','22120016','2212A2')
INSERT INTO CTLOP VALUES ('15','22120112','2212A2')


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