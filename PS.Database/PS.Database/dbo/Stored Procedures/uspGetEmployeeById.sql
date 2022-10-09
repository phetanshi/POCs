  
CREATE PROC [dbo].[uspGetEmployeeById]  
@EmployeeId INT  
AS  
BEGIN  
 SELECT ID, FIRST_NAME, LAST_NAME, SALARY FROM tblEmployees WHERE ID = @EmployeeId  
END