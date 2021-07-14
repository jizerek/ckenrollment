-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 27, 2021 at 04:47 AM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `school db`
--

-- --------------------------------------------------------

--
-- Table structure for table `accdb`
--

CREATE TABLE `accdb` (
  `Employee_ID` varchar(250) NOT NULL,
  `Name` varchar(250) NOT NULL,
  `Lastname` varchar(250) NOT NULL,
  `Firstname` varchar(250) NOT NULL,
  `Middlename` varchar(250) NOT NULL,
  `Suffix` varchar(250) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `Gender` varchar(250) NOT NULL,
  `Birthday` varchar(250) NOT NULL,
  `Age` varchar(250) NOT NULL,
  `Position` varchar(250) NOT NULL,
  `Contact_Number` varchar(250) NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL,
  `Picture` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accdb`
--

INSERT INTO `accdb` (`Employee_ID`, `Name`, `Lastname`, `Firstname`, `Middlename`, `Suffix`, `Address`, `Gender`, `Birthday`, `Age`, `Position`, `Contact_Number`, `Username`, `Password`, `Picture`) VALUES
('034184081540', 'Ramirez, Jessie RHic, Tanglao ', 'Ramirez', 'Jessie RHic', 'Tanglao', '', 'Marilao Bulacan', 'Male', '5/18/2000', '21', 'Admin', '09086677408', 'jizibui', 'jessierhic18', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\1x1.jpg'),
('626060699025', 'Ramirez , Jessie, Rhic JR', 'Ramirez ', 'Jessie', 'Rhic', 'JR', 'Bulacan', 'Male', '6/16/1999', '22', 'Registrar', '09086677408', 'jizerek', 'jessierhic18', 'C:\\JIZEBUI\\ckenrollment\\ckenrollment\\Enrollment\\bin\\pics\\1x1.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `archives`
--

CREATE TABLE `archives` (
  `ID` varchar(250) NOT NULL,
  `Name` varchar(250) NOT NULL,
  `Date_Deleted` varchar(250) NOT NULL,
  `Time_Deleted` varchar(250) NOT NULL,
  `Contact` varchar(250) NOT NULL,
  `Gender` varchar(250) NOT NULL,
  `Position` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `Name` varchar(250) NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Position` varchar(250) NOT NULL,
  `Time` varchar(250) NOT NULL,
  `Date` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`Name`, `Username`, `Position`, `Time`, `Date`) VALUES
('Ramirez, Jessie RHic, Tanglao ', 'jizibui', 'Admin', '02:13:32', '05-26-2021 '),
('Ramirez , Jessie, Rhic JR', 'jizerek', 'Registrar', '02:19:54', '05-26-2021 ');

-- --------------------------------------------------------

--
-- Table structure for table `studentsdb`
--

CREATE TABLE `studentsdb` (
  `Grade_Level` varchar(250) NOT NULL,
  `Student_Type` varchar(250) NOT NULL,
  `Section` varchar(250) NOT NULL,
  `LRN` varchar(250) NOT NULL,
  `Lastname` varchar(250) NOT NULL,
  `Firstname` varchar(250) NOT NULL,
  `Middlename` varchar(250) NOT NULL,
  `Suffix` varchar(250) NOT NULL,
  `Student_Name` varchar(250) NOT NULL,
  `Gender` varchar(250) NOT NULL,
  `Birthday` varchar(250) NOT NULL,
  `Birthplace` varchar(250) NOT NULL,
  `Age` varchar(250) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `Enrolled` varchar(250) NOT NULL,
  `Student_Picture` varchar(250) NOT NULL,
  `Father_Name` varchar(250) NOT NULL,
  `Father_Occupation` varchar(250) NOT NULL,
  `Father_Contact` varchar(250) NOT NULL,
  `Mother_Name` varchar(250) NOT NULL,
  `Mother_Occupation` varchar(250) NOT NULL,
  `Mother_Contact` varchar(250) NOT NULL,
  `Guardian` varchar(250) NOT NULL,
  `Guardian_Address` varchar(250) NOT NULL,
  `Guardian_Contact` varchar(250) NOT NULL,
  `TuitionFee` varchar(250) NOT NULL,
  `Balance` varchar(250) NOT NULL,
  `Date_Enrolled` varchar(250) NOT NULL,
  `Time_Enrolled` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentsdb`
--

INSERT INTO `studentsdb` (`Grade_Level`, `Student_Type`, `Section`, `LRN`, `Lastname`, `Firstname`, `Middlename`, `Suffix`, `Student_Name`, `Gender`, `Birthday`, `Birthplace`, `Age`, `Address`, `Enrolled`, `Student_Picture`, `Father_Name`, `Father_Occupation`, `Father_Contact`, `Mother_Name`, `Mother_Occupation`, `Mother_Contact`, `Guardian`, `Guardian_Address`, `Guardian_Contact`, `TuitionFee`, `Balance`, `Date_Enrolled`, `Time_Enrolled`) VALUES
('1', 'New', 'A', '135812596857', 'Ramirez ', 'Jessie Rhic', 'Tanglao', '', 'Ramirez , Jessie Rhic,  ', 'Male', '6/4/2013', 'Manila', '8', 'Manila', 'Unofficial', 'C:\\JIZEBUI\\ckenrollment\\ckenrollment\\Enrollment\\bin\\pics\\Male.jpg', 'R Ramirez', 'Teacher', '09412421512', 'B Ramirez', 'Teacher', '09124479412', 'R Ramirez', 'Manila', '09124210412', '29000', '29000', '05-25-2021 ', '07:06:04'),
('2', 'Old', 'A', '124809840928', 'Ra', 'Jes', 'Tan', '', 'R, Jes, Tan ', 'Male', '7/16/2013', 'Manila', '8', 'Manila', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'Tan', 'Seaman', '09021412412', 'Ren', 'Tambay', '09421412094', 'Tan', 'Manila', '09898024124', '30500', '30500', '05-25-2021 ', '07:10:22'),
('3', 'Old', 'A', '214125215151', 'Ram', 'Jes', 'Wa', '', 'Ram, Jes, Wa ', 'Female', '7/16/2013', 'Manila', '8', 'Manila', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\female.jpg', 'Man', 'Men', '09214724812', 'Women', 'Women', '09124124798', 'Women', 'Manila', '09124791248', '33800', '33800', '05-25-2021 ', '07:33:16'),
('6', 'Old', 'A', '012480214791', 'Rami', 'Imar', 'Mar', '', 'Rami, Imar,  ', 'Male', '7/21/2009', 'Manila', '12', 'Manila', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'Lalaki', 'Men', '09127492487', 'Women', 'Bouncer', '09712412421', 'Men', 'Manila', '09849248012', '49200', '49200', '05-25-2021 ', '07:34:11'),
('1', 'New', 'B', '361125548305', 'Aviles', 'Leica', 'Tanglao', '', 'Aviles, Leica, Tanglao ', 'Female', '6/9/2014', 'Manila', '7', 'Bulacan', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\female.jpg', 'Fujimoto', 'Teacher', '0974718231', 'Ramirez', 'Teacher', '09247231231', 'Fujimoto', 'Manila', '09012841241', '29000', '29000', '05-25-2021 ', '07:43:27'),
('2', 'New', 'A', '124125251241', 'rasadada', 'dasdasd', 'Ramr', '', 'rasadada, dasdasd, Ramr ', 'Male', '6/12/2013', 'Manila', '8', 'Bulacan', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'Papa', 'Teacher', '09087410241', 'Mama', 'Teacher', '09841241241', 'Tita', 'Bulacan', 'Tae', '30500', '30500', '05-25-2021 ', '07:43:38'),
('3', 'Old', 'A', '211412511212', 'dadasd', 'dadas', 'dasda', '', 'dadasd, dadas, dasda ', 'Male', '7/13/2010', 'Quezon', '11', 'Bulacan', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'PAPA', 'S', '09471247012', 'MAMA', 'T', '09097409724', 'Secret', 'Bulacan', '090971989203', '33800', '33800', '05-25-2021 ', '07:43:49'),
('4', 'Old', 'A', '125125112512', 'sadasdada', 'Sec', 'asd', '', 'sadasdada, Sec, asd ', 'Male', '7/14/2011', 'Capiz', '10', 'Secret', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'Jes', 'R', '09024912-41', 'Sya', 'T', '0971249412', 'ST', 'BUlacan', 'R', '37800', '37800', '05-25-2021 ', '07:44:00'),
('5', 'Old', 'A', '124124141241', 'RAmirez', 'asdaddas', 'fas', '', 'RAmirez, asdaddas, fas ', 'Male', '5/6/2010', 'Caloocan', '11', 'Caloocan', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'asdad', 'asda', '09981247120', 'afas', '12124', '09012480914', 'Bul', 'Bulacan', '0909210492', '42000', '42000', '05-25-2021 ', '07:44:07'),
('6', 'Old', 'A', '124124121214', 'RAasd', 'asd', 'asda', '', 'RAasd, asd, asda ', 'Male', '11/13/2008', 'Bul', '13', 'Manilaasd', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'asasd', 'adsad', '0975253241', 'sdad', 'asdad', '09127414891', 'asdaf', 'falksjdasd', '0951231231', '49200', '49200', '05-25-2021 ', '07:44:14'),
('1', 'New', 'A', '656042362489', '', '', '', '', '', '', '5/25/2021', '', '', '', 'Unofficial', '  ', '', '', '', '', '', '', '', '', '', '29000', '29000', '05-25-2021 ', '07:48:18'),
('6', '', '', '', '', '', '', '', '', '', '5/25/2021', '', '0', '', 'Unofficial', '', '', '', '', '', '', '', '', '', '', '49200', '49200', '05-25-2021 ', '07:48:22'),
('1', 'New', 'A', '925413208931', 'asdsadd', 'asdsad', 'adsasd', 'dsasd', '', 'Male', '8/15/2005', 'fasfsaaa', '16', 'dasdsadadasas', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'dasdasdad', 'asdasdada', '09120412421', '12123asdasda', 'asdadda', '09898491248', 'asffas', 'aadsadad', '09148712471', '29000', '29000', '05-25-2021 ', '07:48:58'),
('6', 'Old', 'A', '124124124141', 'da', 'asdd', 'sdsdaad', 'asda', 'da, asdd, sdsdaad asda', 'Male', '7/20/2010', 'adasd', '11', 'asdads', 'Unofficial', 'C:\\JIZEBUI\\ckenrollment\\ckenrollment\\Enrollment\\bin\\pics\\female.jpg', 'adads', 'asddasd', '09412414141', 'adadad', 'asdsdad', '09124124124', 'adasd', 'asdasdasda', '09124412414', '49200', '49200', '05-25-2021 ', '07:49:28'),
('6', 'Old', 'A', '412411242141', 'sadasdasd', 'adasdsad', 'sadsadsad', '', '', 'Male', '5/25/2005', 'aadr', '16', 'dadads', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'adsasd', 'dasdasad', '09313312312', 'dadaad', 'adsadasd', '09090909090', 'asdadd', '1231124', '59090086332', '49200', '49200', '05-25-2021 ', '07:50:01'),
('1', 'Old', 'B', '325364216227', 'Ramirez', 'Jessie', 'Se', '', 'Ramirez, Jessie,  ', 'Male', '7/16/2014', 'Secret', '7', 'Secret', 'Unofficial', 'C:\\Users\\Jessie Rhic\\Documents\\Visual Studio 2015\\Projects\\Enrollment\\Enrollment\\Enrollment\\bin\\pics\\Male.jpg', 'asdasd', 'asdasd', '09109247988', 'shdadla', 'hsahdad', '09184712470', 'jakldjas', 'adjkld', '09084120480', '29000', '29000', '05-25-2021 ', '08:09:38'),
('6', 'Old', 'A', '223505050161', 'Ramirez', 'Jessie Rhic', 'Tanglao', '', 'Ramirez, Jessie Rhic, Tanglao ', 'Male', '5/11/2000', 'Manila', '21', 'Bulacan', 'Unofficial', 'C:\\JIZEBUI\\ckenrollment\\ckenrollment\\Enrollment\\bin\\pics\\1x1.jpg', 'Ramirez', 'Teacher', '09412414131', 'Ramirez', 'Teacher', '09124124123', 'Ramirez', 'Bulacan', '09102491412', '49200', '49200', '05-26-2021 ', '02:34:54');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
