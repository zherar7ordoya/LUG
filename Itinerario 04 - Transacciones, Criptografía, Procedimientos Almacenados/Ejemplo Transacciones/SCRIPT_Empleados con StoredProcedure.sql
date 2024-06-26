USE [Empleados]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 09/21/2016 16:37:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Sueldo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[GUARDAR_EMPLEADO]    Script Date: 09/21/2016 16:37:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--creamos un procedimiento almacenado
CREATE PROC [dbo].[GUARDAR_EMPLEADO](
      @IdEmpleado        integer,
      @Nombre            varchar(50),
      @Sueldo            Decimal(18,0),
-- variable de salida, para conocer el mensaje de la transacción
      @MESSAGE          varchar(500) output
      )
AS
-- Asignamos un nombre a la transaccion
      BEGIN TRAN TRAN_GUARDAR_EMPLEADO
            BEGIN TRY
                  BEGIN
                        INSERT INTO EMPLEADO(IdEmpleado,
                                           Nombre,
                                           Sueldo
                                           )
                                  VALUES(@IdEmpleado,
                                           @Nombre,
                                           @Sueldo                                                 )
                        set @MESSAGE= 'Registro guardado'
                  END
            END TRY
            BEGIN CATCH
                  -- si se produciera algun error desacera los cambios
                  ROLLBACK TRAN TRAN_GUARDAR_EMPLEADO
                  -- asignara a la variable el mensaje de error
                  SET @MESSAGE      =     ERROR_MESSAGE()
            RETURN
            END CATCH
GO
