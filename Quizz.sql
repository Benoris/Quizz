-- phpMyAdmin SQL Dump
-- version 4.6.3
-- https://www.phpmyadmin.net/
--
-- Client :  localhost
-- Généré le :  Mer 05 Octobre 2016 à 15:56
-- Version du serveur :  5.5.52-MariaDB
-- Version de PHP :  5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `Quizz`
--

-- --------------------------------------------------------

--
-- Structure de la table `have`
--

CREATE TABLE `have` (
  `idQuestion` int(11) NOT NULL,
  `idAnswer` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `tanswer`
--

CREATE TABLE `tanswer` (
  `idAnswer` int(11) NOT NULL,
  `Answer` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `tquestion`
--

CREATE TABLE `tquestion` (
  `idQuestion` int(11) NOT NULL,
  `TextQuestion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `tusers`
--

CREATE TABLE `tusers` (
  `idUser` int(11) NOT NULL,
  `NameUser` text,
  `Score` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `have`
--
ALTER TABLE `have`
  ADD PRIMARY KEY (`idQuestion`,`idAnswer`),
  ADD KEY `FK_Have_idAnswer` (`idAnswer`);

--
-- Index pour la table `tanswer`
--
ALTER TABLE `tanswer`
  ADD PRIMARY KEY (`idAnswer`);

--
-- Index pour la table `tquestion`
--
ALTER TABLE `tquestion`
  ADD PRIMARY KEY (`idQuestion`);

--
-- Index pour la table `tusers`
--
ALTER TABLE `tusers`
  ADD PRIMARY KEY (`idUser`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `tanswer`
--
ALTER TABLE `tanswer`
  MODIFY `idAnswer` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `tquestion`
--
ALTER TABLE `tquestion`
  MODIFY `idQuestion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `tusers`
--
ALTER TABLE `tusers`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT;
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
