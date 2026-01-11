DROP DATABASE IF EXISTS db_LibraryCatalogueApp;
CREATE DATABASE IF NOT EXISTS db_LibraryCatalogueApp;

use db_LibraryCatalogueApp;

create table if not exists `Users` (
	id_users int auto_increment primary key,
	username varchar(20) not null,
	passwords varchar(20) not null,
	user_role varchar(6) not null,
	status_del varchar(1) default 'F'
);


create table if not exists `Books` (
	id_books int auto_increment primary key,
	booktitle text not null,
    bookauthors text not null,
    bookyear int not null,
	book_qty int not null,
	status_del varchar(1) default 'F'
);

create table `details` (
	id_users int not null,
	id_books int not null,
	loandate date,
    duedate date,
    returndate date,
    status_del varchar(1) default 'F',
    foreign key (id_users) references `Users`(id_users),
    foreign key (id_books) references `Books`(id_books)
);

insert into `Users` (username, passwords, user_role) values
('Staff', 'staff123', 'Staff'),
('Admin', 'yesme', 'Staff'),
('Ben', '12345', 'Member'),
('Ken', '23456', 'Member'),
('Pen', '34567', 'Member'),
('George', 'george123', 'Member'),
('Hannah', 'hannah123', 'Member'),
('Iris', 'iris123', 'Member'),
('Jack', 'jack123', 'Member'),
('Karen', 'karenstaff', 'Staff'),
('Leo', 'stafftheleo', 'Staff');

insert into `Books` (booktitle, bookauthors, bookyear, book_qty) values
('1984', 'George Orwell', 1984, 2),
('Brave New World', 'Aldous Huxley', 1932, 1),
('Harry Potter', 'JK Rowling', 1997, 5),
('Crime and Punishment', 'Fyodor Dostoevsky', 1866, 3),
('Glencoe World Geography', 'Richard G. Boehm', 1994, 2),
("Charlotte's Web", 'E. B. White', 1952, 4),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 3),
('To Kill a Mockingbird', 'Harper Lee', 1960, 4),
('The Hobbit', 'J.R.R. Tolkien', 1937, 6),
('Pride and Prejudice', 'Jane Austen', 1813, 5),
('The Catcher in the Rye', 'J.D. Salinger', 1951, 3),
('1984 Revisited', 'John Keller', 2020, 2),
('Modern Physics', 'Alice Johnson', 2010, 1),
('The Mystery of the Lost City', 'Lara Winters', 2018, 2),
('Gardening for Beginners', 'Mark Thompson', 2015, 3);

INSERT INTO details (id_users, id_books, loandate, duedate, returndate) VALUES
(4, 3, '2025-12-30', '2026-01-06', '2026-01-05'),
(3, 5, '2026-01-02', '2026-01-09', '2026-01-08'),
(5, 7, '2026-01-04', '2026-01-11', NULL),
(6, 8, '2026-01-04', '2026-01-11', '2026-01-09'),
(9, 4, '2026-01-07', '2026-01-14', NULL);


