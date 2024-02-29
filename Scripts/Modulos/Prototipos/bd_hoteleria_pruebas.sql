-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 29-02-2024 a las 16:28:29
-- Versión del servidor: 8.0.32
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_hoteleria_pruebas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

DROP TABLE IF EXISTS `alumnos`;
CREATE TABLE IF NOT EXISTS `alumnos` (
  `carnet_alumno` varchar(15) NOT NULL,
  `nombre_alumno` varchar(45) DEFAULT NULL,
  `direccion_alumno` varchar(45) DEFAULT NULL,
  `telefono_alumno` varchar(45) DEFAULT NULL,
  `email_alumno` varchar(20) DEFAULT NULL,
  `estatus_alumno` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`carnet_alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`carnet_alumno`, `nombre_alumno`, `direccion_alumno`, `telefono_alumno`, `email_alumno`, `estatus_alumno`) VALUES
('1', 'Justin', 'Zona 21', '55554444', 'justin@gmail.com', '1'),
('2', 'Ramos', 'Zona 21', '44445555', 'ramos@gmail.com', '1'),
('3', 'Pennant', 'Zona 2', '55556666', 'pennant@gmail.com', '1'),
('4', 'Emmanuel', 'Zona 21', '88884444', 'emmanuel@gmail.com', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacioncursosalumnos`
--

DROP TABLE IF EXISTS `asignacioncursosalumnos`;
CREATE TABLE IF NOT EXISTS `asignacioncursosalumnos` (
  `codigo_carrera` varchar(5) NOT NULL,
  `codigo_sede` varchar(5) NOT NULL,
  `codigo_jornada` varchar(5) NOT NULL,
  `codigo_seccion` varchar(5) NOT NULL,
  `codigo_aula` varchar(5) NOT NULL,
  `codigo_curso` varchar(5) NOT NULL,
  `carnet_alumno` varchar(15) NOT NULL,
  `nota_asignacioncursoalumnos` float(10,2) DEFAULT NULL,
  PRIMARY KEY (`codigo_carrera`,`codigo_sede`,`codigo_jornada`,`codigo_seccion`,`codigo_aula`,`codigo_curso`,`carnet_alumno`),
  KEY `codigo_sede` (`codigo_sede`),
  KEY `codigo_jornada` (`codigo_jornada`),
  KEY `codigo_seccion` (`codigo_seccion`),
  KEY `codigo_aula` (`codigo_aula`),
  KEY `codigo_curso` (`codigo_curso`),
  KEY `carnet_alumno` (`carnet_alumno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacioncursosmastros`
--

DROP TABLE IF EXISTS `asignacioncursosmastros`;
CREATE TABLE IF NOT EXISTS `asignacioncursosmastros` (
  `codigo_carrera` varchar(5) NOT NULL,
  `codigo_sede` varchar(5) NOT NULL,
  `codigo_jornada` varchar(5) NOT NULL,
  `codigo_seccion` varchar(5) NOT NULL,
  `codigo_aula` varchar(5) NOT NULL,
  `codigo_curso` varchar(5) NOT NULL,
  `codigo_maestro` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`codigo_carrera`,`codigo_sede`,`codigo_jornada`,`codigo_seccion`,`codigo_aula`,`codigo_curso`),
  KEY `codigo_sede` (`codigo_sede`),
  KEY `codigo_jornada` (`codigo_jornada`),
  KEY `codigo_seccion` (`codigo_seccion`),
  KEY `codigo_aula` (`codigo_aula`),
  KEY `codigo_curso` (`codigo_curso`),
  KEY `codigo_maestro` (`codigo_maestro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aulas`
--

DROP TABLE IF EXISTS `aulas`;
CREATE TABLE IF NOT EXISTS `aulas` (
  `codigo_aula` varchar(5) NOT NULL,
  `nombre_aula` varchar(45) DEFAULT NULL,
  `estatus_aula` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_aula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carreras`
--

DROP TABLE IF EXISTS `carreras`;
CREATE TABLE IF NOT EXISTS `carreras` (
  `codigo_carrera` varchar(5) NOT NULL,
  `nombre_carrera` varchar(45) DEFAULT NULL,
  `codigo_facultad` varchar(5) DEFAULT NULL,
  `estatus_carrera` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_carrera`),
  KEY `codigo_facultad` (`codigo_facultad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `concepto`
--

DROP TABLE IF EXISTS `concepto`;
CREATE TABLE IF NOT EXISTS `concepto` (
  `codigo_concepto` varchar(5) NOT NULL,
  `nombre_concepto` varchar(60) DEFAULT NULL,
  `efecto_concepto` varchar(1) DEFAULT NULL,
  `estatus_concepto` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_concepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `concepto`
--

INSERT INTO `concepto` (`codigo_concepto`, `nombre_concepto`, `efecto_concepto`, `estatus_concepto`) VALUES
('1', 'Pruebas', '1', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

DROP TABLE IF EXISTS `cursos`;
CREATE TABLE IF NOT EXISTS `cursos` (
  `codigo_curso` varchar(5) NOT NULL,
  `nombre_curso` varchar(45) DEFAULT NULL,
  `estatus_curso` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_curso`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

DROP TABLE IF EXISTS `departamento`;
CREATE TABLE IF NOT EXISTS `departamento` (
  `codigo_departamento` varchar(5) NOT NULL,
  `nombre_departamento` varchar(80) DEFAULT NULL,
  `estatus_departamento` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`codigo_departamento`, `nombre_departamento`, `estatus_departamento`) VALUES
('1', 'Pruebas]', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

DROP TABLE IF EXISTS `empleado`;
CREATE TABLE IF NOT EXISTS `empleado` (
  `codigo_empleado` varchar(5) NOT NULL,
  `nombre_empleado` varchar(60) DEFAULT NULL,
  `codigo_puesto` varchar(5) DEFAULT NULL,
  `codigo_departamento` varchar(5) DEFAULT NULL,
  `sueldo_empleado` float(10,2) DEFAULT NULL,
  `estatus_empleado` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_empleado`),
  KEY `FK_puestoempleado` (`codigo_puesto`),
  KEY `FK_departamentoempleado` (`codigo_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`codigo_empleado`, `nombre_empleado`, `codigo_puesto`, `codigo_departamento`, `sueldo_empleado`, `estatus_empleado`) VALUES
('1', 'Prueba', '1', '1', 2500.00, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facultades`
--

DROP TABLE IF EXISTS `facultades`;
CREATE TABLE IF NOT EXISTS `facultades` (
  `codigo_facultad` varchar(5) NOT NULL,
  `nombre_facultad` varchar(45) DEFAULT NULL,
  `estatus_facultad` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_facultad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `jornadas`
--

DROP TABLE IF EXISTS `jornadas`;
CREATE TABLE IF NOT EXISTS `jornadas` (
  `codigo_jornada` varchar(5) NOT NULL,
  `nombre_jornada` varchar(45) DEFAULT NULL,
  `estatus_jornada` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_jornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maestros`
--

DROP TABLE IF EXISTS `maestros`;
CREATE TABLE IF NOT EXISTS `maestros` (
  `codigo_maestro` varchar(5) NOT NULL,
  `nombre_maestro` varchar(45) DEFAULT NULL,
  `direccion_maestro` varchar(45) DEFAULT NULL,
  `telefono_maetro` varchar(45) DEFAULT NULL,
  `email_maestro` varchar(20) DEFAULT NULL,
  `estatus_maestro` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_maestro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nominad`
--

DROP TABLE IF EXISTS `nominad`;
CREATE TABLE IF NOT EXISTS `nominad` (
  `codigo_nomina` varchar(5) NOT NULL,
  `codigo_empleado` varchar(5) NOT NULL,
  `codigo_concepto` varchar(5) NOT NULL,
  `valor_nominaD` float(10,2) DEFAULT NULL,
  PRIMARY KEY (`codigo_nomina`,`codigo_empleado`,`codigo_concepto`),
  KEY `FK_conceptonominaD` (`codigo_concepto`),
  KEY `FK_empleadonominaD` (`codigo_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nominad`
--

INSERT INTO `nominad` (`codigo_nomina`, `codigo_empleado`, `codigo_concepto`, `valor_nominaD`) VALUES
('1', '1', '1', 500.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nominae`
--

DROP TABLE IF EXISTS `nominae`;
CREATE TABLE IF NOT EXISTS `nominae` (
  `codigo_nomina` varchar(5) NOT NULL,
  `fecha_inicial_nomina` date DEFAULT NULL,
  `fecha_final_nomina` date DEFAULT NULL,
  PRIMARY KEY (`codigo_nomina`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nominae`
--

INSERT INTO `nominae` (`codigo_nomina`, `fecha_inicial_nomina`, `fecha_final_nomina`) VALUES
('1', '2023-11-21', '2023-11-21'),
('2', '2023-11-22', '2023-11-22'),
('3', '2023-11-23', '2023-11-23');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

DROP TABLE IF EXISTS `puesto`;
CREATE TABLE IF NOT EXISTS `puesto` (
  `codigo_puesto` varchar(5) NOT NULL,
  `nombre_puesto` varchar(60) DEFAULT NULL,
  `estatus_puesto` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_puesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`codigo_puesto`, `nombre_puesto`, `estatus_puesto`) VALUES
('1', 'Pruebas', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `secciones`
--

DROP TABLE IF EXISTS `secciones`;
CREATE TABLE IF NOT EXISTS `secciones` (
  `codigo_seccion` varchar(5) NOT NULL,
  `nombre_seccion` varchar(45) DEFAULT NULL,
  `estatus_seccion` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_seccion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sedes`
--

DROP TABLE IF EXISTS `sedes`;
CREATE TABLE IF NOT EXISTS `sedes` (
  `codigo_sede` varchar(5) NOT NULL,
  `nombre_sede` varchar(45) DEFAULT NULL,
  `estatus_sede` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_sede`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
CREATE TABLE IF NOT EXISTS `tbl_aplicaciones` (
  `pk_id_aplicacion` int NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 'Menu', 'Ingreso Login', 1),
(999, 'Cerrar Sesion', 'Cerrar Sesion', 1),
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(4000, 'MDI LOGISTICA', 'PARA LOGISTICA', 1),
(4001, 'Mant. Movimiento Inventarios', 'Mov. Inv.', 1),
(4002, 'Muestreo', 'Muestreo', 1),
(4003, 'Auditorias', 'Auditoria', 1),
(4004, 'Mantenimientos', 'Mantenimientos', 1),
(4005, 'Mant. Traslados de Producto', 'MTraslados de Producto', 1),
(8000, 'MDI Prototipo', 'Proto', 1),
(8001, 'Crear Cita', 'Crear', 1),
(8002, 'Visualizar Cita', 'Vizualizar', 1),
(8003, 'Reprogramar Cita', 'Reprogramar', 1),
(8004, 'Cancelar Cita', 'Cancelar', 1),
(8005, 'Comprobación de Doc', 'Docs', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacionesperfilsusuario`
--

DROP TABLE IF EXISTS `tbl_asignacionesperfilsusuario`;
CREATE TABLE IF NOT EXISTS `tbl_asignacionesperfilsusuario` (
  `fk_id_usuario` int NOT NULL,
  `fk_id_perfil` int NOT NULL,
  PRIMARY KEY (`fk_id_usuario`,`fk_id_perfil`),
  KEY `fk_id_perfil` (`fk_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_asignacionesperfilsusuario`
--

INSERT INTO `tbl_asignacionesperfilsusuario` (`fk_id_usuario`, `fk_id_perfil`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacionmoduloaplicacion`
--

DROP TABLE IF EXISTS `tbl_asignacionmoduloaplicacion`;
CREATE TABLE IF NOT EXISTS `tbl_asignacionmoduloaplicacion` (
  `fk_id_modulos` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  PRIMARY KEY (`fk_id_modulos`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_asignacionmoduloaplicacion`
--

INSERT INTO `tbl_asignacionmoduloaplicacion` (`fk_id_modulos`, `fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(4000, 4000),
(4000, 4001),
(4000, 4002),
(4000, 4003),
(4000, 4004),
(4000, 4005),
(8000, 8000),
(8000, 8001),
(8000, 8002),
(8000, 8003),
(8000, 8004),
(8000, 8005);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacoradeeventos`
--

DROP TABLE IF EXISTS `tbl_bitacoradeeventos`;
CREATE TABLE IF NOT EXISTS `tbl_bitacoradeeventos` (
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_id_usuario` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_id_usuario` (`fk_id_usuario`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=237 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_bitacoradeeventos`
--

INSERT INTO `tbl_bitacoradeeventos` (`pk_id_bitacora`, `fk_id_usuario`, `fk_id_aplicacion`, `fecha_bitacora`, `hora_bitacora`, `host_bitacora`, `ip_bitacora`, `accion_bitacora`) VALUES
(1, 1, 1, '2023-10-24', '15:44:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(2, 1, 1000, '2023-10-24', '15:45:12', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(3, 1, 999, '2023-10-24', '15:45:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(4, 1, 1, '2023-10-30', '16:15:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(5, 1, 1000, '2023-10-30', '16:15:28', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(6, 1, 1000, '2023-10-30', '16:15:39', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(7, 1, 999, '2023-10-30', '16:15:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(8, 1, 1, '2023-10-30', '16:16:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(9, 1, 999, '2023-10-30', '16:16:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(10, 1, 1, '2023-10-30', '16:18:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(11, 1, 999, '2023-10-30', '16:18:17', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(12, 1, 1, '2023-10-30', '16:18:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(13, 1, 1000, '2023-10-30', '16:18:41', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(14, 1, 1000, '2023-10-30', '16:19:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(15, 1, 999, '2023-10-30', '16:19:37', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(16, 1, 1, '2023-10-30', '16:33:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(17, 1, 999, '2023-10-30', '16:33:57', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(18, 1, 1, '2023-10-30', '16:37:03', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(19, 1, 1000, '2023-10-30', '16:37:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(20, 1, 1000, '2023-10-30', '16:37:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(21, 1, 999, '2023-10-30', '16:37:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(22, 1, 1, '2023-10-30', '16:39:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(23, 1, 999, '2023-10-30', '16:39:24', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(24, 1, 1, '2023-11-02', '15:17:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(25, 1, 1000, '2023-11-02', '15:17:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(26, 1, 1000, '2023-11-02', '15:17:36', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(27, 1, 1000, '2023-11-02', '15:17:47', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(28, 1, 1, '2023-11-02', '15:18:03', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(29, 1, 999, '2023-11-02', '15:18:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(30, 1, 1, '2023-11-03', '17:09:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(31, 1, 4000, '2023-11-03', '17:09:55', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(32, 1, 4000, '2023-11-03', '17:10:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(33, 1, 999, '2023-11-03', '17:10:29', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(34, 1, 1, '2023-11-03', '17:14:46', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(35, 1, 4000, '2023-11-03', '17:14:48', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(36, 1, 999, '2023-11-03', '17:15:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(37, 1, 1, '2023-11-03', '17:17:00', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(38, 1, 4000, '2023-11-03', '17:17:01', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(39, 1, 999, '2023-11-03', '17:17:07', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(40, 1, 1, '2023-11-03', '17:17:42', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(41, 1, 4000, '2023-11-03', '17:17:43', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(42, 1, 999, '2023-11-03', '17:17:50', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(43, 1, 1, '2023-11-03', '17:22:18', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(44, 1, 4000, '2023-11-03', '17:22:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(45, 1, 1, '2023-11-03', '17:26:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(46, 1, 4000, '2023-11-03', '17:26:55', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(47, 1, 1, '2023-11-03', '17:28:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(48, 1, 4000, '2023-11-03', '17:28:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(49, 1, 999, '2023-11-03', '17:29:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(50, 1, 1, '2023-11-03', '17:31:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(51, 1, 4000, '2023-11-03', '17:31:16', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(52, 1, 1, '2023-11-03', '17:37:52', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(53, 1, 4000, '2023-11-03', '17:37:53', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(54, 1, 1, '2023-11-03', '17:40:10', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(55, 1, 4000, '2023-11-03', '17:40:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(56, 1, 4005, '2023-11-03', '17:44:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(57, 1, 4005, '2023-11-03', '17:44:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Consulta'),
(58, 1, 4005, '2023-11-03', '17:44:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Consulta'),
(59, 1, 4005, '2023-11-03', '17:46:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Reportes'),
(60, 1, 1, '2023-11-03', '17:46:33', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(61, 1, 4000, '2023-11-03', '17:46:34', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(62, 1, 4005, '2023-11-03', '17:47:52', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Modificar'),
(63, 1, 4005, '2023-11-03', '17:49:33', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(64, 1, 4005, '2023-11-03', '17:50:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Eliminar'),
(65, 1, 999, '2023-11-03', '17:51:53', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(66, 1, 1, '2023-11-03', '18:49:32', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(67, 1, 4000, '2023-11-03', '18:49:34', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(68, 1, 1, '2023-11-03', '18:51:30', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(69, 1, 4000, '2023-11-03', '18:51:31', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(70, 1, 1, '2023-11-03', '18:53:03', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(71, 1, 4000, '2023-11-03', '18:53:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(72, 1, 1, '2023-11-03', '18:56:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(73, 1, 4000, '2023-11-03', '18:56:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(74, 1, 1, '2023-11-03', '18:57:42', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(75, 1, 4000, '2023-11-03', '18:57:43', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(76, 1, 999, '2023-11-03', '18:58:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(77, 1, 1, '2023-11-07', '07:24:56', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(78, 1, 4000, '2023-11-07', '07:24:57', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(79, 1, 999, '2023-11-07', '07:25:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(80, 1, 1, '2023-11-07', '07:39:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(81, 1, 4000, '2023-11-07', '07:40:01', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(82, 1, 4000, '2023-11-07', '07:40:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(83, 1, 999, '2023-11-07', '07:41:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(84, 1, 1, '2023-11-07', '07:53:38', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(85, 1, 4000, '2023-11-07', '07:53:39', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(86, 1, 4005, '2023-11-07', '07:55:41', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(87, 1, 4005, '2023-11-07', '07:58:01', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Eliminar'),
(88, 1, 999, '2023-11-07', '07:58:21', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(89, 1, 1, '2023-11-07', '15:31:51', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(90, 1, 4000, '2023-11-07', '15:31:57', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(91, 1, 1, '2023-11-07', '15:32:44', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(92, 1, 4000, '2023-11-07', '15:32:46', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(93, 1, 999, '2023-11-07', '15:32:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(94, 1, 1, '2023-11-07', '15:47:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(95, 1, 4000, '2023-11-07', '15:47:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(96, 1, 999, '2023-11-07', '15:48:30', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(97, 1, 1, '2023-11-07', '15:49:01', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(98, 1, 4000, '2023-11-07', '15:49:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(99, 1, 999, '2023-11-07', '15:49:27', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(100, 1, 1, '2023-11-07', '16:10:47', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(101, 1, 4000, '2023-11-07', '16:10:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(102, 1, 4005, '2023-11-07', '16:11:36', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Modificar'),
(103, 1, 4005, '2023-11-07', '16:12:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Modificar'),
(104, 1, 4005, '2023-11-07', '16:12:42', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(105, 1, 999, '2023-11-07', '16:13:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(106, 1, 1, '2023-11-07', '16:18:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(107, 1, 4000, '2023-11-07', '16:19:00', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(108, 1, 4000, '2023-11-07', '16:19:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(109, 1, 4005, '2023-11-07', '16:20:01', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Eliminar'),
(110, 1, 999, '2023-11-07', '16:20:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(111, 1, 1, '2023-11-07', '17:53:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(112, 1, 4000, '2023-11-07', '17:53:50', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(113, 1, 4005, '2023-11-07', '17:54:45', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(114, 1, 999, '2023-11-07', '17:55:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(115, 1, 1, '2023-11-07', '18:12:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(116, 1, 4000, '2023-11-07', '18:13:00', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(117, 1, 999, '2023-11-07', '18:13:12', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(118, 1, 1, '2023-11-07', '18:15:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(119, 1, 4000, '2023-11-07', '18:15:05', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(120, 1, 999, '2023-11-07', '18:15:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(121, 1, 1, '2023-11-07', '18:28:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(122, 1, 4000, '2023-11-07', '18:28:07', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(123, 1, 999, '2023-11-07', '18:28:38', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(124, 1, 1, '2023-11-07', '18:33:20', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(125, 1, 4000, '2023-11-07', '18:33:21', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(126, 1, 999, '2023-11-07', '18:34:10', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(127, 1, 1, '2023-11-09', '07:34:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(128, 1, 4000, '2023-11-09', '07:34:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(129, 1, 999, '2023-11-09', '07:34:23', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(130, 1, 1, '2023-11-09', '07:38:17', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(131, 1, 4000, '2023-11-09', '07:38:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(132, 1, 999, '2023-11-09', '07:38:53', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(133, 1, 1, '2023-11-09', '08:17:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(134, 1, 4000, '2023-11-09', '08:17:05', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(135, 1, 999, '2023-11-09', '08:17:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(136, 1, 1, '2023-11-09', '08:36:17', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(137, 1, 4000, '2023-11-09', '08:36:18', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(138, 1, 4005, '2023-11-09', '08:36:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(139, 1, 4005, '2023-11-09', '08:37:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Modificar'),
(140, 1, 4005, '2023-11-09', '08:37:26', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Eliminar'),
(141, 1, 999, '2023-11-09', '08:38:03', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(142, 1, 1, '2023-11-10', '07:03:44', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(143, 1, 4000, '2023-11-10', '07:03:45', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(144, 1, 999, '2023-11-10', '07:03:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(145, 1, 1, '2023-11-10', '07:26:48', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(146, 1, 1000, '2023-11-10', '07:26:50', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(147, 1, 999, '2023-11-10', '07:27:20', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(148, 1, 1, '2023-11-10', '07:44:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(149, 1, 4000, '2023-11-10', '07:44:20', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(150, 1, 4005, '2023-11-10', '07:45:56', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Guardar'),
(151, 1, 4005, '2023-11-10', '07:46:11', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Modificar'),
(152, 1, 999, '2023-11-10', '07:47:32', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(153, 1, 1, '2023-11-21', '08:32:18', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(154, 1, 4000, '2023-11-21', '08:32:21', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(155, 1, 999, '2023-11-21', '08:32:27', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(156, 1, 1, '2023-11-21', '08:34:16', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(157, 1, 4000, '2023-11-21', '08:34:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(158, 1, 1000, '2023-11-21', '08:34:26', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(159, 1, 999, '2023-11-21', '08:34:28', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(160, 1, 1, '2023-11-21', '08:37:48', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(161, 1, 999, '2023-11-21', '08:37:53', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(162, 1, 1, '2023-11-21', '08:38:34', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(163, 1, 999, '2023-11-21', '08:38:38', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(164, 1, 1, '2023-11-21', '08:39:55', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(165, 1, 999, '2023-11-21', '08:40:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(166, 1, 1, '2023-11-21', '08:40:30', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(167, 1, 999, '2023-11-21', '08:40:32', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(168, 1, 1, '2023-11-21', '08:41:07', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(169, 1, 4000, '2023-11-21', '08:41:08', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(170, 1, 999, '2023-11-21', '08:41:10', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(171, 1, 1, '2023-11-21', '08:42:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(172, 1, 4000, '2023-11-21', '08:42:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(173, 1, 999, '2023-11-21', '08:42:07', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(174, 1, 1, '2023-11-21', '08:49:02', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(175, 1, 4000, '2023-11-21', '08:49:03', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(176, 1, 999, '2023-11-21', '08:49:19', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(177, 1, 1, '2023-11-21', '09:08:25', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(178, 1, 4000, '2023-11-21', '09:08:26', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(179, 1, 999, '2023-11-21', '09:09:48', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(180, 1, 1, '2023-11-21', '09:10:58', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(181, 1, 4000, '2023-11-21', '09:10:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(182, 1, 4000, '2023-11-21', '09:12:22', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(183, 1, 999, '2023-11-21', '09:12:29', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(184, 1, 1, '2023-11-21', '09:12:35', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(185, 1, 999, '2023-11-21', '09:12:36', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(186, 1, 1, '2023-11-21', '09:17:05', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(187, 1, 4000, '2023-11-21', '09:17:06', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(188, 1, 999, '2023-11-21', '09:17:47', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(189, 1, 1, '2023-11-21', '09:22:10', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(190, 1, 4000, '2023-11-21', '09:22:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(191, 1, 999, '2023-11-21', '09:23:00', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(192, 1, 1, '2023-11-21', '09:25:25', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(193, 1, 1000, '2023-11-21', '09:25:27', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(194, 1, 999, '2023-11-21', '09:26:09', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(195, 1, 1, '2023-11-21', '09:30:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(196, 1, 4000, '2023-11-21', '09:30:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(197, 1, 1000, '2023-11-21', '09:31:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(198, 1, 999, '2023-11-21', '09:32:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(199, 1, 1, '2023-11-21', '09:35:54', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(200, 1, 4000, '2023-11-21', '09:35:55', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(201, 1, 1000, '2023-11-21', '09:36:31', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(202, 1, 999, '2023-11-21', '09:36:47', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(203, 1, 1, '2023-11-21', '09:36:57', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(204, 1, 4000, '2023-11-21', '09:36:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Inventarios'),
(205, 1, 1000, '2023-11-21', '09:37:14', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(206, 1, 999, '2023-11-21', '09:37:24', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(207, 1, 1, '2024-02-20', '17:42:33', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(208, 1, 1000, '2024-02-20', '17:42:40', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(209, 1, 999, '2024-02-20', '17:42:43', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Cerro Sesion'),
(210, 1, 1, '2024-02-20', '17:52:29', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(211, 1, 1000, '2024-02-20', '17:52:41', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(212, 1, 1, '2024-02-20', '17:53:15', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(213, 1, 1, '2024-02-20', '17:56:57', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(214, 1, 1000, '2024-02-20', '17:56:59', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(215, 1, 1, '2024-02-20', '17:57:13', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(216, 1, 1000, '2024-02-20', '17:57:21', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(217, 1, 1, '2024-02-20', '18:01:48', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(218, 1, 1000, '2024-02-20', '18:02:00', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Seguridad'),
(219, 1, 1, '2024-02-20', '18:15:41', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(220, 1, 1, '2024-02-20', '18:17:04', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(221, 1, 1, '2024-02-20', '19:17:18', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(222, 1, 1, '2024-02-20', '19:21:37', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(223, 1, 1, '2024-02-20', '19:33:31', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(224, 1, 1, '2024-02-20', '19:34:52', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(225, 1, 1, '2024-02-20', '19:36:52', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(226, 1, 1, '2024-02-20', '19:40:18', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(227, 1, 1, '2024-02-20', '20:24:27', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(228, 1, 1, '2024-02-21', '17:06:37', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(229, 1, 1, '2024-02-21', '17:35:30', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(230, 1, 1, '2024-02-21', '18:06:23', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(231, 1, 1, '2024-02-21', '18:07:46', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(232, 1, 1, '2024-02-21', '18:10:36', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(233, 1, 1, '2024-02-29', '09:58:49', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(234, 1, 1, '2024-02-29', '10:12:31', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(235, 1, 1, '2024-02-29', '10:17:42', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login'),
(236, 1, 1, '2024-02-29', '10:18:26', 'DESKTOP-132J629', 'fe80::1257:3da6:f2da:249f%6', 'Ingreso Login');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallesmovimiento`
--

DROP TABLE IF EXISTS `tbl_detallesmovimiento`;
CREATE TABLE IF NOT EXISTS `tbl_detallesmovimiento` (
  `Pk_DocumentoID` int NOT NULL,
  `Pk_AlmacenID` varchar(50) NOT NULL,
  `Doc_Numero` varchar(50) NOT NULL,
  `Doc_Fecha` varchar(50) NOT NULL,
  `Pk_ProductoID` varchar(50) NOT NULL,
  `Prod_Nombre` varchar(50) NOT NULL,
  `DetMov_Cantidad` varchar(50) NOT NULL,
  `Det_MovCostoTotal` varchar(50) NOT NULL,
  `Prod_PrecioUnitario` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Pk_DocumentoID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_detallesmovimiento`
--

INSERT INTO `tbl_detallesmovimiento` (`Pk_DocumentoID`, `Pk_AlmacenID`, `Doc_Numero`, `Doc_Fecha`, `Pk_ProductoID`, `Prod_Nombre`, `DetMov_Cantidad`, `Det_MovCostoTotal`, `Prod_PrecioUnitario`) VALUES
(2, 'Alm2', '002', '2023-11-07', 'Prod2', 'Producto 2', '15', '150.00', '10.00'),
(3, 'Alm3', '003', '2023-11-07', 'Prod3', 'Producto 3', '20', '200.00', '10.00'),
(4, 'Alm5', '004', '2023-11-09', 'Prod4', 'Producto 4', '5', '250', '50.00'),
(5, 'Hola', '005', '2023-11-10', 'Prod5', 'Producto 5', '40', '200', '5.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_estados`
--

DROP TABLE IF EXISTS `tbl_estados`;
CREATE TABLE IF NOT EXISTS `tbl_estados` (
  `pk_id_estado` int NOT NULL AUTO_INCREMENT,
  `est_info_estado` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `est_num_estado` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_estados`
--

INSERT INTO `tbl_estados` (`pk_id_estado`, `est_info_estado`, `est_num_estado`) VALUES
(1, 'Activo', 1),
(2, 'Eliminado', 2),
(3, 'Modificado', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulos`
--

DROP TABLE IF EXISTS `tbl_modulos`;
CREATE TABLE IF NOT EXISTS `tbl_modulos` (
  `pk_id_modulos` int NOT NULL,
  `nombre_modulo` varchar(50) NOT NULL,
  `descripcion_modulo` varchar(150) NOT NULL,
  `estado_modulo` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_modulos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(4000, 'LOGISTICA', 'Inventario', 1),
(8000, 'Prototipo', 'Prototipo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfiles`
--

DROP TABLE IF EXISTS `tbl_perfiles`;
CREATE TABLE IF NOT EXISTS `tbl_perfiles` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) NOT NULL,
  `descripcion_perfil` varchar(150) NOT NULL,
  `estado_perfil` tinyint DEFAULT '0',
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisosaplicacionesusuario`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionesusuario`;
CREATE TABLE IF NOT EXISTS `tbl_permisosaplicacionesusuario` (
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_usuario` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_aplicacion`,`fk_id_usuario`),
  KEY `fk_id_usuario` (`fk_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_permisosaplicacionperfil`
--

DROP TABLE IF EXISTS `tbl_permisosaplicacionperfil`;
CREATE TABLE IF NOT EXISTS `tbl_permisosaplicacionperfil` (
  `fk_id_perfil` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `guardar_permiso` tinyint(1) DEFAULT '0',
  `modificar_permiso` tinyint(1) DEFAULT '0',
  `eliminar_permiso` tinyint(1) DEFAULT '0',
  `buscar_permiso` tinyint(1) DEFAULT '0',
  `imprimir_permiso` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`fk_id_perfil`,`fk_id_aplicacion`),
  KEY `fk_id_aplicacion` (`fk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_permisosaplicacionperfil`
--

INSERT INTO `tbl_permisosaplicacionperfil` (`fk_id_perfil`, `fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1000, 1, 1, 1, 1, 1),
(1, 1001, 1, 1, 1, 1, 1),
(1, 1002, 1, 1, 1, 1, 1),
(1, 1003, 1, 1, 1, 1, 1),
(1, 1004, 1, 1, 1, 1, 1),
(1, 1101, 1, 1, 1, 1, 1),
(1, 1102, 1, 1, 1, 1, 1),
(1, 1103, 1, 1, 1, 1, 1),
(1, 1201, 1, 1, 1, 1, 1),
(1, 1301, 1, 1, 1, 1, 1),
(1, 4000, 1, 1, 1, 1, 1),
(1, 4001, 1, 1, 1, 1, 1),
(1, 4002, 1, 1, 1, 1, 1),
(1, 4003, 1, 1, 1, 1, 1),
(1, 4004, 1, 1, 1, 1, 1),
(1, 4005, 1, 1, 1, 1, 1),
(1, 8000, 1, 1, 1, 1, 1),
(1, 8001, 1, 1, 1, 1, 1),
(1, 8002, 1, 1, 1, 1, 1),
(1, 8003, 1, 1, 1, 1, 1),
(1, 8004, 1, 1, 1, 1, 1),
(1, 8005, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pruebapasaporte`
--

DROP TABLE IF EXISTS `tbl_pruebapasaporte`;
CREATE TABLE IF NOT EXISTS `tbl_pruebapasaporte` (
  `Pk_id_persona` int NOT NULL AUTO_INCREMENT,
  `nombre_persona` varchar(100) NOT NULL,
  `dpi_persona` varchar(50) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `lugar_nacimiento` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_persona`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_pruebapasaporte`
--

INSERT INTO `tbl_pruebapasaporte` (`Pk_id_persona`, `nombre_persona`, `dpi_persona`, `fecha_nacimiento`, `lugar_nacimiento`) VALUES
(1, 'Prueba Corta', '0101', '1990-01-01', 'Ciudad de Guatemala'),
(2, 'Segunda Prueba', '0102', '2002-01-01', 'Ciudad de Guatemala'),
(3, 'Tercera Prueba', '0103', '2002-02-01', 'Ciudad de Guatemala');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pruebatraslado`
--

DROP TABLE IF EXISTS `tbl_pruebatraslado`;
CREATE TABLE IF NOT EXISTS `tbl_pruebatraslado` (
  `Pk_DocumentoID` int NOT NULL,
  `Pk_AlmacenID` varchar(50) NOT NULL,
  `Doc_Numero` varchar(50) NOT NULL,
  `Doc_Fecha` varchar(50) NOT NULL,
  `Pk_ProductoID` varchar(50) NOT NULL,
  `Prod_Nombre` varchar(50) NOT NULL,
  `DetMov_Cantidad` varchar(50) NOT NULL,
  `Det_MovCostoTotal` varchar(50) NOT NULL,
  `Prod_PrecioUnitario` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Pk_DocumentoID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_pruebatraslado`
--

INSERT INTO `tbl_pruebatraslado` (`Pk_DocumentoID`, `Pk_AlmacenID`, `Doc_Numero`, `Doc_Fecha`, `Pk_ProductoID`, `Prod_Nombre`, `DetMov_Cantidad`, `Det_MovCostoTotal`, `Prod_PrecioUnitario`) VALUES
(4, 'Almacen4', 'Doc4', '2023-11-7', '3', 'Prueba3', '25', '625', '25'),
(5, 'Almacen5', 'Doc5', '2023-11-7', '5', 'Prueba5', '1', '25', '25'),
(6, 'AlmacenA', 'Doc6', '2023-11-7', '6', 'Prueba6', '4', '200', '50'),
(7, 'AlmacenB', 'Doc7', '2023-11-7', '7', 'Prueba7', '10', '200', '20');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reportes`
--

DROP TABLE IF EXISTS `tbl_reportes`;
CREATE TABLE IF NOT EXISTS `tbl_reportes` (
  `pk_id_reporte` int NOT NULL AUTO_INCREMENT,
  `rep_correlativo` int DEFAULT NULL,
  `rep_nombre` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `fk_estado` int DEFAULT NULL,
  `rep_fecha` datetime DEFAULT NULL,
  `rep_archivo` varchar(120) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `rep_fechaMod` datetime DEFAULT NULL,
  PRIMARY KEY (`pk_id_reporte`),
  UNIQUE KEY `rep_correlativo` (`rep_correlativo`),
  KEY `fk_estado` (`fk_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

--
-- Volcado de datos para la tabla `tbl_reportes`
--

INSERT INTO `tbl_reportes` (`pk_id_reporte`, `rep_correlativo`, `rep_nombre`, `fk_estado`, `rep_fecha`, `rep_archivo`, `rep_fechaMod`) VALUES
(10, 10002, 'planilssla.txt', 1, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuarios`
--

DROP TABLE IF EXISTS `tbl_usuarios`;
CREATE TABLE IF NOT EXISTS `tbl_usuarios` (
  `pk_id_usuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `apellido_usuario` varchar(50) NOT NULL,
  `username_usuario` varchar(20) NOT NULL,
  `password_usuario` varchar(100) NOT NULL,
  `email_usuario` varchar(50) NOT NULL,
  `estado_usuario` tinyint NOT NULL DEFAULT '0',
  `pregunta` varchar(50) NOT NULL,
  `respuesta` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', 1, 'COLOR FAVORITO', 'X9yc1/l1b2A=');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_aplicacionusuario`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_aplicacionusuario`;
CREATE TABLE IF NOT EXISTS `vista_aplicacionusuario` (
`Aplicacion` int
,`ID` int
,`Usuario` varchar(50)
,`Insertar` tinyint(1)
,`Editar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_aplicacion_perfil`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_aplicacion_perfil`;
CREATE TABLE IF NOT EXISTS `vista_aplicacion_perfil` (
`ID` int
,`Perfil` varchar(50)
,`Aplicacion` int
,`Insertar` tinyint(1)
,`Modificar` tinyint(1)
,`Eliminar` tinyint(1)
,`Buscar` tinyint(1)
,`Reporte` tinyint(1)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_modulo_aplicacion`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_modulo_aplicacion`;
CREATE TABLE IF NOT EXISTS `vista_modulo_aplicacion` (
`ID` int
,`Modulo` varchar(50)
,`Aplicacion` int
,`Nombre` varchar(50)
,`Descripcion` varchar(150)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_perfil_usuario`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `vista_perfil_usuario`;
CREATE TABLE IF NOT EXISTS `vista_perfil_usuario` (
`ID` int
,`Usuario` varchar(50)
,`nickName` varchar(20)
,`perfil` int
,`Nombre` varchar(50)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_aplicacionusuario`
--
DROP TABLE IF EXISTS `vista_aplicacionusuario`;

DROP VIEW IF EXISTS `vista_aplicacionusuario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_aplicacionusuario`  AS SELECT `b`.`fk_id_aplicacion` AS `Aplicacion`, `b`.`fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Editar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisosaplicacionesusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_aplicacion_perfil`
--
DROP TABLE IF EXISTS `vista_aplicacion_perfil`;

DROP VIEW IF EXISTS `vista_aplicacion_perfil`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_aplicacion_perfil`  AS SELECT `b`.`fk_id_perfil` AS `ID`, `a`.`nombre_perfil` AS `Perfil`, `b`.`fk_id_aplicacion` AS `Aplicacion`, `b`.`guardar_permiso` AS `Insertar`, `b`.`modificar_permiso` AS `Modificar`, `b`.`eliminar_permiso` AS `Eliminar`, `b`.`buscar_permiso` AS `Buscar`, `b`.`imprimir_permiso` AS `Reporte` FROM (`tbl_permisosaplicacionperfil` `b` join `tbl_perfiles` `a` on((`a`.`pk_id_perfil` = `b`.`fk_id_perfil`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_modulo_aplicacion`
--
DROP TABLE IF EXISTS `vista_modulo_aplicacion`;

DROP VIEW IF EXISTS `vista_modulo_aplicacion`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_modulo_aplicacion`  AS SELECT `b`.`fk_id_modulos` AS `ID`, `a`.`nombre_modulo` AS `Modulo`, `b`.`fk_id_aplicacion` AS `Aplicacion`, `c`.`nombre_aplicacion` AS `Nombre`, `c`.`descripcion_aplicacion` AS `Descripcion` FROM ((`tbl_asignacionmoduloaplicacion` `b` join `tbl_modulos` `a` on((`a`.`pk_id_modulos` = `b`.`fk_id_modulos`))) join `tbl_aplicaciones` `c` on((`c`.`pk_id_aplicacion` = `b`.`fk_id_aplicacion`)))  ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_perfil_usuario`
--
DROP TABLE IF EXISTS `vista_perfil_usuario`;

DROP VIEW IF EXISTS `vista_perfil_usuario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_perfil_usuario`  AS SELECT `b`.`fk_id_usuario` AS `ID`, `a`.`nombre_usuario` AS `Usuario`, `a`.`username_usuario` AS `nickName`, `b`.`fk_id_perfil` AS `perfil`, `c`.`nombre_perfil` AS `Nombre` FROM ((`tbl_asignacionesperfilsusuario` `b` join `tbl_usuarios` `a` on((`a`.`pk_id_usuario` = `b`.`fk_id_usuario`))) join `tbl_perfiles` `c` on((`c`.`pk_id_perfil` = `b`.`fk_id_perfil`)))  ;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asignacioncursosalumnos`
--
ALTER TABLE `asignacioncursosalumnos`
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_1` FOREIGN KEY (`codigo_carrera`) REFERENCES `carreras` (`codigo_carrera`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_2` FOREIGN KEY (`codigo_sede`) REFERENCES `sedes` (`codigo_sede`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_3` FOREIGN KEY (`codigo_jornada`) REFERENCES `jornadas` (`codigo_jornada`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_4` FOREIGN KEY (`codigo_seccion`) REFERENCES `secciones` (`codigo_seccion`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_5` FOREIGN KEY (`codigo_aula`) REFERENCES `aulas` (`codigo_aula`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_6` FOREIGN KEY (`codigo_curso`) REFERENCES `cursos` (`codigo_curso`),
  ADD CONSTRAINT `asignacioncursosalumnos_ibfk_7` FOREIGN KEY (`carnet_alumno`) REFERENCES `alumnos` (`carnet_alumno`);

--
-- Filtros para la tabla `asignacioncursosmastros`
--
ALTER TABLE `asignacioncursosmastros`
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_1` FOREIGN KEY (`codigo_carrera`) REFERENCES `carreras` (`codigo_carrera`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_2` FOREIGN KEY (`codigo_sede`) REFERENCES `sedes` (`codigo_sede`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_3` FOREIGN KEY (`codigo_jornada`) REFERENCES `jornadas` (`codigo_jornada`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_4` FOREIGN KEY (`codigo_seccion`) REFERENCES `secciones` (`codigo_seccion`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_5` FOREIGN KEY (`codigo_aula`) REFERENCES `aulas` (`codigo_aula`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_6` FOREIGN KEY (`codigo_curso`) REFERENCES `cursos` (`codigo_curso`),
  ADD CONSTRAINT `asignacioncursosmastros_ibfk_7` FOREIGN KEY (`codigo_maestro`) REFERENCES `maestros` (`codigo_maestro`);

--
-- Filtros para la tabla `carreras`
--
ALTER TABLE `carreras`
  ADD CONSTRAINT `carreras_ibfk_1` FOREIGN KEY (`codigo_facultad`) REFERENCES `facultades` (`codigo_facultad`);

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `FK_departamentoempleado` FOREIGN KEY (`codigo_departamento`) REFERENCES `departamento` (`codigo_departamento`),
  ADD CONSTRAINT `FK_puestoempleado` FOREIGN KEY (`codigo_puesto`) REFERENCES `puesto` (`codigo_puesto`);

--
-- Filtros para la tabla `nominad`
--
ALTER TABLE `nominad`
  ADD CONSTRAINT `FK_conceptonominaD` FOREIGN KEY (`codigo_concepto`) REFERENCES `concepto` (`codigo_concepto`),
  ADD CONSTRAINT `FK_empleadonominaD` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleado` (`codigo_empleado`),
  ADD CONSTRAINT `FK_nominaEnominaD` FOREIGN KEY (`codigo_nomina`) REFERENCES `nominae` (`codigo_nomina`);

--
-- Filtros para la tabla `tbl_asignacionesperfilsusuario`
--
ALTER TABLE `tbl_asignacionesperfilsusuario`
  ADD CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  ADD CONSTRAINT `tbl_asignacionesperfilsusuario_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`);

--
-- Filtros para la tabla `tbl_asignacionmoduloaplicacion`
--
ALTER TABLE `tbl_asignacionmoduloaplicacion`
  ADD CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_1` FOREIGN KEY (`fk_id_modulos`) REFERENCES `tbl_modulos` (`pk_id_modulos`),
  ADD CONSTRAINT `tbl_asignacionmoduloaplicacion_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_bitacoradeeventos`
--
ALTER TABLE `tbl_bitacoradeeventos`
  ADD CONSTRAINT `tbl_bitacoradeeventos_ibfk_1` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  ADD CONSTRAINT `tbl_bitacoradeeventos_ibfk_2` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`);

--
-- Filtros para la tabla `tbl_permisosaplicacionesusuario`
--
ALTER TABLE `tbl_permisosaplicacionesusuario`
  ADD CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisosaplicacionesusuario_ibfk_2` FOREIGN KEY (`fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`);

--
-- Filtros para la tabla `tbl_permisosaplicacionperfil`
--
ALTER TABLE `tbl_permisosaplicacionperfil`
  ADD CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_1` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`),
  ADD CONSTRAINT `tbl_permisosaplicacionperfil_ibfk_2` FOREIGN KEY (`fk_id_perfil`) REFERENCES `tbl_perfiles` (`pk_id_perfil`);

--
-- Filtros para la tabla `tbl_reportes`
--
ALTER TABLE `tbl_reportes`
  ADD CONSTRAINT `tbl_reportes_ibfk_1` FOREIGN KEY (`fk_estado`) REFERENCES `tbl_estados` (`pk_id_estado`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
