-- 1. La base de données 

-- Suppression de la base de données "db_gest_commandes" (si elle existe)
DROP DATABASE IF EXISTS db_gest_commandes;
-- Création de la base de données "db_gest_commandes"
CREATE DATABASE db_gest_commandes;
-- Sélection de la base de données "db_gest_commandes" (afin de travailler sur cette BDD)
USE db_gest_commandes;

-- 2. Les tables

-- Création de la table "Client"
-- N.B.: on remarque que tous les champs sont requis/obligatoires (NOT NULL)
CREATE TABLE Client(=
	Id INTEGER auto_increment,
	Civilite VARCHAR(3) NOT NULL,
	Prenom VARCHAR(30) NOT NULL,
	Nom VARCHAR(30) NOT NULL,
	Adresse VARCHAR(80) NOT NULL,
	CodePostal VARCHAR(5) NOT NULL,
	Ville VARCHAR(30) NOT NULL,
	Pays VARCHAR(30) NOT NULL,
	PRIMARY KEY (Id)
) ENGINE = InnoDB;
-- Création de la table "Commande"
-- N.B.: on constate, très normalement, que la clef étrangère IdClient (commentée) est de 
-- même type que le champ "Client(Id)" auquelle elle fait référence.
CREATE TABLE Commande(
	Id INTEGER auto_increment,
	IdClient INTEGER NOT NULL,
	Emission DATE NOT NULL,
	PRIMARY KEY (Id)
	-- FOREIGN KEY (IdClient) REFERENCES Client(Id)
) ENGINE = InnoDB;
-- Création de la table "Produit"
CREATE TABLE Produit(
	Code VARCHAR(7),
	Libelle VARCHAR(80) NOT NULL,
	Prix DECIMAL(6,2) NOT NULL, -- 6 chiffres, dont 2 après la virgule (-9999.99 à 9999.99)
	PRIMARY KEY (Code)
) ENGINE = InnoDB;
-- Création de la table "Ligne" (les lignes de la commande)
CREATE TABLE Ligne(
	Id INTEGER auto_increment,
	IdCommande INTEGER NOT NULL,
	CodeProduit VARCHAR(7) NOT Null,
	Quantite INTEGER NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (IdCommande) REFERENCES Commande(Id),
	FOREIGN KEY (CodeProduit) REFERENCES Produit(Code)
) ENGINE = InnoDB;
-- Ajout du champ "Email" à la table "Client"
-- N.B.: on remarque l'Email n'est pas obligatoire. En effet, on n'a pas précisé "NOT NULL"
ALTER TABLE Client ADD Email VARCHAR(60);
-- Ajout du champ "Description" à la table "Produit"
-- N.B.: VARCHAR est limité à 255 car. (VARCHAR(255)), on choisit d'utiliser le type MySQL TEXT (pour que la description puisse excéder 255 car.)
ALTER TABLE Produit ADD Description TEXT;
-- Ajout de la clef étrangère manquante dans la table "Commande"
ALTER TABLE Commande ADD FOREIGN KEY (IdClient) REFERENCES Client(Id);
-- Suppression du champ "Pays" de la table "Client"
ALTER TABLE Client DROP Pays;

-- 3. Les données

-- Insertion d'enregistrements dans la table "Client"
INSERT INTO Client(Id, Civilite, Prenom, Nom, Adresse, CodePostal, Ville, Email)
VALUES
	(1, 'M.', 'Jean-Claude', 'DUS', '28 Rue de Bronzés', '78000', 'Rambouillet', NULL),
	(2, 'M.', 'Seigneur', 'ARAGORN', '37 Avenue de la Terre du Milieu', '75000', 'PANAME', 'aragorn@outlook.fr'),
	(3, 'M.', 'Agent', 'SMITH', '1 Boulevard de la Matrice', '45000', 'ORLEANS', 'neo@gmail.com'),
	(4, 'M.', 'Philippe', 'Pozo di Borgo', '2 Rue des intouchables', '78000', 'TRAPPES', NULL),
	(5, 'M.', 'Daniel', 'Radcliffe', '7 Rue des Avada Kedavra', '45600', 'ST JEAN LE BLANC', 'wingardium@leviosa.com');
-- Insertion d'enregistrements dans la table "Produit"
INSERT INTO Produit(Code, Libelle, Description, Prix)
VALUES
	('PCDEOUF', 'Ordinateur portable "Alien Ware" n°1', NULL, 2199.90),
	('PCCHIN1', 'Ordinateur portable "Acer" n°1', NULL, 500.00),
	('PCCHIN2', 'Ordinateur portable "Acer" n°2', NULL, 750.00),
	('PCGOOD', 'Ordinateur portable "Asus" n°1', NULL, 799.90),
	('PCDEL1', 'Ordinateur portable "DEL" n°1', NULL, 1190.50),
	('PCDEL2', 'Ordinateur portable "DEL" n°2', NULL, 975.00),
	('PCDEL3', 'Ordinateur portable "DEL" n°3', NULL, 819.99),
	('SOURIS1', 'Souris filaire Logitech', NULL, 20.00),
	('SOURIS2', 'Souris sans fil Logitech', NULL, 25.00),
	('SOURIS3', 'Souris gamer Nacon', NULL, 39.90),
	('SOURIS4', 'Souris gamer Asus ROG', NULL, 125.00),
	('HTCONE', 'Téléphone mobile HTC ONE', NULL, 179.5),
	('ALPHA', 'Téléphone mobile Samsung Galaxy Alpha', NULL, 199.99),
	('IMPR1', 'Imprimante HP Photosmart', NULL, 169.00),
	('IMPR2', 'Imprimante HP Deskjet', NULL, 90.00),
	('CART1', 'Pack de cartouches encre HP 364 XL', NULL, 59.99),
	('CART2', 'Cartouche encre HP 364 Noire', NULL, 19.99),
	('CART3', 'Cartouche encre HP 364 Cyan', NULL, 19.99),
	('CART4', 'Cartouche encre HP 364 Magenta', NULL, 19.99),
	('CART5', 'Cartouche encre HP 364 Jaune', NULL, 19.99);
-- Insertion d'enregistrements dans la table "Commande"
INSERT INTO Commande(Id, IdClient, Emission)
VALUES
	(1, 1, '2016-12-15'),
	(2, 1, '2016-12-30'),
	(3, 1, '2017-01-03'),
	(4, 2, '2017-01-07'),
	(5, 3, '2017-01-12'),
	(6, 5, '2017-01-17');
-- Insertion d'enregistrements dans la table "Ligne"
INSERT INTO Ligne(IdCommande, CodeProduit, Quantite)
VALUES
	-- Lignes de la "Commande" n°1
	(1, 'PCDEOUF', 1),
	(1, 'IMPR1', 1),
	(1, 'CART1', 3),
	-- Lignes de la "Commande" n°2,
	(2, 'ALPHA', 1),
	-- Lignes de la "Commande" n°3
	(3, 'PCCHIN2', 1),
	(3, 'SOURIS2', 1),
	-- Lignes de la "Commande" n°4
	(4, 'CART1', 2),
	(4, 'CART2', 3),
	-- Lignes de la "Commande" n°5
	(5, 'IMPR2', 1),
	(5, 'CART1', 1),
	-- Lignes de la "Commande" n°6
	(6, 'PCGOOD', 1);

