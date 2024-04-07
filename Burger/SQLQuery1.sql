create database Burger
use Burger

create table Category
(
Id int primary key identity (1,1),
[Name] nvarchar (100) not null
)

create table Product
(
Id int primary key identity (1,1),
[Name] nvarchar (100) not null,
Description nvarchar  (100) not null,
Price float not null,
ImageUrl nvarchar (200),
CategoryId int not null,
foreign key (CategoryId) references Category(Id)
)