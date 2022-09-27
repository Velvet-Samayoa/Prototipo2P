create database hotel;
use hotel;

create table reservacion(
	idReservacion varchar(15) primary key not null,
    idCliente varchar(15) not null,
    idHabitacion varchar(15) not null,
    cantidadHabitacion int not null,
    fechaInicio date not null,
    fechaFin date not null,
    estatus varchar(1) not null,             -- checkin, checkout, activo, inactivo
    
    /*Llaves foráneas*/
    foreign key (idCliente) references cliente (pkid)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table tipoCliente(                      /*Huésped, Invitado(consumidor)*/
	idTipo varchar(15) primary key not null,
    nombre varchar(35) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
create table cliente(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	idTipo varchar(15) not null,
	apellido varchar(30) not null,
	nit varchar(15) not null,
	telefono varchar(15) not null,
	direccion varchar(50) not null,
	correo varchar(50) not null,
	estatus varchar(1),

foreign key (idTipo) references tipoCliente(idTipo)
)engine=InnoDB DEFAULT CHARSET=latin1;

select * from reservacion;
insert into tipoCliente values("1000","bueno","1");
insert into cliente values ("250","Jose","1000","Feliciano","15608542","5412-9512","zona 14","notiene@gmail.com","0");
insert into reservacion values ("100","250","500",5,"2022-09-25","2022-09-29","2");
insert into reservacion values ("101","250","501",5,"2022-10-25","2022-10-29","3");


