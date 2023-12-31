-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2023 at 11:15 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ksbinventorymanagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `buy_by`
--

CREATE TABLE `buy_by` (
  `i_id` int(11) NOT NULL,
  `e_id` int(11) NOT NULL,
  `date` varchar(10) NOT NULL,
  `qty` int(11) NOT NULL,
  `cost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buy_by`
--

INSERT INTO `buy_by` (`i_id`, `e_id`, `date`, `qty`, `cost`) VALUES
(20000, 10000, '04/05/2023', 100, 0),
(20002, 10001, '04/05/2023', 12, 0),
(20002, 10002, '04/05/2023', 8, 8),
(20002, 10001, '04/05/2023', 12, 900),
(20001, 10001, '04/05/2023', 0, 0),
(20001, 10001, '04/05/2023', 123, 31),
(20001, 10000, '04/05/2023', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `contains`
--

CREATE TABLE `contains` (
  `i_id` int(11) NOT NULL,
  `p_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contains`
--

INSERT INTO `contains` (`i_id`, `p_id`, `qty`) VALUES
(20001, 30000, 5),
(20002, 30000, 1),
(20006, 30000, 3),
(20000, 30001, 1),
(20006, 30001, 3),
(20003, 30002, 2),
(20007, 30002, 2),
(20009, 30003, 5),
(20008, 30003, 1),
(20000, 30004, 1),
(20008, 30004, 1),
(20006, 30004, 3),
(20005, 30005, 2),
(20004, 30005, 2),
(20008, 30005, 1);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `c_id` int(11) NOT NULL,
  `c_name` varchar(60) NOT NULL,
  `c_payment_method` varchar(60) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`c_id`, `c_name`, `c_payment_method`) VALUES
(60000, 'Jomar Asis', 'Gcash'),
(60001, 'EGBoy', 'Gcash'),
(60002, 'Bundalian JUlius', 'Cash'),
(60003, 'juls', 'Gcash'),
(60004, 'ewan', 'Cash'),
(60005, 'pat', 'Cash'),
(60006, 'loh', 'Cash'),
(60007, 'ew', 'Cash'),
(60008, 'dad', 'Gcash'),
(60009, 'fhf', 'Gcash'),
(60010, 'fhfpo', 'Cash'),
(60011, 'oiuo', 'Gcash'),
(60012, '20adw', 'Gcash'),
(60013, 'bbis', 'Gcash'),
(60014, 'JOmar Asis', 'Gcash'),
(60015, 'JOmar Asis', 'Gcash'),
(60016, 'julius', 'Gcash'),
(60017, 'jomar', 'Cash'),
(60018, 'Patrcik', 'Gcash'),
(60019, 'PaDIon', 'Gcash'),
(60020, 'jols', 'Gcash'),
(60021, 'jols', 'Cash'),
(60022, 'Julius Bundalian', 'Gcash');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `e_id` int(11) NOT NULL,
  `e_lname` varchar(60) NOT NULL,
  `e_fname` varchar(60) NOT NULL,
  `e_minit` varchar(60) NOT NULL,
  `e_address` varchar(60) NOT NULL,
  `e_number` varchar(11) NOT NULL,
  `e_sex` varchar(60) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`e_id`, `e_lname`, `e_fname`, `e_minit`, `e_address`, `e_number`, `e_sex`) VALUES
(10000, 'Bundalian', 'Julius Jervin', 'V', 'P3. Gumamela Pob., Labo, Camarines Norte', '09613644784', 'Male'),
(10001, 'Labrador', 'Zyne', 'T', 'Vinzons, Camarines Norte', '09771174519', 'Female'),
(10002, 'Bundalian', 'Sean Ashley', 'V', 'P1. Bulhao, Hillcreast Subdivision, Labo, Camarines Norte', '09613644784', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `handle_by`
--

CREATE TABLE `handle_by` (
  `i_id` int(11) NOT NULL,
  `e_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `date` varchar(10) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `handle_by`
--

INSERT INTO `handle_by` (`i_id`, `e_id`, `qty`, `date`) VALUES
(20003, 10001, 12, '15/05/2023'),
(20004, 10001, 50, '15/05/2023'),
(20001, 10001, 90, '21/05/2023');

-- --------------------------------------------------------

--
-- Table structure for table `ingredient`
--

CREATE TABLE `ingredient` (
  `i_id` int(11) NOT NULL,
  `i_name` varchar(60) NOT NULL,
  `i_expiration_date` varchar(10) NOT NULL,
  `i_qty` int(11) NOT NULL,
  `s_id` int(11) DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ingredient`
--

INSERT INTO `ingredient` (`i_id`, `i_name`, `i_expiration_date`, `i_qty`, `s_id`) VALUES
(20000, 'Chicken Breast', '30/05/2023', 196, 40002),
(20001, 'Shrimp', '20/05/2029', 30, 40000),
(20002, 'Butter', '14/05/2023', 106, 0),
(20003, 'Canned Corn', '30/05/2023', 28, 0),
(20004, 'Beef Sirloin', '30/05/2023', 40, 40004),
(20005, 'Eggs', '30/05/2023', 90, 0),
(20006, 'Herbs & Spices', '30/05/2023', 26, 0),
(20007, 'Evaporated Milk', '30/05/2023', 78, 0),
(20008, 'Bigas', '30/05/2023', 89, 0),
(20009, 'Siomai', '30/05/2023', 85, 0);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `p_id` int(11) NOT NULL,
  `c_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `date` varchar(10) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`p_id`, `c_id`, `qty`, `date`) VALUES
(30001, 60000, 2, '09/05/2023'),
(30002, 60000, 1, '09/05/2023'),
(0, 60000, 0, '09/05/2023'),
(30000, 60001, 1, '09/05/2023'),
(30001, 60001, 10, '09/05/2023'),
(30002, 60001, 5, '09/05/2023'),
(30003, 60001, 3, '09/05/2023'),
(30000, 60002, 1, '10/05/2023'),
(30003, 60002, 1, '10/05/2023'),
(30001, 60002, 2, '10/05/2023'),
(30000, 60003, 1, '11/05/2023'),
(30000, 60004, 1, '11/05/2023'),
(30000, 60005, 1, '11/05/2023'),
(30000, 60006, 1, '11/05/2023'),
(30000, 60007, 1, '11/05/2023'),
(30000, 60008, 1, '11/05/2023'),
(30000, 60009, 1, '11/05/2023'),
(30000, 60010, 1, '11/05/2023'),
(30000, 60011, 1, '11/05/2023'),
(30000, 60012, 1, '11/05/2023'),
(30000, 60013, 1, '14/05/2023'),
(30001, 60016, 1, '15/05/2023'),
(30001, 60017, 1, '15/05/2023'),
(30000, 60018, 1, '15/05/2023'),
(30001, 60019, 1, '15/05/2023'),
(30000, 60019, 1, '15/05/2023'),
(30002, 60019, 1, '15/05/2023'),
(30000, 60020, 1, '16/05/2023'),
(30000, 60022, 1, '21/05/2023'),
(30003, 60022, 1, '21/05/2023'),
(30001, 60022, 1, '21/05/2023');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `p_id` int(11) NOT NULL,
  `p_name` varchar(60) NOT NULL,
  `p_cost` varchar(60) NOT NULL,
  `p_type` varchar(60) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`p_id`, `p_name`, `p_cost`, `p_type`) VALUES
(30000, 'Buttered Shrimp', '249.00', 'Main Dish'),
(30001, 'Fried Chicken', '210.00', 'Main Dish'),
(30002, 'Mais Con Yelo', '65.00', 'Drinks & Dessert'),
(30003, 'Shomai Rice', '49.00', 'Tipid Meals'),
(30004, 'Chicken Inasal', '169.00', 'Main Dish'),
(30005, 'Tapsilog', '95.00', 'Rice Meal');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `s_id` int(11) NOT NULL,
  `s_lname` varchar(60) NOT NULL,
  `s_fname` varchar(60) NOT NULL,
  `s_minit` varchar(60) DEFAULT NULL,
  `s_address` varchar(60) NOT NULL,
  `s_number` varchar(11) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`s_id`, `s_lname`, `s_fname`, `s_minit`, `s_address`, `s_number`) VALUES
(40000, 'Lapak', 'Earl George', 'A', 'Daet, Camarines Norte', '09091901091'),
(40001, 'Furio', 'Ronalyn', 'B', 'Santa Elena, Camarines Norte', '09817235648'),
(40002, 'Panganiban', 'Irish', 'D', 'Santa Elena, Camarines Norte', '09817238976'),
(40003, 'Bobis', 'Jay Austin', 'A', 'San Vicente, Camarines Norte', '09123678716'),
(40004, 'Villaluz', 'Patrick', 'S', 'Labo, Camarines Norte', '09786455979');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buy_by`
--
ALTER TABLE `buy_by`
  ADD KEY `e_id` (`e_id`),
  ADD KEY `i_id` (`i_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`e_id`);

--
-- Indexes for table `ingredient`
--
ALTER TABLE `ingredient`
  ADD PRIMARY KEY (`i_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`p_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`s_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `c_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60023;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `e_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10003;

--
-- AUTO_INCREMENT for table `ingredient`
--
ALTER TABLE `ingredient`
  MODIFY `i_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20010;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `p_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30011;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `s_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40005;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `buy_by`
--
ALTER TABLE `buy_by`
  ADD CONSTRAINT `buy_by_ibfk_1` FOREIGN KEY (`e_id`) REFERENCES `employee` (`e_id`),
  ADD CONSTRAINT `buy_by_ibfk_2` FOREIGN KEY (`i_id`) REFERENCES `ingredient` (`i_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
