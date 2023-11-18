CREATE DATABASE  IF NOT EXISTS `tp_abm` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `tp_abm`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: tp_abm
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.28-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cabecerafactura`
--

DROP TABLE IF EXISTS `cabecerafactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cabecerafactura` (
  `idCabeceraFactura` int(11) NOT NULL AUTO_INCREMENT,
  `numeroFactura` varchar(10) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `idTipoIva` int(11) NOT NULL,
  `montoTotalSinIva` double NOT NULL,
  `montoTotalConIva` double NOT NULL,
  `ivaPorcentaje` varchar(45) NOT NULL,
  `montoIva` varchar(45) NOT NULL,
  PRIMARY KEY (`idCabeceraFactura`),
  KEY `fk_cabecera_producto_idx` (`idCliente`),
  KEY `fk_cabecera_idtipoiva_idx` (`idTipoIva`),
  CONSTRAINT `fk_cabecera_idtipoiva` FOREIGN KEY (`idTipoIva`) REFERENCES `tipoiva` (`idtipoIVA`),
  CONSTRAINT `fk_cabecera_producto` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabecerafactura`
--

LOCK TABLES `cabecerafactura` WRITE;
/*!40000 ALTER TABLE `cabecerafactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `cabecerafactura` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-12 18:23:45
