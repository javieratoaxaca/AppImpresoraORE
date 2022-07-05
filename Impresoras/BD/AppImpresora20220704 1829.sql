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
  `idAccesorioEquipo` int(5) NOT NULL AUTO_INCREMENT,
  `nombreAccesorio` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `statusAccesorio` bit(1) DEFAULT NULL,
  PRIMARY KEY (`idAccesorioEquipo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `accesoriosequipo`
--

/*!40000 ALTER TABLE `accesoriosequipo` DISABLE KEYS */;
INSERT INTO `accesoriosequipo` (`idAccesorioEquipo`,`nombreAccesorio`,`statusAccesorio`) VALUES 
 (1,'CABLE ENERGIA',0x01),
 (2,'CABLE USB',0x01),
 (3,'CD INSTALL',0x01);
/*!40000 ALTER TABLE `accesoriosequipo` ENABLE KEYS */;


--
-- Definition of table `detalleasignacion`
--

DROP TABLE IF EXISTS `detalleasignacion`;
CREATE TABLE `detalleasignacion` (
  `idDetalleAsignacion` int(5) NOT NULL AUTO_INCREMENT,
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
  `idInventarioEquipo` int(5) NOT NULL AUTO_INCREMENT,
  `numEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nombreEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `serieEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `marcaEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `modeloEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `obsEquipo` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `statusEquipo` bit(1) DEFAULT NULL,
  `fechaRegistro` date DEFAULT NULL,
  `imgQr` longblob,
  PRIMARY KEY (`idInventarioEquipo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `inventarioequipo`
--

/*!40000 ALTER TABLE `inventarioequipo` DISABLE KEYS */;
INSERT INTO `inventarioequipo` (`idInventarioEquipo`,`numEquipo`,`nombreEquipo`,`serieEquipo`,`marcaEquipo`,`modeloEquipo`,`obsEquipo`,`statusEquipo`,`fechaRegistro`,`imgQr`) VALUES 
 (1,'222','1212','123123','12312','123123','dfdfsdf',0x01,'2022-06-30',NULL),
 (2,'asdasd','asdasd','asdaffdg','dfgdfghgh','qweqwe','gsdgfefasfasd',0x01,'2022-07-01',NULL),
 (3,'qweqweqw','adsasdasd','asdasdasdsd','asdasdasd','asdasdasd','asdasdfasfasdfasdf\n Siguientes Accesorios: CABLE ENERGIA,\nCABLE USB,\nCD INSTALL',0x01,'2022-07-01',NULL),
 (4,'1','2','3','4','5','esto es una prueba \n Siguientes Accesorios: CABLE ENERGIA,\nCABLE USB,\n',0x01,'2022-07-01',NULL),
 (5,'2','3','4','5','6','otra vez\n Siguientes Accesorios: CABLE ENERGIA,\nCABLE USB,\nCD INSTALL',0x01,'2022-07-01',NULL);
/*!40000 ALTER TABLE `inventarioequipo` ENABLE KEYS */;


--
-- Definition of table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE `region` (
  `idRegion` int(5) NOT NULL AUTO_INCREMENT,
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


--
-- Definition of procedure `insertAccesorio`
--

DROP PROCEDURE IF EXISTS `insertAccesorio`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertAccesorio`( in nameAccesorio VARCHAR(255), in estadoAccesorio BIGINT(1))
BEGIN
  #Routine body goes here...
	INSERT INTO accesoriosequipo(nombreAccesorio,statusAccesorio)
	VALUES (nameAccesorio,estadoAccesorio);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `insertEquipo`
--

DROP PROCEDURE IF EXISTS `insertEquipo`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertEquipo`( in numeEquipo VARCHAR(255), 
																														in nameEquipo VARCHAR(255), 
																														in seriEquipo VARCHAR(255), 
																														in marcEquipo VARCHAR(255),
																														in modelEquipo VARCHAR(255),
																														in statuEquipo BIGINT(1))
BEGIN
  #Routine body goes here...
	INSERT INTO inventarioequipo(numEquipo, nombreEquipo , serieEquipo , marcaEquipo, modeloEquipo ,statusEquipo )
	VALUES ( numeEquipo,nameEquipo,seriEquipo, marcEquipo, modelEquipo,statuEquipo);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
