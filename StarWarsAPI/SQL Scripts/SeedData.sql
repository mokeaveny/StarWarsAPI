USE StarWars

INSERT INTO Character VALUES 
('Luke Skywalker', 'Human', '1.72', '73', 'Blonde', 'Blue')

INSERT INTO Planet VALUES
('Ahch-To', 'Unknown Regions', NULL, 'Ahch-To System', 1, 2, NULL, NULL, NULL, NULL, NULL)

INSERT INTO Location VALUES
('Jedi Village', 1, NULL, 'This settlement was constructed an unfathomable number of years prior to Jedi Master Luke Skywalkers
 residence in the village, and consisted of ancient stone structures and cold huts that offered few comforts for their inhabitants. 
 Skywalker himself made his home in a hut in the village,[1] and accommodated Rey in another during her stay on the island. 
 Caretakers of the Lanai also lived in and maintained the village huts.')

INSERT INTO Faction VALUES
('Jedi Order', 'Grand Master', '25000 BBY', 1)

INSERT INTO Position VALUES 
('Master of the order', 'Elected leader of the Jedi High Council')

INSERT INTO CharacterFactions VALUES
(1, 1)

INSERT INTO FactionPositions VALUES
(1, 1)

SELECT * FROM Character;

SELECT * FROM Faction;

SELECT * FROM Position;

SELECT * FROM Planet;

SELECT * FROM Location;

SELECT * FROM CharacterFactions;

SELECT * FROM FactionPositions;