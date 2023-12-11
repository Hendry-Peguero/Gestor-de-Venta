-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS ProyectoFinal;
USE ProyectoFinal;

-- Crear la tabla de Producto
CREATE TABLE IF NOT EXISTS Producto (
    IdProducto INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(13, 2) NOT NULL
);

-- Crear la tabla de ventas (Venta)
CREATE TABLE IF NOT EXISTS Venta (
    IdVenta INT AUTO_INCREMENT PRIMARY KEY,
    IdProducto INT,  -- Agrega la columna IdProducto
    Producto VARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL,
    FechaVenta DATETIME NOT NULL,
    TotalVenta DECIMAL(13, 2) NOT NULL,
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);

-- Crear la tabla de historial de ventas
CREATE TABLE IF NOT EXISTS HistorialVenta (
    IdHistorial INT AUTO_INCREMENT PRIMARY KEY,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    FechaVenta DATE NOT NULL,
    TotalVenta DECIMAL(13, 2) NOT NULL,
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);

CREATE TABLE IF NOT EXISTS Usuario (
    idUsuario INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL
);

-- Insertar un registro en la tabla Usuario
INSERT INTO Usuario (usuario, password) VALUES ('hola', '1234');


-- Crear procedimiento almacenado para mover datos de Venta a HistorialVenta
DELIMITER //

CREATE PROCEDURE MoverDatosVentaAHistorial()
BEGIN
    -- Insertar datos de Venta a HistorialVenta
    INSERT INTO HistorialVenta (IdProducto, Cantidad, FechaVenta, TotalVenta)
    SELECT IdProducto, Cantidad, FechaVenta, TotalVenta
    FROM Venta;

    -- Actualizar la cantidad en la tabla Producto
    UPDATE Producto P
    INNER JOIN Venta V ON P.IdProducto = V.IdProducto
    SET P.Cantidad = P.Cantidad - V.Cantidad;

    -- Eliminar datos de Venta
    DELETE FROM Venta;
END;

//
DELIMITER ;




