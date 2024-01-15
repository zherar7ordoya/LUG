USE [MiBasev2]
GO

/****** Object:  StoredProcedure [dbo].[s_BorrarAlumno]    Script Date: 15/1/2024 08:40:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[s_BorrarAlumno] @C INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	DELETE
	FROM Alumno
	WHERE Codigo = @C
END
