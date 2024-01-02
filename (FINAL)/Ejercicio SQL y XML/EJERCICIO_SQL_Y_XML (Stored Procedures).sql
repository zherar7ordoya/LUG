USE [Prinzo]

go


-- =============================================
-- Author:      Gerardo Tordoya
-- Create date: 2023-06-18
-- Update date: XXXX-XX-XX
-- Description: CRUD Unificado
-- =============================================


SET ansi_nulls ON

go

SET quoted_identifier ON

go


-- Stored procedure for Agencia table
CREATE PROCEDURE [dbo].[Sp_agencia_crud] @agencia_id INT,
                                         @action     VARCHAR(10)
AS
  BEGIN
      IF @action = 'SELECT'
        BEGIN
            SELECT *
            FROM   agencia
            WHERE  agencia_id = @agencia_id
        END
      ELSE IF @action = 'INSERT'
        BEGIN
            INSERT INTO agencia
                        (agencia_id)
            VALUES      (@agencia_id)
        END
      ELSE IF @action = 'UPDATE'
        BEGIN
            UPDATE agencia
            SET    agencia_id = @agencia_id
            WHERE  agencia_id = @agencia_id
        END
      ELSE IF @action = 'DELETE'
        BEGIN
            DELETE FROM agencia
            WHERE  agencia_id = @agencia_id
        END
  END

go


-- Stored procedure for Vehiculo table
CREATE PROCEDURE [dbo].[Sp_vehiculo_crud] @vehiculo_id INT,
                                          @marca       VARCHAR(50),
                                          @modelo      VARCHAR(50),
                                          @patente     VARCHAR(20),
                                          @action      VARCHAR(10)
AS
  BEGIN
      IF @action = 'SELECT'
        BEGIN
            SELECT *
            FROM   vehiculo
            WHERE  vehiculo_id = @vehiculo_id
        END
      ELSE IF @action = 'INSERT'
        BEGIN
            INSERT INTO vehiculo
                        (vehiculo_id,
                         marca,
                         modelo,
                         patente)
            VALUES      (@vehiculo_id,
                         @marca,
                         @modelo,
                         @patente)
        END
      ELSE IF @action = 'UPDATE'
        BEGIN
            UPDATE vehiculo
            SET    marca = @marca,
                   modelo = @modelo,
                   patente = @patente
            WHERE  vehiculo_id = @vehiculo_id
        END
      ELSE IF @action = 'DELETE'
        BEGIN
            DELETE FROM vehiculo
            WHERE  vehiculo_id = @vehiculo_id
        END
  END

go


-- Stored procedure for Cliente table
CREATE PROCEDURE [dbo].[Sp_cliente_crud] @cliente_id        INT,
                                         @nombre            VARCHAR(50),
                                         @apellido          VARCHAR(50),
                                         @dni               VARCHAR(20),
                                         @fechaNacimiento   DATE,
                                         @correoElectronico VARCHAR(100),
                                         @action            VARCHAR(10)
AS
  BEGIN
      IF @action = 'SELECT'
        BEGIN
            SELECT *
            FROM   cliente
            WHERE  cliente_id = @cliente_id
        END
      ELSE IF @action = 'INSERT'
        BEGIN
            INSERT INTO cliente
                        (cliente_id,
                         nombre,
                         apellido,
                         dni,
                         fechanacimiento,
                         correoelectronico)
            VALUES      (@cliente_id,
                         @nombre,
                         @apellido,
                         @dni,
                         @fechaNacimiento,
                         @correoElectronico)
        END
      ELSE IF @action = 'UPDATE'
        BEGIN
            UPDATE cliente
            SET    nombre = @nombre,
                   apellido = @apellido,
                   dni = @dni,
                   fechanacimiento = @fechaNacimiento,
                   correoelectronico = @correoElectronico
            WHERE  cliente_id = @cliente_id
        END
      ELSE IF @action = 'DELETE'
        BEGIN
            DELETE FROM cliente
            WHERE  cliente_id = @cliente_id
        END
  END

go


-- Stored procedure for Alquiler table
CREATE PROCEDURE [dbo].[Sp_alquiler_crud] @alquiler_id INT,
                                          @dias        INT,
                                          @importe     FLOAT,
                                          @action      VARCHAR(10)
AS
  BEGIN
      IF @action = 'SELECT'
        BEGIN
            SELECT *
            FROM   alquiler
            WHERE  alquiler_id = @alquiler_id
        END
      ELSE IF @action = 'INSERT'
        BEGIN
            INSERT INTO alquiler
                        (alquiler_id,
                         dias,
                         importe)
            VALUES      (@alquiler_id,
                         @dias,
                         @importe)
        END
      ELSE IF @action = 'UPDATE'
        BEGIN
            UPDATE alquiler
            SET    dias = @dias,
                   importe = @importe
            WHERE  alquiler_id = @alquiler_id
        END
      ELSE IF @action = 'DELETE'
        BEGIN
            DELETE FROM alquiler
            WHERE  alquiler_id = @alquiler_id
        END
  END

go 