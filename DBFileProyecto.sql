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
productPrice decimal (18,0) not null
primary key (idProductCategory)
);

create table Product (
idProduct int identity (1,1) not null,
productDescription varchar (30) not null,
idProductCategory int not null,
productStatus varchar (10) not null,
productPrice decimal(18,0) not null
primary key (idProduct)
);

create table ServiceOrderStatus (
idServiceOrderStatus int identity (1,1) not null,
ServiceOrderDescription varchar (30) not null,
primary key (idServiceOrderStatus)
);

create table ServiceOrder (
idServiceOrder int identity (1,1) not null,
idUserLogin varchar(10) not null,
idTableNumber int not null,
idServiceOrderStatus int not null,
total decimal (18,2) not null
primary key (idServiceOrder)
);

create table ServiceOrderDetails (
idServiceOrderDetails int identity (1,1) not null,
idServiceOrder int not null,
idProduct int not null,
serviceOrderNotes varchar (100) not null
primary key (idServiceOrderDetails)
);

-------------------------------------------Foreign keys-----------------------------------------------
alter table UserLogin add foreign key (userType) references UserType(idUserType);
alter table TableNumber add foreign key (idTableStatus) references TableStatus(idStatus);
alter table Product add foreign key (idProductCategory) references ProductCategory(idProductCategory);
alter table ServiceOrder add foreign key (idUserLogin) references UserLogin(username);
alter table ServiceOrder add foreign key (idTableNumber) references TableNumber(idTable);
alter table ServiceOrder add foreign key (idServiceOrderStatus) references ServiceOrderStatus(idServiceOrderStatus);
alter table ServiceOrderDetails add foreign key (idServiceOrder) references ServiceOrder(idServiceOrder);
alter table ServiceOrderDetails add foreign key (idProduct) references Product(idProduct);


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

insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Papaya',1,1,800); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Pineaple',1,1,800); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Pineaple',1,1,800); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Blackberry',1,1,800); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Fruits',1,1,800); --NaturalDrink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Bear',2,1,1200); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('whiskey',2,1,1500); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Tequila',2,1,1500); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Smirnoff',2,1,1200); --Liqueur
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Coca-Cola',3,1,1100); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('7Up',3,1,1100); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Evervess',3,1,1100); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Pepsi',3,1,1100); --Soft drink
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Green Smoothie',4,1,1300); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Energy Smoothie',4,1,1300); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Muscle Smoothie',4,1,1300); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Weight Control Smoothie',4,1,1300); --Smoothies
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Patacones',5,1,1800); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Fried Cheese Cubes',5,1,1800); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Chicken Nuggets',5,1,1800); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Ceviche',5,1,2000); --Appetizer
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Olla de carne',6,1,2500); --Main course
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Casado',6,1,2200); --Main course
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Chicken Fajitas',6,1,2200); --Main course
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Beef fajitas',6,1,2800); --Main course
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Rice pudding',7,1,1500); --Dessert
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Icre Cream',7,1,1000); --Dessert
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Fuid Salad',7,1,1000); --Dessert
insert into Product (productDescription,idProductCategory,productStatus,productPrice) values ('Flan',7,1,1000); --Dessert

insert into ServiceOrderStatus (ServiceOrderDescription) values ('Registered'); 
insert into ServiceOrderStatus (ServiceOrderDescription) values ('In process'); 
insert into ServiceOrderStatus (ServiceOrderDescription) values ('Pending'); 
insert into ServiceOrderStatus (ServiceOrderDescription) values ('Delivered'); 
insert into ServiceOrderStatus (ServiceOrderDescription) values ('Finished');

insert into ServiceOrder (idUserLogin, idTableNumber) values ('manager', 1, 3200); 
insert into ServiceOrder (idUserLogin, idTableNumber) values ('manager', 2, 1600); 
insert into ServiceOrder (idUserLogin, idTableNumber) values ('manager', 3, 2000); 
insert into ServiceOrder (idUserLogin, idTableNumber) values ('manager', 4, 2000); 
insert into ServiceOrder (idUserLogin, idTableNumber) values ('manager', 5, 2000);

insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (1, 1, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (1, 2, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (1, 3, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (2, 4, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (2, 5, 'This is a test');
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (2, 6, 'This is a test');
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (3, 1, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (4, 1, 'This is a test'); 
insert into ServiceOrderDetails (idServiceOrder, idProduct, serviceOrderNotes) values (5, 1, 'This is a test'); 