-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 13 mars 2024 à 17:40
-- Version du serveur : 8.0.31
-- Version de PHP : 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `cuisinecolmar`
--

-- --------------------------------------------------------

--
-- Structure de la table `atelier_cuisine`
--

DROP TABLE IF EXISTS `atelier_cuisine`;
CREATE TABLE IF NOT EXISTS `atelier_cuisine` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `telcuisine` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `idCuisinierResponsable` smallint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idx_numcuisinier` (`idCuisinierResponsable`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `atelier_cuisine`
--

INSERT INTO `atelier_cuisine` (`id`, `telcuisine`, `idCuisinierResponsable`) VALUES
(1, '115', 2),
(2, '118', 5),
(3, '120', 6);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `libelle`) VALUES
(1, 'soupes'),
(2, 'salades composées'),
(3, 'entrées'),
(4, 'légumineuses'),
(5, 'légumes'),
(6, 'céréales'),
(7, 'pâtés, soufflés, gratins, beignets'),
(8, 'plats de résistance'),
(9, 'pâtisserie'),
(10, 'desserts et entremets'),
(11, 'fruits');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `prenom` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `adresseRue` varchar(30) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `cp` int DEFAULT NULL,
  `ville` varchar(20) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`id`, `nom`, `prenom`, `adresseRue`, `cp`, `ville`) VALUES
(1, 'ALLANIC', 'Etienne', '4 Rue des Papillons', 35000, 'RENNES'),
(2, 'DOUMER', 'Jeanne', '15 Place de la Liberté', 35000, 'RENNES'),
(3, 'GANDIER', 'Raoul', '23 Quai Chateaubriand', 35000, 'LIFFRE'),
(4, 'TIMON', 'Marie', '38 Rue des Tulipes', 35700, 'RENNES'),
(5, 'NOVEN', 'Jacques', '41 Quai Surcouf', 35000, 'RENNES'),
(6, 'MOTE', 'Julien', '9, allée de Canain', 35340, 'LIFFRE'),
(7, 'REOUL', 'Maurice', '18, qui Châteaubriand', 35000, 'RENNES');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datecom` datetime DEFAULT NULL,
  `datelivraison` datetime DEFAULT NULL,
  `idClient` smallint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idClient` (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `datecom`, `datelivraison`, `idClient`) VALUES
(1, '2024-03-15 00:00:00', '2024-03-15 00:00:00', 1),
(2, '2024-03-18 00:00:00', '2024-03-20 00:00:00', 5),
(3, '2024-03-15 00:00:00', '2024-03-16 00:00:00', 4),
(4, '2024-03-15 00:00:00', '2024-03-15 00:00:00', 2),
(5, '2024-03-06 00:00:00', '2024-03-16 00:00:00', 6),
(6, '2024-03-12 00:00:00', '2024-03-15 00:00:00', 7);

-- --------------------------------------------------------

--
-- Structure de la table `compose`
--

DROP TABLE IF EXISTS `compose`;
CREATE TABLE IF NOT EXISTS `compose` (
  `idMenu` int NOT NULL,
  `idPlat` int NOT NULL,
  PRIMARY KEY (`idMenu`,`idPlat`),
  KEY `idPlat` (`idPlat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `compose`
--

INSERT INTO `compose` (`idMenu`, `idPlat`) VALUES
(6, 1),
(8, 1),
(9, 2),
(5, 4),
(4, 5),
(8, 5),
(5, 6),
(7, 7),
(12, 7),
(15, 8),
(9, 9),
(2, 10),
(7, 10),
(12, 10),
(1, 11),
(13, 11),
(3, 12),
(3, 13),
(13, 13),
(14, 14),
(6, 15),
(2, 16),
(1, 17),
(8, 17),
(15, 17),
(4, 18),
(15, 18),
(13, 19),
(11, 20),
(7, 22),
(12, 22),
(6, 23),
(9, 23),
(10, 26),
(5, 29),
(13, 29),
(14, 30),
(3, 31),
(4, 32),
(10, 32),
(10, 33),
(14, 33),
(6, 34),
(13, 34),
(3, 36),
(7, 36),
(11, 39),
(8, 40),
(7, 41),
(2, 42),
(5, 43),
(1, 45),
(9, 47),
(11, 48);

-- --------------------------------------------------------

--
-- Structure de la table `cuisinier`
--

DROP TABLE IF EXISTS `cuisinier`;
CREATE TABLE IF NOT EXISTS `cuisinier` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `dateEmb` datetime DEFAULT NULL,
  `idCuisine` smallint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idCuisine` (`idCuisine`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `cuisinier`
--

INSERT INTO `cuisinier` (`id`, `nom`, `dateEmb`, `idCuisine`) VALUES
(1, 'DURAND', '2000-10-15 00:00:00', 2),
(2, 'GENARD', '2022-01-01 00:00:00', 1),
(3, 'NICOLET', '2012-01-01 00:00:00', 3),
(4, 'MENARDEAU', '2013-05-18 00:00:00', 1),
(5, 'JASMIN', '2023-08-15 00:00:00', 2),
(6, 'DUBLIER', '2022-01-01 00:00:00', 3),
(7, 'PINTEAU', '2024-01-01 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `ligne_commande`
--

DROP TABLE IF EXISTS `ligne_commande`;
CREATE TABLE IF NOT EXISTS `ligne_commande` (
  `idCommande` int NOT NULL,
  `idMenu` int NOT NULL,
  `qtecom` int DEFAULT NULL,
  PRIMARY KEY (`idCommande`,`idMenu`),
  KEY `idMenu` (`idMenu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `ligne_commande`
--

INSERT INTO `ligne_commande` (`idCommande`, `idMenu`, `qtecom`) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 2, 7),
(2, 6, 4),
(3, 6, 18),
(3, 7, 12),
(3, 9, 10),
(4, 1, 5),
(4, 6, 3),
(4, 8, 4),
(5, 3, 10),
(5, 4, 12),
(6, 1, 8),
(6, 10, 5),
(6, 12, 3);

-- --------------------------------------------------------

--
-- Structure de la table `menu`
--

DROP TABLE IF EXISTS `menu`;
CREATE TABLE IF NOT EXISTS `menu` (
  `id` int NOT NULL AUTO_INCREMENT,
  `prixmenu` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `menu`
--

INSERT INTO `menu` (`id`, `prixmenu`) VALUES
(1, 15),
(2, 18),
(3, 25),
(4, 19),
(5, 24),
(6, 28),
(7, 36),
(8, 29),
(9, 27),
(10, 12),
(11, 15),
(12, 9),
(13, 40),
(14, 25),
(15, 18);

-- --------------------------------------------------------

--
-- Structure de la table `plat`
--

DROP TABLE IF EXISTS `plat`;
CREATE TABLE IF NOT EXISTS `plat` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomplat` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `idCategorie` smallint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idCategorie` (`idCategorie`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `plat`
--

INSERT INTO `plat` (`id`, `nomplat`, `idCategorie`) VALUES
(1, 'apple crumble', 10),
(2, 'artichauts ailloli', 3),
(3, 'avocat vinaigrette', 3),
(4, 'azukis nature', 4),
(5, 'beignets d\'aubergines', 7),
(6, 'beignets de courgettes', 7),
(7, 'biscuits au chocolat', 9),
(8, 'bortsch', 1),
(9, 'brocolis fleurs à la provençale', 5),
(10, 'carottes râpées aux noisettes', 2),
(11, 'cassoulet végétarien', 8),
(12, 'caviar d\'aubergines', 3),
(13, 'compote d\'abricots', 11),
(14, 'coulis de figues à la mangue', 10),
(15, 'courgettes pânées', 8),
(16, 'crème à l\'orange', 10),
(17, 'crème de tofu aux pêches', 10),
(18, 'croquettes de riz aux noix', 8),
(19, 'crudités à la japonaise', 2),
(20, 'crudités selon saison', 2),
(21, 'endives au citron', 5),
(22, 'flan aux poireaux', 7),
(23, 'fraises en salade', 11),
(24, 'galettes d\'avoine', 8),
(25, 'haricots de soja aux légumes', 4),
(26, 'humos', 3),
(27, 'kasha', 6),
(28, 'millet à l\'indienne', 6),
(29, 'mousse au citron', 10),
(30, 'pâté végétal aux champignons', 7),
(31, 'poireaux à la flamande', 5),
(32, 'poires au sirop', 11),
(33, 'purée de céléri à la coriandre', 5),
(34, 'rouleaux de printemps', 3),
(35, 'sablé à l\'orange', 9),
(36, 'salade de chou et de raisin', 2),
(37, 'salade de cresson et de betteraves', 2),
(38, 'salade de mangues et de pêches', 11),
(39, 'sarrasin aux carottes', 6),
(40, 'saucisses de riz', 8),
(41, 'seitan', 8),
(42, 'soufflé aux asperges', 7),
(43, 'soupe à l\'avocat', 1),
(44, 'soupe au persil', 1),
(45, 'soupe aux asperges et aux oeufs', 1),
(46, 'tarte aux pruneaux', 9),
(47, 'tofu burger', 8),
(48, 'tourte aux pommes et aux raisins', 9);

-- --------------------------------------------------------

--
-- Structure de la table `preparer`
--

DROP TABLE IF EXISTS `preparer`;
CREATE TABLE IF NOT EXISTS `preparer` (
  `idCuisine` smallint NOT NULL,
  `idPlat` int NOT NULL,
  `datePreparation` datetime NOT NULL,
  `nombrePlats` smallint DEFAULT NULL,
  PRIMARY KEY (`idCuisine`,`idPlat`,`datePreparation`),
  KEY `idPlat` (`idPlat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `preparer`
--

INSERT INTO `preparer` (`idCuisine`, `idPlat`, `datePreparation`, `nombrePlats`) VALUES
(1, 1, '2024-03-16 00:00:00', 18),
(1, 1, '2024-03-20 00:00:00', 4),
(1, 2, '2024-03-16 00:00:00', 10),
(1, 7, '2024-03-15 00:00:00', 3),
(1, 10, '2024-03-15 00:00:00', 3),
(1, 13, '2024-03-16 00:00:00', 10),
(1, 15, '2024-03-15 00:00:00', 3),
(1, 15, '2024-03-20 00:00:00', 4),
(1, 22, '2024-03-16 00:00:00', 12),
(1, 23, '2024-03-15 00:00:00', 3),
(1, 23, '2024-03-16 00:00:00', 28),
(1, 33, '2024-03-15 00:00:00', 5),
(1, 34, '2024-03-16 00:00:00', 18),
(1, 40, '2024-03-15 00:00:00', 4),
(2, 1, '2024-03-15 00:00:00', 7),
(2, 5, '2024-03-15 00:00:00', 4),
(2, 5, '2024-03-16 00:00:00', 12),
(2, 9, '2024-03-16 00:00:00', 10),
(2, 12, '2024-03-16 00:00:00', 10),
(2, 15, '2024-03-16 00:00:00', 18),
(2, 16, '2024-03-15 00:00:00', 1),
(2, 18, '2024-03-16 00:00:00', 12),
(2, 22, '2024-03-15 00:00:00', 3),
(2, 26, '2024-03-15 00:00:00', 5),
(2, 32, '2024-03-15 00:00:00', 5),
(2, 32, '2024-03-16 00:00:00', 12),
(2, 34, '2024-03-15 00:00:00', 3),
(2, 34, '2024-03-20 00:00:00', 4),
(2, 36, '2024-03-16 00:00:00', 22),
(2, 42, '2024-03-20 00:00:00', 7),
(2, 47, '2024-03-16 00:00:00', 10),
(3, 7, '2024-03-16 00:00:00', 12),
(3, 10, '2024-03-15 00:00:00', 1),
(3, 10, '2024-03-16 00:00:00', 12),
(3, 10, '2024-03-20 00:00:00', 7),
(3, 11, '2024-03-15 00:00:00', 15),
(3, 16, '2024-03-20 00:00:00', 7),
(3, 17, '2024-03-15 00:00:00', 19),
(3, 23, '2024-03-20 00:00:00', 4),
(3, 31, '2024-03-16 00:00:00', 10),
(3, 41, '2024-03-16 00:00:00', 12),
(3, 42, '2024-03-15 00:00:00', 1),
(3, 45, '2024-03-15 00:00:00', 15);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `atelier_cuisine`
--
ALTER TABLE `atelier_cuisine`
  ADD CONSTRAINT `atelier_cuisine_ibfk_1` FOREIGN KEY (`idCuisinierResponsable`) REFERENCES `cuisinier` (`id`);

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`idClient`) REFERENCES `client` (`id`);

--
-- Contraintes pour la table `compose`
--
ALTER TABLE `compose`
  ADD CONSTRAINT `compose_ibfk_1` FOREIGN KEY (`idMenu`) REFERENCES `menu` (`id`),
  ADD CONSTRAINT `compose_ibfk_2` FOREIGN KEY (`idPlat`) REFERENCES `plat` (`id`);

--
-- Contraintes pour la table `cuisinier`
--
ALTER TABLE `cuisinier`
  ADD CONSTRAINT `cuisinier_ibfk_1` FOREIGN KEY (`idCuisine`) REFERENCES `atelier_cuisine` (`id`);

--
-- Contraintes pour la table `ligne_commande`
--
ALTER TABLE `ligne_commande`
  ADD CONSTRAINT `ligne_commande_ibfk_1` FOREIGN KEY (`idMenu`) REFERENCES `menu` (`id`),
  ADD CONSTRAINT `ligne_commande_ibfk_2` FOREIGN KEY (`idCommande`) REFERENCES `commande` (`id`);

--
-- Contraintes pour la table `plat`
--
ALTER TABLE `plat`
  ADD CONSTRAINT `plat_ibfk_1` FOREIGN KEY (`idCategorie`) REFERENCES `categorie` (`id`);

--
-- Contraintes pour la table `preparer`
--
ALTER TABLE `preparer`
  ADD CONSTRAINT `preparer_ibfk_1` FOREIGN KEY (`idCuisine`) REFERENCES `atelier_cuisine` (`id`),
  ADD CONSTRAINT `preparer_ibfk_2` FOREIGN KEY (`idPlat`) REFERENCES `plat` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
