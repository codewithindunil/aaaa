-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2020 at 11:03 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ayurvedicsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctordetails`
--

CREATE TABLE `doctordetails` (
  `id` int(11) NOT NULL,
  `employee_id` varchar(255) NOT NULL,
  `employee_name` varchar(255) NOT NULL,
  `address_line_1` varchar(255) NOT NULL,
  `address_line_2` varchar(255) NOT NULL,
  `address_line_3` varchar(255) NOT NULL,
  `sex` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `doctor_reg_no` varchar(255) NOT NULL,
  `mobile` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `created_by` varchar(255) NOT NULL,
  `created_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `doctordetails`
--

INSERT INTO `doctordetails` (`id`, `employee_id`, `employee_name`, `address_line_1`, `address_line_2`, `address_line_3`, `sex`, `type`, `doctor_reg_no`, `mobile`, `email`, `created_by`, `created_date`) VALUES
(0, 'das', 'asd', 'ad', 'asd', 'asd', 'asda', 'dsad', 'dasd', 'das', 'asd', 'dsfsd', '2020-05-30 21:22:14');

-- --------------------------------------------------------

--
-- Table structure for table `medicine_items`
--

CREATE TABLE `medicine_items` (
  `id` int(11) NOT NULL,
  `item_id` varchar(255) NOT NULL,
  `item_code` varchar(255) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `uom` varchar(255) NOT NULL,
  `created_by` varchar(255) NOT NULL,
  `expDate` varchar(100) NOT NULL,
  `expMonth` varchar(100) NOT NULL,
  `expYear` varchar(100) NOT NULL,
  `create_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `supplier_id` varchar(255) NOT NULL,
  `selling_price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `medicine_items`
--

INSERT INTO `medicine_items` (`id`, `item_id`, `item_code`, `item_name`, `uom`, `created_by`, `expDate`, `expMonth`, `expYear`, `create_date`, `supplier_id`, `selling_price`) VALUES
(3, 'ITEM1', '1', 's', 's', '', '31', '05', '2020', '2020-05-31 14:47:03', '', ''),
(4, 'ITEM4', '4', 'grd', 'hdhd', '', '31', '05', '2020', '2020-05-31 14:49:32', 'ad', ''),
(5, 'ITEM5', '5', 'sad', 'adasd', '', '31', '05', '2020', '2020-05-31 16:15:14', 'ad', '1111'),
(6, 'ITEM6', '6', 'dasdas', '1', '', '31', '05', '2020', '2020-05-31 16:16:53', 'ad', '123');

-- --------------------------------------------------------

--
-- Table structure for table `patientdetails`
--

CREATE TABLE `patientdetails` (
  `id` int(11) NOT NULL,
  `patient_id` varchar(255) NOT NULL,
  `patient_name` varchar(255) NOT NULL,
  `address_line_1` varchar(255) NOT NULL,
  `address_line_2` varchar(255) NOT NULL,
  `address_line_3` varchar(255) NOT NULL,
  `age` varchar(255) NOT NULL,
  `sex` varchar(255) NOT NULL,
  `mobile` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `created_by` varchar(255) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patientdetails`
--

INSERT INTO `patientdetails` (`id`, `patient_id`, `patient_name`, `address_line_1`, `address_line_2`, `address_line_3`, `age`, `sex`, `mobile`, `email`, `created_by`, `timestamp`) VALUES
(0, 'sdf', 'sdf', 'sdf', 'sdf', 'sd', 'sdf', 'fsd', 'sd', 'sdf', 'sd', '2020-05-30 21:24:28');

-- --------------------------------------------------------

--
-- Table structure for table `shop`
--

CREATE TABLE `shop` (
  `id` int(11) NOT NULL,
  `order_no` varchar(255) NOT NULL,
  `item_name` varchar(255) NOT NULL,
  `item_code` varchar(255) NOT NULL,
  `qty` varchar(255) NOT NULL,
  `eachprice` varchar(255) NOT NULL,
  `total` varchar(255) NOT NULL,
  `patient_no` varchar(255) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shop`
--

INSERT INTO `shop` (`id`, `order_no`, `item_name`, `item_code`, `qty`, `eachprice`, `total`, `patient_no`, `customer_name`, `date`) VALUES
(1, 'OTHER7', 'dasdas', 'ITEM6', '2', '123', '246', '', 'indunil', '2020-05-31 20:36:06'),
(2, 'OTHER7', 'dasdas', 'ITEM6', '2', '123', '246', '', 'indunil', '2020-05-31 20:36:10'),
(3, 'OTHER3', 'dasdas', 'ITEM6', '2', '123', '246', '0', 'sdf', '2020-05-31 20:57:27'),
(4, 'OTHER4', 'dasdas', 'ITEM6', '12', '123', '1476', '0', 'sdf', '2020-05-31 20:58:15'),
(5, 'OTHER5', 'sad', 'ITEM5', '4', '1111', '4444', 'sdf', 'sdf', '2020-06-03 06:46:01'),
(6, 'OTHER6', 'dasdas', 'ITEM6', '2', '123', '246', 'sdf', 'sdf', '2020-06-05 19:52:06'),
(7, 'OTHER7', 'sad', 'ITEM5', '2', '1111', '2222', 'sdf', 'sdf', '2020-06-06 08:49:15'),
(8, 'OTHER7', 'dasdas', 'ITEM6', '1', '123', '123', 'sdf', 'sdf', '2020-06-06 08:49:23'),
(9, 'OTHER9', 'dasdas', 'ITEM6', '23', '123', '2829', '', 'sasafsa', '2020-06-06 09:00:14'),
(10, 'OTHER10', 'dasdas', 'ITEM6', '1', '123', '123', 'sdf', 'sdf', '2020-06-06 09:02:01');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL,
  `suplier_id` varchar(255) NOT NULL,
  `suplier_name` varchar(255) NOT NULL,
  `adress_line_1` varchar(255) NOT NULL,
  `adress_line_2` varchar(255) NOT NULL,
  `adress_line_3` varchar(255) NOT NULL,
  `contact_person` varchar(255) NOT NULL,
  `mobile_no` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `created_by` varchar(255) NOT NULL,
  `created_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`id`, `suplier_id`, `suplier_name`, `adress_line_1`, `adress_line_2`, `adress_line_3`, `contact_person`, `mobile_no`, `email`, `created_by`, `created_date`) VALUES
(1, 'ad', 'asd', 'asd', 'as', 'asd', 'asd', 'ad', 'ad', 'ad', '2020-05-31 13:16:21'),
(2, 'SUP2', 'ADSA', 'sadsa', 'ASDSA', 'ASDSA', 'ASDAS', 'asdas', 'dasd', 'TEST', '2020-06-05 15:07:33');

-- --------------------------------------------------------

--
-- Table structure for table `treatments`
--

CREATE TABLE `treatments` (
  `id` int(11) NOT NULL,
  `seq_id` varchar(255) NOT NULL,
  `patient_id` varchar(255) NOT NULL,
  `doctor_id` varchar(255) NOT NULL,
  `treatment_type` varchar(255) NOT NULL,
  `other_treatment` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `mr_issue_date` varchar(255) NOT NULL,
  `created_by` varchar(255) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `treatments`
--

INSERT INTO `treatments` (`id`, `seq_id`, `patient_id`, `doctor_id`, `treatment_type`, `other_treatment`, `description`, `mr_issue_date`, `created_by`, `date`) VALUES
(0, 'das', 'das', 'ad', 'das', 'ad', 'asd', 'das', 'das', '2020-06-06 13:51:20'),
(2, 'T1', 'sdf', 'das', 'sfdsfd', 'fdsfds', 'fsdfsdfdsf', '6/6/2020 1:51:47 PM', 'test', '2020-06-06 13:51:47');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `uname` varchar(255) NOT NULL,
  `pword` varchar(255) NOT NULL,
  `privilages` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `uname`, `pword`, `privilages`) VALUES
(1, 'test', 't', 't', '1'),
(2, 'guest', 'g', 'g', '2'),
(3, 'ABC', 'ABC', 'ABC', '4'),
(4, 'AD', 'ASDA', 'ggg', 'p'),
(5, 'INDUNIL', 'I', 'I', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctordetails`
--
ALTER TABLE `doctordetails`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicine_items`
--
ALTER TABLE `medicine_items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patientdetails`
--
ALTER TABLE `patientdetails`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shop`
--
ALTER TABLE `shop`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `treatments`
--
ALTER TABLE `treatments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doctordetails`
--
ALTER TABLE `doctordetails`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medicine_items`
--
ALTER TABLE `medicine_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `patientdetails`
--
ALTER TABLE `patientdetails`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `shop`
--
ALTER TABLE `shop`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `treatments`
--
ALTER TABLE `treatments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
