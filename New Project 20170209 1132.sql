-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema ppap
--

CREATE DATABASE IF NOT EXISTS ppap;
USE ppap;

--
-- Definition of table `bilhetes`
--

DROP TABLE IF EXISTS `bilhetes`;
CREATE TABLE `bilhetes` (
  `codB` int(11) NOT NULL auto_increment,
  `codL` int(11) default NULL,
  `codV` int(11) default NULL,
  `preco` double default NULL,
  PRIMARY KEY  (`codB`),
  KEY `codL` (`codL`),
  KEY `codV` (`codV`),
  CONSTRAINT `bilhetes_ibfk_1` FOREIGN KEY (`codL`) REFERENCES `lugares` (`codL`),
  CONSTRAINT `bilhetes_ibfk_2` FOREIGN KEY (`codV`) REFERENCES `vendas` (`codV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bilhetes`
--

/*!40000 ALTER TABLE `bilhetes` DISABLE KEYS */;
/*!40000 ALTER TABLE `bilhetes` ENABLE KEYS */;


--
-- Definition of table `calendarios`
--

DROP TABLE IF EXISTS `calendarios`;
CREATE TABLE `calendarios` (
  `codCa` int(11) NOT NULL auto_increment,
  `hora` time default NULL,
  `datai` date default NULL,
  `dataf` date default NULL,
  `codS` int(11) default NULL,
  `codFl` int(11) default NULL,
  PRIMARY KEY  USING BTREE (`codCa`),
  KEY `codS` (`codS`),
  KEY `codFl` (`codFl`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `calendarios`
--

/*!40000 ALTER TABLE `calendarios` DISABLE KEYS */;
INSERT INTO `calendarios` (`codCa`,`hora`,`datai`,`dataf`,`codS`,`codFl`) VALUES 
 (2,'13:00:00','2017-01-17','2017-03-30',2,2),
 (3,'15:00:00','2017-01-17','2017-03-30',2,2);
/*!40000 ALTER TABLE `calendarios` ENABLE KEYS */;


--
-- Definition of table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `codCat` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  USING BTREE (`codCat`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categorias`
--

/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` (`codCat`,`nome`) VALUES 
 (1,'Ação'),
 (2,'Aventura'),
 (3,'Animação'),
 (4,'Comédia'),
 (5,'Clássico'),
 (6,'Documentário'),
 (7,'Drama'),
 (8,'Ficção'),
 (9,'Musical'),
 (10,'Romance'),
 (11,'Terror'),
 (12,'Suspense');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;


--
-- Definition of table `classificacoes`
--

DROP TABLE IF EXISTS `classificacoes`;
CREATE TABLE `classificacoes` (
  `codCs` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codCs`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `classificacoes`
--

/*!40000 ALTER TABLE `classificacoes` DISABLE KEYS */;
INSERT INTO `classificacoes` (`codCs`,`nome`) VALUES 
 (1,'M/3'),
 (2,'M/7'),
 (3,'M/12'),
 (4,'M/16'),
 (5,'M/18');
/*!40000 ALTER TABLE `classificacoes` ENABLE KEYS */;


--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `codC` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  `NIF` varchar(9) default NULL,
  `codLo` int(11) default NULL,
  `rua` varchar(100) default NULL,
  `ativado` tinyint(1) default NULL,
  `telemovel` varchar(9) default NULL,
  `empregado` tinyint(1) default NULL,
  PRIMARY KEY  (`codC`),
  KEY `codLo` (`codLo`),
  CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`codLo`) REFERENCES `localidades` (`codLo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`codC`,`nome`,`NIF`,`codLo`,`rua`,`ativado`,`telemovel`,`empregado`) VALUES 
 (1,'uuksdfh','123456789',1,'Rua Não Ramirez',1,'123456789',NULL),
 (2,'uuksdfh','123456780',1,'Rua Ramirez',1,'123456789',NULL),
 (3,'uuksdfh','123',1,'Rua Tavares',1,'123456789',NULL);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `encargos`
--

DROP TABLE IF EXISTS `encargos`;
CREATE TABLE `encargos` (
  `codE` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  USING BTREE (`codE`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `encargos`
--

/*!40000 ALTER TABLE `encargos` DISABLE KEYS */;
INSERT INTO `encargos` (`codE`,`nome`) VALUES 
 (1,'Rececionista');
/*!40000 ALTER TABLE `encargos` ENABLE KEYS */;


--
-- Definition of table `filmes`
--

DROP TABLE IF EXISTS `filmes`;
CREATE TABLE `filmes` (
  `codFl` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `atores` varchar(200) default NULL,
  `realizador` varchar(50) default NULL,
  `ano` year(4) NOT NULL,
  `duracao` time default NULL,
  `codCs` int(11) default NULL,
  `preco` double default NULL,
  PRIMARY KEY  (`codFl`),
  KEY `codCs` (`codCs`),
  CONSTRAINT `filmes_ibfk_2` FOREIGN KEY (`codCs`) REFERENCES `classificacoes` (`codCs`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `filmes`
--

/*!40000 ALTER TABLE `filmes` DISABLE KEYS */;
INSERT INTO `filmes` (`codFl`,`nome`,`atores`,`realizador`,`ano`,`duracao`,`codCs`,`preco`) VALUES 
 (2,'Assassin’s Creed','Michael Fassbender, Marion Cotillard, Jeremy Irons, Brendan Gleeson, Khalid Abdalla, Michael K. Williams','Justin Kurzel',2016,'01:55:00',3,5.56),
 (3,'O Pátio das Cantigas','Rui Unas, Miguel Guilherme, Anabela Moreira, César Mourão','Leonel Vieira',2015,'01:51:00',4,4.87),
 (4,'A Mãe é que Sabe','Maria João Abreu, Dalila Carmo, Manuel Cavaco, Bruno Cabrerizo, Margarida Carpinteiro','Nuno Rocha',2016,'01:28:00',3,4.56),
 (6,'Zeus','Sinde Filipe, Ivo Canelas, Catarina Luís, Paulo Pires','Paulo Filipe Monteiro',2016,'01:57:00',3,5.08),
 (7,'Cartas de Guerra','Miguel Nunes, Margarida Vila-Nova, Ricardo Pereira, João Pedro Vaz, Simão Cayatte','Ivo M. Ferreira',2016,'01:45:00',3,4.83),
 (8,'À Procura de Dory','Ellen DeGeneres, Albert Brooks, Ed O\'Neill','Andrew Stanton, Angus MacLane',2016,'01:37:00',1,4.42);
/*!40000 ALTER TABLE `filmes` ENABLE KEYS */;


--
-- Definition of table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE `funcionarios` (
  `codF` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `ordenado` double default NULL,
  `telemovel` varchar(9) default NULL,
  `codE` int(11) default NULL,
  `palavra_passe` varchar(50) default NULL,
  `datanasc` date default NULL,
  `rua` varchar(45) default NULL,
  `codLo` int(11) default NULL,
  `username` varchar(50) default NULL,
  `empregado` tinyint(1) default NULL,
  PRIMARY KEY  (`codF`),
  KEY `codEnc` USING BTREE (`codE`),
  KEY `codLo` (`codLo`),
  CONSTRAINT `funcionarios_ibfk_1` FOREIGN KEY (`codE`) REFERENCES `encargos` (`codE`),
  CONSTRAINT `funcionarios_ibfk_2` FOREIGN KEY (`codLo`) REFERENCES `localidades` (`codLo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `funcionarios`
--

/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` (`codF`,`nome`,`ordenado`,`telemovel`,`codE`,`palavra_passe`,`datanasc`,`rua`,`codLo`,`username`,`empregado`) VALUES 
 (1,'Pedro Marquesisas',200,'912345678',1,'1234','1999-11-11','Rua Filipa Lencastre',1,'PP',1),
 (2,'Patrício Ribeiro',500,NULL,1,'1',NULL,NULL,1,'Ribas21',1);
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;


--
-- Definition of table `generos`
--

DROP TABLE IF EXISTS `generos`;
CREATE TABLE `generos` (
  `codG` int(11) NOT NULL auto_increment,
  `nome` varchar(60) default NULL,
  PRIMARY KEY  (`codG`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `generos`
--

/*!40000 ALTER TABLE `generos` DISABLE KEYS */;
INSERT INTO `generos` (`codG`,`nome`) VALUES 
 (1,'Comida'),
 (2,'Bebidas'),
 (3,'Gomas');
/*!40000 ALTER TABLE `generos` ENABLE KEYS */;


--
-- Definition of table `localidades`
--

DROP TABLE IF EXISTS `localidades`;
CREATE TABLE `localidades` (
  `codLo` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  PRIMARY KEY  (`codLo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `localidades`
--

/*!40000 ALTER TABLE `localidades` DISABLE KEYS */;
INSERT INTO `localidades` (`codLo`,`nome`) VALUES 
 (1,'Queijas');
/*!40000 ALTER TABLE `localidades` ENABLE KEYS */;


--
-- Definition of table `lugares`
--

DROP TABLE IF EXISTS `lugares`;
CREATE TABLE `lugares` (
  `codL` int(11) NOT NULL auto_increment,
  `coluna` int(11) default NULL,
  `linha` varchar(1) default NULL,
  `codS` int(11) default NULL,
  `disponivel` tinyint(1) default NULL,
  PRIMARY KEY  (`codL`),
  KEY `codS` (`codS`),
  CONSTRAINT `lugares_ibfk_1` FOREIGN KEY (`codS`) REFERENCES `salas` (`codS`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `lugares`
--

/*!40000 ALTER TABLE `lugares` DISABLE KEYS */;
INSERT INTO `lugares` (`codL`,`coluna`,`linha`,`codS`,`disponivel`) VALUES 
 (1,1,'A',NULL,NULL),
 (2,2,'A',NULL,NULL),
 (3,3,'A',NULL,NULL),
 (4,4,'A',NULL,NULL),
 (5,5,'A',NULL,NULL),
 (6,6,'A',NULL,NULL),
 (7,7,'A',NULL,NULL),
 (8,8,'A',NULL,NULL),
 (9,9,'A',NULL,NULL),
 (10,10,'A',NULL,NULL),
 (11,11,'A',NULL,NULL),
 (12,12,'A',NULL,NULL);
/*!40000 ALTER TABLE `lugares` ENABLE KEYS */;


--
-- Definition of table `paises`
--

DROP TABLE IF EXISTS `paises`;
CREATE TABLE `paises` (
  `codPs` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codPs`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `paises`
--

/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` (`codPs`,`nome`) VALUES 
 (1,'Portugal'),
 (2,'EUA'),
 (3,'Brasil'),
 (4,'França'),
 (5,'China'),
 (6,'Reino Unido');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;


--
-- Definition of table `permissoes`
--

DROP TABLE IF EXISTS `permissoes`;
CREATE TABLE `permissoes` (
  `codPe` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  PRIMARY KEY  (`codPe`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `permissoes`
--

/*!40000 ALTER TABLE `permissoes` DISABLE KEYS */;
INSERT INTO `permissoes` (`codPe`,`nome`) VALUES 
 (1,'consultar'),
 (2,'alterar'),
 (3,'inserir'),
 (4,'desativar');
/*!40000 ALTER TABLE `permissoes` ENABLE KEYS */;


--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `codP` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `codG` int(11) default NULL,
  `stock` int(10) unsigned default NULL,
  `preco` double default NULL,
  PRIMARY KEY  (`codP`),
  KEY `codG` (`codG`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`codG`) REFERENCES `generos` (`codG`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`codP`,`nome`,`codG`,`stock`,`preco`) VALUES 
 (2,'Pipocas pequenas',1,45,1.5),
 (3,'Pipocas médias',1,40,2),
 (4,'Pipocas grandes',1,35,3),
 (5,'Sumol Ananás',2,67,0.65),
 (6,'Sumol Maracujá',2,45,0.75),
 (7,'Sumol Tropical',2,23,0.75),
 (8,'Sumol Frutos Vermelhos',2,10,0.8);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;


--
-- Definition of table `salas`
--

DROP TABLE IF EXISTS `salas`;
CREATE TABLE `salas` (
  `codS` int(11) NOT NULL auto_increment,
  `codT` int(11) default NULL,
  PRIMARY KEY  (`codS`),
  KEY `codT` (`codT`),
  CONSTRAINT `salas_ibfk_1` FOREIGN KEY (`codT`) REFERENCES `tipos` (`codT`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `salas`
--

/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` (`codS`,`codT`) VALUES 
 (1,1),
 (2,1),
 (3,1),
 (4,2);
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;


--
-- Definition of table `tabelas`
--

DROP TABLE IF EXISTS `tabelas`;
CREATE TABLE `tabelas` (
  `codTa` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codTa`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabelas`
--

/*!40000 ALTER TABLE `tabelas` DISABLE KEYS */;
INSERT INTO `tabelas` (`codTa`,`nome`) VALUES 
 (1,'Funcionarios/Localidades'),
 (2,'Encargos/Permissoes/Tabelas'),
 (3,'Clientes/Localidades'),
 (4,'Vendas/Bilhetes/Clientes/Localidades'),
 (5,'Salas/Lugares/Tipo'),
 (6,'Produtos/Generos'),
 (7,'Calendarios/Filmes/Paises'),
 (8,'Lugares');
/*!40000 ALTER TABLE `tabelas` ENABLE KEYS */;


--
-- Definition of table `tipos`
--

DROP TABLE IF EXISTS `tipos`;
CREATE TABLE `tipos` (
  `codT` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codT`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tipos`
--

/*!40000 ALTER TABLE `tipos` DISABLE KEYS */;
INSERT INTO `tipos` (`codT`,`nome`) VALUES 
 (1,'2D'),
 (2,'2D/3D');
/*!40000 ALTER TABLE `tipos` ENABLE KEYS */;


--
-- Definition of table `vendas`
--

DROP TABLE IF EXISTS `vendas`;
CREATE TABLE `vendas` (
  `codV` int(11) NOT NULL auto_increment,
  `datav` date default NULL,
  `codF` int(11) default NULL,
  `codC` int(11) default NULL,
  PRIMARY KEY  (`codV`),
  KEY `codF` (`codF`),
  KEY `codC` (`codC`),
  CONSTRAINT `vendas_ibfk_1` FOREIGN KEY (`codF`) REFERENCES `funcionarios` (`codF`),
  CONSTRAINT `vendas_ibfk_2` FOREIGN KEY (`codC`) REFERENCES `clientes` (`codC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vendas`
--

/*!40000 ALTER TABLE `vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendas` ENABLE KEYS */;

--
-- Definition of table `aux_cat`
--

DROP TABLE IF EXISTS `aux_cat`;
CREATE TABLE `aux_cat` (
  `codAC` int(11) NOT NULL auto_increment,
  `codFl` int(11) default NULL,
  `codCat` int(11) default NULL,
  PRIMARY KEY  (`codAC`),
  KEY `codFl` (`codFl`),
  KEY `codCat` (`codCat`),
  CONSTRAINT `aux_cat_ibfk_2` FOREIGN KEY (`codFl`) REFERENCES `filmes` (`codFl`),
  CONSTRAINT `aux_cat_ibfk_3` FOREIGN KEY (`codCat`) REFERENCES `categorias` (`codCat`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aux_cat`
--

/*!40000 ALTER TABLE `aux_cat` DISABLE KEYS */;
INSERT INTO `aux_cat` (`codAC`,`codFl`,`codCat`) VALUES 
 (1,2,1),
 (2,2,2),
 (3,3,4),
 (4,4,4),
 (5,6,6),
 (6,6,7),
 (7,7,6),
 (8,7,7),
 (9,8,2),
 (10,8,3);
/*!40000 ALTER TABLE `aux_cat` ENABLE KEYS */;


--
-- Definition of table `aux_enc`
--

DROP TABLE IF EXISTS `aux_enc`;
CREATE TABLE `aux_enc` (
  `codAE` int(11) NOT NULL auto_increment,
  `codE` int(11) default NULL,
  `codPe` int(11) default NULL,
  `codTa` int(11) default NULL,
  PRIMARY KEY  (`codAE`),
  KEY `codE` (`codE`),
  KEY `codPe` (`codPe`),
  KEY `codTa` (`codTa`),
  CONSTRAINT `aux_enc_ibfk_1` FOREIGN KEY (`codE`) REFERENCES `encargos` (`codE`),
  CONSTRAINT `aux_enc_ibfk_2` FOREIGN KEY (`codPe`) REFERENCES `permissoes` (`codPe`),
  CONSTRAINT `aux_enc_ibfk_3` FOREIGN KEY (`codTa`) REFERENCES `tabelas` (`codTa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aux_enc`
--

/*!40000 ALTER TABLE `aux_enc` DISABLE KEYS */;
INSERT INTO `aux_enc` (`codAE`,`codE`,`codPe`,`codTa`) VALUES 
 (1,1,1,4),
 (2,1,2,4),
 (3,1,3,4),
 (4,1,4,4);
/*!40000 ALTER TABLE `aux_enc` ENABLE KEYS */;


--
-- Definition of table `aux_pai`
--

DROP TABLE IF EXISTS `aux_pai`;
CREATE TABLE `aux_pai` (
  `codAP` int(11) NOT NULL auto_increment,
  `codFl` int(11) default NULL,
  `codPs` int(11) default NULL,
  PRIMARY KEY  (`codAP`),
  KEY `codFl` (`codFl`),
  KEY `codPs` (`codPs`),
  CONSTRAINT `aux_pai_ibfk_1` FOREIGN KEY (`codFl`) REFERENCES `filmes` (`codFl`),
  CONSTRAINT `aux_pai_ibfk_2` FOREIGN KEY (`codPs`) REFERENCES `paises` (`codPs`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aux_pai`
--

/*!40000 ALTER TABLE `aux_pai` DISABLE KEYS */;
INSERT INTO `aux_pai` (`codAP`,`codFl`,`codPs`) VALUES 
 (1,2,1),
 (2,3,1),
 (3,4,1),
 (4,6,1),
 (5,7,1),
 (6,8,2),
 (7,2,6),
 (8,2,4),
 (9,2,5);
/*!40000 ALTER TABLE `aux_pai` ENABLE KEYS */;


--
-- Definition of table `aux_vend`
--

DROP TABLE IF EXISTS `aux_vend`;
CREATE TABLE `aux_vend` (
  `codAV` int(11) NOT NULL auto_increment,
  `codP` int(11) default NULL,
  `codV` int(11) default NULL,
  `quantidade` int(11) default NULL,
  `codCat` int(11) default NULL,
  PRIMARY KEY  (`codAV`),
  KEY `codP` (`codP`),
  KEY `codV` (`codV`),
  KEY `codCat` (`codCat`),
  CONSTRAINT `aux_vend_ibfk_1` FOREIGN KEY (`codP`) REFERENCES `produtos` (`codP`),
  CONSTRAINT `aux_vend_ibfk_2` FOREIGN KEY (`codV`) REFERENCES `vendas` (`codV`),
  CONSTRAINT `aux_vend_ibfk_3` FOREIGN KEY (`codCat`) REFERENCES `categorias` (`codCat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aux_vend`
--

/*!40000 ALTER TABLE `aux_vend` DISABLE KEYS */;
/*!40000 ALTER TABLE `aux_vend` ENABLE KEYS */;





/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
