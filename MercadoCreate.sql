USE Mercado;

CREATE TABLE `productos` (
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`nombre` varchar(255) NOT NULL,
	`precio` float NOT NULL,
	`stock` int(11) NOT NULL,

	PRIMARY KEY (`id`)
);

CREATE TABLE `tickets` (
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`total` float NOT NULL,
	`tipo` varchar(255) NOT NULL,
	`fecha` date NOT NULL,

	PRIMARY KEY (`id`)
);

CREATE TABLE `usuarios` (
	`username` varchar(255) NOT NULL,
	`password` varchar(255) NOT NULL,
	`rol` varchar(255) NOT NULL,

	PRIMARY KEY (`username`)
);

create table tickets_productos (
id int not null auto_increment,
ticket_id int not null,
producto varchar(255) not null,
precio float not null,
primary key(id)
);

alter table tickets_productos add foreign key(ticket_id) references tickets(id);
