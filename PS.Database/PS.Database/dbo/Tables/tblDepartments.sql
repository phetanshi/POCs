CREATE TABLE [dbo].[tblDepartments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [DeptName] NVARCHAR(50) NULL, 
    [IsActive] BIT NULL
)
