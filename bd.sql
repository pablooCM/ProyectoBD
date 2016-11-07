create database SistemaVentas
use SistemaVentas
create table Clientes(
	codCliente int not null,
	CHECK (codCliente>999 and codCliente <=9999),
	nombreCliente char(60),
	codPais char(3),
	direccion char(180),
	codPostal char(12),
	direccioEntrega char(180),
	correoelectronico char(60),
	fechaIniRRCC date,
	condicionPago char(40),
	limiteCredito numeric(7,0)
	primary key(codCliente)
)
