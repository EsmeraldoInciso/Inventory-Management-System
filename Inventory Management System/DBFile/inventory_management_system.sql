-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 18, 2025 at 07:24 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category_name`) VALUES
(1, 'Coffee Beans'),
(2, 'Beverages'),
(3, 'Sample Category'),
(4, 'Milk Powder'),
(5, 'Food');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_id` int(11) NOT NULL,
  `item_code` varchar(50) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `description` text DEFAULT NULL,
  `price` double(10,2) NOT NULL DEFAULT 0.00,
  `category_id` int(11) DEFAULT NULL,
  `unit` varchar(50) DEFAULT NULL,
  `reorder_level` int(11) DEFAULT 0,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`item_id`, `item_code`, `item_name`, `description`, `price`, `category_id`, `unit`, `reorder_level`, `created_at`, `updated_at`) VALUES
(1, 'C001', 'Stick', 'Nescafe Stick', 6.00, 1, 'Pcs', 10, '2025-08-11 19:39:42', '2025-10-16 16:46:30'),
(2, 'M001', 'Gatas', 'Bear Brand', 16.00, 4, 'Pack', 10, '2025-08-15 18:15:18', '2025-09-29 16:52:21'),
(3, 'C002', 'Kape', 'barako', 90.00, 1, 'Bag', 10, '2025-08-21 17:02:54', '2025-09-29 16:52:52'),
(4, 'S001', 'Sugar', 'Brown', 30.00, 3, 'Pack', 10, '2025-10-15 15:05:05', '2025-10-15 15:05:05');

--
-- Triggers `items`
--
DELIMITER $$
CREATE TRIGGER `after_item_insert` AFTER INSERT ON `items` FOR EACH ROW BEGIN
    INSERT INTO stock_levels (item_id, quantity_on_hand)
    VALUES (NEW.item_id, 0);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `log_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `action` varchar(50) NOT NULL,
  `description` text DEFAULT NULL,
  `table_name` varchar(50) DEFAULT NULL,
  `record_id` int(11) DEFAULT NULL,
  `timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`log_id`, `user_id`, `action`, `description`, `table_name`, `record_id`, `timestamp`) VALUES
(1, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:33:02'),
(2, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:34:54'),
(3, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:35:06'),
(4, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:46:54'),
(5, 1, 'STOCK-IN', 'Added 20  of Stick', 'stock_movements', NULL, '2025-08-13 04:47:43'),
(6, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:51:31'),
(7, 1, 'STOCK-OUT', 'Removed 30  of Stick', 'stock_movements', NULL, '2025-08-13 04:52:11'),
(8, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:52:58'),
(9, 1, 'STOCK-OUT', 'Removed 10  of Stick', 'stock_movements', NULL, '2025-08-13 04:53:13'),
(10, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:54:15'),
(11, 1, 'STOCK-OUT', 'Removed 10 Pcs of Stick', 'stock_movements', NULL, '2025-08-13 04:54:28'),
(12, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:56:44'),
(13, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 04:58:40'),
(14, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:01:56'),
(15, 1, 'STOCK-IN', 'Updated entry: 10', 'stock_movements', NULL, '2025-08-13 05:02:19'),
(16, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:08:04'),
(17, 1, 'UPDATE ITEM', 'Updated item: Sticks', 'items', 1, '2025-08-13 05:08:41'),
(18, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:11:07'),
(19, 1, 'UPDATE ITEM', 'Updated item: Stick with id of 1', 'items', 1, '2025-08-13 05:11:17'),
(20, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:12:12'),
(21, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:16:02'),
(22, 1, 'ADD CATEGORY', 'Added new category: Sample Category', 'categories', NULL, '2025-08-13 05:16:22'),
(23, 1, 'UPDATE CATEGORY', 'Updated category id: 3, category: Sample Category 123', 'categories', NULL, '2025-08-13 05:16:34'),
(24, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:21:37'),
(25, 1, 'UPDATE USER', 'Updated user with id: 1, name: Trisha Batingana', 'items', 1, '2025-08-13 05:21:52'),
(26, 1, 'UPDATE USER', 'Updated user with id: 1, name: Trish Batingana', 'items', 1, '2025-08-13 05:22:07'),
(27, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:22:40'),
(28, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:27:00'),
(29, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-13 05:27:02'),
(30, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:27:03'),
(31, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:28:09'),
(32, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-13 05:28:19'),
(33, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 05:31:57'),
(34, 1, 'UPDATE CATEGORY', 'Updated category with id: 3, category: Sample Category', 'categories', NULL, '2025-08-13 05:32:17'),
(35, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-13 05:32:28'),
(36, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 22:53:10'),
(37, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-13 23:48:45'),
(38, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-13 23:50:34'),
(39, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-13 23:51:00'),
(40, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-16 02:10:14'),
(41, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-16 02:11:48'),
(42, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-16 02:14:07'),
(43, 1, 'ADD ITEM', 'Added new item: Gatas', 'items', NULL, '2025-08-16 02:15:18'),
(44, 1, 'ADD CATEGORY', 'Added new category: Milk Powder', 'categories', NULL, '2025-08-16 02:17:02'),
(45, 1, 'UPDATE ITEM', 'Updated item with id: 2, item: Gatas', 'items', 2, '2025-08-16 02:17:10'),
(46, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-16 02:18:36'),
(47, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-16 02:22:01'),
(48, 1, 'STOCK-IN', 'Added 20 Pack of Gatas', 'stock_movements', NULL, '2025-08-16 02:23:18'),
(49, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-16 02:55:19'),
(50, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-16 03:04:10'),
(51, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-16 03:04:18'),
(52, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 02:45:23'),
(53, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 02:45:51'),
(54, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 02:45:54'),
(55, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 02:45:58'),
(56, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 02:50:22'),
(57, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 02:50:30'),
(58, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 02:50:33'),
(59, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 02:50:35'),
(60, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 02:54:15'),
(61, 1, 'UPDATE ITEM', 'Updated item with id: 2, item: Gatas', 'items', 2, '2025-08-20 02:54:37'),
(62, 1, 'UPDATE ITEM', 'Updated item with id: 2, item: Gatas', 'items', 2, '2025-08-20 02:54:46'),
(63, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 02:55:20'),
(64, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:01:41'),
(65, 1, 'STOCK-IN', 'Added 10 Pack of Gatas', 'stock_movements', NULL, '2025-08-20 03:02:33'),
(66, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:03:20'),
(67, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:05:34'),
(68, 1, 'UPDATE USER', 'Updated user with id: 3, name: User2 Two1', 'users', 3, '2025-08-20 03:05:59'),
(69, 1, 'UPDATE USER', 'Updated user with id: 3, name: User2 Two', 'users', 3, '2025-08-20 03:06:06'),
(70, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:07:45'),
(71, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:11:31'),
(72, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:12:04'),
(73, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:19:52'),
(74, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:20:18'),
(75, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:21:16'),
(76, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:21:41'),
(77, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:23:31'),
(78, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:23:45'),
(79, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:24:35'),
(80, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:24:57'),
(81, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:25:27'),
(82, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:25:54'),
(83, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:26:11'),
(84, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:26:22'),
(85, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:27:06'),
(86, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:27:34'),
(87, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:29:05'),
(88, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:29:19'),
(89, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:29:57'),
(90, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:30:07'),
(91, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 03:31:15'),
(92, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 03:32:35'),
(93, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 22:50:12'),
(94, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 23:06:18'),
(95, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 23:06:39'),
(96, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 23:10:01'),
(97, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 23:11:10'),
(98, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 23:12:56'),
(99, 1, 'STOCK-OUT', 'Updated entry id: 13', 'stock_movements', NULL, '2025-08-20 23:14:33'),
(100, 1, 'STOCK-OUT', 'Updated entry id: 13', 'stock_movements', NULL, '2025-08-20 23:14:46'),
(101, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 23:15:22'),
(102, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 23:23:38'),
(103, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 23:23:45'),
(104, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-20 23:32:16'),
(105, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-20 23:32:39'),
(106, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 22:48:35'),
(107, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 22:49:18'),
(108, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 22:51:23'),
(109, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 22:51:36'),
(110, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 22:52:13'),
(111, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 22:52:36'),
(112, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 22:53:32'),
(113, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 22:54:43'),
(114, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 22:58:47'),
(115, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 22:59:09'),
(116, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:00:43'),
(117, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:01:10'),
(118, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:15:52'),
(119, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:16:22'),
(120, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:22:44'),
(121, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:22:56'),
(122, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:23:28'),
(123, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:23:43'),
(124, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:26:14'),
(125, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:27:07'),
(126, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:30:09'),
(127, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:31:24'),
(128, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:33:19'),
(129, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:35:44'),
(130, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:36:19'),
(131, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:36:44'),
(132, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:37:26'),
(133, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-21 23:39:32'),
(134, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-21 23:53:46'),
(135, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 00:44:49'),
(136, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:01:48'),
(137, 1, 'ADD ITEM', 'Added new item: Kape', 'items', NULL, '2025-08-22 01:02:54'),
(138, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:03:12'),
(139, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:05:25'),
(140, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:05:51'),
(141, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:07:31'),
(142, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:09:41'),
(143, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:14:58'),
(144, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:15:09'),
(145, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:15:28'),
(146, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:16:00'),
(147, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:16:19'),
(148, 1, 'STOCK-OUT', 'Removed 20 Pcs of Stick', 'stock_movements', NULL, '2025-08-22 01:16:43'),
(149, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:20:31'),
(150, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:21:10'),
(151, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:21:37'),
(152, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:24:52'),
(153, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:26:00'),
(154, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:33:14'),
(155, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:33:19'),
(156, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:33:48'),
(157, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:33:51'),
(158, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:34:07'),
(159, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 01:56:53'),
(160, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 01:59:44'),
(161, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:03:41'),
(162, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:03:43'),
(163, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:04:21'),
(164, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:04:23'),
(165, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:04:49'),
(166, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:04:52'),
(167, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:05:09'),
(168, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:06:38'),
(169, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:08:35'),
(170, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:10:23'),
(171, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:13:07'),
(172, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:13:25'),
(173, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:20:01'),
(174, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:20:30'),
(175, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:21:06'),
(176, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:22:32'),
(177, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:35:31'),
(178, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:39:34'),
(179, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:41:41'),
(180, 1, 'STOCK-OUT', 'Removed 10 Pack of Gatas', 'stock_movements', NULL, '2025-08-22 02:43:58'),
(181, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:44:35'),
(182, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:45:52'),
(183, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:45:55'),
(184, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:46:50'),
(185, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:51:28'),
(186, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:52:02'),
(187, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:52:26'),
(188, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:54:35'),
(189, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:54:38'),
(190, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:54:58'),
(191, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:55:48'),
(192, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:56:42'),
(193, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:57:22'),
(194, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:58:01'),
(195, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 02:59:00'),
(196, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 02:59:11'),
(197, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 03:00:00'),
(198, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 03:01:34'),
(199, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 03:02:13'),
(200, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 03:04:28'),
(201, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 03:05:07'),
(202, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 03:08:30'),
(203, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 03:09:08'),
(204, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-22 03:11:37'),
(205, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-22 03:12:16'),
(206, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-27 06:15:24'),
(207, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-27 06:17:50'),
(208, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-08-30 20:20:59'),
(209, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-08-30 20:21:39'),
(210, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 02:54:51'),
(211, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 02:57:21'),
(212, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 02:59:07'),
(213, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 02:59:46'),
(214, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 05:20:02'),
(215, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 05:21:56'),
(216, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 05:22:03'),
(217, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 05:22:14'),
(218, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 05:22:20'),
(219, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 05:26:20'),
(220, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 05:41:03'),
(221, 1, 'UPDATE USER', 'Updated user with id: 2, name: Don Desu', 'users', 2, '2025-09-09 05:42:58'),
(222, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 05:43:02'),
(223, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 05:43:21'),
(224, 1, 'UPDATE USER', 'Updated user with id: 2, name: Don Desu', 'users', 2, '2025-09-09 05:43:35'),
(225, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 05:43:38'),
(226, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-09 06:05:44'),
(227, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-09 06:07:25'),
(228, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-11 12:38:45'),
(229, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-11 12:39:36'),
(230, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-17 01:51:44'),
(231, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-17 01:52:42'),
(232, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-17 02:01:47'),
(233, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-17 02:01:52'),
(234, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-17 02:07:03'),
(235, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-17 02:07:18'),
(236, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-18 23:43:37'),
(237, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-18 23:43:43'),
(238, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-18 23:47:07'),
(239, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-18 23:47:49'),
(240, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:24:18'),
(241, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:25:16'),
(242, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:28:15'),
(243, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:29:19'),
(244, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:32:31'),
(245, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:32:49'),
(246, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:34:26'),
(247, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:34:43'),
(248, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:35:53'),
(249, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:36:16'),
(250, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:38:03'),
(251, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:39:03'),
(252, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:39:35'),
(253, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:39:39'),
(254, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:43:43'),
(255, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:44:02'),
(256, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:46:54'),
(257, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:47:24'),
(258, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:50:05'),
(259, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:50:34'),
(260, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:52:13'),
(261, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:52:30'),
(262, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:56:30'),
(263, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-23 23:57:03'),
(264, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-23 23:59:15'),
(265, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:00:05'),
(266, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:02:41'),
(267, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:03:23'),
(268, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:06:02'),
(269, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:06:12'),
(270, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:12:15'),
(271, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:13:12'),
(272, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:14:57'),
(273, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:15:15'),
(274, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:15:39'),
(275, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:16:00'),
(276, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:17:08'),
(277, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:17:46'),
(278, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:18:13'),
(279, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:18:22'),
(280, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:19:00'),
(281, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:19:12'),
(282, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:19:48'),
(283, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:20:36'),
(284, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:23:16'),
(285, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:23:51'),
(286, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:25:36'),
(287, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:25:51'),
(288, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:28:53'),
(289, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:32:24'),
(290, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:33:50'),
(291, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:34:38'),
(292, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:35:01'),
(293, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:35:05'),
(294, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:35:17'),
(295, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:35:21'),
(296, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:41:10'),
(297, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:42:07'),
(298, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:42:30'),
(299, 1, 'STOCK-IN', 'Added 30 Bag of Kape', 'stock_movements', NULL, '2025-09-24 00:43:02'),
(300, 1, 'STOCK-OUT', 'Removed 5 Pack of Gatas', 'stock_movements', NULL, '2025-09-24 00:44:06'),
(301, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:45:20'),
(302, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:47:52'),
(303, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:48:10'),
(304, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 00:55:29'),
(305, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 00:55:48'),
(306, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:26:38'),
(307, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:26:57'),
(308, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:27:52'),
(309, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:29:13'),
(310, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:32:55'),
(311, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:33:45'),
(312, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:35:40'),
(313, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:36:07'),
(314, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:36:39'),
(315, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:37:21'),
(316, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:41:27'),
(317, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:41:53'),
(318, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:42:00'),
(319, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:45:16'),
(320, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:46:51'),
(321, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:47:48'),
(322, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:52:10'),
(323, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:52:22'),
(324, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:52:59'),
(325, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:53:10'),
(326, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:53:38'),
(327, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:55:48'),
(328, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:55:59'),
(329, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 01:58:07'),
(330, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 01:58:19'),
(331, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:00:28'),
(332, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:00:34'),
(333, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:03:27'),
(334, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:06:49'),
(335, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:07:01'),
(336, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:07:47'),
(337, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:08:01'),
(338, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:10:59'),
(339, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:11:11'),
(340, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:13:45'),
(341, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:14:09'),
(342, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-24 02:14:55'),
(343, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-24 02:17:17'),
(344, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 21:48:29'),
(345, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 21:49:25'),
(346, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 21:57:55'),
(347, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 21:58:00'),
(348, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 21:58:53'),
(349, 1, 'UPDATE CATEGORY', 'Updated category with id: 1, category: Coffee Beans 123', 'categories', NULL, '2025-09-29 21:59:34'),
(350, 1, 'UPDATE CATEGORY', 'Updated category with id: 1, category: Coffee Beans', 'categories', NULL, '2025-09-29 21:59:48'),
(351, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:03:57'),
(352, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:11:12'),
(353, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:12:44'),
(354, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:15:07'),
(355, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:15:33'),
(356, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:16:16'),
(357, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:16:53'),
(358, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:18:31'),
(359, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:19:08'),
(360, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:23:14'),
(361, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:23:47'),
(362, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:26:27'),
(363, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:26:53'),
(364, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:40:13'),
(365, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:40:27'),
(366, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:41:13'),
(367, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:41:21'),
(368, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:41:44'),
(369, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:41:51'),
(370, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:42:03'),
(371, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:42:18'),
(372, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:43:00'),
(373, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:43:05'),
(374, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:43:39'),
(375, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:43:49'),
(376, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:46:50'),
(377, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:47:00'),
(378, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:47:01'),
(379, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:47:26'),
(380, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:49:46'),
(381, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:49:52'),
(382, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:50:23'),
(383, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:50:36'),
(384, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:52:07'),
(385, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:52:32'),
(386, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:56:26'),
(387, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:56:57'),
(388, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 22:57:22'),
(389, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 22:57:34'),
(390, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:02:41'),
(391, 1, 'STOCK-OUT', 'Removed 6 Pack of Gatas', 'stock_movements', NULL, '2025-09-29 23:03:03'),
(392, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:03:22'),
(393, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:08:05'),
(394, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:08:08'),
(395, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:08:30'),
(396, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:08:37'),
(397, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:10:06'),
(398, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:10:08'),
(399, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:11:09'),
(400, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:11:11'),
(401, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:13:32'),
(402, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:13:53'),
(403, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:16:46'),
(404, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:16:54'),
(405, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:18:36'),
(406, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:18:41'),
(407, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:19:22'),
(408, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:19:25'),
(409, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:21:59'),
(410, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:22:13'),
(411, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:22:26'),
(412, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:23:09'),
(413, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:23:54'),
(414, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:24:25'),
(415, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:26:04'),
(416, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:26:24'),
(417, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:28:42'),
(418, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:29:15'),
(419, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:30:45'),
(420, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:30:49'),
(421, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:31:30'),
(422, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:31:35'),
(423, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:31:54'),
(424, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:32:05'),
(425, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:32:22'),
(426, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:32:32'),
(427, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:35:38'),
(428, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:36:17'),
(429, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:36:18'),
(430, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:36:32'),
(431, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:37:19'),
(432, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:37:31'),
(433, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:37:59'),
(434, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:38:11'),
(435, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:38:40'),
(436, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:38:55'),
(437, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:40:28'),
(438, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:40:45'),
(439, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:43:26'),
(440, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:44:16'),
(441, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:45:21'),
(442, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:48:39'),
(443, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:49:37'),
(444, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:51:19'),
(445, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:51:55'),
(446, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:55:39'),
(447, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:56:42'),
(448, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:56:59'),
(449, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-29 23:57:06'),
(450, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-29 23:57:14'),
(451, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:01:31'),
(452, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:01:36'),
(453, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:02:30'),
(454, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:03:15'),
(455, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:04:03'),
(456, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:04:12'),
(457, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:05:23'),
(458, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:05:47'),
(459, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:05:54'),
(460, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:06:26'),
(461, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:08:32'),
(462, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:09:02'),
(463, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:09:39'),
(464, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:09:48'),
(465, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:10:39'),
(466, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:12:09'),
(467, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:15:17'),
(468, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:16:11'),
(469, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:16:50'),
(470, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:17:41'),
(471, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:19:49'),
(472, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:20:40'),
(473, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:21:14'),
(474, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:21:28'),
(475, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:22:26'),
(476, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:22:47'),
(477, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:26:38'),
(478, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:28:37'),
(479, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:29:43'),
(480, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:32:54'),
(481, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:41:44'),
(482, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:42:02'),
(483, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:43:36'),
(484, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:44:08'),
(485, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:45:18'),
(486, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 00:45:45'),
(487, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:45:58'),
(488, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:46:21'),
(489, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:47:33'),
(490, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:48:20'),
(491, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:49:13'),
(492, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:51:05'),
(493, 1, 'UPDATE ITEM', 'Updated item with id: 2, item: Gatas', 'items', 2, '2025-09-30 00:52:21'),
(494, 1, 'UPDATE ITEM', 'Updated item with id: 3, item: Kape', 'items', 3, '2025-09-30 00:52:52'),
(495, 1, 'UPDATE CATEGORY', 'Updated category with id: 2, category: Beverage', 'categories', NULL, '2025-09-30 00:53:08'),
(496, 1, 'UPDATE CATEGORY', 'Updated category with id: 2, category: Beverages', 'categories', NULL, '2025-09-30 00:53:14'),
(497, 1, 'ADD CATEGORY', 'Added new category: Food?', 'categories', NULL, '2025-09-30 00:53:49'),
(498, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:54:01'),
(499, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:54:16'),
(500, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:56:13'),
(501, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 00:56:25'),
(502, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 00:56:37'),
(503, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:57:03'),
(504, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:57:59'),
(505, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 00:58:10'),
(506, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 00:58:36'),
(507, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 00:59:14'),
(508, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 00:59:26'),
(509, 1, 'UPDATE USER', 'Updated user with id: 2, name: User One', 'users', 2, '2025-09-30 01:00:52'),
(510, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 01:02:18'),
(511, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-09-30 01:04:04'),
(512, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-09-30 01:04:28'),
(513, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-09-30 01:05:50'),
(514, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 00:19:11'),
(515, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 00:21:31'),
(516, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:06:06'),
(517, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:06:14'),
(518, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:06:51'),
(519, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:07:04'),
(520, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:10:03'),
(521, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:10:47'),
(522, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:11:38'),
(523, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:11:52'),
(524, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:20:55'),
(525, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:21:12'),
(526, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:21:53'),
(527, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:22:35'),
(528, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:28:38'),
(529, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:29:02'),
(530, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:30:02'),
(531, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:30:12'),
(532, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:30:45'),
(533, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:30:56'),
(534, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:31:32'),
(535, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:31:46'),
(536, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:38:20'),
(537, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:38:28'),
(538, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:40:28'),
(539, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:40:36'),
(540, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:42:07'),
(541, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:43:12'),
(542, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:43:29'),
(543, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:43:41'),
(544, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:53:46'),
(545, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:53:57'),
(546, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:55:46'),
(547, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:56:36'),
(548, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 01:57:06'),
(549, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 01:58:15'),
(550, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:02:47'),
(551, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:03:09'),
(552, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:04:46'),
(553, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:04:55'),
(554, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:05:23'),
(555, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:06:42'),
(556, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:09:31'),
(557, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:09:46'),
(558, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:10:56'),
(559, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:11:51'),
(560, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:16:24'),
(561, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:16:35'),
(562, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:17:13'),
(563, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:17:28'),
(564, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:18:34'),
(565, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:19:03'),
(566, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:20:25'),
(567, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:20:46'),
(568, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:21:30'),
(569, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:23:00'),
(570, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:24:57'),
(571, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:25:07'),
(572, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:25:21'),
(573, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:25:49'),
(574, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-11 02:26:23'),
(575, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-11 02:38:10'),
(576, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:22:36'),
(577, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:27:25'),
(578, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:32:05'),
(579, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:35:41'),
(580, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:36:44'),
(581, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:42:01'),
(582, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:44:43'),
(583, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:45:18'),
(584, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:46:00'),
(585, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:46:09'),
(586, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:46:41');
INSERT INTO `logs` (`log_id`, `user_id`, `action`, `description`, `table_name`, `record_id`, `timestamp`) VALUES
(587, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:46:50'),
(588, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:47:15'),
(589, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:47:29'),
(590, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:47:50'),
(591, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:48:39'),
(592, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:52:45'),
(593, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:53:10'),
(594, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:55:53'),
(595, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:56:14'),
(596, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-12 21:58:30'),
(597, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-12 21:59:07'),
(598, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 22:53:23'),
(599, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 22:54:38'),
(600, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 22:55:28'),
(601, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 22:55:52'),
(602, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 22:58:41'),
(603, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 22:59:41'),
(604, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:00:11'),
(605, 1, 'STOCK-IN', 'Added 30 Pcs of Stick', 'stock_movements', NULL, '2025-10-15 23:02:58'),
(606, 1, 'ADD ITEM', 'Added new item: Sugar', 'items', NULL, '2025-10-15 23:05:05'),
(607, 1, 'STOCK-IN', 'Added 30 Pack of Sugar', 'stock_movements', NULL, '2025-10-15 23:05:35'),
(608, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:07:23'),
(609, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:09:26'),
(610, 1, 'STOCK-OUT', 'Removed 2 Pcs of Stick', 'stock_movements', NULL, '2025-10-15 23:10:16'),
(611, 1, 'STOCK-OUT', 'Removed 1 Pack of Sugar', 'stock_movements', NULL, '2025-10-15 23:10:51'),
(612, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:11:14'),
(613, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:20:58'),
(614, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:21:43'),
(615, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:23:59'),
(616, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:24:32'),
(617, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:24:54'),
(618, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:25:17'),
(619, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:26:43'),
(620, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:27:12'),
(621, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:30:26'),
(622, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:30:38'),
(623, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:32:41'),
(624, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:33:16'),
(625, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:34:11'),
(626, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:34:28'),
(627, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:34:47'),
(628, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:35:06'),
(629, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:35:27'),
(630, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:36:13'),
(631, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:37:04'),
(632, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:39:19'),
(633, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:39:33'),
(634, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:42:46'),
(635, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:43:05'),
(636, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:48:25'),
(637, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:49:13'),
(638, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:49:34'),
(639, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:51:33'),
(640, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:52:13'),
(641, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-15 23:54:38'),
(642, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-15 23:59:07'),
(643, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:00:00'),
(644, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:00:14'),
(645, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:01:25'),
(646, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:02:24'),
(647, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:02:48'),
(648, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:03:37'),
(649, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:05:39'),
(650, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:06:25'),
(651, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:07:19'),
(652, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:08:39'),
(653, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:09:20'),
(654, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:10:08'),
(655, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:10:52'),
(656, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:12:50'),
(657, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:14:37'),
(658, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:16:26'),
(659, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:16:45'),
(660, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:17:57'),
(661, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:18:08'),
(662, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:18:36'),
(663, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:22:10'),
(664, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:22:32'),
(665, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:22:43'),
(666, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:22:58'),
(667, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:23:09'),
(668, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:23:12'),
(669, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:23:22'),
(670, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:23:35'),
(671, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:24:19'),
(672, 2, 'STOCK-OUT', 'Removed 1 Pack of Sugar', 'stock_movements', NULL, '2025-10-16 00:24:53'),
(673, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:25:03'),
(674, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:25:10'),
(675, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:26:22'),
(676, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:26:27'),
(677, 2, 'STOCK-OUT', 'Removed 1 Bag of Kape', 'stock_movements', NULL, '2025-10-16 00:26:42'),
(678, 2, 'STOCK-OUT', 'Removed 1 Pcs of Stick', 'stock_movements', NULL, '2025-10-16 00:26:53'),
(679, 2, 'STOCK-OUT', 'Removed 2 Pack of Gatas', 'stock_movements', NULL, '2025-10-16 00:27:03'),
(680, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:27:09'),
(681, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:27:16'),
(682, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:29:40'),
(683, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:32:24'),
(684, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:33:18'),
(685, 2, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:33:25'),
(686, 2, 'STOCK-OUT', 'Removed 1 Pack of Sugar', 'stock_movements', NULL, '2025-10-16 00:33:49'),
(687, 2, 'STOCK-OUT', 'Removed 1 Pack of Gatas', 'stock_movements', NULL, '2025-10-16 00:34:02'),
(688, 2, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:34:08'),
(689, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 00:34:14'),
(690, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 00:34:58'),
(691, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-16 04:02:00'),
(692, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-16 04:02:24'),
(693, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:28:19'),
(694, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:29:12'),
(695, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:32:18'),
(696, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:33:19'),
(697, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:37:22'),
(698, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:37:38'),
(699, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:38:49'),
(700, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:40:28'),
(701, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:40:39'),
(702, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:43:08'),
(703, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:43:44'),
(704, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:45:35'),
(705, 1, 'UPDATE ITEM', 'Updated item with id: 1, item: Stick', 'items', 1, '2025-10-17 00:46:30'),
(706, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:49:00'),
(707, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:52:01'),
(708, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:52:30'),
(709, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:53:47'),
(710, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:53:57'),
(711, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:55:41'),
(712, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:56:11'),
(713, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:57:15'),
(714, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:58:01'),
(715, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 00:59:00'),
(716, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 00:59:42'),
(717, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-17 01:02:36'),
(718, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-17 01:03:18'),
(719, 1, 'LOGIN', 'User logged in successfully', NULL, NULL, '2025-10-18 13:21:32'),
(720, 1, 'LOGOUT', 'User logged out successfully', NULL, NULL, '2025-10-18 13:21:58');

-- --------------------------------------------------------

--
-- Table structure for table `stock_alerts`
--

CREATE TABLE `stock_alerts` (
  `alert_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `alert_message` varchar(255) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stock_alerts`
--

INSERT INTO `stock_alerts` (`alert_id`, `item_id`, `alert_message`, `created_at`) VALUES
(1, 1, 'Stock is low for item ID 1', '2025-08-12 17:51:01'),
(2, 1, 'Stock is low for item ID 1', '2025-08-12 17:54:32'),
(3, 1, 'Stock is low for item ID 1', '2025-08-21 17:16:43'),
(4, 2, 'Stock is low for item ID 2', '2025-09-29 15:03:03'),
(5, 2, 'Stock is low for item ID 2', '2025-10-15 16:27:03'),
(6, 2, 'Stock is low for item ID 2', '2025-10-15 16:34:02');

-- --------------------------------------------------------

--
-- Table structure for table `stock_levels`
--

CREATE TABLE `stock_levels` (
  `item_id` int(11) NOT NULL,
  `quantity_on_hand` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stock_levels`
--

INSERT INTO `stock_levels` (`item_id`, `quantity_on_hand`) VALUES
(1, 37),
(2, 6),
(3, 29),
(4, 27);

--
-- Triggers `stock_levels`
--
DELIMITER $$
CREATE TRIGGER `after_stock_level_update` AFTER UPDATE ON `stock_levels` FOR EACH ROW BEGIN
    DECLARE reorderLevel INT;
    SELECT reorder_level INTO reorderLevel FROM items WHERE item_id = NEW.item_id;

    IF NEW.quantity_on_hand <= reorderLevel THEN
        INSERT INTO stock_alerts (item_id, alert_message)
        VALUES (NEW.item_id, CONCAT('Stock is low for item ID ', NEW.item_id));
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `stock_movements`
--

CREATE TABLE `stock_movements` (
  `movement_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `movement_type` enum('IN','OUT') NOT NULL,
  `quantity` int(11) NOT NULL,
  `reference_no` varchar(100) DEFAULT NULL,
  `remarks` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_by` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stock_movements`
--

INSERT INTO `stock_movements` (`movement_id`, `item_id`, `movement_type`, `quantity`, `reference_no`, `remarks`, `created_at`, `updated_at`, `created_by`) VALUES
(1, 1, 'IN', 20, 'REFERENCEsample', 'Good', '2025-08-11 21:40:14', '2025-08-11 21:40:14', 1),
(2, 1, 'IN', 4, 'Sample', 'Add', '2025-08-11 21:55:48', '2025-08-11 21:55:48', 1),
(3, 1, 'IN', 10, '1234', 'done', '2025-08-12 06:38:38', '2025-08-12 17:52:57', 1),
(4, 1, 'OUT', 12, '12345678', 'for store', '2025-08-12 06:54:52', '2025-08-12 17:54:32', 1),
(5, 1, 'OUT', 12, '123123123', 'store', '2025-08-12 06:56:08', '2025-08-12 17:54:24', 2),
(6, 1, 'IN', 30, '12345456', 'Add-on', '2025-08-12 17:55:29', '2025-08-12 17:55:29', 1),
(7, 1, 'OUT', 10, '1234561', 'for store', '2025-08-12 17:56:22', '2025-08-12 17:56:22', 1),
(8, 1, 'IN', 10, '123123', '123123', '2025-08-12 19:34:36', '2025-08-12 19:34:36', 1),
(9, 1, 'IN', 10, '123123', '123123', '2025-08-12 19:34:52', '2025-08-12 19:34:52', 1),
(10, 1, 'IN', 30, '123123', '123123', '2025-08-12 20:47:43', '2025-08-12 21:02:19', 1),
(11, 1, 'OUT', 30, '123123', '123123', '2025-08-12 20:52:11', '2025-08-12 20:52:11', 1),
(12, 1, 'OUT', 10, '123123', '123123', '2025-08-12 20:53:13', '2025-08-12 20:53:13', 1),
(13, 1, 'OUT', 10, '123123', '123123', '2025-08-12 20:54:28', '2025-08-20 15:14:46', 1),
(14, 2, 'IN', 20, '123123', '123456', '2025-08-15 18:23:18', '2025-08-15 18:23:18', 1),
(15, 2, 'IN', 10, '123123123', '123123132', '2025-08-19 19:02:33', '2025-08-19 19:02:33', 1),
(16, 1, 'OUT', 20, '', '', '2025-08-21 17:16:43', '2025-08-21 17:16:43', 1),
(17, 2, 'OUT', 10, '', '', '2025-08-21 18:43:58', '2025-08-21 18:43:58', 1),
(18, 3, 'IN', 30, '123123', '123123', '2025-09-23 16:43:01', '2025-09-23 16:43:01', 1),
(19, 2, 'OUT', 5, '', '', '2025-09-23 16:44:06', '2025-09-23 16:44:06', 1),
(20, 2, 'OUT', 6, '', '', '2025-09-29 15:03:03', '2025-09-29 15:03:03', 1),
(21, 1, 'IN', 30, '123456', '132', '2025-10-15 15:02:58', '2025-10-15 15:02:58', 1),
(22, 4, 'IN', 30, '123', '123', '2025-10-15 15:05:35', '2025-10-15 15:05:35', 1),
(23, 1, 'OUT', 2, '123', '123', '2025-10-15 15:10:16', '2025-10-15 15:10:16', 1),
(24, 4, 'OUT', 1, '123', '123', '2025-10-15 15:10:51', '2025-10-15 15:10:51', 1),
(25, 4, 'OUT', 1, '123', '123', '2025-10-15 16:24:53', '2025-10-15 16:24:53', 2),
(26, 3, 'OUT', 1, '', '', '2025-10-15 16:26:42', '2025-10-15 16:26:42', 2),
(27, 1, 'OUT', 1, '', '', '2025-10-15 16:26:53', '2025-10-15 16:26:53', 2),
(28, 2, 'OUT', 2, '', '', '2025-10-15 16:27:03', '2025-10-15 16:27:03', 2),
(29, 4, 'OUT', 1, '', '', '2025-10-15 16:33:49', '2025-10-15 16:33:49', 2),
(30, 2, 'OUT', 1, '', '', '2025-10-15 16:34:02', '2025-10-15 16:34:02', 2);

--
-- Triggers `stock_movements`
--
DELIMITER $$
CREATE TRIGGER `after_stock_movement_insert` AFTER INSERT ON `stock_movements` FOR EACH ROW BEGIN
    IF NEW.movement_type = 'IN' THEN
        UPDATE stock_levels
        SET quantity_on_hand = quantity_on_hand + NEW.quantity
        WHERE item_id = NEW.item_id;
    ELSEIF NEW.movement_type = 'OUT' THEN
        UPDATE stock_levels
        SET quantity_on_hand = quantity_on_hand - NEW.quantity
        WHERE item_id = NEW.item_id;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_stock_movement_update` AFTER UPDATE ON `stock_movements` FOR EACH ROW BEGIN
    DECLARE qty_diff INT;

    -- Calculate difference
    SET qty_diff = NEW.quantity - OLD.quantity;

    IF NEW.movement_type = 'IN' THEN
        UPDATE stock_levels
        SET quantity_on_hand = quantity_on_hand + qty_diff
        WHERE item_id = NEW.item_id;

    ELSEIF NEW.movement_type = 'OUT' THEN
        UPDATE stock_levels
        SET quantity_on_hand = quantity_on_hand - qty_diff
        WHERE item_id = NEW.item_id;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `user_firstname` varchar(50) NOT NULL,
  `user_lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL,
  `user_type` int(1) NOT NULL DEFAULT 2,
  `status` int(1) NOT NULL DEFAULT 1,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `modified_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_firstname`, `user_lastname`, `username`, `password`, `user_type`, `status`, `created_at`, `modified_at`) VALUES
(1, 'Trish', 'Batingana', 'trish', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, 1, '2025-08-05 10:52:30', '2025-08-12 21:22:07'),
(2, 'User', 'One', 'user', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 2, 1, '2025-08-06 11:30:27', '2025-09-29 17:00:52'),
(3, 'User2', 'Two', 'two', '8d23cf6c86e834a7aa6eded54c26ce2bb2e74903538c61bdd5d2197997ab2f72', 2, 1, '2025-08-08 19:51:30', '2025-08-19 19:06:06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_id`),
  ADD UNIQUE KEY `item_code` (`item_code`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `stock_alerts`
--
ALTER TABLE `stock_alerts`
  ADD PRIMARY KEY (`alert_id`),
  ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `stock_levels`
--
ALTER TABLE `stock_levels`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `stock_movements`
--
ALTER TABLE `stock_movements`
  ADD PRIMARY KEY (`movement_id`),
  ADD KEY `item_id` (`item_id`),
  ADD KEY `created_by` (`created_by`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=721;

--
-- AUTO_INCREMENT for table `stock_alerts`
--
ALTER TABLE `stock_alerts`
  MODIFY `alert_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `stock_movements`
--
ALTER TABLE `stock_movements`
  MODIFY `movement_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`);

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);

--
-- Constraints for table `stock_alerts`
--
ALTER TABLE `stock_alerts`
  ADD CONSTRAINT `stock_alerts_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`);

--
-- Constraints for table `stock_levels`
--
ALTER TABLE `stock_levels`
  ADD CONSTRAINT `stock_levels_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`);

--
-- Constraints for table `stock_movements`
--
ALTER TABLE `stock_movements`
  ADD CONSTRAINT `stock_movements_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`),
  ADD CONSTRAINT `stock_movements_ibfk_2` FOREIGN KEY (`created_by`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
