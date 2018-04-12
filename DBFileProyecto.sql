CREATE DATABASE POS_Restaurant;

use POS_Restaurant;

----------------------------------------Table Creation section----------------------------------------
create table UserLogin (
username varchar(10) not null,
pass varchar(100) not null,
name varchar (100) not null,
lastName varchar (100) not null,
userType int not null
PRIMARY KEY (username)
);


create table UserType (
idUserType int identity (1,1) not null,
description varchar (30) not null
PRIMARY KEY (idUserType)
);


create table TableNumber (
idTable int identity (1,1) not null,
idTableStatus int not null
primary key (idTable)
);


create table TableStatus (
idStatus int identity (1,1) not null,
description varchar (30) not null
primary key (idStatus)
);

create table ProductCategory (
idProductCategory int identity (1,1) not null,
productCategoryDescription varchar (30) not null
primary key (idProductCategory)
);

create table Product (
idProduct int identity (1,1) not null,
productDescription varchar (30) not null,
idProductCategory int not null,
productStatus varchar (10) not null
primary key (idProduct)
);


-------------------------------------------Foreign keys-----------------------------------------------
alter table UserLogin add foreign key (userType) references UserType(idUserType);
alter table TableNumber add foreign key (idTableStatus) references TableStatus(idStatus);
alter table Product add foreign key (idProductCategory) references ProductCategory(idProductCategory);



-------------------------------------------Filling data-----------------------------------------------
insert into UserType (description) values ('Waiter');
insert into UserType (description) values ('Manager');

insert into UserLogin(username, pass, name, lastName, userType) values ('Manager', '123', 'Tomas', 'Navarro', 2);
insert into UserLogin (username, pass, name, lastName, userType) values ('Waiter', '123', 'MeseroName', 'MeseroLastName', 1);

insert into TableStatus (description) values ('Free table');
insert into TableStatus (description) values ('Busy table');
insert into TableStatus (description) values ('Service Order registred');
insert into TableStatus (description) values ('Unactive table');
insert into TableStatus (description) values ('Account payable');

insert into TableNumber (idTableStatus) values (1);
insert into TableNumber (idTableStatus) values (2);
insert into TableNumber (idTableStatus) values (3);
insert into TableNumber (idTableStatus) values (4);
insert into TableNumber (idTableStatus) values (5);

insert into ProductCategory (productCategoryDescription) values ('Natural Drink'); --1
insert into ProductCategory (productCategoryDescription) values ('Liqueur'); --2
insert into ProductCategory (productCategoryDescription) values ('Soft drink'); --3
insert into ProductCategory (productCategoryDescription) values ('smoothies'); --4
insert into ProductCategory (productCategoryDescription) values ('Appetizer/Starter'); --5
insert into ProductCategory (productCategoryDescription) values ('Main course') --6
insert into ProductCategory (productCategoryDescription) values ('Dessert') --7


insert into Product (productDescription,idProductCategory,productStatus) values ('Papaya',1,1); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus) values ('Pineaple',1,1); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus) values ('Blackberry',1,1); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus) values ('Fruits',1,1); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus) values ('Bear',2,1); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus) values ('whiskey',2,1); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus) values ('Tequila',2,1); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus) values ('Smirnoff',2,1); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus) values ('Coca-Cola',3,1); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus) values ('7Up',3,1); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus) values ('Evervess',3,1); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus) values ('Pepsi',3,1); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus) values ('Green Smoothie',4,1); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus) values ('Energy Smoothie',4,1); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus) values ('Muscle Smoothie',4,1); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus) values ('Weight Control Smoothie',4,1); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus) values ('Patacones',5,1); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus) values ('Fried Cheese Cubes',5,1); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus) values ('Chicken Nuggets',5,1); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus) values ('Ceviche',5,1); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus) values ('Olla de carne',6,1); --Main course
insert into Product (productDescription,idProductCategory,productStatus) values ('Casado',6,1); --Main course
insert into Product (productDescription,idProductCategory,productStatus) values ('Chicken Fajitas',6,1); --Main course
insert into Product (productDescription,idProductCategory,productStatus) values ('Beef fajitas',6,1); --Main course
insert into Product (productDescription,idProductCategory,productStatus) values ('Rice pudding',7,1); --Dessert
insert into Product (productDescription,idProductCategory,productStatus) values ('Icre Cream',7,1); --Dessert
insert into Product (productDescription,idProductCategory,productStatus) values ('Fuid Salad',7,1); --Dessert
insert into Product (productDescription,idProductCategory,productStatus) values ('Flan',7,1); --Dessert