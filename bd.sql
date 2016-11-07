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
create table Pedidos (
	idPedido int not null,
	fechaPedido date,
	fechaEntrega date,
	codigoPago int,
	codEjVentas int,
	codCliente int foreign key references Clientes(codCliente),
	primary key (idPedido),
)
create table Facturacion(
	idFactura int not null,
	fechaFactura date,
	direccionEntrega char(180),
	condicionPago char(40),
	fechaVencimiento date,
	primary key(idFactura)

	)
create table Personal(
	idPersonal int not null,
	cedula int,
	nombrePila char(20), 
	primerApellido char(20),
	segundoApellido char(20),
	correoelectronico_emp char(120),
	lugarResidencia char(60),
	puestoTrabajo char(4),
	fechaNacimiento date,
	fechaIngresoEmpresa date,
	fechaRetiro date
	
	primary key(idPersonal)
)

create table CatalogodeProductos(
	SKU int not null
	CHECK (SKU>99999 and SKU <=999999),
	descripProducto char(60),
	costo numeric (4,2),
	precioVenta numeric (4,2),
	existencia int
	CHECK (existencia>=99999 and existencia <=999999),
	impVentas numeric (4,2),
	descripcion char(60)
	primary key(SKU)
)


create table CXC(
	numFactura int,
	fechaFactura date,
	condPago char(40),
	fechaVencimiento date,
	numCliente int,
	totalFactura int,
	totalImp numeric (6,2),
	totalPagado int,
	idFactura int foreign key references Facturacion(idFactura),
	primary key(numFactura)
)


create table SeFactura (
	idPedido int foreign key references Pedidos(idPedido),
	numFactura int foreign key references CXC(numFactura),
	primary key (idPedido,numFactura)
)

create table DetallePedido(
	cantPedida int,
	descuento numeric (7,2),
	precioVenta numeric (4,2),
	impVenta numeric (6,2),
	precioTotal numeric (8,2),
	idPedido int foreign key references Pedidos(idPedido),
	SKU int foreign key references CatalogodeProductos(SKU),
	primary key (cantPedida)
)

create table DetalleFacturacion(
	idPedido int not null,
	descripcion char(120),
	unidadesFacturadas int,
	precioVentaUnitario numeric (4,2),
	subtotal int,
	descuento int,
	totalImpuesto int,
	totalPagar int,
	idFactura int foreign key references Facturacion(idFactura),
	primary key (idPedido)
	
)
create table TelefonoCLiente(
	codCliente int foreign key references Clientes(codCliente),
	telefonoCliente int,
	CHECK (telefonoCliente>20000000 and telefonoCliente <=89999999)
)

create table TelefonoPersonal(
	idPersona int foreign key references Personal(idPersonal),
	telefonoPersonal int,
	CHECK (telefonoPersonal>20000000 and telefonoPersonal <=89999999)
)


create table Instrucciones(
	query varchar(1000)
)