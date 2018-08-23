CREATE DATABASE TwitDB
GO
USE TwitDB
GO

CREATE TABLE UserTable(
	Id int IDENTITY(1, 1),
	[Name] char(50) NOT NULL,
	Surname char(50) NOT NULL,
	Avatar char(100) NULL,
	[Login] char(50) NOT NULL,
	[Password] char(50) NOT NULL,

	CONSTRAINT PK_UserTable_Id PRIMARY KEY (Id)
)

GO

CREATE TABLE PostTable(
	Id int IDENTITY(1, 1),
	Sender_Id int NOT NULL,
	SendTime time NOT NULL,
	Theme char(50) NULL,
	Tag char(20) NOT NULL,

	CONSTRAINT PK_PostTable_Id PRIMARY KEY (Id),
	CONSTRAINT FK_PostTable_UserTable_Sender FOREIGN KEY (Sender_Id) REFERENCES UserTable(Id)
)