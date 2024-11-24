--DDL
CREATE DATABASE PB502
DROP DATABASE PB502
USE PB502

CREATE TABLE Students
(
 Id int,
 [Name] nvarchar(10),
 Age int,
 IsMarried bit
)
DROP TABLE Students

ALTER TABLE Students ADD Email nvarchar(15) 
ALTER TABLE Students DROP COLUMN Email
EXEC sp_rename Students,Student
EXEC sp_rename Student,Students
EXEC sp_rename 'Students.Age',Yas
EXEC sp_rename 'Students.Yas',Age

ALTER TABLE Students
ALTER COLUMN Age nvarchar(10);

TRUNCATE TABLE Students

--DML
INSERT INTO Students 
VALUES
(2,'Asif',20,0,'asif@gmail.com'),
(3,'Yusif',20,0,'yusif@gmail.com'),
(4,'Nesib',20,0,'nesib@gmail.com')

INSERT INTO Students 
VALUES
(2,'Fidan',20,0,'fidan@gmail.com')

INSERT INTO Students 
(Id,[Name],IsMarried,Email)
VALUES
(2,'Samir',0,'samir@gmail.com')

DELETE FROM Students WHERE Id<3 AND Age IS NULL
DELETE FROM Students WHERE Id IN(2,3,45)

UPDATE Students 
SET Age=25 WHERE [Name]='Nesib'

SELECT Id AS AYDI,Name Ad FROM Students
SELECT * FROM Students WHERE [Name] LIKE '%if%'

SELECT * FROM Students

SELECT LEN(Name) 'Uzun luq' FROM Students WHERE Id=2

SELECT CHARINDEX('@',Email) as [Index],Email FROM Students


SELECT SUBSTRING(Email,1,5),Email FROM Students 

SELECT SUBSTRING(Email,1,CHARINDEX('@',Email)-1),Email FROM Students 

SELECT SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)),Email FROM Students 

SELECT SUM(AGE) FROM Students

SELECT AVG(AGE) FROM Students

SELECT MIN(AGE) FROM Students

SELECT MAX(AGE) FROM Students

SELECT * FROM Students WHERE Age> AVG(AGE) FROM Students) OR Age IS NOT NULL

--constraint
DROP TABLE Students
CREATE TABLE Students
(
 Id int primary key identity,
 [Name] nvarchar(10) NOT NULL,
 Age int CHECK(Age>0AND Age<25),
 IsMarried bit,
 SurName nvarchar(20) DEFAULT 'Lorem',
 Email nvarchar(20) unique
)

INSERT INTO Students 
(Name,Age,IsMarried,Email)
VALUES
('Senan',20,0,'senan@gmail.com'),
('Ramil',20,0,'ramil@gmail.com'),
('Tahir',20,0,'tahir@gmail.com')

INSERT INTO Students 
VALUES
('Cavid',20,0,'Ibadov','cavid@gmail.com')

ALTER TABLE Students
DROP CONSTRAINT UQ__Students__A9D10534A70F26C4
ALTER TABLE Students ADD Email nvarchar(20)

ALTER TABLE Students
ADD CONSTRAINT UC_Student_123 UNIQUE (Email)

SELECT * FROM Students
DELETE FROM Students
DROP TABLE Students

CREATE DATABASE PB502Demo
USE PB502Demo

CREATE TABLE Groups
(
 Id int primary key identity,
 [Name] nvarchar(10) NOT NULL
)
CREATE TABLE Students
(
 Id int primary key identity,
 GroupId int foreign key references Groups(Id)
)

CREATE TABLE StudentDetails
(
 Id int primary key identity,
 Age int CHECK(Age>0AND Age<25),
 IsMarried bit,
 SurName nvarchar(20) DEFAULT 'Lorem',
 Email nvarchar(20) unique,
 StudentId int foreign key references Students(Id)
)

CREATE TABLE Books
(
 Id int primary key identity,
 [Name] nvarchar(10) NOT NULL
)
CREATE TABLE Genres
(
 Id int primary key identity,
 [Name] nvarchar(10) NOT NULL
)
CREATE TABLE BookGenres
(
 Id int primary key identity,
  BookId int foreign key references Books(Id),
   GenreId int foreign key references Genres(Id)
)
