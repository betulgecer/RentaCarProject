CREATE TABLE Customers(
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
CompanyName VARCHAR(50))


INSERT INTO dbo.Customers
(CompanyName)
VALUES
('Hilmi'), ('Bilal'), ('NAS Gıda'), ('Furkan')

CREATE TABLE RentACars(
Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
CarId INT FOREIGN KEY ([CarId]) REFERENCES dbo.Cars ([CarId]),
CustomerId INT FOREIGN KEY ([CustomerId]) REFERENCES dbo.Customers ([CustomerId]),
CreatedDate Datetime,
EndDate Datetime
)

Insert Into RentACars
(
CarId,
CustomerId,
CreatedDate,
EndDate) values (1,2,'03/21/2020','03/22/2020'),(4,3,'05/21/2020','03/22/2020'),(2,1,'01/21/2020','07/22/2020')
