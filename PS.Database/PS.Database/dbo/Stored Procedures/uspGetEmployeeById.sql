
CREATE PROC [dbo].[uspGetEmployeeById]
@EmployeeId INT
AS
BEGIN
	SELECT * FROM tblEmployees WHERE ID = @EmployeeId
END