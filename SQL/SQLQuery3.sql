CREATE DATABASE RestaurantDb
USE RestaurantDb
CREATE TABLE [Tables]
(
Id INT PRIMARY KEY IDENTITY,
[No] NVARCHAR(10)
)

CREATE TABLE Meals
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
Price DECIMAL(18,2)
)

CREATE TABLE Orders
(
Id INT PRIMARY KEY IDENTITY,
[Date] DATETIME2,
MealId INT FOREIGN KEY REFERENCES Meals(Id),
TableId INT FOREIGN KEY REFERENCES [Tables](Id)
)
SELECT TOP(1) * FROM [Tables] t
ORDER BY Id DESC

--1
SELECT t.*,(SELECT COUNT(*)  FROM Orders o WHERE o.TableId=t.Id) AS OrdersCount
FROM [Tables] t

--2
SELECT m.*,(SELECT COUNT(*)  FROM Orders o WHERE o.MealId=m.Id) AS OrdersCount
FROM [Meals] m

--3
SELECT o.*,m.Name AS MealName FROM Orders o
JOIN Meals m
ON o.MealId=m.Id

--4
SELECT o.*,m.Name AS MealName,t.[No]  FROM Orders o
JOIN Meals m
ON o.MealId=m.Id
JOIN [Tables] t
ON o.TableId=t.Id

--5
SELECT t.*,(SELECT SUM(m.Price) FROM Orders o
JOIN Meals m
ON o.MealId=m.Id
WHERE o.TableId=t.Id) AS TotalPrice
FROM [Tables] t

--6
SELECT DATEDIFF(hour, MIN(Date), MAX(DATE)) FROM Orders o
WHERE o.TableId=1

--7
SELECT * FROM Orders o
WHERE Date< DATEADD(minute,-30,GetDate())

--8
SELECT * FROM [Tables] t
WHERE 
NOT EXISTS
(SELECT TableId FROM Orders o WHERE t.Id=o.TableId )


--9
SELECT * FROM [Tables] t
WHERE 
NOT EXISTS
(SELECT TableId FROM Orders o WHERE t.Id=o.TableId AND DATE> DATEADD(minute,-60,Getdate()))


--INDEX,VIEW,PROCEDURE,Function,TRIGGER

CREATE VIEW GetTableWithOrdersCount
AS
SELECT t.*,(SELECT COUNT(*)  FROM Orders o WHERE o.TableId=t.Id) AS OrdersCount
FROM [Tables] t


SELECT * FROM GetTableWithOrdersCount
