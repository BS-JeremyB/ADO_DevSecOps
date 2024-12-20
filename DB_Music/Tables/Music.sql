CREATE TABLE [dbo].[Music]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(250) NOT NULL,
	[Release_Date] Date NULL,
	[Duration] TIME NULL,
	[Spotify_Link] NVARCHAR(MAX) NULL,

	CONSTRAINT UK_Title_Release_Date UNIQUE ([Title], [Release_Date])


)
