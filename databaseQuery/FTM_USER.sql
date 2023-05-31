create database FTM_USER
use FTM_USER

create table UserData
(

	FirstName varchar(20),
	LastName varchar(40),
	Email varchar(50) not null primary key,
	UserPassword varchar(50) not null,
	UserProfilePicture varbinary(max)
)

