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

-------------------------------------------Foreign keys-----------------------------------------------
alter table UserLogin add foreign key (userType) references UserType(idUserType);
alter table TableNumber add foreign key (idTableStatus) references TableStatus(idStatus);


-------------------------------------------Filling data-----------------------------------------------
insert into UserType (description) values ('Mesero');
insert into UserType (description) values ('Gerente');

insert into UserLogin (username, pass, name, lastName, userType) values ('Gerente', 'Gerente', 'GerenteName', 'GerenteLastName', 2);
insert into UserLogin (username, pass, name, lastName, userType) values ('Mesero', 'Mesero', 'MeseroName', 'MeseroLastName', 1);

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