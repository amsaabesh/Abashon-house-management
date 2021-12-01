-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2021 at 07:14 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `abashon`
--

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `date` int(5) NOT NULL,
  `house_no` varchar(20) NOT NULL,
  `flat` int(4) NOT NULL,
  `electricity` int(5) NOT NULL,
  `water` int(5) NOT NULL,
  `other` int(5) NOT NULL,
  `gas` int(5) NOT NULL,
  `night_guard` int(5) NOT NULL,
  `yard` int(5) NOT NULL,
  `cleaner` int(5) NOT NULL,
  `servant` int(5) NOT NULL,
  `caretaker` int(5) NOT NULL,
  `total` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`date`, `house_no`, `flat`, `electricity`, `water`, `other`, `gas`, `night_guard`, `yard`, `cleaner`, `servant`, `caretaker`, `total`) VALUES
(521, ' 172/2 North Shyamol', 6, 2700, 6350, 1720, 5850, 600, 800, 360, 1000, 0, 3330),
(621, ' 172/2 North Shyamol', 6, 2700, 2200, 24600, 5850, 600, 800, 360, 1000, 0, 6452),
(721, ' 172/2 North Shyamol', 6, 2700, 5200, 60, 5850, 600, 800, 360, 1000, 0, 2862);

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `NID` bigint(15) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Phone` varchar(11) NOT NULL,
  `Password` varchar(120) NOT NULL,
  `User_Name` varchar(20) NOT NULL,
  `Email` varchar(20) NOT NULL,
  `Photo` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`NID`, `Name`, `Phone`, `Password`, `User_Name`, `Email`, `Photo`) VALUES
(18192103235, ' Shoaib Aabesh', ' 0171850211', '20058ec0e2f94753f5d6b2b36a8596aa', ' Aabesh235', 'mahiraabesh@gmail.co', '');

-- --------------------------------------------------------

--
-- Table structure for table `renter`
--

CREATE TABLE `renter` (
  `Flat_no` int(3) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Mobile` varchar(11) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `NID` varchar(15) NOT NULL,
  `No_Of_Fam_Mem` varchar(15) NOT NULL,
  `Occupation` varchar(15) NOT NULL,
  `Age` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `renter`
--

INSERT INTO `renter` (`Flat_no`, `Name`, `Mobile`, `Email`, `NID`, `No_Of_Fam_Mem`, `Occupation`, `Age`) VALUES
(21, ' shoaib aabesh', '021585888', ' mahiraabesh@gmail.com', '123456789', ' 4', 'Student', 22);

-- --------------------------------------------------------

--
-- Table structure for table `renters_fam_mem`
--

CREATE TABLE `renters_fam_mem` (
  `Flat_no` varchar(15) NOT NULL,
  `M1Name` varchar(20) DEFAULT NULL,
  `M1Mobile` varchar(11) DEFAULT NULL,
  `M1Occupation` varchar(15) DEFAULT NULL,
  `M1Age` int(3) DEFAULT NULL,
  `M2Name` varchar(20) DEFAULT NULL,
  `M2Mobile` varchar(11) DEFAULT NULL,
  `M2Occupation` varchar(15) DEFAULT NULL,
  `M2Age` int(3) DEFAULT NULL,
  `M3Name` varchar(20) DEFAULT NULL,
  `M3Mobile` varchar(11) DEFAULT NULL,
  `M3Occupation` varchar(15) DEFAULT NULL,
  `M3Age` int(3) DEFAULT NULL,
  `M4Name` varchar(20) DEFAULT NULL,
  `M4Mobile` varchar(11) DEFAULT NULL,
  `M4Occupation` varchar(15) DEFAULT NULL,
  `M4Age` int(3) DEFAULT NULL,
  `M5Name` varchar(20) DEFAULT NULL,
  `M5Mobile` varchar(11) DEFAULT NULL,
  `M5Occupation` varchar(15) DEFAULT NULL,
  `M5Age` int(3) DEFAULT NULL,
  `SName` varchar(20) DEFAULT NULL,
  `SMobile` varchar(11) DEFAULT NULL,
  `SAge` int(3) DEFAULT NULL,
  `DName` varchar(20) DEFAULT NULL,
  `DMobile` varchar(11) DEFAULT NULL,
  `DAge` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`date`);

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`User_Name`,`NID`);

--
-- Indexes for table `renter`
--
ALTER TABLE `renter`
  ADD PRIMARY KEY (`Flat_no`);

--
-- Indexes for table `renters_fam_mem`
--
ALTER TABLE `renters_fam_mem`
  ADD PRIMARY KEY (`Flat_no`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
