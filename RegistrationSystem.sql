-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Июн 23 2020 г., 21:47
-- Версия сервера: 10.4.11-MariaDB
-- Версия PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `registrationsystem`
--
CREATE DATABASE IF NOT EXISTS `registrationsystem` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `registrationsystem`;

-- --------------------------------------------------------

--
-- Структура таблицы `incidents`
--

CREATE TABLE `incidents` (
  `id` int(50) NOT NULL,
  `Category` varchar(30) NOT NULL,
  `Country` varchar(40) NOT NULL,
  `Address` varchar(25) NOT NULL,
  `Date` date NOT NULL,
  `Affected` varchar(30) NOT NULL,
  `Description` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `incidents`
--

INSERT INTO `incidents` (`id`, `Category`, `Country`, `Address`, `Date`, `Affected`, `Description`) VALUES
(30, 'Пожар ', 'Астрахань', 'Ул.Колхозная б2', '2020-05-23', 'Два человека', 'Два человека сгорели в машине'),
(31, 'Дорожно-транспортное происшест', 'Астрахань', 'Ул.Пушкина', '2020-06-05', 'Нету', 'Две машины столкнулись'),
(32, 'Убийство', 'Астрахань', 'Ул.Есенина', '2020-06-24', 'Один человек', 'Застрелили человека из пистолета'),
(33, 'Повреждения при стихийных бедс', 'Астрахань', 'Ул.Заводная с3', '2020-05-22', 'Нету', 'Затопило дом'),
(34, 'Падение, обрушение, обвалы пре', 'Астрахань', 'Ул.Красная б3', '2020-06-15', 'Пять человек', 'Обрушилось здание на людей'),
(35, 'Потоп', 'Астрахань', 'Ул.Набережная с3', '2020-04-08', 'Один человек', 'Утонул человек'),
(36, 'Другое', 'Астрахань', 'Ул.Центральная с3', '2020-05-23', 'Два человека', 'В ходе драки пострадали два человека');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(50) NOT NULL,
  `Role` int(4) NOT NULL DEFAULT 2,
  `name` varchar(15) NOT NULL,
  `login` varchar(20) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `Role`, `name`, `login`, `password`) VALUES
(2, 1, 'admin', 'admin', 'root'),
(10, 2, 'Вася', 'User1', 'User01'),
(11, 2, 'Дима', 'User2', 'User02'),
(12, 2, 'Коля', 'User3', 'User03'),
(13, 2, 'Петя', 'User4', 'User04');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `incidents`
--
ALTER TABLE `incidents`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `incidents`
--
ALTER TABLE `incidents`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
