--AYUDA-MEMORIA:
--Students => Ordenes (Pedidos)
--Courses  => Items   (Productos)

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Ordenes_Items
    --Ordenes
	@Legajo         INTEGER,
	@Fecha          DATE,
	@Estado         CHAR(10),
	--Items
	@CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
	--Ordenes_Items
	@Id             INTEGER,
    @OrdenID        INTEGER,
    @ItemID         INTEGER,
    @Cantidad       INTEGER,
	--Procedimiento Almacenado
    @Instruccion    CHAR(6)
AS
BEGIN

    DECLARE @ID_ORDEN int
    DECLARE @ID_ITEM int

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS
	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar �tems
	--a una orden. No se han hecho m�s pruebas.
	--Par�metros necesarios: creo que todos.

    IF @Instruccion = 'Insert'
    BEGIN

	    --Busco por empleado que pide (por el momento, hasta mejorar el dise�o).
        SELECT @ID_ORDEN = OrdenID
	    FROM Ordenes
	    WHERE Legajo = @Legajo

	    --Busco por nombre del producto (por el momento, hasta mejorar el dise�o).
	    SELECT @ID_ITEM = ItemID
	    FROM Items
	    WHERE Nombre = @Nombre

        IF (@ID_ORDEN IS NULL)
        BEGIN
            INSERT INTO Ordenes
			(
			    Legajo,
				Fecha,
				Estado
			)
		    VALUES
			(
			    @Legajo,
				@Fecha,
				@Estado
			)
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END

        IF (@ID_ITEM IS NULL)
        BEGIN
            INSERT INTO Items
			(
			    CategoriaID,
				Nombre,
				PrecioUnitario,
				ProveedorID
			)
		    VALUES
			(
			    @CategoriaID,
				@Nombre,
				@PrecioUnitario,
				@ProveedorID
			)
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END

	    INSERT INTO Ordenes_Items
        VALUES (@ID_ORDEN, @ID_ITEM, @Cantidad)

    END

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS
	--USO: 
	--Las tablas son de �rdenes y sus �tems.
	--Si deseo borrar la �rden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACI�N QUE SE HAR�.
	--EN UN FUTURO, SE PODR�A AJUSTAR PARA QUE:
	--Si no deseo borrar la �rden, Id = 0
	--Si deseo borrar un �tem de la orden, proveo su ID.
	--Si no deseo borrar un �tem, Id = 0
	--Par�metros necesarios: ID de la �rden.

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES
    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de art�culos pedida.
	--Par�metros necesarios: ID del �tem.

	IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes_Items
        SET Cantidad = @Cantidad
        WHERE OrdenID = @OrdenID AND ItemID = @ItemID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS
	--Por el momento (incluso creo que esta secci�n es un "huevo de pascua")
	--la operaci�n de listado implica a los �tems de una �rden.
	--Par�metros necesarios: ID de la �rden.
	
	IF @Instruccion = 'Select'
    BEGIN
        SELECT Legajo,
               Fecha,
			   Estado,
			   Nombre,
			   Descripcion,
			   PrecioUnitario
        FROM Items
            JOIN Ordenes_Items 
			ON Ordenes_Items.ItemID  = Items.ItemID
            JOIN Ordenes
			ON Ordenes_Items.OrdenID = Ordenes.OrdenID
        WHERE Ordenes.OrdenID = @OrdenID
    END

END