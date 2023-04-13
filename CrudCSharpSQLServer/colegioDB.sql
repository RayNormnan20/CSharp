

create database colegioDB
use colegioDB
create table alumnos
(codigo int identity (1,1) primary key not null,
dni varchar (8),
nombres varchar (50),
apellidos varchar (50),
edad int

)

insert into alumnos (dni, nombres, apellidos, edad) values ('76079784', 'Jose', 'Pintado Yamo', 20)
insert into alumnos (dni, nombres, apellidos, edad) values ('76079700', 'Aracely', 'Corrales Meza', 20)
insert into alumnos (dni, nombres, apellidos, edad) values ('76079722', 'Frnacisco', 'Godoy Espinal', 19)


select * from alumnos
update alumnos set alumnos.dni = '22222222', alumnos.nombres = 'Juan', alumnos.apellidos = 'Prado', alumnos.edad = 20 WHERE alumnos.codigo = 3


go 
DELETE FROM alumnos WHERE alumnos.codigo = 3