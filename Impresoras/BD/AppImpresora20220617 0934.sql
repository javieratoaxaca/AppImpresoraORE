-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.54-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema impresora
--

CREATE DATABASE IF NOT EXISTS impresora;
USE impresora;

--
-- Definition of table `accesoriosequipo`
--

DROP TABLE IF EXISTS `accesoriosequipo`;
CREATE TABLE `accesoriosequipo` (
  `idAccesorioEquipo` int(5) NOT NULL,
  `nombreAccesorio` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `statusAccesorio` bit(1) DEFAULT NULL,
  PRIMARY KEY (`idAccesorioEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `accesoriosequipo`
--

/*!40000 ALTER TABLE `accesoriosequipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `accesoriosequipo` ENABLE KEYS */;


--
-- Definition of table `detalleasignacion`
--

DROP TABLE IF EXISTS `detalleasignacion`;
CREATE TABLE `detalleasignacion` (
  `idDetalleAsignacion` int(5) NOT NULL,
  `idInventarioEquipo` int(5) NOT NULL,
  `idAccesorioEquipo` int(5) NOT NULL,
  `idRegion` int(5) NOT NULL,
  `fechaAsignacion` date DEFAULT NULL,
  PRIMARY KEY (`idDetalleAsignacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `detalleasignacion`
--

/*!40000 ALTER TABLE `detalleasignacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleasignacion` ENABLE KEYS */;


--
-- Definition of table `inventarioequipo`
--

DROP TABLE IF EXISTS `inventarioequipo`;
CREATE TABLE `inventarioequipo` (
  `idInventarioEquipo` int(5) NOT NULL,
  `idAccesorioEquipo` int(5) NOT NULL,
  `numEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nombreEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `serieEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `marcaEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `modeloEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `statusEquipo` bit(1) DEFAULT NULL,
  PRIMARY KEY (`idInventarioEquipo`),
  KEY `EquipoAccesorio` (`idAccesorioEquipo`),
  CONSTRAINT `EquipoAccesorio` FOREIGN KEY (`idAccesorioEquipo`) REFERENCES `accesoriosequipo` (`idAccesorioEquipo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `inventarioequipo`
--

/*!40000 ALTER TABLE `inventarioequipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventarioequipo` ENABLE KEYS */;


--
-- Definition of table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE `region` (
  `idRegion` int(5) NOT NULL,
  `numRegion` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nombreRegion` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `responsableRegion` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cupo` int(6) DEFAULT NULL,
  PRIMARY KEY (`idRegion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `region`
--

/*!40000 ALTER TABLE `region` DISABLE KEYS */;
/*!40000 ALTER TABLE `region` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
