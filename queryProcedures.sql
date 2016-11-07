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


