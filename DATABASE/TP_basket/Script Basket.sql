 -- Structure de la base de données
 
CREATE TABLE `Club` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`nom`	TEXT NOT NULL,
	`nomContact`	TEXT  NOT NULL,	
	`telephoneContact`	TEXT  NOT NULL,	
	`nbGagnes`	INTEGER NOT NULL,
	`nbNuls`	INTEGER NOT NULL,
	`nbPerdus`	INTEGER NOT NULL		
);

CREATE TABLE `Joueur` (
	`id` INTEGER PRIMARY KEY AUTOINCREMENT,
	`nom` TEXT NOT NULL,
	`prenom` TEXT NOT NULL,	
	`dateNaissance`	TEXT NOT NULL,	
	`idClub` INTEGER NOT NULL,
	FOREIGN KEY(`idClub`) REFERENCES `Club`(`id`)
);

CREATE TABLE `Match` (
	`id` INTEGER PRIMARY KEY AUTOINCREMENT,
	`dateM`	TEXT NOT NULL,
	`heure`	TEXT NOT NULL,
	`idClubVisite`	INTEGER NOT NULL,
	`scoreClubVisite` INTEGER NOT NULL,
	`idClubVisiteur`	INTEGER NOT NULL,
	`scoreClubVisiteur` INTEGER NOT NULL,
	FOREIGN KEY(`idClubVisite`) REFERENCES `Club`(`id`),
	FOREIGN KEY(`idClubVisiteur`) REFERENCES `Club`(`id`)
);

CREATE TABLE `Participer` (
	`idMatch`	INTEGER NOT NULL,
	`idJoueur`	INTEGER NOT NULL,
	`nbPoint`	INTEGER NOT NULL,
	`nbFaute`	INTEGER NOT NULL,	
	PRIMARY KEY(`idMatch`,`idJoueur`),	
	FOREIGN KEY(`idMatch`) REFERENCES `Match`(`id`),
	FOREIGN KEY(`idJoueur`) REFERENCES `Joueur`(`id`)
);

 -- Remplissage des tables pour la préparation du championnat

INSERT INTO Club (nom, nomContact, telephoneContact, nbGagnes, nbNuls, nbPerdus) VALUES ('Niederhausbergen','Sonnen Richard','0629352256',0,0,0);
INSERT INTO Club (nom, nomContact, telephoneContact, nbGagnes, nbNuls, nbPerdus) VALUES ('Mittelhausbergen','Rage Michel','0634301230',0,0,0);
INSERT INTO Club (nom, nomContact, telephoneContact, nbGagnes, nbNuls, nbPerdus) VALUES ('Oberhausbergen','Potz Arnaud','0639259068',0,0,0);

INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Dupoint','Felix', '2005-05-12', 1);
INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Ball', 'Simon', '2004-01-03', 1);
INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Filet', 'Clément', '2004-01-29',2);
INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Raquette', 'Franck', '2005-06-04',2);
INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Ligne', 'Jean', '2003-06-05',3);
INSERT INTO Joueur (nom, prenom, dateNaissance, idClub) VALUES ('Troispoints', 'Corentin', '2005-11-22',3);

INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-01-13','20:00',1, 0, 2, 0);
INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-01-10','20:30',1, 0, 3, 0);
INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-01-06','20:00',2, 0, 3, 0);
INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-02-13','20:30',2, 0, 1, 0);
INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-02-13','20:00',3, 0, 1, 0);
INSERT INTO Match (dateM, heure, idClubVisite, scoreClubVisite, idClubVisiteur, scoreClubVisiteur) VALUES ('2024-02-20','18:00',3, 0, 2, 0);

INSERT INTO Participer VALUES (1,1,0,0);
INSERT INTO Participer VALUES (1,2,0,0);
INSERT INTO Participer VALUES (1,3,0,0);
INSERT INTO Participer VALUES (1,4,0,0);

INSERT INTO Participer VALUES (2,1,0,0);
INSERT INTO Participer VALUES (2,2,0,0);
INSERT INTO Participer VALUES (2,5,0,0);
INSERT INTO Participer VALUES (2,6,0,0);

INSERT INTO Participer VALUES (3,3,0,0);
INSERT INTO Participer VALUES (3,4,0,0);
INSERT INTO Participer VALUES (3,5,0,0);
INSERT INTO Participer VALUES (3,6,0,0);

INSERT INTO Participer VALUES (4,3,0,0);
INSERT INTO Participer VALUES (4,4,0,0);
INSERT INTO Participer VALUES (4,1,0,0);
INSERT INTO Participer VALUES (4,2,0,0);

INSERT INTO Participer VALUES (5,5,0,0);
INSERT INTO Participer VALUES (5,6,0,0);
INSERT INTO Participer VALUES (5,1,0,0);
INSERT INTO Participer VALUES (5,2,0,0);

INSERT INTO Participer VALUES (6,5,0,0);
INSERT INTO Participer VALUES (6,6,0,0);
INSERT INTO Participer VALUES (6,3,0,0);
INSERT INTO Participer VALUES (6,4,0,0);
