-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         10.5.9-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para ayspos
CREATE DATABASE IF NOT EXISTS `ayspos` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `ayspos`;

-- Volcando estructura para tabla ayspos.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `Cédula` int(11) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Dirección` varchar(50) DEFAULT NULL,
  `Vendedor` varchar(50) DEFAULT NULL,
  `Plazo` bigint(20) DEFAULT NULL,
  `Dcto` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tabla para el almacenamiento de clientes';

-- Volcando datos para la tabla ayspos.clientes: ~2 rows (aproximadamente)
DELETE FROM `clientes`;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`Cédula`, `Nombre`, `Dirección`, `Vendedor`, `Plazo`, `Dcto`) VALUES
	(1128482946, 'Andr?s Manrique', 'Cra 100 # 47A - 87 br San Javier', 'V1', 4, 30),
	(15372581, 'Leonardo Manrique', 'Cra 64AA # 113 - 96 br Toscana', 'V3', 15, 10);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla ayspos.inventario
CREATE TABLE IF NOT EXISTS `inventario` (
  `Código` varchar(50) DEFAULT NULL,
  `Descripción` varchar(50) DEFAULT NULL,
  `valor` int(20) DEFAULT NULL,
  `Cantidad` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla ayspos.inventario: ~2 rows (aproximadamente)
DELETE FROM `inventario`;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` (`Código`, `Descripción`, `valor`, `Cantidad`) VALUES
	('1', 'Arroz', 1550, NULL),
	('2', 'Panela', 1000, NULL);
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;

-- Volcando estructura para tabla ayspos.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `Código` int(11) NOT NULL,
  `Descripción` varchar(50) NOT NULL DEFAULT '',
  `Valor` double NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Inventario de productos';

-- Volcando datos para la tabla ayspos.productos: ~0 rows (aproximadamente)
DELETE FROM `productos`;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla ayspos.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Usuario` varchar(50) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Contraseña` varchar(50) DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Ingreso de usuarios para el sistem';

-- Volcando datos para la tabla ayspos.usuarios: ~2 rows (aproximadamente)
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`Usuario`, `Nombre`, `Contraseña`, `Tipo`) VALUES
	('admin', 'Andrés Manrique', '0000', 'Administrador'),
	('ventas1', 'Juan José Álvarez', '0000', 'Facturación');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
