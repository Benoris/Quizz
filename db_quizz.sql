-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 28 Septembre 2016 à 13:13
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `db_quizz`
--

-- --------------------------------------------------------

--
-- Structure de la table `have`
--

CREATE TABLE IF NOT EXISTS `have` (
  `idQuestion` int(11) NOT NULL,
  `idAnswer` int(11) NOT NULL,
  PRIMARY KEY (`idQuestion`,`idAnswer`),
  KEY `FK_Have_idAnswer` (`idAnswer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `tanswer`
--

CREATE TABLE IF NOT EXISTS `tanswer` (
  `idAnswer` int(11) NOT NULL AUTO_INCREMENT,
  `Answer` text,
  PRIMARY KEY (`idAnswer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `tquestion`
--

CREATE TABLE IF NOT EXISTS `tquestion` (
  `idQuestion` int(11) NOT NULL AUTO_INCREMENT,
  `TextQuestion` text,
  PRIMARY KEY (`idQuestion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `tusers`
--

CREATE TABLE IF NOT EXISTS `tusers` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `NameUser` text,
  `Score` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `have`
--
ALTER TABLE `have`
  ADD CONSTRAINT `FK_Have_idAnswer` FOREIGN KEY (`idAnswer`) REFERENCES `tanswer` (`idAnswer`),
  ADD CONSTRAINT `FK_Have_idQuestion` FOREIGN KEY (`idQuestion`) REFERENCES `tquestion` (`idQuestion`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
