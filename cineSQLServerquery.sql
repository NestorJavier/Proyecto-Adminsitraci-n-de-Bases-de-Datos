CREATE DATABASE Cine

USE Cine

CREATE SCHEMA Establecimiento
CREATE SCHEMA Negocio

CREATE TABLE Establecimiento.Pelicula
(
	IdPelicula BIGINT IDENTITY(1, 1) NOT NULL,
	Titulo VARCHAR(100) NOT NULL,
	Duracion INT NOT NULL,
	Genero VARCHAR(30) NOT NULL,
	Sinopsis VARCHAR(500) NOT NULL,
	FechaLlegada DATE NOT NULL,

	CONSTRAINT PK_Pelicula PRIMARY KEY(IdPelicula)
)

CREATE RULE genero AS @Gen IN('Romance','Terror','Aventura', 'Accion', 'Comedia', 'Suspenso', 'Mexicana', 'Documental', 'Animada', 'Familiar')

EXEC sp_bindrule 'genero' , 'Establecimiento.Pelicula.Genero'

CREATE TABLE Establecimiento.Sucursal
(
	IdSucursal BIGINT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Direccion VARCHAR(200) NOT NULL,

	CONSTRAINT PK_Sucursal PRIMARY KEY(IdSucursal)
)

CREATE TABLE Establecimiento.Sala
(
	IdSala BIGINT IDENTITY(1,1) NOT NULL,
	IdSucursal BIGINT NOT NULL,
	Numero INT NOT NULL,
	CupoTotal INT NOT NULL,

	CONSTRAINT PK_Sala PRIMARY KEY(IdSala),
	CONSTRAINT FK_Sucursal FOREIGN KEY(IdSucursal) REFERENCES Establecimiento.Sucursal(IdSucursal)
)

CREATE TABLE Establecimiento.Funcion
(
	IdFuncion BIGINT IDENTITY(1,1) NOT NULL,
	IdPelicula BIGINT NOT NULL,
	IdSala BIGINT NOT NULL,
	Disponibilidad INT NOT NULL,
	
	CONSTRAINT PK_Funcion PRIMARY KEY(IdFuncion),
	CONSTRAINT FK_Pelicula FOREIGN KEY(IdPelicula) REFERENCES Establecimiento.Pelicula(IdPelicula),
	CONSTRAINT FK_Sala FOREIGN KEY(IdSala) REFERENCES Establecimiento.Sala(IdSala)
)


CREATE TABLE Establecimiento.Asiento
(
	IdAsiento BIGINT IDENTITY(1,1) NOT NULL,
	IdSala BIGINT NOT NULL,
	Estado BIT NOT NULL,
	Fila CHAR NOT NULL,
	Numero INT NOT NULL,

	CONSTRAINT PK_Asiento PRIMARY KEY(IdAsiento),
	CONSTRAINT FK_Sala2 FOREIGN KEY(IdSala) REFERENCES Establecimiento.Sala(IdSala)
)

CREATE TABLE Negocio.Reservacion
(
	IdFuncion BIGINT NOT NULL,
	IdAsiento BIGINT NOT NULL,
	Estado BIT NOT NULL,

	CONSTRAINT FK_Funcion2 FOREIGN KEY(IdFuncion) REFERENCES Establecimiento.Funcion(IdFuncion),
	CONSTRAINT FK_Asiento2 FOREIGN KEY(IdAsiento) REFERENCES Establecimiento.Asiento(IdAsiento)
)


CREATE TABLE Negocio.Membresia
(
	IdMiembro BIGINT IDENTITY(1,1) NOT NULL,
	NombreMiembro VARCHAR(100) NOT NULL,
	Telefono VARCHAR (20) NOT NULL,
	Puntos INT NOT NULL,
	Promocion INT NOT NULL,

	CONSTRAINT PK_Miembro PRIMARY KEY(IdMiembro),
)

CREATE RULE promocion AS @Prom IN('10', '15', '20')

EXEC sp_bindrule 'promocion' , 'Negocio.Membresia.Promocion'

CREATE TABLE Negocio.Venta
(
	IdVenta BIGINT IDENTITY(1,1) NOT NULL,
	IdFuncion BIGINT NOT NULL,
	IdMiembro BIGINT NOT NULL,
	Hora VARCHAR(10) NOT NULL,
	Total REAL NOT NULL,

	CONSTRAINT PK_Venta PRIMARY KEY(IdVenta),
	CONSTRAINT FK_Funcion FOREIGN KEY(IdFuncion) REFERENCES Establecimiento.Funcion(IdFuncion),
	CONSTRAINT FK_Miembro FOREIGN KEY(IdMiembro) REFERENCES Negocio.Membresia(IdMiembro)
)

CREATE TABLE Negocio.DetalleVenta
(
	IdVenta BIGINT NOT NULL,
	IdAsiento BIGINT NOT NULL,
	Subtotal REAL NOT NULL,

	CONSTRAINT FK_Venta FOREIGN KEY(IdVenta) REFERENCES Negocio.Venta(IdVenta),
	CONSTRAINT FK_Asiento FOREIGN KEY(IdAsiento) REFERENCES Establecimiento.Asiento(IdAsiento)
)


CREATE TRIGGER T_Asiento
ON Negocio.DetalleVenta
AFTER INSERT
AS
UPDATE Establecimiento.Asiento SET Estado = 1

DISABLE TRIGGER T_Asiento ON DATABASE

DROP TRIGGER T_Asiento

SELECT * FROM [sys].[triggers] 

-- Triggers funcionales
CREATE TRIGGER Negocio.T_Asiento
ON Negocio.DetalleVenta		
AFTER INSERT
AS
DECLARE @funcion BIGINT
SELECT TOP 1 @funcion = IdFuncion FROM Negocio.Venta V, inserted WHERE V.IdVenta = inserted.IdVenta
IF((SELECT COUNT(R.IdFuncion) FROM Negocio.Reservacion R, inserted WHERE R.IdFuncion = @funcion AND R.IdAsiento = inserted.IdAsiento) = 0)
BEGIN
	INSERT INTO Negocio.Reservacion VALUES (@funcion, (SELECT TOP 1 inserted.IdAsiento FROM inserted), 1)
END
ELSE
BEGIN
	RAISERROR('Asiento ocupado', 16, 1)
	ROLLBACK TRANSACTION
END

CREATE TRIGGER Negocio.T_EliminacionDeralleVenta
ON Negocio.DetalleVenta
AFTER DELETE
AS
DECLARE @funcion BIGINT
SELECT @funcion = IdFuncion FROM Negocio.Venta V, deleted WHERE V.IdVenta = deleted.IdVenta
DELETE FROM Reservacion WHERE IdFuncion = @funcion AND IdAsiento = (SELECT IdAsiento FROM deleted)

CREATE TRIGGER Negocio.T_InsercionDetalleVenta
ON Negocio.DetalleVenta
AFTER INSERT
AS
UPDATE Establecimiento.Funcion SET Disponibilidad = (Disponibilidad - 1) WHERE Establecimiento.Funcion.IdFuncion = (SELECT IdFuncion FROM Negocio.Venta V, inserted WHERE V.IdVenta = inserted.IdVenta)

CREATE TRIGGER Negocio.T_AumentoVenta
ON Negocio.DetalleVenta
AFTER INSERT
AS
UPDATE Negocio.Venta SET Total = (Total + (SELECT Subtotal FROM inserted)) WHERE Negocio.Venta.IdVenta = (SELECT IdVenta FROM inserted)

CREATE TRIGGER Negocio.T_PuntosMembresia
ON Negocio.DetalleVenta
AFTER INSERT
AS
UPDATE Negocio.Membresia SET Puntos = (Puntos + (SELECT Subtotal FROM inserted)*(Promocion/100)) WHERE Negocio.Membresia.IdMiembro = (SELECT V.IdMiembro FROM inserted, Negocio.Venta V WHERE V.IdVenta = inserted.IdVenta)

CREATE TRIGGER Negocio.T_AumentoPromocion
ON Negocio.Membresia
AFTER UPDATE
AS
If((SELECT inserted.Puntos FROM inserted) > 50)
BEGIN
	UPDATE Negocio.Membresia SET Promocion = 15 WHERE IdMiembro = (SELECT IdMiembro FROM inserted)
END
ELSE
If((SELECT inserted.Puntos FROM inserted) > 100)
BEGIN
	UPDATE Negocio.Membresia SET Promocion = 20 WHERE IdMiembro = (SELECT IdMiembro FROM inserted)
END

INSERT INTO Establecimiento.Sucursal
INSERT INTO Establecimiento.Sala VALUES (1, 12, 30)
INSERT INTO Establecimiento.Funcion VALUES (1, 1, 30)
INSERT INTO Negocio.Venta VALUES (1, 1, '10:00', 100)

INSERT INTO Negocio.DetalleVenta VALUES (3, 1, 10)
INSERT INTO Negocio.DetalleVenta VALUES (3, 2, 10)

SELECT * FROM Negocio.DetalleVenta
SELECT * FROM Negocio.Reservacion
SELECT * FROM Negocio.Venta
SELECT * FROM Establecimiento.Funcion

DELETE FROM Negocio.Venta WHERE IdVenta = 3