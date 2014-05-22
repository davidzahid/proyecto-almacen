/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : eura_database

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2014-05-21 23:13:24
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
INSERT INTO `empleado` VALUES ('1', 'david', '321412sda', '123', '2', 'Habilitado');
INSERT INTO `empleado` VALUES ('2', 'david', 'Em15076', '15004', '1', 'Habilitado');
INSERT INTO `empleado` VALUES ('3', 'david peresz', 'Em14457', '14747', '2', 'Habilitado');
INSERT INTO `empleado` VALUES ('4', 'david zahid', 'david', '1234', '1', 'Habilitado');
INSERT INTO `empleado` VALUES ('5', 'adal', 'adal', '1234', '2', 'Habilitado');
INSERT INTO `empleado` VALUES ('6', 'christian', 'christian', '1234', '2', 'Deshabilitado');

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
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of entrada
-- ----------------------------
INSERT INTO `entrada` VALUES ('1', '21412', 'varilla', '1', '1', '3123.00', '131', 'Kilogramos', 'NO EXISTE POR EL MOMENTO', '2014-05-20 16:52:31');
INSERT INTO `entrada` VALUES ('3', '32132', 'Varilla', '2', '3', '123.00', '12', 'Metro', 'Ninguna', '2014-05-20 20:26:59');
INSERT INTO `entrada` VALUES ('6', '12321', 'dasdsadasdsa', '2', '3', '123.00', '0', 'Kilogramo', 'dsadassdadas', '2014-05-20 20:31:40');
INSERT INTO `entrada` VALUES ('7', '12322', 'das', '2', '3', '1.00', '0', 'Metro Cuadrado', '2', '2014-05-20 20:34:06');
INSERT INTO `entrada` VALUES ('8', '123', 'dsaads', '2', '3', '12.00', '21', 'Kilogramo', 'dsadsa', '2014-05-20 20:37:02');
INSERT INTO `entrada` VALUES ('9', '312', 'Varilla de 3/4', '2', '3', '12.00', '1', 'Metro', 'DASDA', '2014-05-20 20:42:55');
INSERT INTO `entrada` VALUES ('12', '123414', 'DADSADSAD', '2', '3', '21.00', '14', 'Metro Cuadrado', 'DSDA', '2014-05-21 14:03:45');
INSERT INTO `entrada` VALUES ('14', '3124A', 'DAVID 1/3', '2', '3', '12.10', '1498', 'Kilogramo', 'NO SE ENCONTRO NADA', '2014-05-21 14:46:22');
INSERT INTO `entrada` VALUES ('15', 'SAA131', 'DASDASAD', '2', '3', '20000.00', '12', 'Kilogramo', 'NINGUNA131', '2014-05-21 14:46:22');
INSERT INTO `entrada` VALUES ('16', 'WQEQEQWEWQ', 'DADSA', '2', '3', '1.00', '0', 'Metro', 'A', '2014-05-21 14:49:25');
INSERT INTO `entrada` VALUES ('17', 'DASAFASAFA', 'FASFAS', '2', '3', '1.00', '0', 'Metro Cuadrado', 'S', '2014-05-21 14:50:14');
INSERT INTO `entrada` VALUES ('18', '12AFAFSFFS', 'FAFSASFSA', '2', '3', '1111111.10', '12298', 'Metro Cubico', 'SFAASD', '2014-05-21 14:50:14');
INSERT INTO `entrada` VALUES ('19', '1DAASDADAD', 'DASSFASAAS', '2', '3', '9999999.90', '0', 'Metro', 'DSASAFA', '2014-05-21 14:50:14');
INSERT INTO `entrada` VALUES ('21', 'dasdassd', 'dsasdaassdasa', '1', '3', '11111111.00', '0', 'Metro Cuadrado', 'fsfd', '2014-05-21 15:13:25');
INSERT INTO `entrada` VALUES ('22', 'saaaw', 'fafsasfa', '2', '3', '1111111.00', '312', 'Metro Cubico', 'addas', '2014-05-21 15:13:25');
INSERT INTO `entrada` VALUES ('23', 'sfsfaafsfa', 'vfsfsasfasfa', '2', '3', '1112123.00', '32132131', 'Metro', 'dasddsaasd', '2014-05-21 15:13:25');
INSERT INTO `entrada` VALUES ('24', 'dsadsaddas', 'dadsadsa', '2', '3', '12312.00', '12331', 'Kilogramo', 'fsafas', '2014-05-21 15:13:25');
INSERT INTO `entrada` VALUES ('25', 'DASASADAS', 'VARILL', '1', '3', '123.10', '123', 'Mililitros', 'DDADSA', '2014-05-21 16:04:35');
INSERT INTO `entrada` VALUES ('26', '1123', 'q', '2', '3', '32123232.00', '23', 'Metro', 'd', '2014-05-21 17:02:43');

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
) ENGINE=InnoDB AUTO_INCREMENT=367 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

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
INSERT INTO `movimientos_sistema` VALUES ('36', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:21:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('37', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:21:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('38', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:21:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('39', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:21:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('40', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 15:22:15', '3');
INSERT INTO `movimientos_sistema` VALUES ('41', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 16:36:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('42', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:24:08', '3');
INSERT INTO `movimientos_sistema` VALUES ('43', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 17:24:31', '2');
INSERT INTO `movimientos_sistema` VALUES ('44', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:24:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('45', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:26:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('46', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:28:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('47', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 17:29:06', '2');
INSERT INTO `movimientos_sistema` VALUES ('48', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:29:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('49', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 17:30:00', '2');
INSERT INTO `movimientos_sistema` VALUES ('50', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:30:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('51', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 17:30:48', '2');
INSERT INTO `movimientos_sistema` VALUES ('52', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:31:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('53', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:35:54', '3');
INSERT INTO `movimientos_sistema` VALUES ('54', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 17:56:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('55', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:03:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('56', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:04:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('57', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:04:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('58', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:06:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('59', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:09:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('60', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 18:10:05', '2');
INSERT INTO `movimientos_sistema` VALUES ('61', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:11:21', '3');
INSERT INTO `movimientos_sistema` VALUES ('62', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:20:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('63', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:25:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('64', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:26:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('65', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:44:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('66', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:45:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('67', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:45:31', '3');
INSERT INTO `movimientos_sistema` VALUES ('68', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:46:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('69', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:47:15', '3');
INSERT INTO `movimientos_sistema` VALUES ('70', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:49:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('71', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:51:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('72', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:52:45', '3');
INSERT INTO `movimientos_sistema` VALUES ('73', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 18:54:07', '3');
INSERT INTO `movimientos_sistema` VALUES ('74', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:25:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('75', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:28:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('76', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:29:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('77', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:30:07', '3');
INSERT INTO `movimientos_sistema` VALUES ('78', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:30:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('79', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:32:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('80', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:33:26', '3');
INSERT INTO `movimientos_sistema` VALUES ('81', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:34:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('82', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:34:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('83', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:35:37', '3');
INSERT INTO `movimientos_sistema` VALUES ('84', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:39:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('85', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:40:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('86', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:40:32', '3');
INSERT INTO `movimientos_sistema` VALUES ('87', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:41:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('88', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:41:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('89', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:44:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('90', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:44:06', '3');
INSERT INTO `movimientos_sistema` VALUES ('91', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:47:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('92', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:47:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('93', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:49:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('94', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:51:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('95', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:51:46', '3');
INSERT INTO `movimientos_sistema` VALUES ('96', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:54:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('97', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:57:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('98', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:57:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('99', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 19:57:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('100', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 19:57:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('101', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:00:17', '3');
INSERT INTO `movimientos_sistema` VALUES ('102', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:00:20', '3');
INSERT INTO `movimientos_sistema` VALUES ('103', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:01:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('104', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:01:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('105', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:02:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('106', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:02:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('107', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:03:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('108', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:03:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('109', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:04:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('110', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:04:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('111', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:05:21', '3');
INSERT INTO `movimientos_sistema` VALUES ('112', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:05:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('113', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:05:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('114', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:05:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('115', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:07:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('116', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:07:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('117', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:09:29', '3');
INSERT INTO `movimientos_sistema` VALUES ('118', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:09:31', '3');
INSERT INTO `movimientos_sistema` VALUES ('119', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:10:39', '3');
INSERT INTO `movimientos_sistema` VALUES ('120', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:10:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('121', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:12:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('122', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:12:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('123', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:15:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('124', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:15:24', '3');
INSERT INTO `movimientos_sistema` VALUES ('125', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:22:39', '3');
INSERT INTO `movimientos_sistema` VALUES ('126', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:22:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('127', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:26:57', '3');
INSERT INTO `movimientos_sistema` VALUES ('128', 'Registro de Entrada', 'Entrada generada por empleado: Em14457', '2014-05-20 20:26:59', '3');
INSERT INTO `movimientos_sistema` VALUES ('129', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:28:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('130', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:29:08', '3');
INSERT INTO `movimientos_sistema` VALUES ('131', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:30:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('132', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:31:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('133', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:31:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('134', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:31:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('135', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:34:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('136', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:34:06', '3');
INSERT INTO `movimientos_sistema` VALUES ('137', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:37:00', '3');
INSERT INTO `movimientos_sistema` VALUES ('138', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:37:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('139', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:38:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('140', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:42:54', '3');
INSERT INTO `movimientos_sistema` VALUES ('141', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-20 20:42:55', '3');
INSERT INTO `movimientos_sistema` VALUES ('142', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 20:52:27', '3');
INSERT INTO `movimientos_sistema` VALUES ('143', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:04:27', '3');
INSERT INTO `movimientos_sistema` VALUES ('144', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:07:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('145', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:08:00', '3');
INSERT INTO `movimientos_sistema` VALUES ('146', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:08:27', '3');
INSERT INTO `movimientos_sistema` VALUES ('147', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:17:18', '3');
INSERT INTO `movimientos_sistema` VALUES ('148', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:27:26', '3');
INSERT INTO `movimientos_sistema` VALUES ('149', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:29:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('150', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:32:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('151', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:34:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('152', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:35:53', '3');
INSERT INTO `movimientos_sistema` VALUES ('153', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:36:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('154', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:38:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('155', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:39:07', '2');
INSERT INTO `movimientos_sistema` VALUES ('156', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:39:48', '2');
INSERT INTO `movimientos_sistema` VALUES ('157', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:40:35', '2');
INSERT INTO `movimientos_sistema` VALUES ('158', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:49:18', '3');
INSERT INTO `movimientos_sistema` VALUES ('159', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:49:33', '2');
INSERT INTO `movimientos_sistema` VALUES ('160', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:49:59', '2');
INSERT INTO `movimientos_sistema` VALUES ('161', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:51:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('162', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:51:09', '3');
INSERT INTO `movimientos_sistema` VALUES ('163', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:51:22', '2');
INSERT INTO `movimientos_sistema` VALUES ('164', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 21:56:36', '3');
INSERT INTO `movimientos_sistema` VALUES ('165', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 21:56:51', '2');
INSERT INTO `movimientos_sistema` VALUES ('166', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-20 23:02:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('167', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-20 23:02:24', '2');
INSERT INTO `movimientos_sistema` VALUES ('168', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 12:09:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('169', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 12:50:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('170', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 12:57:02', '2');
INSERT INTO `movimientos_sistema` VALUES ('171', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:05:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('172', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:05:46', '3');
INSERT INTO `movimientos_sistema` VALUES ('173', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:06:13', '2');
INSERT INTO `movimientos_sistema` VALUES ('174', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:12:32', '3');
INSERT INTO `movimientos_sistema` VALUES ('175', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:12:48', '2');
INSERT INTO `movimientos_sistema` VALUES ('176', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:16:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('177', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:17:04', '2');
INSERT INTO `movimientos_sistema` VALUES ('178', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:20:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('179', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:21:07', '2');
INSERT INTO `movimientos_sistema` VALUES ('180', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:28:06', '3');
INSERT INTO `movimientos_sistema` VALUES ('181', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:28:18', '2');
INSERT INTO `movimientos_sistema` VALUES ('182', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:54:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('183', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 13:54:13', '2');
INSERT INTO `movimientos_sistema` VALUES ('184', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 13:59:15', '3');
INSERT INTO `movimientos_sistema` VALUES ('185', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:00:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('186', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:03:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('187', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:03:45', '3');
INSERT INTO `movimientos_sistema` VALUES ('188', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:22:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('189', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:23:37', '3');
INSERT INTO `movimientos_sistema` VALUES ('190', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:24:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('191', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:25:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('192', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:26:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('193', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:26:26', '3');
INSERT INTO `movimientos_sistema` VALUES ('194', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:28:09', '3');
INSERT INTO `movimientos_sistema` VALUES ('195', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:31:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('196', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:32:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('197', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:33:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('198', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:34:53', '3');
INSERT INTO `movimientos_sistema` VALUES ('199', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:35:33', '3');
INSERT INTO `movimientos_sistema` VALUES ('200', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:37:00', '3');
INSERT INTO `movimientos_sistema` VALUES ('201', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:42:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('202', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:44:15', '3');
INSERT INTO `movimientos_sistema` VALUES ('203', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:45:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('204', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:46:20', '3');
INSERT INTO `movimientos_sistema` VALUES ('205', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:46:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('206', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:46:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('207', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:48:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('208', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:49:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('209', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:49:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('210', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:50:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('211', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:50:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('212', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:50:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('213', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 14:50:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('214', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:54:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('215', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:55:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('216', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:56:12', '3');
INSERT INTO `movimientos_sistema` VALUES ('217', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:57:35', '3');
INSERT INTO `movimientos_sistema` VALUES ('218', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 14:58:59', '3');
INSERT INTO `movimientos_sistema` VALUES ('219', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:00:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('220', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:08:20', '3');
INSERT INTO `movimientos_sistema` VALUES ('221', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:09:16', '3');
INSERT INTO `movimientos_sistema` VALUES ('222', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:10:07', '3');
INSERT INTO `movimientos_sistema` VALUES ('223', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:10:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('224', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:12:17', '3');
INSERT INTO `movimientos_sistema` VALUES ('225', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:12:35', '3');
INSERT INTO `movimientos_sistema` VALUES ('226', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:12:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('227', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:13:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('228', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 15:13:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('229', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 15:13:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('230', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 15:13:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('231', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 15:13:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('232', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:51:29', '3');
INSERT INTO `movimientos_sistema` VALUES ('233', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 15:51:48', '2');
INSERT INTO `movimientos_sistema` VALUES ('234', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:52:31', '3');
INSERT INTO `movimientos_sistema` VALUES ('235', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:54:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('236', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 15:55:52', '2');
INSERT INTO `movimientos_sistema` VALUES ('237', 'Login', 'Accedio al Sistema un Empleado registrado como: em14457', '2014-05-21 15:56:19', '3');
INSERT INTO `movimientos_sistema` VALUES ('238', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 15:56:54', '2');
INSERT INTO `movimientos_sistema` VALUES ('239', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 15:58:01', '2');
INSERT INTO `movimientos_sistema` VALUES ('240', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 15:59:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('241', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 16:04:34', '3');
INSERT INTO `movimientos_sistema` VALUES ('242', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 16:04:35', '3');
INSERT INTO `movimientos_sistema` VALUES ('243', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 16:09:16', '3');
INSERT INTO `movimientos_sistema` VALUES ('244', 'Login', 'Accedio al Sistema un Administrador registrado como: Em15076', '2014-05-21 16:09:59', '2');
INSERT INTO `movimientos_sistema` VALUES ('245', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:02:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('246', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 17:02:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('247', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:14:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('248', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:25:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('249', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:26:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('250', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:28:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('251', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:41:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('252', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:44:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('253', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:45:46', '3');
INSERT INTO `movimientos_sistema` VALUES ('254', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:46:56', '3');
INSERT INTO `movimientos_sistema` VALUES ('255', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:47:24', '3');
INSERT INTO `movimientos_sistema` VALUES ('256', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:48:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('257', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:50:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('258', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:51:36', '3');
INSERT INTO `movimientos_sistema` VALUES ('259', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:53:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('260', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:56:19', '3');
INSERT INTO `movimientos_sistema` VALUES ('261', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:58:27', '3');
INSERT INTO `movimientos_sistema` VALUES ('262', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 17:59:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('263', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:01:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('264', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:02:47', '3');
INSERT INTO `movimientos_sistema` VALUES ('265', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:03:09', '3');
INSERT INTO `movimientos_sistema` VALUES ('266', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:08:18', '3');
INSERT INTO `movimientos_sistema` VALUES ('267', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:08:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('268', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:11:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('269', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:14:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('270', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:16:16', '3');
INSERT INTO `movimientos_sistema` VALUES ('271', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:17:33', '3');
INSERT INTO `movimientos_sistema` VALUES ('272', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:19:09', '3');
INSERT INTO `movimientos_sistema` VALUES ('273', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:19:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('274', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:20:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('275', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:21:17', '3');
INSERT INTO `movimientos_sistema` VALUES ('276', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:23:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('277', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:26:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('278', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:26:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('279', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:29:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('280', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:30:31', '3');
INSERT INTO `movimientos_sistema` VALUES ('281', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:31:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('282', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:32:07', '3');
INSERT INTO `movimientos_sistema` VALUES ('283', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:32:46', '3');
INSERT INTO `movimientos_sistema` VALUES ('284', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:33:59', '3');
INSERT INTO `movimientos_sistema` VALUES ('285', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:34:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('286', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:35:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('287', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:36:54', '3');
INSERT INTO `movimientos_sistema` VALUES ('288', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:37:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('289', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:39:53', '3');
INSERT INTO `movimientos_sistema` VALUES ('290', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:41:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('291', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:41:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('292', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:43:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('293', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:46:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('294', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 18:48:05', '3');
INSERT INTO `movimientos_sistema` VALUES ('295', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:14:03', '3');
INSERT INTO `movimientos_sistema` VALUES ('296', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:16:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('297', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:20:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('298', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:21:58', '3');
INSERT INTO `movimientos_sistema` VALUES ('299', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:22:38', '3');
INSERT INTO `movimientos_sistema` VALUES ('300', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:23:02', '3');
INSERT INTO `movimientos_sistema` VALUES ('301', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:23:39', '3');
INSERT INTO `movimientos_sistema` VALUES ('302', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:24:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('303', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:26:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('304', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:27:17', '3');
INSERT INTO `movimientos_sistema` VALUES ('305', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:35:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('306', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:54:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('307', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:58:19', '3');
INSERT INTO `movimientos_sistema` VALUES ('308', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 19:59:46', '3');
INSERT INTO `movimientos_sistema` VALUES ('309', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:03:08', '3');
INSERT INTO `movimientos_sistema` VALUES ('310', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:05:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('311', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:06:31', '3');
INSERT INTO `movimientos_sistema` VALUES ('312', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:09:40', '3');
INSERT INTO `movimientos_sistema` VALUES ('313', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:16:01', '3');
INSERT INTO `movimientos_sistema` VALUES ('314', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:18:57', '3');
INSERT INTO `movimientos_sistema` VALUES ('315', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:22:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('316', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:25:06', '3');
INSERT INTO `movimientos_sistema` VALUES ('317', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:26:52', '3');
INSERT INTO `movimientos_sistema` VALUES ('318', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:27:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('319', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:29:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('320', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:30:32', '3');
INSERT INTO `movimientos_sistema` VALUES ('321', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:33:53', '3');
INSERT INTO `movimientos_sistema` VALUES ('322', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:39:16', '3');
INSERT INTO `movimientos_sistema` VALUES ('323', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:41:14', '3');
INSERT INTO `movimientos_sistema` VALUES ('324', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:43:21', '3');
INSERT INTO `movimientos_sistema` VALUES ('325', 'Registro de Entrada', 'Entrada GUARDADA por empleado: Em14457', '2014-05-21 20:43:23', '3');
INSERT INTO `movimientos_sistema` VALUES ('326', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:44:49', '3');
INSERT INTO `movimientos_sistema` VALUES ('327', 'Registro de Salida', 'Salida GUARDADA por empleado: Em14457', '2014-05-21 20:44:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('328', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:46:50', '3');
INSERT INTO `movimientos_sistema` VALUES ('329', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:47:25', '3');
INSERT INTO `movimientos_sistema` VALUES ('330', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:48:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('331', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:48:32', '3');
INSERT INTO `movimientos_sistema` VALUES ('332', 'Registro de Salida', 'Salida GUARDADA por empleado: Em14457', '2014-05-21 20:48:34', '3');
INSERT INTO `movimientos_sistema` VALUES ('333', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 20:59:04', '3');
INSERT INTO `movimientos_sistema` VALUES ('334', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 21:00:30', '4');
INSERT INTO `movimientos_sistema` VALUES ('335', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:02:11', '3');
INSERT INTO `movimientos_sistema` VALUES ('336', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:02:27', '3');
INSERT INTO `movimientos_sistema` VALUES ('337', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:04:44', '3');
INSERT INTO `movimientos_sistema` VALUES ('338', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:05:10', '3');
INSERT INTO `movimientos_sistema` VALUES ('339', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:05:57', '3');
INSERT INTO `movimientos_sistema` VALUES ('340', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:06:13', '3');
INSERT INTO `movimientos_sistema` VALUES ('341', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:12:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('342', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:14:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('343', 'Registro de Salida', 'Salida GUARDADA por empleado: Em14457', '2014-05-21 21:15:22', '3');
INSERT INTO `movimientos_sistema` VALUES ('344', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:19:36', '3');
INSERT INTO `movimientos_sistema` VALUES ('345', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:23:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('346', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 21:24:01', '4');
INSERT INTO `movimientos_sistema` VALUES ('347', 'Registro de Salida', 'Salida GUARDADA por administrador: david', '2014-05-21 21:24:19', '4');
INSERT INTO `movimientos_sistema` VALUES ('348', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:36:51', '3');
INSERT INTO `movimientos_sistema` VALUES ('349', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:43:58', '3');
INSERT INTO `movimientos_sistema` VALUES ('350', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:54:42', '3');
INSERT INTO `movimientos_sistema` VALUES ('351', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 21:59:28', '3');
INSERT INTO `movimientos_sistema` VALUES ('352', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 22:00:29', '3');
INSERT INTO `movimientos_sistema` VALUES ('353', 'Login', 'Accedio al Sistema un Empleado registrado como: adal', '2014-05-21 22:01:19', '5');
INSERT INTO `movimientos_sistema` VALUES ('354', 'Login', 'Accedio al Sistema un Empleado registrado como: adal', '2014-05-21 22:02:16', '5');
INSERT INTO `movimientos_sistema` VALUES ('355', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 22:02:32', '4');
INSERT INTO `movimientos_sistema` VALUES ('356', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 22:09:43', '3');
INSERT INTO `movimientos_sistema` VALUES ('357', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 22:10:48', '3');
INSERT INTO `movimientos_sistema` VALUES ('358', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 22:49:41', '3');
INSERT INTO `movimientos_sistema` VALUES ('359', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 22:49:47', '4');
INSERT INTO `movimientos_sistema` VALUES ('360', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 22:51:27', '4');
INSERT INTO `movimientos_sistema` VALUES ('361', 'Login', 'Accedio al Sistema un Empleado registrado como: Em14457', '2014-05-21 22:52:30', '3');
INSERT INTO `movimientos_sistema` VALUES ('362', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 22:52:36', '4');
INSERT INTO `movimientos_sistema` VALUES ('363', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 23:02:49', '4');
INSERT INTO `movimientos_sistema` VALUES ('364', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 23:05:34', '4');
INSERT INTO `movimientos_sistema` VALUES ('365', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 23:06:45', '4');
INSERT INTO `movimientos_sistema` VALUES ('366', 'Login', 'Accedio al Sistema un Administrador registrado como: david', '2014-05-21 23:09:02', '4');

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
INSERT INTO `obra_destino` VALUES ('1', 'Plaza de Toros', 'Resinto Ferial', 'Responsable de obra Juan Carlos Muñoz');

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
INSERT INTO `puesto` VALUES ('1', '1', '');
INSERT INTO `puesto` VALUES ('2', '1', 'Administrador');
INSERT INTO `puesto` VALUES ('3', '2', 'Empleado');

-- ----------------------------
-- Table structure for salida
-- ----------------------------
DROP TABLE IF EXISTS `salida`;
CREATE TABLE `salida` (
  `id_salida` int(10) NOT NULL,
  `fecha_salida` timestamp NULL DEFAULT NULL,
  `unidad` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `obra` int(10) DEFAULT NULL,
  `nota` varchar(255) COLLATE latin1_spanish_ci DEFAULT NULL,
  `num_salidas` int(10) DEFAULT NULL,
  `entrada` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_salida`),
  KEY `FK_OBRA_SAL` (`obra`),
  KEY `FK_ENTRADA` (`entrada`),
  CONSTRAINT `FK_ENTRADA` FOREIGN KEY (`entrada`) REFERENCES `entrada` (`id_entrada`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_OBRA_SAL` FOREIGN KEY (`obra`) REFERENCES `obra_destino` (`id_obra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- ----------------------------
-- Records of salida
-- ----------------------------
INSERT INTO `salida` VALUES ('1', '2014-05-21 20:22:00', 'Metro Cuadrado', '1', '', '1', '7');
INSERT INTO `salida` VALUES ('2', '2014-05-21 20:27:00', 'Metro Cubico', '1', '', '1', '18');
INSERT INTO `salida` VALUES ('3', '2014-05-21 20:27:00', 'Metro Cuadrado', '1', '', '1', '12');
INSERT INTO `salida` VALUES ('4', '2014-05-21 20:29:00', 'Kilogramo', '1', '', '1', '14');
INSERT INTO `salida` VALUES ('5', '2014-05-21 20:30:00', 'Kilogramo', '1', '', '1', '14');
INSERT INTO `salida` VALUES ('6', '2014-05-21 20:30:00', 'Metro Cuadrado', '1', '', '1', '7');
INSERT INTO `salida` VALUES ('7', '2014-05-21 20:31:00', 'Metro', '1', '', '1', '9');
INSERT INTO `salida` VALUES ('8', '2014-05-21 20:31:00', 'Kilogramo', '1', '', '1', '15');
INSERT INTO `salida` VALUES ('9', '2014-05-21 20:32:00', 'Kilogramo', '1', '', '1', '8');
INSERT INTO `salida` VALUES ('10', '2014-05-21 20:33:00', 'Kilogramos', '1', '', '1', '1');
INSERT INTO `salida` VALUES ('11', '2014-05-21 20:43:00', 'Kilogramo', '1', '', '1', '8');
INSERT INTO `salida` VALUES ('12', '2014-05-21 20:44:00', 'Metro', '1', '', '1', '3');
INSERT INTO `salida` VALUES ('13', '2014-05-21 20:48:00', 'Metro Cuadrado', '1', '', '3213', '21');
INSERT INTO `salida` VALUES ('14', '2014-05-21 21:15:00', 'Metro Cubico', '1', 'Para el contador Ramon', '12', '18');
INSERT INTO `salida` VALUES ('15', '2014-05-21 21:24:00', 'Metro', '1', '', '1', '3');
