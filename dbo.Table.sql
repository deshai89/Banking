CREATE TABLE [dbo].[Members]
(
	[Member_ID] INT NOT NULL PRIMARY KEY, 
    [Member_Name] NCHAR(20) NULL, 
    [Member_Pin] INT NULL, 
    [Member_Funds] MONEY NULL
)
