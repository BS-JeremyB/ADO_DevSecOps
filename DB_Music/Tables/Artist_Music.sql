﻿CREATE TABLE [dbo].[Artist_Music]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Music_Id] INT NOT NULL,
	[Artist_Id] INT NOT NULL,


	CONSTRAINT FK_ARTIST_MUSIC_MUSIC_ID FOREIGN KEY (Music_Id) REFERENCES dbo.[Music](Id),
	CONSTRAINT FK_ARTIST_MUSIC_ARTIST_ID FOREIGN KEY ([Artist_Id]) REFERENCES dbo.[Artist](Id),
)
