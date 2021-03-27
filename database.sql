/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 10.4.17-MariaDB : Database - familia_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`familia_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `familia_db`;

/*Table structure for table `mae_persona` */

DROP TABLE IF EXISTS `mae_persona`;

CREATE TABLE `mae_persona` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `tipo_documento` varchar(50) DEFAULT NULL,
  `numero_documento` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `nacionalidad` varchar(50) DEFAULT NULL,
  `telefono1` varchar(30) DEFAULT NULL,
  `telefono2` varchar(30) DEFAULT NULL,
  `telefono3` varchar(30) DEFAULT NULL,
  `celular` varchar(30) DEFAULT NULL,
  `lugar_residencia` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` varchar(50) DEFAULT NULL,
  `tipo_programa` varchar(50) DEFAULT NULL,
  `nombre_fallecido` varchar(50) DEFAULT NULL,
  `num_doc_fallecido` varchar(30) DEFAULT NULL,
  `fecha_fallecimiento` varchar(50) DEFAULT NULL,
  `detalles_fallecimiento` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
