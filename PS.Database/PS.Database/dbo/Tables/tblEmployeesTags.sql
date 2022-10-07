CREATE TABLE [dbo].[tblEmployeesTags] (
    [ID]     INT IDENTITY (1, 1) NOT NULL,
    [TAG_ID] INT NULL,
    [EMP_ID] INT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tblEmployees_EmpId] FOREIGN KEY ([EMP_ID]) REFERENCES [dbo].[tblEmployees] ([ID]),
    CONSTRAINT [FK_tblTags_TagId] FOREIGN KEY ([TAG_ID]) REFERENCES [dbo].[tblTags] ([ID])
);

