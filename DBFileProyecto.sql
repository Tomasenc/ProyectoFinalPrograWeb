CREATE DATABASE POS_Restaurant;

use POS_Restaurant;

----------------------------------------Table Creation section----------------------------------------
create table UserLogin (
userID int identity (1,1),
username varchar(10),
pass varchar(100),
name varchar (100),
lastName varchar (100),
userType int
PRIMARY KEY (userID)
);

create table UserType (
idUserType int identity (1,1),
description varchar (30)
PRIMARY KEY (idUserType)
);

-------------------------------------------Foreign keys-----------------------------------------------
alter table UserLogin add foreign key (userID) references UserType(idUserType);



-------------------------------------------Filling data-----------------------------------------------
insert into UserType (description) values ('Mesero');
insert into UserType (description) values ('Gerente');

insert into UserLogin (username, pass, name, lastName, userType) values ('Gerente', 'Gerente', 'GerenteName', 'GerenteLastName', 2);
insert into UserLogin (username, pass, name, lastName, userType) values ('Mesero', 'Mesero', 'MeseroName', 'MeseroLastName', 1);
