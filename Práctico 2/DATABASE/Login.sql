USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE Login
(
	@Usuario        VARCHAR(50),
	@Contrase�a     VARCHAR(50)
)

AS
BEGIN
	SELECT COUNT(*) FROM Empleados WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a
END