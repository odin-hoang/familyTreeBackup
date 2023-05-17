create database FTM
use FTM

create table MEMBER
(
	MemberID int not null primary key,
	FirstName varchar(20) not null,
	LastName varchar(40) not null,
	DateOfBirt date not null, 
	Gender varchar(3) not null,
	PlaceOfOrigin varchar(255),
	Email varchar(50),
	Biography varchar(max),
	MemberProfilePicture varbinary(max)

)

create table RELATIONSHIP_SPOUSE
(
	MemberID int,
	MemberID2 int,
	SpouseID int not null primary key,
	constraint FK_Relationship_Spouse_Member foreign key (MemberID) references Member (MemberID),
	constraint FK_Relationship_Spouse_Member foreign key (MemberID2) references Member (MemberID)
)

create table RELATIONSHIP_PARENT_CHILD
(
	MemberID int,
	SpouseID int,
	primary key (MemberID,SpouseID)
)