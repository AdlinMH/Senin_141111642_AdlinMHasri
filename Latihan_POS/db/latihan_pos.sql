-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 30, 2016 at 01:46 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latihan_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id` int(10) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga_beli` decimal(10,2) NOT NULL,
  `harga_jual` decimal(10,2) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id`, `kode`, `nama`, `jumlah`, `harga_beli`, `harga_jual`, `created_at`, `updated_at`) VALUES
(6, 'ITEM-1', 'Kecap Sedap 100ml', 400, '2000.00', '2500.00', '2016-12-30 10:26:53', '2016-12-30 10:26:53'),
(7, 'ITEM-2', 'Gula Merah', 456, '5000.00', '5400.00', '2016-12-30 10:27:26', '2016-12-30 10:27:26'),
(8, 'ITEM-3', 'Teh Botol Sosro', 202, '3500.00', '4000.00', '2016-12-30 12:33:48', '2016-12-30 12:33:48');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `kota` varchar(30) NOT NULL,
  `kode_pos` varchar(6) NOT NULL,
  `noHp` varchar(15) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `nama`, `alamat`, `kota`, `kode_pos`, `noHp`, `created_at`, `updated_at`) VALUES
(3, 'Hode', 'Nirmaht', 'Nadem', '20212', '081123123123', '2016-12-21 22:19:50', '2016-12-22 10:31:17'),
(4, 'Adlin Muh', 'Jl. Perdana ||', 'Batam', '20229', '081234567891', '2016-12-28 11:02:29', '2016-12-28 11:07:20');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `id` int(11) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `id_supplier` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`id`, `kode`, `id_supplier`, `created_at`, `updated_at`) VALUES
(2, 'test', 6, '2016-12-22 16:40:41', '2016-12-22 16:40:41'),
(3, 'Inp1', 6, '2016-12-22 16:41:42', '2016-12-22 16:41:42'),
(4, 'test2', 6, '2016-12-22 16:43:07', '2016-12-22 16:43:07'),
(5, 'test32', 6, '2016-12-22 16:44:08', '2016-12-22 16:44:08'),
(6, 'testestt', 3, '2016-12-22 16:44:25', '2016-12-22 16:44:25'),
(7, 'testestete', 3, '2016-12-22 16:44:56', '2016-12-22 16:44:56'),
(8, 'safdsfads', 3, '2016-12-22 16:45:32', '2016-12-22 16:45:32'),
(9, 'test2131232131', 3, '2016-12-22 16:47:02', '2016-12-22 16:47:02'),
(11, 'asd', 1, '2016-12-26 18:16:29', '2016-12-26 18:16:29'),
(12, 'bac', 1, '2016-12-26 18:18:08', '2016-12-26 18:18:08'),
(13, '01', 1, '2016-12-26 23:23:37', '2016-12-26 23:23:37'),
(14, '04', 1, '2016-12-26 23:39:30', '2016-12-26 23:39:30'),
(15, 'j3', 1, '2016-12-26 23:40:12', '2016-12-26 23:40:12'),
(16, 'abc12', 1, '2016-12-26 23:40:52', '2016-12-26 23:40:52'),
(17, '', 6, '2016-12-27 00:33:49', '2016-12-27 00:33:49'),
(18, 'BELI-1', 9, '2016-12-30 10:52:25', '2016-12-30 10:52:25');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `id` int(11) NOT NULL,
  `kode_pembelian` varchar(100) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(10,0) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian_detail`
--

INSERT INTO `pembelian_detail` (`id`, `kode_pembelian`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(2, 'test', 6, '100000', 2, '2016-12-22 16:40:41', '2016-12-22 16:43:02'),
(3, 'lnp1', 6, '100000', 1, '2016-12-22 16:41:42', '2016-12-22 18:33:01'),
(4, 'test2', 6, '100000', 1, '2016-12-22 16:43:07', '2016-12-22 16:43:07'),
(5, 'test32', 6, '100000', 1, '2016-12-22 16:44:08', '2016-12-22 16:44:08'),
(6, 'testestt', 5, '100000', 1, '2016-12-22 16:44:25', '2016-12-22 16:44:25'),
(7, 'testestete', 5, '100000', 2, '2016-12-22 16:44:56', '2016-12-22 16:44:56'),
(8, 'safdsfads', 5, '100000', 12, '2016-12-22 16:45:32', '2016-12-22 16:45:32'),
(9, 'test2131232131', 5, '100000', 1, '2016-12-22 16:47:02', '2016-12-22 16:47:02'),
(10, '04', 1, '0', 0, '2016-12-26 23:39:30', '2016-12-26 23:39:30'),
(11, 'j3', 1, '0', 0, '2016-12-26 23:40:12', '2016-12-26 23:40:12'),
(12, 'abc12', 1, '103809138', 6, '2016-12-26 23:40:52', '2016-12-26 23:40:52'),
(13, 'abc12', 1, '103809138', 12, '2016-12-26 23:42:34', '2016-12-26 23:42:34'),
(14, 'test2', 6, '200000', 7, '2016-12-26 23:44:15', '2016-12-26 23:44:15'),
(15, 'test2', 6, '200000', 7, '2016-12-26 23:44:35', '2016-12-26 23:44:35'),
(16, 'test2', 1, '103809138', 6, '2016-12-26 23:46:08', '2016-12-26 23:46:08'),
(17, '', 6, '200000', 6, '2016-12-27 00:33:49', '2016-12-27 00:33:49'),
(18, 'BELI-1', 6, '2000', 10, '2016-12-30 10:52:25', '2016-12-30 10:52:25');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `id` int(11) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `id_customer` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`id`, `kode`, `id_customer`, `created_at`, `updated_at`) VALUES
(1, 'FAK-001', 3, '2016-12-22 14:05:45', '2016-12-22 14:05:45'),
(2, 'FAK-002', 3, '2016-12-22 14:46:43', '2016-12-22 14:46:43'),
(3, 'FAK-003', 3, '2016-12-22 15:25:55', '2016-12-22 15:25:55'),
(5, 'FAK-006', 3, '2016-12-27 05:28:34', '2016-12-27 05:28:34'),
(6, 'FAK-004', 2, '2016-12-27 05:28:58', '2016-12-27 05:28:58'),
(7, 'FAK-0010', 1, '2016-12-27 05:33:05', '2016-12-27 05:33:05'),
(8, 'Fak-1001', 1, '2016-12-27 05:33:54', '2016-12-27 05:33:54'),
(9, 'FAK002', 1, '2016-12-27 05:36:54', '2016-12-27 05:36:54'),
(10, 'FAK01', 1, '2016-12-27 05:37:58', '2016-12-27 05:37:58'),
(11, 'a', 3, '2016-12-27 05:41:38', '2016-12-27 05:41:38'),
(12, 'FAK-005', 4, '2016-12-30 11:06:40', '2016-12-30 11:06:40');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan_detail`
--

CREATE TABLE `penjualan_detail` (
  `id` int(11) NOT NULL,
  `kode_penjualan` varchar(50) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `harga_barang` decimal(10,2) NOT NULL,
  `kuantitas` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan_detail`
--

INSERT INTO `penjualan_detail` (`id`, `kode_penjualan`, `id_barang`, `harga_barang`, `kuantitas`, `created_at`, `updated_at`) VALUES
(1, 'FAK-001', 6, '100000.00', 15, '2016-12-22 15:14:02', '2016-12-22 18:26:40'),
(2, 'FAK-003', 6, '100000.00', 4, '2016-12-22 15:25:55', '2016-12-22 15:25:58'),
(3, 'FAK01', 1, '1005100.00', 9, '2016-12-27 05:37:58', '2016-12-27 05:37:58'),
(4, 'FAK01', 1, '1005100.00', 6, '2016-12-27 05:38:39', '2016-12-27 05:38:39'),
(5, 'FAK-002', 6, '7000000.00', 8, '2016-12-27 05:39:55', '2016-12-27 05:39:55'),
(6, 'a', 1, '1005100.00', 2, '2016-12-27 05:41:38', '2016-12-27 05:41:38'),
(7, 'FAK-004', 7, '5400.00', 3, '2016-12-30 10:53:35', '2016-12-30 10:53:35'),
(8, 'FAK-005', 6, '2500.00', 2000, '2016-12-30 11:06:40', '2016-12-30 11:06:40');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(10) DEFAULT NULL,
  `Nama` varchar(20) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `Kota` varchar(30) DEFAULT NULL,
  `Contact` varchar(15) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Join_at` datetime DEFAULT NULL,
  `Edit_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID`, `Kode`, `Nama`, `Alamat`, `Kota`, `Contact`, `Created_at`, `Join_at`, `Edit_at`) VALUES
(9, 'SUP-1', 'PT. Maju Mundur', 'Jl. Gudang Garam', 'Medan', '0812345', '2016-12-30 10:30:32', '2016-12-30 10:30:32', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kode` (`kode`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `penjualan_detail`
--
ALTER TABLE `penjualan_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
