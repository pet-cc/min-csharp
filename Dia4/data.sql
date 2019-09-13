-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: jornal
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `autor`
--

LOCK TABLES `autor` WRITE;
/*!40000 ALTER TABLE `autor` DISABLE KEYS */;
INSERT INTO `autor` VALUES (1,'José Brum',43,1),(2,'Pedro Bento Santos',23,5),(3,'Carla Raniery',67,8),(4,'Giovana Librelotto',32,2),(5,'Andre Charão',25,1),(6,'Augusto Gai',56,NULL);
/*!40000 ALTER TABLE `autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Politica'),(2,'Esportes'),(3,'Policial'),(4,'Economia'),(5,'Famosos'),(6,'Culinária'),(7,'Classificados'),(8,'Cultura');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `cidade`
--

LOCK TABLES `cidade` WRITE;
/*!40000 ALTER TABLE `cidade` DISABLE KEYS */;
INSERT INTO `cidade` VALUES (1,'Santa Maria','RS'),(2,'Cruz Alta','RS'),(3,'Santiago','RS'),(4,'Alegrete','RS'),(5,'Uruguaiana','RS'),(6,'Porto Alegre','RS'),(7,'Curitiba','PR'),(8,'Maringá','PR'),(9,'Blumenau','SC'),(10,'Tubarão','SC'),(11,'Itapema','SC'),(12,'Bagé','RS');
/*!40000 ALTER TABLE `cidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `noticia`
--

LOCK TABLES `noticia` WRITE;
/*!40000 ALTER TABLE `noticia` DISABLE KEYS */;
INSERT INTO `noticia` VALUES (1,'Felipão saí do Palmeiras','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ullamcorper magna in cursus molestie. Pellentesque est mi, aliquet non elementum ac, sodales volutpat mauris. Mauris sit amet lectus finibus arcu dignissim sodales. Mauris in enim sit amet lectus rutrum mattis. Etiam ultrices laoreet vulputate. In interdum varius dui. Mauris diam lacus, molestie eget odio ullamcorper, maximus varius nibh. Donec eu nibh sagittis, luctus urna vitae, bibendum nulla. Quisque vestibulum mi id luctus interdum. Mauris eu ipsum justo.','2019-09-13',1,2),(2,'Relampago Marquinhos','Corrida Maluca','2019-09-13',NULL,8),(3,'Massa ao Pesto','Receitas novas','2019-09-11',4,NULL);
/*!40000 ALTER TABLE `noticia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-13 13:24:20
