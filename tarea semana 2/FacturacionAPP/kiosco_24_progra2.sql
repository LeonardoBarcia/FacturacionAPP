create database Kiosco_24
use Kiosco_24

create table formasPago
(id_forma_pago int identity,
nombre_formas_Pago varchar(15),
constraint pk_formas_pago primary key (id_forma_pago))

create table articulos
(id_articulo int identity,
nombre_articulo varchar (50),
precio_unitario decimal(10,2),
constraint pk_articulos primary key (id_articulo)
)

create table detalles_facturas
(id_detalles_facturas int identity,
id_articulo int,
cantidad int,
constraint pk_detalles_facturas primary key(id_detalles_facturas),
constraint fk_detalles_articulos foreign key(id_articulo)
references articulos(id_articulo)
)

create table facturas
(id_factura int identity,
fecha datetime,
id_forma_pago int,
cliente varchar (30),
total numeric(8,2),
constraint pk_facturas primary key(id_factura),
constraint fk_facturas_forma_pago foreign key(id_forma_pago)
references formasPago(id_forma_pago)
)
set dateformat dmy
INSERT INTO facturas(cliente,total)values('consumidor final',785)
--formas de pago
insert into formasPago(nombre_formas_Pago) values ('Efectivo');
insert into formasPago(nombre_formas_Pago) values ('Debito');
insert into formasPago(nombre_formas_Pago) values ('Transferencia');

--articulos
insert into articulos(nombre_articulo,precio_unitario) values ('Coca-Cola 2,5',750);
insert into articulos(nombre_articulo,precio_unitario) values ('Cerveza Bramaha',900);
insert into articulos(nombre_articulo,precio_unitario) values ('Pebete',250);
insert into articulos(nombre_articulo,precio_unitario) values ('Alfajor fulbito',150);
insert into articulos(nombre_articulo,precio_unitario) values ('Topline 7-seven',120);

CREATE PROCEDURE SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_factura)+1  FROM facturas);
END
SELECT * FROM facturas

execute SP_PROXIMO_ID

create procedure SP_FORMAS_PAGO
AS
BEGIN 
		SELECT * FROM formasPago;
END 

create procedure SP_INSERT_MAESTO
@cliente varchar (150),
@total numeric(8,2),
@numero_factura int output
AS
begin
	insert into facturas(fecha,cliente,total)
	values(GETDATE(),@cliente,@total)
	SET @numero_factura = SCOPE_IDENTITY();
end

create procedure SP_ARTICULOS
as
begin
		select * from articulos
end

CREATE PROCEDURE SP_CONSULTAR_FACTURAS
@FECHA_DESDE DATETIME,
@FECHA_HASTA DATETIME,
@CLIENTE VARCHAR(255)
AS 
BEGIN
SELECT * FROM facturas
WHERE (fecha BETWEEN @FECHA_DESDE AND @FECHA_HASTA)
AND (cliente LIKE '%'+@CLIENTE +'%' )

END