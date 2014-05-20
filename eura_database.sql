/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : eura_database

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2014-05-20 15:20:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for empleado
-- ----------------------------
DROP TABLE IF EXISTS `empleado`;
CREATE TABLE `empleado` (
  `id_empleado` int(10) NOT NULL,
  `nombre` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `username` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `password` varchar(16) COLLATE latin1_spanish_ci DEFAULT NULL,
  `puesto` int(10) DEFAULT NULL,
  `status` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `FK_puesto_employee` (`puesto`),
  CONSTRAINT `FK_puesto_employee` FOREIGN KEY (`puesto`) REFERENCES `puesto` (`id_puesto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of empleado
-- ----------------------------
INSERT INTO `empleado` VALUES ('1', 'david', '321412sda', '123', '2', '1');
INSERT INTO `empleado` VALUES ('2', 'david', 'Em15076', '15004', '1', 'activo');
INSERT INTO `empleado` VALUES ('3', 'david peresz', 'Em14457', '14747', '2', 'Habiliado');

-- ----------------------------
-- Table structure for entrada
-- ----------------------------
DROP TABLE IF EXISTS `entrada`;
CREATE TABLE `entrada` (
  `id_entrada` int(10) NOT NULL AUTO_INCREMENT,
  `no_nota` varchar(10) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(60) COLLATE latin1_spanish_ci DEFAULT NULL,
  `proveedor` int(10) DEFAULT NULL,
  `empleado` int(10) DEFAULT NULL,
  `precio` double(10,2) DEFAULT NULL,
  `cantidad` int(10) DEFAULT NULL,
  `tipo_unidad` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `nota` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `fecha` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_entrada`),
  KEY `FK_PROV_ENT` (`proveedor`),
  KEY `FK_EMP_ENT` (`empleado`),
  CONSTRAINT `FK_EMP_ENT` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_PROV_ENT` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`id_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of entrada
-- ----------------------------
INSERT INTO `entrada` VALUES ('1', '21412', 'varilla', '1', '1', '3123.00', '132', 'Kilogramos', 'NO EXISTE POR EL MOMENTO', '2014-05-20 16:52:31');

-- ----------------------------
-- Table structure for material
-- ----------------------------
DROP TABLE IF EXISTS `material`;
CREATE TABLE `material` (
  `id_material` int(10) NOT NULL,
  `unidad` varchar(6) COLLATE latin1_spanish_ci DEFAULT NULL,
  `concepto` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `cantidad` int(10) DEFAULT NULL,
  `num_nota` int(10) DEFAULT NULL,
  `fecha_entrada` varchar(15) COLLATE latin1_spanish_ci DEFAULT NULL,
  `notas` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `kg` double(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_material`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of material
-- ----------------------------

-- ----------------------------
-- Table structure for movimientos_sistema
-- ----------------------------
DROP TABLE IF EXISTS `movimientos_sistema`;
CREATE TABLE `movimientos_sistema` (
  `id_movimiento` int(10) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(60) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(200) COLLATE latin1_spanish_ci DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `empleado` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `FK_EMP_MOVSIS` (`empleado`),
  CONSTRAINT `FK_EMP_MOVSIS` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of movimientos_sistema
-- ----------------------------
INSERT INTO `movimientos_sistema` VALUES ('1', 'acceso', 'el usuario accedio', '2014-05-20 12:31:43', '2');
INSERT INTO `movimientos_sistema` VALUES ('2', null, null, null, null);
INSERT INTO `movimientos_sistema` VALUES ('3', 'Login', 'Accedio al Sistema', '2014-05-20 14:21:07', '3');
INSERT INTO `movimientos_sistema` VALUES ('4', 'Login', 'Accedio al Sistema', '2014-05-20 14:21:56', '3');
INSERT INTO `movimientos_sistema` VALUES ('5', 'Login', 'Accedio al Sistema', '2014-05-20 14:22:26', '3');
INSERT INTO `movimientos_sistema` VALUES ('6', 'Login', 'Accedio al Sistema', '2014-05-20 14:22:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('7', 'Login', 'Accedio al Sistema', '2014-05-20 14:22:56', '3');
INSERT INTO `movimientos_sistema` VALUES ('8', 'Login', 'Accedio al Sistema', '2014-05-20 14:26:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('9', 'Login', 'Accedio al Sistema', '2014-05-20 14:31:08', '3');
INSERT INTO `movimientos_sistema` VALUES ('10', 'Login', 'Accedio al Sistema', '2014-05-20 14:31:56', '3');
INSERT INTO `movimientos_sistema` VALUES ('11', 'Login', 'Accedio al Sistema', '2014-05-20 14:32:21', '3');
INSERT INTO `movimientos_sistema` VALUES ('12', 'Login', 'Accedio al Sistema', '2014-05-20 14:33:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('13', 'Login', 'Accedio al Sistema', '2014-05-20 14:33:17', '3');
INSERT INTO `movimientos_sistema` VALUES ('14', 'Login', 'Accedio al Sistema', '2014-05-20 14:33:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('15', 'Login', 'Accedio al Sistema', '2014-05-20 14:34:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('16', 'Login', 'Accedio al Sistema', '2014-05-20 14:39:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('17', 'Login', 'Accedio al Sistema', '2014-05-20 14:40:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('18', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:43:34', '3');
INSERT INTO `movimientos_sistema` VALUES ('19', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:43:56', '3');
INSERT INTO `movimientos_sistema` VALUES ('20', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:44:46', '2');
INSERT INTO `movimientos_sistema` VALUES ('21', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:45:26', '2');
INSERT INTO `movimientos_sistema` VALUES ('22', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:46:32', '2');
INSERT INTO `movimientos_sistema` VALUES ('23', 'Login', 'Accedio al Sistema un Administrador', '2014-05-20 14:47:45', '1');
INSERT INTO `movimientos_sistema` VALUES ('24', 'Login', 'Accedio al Sistema un Empleado', '2014-05-20 14:51:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('25', 'Login', 'Accedio al Sistema un Administrador', '2014-05-20 14:52:10', '2');
INSERT INTO `movimientos_sistema` VALUES ('26', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 14:53:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('27', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:00:15', '2');
INSERT INTO `movimientos_sistema` VALUES ('28', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:04:58', '2');
INSERT INTO `movimientos_sistema` VALUES ('29', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:05:51', '2');
INSERT INTO `movimientos_sistema` VALUES ('30', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:06:43', '2');
INSERT INTO `movimientos_sistema` VALUES ('31', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:07:20', '2');
INSERT INTO `movimientos_sistema` VALUES ('32', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:09:17', '2');
INSERT INTO `movimientos_sistema` VALUES ('33', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:17:08', '3');
INSERT INTO `movimientos_sistema` VALUES ('34', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:18:29', '3');
INSERT INTO `movimientos_sistema` VALUES ('35', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 15:18:47', '2');

-- ----------------------------
-- Table structure for obra_destino
-- ----------------------------
DROP TABLE IF EXISTS `obra_destino`;
CREATE TABLE `obra_destino` (
  `id_obra` int(10) NOT NULL,
  `obra` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `direccion` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `nota` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_obra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of obra_destino
-- ----------------------------

-- ----------------------------
-- Table structure for proveedor
-- ----------------------------
DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `id_proveedor` int(10) NOT NULL,
  `nombre_proveedor` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `RFC` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `razon_social` varchar(70) COLLATE latin1_spanish_ci DEFAULT NULL,
  `direccion` varchar(200) COLLATE latin1_spanish_ci DEFAULT NULL,
  `telefono_contacto` varchar(30) COLLATE latin1_spanish_ci DEFAULT NULL,
  `email` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `status` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `website` varchar(70) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of proveedor
-- ----------------------------
INSERT INTO `proveedor` VALUES ('1', 'Home depot', '21\'4912', 'bavria', 'tizapa', '41421214241', 'zahid@fasfa.com', '1', null);
INSERT INTO `proveedor` VALUES ('2', 'Varillax', 'das', 'das', 'dsa', 'dsa', 'das', '1', null);

-- ----------------------------
-- Table structure for puesto
-- ----------------------------
DROP TABLE IF EXISTS `puesto`;
CREATE TABLE `puesto` (
  `id_puesto` int(10) NOT NULL,
  `puesto` varchar(40) COLLATE latin1_spanish_ci DEFAULT NULL,
  `descripcion` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_puesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of puesto
-- ----------------------------
INSERT INTO `puesto` VALUES ('0', '', '');
INSERT INTO `puesto` VALUES ('1', '', '');
INSERT INTO `puesto` VALUES ('2', '1', 'Administrador');
INSERT INTO `puesto` VALUES ('3', '2', 'Empleado');

-- ----------------------------
-- Table structure for salida
-- ----------------------------
DROP TABLE IF EXISTS `salida`;
CREATE TABLE `salida` (
  `id_salida` int(10) NOT NULL,
  `fecha_salida` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `kg` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `obra` int(10) DEFAULT NULL,
  `nota` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `num_salidas` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_salida`),
  KEY `FK_OBRA_SAL` (`obra`),
  CONSTRAINT `FK_OBRA_SAL` FOREIGN KEY (`obra`) REFERENCES `obra_destino` (`id_obra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of salida
-- ----------------------------
