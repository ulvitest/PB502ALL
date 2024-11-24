DROP DATABASE PB502
CREATE DATABASE PB502
USE PB502
CREATE TABLE Students
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20),
Age int,
Email nvarchar(20)
)
ALTER TABLE Students DROP COLUMN Email
ALTER TABLE Students ADD Surname  nvarchar(20)

CREATE TABLE StudentDetails
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20),
PhoneNumber nvarchar(20),
[Address] nvarchar(20),
StudentId int FOREIGN KEY REFERENCES Students(Id)
)
ALTER TABLE StudentDetails DROP COLUMN [Name]

--INNER JOIN
SELECT s.Id StuId,s.Name StuName,s.Age,st.PhoneNumber,st.Address FROM Students s
JOIN StudentDetails  st
ON
s.Id=st.StudentId

--LEFT JOIN
SELECT s.Id StuId,s.Name StuName,s.Age,st.PhoneNumber,st.Address FROM Students s
LEFT JOIN StudentDetails  st
ON
s.Id=st.StudentId

--RIGHT JOIN
SELECT s.Id StuId,s.Name StuName,s.Age,st.PhoneNumber,st.Address FROM Students s
RIGHT JOIN StudentDetails  st
ON
s.Id=st.StudentId

--FULL OUTER JOIN
SELECT s.Id StuId,s.Name StuName,s.Age,st.PhoneNumber,st.Address FROM Students s
FULL OUTER JOIN  StudentDetails  st
ON
s.Id=st.StudentId

--SELF JOIN

CREATE TABLE Positions
(
Id int PRIMARY KEY IDENTITY,
Duty nvarchar(20),
ParentId int
)

SELECT p.Duty ,a.Duty ParentName FROM Positions p
JOIN Positions a
ON
p.ParentId=a.Id

--CROSS JOIN

CREATE TABLE Poducts
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20)
)

CREATE TABLE Sizes
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20)
)
SELECT p.Name ProductName,s.Name SizeName FROM Poducts p
CROSS JOIN
Sizes s

--non equi join

ALTER TABLE Students ADD Point  decimal(18,2)

CREATE TABLE Grades
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20),
MinGrade int,
MaxGrade int
)

SELECT s.*,g.Name FROM Students s
JOIN 
Grades g
ON
s.Point>=g.MinGrade AND s.Point<=g.MaxGrade

--UNION
--UNION,UNION ALL,EXCEPT,INTERSECT

SELECT * FROM Students

CREATE TABLE OldStudents
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20),
Age int,
Surname nvarchar(20),
Point  decimal(18,2)
)
SELECT s.Name,s.Age FROM Students s
UNION
SELECT so.Name,so.Age FROM OldStudents so

SELECT s.Name FROM Students s
UNION ALL
SELECT so.Name FROM OldStudents so

SELECT s.Name FROM Students s
EXCEPT
SELECT so.Name FROM OldStudents so

SELECT s.Name FROM Students s
INTERSECT
SELECT so.Name FROM OldStudents so

--IMDB
--actors,movies,genres,directors
CREATE DATABASE PB502IMDB
USE PB502IMDB

CREATE TABLE Directors
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20)
)
CREATE TABLE Movies
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20),
Imdb decimal(18,2),
Duration int,
DirectorId int FOREIGN KEY REFERENCES Directors(Id)
)
--kino siyahisi director adi ile
SELECT m.*,d.Name DirectorName FROM Movies m
JOIN Directors d
ON
m.DirectorId=d.Id

CREATE TABLE Genres
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20)
)

CREATE TABLE MovieGenres
(
Id int PRIMARY KEY IDENTITY,
MovieId int FOREIGN KEY REFERENCES Movies(Id),
GenreId int FOREIGN KEY REFERENCES Genres(Id),
)
--all movie with genre name
SELECT m.*,g.Name GenreName FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN
Genres g
ON
g.Id=mg.GenreId

CREATE TABLE Actors
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(20)
)

CREATE TABLE ActorMovies
(
Id int PRIMARY KEY IDENTITY,
MovieId int FOREIGN KEY REFERENCES Movies(Id),
ActorId int FOREIGN KEY REFERENCES Actors(Id)
)

--all actors with movie and directors and genres
SELECT a.*,m.Name MovieName,d.Name DirectorName,g.Name GenreName FROM  Actors a
JOIN ActorMovies ac
ON
a.Id =ac.ActorId
JOIN Movies m
ON
m.Id=ac.MovieId
JOIN Directors d
ON
d.Id=m.DirectorId
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId

--imdb point 6dan boyuk olan
CREATE VIEW GetMovie
AS
SELECT m.Name,m.Imdb,g.Name GenreName,d.Name DirectorName FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
JOIN Directors d
ON
m.DirectorId=d.Id

WHERE m.Imdb>6

SELECT * FROM GetMovie WHERE Name='Movie3'
DROP VIEW GetMovie

CREATE PROCEDURE st_GetMovieWithIMdb @imdb int,@MovieName nvarchar(10)
AS
SELECT m.Name,m.Imdb,g.Name GenreName,d.Name DirectorName FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
JOIN Directors d
ON
m.DirectorId=d.Id
WHERE m.Imdb>@imdb AND m.[Name]=@MovieName

DROP PROCEDURE dbo.st_GetMovieWithIMdb
EXEC dbo.st_GetMovieWithIMdb 7,'Movie2'

CREATE PROCEDURE st_GetMovieGenreName @GenreName nvarchar(10)
AS
SELECT * FROM GetMovie g
WHERE g.GenreName=@GenreName
EXEC st_GetMovieGenreName 'Genre10'

CREATE FUNCTION GetDataCountMovies()
RETURNS int
AS BEGIN
DECLARE @Count int

SELECT @Count= COUNT(*) FROM Movies
RETURN @Count
END
SELECT dbo.GetDataCountMovies() as CountMovie

CREATE TRIGGER ShowAllDataMovie 
ON Movies
    FOR INSERT, UPDATE, DELETE
AS
SELECT * FROM Movies

DELETE FROM Movies Where Id=9











