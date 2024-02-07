-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GuardarCliente
	-- Add the parameters for the stored procedure here
	@Codigo INT,
    @Nombre NVARCHAR(15),
    @Apellido NVARCHAR(15),
    @DNI INT,
    @FechaNacimiento DATE,
    @Email NVARCHAR(30),
    @Codigo_VehiculoRentado INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Cliente (Codigo, Nombre, Apellido, DNI, FechaNacimiento, Email, Codigo_VehiculoRentado)
    VALUES (@Codigo, @Nombre, @Apellido, @DNI, @FechaNacimiento, @Email, @Codigo_VehiculoRentado);
END
GO
