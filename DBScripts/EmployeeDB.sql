--CREATE Database EmployeeManagment
--GO


USE EmployeeManagment
GO

IF NOT EXISTS (SELECT * FROM SYS.tables WHERE NAME = 'tblTags')
BEGIN
	CREATE TABLE tblTags
	(
		ID INT IDENTITY(1,1) PRIMARY KEY
		,TAG VARCHAR(30)
	)
END
GO

IF NOT EXISTS (SELECT * FROM SYS.tables WHERE NAME = 'tblEmployees')
BEGIN
	CREATE TABLE tblEmployees
	(
		ID INT IDENTITY(1,1) PRIMARY KEY
		,FIRST_NAME VARCHAR(75)
		,LAST_NAME VARCHAR(75)
		,SALARY DECIMAL
	)
END
GO

IF NOT EXISTS (SELECT * FROM SYS.tables WHERE NAME = 'tblEmployeesTags')
BEGIN
	CREATE TABLE tblEmployeesTags
	(
	ID INT IDENTITY(1,1) PRIMARY KEY
	,TAG_ID INT
	,EMP_ID INT
	,CONSTRAINT FK_tblTags_TagId FOREIGN KEY (TAG_ID) REFERENCES tblTags(ID)
	,CONSTRAINT FK_tblEmployees_EmpId FOREIGN KEY (EMP_ID) REFERENCES tblEmployees(ID)
	)
END
GO

IF NOT EXISTS (SELECT * FROM tblTags)
BEGIN
	INSERT INTO tblTags (TAG) VALUES ('elderbatch1')
	INSERT INTO tblTags (TAG) VALUES ('elderbatch2')
	INSERT INTO tblTags (TAG) VALUES ('youngerbarch')
	INSERT INTO tblTags (TAG) VALUES ('kidsbatch')
	INSERT INTO tblTags (TAG) VALUES ('software')
	INSERT INTO tblTags (TAG) VALUES ('business')
	INSERT INTO tblTags (TAG) VALUES ('schooling')
	INSERT INTO tblTags (TAG) VALUES ('others')
END
GO

IF NOT EXISTS (SELECT * FROM tblEmployees)
BEGIN
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Padmasekhar','Pottepalem', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Narmada','Pottepalem', 100000)

	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Jayachandu','Pottepalem', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Jhansi Rani','Pottepalem', 100000)

	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Kalpana','Kamepalli', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Prasad','Kamepalli', 100000)

	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Venkat Sai Charan','Pottepalem', 100000)
	
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Samanvi','Pottepalem', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Charvic Sai','Pottepalem', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Hetanshi','Pottepalem', 100000)
	
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Sahasra','Kamepalli', 100000)
	INSERT INTO tblEmployees (FIRST_NAME, LAST_NAME, SALARY) VALUES ('Manvisri','Kamepalli', 100000)
END
GO

IF NOT EXISTS (SELECT * FROM tblEmployeesTags)
BEGIN
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (2, 1)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (5, 1)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (2, 2)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (5, 2)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (1, 3)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (8, 3)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (1, 4)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (8, 4)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (1, 5)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (5, 5)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (1, 6)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (6, 6)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (3, 7)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (7, 7)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (4, 8)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (7, 8)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (4, 9)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (4, 10)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (7, 10)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (4, 11)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (7, 11)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (4, 12)
	INSERT INTO tblEmployeesTags (TAG_ID, EMP_ID) VALUES (7, 12)
END
GO
