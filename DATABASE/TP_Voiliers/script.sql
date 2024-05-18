--
-- INIT DATABASE
--

CREATE TABLE CLIENT (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50) NOT NULL,
    adresse VARCHAR(50) NOT NULL,
    codePostal VARCHAR(50) NOT NULL,
    ville VARCHAR(50) NOT NULL
);

--
-- SUCCURSALE
--

CREATE TABLE SUCCURSALE (
    id INT AUTO_INCREMENT PRIMARY KEY,
    base VARCHAR(50) NOT NULL,
    nomDirecteur VARCHAR(50) NOT NULL
);

--
-- VOILIER
--

CREATE TABLE VOILIER (
    id INT AUTO_INCREMENT PRIMARY KEY,
    type VARCHAR(50),
    tarif FLOAT NOT NULL,
    etat INT NOT NULL CHECK (etat BETWEEN 1 AND 6),
    idSuccursale INT NOT NULL,
    FOREIGN KEY (idSuccursale) REFERENCES SUCCURSALE (id)
);

--
-- RESERVATION
--

CREATE TABLE RESERVATION (
    id INT AUTO_INCREMENT PRIMARY KEY,
    JourDebut INT NOT NULL CHECK (JourDebut BETWEEN 1 AND 365),
    JourFin INT NOT NULL CHECK (JourFin BETWEEN 1 AND 365),
    idClient INT NOT NULL,
    idVoilier INT NOT NULL,
    FOREIGN KEY (idClient) REFERENCES CLIENT (id),
    FOREIGN KEY (idVoilier) REFERENCES VOILIER (id)
);

--
-- RECORD INSERTION
--

--
-- SUCCURSALE
--

INSERT INTO SUCCURSALE (id, base, nomDirecteur)
VALUES  (1, "Arcachon",  "Germain"),
        (2, "Marseille", "Martin"),
        (3, "Sète",      "Muller");
        
--
-- VOILIER
--

INSERT INTO VOILIER (id, tarif, etat, idSuccursale)
VALUES	(1, 300,  4, 1),
        	(2, 800,  3, 3),
        	(3, 250,  5, 3),
        	(4, 1000, 2, 3),
        	(5, 1760, 1, 2),
        	(6, 1045, 2, 2),
        	(7, 550,  3, 1);

--
-- CLIENT
--

INSERT INTO CLIENT (id, nom, adresse, codePostal, ville)
VALUES  (1, "Dupont",  "12, rue des abeilles", "68200", "Mulhouse"),
        (2, "Muller",  "225, grand rue",       "68500", "Guebwiller"),
        (3, "Simon",   "56, rue du port",      "34200", "Sète"),
        (4, "Gilbert", "La canebière",         "13000", "Marseille"),
        (5, "Dutrain", "26, rue du bassin",    "33120", "Arcachon");

--
-- RESERVATION
--

INSERT INTO RESERVATION (id, JourDebut, JourFin, idVoilier, idClient)
VALUES  (1, 67, 89, 2, 2),
        (2, 12, 34, 5, 2),
        (3, 56, 67, 3, 4),
        (4, 68, 78, 5, 4),
        (5, 12, 23, 6, 5),
        (6, 78, 89, 4, 1),
        (7, 45, 46, 2, 3),
        (8, 43, 54, 7, 4),
        (9, 24, 54, 4, 1);

--
-- Requetes test CHECK
--

INSERT INTO VOILIER (id, tarif, etat, idSuccursale)
VALUES	(8, 550, 10, 1);

INSERT INTO RESERVATION (id, JourDebut, JourFin, idVoilier, idClient)
VALUES	(10, -100, 500, 4, 1);
