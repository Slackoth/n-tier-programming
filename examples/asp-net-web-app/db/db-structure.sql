--tabla usuario
create table usuario(
	nombre varchar(30) primary key,
	contrasena varchar(50)
);

--tabla libro
create table libro(
	idlibro integer primary key identity (1000,1),
	nombre nvarchar(MAX),
	autor char(30),
	fecha datetime
);

--tabla biblioteca
create table biblioteca(
	idbiblioteca integer primary key identity (1000,1),
	nombre_usuario varchar(30),
	idlibro integer
);

--relaciones entre tablas
alter table biblioteca add foreign key (nombre_usuario) references usuario (nombre);
alter table biblioteca add foreign key (idlibro) references libro (idlibro);

--consultas a tablas
select * from usuario;
select * from libro;
select * from biblioteca;