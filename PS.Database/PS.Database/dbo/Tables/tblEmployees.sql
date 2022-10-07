﻿CREATE TABLE [dbo].[tblEmployees] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [FIRST_NAME] VARCHAR (75) NULL,
    [LAST_NAME]  VARCHAR (75) NULL,
    [SALARY]     DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
