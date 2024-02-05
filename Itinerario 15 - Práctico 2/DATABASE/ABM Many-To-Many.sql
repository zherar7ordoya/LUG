--AYUDA-MEMORIA:
--Students => Ordenes (Pedidos)
--Courses  => Items   (Productos)

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_StudentCourses
    @StudentId INTEGER,
    @StudentName VARCHAR(50),
    @CourseId INTEGER,
    @CourseName VARCHAR(50),
    @StatementType NVARCHAR(20)
AS
BEGIN

    DECLARE @Student_Id int
    DECLARE @Course_Id int

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar �tems
	--a una orden. No se han hecho m�s pruebas.

	--Par�metros necesarios: creo que todos.

    IF @StatementType = 'Insert'
    BEGIN
        INSERT Students (StudentName)
        SELECT DISTINCT @StudentName
        FROM Students
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Students 
			WHERE StudentId = @StudentId
        )

        IF @StudentId = 0
        BEGIN
            SELECT @Student_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Student_Id = @StudentId
        END

        INSERT Courses (CourseName)
        SELECT DISTINCT @CourseName
        FROM Courses
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Courses 
			WHERE CourseId = @CourseId
        )

        IF @CourseId = 0
        BEGIN
            SELECT @Course_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Course_Id = @CourseId
        END

        INSERT INTO StudentCourses
        VALUES
        (@Student_Id, @Course_Id)
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    --NOTA:
	--Por el momento (incluso creo que esta secci�n es un "huevo de pascua")
	--la operaci�n de listado implica a los �tems de una �rden.

	--Par�metros necesarios: ID de la �rden.
	
	IF @StatementType = 'Select'
    BEGIN
        SELECT StudentName,
               CourseName
        FROM Courses
            JOIN StudentCourses ON Courses.CourseId = StudentCourses.CourseId
            JOIN Students ON Students.StudentId = StudentCourses.StudentId
        WHERE Students.StudentId = @StudentId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de art�culos pedida.

	--Par�metros necesarios: ID del �tem.

	IF @StatementType = 'Update'
    BEGIN
        UPDATE Courses
        SET CourseName = @CourseName
        WHERE CourseId = @CourseId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--USO: 
	--Las tablas son de �rdenes y sus �tems.
	--Si deseo borrar la �rden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACI�N QUE SE HAR�.

	--EN UN FUTURO, SE PODR�A AJUSTAR PARA QUE:
	--Si no deseo borrar la �rden, Id = 0
	--Si deseo borrar un �tem de la orden, proveo su ID.
	--Si no deseo borrar un �tem, Id = 0

	--Par�metros necesarios: ID de la �rden.

    IF @StatementType = 'Delete'
    BEGIN
        DELETE FROM Students
        WHERE StudentId = @StudentId
    END

END