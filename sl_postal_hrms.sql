-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 01, 2026 at 07:26 AM
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
-- Database: `sl_postal_hrms`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `id` int(11) NOT NULL,
  `nic` varchar(20) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id`, `nic`, `date`, `time_in`, `time_out`) VALUES
(1, '200063200720', '2026-11-01', '00:01:45', '00:01:49'),
(2, '123456789V', '2026-11-01', '02:16:12', '02:16:15');

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `id` int(11) NOT NULL,
  `nic` varchar(20) DEFAULT NULL,
  `feedback_text` text DEFAULT NULL,
  `date_submitted` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`id`, `nic`, `feedback_text`, `date_submitted`) VALUES
(1, '200063200720', 'Subject: Delay in Registered Mail Delivery\nCategory: Mail\nPriority: Medium\nDescription: I sent a registered letter 10 days ago, but the recipient has still not received it. I would like to know the current status of the delivery and the reason for the delay.', '2026-10-31 19:55:48'),
(2, '200063200720', 'Subject: Incorrect Salary Calculation\nCategory: Salary & Payroll\nPriority: High\nDescription: I noticed that my salary for this month is lower than the amount I usually receive. I believe there may be an error in calculating my overtime payments. Kindly review my salary details and resolve this issue.', '2026-10-31 19:56:33'),
(3, '200063200720', 'Subject: Leave Request Not Approved\n\n\nCategory: Leave Management\n\nPriority: Medium\n\n\nDescription: I submitted a leave request through the HRMS several days ago, but its status is still pending. I need confirmation because I have already planned my personal activities based on this leave.', '2026-10-31 19:57:23'),
(4, '200063200720', 'Subject: Inappropriate Behaviour by a Colleague\r\n\r\nCategory: Employee Relations\r\n\r\nPriority: High\r\n\r\nDescription: I would like to report repeated inappropriate behaviour from a colleague in my department. This behaviour has made me uncomfortable in the workplace. I kindly request HR to investigate this matter confidentially.', '2026-10-31 19:57:44'),
(5, '200063200720', 'Subject: Employee Loan Application Delay\r\n\r\nCategory: Employee Loan\r\n\r\nPriority: Medium\r\n\r\nDescription: I submitted an employee loan application more than two weeks ago, but I have not received any updates regarding its approval. I would appreciate it if HR could provide information about the current status.', '2026-10-31 19:59:02');

-- --------------------------------------------------------

--
-- Table structure for table `leaves`
--

CREATE TABLE `leaves` (
  `id` int(11) NOT NULL,
  `nic` varchar(20) DEFAULT NULL,
  `leave_type` varchar(50) DEFAULT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `reason` text DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `leaves`
--

INSERT INTO `leaves` (`id`, `nic`, `leave_type`, `start_date`, `end_date`, `reason`, `status`) VALUES
(1, '123456789V', 'Annual', '2026-10-31', '2026-10-31', 'asasa', 'Rejected'),
(2, '123456789V', 'Sick', '2026-10-31', '2026-11-01', 'Im not feeling well today, So I won\'t be able to come to work', 'Approved'),
(3, '200063200720', 'Sick', '2026-11-01', '2026-11-01', 'Sick Leave', 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `salaries`
--

CREATE TABLE `salaries` (
  `id` int(11) NOT NULL,
  `nic` varchar(20) DEFAULT NULL,
  `month` varchar(20) DEFAULT NULL,
  `basic_salary` decimal(10,2) DEFAULT NULL,
  `allowances` decimal(10,2) DEFAULT NULL,
  `deductions` decimal(10,2) DEFAULT NULL,
  `net_salary` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `salaries`
--

INSERT INTO `salaries` (`id`, `nic`, `month`, `basic_salary`, `allowances`, `deductions`, `net_salary`) VALUES
(1, '200063200720', 'October 2026', 50000.00, 5000.00, 2000.00, 53000.00),
(2, '123456789V', '50000', 0.00, 65000.00, 200.00, 64800.00),
(3, '200369333256', '60000', 60000.00, 1000.00, 200.00, 60800.00),
(4, '200369333256', '600', 60000.00, 1200.00, 200.00, 61000.00),
(5, '123456789V', '60000', 0.00, 62000.00, 200.00, 61800.00),
(6, '123456789V', '60000', 0.00, 62000.00, 200.00, 61800.00),
(7, '123456789V', '60000', 0.00, 62000.00, 200.00, 61800.00),
(8, '123456789V', '60000', 0.00, 62000.00, 200.00, 61800.00),
(9, '123456789V', '60000', 0.00, 61000.00, 200.00, 60800.00),
(10, '123456789V', '60000', 0.00, 65000.00, 2000.00, 63000.00),
(11, '123456789V', '60000', 0.00, 62000.00, 200.00, 61800.00),
(12, '200056500265', '62000', 0.00, 62500.00, 200.00, 62300.00);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `nic` varchar(12) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` varchar(50) DEFAULT 'Employee',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `department` varchar(50) DEFAULT 'General',
  `basic_salary` decimal(10,2) DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`nic`, `full_name`, `password_hash`, `role`, `created_at`, `department`, `basic_salary`) VALUES
('123456789V', 'M M Madanayake', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Employee', '2026-10-31 16:50:57', 'General', 0.00),
('123654987V', 'L N K Perera', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Employee', '2026-11-01 06:03:40', 'General', 60000.00),
('200056500265', 'P S Madanayake', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Accountant', '2026-10-31 18:47:16', 'General', 0.00),
('200063200720', 'S M Perera', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Employee', '2026-10-31 17:13:27', 'General', 0.00),
('200326300465', 'L S Shakira', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Superintendent', '2026-10-31 17:44:32', 'General', 0.00),
('200369333256', 'S G Saranga', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Employee', '2026-10-31 18:40:52', 'General', 60000.00),
('987654321V', 'N S Rajapaksha', '422ad3fc127eb248695f259a207792238f5bce2a4e22b547243f948b1cd2cac7', 'Superintendent', '2026-10-31 17:49:58', 'General', 0.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nic` (`nic`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nic` (`nic`);

--
-- Indexes for table `leaves`
--
ALTER TABLE `leaves`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nic` (`nic`);

--
-- Indexes for table `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nic` (`nic`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`nic`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `leaves`
--
ALTER TABLE `leaves`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `salaries`
--
ALTER TABLE `salaries`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`nic`) REFERENCES `users` (`nic`);

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`nic`) REFERENCES `users` (`nic`);

--
-- Constraints for table `leaves`
--
ALTER TABLE `leaves`
  ADD CONSTRAINT `leaves_ibfk_1` FOREIGN KEY (`nic`) REFERENCES `users` (`nic`);

--
-- Constraints for table `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`nic`) REFERENCES `users` (`nic`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
