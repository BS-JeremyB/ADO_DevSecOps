CREATE TABLE [dbo].[Artist]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Creation_Date] DATE NOT NULL,
    [Retirement_Date] DATE NULL,
    [Country] NVARCHAR(56) NOT NULL,

    CONSTRAINT CK_RETIREMENT_DATE CHECK  ([Retirement_Date] > [Creation_Date])
)
