--create database droseroDB

create table Category
(

	id int primary key identity(1,1),
	categoryName nvarchar(500),
	description nvarchar(max)
)

create table FoodItem
(
	id int primary key identity(1,1),
	foodName nvarchar(500),
	description nvarchar(max),
	price decimal,
	categoryId int,
	constraint  FK_Category foreign key (categoryId) references Category(id)
)

create table Users
(
	id int primary key identity(1,1),
	userName nvarchar(500),
	userPassword nvarchar(max),
	phone nvarchar(100),
	emailId nvarchar(500)	
)

create table Address
(
	id int primary key identity(1,1),
	userId int,
	address nvarchar(max),
	addressName nvarchar(100),
	constraint  FK_Users foreign key (userId) references Users(id)
)


create table CustomerOrder
(
	id int primary key identity(1,1),
	quantity int,
	foodItemId int,
	addressId int,
	userId int
)
