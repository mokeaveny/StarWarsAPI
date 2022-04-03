USE StarWars

DROP TABLE IF EXISTS FactionPositions
DROP TABLE IF EXISTS CharacterFactions
DROP TABLE IF EXISTS Position
DROP TABLE IF EXISTS Faction
DROP TABLE IF EXISTS Location
DROP TABLE IF EXISTS Planet
DROP TABLE IF EXISTS Character

CREATE TABLE Character
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(30) NOT NULL,
	Species VARCHAR(30) NOT NULL,
	Height FLOAT,
	Weight FLOAT,
	HairColour VARCHAR(20),
	EyeColour VARCHAR(20)
)

CREATE TABLE Planet
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(30),
	Region VARCHAR(30),
	Sector VARCHAR(30),
	System VARCHAR(30),
	NumberOfMoons INT,
	NumberOfSuns INT,
	OrbitalPeriod FLOAT,
	RotationPeriodHrs FLOAT,
	Class VARCHAR(30),
	Diameter FLOAT,
	Population BIGINT
)

CREATE TABLE Location
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(30),
	PlanetId INT,
	Population BIGINT,
	Description VARCHAR(1000),
	FOREIGN KEY (PlanetId) REFERENCES Planet(Id)
)

CREATE TABLE Faction
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(30) NOT NULL,
	LeaderTitle VARCHAR(30),
	DateFounded VARCHAR(12),
	PlanetOfOrigin INT,
	FOREIGN KEY (PlanetOfOrigin) REFERENCES Planet(Id)
)

CREATE TABLE Position
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(30) NOT NULL,
	Description VARCHAR(100)
)

CREATE TABLE CharacterFactions
(
	CharacterId INT,
	FactionId INT,
	PRIMARY KEY (CharacterId, FactionId),
	FOREIGN KEY (CharacterId) REFERENCES Character(Id),
	FOREIGN KEY (FactionId) REFERENCES Faction(Id)
)

CREATE TABLE FactionPositions
(
	FactionId INT,
	PositionId INT,
	PRIMARY KEY (FactionId, PositionId),
	FOREIGN KEY (FactionId) REFERENCES Faction(Id),
	FOREIGN KEY (PositionId) REFERENCES Position(Id)
)