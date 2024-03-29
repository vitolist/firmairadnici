-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2024 at 11:00 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `firmairadnici`
--

-- --------------------------------------------------------

--
-- Table structure for table `firme`
--

CREATE TABLE `firme` (
  `id` int(11) NOT NULL,
  `naziv` varchar(32) NOT NULL,
  `pocetak1` time NOT NULL,
  `pocetak2` time NOT NULL,
  `kraj1` time NOT NULL,
  `kraj2` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `firme`
--

INSERT INTO `firme` (`id`, `naziv`, `pocetak1`, `pocetak2`, `kraj1`, `kraj2`) VALUES
(1, 'TSC', '09:00:00', '00:00:00', '17:00:00', '00:00:00'),
(2, 'google', '07:00:00', '00:00:00', '15:00:00', '00:00:00'),
(3, 'apple', '09:00:00', '00:00:00', '16:00:00', '00:00:00'),
(4, 'cwebspace', '07:00:00', '08:00:00', '15:00:00', '16:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `radnici`
--

CREATE TABLE `radnici` (
  `id` int(11) NOT NULL,
  `ime` varchar(32) NOT NULL,
  `prezime` varchar(32) NOT NULL,
  `firma_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `radnici`
--

INSERT INTO `radnici` (`id`, `ime`, `prezime`, `firma_id`) VALUES
(1, 'Lana', 'Bogdanović', 3),
(2, 'Magdalena', 'Barišić', 1),
(3, 'Petar', 'Martinović', 2),
(4, 'Petar', 'Hrastić', 1),
(5, 'Petar', 'Matijević', 1),
(6, 'Šime', 'Marić', 2),
(7, 'Ante', 'Pavić', 2),
(8, 'Laura', 'Hrastić', 2),
(9, 'Lana', 'Krulj', 2),
(10, 'Tomislav', 'Petrović', 2),
(11, 'Sara', 'Hrastić', 1),
(12, 'Fran', 'Petrović', 1),
(13, 'Marija', 'Jurić', 3),
(14, 'Matija', 'Hrastić', 2),
(15, 'Mia', 'Čule', 2),
(16, 'Tina', 'Ivančević', 3),
(17, 'Fran', 'Ivančević', 2),
(18, 'Tomislav', 'Križanac', 2),
(19, 'Borna', 'Marić', 3),
(20, 'Lana', 'Marić', 3),
(21, 'Vito', 'List', 4),
(22, 'Vito', 'List', 2);

-- --------------------------------------------------------

--
-- Table structure for table `radno_vrijeme`
--

CREATE TABLE `radno_vrijeme` (
  `id` int(11) NOT NULL,
  `radnik_id` int(11) NOT NULL,
  `vrijeme` datetime NOT NULL,
  `dolazak` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `radno_vrijeme`
--

INSERT INTO `radno_vrijeme` (`id`, `radnik_id`, `vrijeme`, `dolazak`) VALUES
(615, 1, '2024-01-16 09:00:00', b'1'),
(616, 1, '2024-01-16 15:00:00', b'0'),
(617, 1, '2024-01-17 10:00:00', b'1'),
(618, 1, '2024-01-17 15:00:00', b'0'),
(619, 1, '2024-01-18 07:00:00', b'1'),
(620, 1, '2024-01-18 17:00:00', b'0'),
(621, 1, '2024-01-19 07:00:00', b'1'),
(622, 1, '2024-01-19 16:00:00', b'0'),
(623, 2, '2024-01-16 09:00:00', b'1'),
(624, 2, '2024-01-16 16:00:00', b'0'),
(625, 2, '2024-01-17 10:00:00', b'1'),
(626, 2, '2024-01-17 17:00:00', b'0'),
(627, 2, '2024-01-18 08:00:00', b'1'),
(628, 2, '2024-01-18 16:00:00', b'0'),
(629, 2, '2024-01-19 08:00:00', b'1'),
(630, 2, '2024-01-19 17:00:00', b'0'),
(631, 3, '2024-01-16 07:00:00', b'1'),
(632, 3, '2024-01-16 15:00:00', b'0'),
(633, 3, '2024-01-17 10:00:00', b'1'),
(634, 3, '2024-01-17 15:00:00', b'0'),
(635, 3, '2024-01-18 10:00:00', b'1'),
(636, 3, '2024-01-18 16:00:00', b'0'),
(637, 3, '2024-01-19 07:00:00', b'1'),
(638, 3, '2024-01-19 16:00:00', b'0'),
(639, 4, '2024-01-16 07:00:00', b'1'),
(640, 4, '2024-01-16 17:00:00', b'0'),
(641, 4, '2024-01-17 09:00:00', b'1'),
(642, 4, '2024-01-17 14:00:00', b'0'),
(643, 4, '2024-01-18 09:00:00', b'1'),
(644, 4, '2024-01-18 16:00:00', b'0'),
(645, 4, '2024-01-19 09:00:00', b'1'),
(646, 4, '2024-01-19 17:00:00', b'0'),
(647, 5, '2024-01-16 09:00:00', b'1'),
(648, 5, '2024-01-16 14:00:00', b'0'),
(649, 5, '2024-01-17 08:00:00', b'1'),
(650, 5, '2024-01-17 17:00:00', b'0'),
(651, 5, '2024-01-18 10:00:00', b'1'),
(652, 5, '2024-01-18 14:00:00', b'0'),
(653, 5, '2024-01-19 08:00:00', b'1'),
(654, 5, '2024-01-19 14:00:00', b'0'),
(655, 6, '2024-01-16 09:00:00', b'1'),
(656, 6, '2024-01-16 16:00:00', b'0'),
(657, 6, '2024-01-17 10:00:00', b'1'),
(658, 6, '2024-01-17 15:00:00', b'0'),
(659, 6, '2024-01-18 09:00:00', b'1'),
(660, 6, '2024-01-18 17:00:00', b'0'),
(661, 6, '2024-01-19 08:00:00', b'1'),
(662, 6, '2024-01-19 16:00:00', b'0'),
(663, 7, '2024-01-16 08:00:00', b'1'),
(664, 7, '2024-01-16 14:00:00', b'0'),
(665, 7, '2024-01-17 10:00:00', b'1'),
(666, 7, '2024-01-17 16:00:00', b'0'),
(667, 7, '2024-01-18 07:00:00', b'1'),
(668, 7, '2024-01-18 15:00:00', b'0'),
(669, 7, '2024-01-19 10:00:00', b'1'),
(670, 7, '2024-01-19 15:00:00', b'0'),
(671, 8, '2024-01-16 10:00:00', b'1'),
(672, 8, '2024-01-16 17:00:00', b'0'),
(673, 8, '2024-01-17 07:00:00', b'1'),
(674, 8, '2024-01-17 15:00:00', b'0'),
(675, 8, '2024-01-18 08:00:00', b'1'),
(676, 8, '2024-01-18 15:00:00', b'0'),
(677, 8, '2024-01-19 10:00:00', b'1'),
(678, 8, '2024-01-19 16:00:00', b'0'),
(679, 9, '2024-01-16 09:00:00', b'1'),
(680, 9, '2024-01-16 17:00:00', b'0'),
(681, 9, '2024-01-17 08:00:00', b'1'),
(682, 9, '2024-01-17 16:00:00', b'0'),
(683, 9, '2024-01-18 09:00:00', b'1'),
(684, 9, '2024-01-18 16:00:00', b'0'),
(685, 9, '2024-01-19 07:00:00', b'1'),
(686, 9, '2024-01-19 15:00:00', b'0'),
(687, 10, '2024-01-16 08:00:00', b'1'),
(688, 10, '2024-01-16 17:00:00', b'0'),
(689, 10, '2024-01-17 09:00:00', b'1'),
(690, 10, '2024-01-17 16:00:00', b'0'),
(691, 10, '2024-01-18 10:00:00', b'1'),
(692, 10, '2024-01-18 17:00:00', b'0'),
(693, 10, '2024-01-19 08:00:00', b'1'),
(694, 10, '2024-01-19 15:00:00', b'0'),
(695, 11, '2024-01-16 08:00:00', b'1'),
(696, 11, '2024-01-16 14:00:00', b'0'),
(697, 11, '2024-01-17 07:00:00', b'1'),
(698, 11, '2024-01-17 16:00:00', b'0'),
(699, 11, '2024-01-18 10:00:00', b'1'),
(700, 11, '2024-01-18 14:00:00', b'0'),
(701, 11, '2024-01-19 10:00:00', b'1'),
(702, 11, '2024-01-19 14:00:00', b'0'),
(703, 12, '2024-01-16 09:00:00', b'1'),
(704, 12, '2024-01-16 14:00:00', b'0'),
(705, 12, '2024-01-17 10:00:00', b'1'),
(706, 12, '2024-01-17 15:00:00', b'0'),
(707, 12, '2024-01-18 09:00:00', b'1'),
(708, 12, '2024-01-18 14:00:00', b'0'),
(709, 12, '2024-01-19 10:00:00', b'1'),
(710, 12, '2024-01-19 17:00:00', b'0'),
(711, 13, '2024-01-16 10:00:00', b'1'),
(712, 13, '2024-01-16 17:00:00', b'0'),
(713, 13, '2024-01-17 09:00:00', b'1'),
(714, 13, '2024-01-17 15:00:00', b'0'),
(715, 13, '2024-01-18 08:00:00', b'1'),
(716, 13, '2024-01-18 14:00:00', b'0'),
(717, 13, '2024-01-19 10:00:00', b'1'),
(718, 13, '2024-01-19 16:00:00', b'0'),
(719, 14, '2024-01-16 09:00:00', b'1'),
(720, 14, '2024-01-16 14:00:00', b'0'),
(721, 14, '2024-01-17 10:00:00', b'1'),
(722, 14, '2024-01-17 17:00:00', b'0'),
(723, 14, '2024-01-18 08:00:00', b'1'),
(724, 14, '2024-01-18 15:00:00', b'0'),
(725, 14, '2024-01-19 08:00:00', b'1'),
(726, 14, '2024-01-19 14:00:00', b'0'),
(727, 15, '2024-01-16 10:00:00', b'1'),
(728, 15, '2024-01-16 16:00:00', b'0'),
(729, 15, '2024-01-17 09:00:00', b'1'),
(730, 15, '2024-01-17 14:00:00', b'0'),
(731, 15, '2024-01-18 09:00:00', b'1'),
(732, 15, '2024-01-18 17:00:00', b'0'),
(733, 15, '2024-01-19 10:00:00', b'1'),
(734, 15, '2024-01-19 15:00:00', b'0'),
(735, 16, '2024-01-16 08:00:00', b'1'),
(736, 16, '2024-01-16 17:00:00', b'0'),
(737, 16, '2024-01-17 07:00:00', b'1'),
(738, 16, '2024-01-17 15:00:00', b'0'),
(739, 16, '2024-01-18 09:00:00', b'1'),
(740, 16, '2024-01-18 15:00:00', b'0'),
(741, 16, '2024-01-19 10:00:00', b'1'),
(742, 16, '2024-01-19 15:00:00', b'0'),
(743, 17, '2024-01-16 08:00:00', b'1'),
(744, 17, '2024-01-16 17:00:00', b'0'),
(745, 17, '2024-01-17 07:00:00', b'1'),
(746, 17, '2024-01-17 14:00:00', b'0'),
(747, 17, '2024-01-18 10:00:00', b'1'),
(748, 17, '2024-01-18 15:00:00', b'0'),
(749, 17, '2024-01-19 07:00:00', b'1'),
(750, 17, '2024-01-19 14:00:00', b'0'),
(751, 18, '2024-01-16 08:00:00', b'1'),
(752, 18, '2024-01-16 14:00:00', b'0'),
(753, 18, '2024-01-17 09:00:00', b'1'),
(754, 18, '2024-01-17 15:00:00', b'0'),
(755, 18, '2024-01-18 10:00:00', b'1'),
(756, 18, '2024-01-18 14:00:00', b'0'),
(757, 18, '2024-01-19 10:00:00', b'1'),
(758, 18, '2024-01-19 16:00:00', b'0'),
(759, 19, '2024-01-16 09:00:00', b'1'),
(760, 19, '2024-01-16 17:00:00', b'0'),
(761, 19, '2024-01-17 07:00:00', b'1'),
(762, 19, '2024-01-17 14:00:00', b'0'),
(763, 19, '2024-01-18 09:00:00', b'1'),
(764, 19, '2024-01-18 17:00:00', b'0'),
(765, 19, '2024-01-19 08:00:00', b'1'),
(766, 19, '2024-01-19 15:00:00', b'0'),
(767, 20, '2024-01-16 08:00:00', b'1'),
(768, 20, '2024-01-16 16:00:00', b'0'),
(769, 20, '2024-01-17 09:00:00', b'1'),
(770, 20, '2024-01-17 16:00:00', b'0'),
(771, 20, '2024-01-18 10:00:00', b'1'),
(772, 20, '2024-01-18 17:00:00', b'0'),
(773, 20, '2024-01-19 08:00:00', b'1'),
(774, 20, '2024-01-19 15:00:00', b'0'),
(775, 21, '2024-01-16 08:00:00', b'1'),
(776, 21, '2024-01-16 17:00:00', b'0'),
(777, 21, '2024-01-17 08:00:00', b'1'),
(778, 21, '2024-01-17 15:00:00', b'0'),
(779, 21, '2024-01-18 07:00:00', b'1'),
(780, 21, '2024-01-18 14:00:00', b'0'),
(781, 21, '2024-01-19 07:00:00', b'1'),
(782, 21, '2024-01-19 15:00:00', b'0'),
(783, 22, '2024-01-16 07:00:00', b'1'),
(784, 22, '2024-01-16 16:00:00', b'0'),
(785, 22, '2024-01-17 07:00:00', b'1'),
(786, 22, '2024-01-17 16:00:00', b'0'),
(787, 22, '2024-01-18 08:00:00', b'1'),
(788, 22, '2024-01-18 14:00:00', b'0'),
(789, 22, '2024-01-19 08:00:00', b'1'),
(790, 22, '2024-01-19 15:00:00', b'0'),
(791, 2, '2024-01-16 07:00:00', b'1'),
(792, 3, '2024-01-16 08:00:00', b'1'),
(793, 21, '2024-01-16 08:00:00', b'1'),
(794, 21, '2024-01-16 09:00:00', b'0'),
(795, 2, '2024-01-16 09:00:00', b'1'),
(796, 2, '2024-01-16 17:00:00', b'0'),
(797, 20, '2024-01-20 08:00:00', b'1'),
(798, 20, '2024-01-20 20:00:00', b'0'),
(799, 12, '2024-01-20 00:00:00', b'1'),
(800, 12, '2024-01-20 18:00:00', b'1'),
(801, 1, '2024-01-16 00:00:00', b'1'),
(802, 1, '2024-01-16 11:00:00', b'0'),
(803, 21, '2024-01-16 00:00:00', b'0'),
(804, 6, '2024-01-16 00:00:00', b'1'),
(805, 3, '2024-01-16 00:00:00', b'1'),
(806, 20, '2024-01-16 00:00:00', b'1'),
(807, 20, '2024-01-16 02:00:00', b'0');

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE `test` (
  `id` int(11) NOT NULL,
  `value` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `test`
--

INSERT INTO `test` (`id`, `value`) VALUES
(1, 'test 1'),
(2, '2'),
(3, '3'),
(4, '4'),
(5, '5'),
(6, '6'),
(7, '7'),
(8, '8'),
(9, '9'),
(10, '10'),
(11, '11'),
(12, '12'),
(13, '13'),
(14, '14'),
(15, '15'),
(16, '16'),
(17, '17'),
(18, '18'),
(19, '19');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `firme`
--
ALTER TABLE `firme`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `radnici`
--
ALTER TABLE `radnici`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `radno_vrijeme`
--
ALTER TABLE `radno_vrijeme`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `test`
--
ALTER TABLE `test`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `firme`
--
ALTER TABLE `firme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `radnici`
--
ALTER TABLE `radnici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `radno_vrijeme`
--
ALTER TABLE `radno_vrijeme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=808;

--
-- AUTO_INCREMENT for table `test`
--
ALTER TABLE `test`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
