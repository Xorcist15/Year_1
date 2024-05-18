--
-- CREATION DE LA BASE DE DONN2ES
--

CREATE TABLE CatPassager(
   id INT,
   libelle VARCHAR(50),
   PRIMARY KEY(id)
);

CREATE TABLE TypeBillet(
   id INT,
   libelle VARCHAR(50),
   PRIMARY KEY(id)
);

CREATE TABLE TypePeriode(
   id INT,
   libelle VARCHAR(50),
   PRIMARY KEY(id)
);

CREATE TABLE Periode(
   id INT,
   dateDebut DATE,
   dateFin DATE,
   commentaire VARCHAR(50),
   idTypePeriode INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(idTypePeriode) REFERENCES TypePeriode(id)
);

CREATE TABLE Lieu(
   id INT,
   nom VARCHAR(30),
   informations VARCHAR(100),
   ile BOOLEAN,
   PRIMARY KEY(id)
);

CREATE TABLE Bateau(
   id INT,
   nom VARCHAR(30),
   longueur DOUBLE,
   largeur DOUBLE,
   vitesse DOUBLE,
   nbPassager SMALLINT,
   nbVehicule TINYINT,
   PRIMARY KEY(id)
);

CREATE TABLE Port(
   id INT,
   nom VARCHAR(30),
   adresse VARCHAR(50),
   codePostal VARCHAR(5),
   ville VARCHAR(30),
   idLieu INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(idLieu) REFERENCES Lieu(id)
);

CREATE TABLE Trajet(
   id INT,
   idPortDepart INT NOT NULL,
   idPortArrivee INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(idPortDepart) REFERENCES Port(id),
   FOREIGN KEY(idPortArrivee) REFERENCES Port(id)
);

CREATE TABLE Reservation(
   id INT,
   nomClient VARCHAR(50),
   dateReservation DATE,
   dateTrajet DATE,
   idTypeBillet INT NOT NULL,
   idTrajet INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(idTypeBillet) REFERENCES TypeBillet(id),
   FOREIGN KEY(idTrajet) REFERENCES Trajet(id)
);

CREATE TABLE Choisir(
   idCatPassager INT,
   idReservation INT,
   nombre INT,
   PRIMARY KEY(idCatPassager, idReservation),
   FOREIGN KEY(idCatPassager) REFERENCES CatPassager(id),
   FOREIGN KEY(idReservation) REFERENCES Reservation(id)
);

CREATE TABLE Tarifs(
   idCatPassager INT,
   idTypeBillet INT,
   idTypePeriode INT,
   prix DECIMAL(19,4),
   PRIMARY KEY(idCatPassager, idTypeBillet, idTypePeriode),
   FOREIGN KEY(idCatPassager) REFERENCES CatPassager(id),
   FOREIGN KEY(idTypeBillet) REFERENCES TypeBillet(id),
   FOREIGN KEY(idTypePeriode) REFERENCES TypePeriode(id)
);

CREATE TABLE utiliser(
   idTrajet INT, 
   idBateau INT,
   duree TIME,
   PRIMARY KEY(idTrajet, idBateau),
   FOREIGN KEY(idTrajet) REFERENCES Trajet(id),
   FOREIGN KEY(idBateau) REFERENCES Bateau(id)
);

--
-- MLD
--

-- CatPassager(id, libelle)
   -- id (PK)

-- TypeBillet (id, libelle)
   -- id (PK)

-- TypePeriode (id, libelle)
   -- id (PK)

-- Periode (id, dateDebut, dateFin, commentaire, idTypePeriode)
   -- id (PK)
   -- idTypePeriode (FK references TypePeriode(id))

-- Lieu (id, nom, informations, ile)
   -- id (PK)

-- Bateau (id, nom, longeur, largeur, vitesse, nbPassager, nbVehicule)
   -- id (PK)

-- Port (id, nom, adresse, codePostal, ville, idLieu)
   -- id (PK)
   -- idLieu (FK references Lieu(id))

-- Trajet (id, idPortDepart, idPortArrivee)
   -- id (PK)
   -- idPortDepart (FK references Port(id))
   -- idPortArrivee (FK references Port(id))

-- Reservation (id, nomClient, dateReservation, dateTrajet, idTypeBillet, idTrajet)
   -- id (PK)
   -- idTypeBillet (FK references TypeBillet(id))
   -- idTrajet (FK references Trajet(id))

-- Choisir (id, idCatPassager, idReservation, nombre)
   -- idCatPassager, idReservation (PK)
   -- idCatPassager (FK references CatPassager(id))
   -- idReservation (FK references Reservation(id))

-- Tarifs (idCatPassager, idTypeBillet, idTypePeriode, prix)
   -- idCatPassager, idTypeBillet, idTypePeriode (PK)
   -- idCatPassager (FK references CatPassager(id))
   -- idTypeBillet (FK references TypeBillet(id))
   -- idTypePeriode (FK references TypePeriode(id))

-- Utiliser (idTrajet, idBateau, duree)
   -- idTrajet, idBateau (PK)
   -- idTrajet (FK references Trajet(id))
   -- idBateau (FK references Bateau(id))

--
-- INSERTION DONN2ES AP1 MISSION 2
--

INSERT INTO Lieu(id, nom, informations, ile)
VALUES
	(1, 'Continent', ' ',0),
	(2, 'Ile de Groix', ' ', 1),
	(3, 'Belle-Ile', ' ', 1),
	(4, 'Ile de Houat', ' ', 1),
	(5, 'Ile de Hoëdic', ' ', 1);

INSERT INTO Port(id, nom, adresse, codePostal, ville, idLieu)
VALUES
	(1, 'Lorient', 'Rue Gilles Gahinet', '56100', 'Lorient', 1),
	(2, 'Quiberon', '8 Quai de l Océan', '56170', 'Quiberon', 1),
	(3, 'Port Tudy', 'Port Tudy', '56590', 'Groix',2),
	(4, 'Sauzon', 'Port Bihan', '56360', 'Sauzon', 3),
	(5, 'Le Palais', 'Quai Bonnelle', '56360', 'Le Palais', 3),
	(6, 'Houat', 'Port de Saint-Gildas', '56170', 'Île-d Houat', 4),
	(7, 'Hoedic', 'Gare Maritime de Hoëdic', '56170', 'Hoedic', 5);

INSERT INTO Bateau(id, nom, longueur, largeur, vitesse, nbPassager, nbVehicule)
VALUES
	(1, 'BREIZH NEVEZ 1', 43.5, 11.6, 11.5, 300, 18),
	(2, 'L ILE DE GROIX', 46, 12, 12, 450, 32),
	(3, 'BANGOR', 46, 12, 12, 450, 32),
	(4, 'VINDILIS', 48, 12.50, 12, 399, 39),
	(5, 'KERDONIS', 30.75, 8, 20, 295, 0),
	(6, 'MELVAN', 31, 8.06, 16.5, 234, 3);

INSERT INTO Trajet(id, idPortDepart, idPortArrivee)
VALUES
	(1, 2, 5),
	(2, 2, 4),
	(3, 2, 6),
	(4, 2, 7),
	(5, 2, 3),
	(6, 1, 2);

INSERT INTO utiliser(idTrajet, idBateau, duree)
VALUES
	(1, 3, '00:45'),
	(1, 5, '00:30'),
	(3, 6, '00:40'),
	(4, 6, '00:55'),
	(6, 2, '00:45'),
	(6, 1, '00:45');

--
-- INSERTION TYPES
--

INSERT INTO CatPassager (id, libelle)
VALUES  (1, 'Adulte 26 ans et plus'),
        (2, 'De 18 à 25 ans inclus'),
        (3, 'Enfant de 4 à 18 ans'),
        (4, 'Enfant moins de 4 ans'),
        (5, 'Titulaire carte invalidité ou son accompagnateur'),
        (6, 'chien');

INSERT INTO TypeBillet (id, libelle)
VALUES  (1, 'Billet Simple'),
        (2, 'Abonné Fréquence 4'),
        (3, 'Abonné Fréquence 10'),
        (4, 'Abonné Illimité');

INSERT INTO TypePeriode (id, libelle)
VALUES  (1, 'PN (période normale)'),
        (2, 'PHF (période haute fréquentation)');

--
-- INSERTION DES PERIODES
--

INSERT INTO Periode (id, dateDebut, dateFin, commentaire, idTypePeriode)
VALUES  
        --
        -- GROUPE 1 janvier - février
        --
        (1, '2024-01-01', '2024-02-29', 'g1', 1), -- i wonder about that null value tbh
        --
        -- janvier
        --
        (2, '2024-01-01', '2024-01-01', 'g1-jour de l''an ', 2),
        (3, '2024-01-05', '2024-01-07', 'g1-weekend 1', 1),
        (4, '2024-01-12', '2024-01-14', 'g1-weekend 2', 1),
        (5, '2024-01-19', '2024-01-21', 'g1-weekend 3', 1),
        (6, '2024-01-26', '2024-01-28', 'g1-weekend 4', 1),
        --
        -- février
        --
        (7, '2024-02-02', '2024-02-04', 'g1-weekend 1', 1),
        (8, '2024-02-09', '2024-02-11', 'g1-weekend 2', 1),
        (9, '2024-02-16', '2024-02-18', 'g1-weekend 3', 1),
        (10, '2024-02-23', '2024-02-25', 'g1-weekend 4', 1),
        --
        -- GROUPE 2 mars - avril
        --  
        (11, '2024-03-01', '2024-04-30', 'g2', 1),
        --
        -- mars
        --
        (12, '2024-03-01', '2024-03-03', 'g2-weekend 1', 1),
        (13, '2024-03-08', '2024-03-10', 'g2-weekend 2', 1),
        (14, '2024-03-15', '2024-03-17', 'g2-weekend 3', 1),
        (15, '2024-03-22', '2024-03-24', 'g2-weekend 4', 1),
        (16, '2024-03-29', '2024-03-31', 'g2-weekend 5', 1),
        --
        -- avril
        --
        (17, '2024-04-01', '2024-04-01', 'g2-lundi de pâques', 2),
        (18, '2024-04-05', '2024-04-07', 'g2-weekend 1', 2),
        (19, '2024-04-12', '2024-04-14', 'g2-weekend 2', 2),
        (20, '2024-04-19', '2024-04-21', 'g2-weekend 3', 2),
        (21, '2024-04-26', '2024-04-28', 'g2-weekend 4', 2),
        --
        -- GROUPE 3 mai - juin
        --  
        (22, '2024-05-01', '2024-06-30', 'g3', 1),
        --
        -- mai
        --
        (23, '2024-05-01', '2024-05-01', 'g3-fête du travail', 2),
        (24, '2024-05-08', '2024-05-08', 'g3-victoire 1945', 2),
        (25, '2024-05-09', '2024-05-09', 'g3-ascension', 2),
        (26, '2024-05-20', '2024-05-20', 'g3-pentecôte', 2),
        (27, '2024-05-03', '2024-05-05', 'g3-weekend 1', 2),
        (28, '2024-05-10', '2024-05-12', 'g3-weekend 2', 2),
        (29, '2024-05-17', '2024-05-19', 'g3-weekend 3', 2),
        (30, '2024-05-24', '2024-05-26', 'g3-weekend 4', 2),
        (31, '2024-05-31', '2024-05-31', 'g3-weekend 5', 2),
        --
        -- juin
        --
        (32, '2024-06-01', '2024-06-02', 'g3-weekend 1', 2),
        (33, '2024-06-07', '2024-06-09', 'g3-weekend 2', 2),
        (34, '2024-06-14', '2024-06-16', 'g3-weekend 3', 2),
        (35, '2024-06-21', '2024-06-23', 'g3-weekend 4', 2),
        (36, '2024-06-28', '2024-06-30', 'g3-weekend 5', 2),
        --
        -- GROUPE 4 juillet - août
        --  
        (37, '2024-07-01', '2024-08-31', 'g4', 2),
        --
        -- juillet
        --
        (38, '2024-07-14', '2024-07-14', 'g4-fête nationale', 2),
        (39, '2024-07-05', '2024-07-07', 'g4-weekend 1', 2),
        (40, '2024-07-12', '2024-07-14', 'g4-weekend 2', 2),
        (41, '2024-07-19', '2024-07-21', 'g4-weekend 3', 2),
        (42, '2024-07-26', '2024-07-28', 'g4-weekend 4', 2),
        --
        -- août
        --
        (43, '2024-08-15', '2024-08-15', 'g4-assomption', 2),
        (44, '2024-08-02', '2024-08-04', 'g4-weekend 1', 2),
        (45, '2024-08-09', '2024-08-11', 'g4-weekend 2', 2),
        (46, '2024-08-16', '2024-08-18', 'g4-weekend 3', 2),
        (47, '2024-08-23', '2024-08-25', 'g4-weekend 4', 2),
        (48, '2024-08-30', '2024-08-31', 'g4-weekend 5', 2),
        --
        -- GROUPE 5 septembre - octobre
        --  
        (49, '2024-09-01', '2024-10-31', 'g5', 1),
        --
        -- septembre
        --
        (50, '2024-09-01', '2024-09-01', 'g5-weekend 1', 2),
        (51, '2024-09-06', '2024-09-08', 'g5-weekend 2', 2),
        (52, '2024-09-13', '2024-09-15', 'g5-weekend 3', 2),
        (53, '2024-09-20', '2024-09-22', 'g5-weekend 4', 2),
        (54, '2024-09-27', '2024-09-29', 'g5-weekend 5', 2),
        --
        -- octobre
        --
        (55, '2024-10-04', '2024-10-06', 'g5-weekend 1', 1),
        (56, '2024-10-11', '2024-10-13', 'g5-weekend 2', 1),
        (57, '2024-10-18', '2024-10-20', 'g5-weekend 3', 1),
        (58, '2024-10-25', '2024-10-27', 'g5-weekend 4', 1),
        --
        -- GROUPE 6 novembre - décembre
        --  
        (59, '2024-10-01', '2024-12-31', 'g6', 1),
        --
        -- novembre
        --
        (60, '2024-11-01', '2024-11-01', 'g6-toussaint', 2),
        (61, '2024-11-11', '2024-11-11', 'g6-armistice 1918', 2),
        (62, '2024-11-01', '2024-11-03', 'g6-weekend 1', 1),
        (63, '2024-11-08', '2024-11-10', 'g6-weekend 2', 1),
        (64, '2024-11-15', '2024-11-17', 'g6-weekend 3', 1),
        (65, '2024-11-22', '2024-11-24', 'g6-weekend 4', 1),
        (66, '2024-11-29', '2024-11-30', 'g6-weekend 5', 1),
        --
        -- décembre
        --
        (67, '2024-12-25', '2024-12-25', 'g6-jour de noël', 2),
        (68, '2024-12-01', '2024-12-01', 'g6-weekend 1', 1),
        (69, '2024-12-06', '2024-12-08', 'g6-weekend 2', 1),
        (70, '2024-12-13', '2024-12-15', 'g6-weekend 3', 1),
        (71, '2024-12-20', '2024-12-22', 'g6-weekend 4', 1),
        (72, '2024-12-27', '2024-12-29', 'g6-weekend 5', 1);

--
-- REQUETES DE DATES
--

--
-- date en semaine
--

SELECT P.idTypePeriode, TP.libelle
FROM Periode P
JOIN TypePeriode TP ON P.idTypePeriode = TP.id
WHERE '2024-02-01' BETWEEN P.dateDebut AND P.dateFin 
ORDER BY TP.id DESC
LIMIT 1;

--
-- date en weekend
--

SELECT P.idTypePeriode, TP.libelle
FROM Periode P
JOIN TypePeriode TP ON P.idTypePeriode = TP.id
WHERE '2024-04-20' BETWEEN P.dateDebut AND P.dateFin 
ORDER BY TP.id DESC
LIMIT 1;

--
-- date en jour férié
--

SELECT P.idTypePeriode, TP.libelle
FROM Periode P
JOIN TypePeriode TP ON P.idTypePeriode = TP.id
WHERE '2024-12-25' BETWEEN P.dateDebut AND P.dateFin 
ORDER BY TP.id DESC
LIMIT 1;

--
-- INSERTION DES PRIX DES BILLETS
--

INSERT INTO Tarifs (idCatPassager, idTypeBillet, idTypePeriode, prix) 
VALUES  
-- BILLET SIMPLE
        --
        -- 'Adulte 26 ans et plus'
        --
        (1, 1, 1, 17.5),
        (1, 1, 2, 19),
        --
        -- 'De 18 à 25 ans inclus'
        --
        (2, 1, 1, 13.5),
        (2, 1, 2, 13.5),
        --
        -- 'Enfant de 4 à 18 ans'
        --
        (3, 1, 1, 11),
        (3, 1, 2, 11),
        --
        -- 'Enfant moins de 4 ans'
        --
        (4, 1, 1, 0),
        (4, 1, 2, 0),
        --
        -- 'Titulaire carte invalidité ou son accompagnateur'
        --
        (5, 1, 1, 6.2),
        (5, 1, 2, 6.2),
        --
        -- 'chien'
        --
        (6, 1, 1, 3.1),
        (6, 1, 2, 3.1);

INSERT INTO Tarifs (idCatPassager, idTypeBillet, idTypePeriode, prix) 
VALUES  
-- BILLET ABONN2E FR2QUENCE 4
        --
        -- 'Adulte 26 ans et plus'
        --  
        (1, 2, 1, 15.45),
        (1, 2, 2, 15.45),
        --
        -- 'De 18 à 25 ans inclus'
        --  
        (2, 2, 1, 12.85),
        (2, 2, 2, 12.85),
        --
        -- 'Enfant de 4 à 18 ans'
        --  
        (3, 2, 1, 7.7),
        (3, 2, 2, 7.7),
        --
        -- 'Enfant moins de 4 ans'
        --  
        (4, 2, 1, 0),
        (4, 2, 2, 0),
        --
        -- 'Titulaire carte invalidité ou son accompagnateur'
        --  
        (5, 2, 1, 6.2),
        (5, 2, 2, 6.2),
        --
        -- 'chien'
        --  
        (6, 2, 1, 3.1),
        (6, 2, 2, 3.1);

INSERT INTO Tarifs (idCatPassager, idTypeBillet, idTypePeriode, prix) 
VALUES  
-- BILLET ABONN2E FREQUENCE 10
        --
        -- 'Adulte 26 ans et plus'
        --  
        (1, 3, 1, 8.45),
        (1, 3, 2, 8.45),
        --
        -- 'De 18 à 25 ans inclus'
        --  
        (2, 3, 1, 6.7),
        (2, 3, 2, 6.7),
        --
        -- 'Enfant de 4 à 18 ans'
        --  
        (3, 3, 1, 4.25),
        (3, 3, 2, 4.25),
        --
        -- 'Enfant moins de 4 ans'
        --  
        (4, 3, 1, 0),
        (4, 3, 2, 0),
        --
        -- 'Titulaire carte invalidité ou son accompagnateur'
        --  
        (5, 3, 1, 6.2),
        (5, 3, 2, 6.2),
        --
        -- 'chien'
        --  
        (6, 3, 1, 3.1),
        (6, 3, 2, 3.1);

INSERT INTO Tarifs (idCatPassager, idTypeBillet, idTypePeriode, prix) 
VALUES  
-- BILLET ABONN2E ILLIMIT2E
        --
        -- 'Adulte 26 ans et plus'
        --  
        (1, 4, 1, 6.2),
        (1, 4, 2, 6.2),
        --
        -- 'De 18 à 25 ans inclus'
        --  
        (2, 4, 1, 6.2),
        (2, 4, 2, 6.2),
        --
        -- 'Enfant de 4 à 18 ans'
        --  
        (3, 4, 1, 3.7),
        (3, 4, 2, 3.7),
        --
        -- 'Enfant moins de 4 ans'
        --  
        (4, 4, 1, 0),
        (4, 4, 2, 0),
        --
        -- 'Titulaire carte invalidité ou son accompagnateur'
        --  
        (5, 4, 1, 6.2),
        (5, 4, 2, 6.2),
        --
        -- 'chien'
        --  
        (6, 4, 1, 3.1),
        (6, 4, 2, 3.1);

--
-- billet simple, jeune 20 ans, PHF
--

SELECT T.prix, T.idTypePeriode
FROM Tarifs T
JOIN TypePeriode TP ON T.idTypePeriode = TP.id
JOIN Periode P ON P.idTypePeriode = TP.id
WHERE 
	T.idCatPassager = 2 -- Catégorie: De 18 à 25 ans inclus (Jeune de 20 ans)
	AND
	'2024-12-25' BETWEEN P.dateDebut AND P.dateFin -- Type de période: Haute fréquentation
ORDER BY P.id DESC
LIMIT 1;

--
-- Billet fréquence 10 adulte de 30 ans, période normale
--

SELECT T.prix, TP.id
FROM Tarifs T
JOIN TypePeriode TP ON T.idTypePeriode = TP.id
JOIN Periode P ON P.idTypePeriode = TP.id
WHERE 
    T.idCatPassager = 1 -- Catégorie: Adulte 26 ans et plus
    AND
    T.idTypeBillet = 3 -- Type de billet: Fréquence 10
    AND
    '2024-04-15' BETWEEN P.dateDebut AND P.dateFin -- Date choisie
ORDER BY P.id DESC
LIMIT 1;

--
-- requete qui determine le port d'arrivée l'ile de Groix
--

SELECT 
        T.id, 
        P_Depart.nom AS Port_Depart, 
        P_Arrivee.nom AS Port_Arrivee, 
        P_Arrivee.idLieu AS Lieu_Arrivee
FROM Trajet T
JOIN Port P_Depart ON P_Depart.id = T.idPortDepart
JOIN Port P_Arrivee ON P_Arrivee.id = T.idPortArrivee
WHERE P_Arrivee.idLieu = 2

--
-- reservation famille 2 parents, 2 enfants et un chien, billet simple, vers Ile de groix
--

INSERT INTO Reservation (id, nomClient, dateReservation, dateTrajet, idTypeBillet, idTrajet)
VALUES   (1, 'Famille de 5', '2024-04-19', '2024-04-19', 1, 5);

INSERT INTO Choisir (idCatPassager, idReservation, nombre)
VALUES   (1, 1, 2), -- 2 adultes
         (3, 1, 2), -- 2 enfants
         (6, 1, 1); -- 1 chien

--
-- Requete calcul prix total
--

--V1

SELECT SUM(T.prix * CH.nombre) AS prix_total
FROM Choisir CH
JOIN Tarifs T ON T.idCatPassager = CH.idCatPassager
WHERE
	CH.idReservation = 1
	AND
	T.idTypePeriode = 2 
	AND
	T.idTypeBillet = 1;

--V2

SELECT SUM(T.prix * CH.nombre) AS prix_total
FROM Reservation R
JOIN Choisir CH ON CH.idReservation = R.id
JOIN Tarifs T ON T.idCatPassager = CH.idCatPassager
JOIN TypeBillet TB ON TB.id = R.idTypeBillet
WHERE T.idTypePeriode = (
	SELECT P.idTypePeriode
	FROM Reservation R
	JOIN Periode P ON R.dateReservation BETWEEN P.dateDebut AND P.dateFin
	ORDER BY P.id DESC
	LIMIT 1
)
AND T.idTypeBillet = R.idTypeBillet
AND R.id = 1 -- seul paramètre à manipuler