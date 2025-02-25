CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(100) NOT NULL,
DailyRate DECIMAL NOT NULL,
WeeklyRate DECIMAL NOT NULL,
MonthlyRate DECIMAL NOT NULL,
WeekendRate Decimal NOT NULL);

INSERT INTO Categories
VALUES
('Fast', 2.4, 2.5, 4, 5),
('Fast', 2.4, 2.5, 4, 5),
('Fast', 2.4, 2.5, 4, 5);

CREATE TABLE Cars(
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(10) NOT NULL,
Manifacturer VARCHAR(50) NOT NULL,
Model VARCHAR(50) NOT NULL,
CarYear DATE NOT NULL,
CategoryId INT NOT NULL
FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
Doors INT,
Picture VARBINARY(MAX),
Condition FLOAT NOT NULL,
Available BIT NOT NULL);

INSERT INTO Cars
VALUES
('DF231VD','FASTCARS' , 'SONIC`S RIDE', GETDATE(),1, 4, NULL, 6.5, 1),
('DF231VD','FASTCARS' , 'SONIC`S RIDE', GETDATE(),1, 4, NULL, 6.5, 1),
('DF231VD','FASTCARS' , 'SONIC`S RIDE', GETDATE(),1, 4, NULL, 6.5, 1);


CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Title NVARCHAR(30) NOT NULL,
Notes NVARCHAR(MAX));

INSERT INTO Employees
VALUES
('AR43','BG12' , 'ESSENTIAL WORKER', NULL),
('AR43','BG12' , 'ESSENTIAL WORKER', NULL),
('AR43','BG12' , 'ESSENTIAL WORKER', NULL);

CREATE TABLE Customer(
Id INT PRIMARY KEY IDENTITY,
DriverLicenseNumber NVARCHAR(30) UNIQUE NOT NULL,
FullName NVARCHAR(50) NOT NULL,
Adress NVARCHAR(100),
City NVARCHAR(30),
ZipCode INT UNIQUE,
Notes NVARCHAR(MAX));

INSERT INTO Customer
VALUES
('AR433FD','Bon Voyage' , NULL, NULL, '123', NULL),
('AR433hFD','Bon Voyage' , NULL, NULL, '1234', NULL),
('AR4h33FD','Bon Voyage' , NULL, NULL, '1235', NULL);

CREATE TABLE RentalOrder(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL
FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
CarId INT NOT NULL
FOREIGN KEY (CarId) REFERENCES Cars(Id),
TankLevel FLOAT,
KilometrageStart INT NOT NULL,
KilometrageEnd INT NOT NULL,
TotalKilometrage INT NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
TotalDays INT NOT NULL,
RateApplied DECIMAL NOT NULL,
TaxRate DECIMAL NOT NULL,
OrderStatus BIT NOT NULL,
Notes NVARCHAR(MAX));

INSERT INTO RentalOrder
VALUES
(1, 1 , NULL, 1, 2, 3, GETDATE(), GETDATE(), 4, 12, 32, 1, NULL),
(1, 1 , NULL, 1, 2, 3, GETDATE(), GETDATE(), 4, 12, 32, 1, NULL),
(1, 1 , NULL, 1, 2, 3, GETDATE(), GETDATE(), 4, 12, 32, 1, NULL);
