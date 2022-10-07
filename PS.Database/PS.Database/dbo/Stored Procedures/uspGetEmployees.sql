CREATE PROC uspGetEmployees
@Id INT
AS
BEGIN
	SELECT * FROM tblEmployees WHERE ID = @Id
END
