create database hotel;
use hotel;
create table loginNew(
NIC varchar (20) primary key,
Name varchar (20),
mobile int,
username varchar (20),
password varchar (20),
confirmpw varchar (20),
member varchar(20),
);
insert into loginNew (NIC,name,mobile,username,password,confirmpw,member)
values('996981952V','APM Tayanika',0719651733,'monatayani','monashi1234','monashi1234','Admin');
insert into loginNew (NIC,name,mobile,username,password,confirmpw,member)
values('987634452V','KMRT Munasinghe',0719325192,'rivimune','rivindu1234','rivindu1234','Admin');
insert into loginNew(NIC,name,mobile,username,password,confirmpw,member)
values('20006749493','AMDTN Perera',0703452834,'naveepere','naveen1234','naveen1234','Staff');
select * from loginNew;

create table customer(
cid int primary key,
name varchar(20),
nic varchar(20),
mobile varchar(20),
dob varchar(20),
address varchar(20),
);
insert into customer(cid,name,nic,mobile,dob,address)
values(001,'Kavya Sandeepani','989751773V','0702154689','1999.12.02','kurunagala');
insert into customer(cid,name,nic,mobile,dob,address)
values(002,'Gavini Nadika','989651743V','0702155689','1999.11.02','Colombo');

select * from customer;

create table bookings(
bookingNo int primary key,
startDate varchar(20),
endDate varchar(20),
roomNo varchar(20),
condition varchar(20),
cid varchar(20),
);
insert into bookings(bookingNo,startDate,endDate,roomNo,condition,cid)
values(001,'20.04.2022','25.04.2022','08','single','009');
insert into bookings(bookingNo,startDate,endDate,roomNo,condition,cid)
values(002,'20.03.2022','20.03.2022','0702187689','double','Colombo');

select * from bookings;

update bookings set cid='001' where bookingNo=002;
update bookings set roomNo='10' where bookingNo=002;

create table rooms(
roomNo int primary key,
floor varchar(20),
type varchar(20),
staff varchar(20),
condition varchar(20),
emNo varchar(20),
);
insert into rooms(roomNo,floor,type,staff,condition,emNo)
values(001,'2','single','Subashini','single','0716784532');
insert into rooms(roomNo,floor,type,staff,condition,emNo)
values(002,'3','double','ilangasinghe','double','0779784532');

select * from rooms;

create table staff(
staffNo int primary key,
name varchar(20),
nic varchar(20),
mobile varchar(20),
dob varchar(20),
address varchar(20),
position varchar(20),
);
insert into staff(staffNo,name,nic,mobile,dob,address,position)
values(001,'subashini','975846214V','0718524178','17.06.2000','polonnaruwa','registration');
insert into staff(staffNo,name,nic,mobile,dob,address,position)
values(001,'thilini','20005846214V','0778527178','17.09.2000','kurunagala','dancer');
update staff set staffNo= 002 where address='kurunagala';

select * from staff;

create table payment(
cid int primary key,
roomNo varchar(20),
packagePrice varchar(20),
noofDays varchar(20),
extra varchar(20),
discount varchar(20),
total varchar(20),
);
insert into payment(cid,roomNo,packagePrice,noofDays,extra,discount,total)
values(004,'021','2000','02','500','50','4450');
insert into payment(cid,roomNo,packagePrice,noofDays,extra,discount,total)
values(005,'011','4000','04','300','100','16200');

select * from payment;

create table salary1(
staffId int primary key,
name varchar(20),
nic varchar(20),
noofDays varchar(20),
wage varchar(20),
bonus varchar(20),
deductions varchar(20),
totalSalary varchar (20),
);
insert into salary1 (staffId,name,nic,noofDays,wage,bonus,deductions,totalSalary)
values(001,'Jagath Nishantha','682475896V','20','5000','20000','5000','115000');
insert into salary1 (staffId,name,nic,noofDays,wage,bonus,deductions,totalSalary)
values(002,'Rani Hiranthika','682475746V','25','4000','16000','5000','111000');

select * from salary1;
drop table customer;