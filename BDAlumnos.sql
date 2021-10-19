inscripciones

create database Alumnos;
use Alumnos;

create table Grados(
idGrado int primary key, 
Descripcion varchar (15)
);

create table Grupos (
idGrupo int primary key, 
Nombre varchar (2)
);

create table Materias (
idMateria int primary key, 
Nombre_Materia varchar(20), 
Descripcion varchar (50)
);

create table Estudiante_Materia(
idEstudiante_Materia int primary key,
idEstudiantes int, 
foreign key (idEstudiantes) REFERENCES Estudiantes (idEstudiantes),
idMateria int, 
foreign key (idMateria) REFERENCES Materias (idMateria),
);

create table Estudiantes (
idEstudiantes int primary Key, 
Matricula varchar (15) not null, 
Nombre varchar(35) not null, 
Promedio double not null, 
idGrado int, 
foreign key (idGrado) REFERENCES Grados (idGrado), 
idGrupo int, 
foreign key (idGrupo)REFERENCES Grupos (idGrupo)
);

create table Usuarios (
idUsuario int primary key, 
Nombre varchar(30), 
Username varchar (30),
password varchar(30),
idRol int, 
foreign key (idRol) REFERENCES Roles (idRol),
);


create table Roles(
idRol int primary key,
Descripcion varchar(20)
);



insert into Grados values (01,'Primero');
insert into Grados values (02,'Segundo');
insert into Grados values (03,'Tercero');

insert into Grupos values (01,'A');
insert into Grupos values (02,'B');
insert into Grupos values (03,'C');

insert into Materias values (11,'Español I', 'Español para primer año');
insert into Materias values (12,'Matemáticas I', 'Matmáticas para primer año');
insert into Materias values (13,'Inglés I', 'Inglés para primer año');
insert into Materias values (21,'Español II', 'Español para segundo año');
insert into Materias values (22,'Matemáticas II', 'Matmáticas para segundo año');
insert into Materias values (23,'Inglés II', 'Inglés para segundo año');
insert into Materias values (33,'Español III', 'Español para segundo año');
insert into Materias values (32,'Matemáticas III', 'Matmáticas para segundo año');
insert into Materias values (33,'Inglés III', 'Inglés para segundo año');



insert into Roles values (1,'Administrador');
insert into Roles values (2,'Co_Matemáticas');
insert into Roles values (3,'Co_Español');
insert into Roles values (4,'Co_Inglés');

insert into Usuarios values (01,'Latapide Pablo','LataPa','Reach1506', 1);
insert into Usuarios values (02,'Jiménez Esmeralda','JimeEs','Agua7979', 2);
insert into Usuarios values (03,'Lara Victor','LaraVi','Beerx123', 3);
insert into Usuarios values (04,'Ochoa Daniela','OchoDa','Matias616', 4);
