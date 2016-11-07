create procedure insertaCliente
	@codigo int,
	@nombre char(60),
	@pais char(3),
	@direccion char(180),
	@codPostal char(12),
	@direccionEntrega char(180),
	@correo char(60),
	@fecha date,
	@condicion char(40),
	@limite int
	as
	begin
		insert into Clientes values(@codigo, @nombre, @pais, @direccion, @codPostal, @direccionEntrega, @correo, @fecha, @condicion, @limite)
	end
	
create procedure insertaTelefonoCliente
	@telefono int,
	@codigo int
	as
	begin
		insert into TelefonoCLiente values(@codigo, @telefono)
	end

select * from Clientes

select * from TelefonoCliente

drop procedure insertaCliente
delete from Clientes
delete from TelefonoCliente
exec insertaCliente 8760, 'Pablo', '506', 'Cartago', '233', 'Calle Blancos', 'asdsd', '11-5-2016', '30', 200

exec insertTelefonoCliente 87675678, 876



 





--------------------


create procedure insertaCatalogo
	@SKU int,
	@descripProducto char(60),
	@costo int,
	@precioVenta int,
	@existencia int,
	@impVentas int,
	@descripcion char(60)
	
	as
	begin
		insert into CatalogodeProductos values(@SKU,@descripProducto ,@costo,@precioVenta ,@existencia,@impVentas)
	end



select * from CatalogodeProductos


drop procedure insertaCatalogo
delete from CatalogodeProductos

exec insertaCatalogo 234120,'Zapatos azules',8500.00,9500.00,8000012,13.00

-----------------
create procedure actualizaTelCliente
	@codigo int,
	@telefono int

AS
BEGIN 
      SET NOCOUNT ON 

      UPDATE TelefonoClientes
      SET 
			telefonoCliente=@telefono 
      FROM   TelefonoClientes
	  where
		codCliente=@codigo
              
END
create procedure actualizaCatalogo
	@SKU int,
	@descripProducto char(60),
	@costo int,
	@precioVenta int,
	@existencia int,
	@impVentas int
AS
BEGIN 
      SET NOCOUNT ON 

      UPDATE CatalogodeProductos
      SET 
		descripProducto=@descripProducto,
		costo=@costo ,
		precioVenta=@precioVenta ,
		existencia=@existencia ,
		impVentas=@impVentas 
	
      FROM   CatalogdeProductos
	  wHERE  
			SKU=@SKU
      
              
END
GO

	



---------------
create procedure eliminaCatalogo
	@SKU int
	as
	begin
		delete CatalogodeProductos
		from catalogodeProductos
		where SKU=@SKU
	end











