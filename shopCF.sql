CREATE DATABASE ManagementCoffeeShop
GO

USE ManagementCoffeeShop
GO

CREATE TABLE Account
(
	
    UserName NVARCHAR(100) PRIMARY KEY,    
    DisplayName NVARCHAR(100) NOT NULL DEFAULT N'No name',
    PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
    TypeUser INT NOT NULL  DEFAULT 0 -- 1: ADMIN && 0: STAFF
)
GO

create table Employee (
    id int primary key identity(1,1),
	DoB date,
    NameEmployee nvarchar(50),
	Sex INT NOT NULL DEFAULT 0, -- 1 men && O momen
    Position nvarchar(20),
    BasicSalary float,
    TypeStaff INT NOT NULL DEFAULT 0 -- 1 admin && O default staff
)
GO

create table EmployeePayroll (
    id int primary key identity(1,1),
	DMYofW date,
	idEm int,
	NumofWorks int,
	Bonus float,
	Salary float,
	FOREIGN KEY (idEm) REFERENCES Employee(id)
)
GO

create table Customer (
    id int primary key identity(1,1),
	DoB date,
    NameCustomer nvarchar(50),
	Sex INT NOT NULL DEFAULT 0, -- 1 men && O momen
    Classtify INT NOT NULL DEFAULT 0 -- 1 Vip && O Basic
)
GO

CREATE TABLE Category
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nameCategory NVARCHAR(69) NOT NULL DEFAULT N'Category no name'
)
GO

CREATE TABLE Product
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nameProduct NVARCHAR(69) NOT NULL DEFAULT N'Product no name',
    idCategory INT NOT NULL,
    priceProduct FLOAT NOT NULL DEFAULT 0,
    
    FOREIGN KEY (idCategory) REFERENCES Category(id)
)
GO

CREATE TABLE TableCF
(
    id INT IDENTITY PRIMARY KEY,
    status NVARCHAR(100) NOT NULL DEFAULT N'Trống'    -- Trống || Có người
)
GO

CREATE TABLE Bill
(
    id INT  PRIMARY KEY IDENTITY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE,
	idEm INT NOT NULL,
	idCus INT NOT NULL,
    idTable INT NOT NULL,
	Discount float,
	PriceBill float, 
	Amount float,
    statusBill INT NOT NULL DEFAULT 0 -- 1: NO && 0: YES
    FOREIGN KEY (idTable) REFERENCES TableCF(id),
	FOREIGN KEY (idEm) REFERENCES Employee(id),
    FOREIGN KEY (idCus) REFERENCES Customer(id)
)
GO

CREATE TABLE BillInfo
(
    idBill INT NOT NULL,
    idProduct INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
	Quantity int not null,
	TotalMoney float,
	PricePDS FLOAT,
	FOREIGN KEY (idBill) REFERENCES Bill(id),
)
GO
		

CREATE TABLE Revenue
(
    DMY date,
	idBill INT NOT NULL,
	allMoney float,
    
    FOREIGN KEY (idBill) REFERENCES Bill(id),
)
GO


