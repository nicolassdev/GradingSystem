-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: gradingsystemdb
-- ------------------------------------------------------
-- Server version	5.6.51-log

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
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grades` (
  `S_ID` varchar(20) NOT NULL,
  `SUB_ID` varchar(20) NOT NULL,
  `G_PRELIM` decimal(10,2) NOT NULL,
  `G_MIDTER` decimal(10,2) NOT NULL,
  `G_SEMI` decimal(10,2) NOT NULL,
  `G_FINAL` decimal(10,2) NOT NULL,
  `G_REMARKS` varchar(20) NOT NULL,
  PRIMARY KEY (`S_ID`,`SUB_ID`),
  KEY `SUB_ID` (`SUB_ID`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`S_ID`) REFERENCES `student` (`S_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`SUB_ID`) REFERENCES `subjects` (`SUB_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `S_NUM` int(11) NOT NULL AUTO_INCREMENT,
  `S_ID` varchar(20) NOT NULL,
  `S_FNAME` varchar(30) NOT NULL,
  `S_MNAME` varchar(30) NOT NULL,
  `S_LNAME` varchar(30) NOT NULL,
  `S_COURSE` varchar(30) NOT NULL,
  `S_SECTION` varchar(30) NOT NULL,
  PRIMARY KEY (`S_ID`),
  UNIQUE KEY `S_NUM` (`S_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'STUD-2023-1','ANTHONY NICOLE','DADO','DAEN','BSCS	','BLOCK A'),(2,'STUD-2023-2','RICHARD','DALU','MANZO','BSCS	','BLOCK A'),(3,'STUD-2023-3','LESTER','BULDOG','SAPAULA','BSCS	','BLOCK A');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `SUB_NUM` int(11) NOT NULL AUTO_INCREMENT,
  `SUB_ID` varchar(20) NOT NULL,
  `T_ID` varchar(20) DEFAULT NULL,
  `T_NAME` varchar(20) DEFAULT NULL,
  `SUB_NAME` varchar(20) NOT NULL,
  `SUB_UNIT` tinyint(4) NOT NULL,
  `SUB_SYEAR` varchar(20) NOT NULL,
  `SUB_TYPE` varchar(20) NOT NULL,
  PRIMARY KEY (`SUB_ID`),
  UNIQUE KEY `SUB_NUM` (`SUB_NUM`),
  KEY `T_ID` (`T_ID`),
  CONSTRAINT `subjects_ibfk_1` FOREIGN KEY (`T_ID`) REFERENCES `teacher` (`T_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (1,'SUB-2023-1','TEACHER-2023-2','MARICAR CARREON AYDA','FUNDAMENTALS OF PROG',3,'2023','Major'),(2,'SUB-2023-2','TEACHER-2023-1','ANTHONY DADO DAEN','ADV. DATABASE MANAGE',3,'2023','Major'),(4,'SUB-2023-3','TEACHER-2023-3','LESTER  BAK SAPAULA','APP. DEV. AND EMERGI',2,'2023','Major'),(5,'SUB-2023-5','TEACHER-2023-5','SAM YU KANZU','INTRODUCTION TO COMP',3,'2023','MAJOR'),(6,'SUB-2023-6','TEACHER-2023-4','JOHN DAVE DADO DAEN','PURPOSIVE COMMUNICAT',3,'2023','MINOR '),(7,'SUB-2023-7','TEACHER-2023-1','ANTHONY DADO DAEN','NSTP 1 (CWTS, LECTUR',3,'2023','MAJOR'),(8,'SUB-2023-8','TEACHER-2023-3','LESTER  BAK SAPAULA','MASINING NA PAGPAPAH',2,'2023','MINOR '),(9,'SUB-2023-9','TEACHER-2023-1','LESTER  BAK SAPAULA','UNDERSTANDING THE SE',2,'2023','Minor ');
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacher` (
  `T_NUM` int(11) NOT NULL AUTO_INCREMENT,
  `T_ID` varchar(20) NOT NULL,
  `T_FNAME` varchar(30) NOT NULL,
  `T_MNAME` varchar(30) NOT NULL,
  `T_LNAME` varchar(30) NOT NULL,
  PRIMARY KEY (`T_ID`),
  UNIQUE KEY `T_NUM` (`T_NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (1,'TEACHER-2023-1','ANTHONY','DADO','DAEN'),(2,'TEACHER-2023-2','MARICAR','CARREON','AYDALLA'),(3,'TEACHER-2023-3','LESTER ','BAK','SAPAULA'),(4,'TEACHER-2023-4','JOHN DAVE','DADO','DAEN'),(5,'TEACHER-2023-5','SAM','YU','KANZU');
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-13 10:32:53
