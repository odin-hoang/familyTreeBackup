create database FTM_USER
use FTM_USER

create table UserData
(
	UserName varchar(20) not null primary key,
	FirstName varchar(20),
	LastName varchar(40),
	Email varchar(50),
	UserPassword varchar(50) not null,
	UserProfilePicture varbinary(max)
)

insert into UserData(UserName,FirstName,LastName,Email,UserPassword,UserProfilePicture) values ('HungLuong','Hung','Luong vinh','vinhhung@gmail.com','88888888',null)
insert into UserData(UserName,FirstName,LastName,Email,UserPassword,UserProfilePicture) values ('ad','Hung1','Luong vinh','vinhhung@gmail.com','88888888',null)



select * 
from UserData