create database FTM
use FTM

create table MEMBER
(
	MemberID int not null IDENTITY(1,1) primary key,
	FirstName varchar(20) not null,
	LastName varchar(40) not null,
	DateOfBirth date not null, 
	Gender varchar(3) not null,
	PlaceOfOrigin varchar(255),
	Email varchar(50),
	Biography varchar(max),
	MemberProfilePicture varbinary(max)

)

create table RELATIONSHIP_SPOUSE
(
	MemberID1 int,
	MemberID2 int,
	SpouseID int not null IDENTITY(1,1) primary key,
	constraint FK_Relationship_Spouse_Member1 foreign key (MemberID1) references Member (MemberID),
	constraint FK_Relationship_Spouse_Member2 foreign key (MemberID2) references Member (MemberID)
)

create table RELATIONSHIP_PARENT_CHILD
(
	ChildID int,
	ParentID int,
	primary key (ChildID, ParentID),
	constraint FK_Relationship_P_C_Child foreign key (ChildID) references Member (MemberID),
	constraint FK_Relationship_P_C_Parent foreign key (ParentID) references RELATIONSHIP_SPOUSE (SpouseID),
)