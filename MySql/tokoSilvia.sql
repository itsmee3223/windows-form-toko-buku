/*
SQLyog Ultimate v12.5.1 (64 bit)
MySQL - 10.4.21-MariaDB : Database - tokobuku
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`tokobuku` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `tokobuku`;

/*Table structure for table `tbl_buku` */

DROP TABLE IF EXISTS `tbl_buku`;

CREATE TABLE `tbl_buku` (
  `kode_buku` varchar(10) NOT NULL,
  `penulis` varchar(50) DEFAULT NULL,
  `penerbit` varchar(50) DEFAULT NULL,
  `nama_buku` varchar(50) DEFAULT NULL,
  `tanggal_terbit` date DEFAULT NULL,
  `Harga` int(255) DEFAULT NULL,
  PRIMARY KEY (`kode_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tbl_buku` */

insert  into `tbl_buku`(`kode_buku`,`penulis`,`penerbit`,`nama_buku`,`tanggal_terbit`,`Harga`) values 
('23341','Soeharto','NKRI','Sejarah Indonesia','2022-01-01',10000),
('55455','Ranti','Gramedia','Tuhan Ada Dihatimu','2021-12-15',25000),
('BK5675','Pribakti B','LKiS','Dasar Dasar Uroginekologi','2011-06-17',90000),
('BK782','Supardi','Gava Media','Akutansi Pengantar 1','2009-07-23',78000),
('BK812','Simican','Andi','Penjas','2022-01-09',55000);

/*Table structure for table `tbl_detailtransaksi` */

DROP TABLE IF EXISTS `tbl_detailtransaksi`;

CREATE TABLE `tbl_detailtransaksi` (
  `kode_transaksi` varchar(10) DEFAULT NULL,
  `telpon` varchar(10) DEFAULT NULL,
  `alamat` varchar(20) DEFAULT NULL,
  `tanggal_dibayar` date DEFAULT NULL,
  KEY `kode_buku` (`telpon`),
  KEY `kode_transaksi` (`kode_transaksi`),
  CONSTRAINT `tbl_detailtransaksi_ibfk_1` FOREIGN KEY (`kode_transaksi`) REFERENCES `tbl_pembeli` (`kode_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tbl_detailtransaksi` */

insert  into `tbl_detailtransaksi`(`kode_transaksi`,`telpon`,`alamat`,`tanggal_dibayar`) values 
('TR123','0898789768','Sukarame','2022-01-01');

/*Table structure for table `tbl_pembeli` */

DROP TABLE IF EXISTS `tbl_pembeli`;

CREATE TABLE `tbl_pembeli` (
  `kode_buku` varchar(10) DEFAULT NULL,
  `nama_pembeli` varchar(50) DEFAULT NULL,
  `kode_transaksi` varchar(10) DEFAULT NULL,
  `jumlah` int(255) DEFAULT NULL,
  KEY `kode_transaksi` (`kode_transaksi`),
  KEY `kode_buku` (`kode_buku`),
  CONSTRAINT `tbl_pembeli_ibfk_1` FOREIGN KEY (`kode_buku`) REFERENCES `tbl_buku` (`kode_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tbl_pembeli` */

insert  into `tbl_pembeli`(`kode_buku`,`nama_pembeli`,`kode_transaksi`,`jumlah`) values 
('23341','Silvia Ranti','TR500',2),
('55455','RamandaAA','TR400',2),
('23341','RamandaAA','TR400',5),
('55455','Silvia Ranti','TR500',5),
('BK782','Silvia','TR123',3),
('BK5675','Silvia','TR123',2);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
