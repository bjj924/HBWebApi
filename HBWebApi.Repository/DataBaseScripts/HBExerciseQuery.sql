/*Create Database ShopTest*/
CREATE DATABASE ShopTest
GO

/*Use the new DB*/
USE [ShopTest]
GO

/*Create the tables*/
/*[PersonID] [int] IDENTITY(1,1) PRIMARY KEY, Se le pone el identity para que sea incremental cada vez que se lo inserta*/
CREATE TABLE Customer
(
	[PersonID] [int] IDENTITY(1,1) PRIMARY KEY,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Age] [int] NULL,
	[Occupation] [varchar](255) NULL,
	[MartialStatus] [varchar](255) NULL
)
GO

CREATE TABLE Orders
(
	[OrderID] [int] IDENTITY(1,1) PRIMARY KEY,
	[PersonID] [int] NOT NULL FOREIGN KEY REFERENCES Customer(PersonID),
	[DateCreated] [DateTime] NULL,
	[MethodofPurchase] [varchar](255) NOT NULL
)
GO

CREATE TABLE OrdersDetails (
    OrderDetailID [int] IDENTITY(1,1) PRIMARY KEY,
    OrderID [int] NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
	ProductNumber [int] NOT NULL,
	ProductID [int] NOT NULL,
	ProductOrigin [varchar](255) NOT NULL
);
GO

/*Add Data to fill the tables */
USE [ShopTest]
GO

INSERT INTO [dbo].[Customer] ([FirstName],[LastName],[Age],[Occupation],[MartialStatus])
     VALUES
           ('Braian', 'Joho', '28', 'Developer', 'Single'),
		   ('Esteban', 'Romero', '30', 'Artist', 'Divorced'),
		   ('Sergio', 'Schmikel', '23', 'Student', 'Single'),
		   ('Alejandro', 'Constanzo', '26', 'Architect', 'Married'),
		   ('Sebastian', 'Jansen', '21', 'Student', 'Single'),
		   ('Aldana', 'Curi', '30', 'Veterinarian', 'Divorced'),
		   ('Pierre', 'Sciu', '27', 'Developer', 'Single'),
		   ('Maria', 'Cruz', '45', 'FireFighter', 'Married'),
		   ('Alan', 'Marcusi', '28', 'Police Officer', 'Single'),
		   ('Horacio', 'Chamorro', '45', 'Teacher', 'Married')
GO

INSERT INTO [dbo].[Orders] ([PersonID],[DateCreated],[MethodofPurchase])
VALUES
           (1 ,GETDATE(),'Debit' ),
		   (3 ,GETDATE(),'Credit'),
		   (5 ,GETDATE(),'Money' ),
		   (10,GETDATE(),'Debit' ),
		   (2 ,GETDATE(),'Money' ),
		   (10,GETDATE(),'Debit' ),
		   (7 ,GETDATE(),'Money' ),
		   (4 ,GETDATE(),'Credit'),
		   (4 ,GETDATE(),'Credit'),
		   (4 ,GETDATE(),'Credit'),
		   (3 ,GETDATE(),'Credit'),
		   (6 ,GETDATE(),'Debit' ),
		   (6 ,GETDATE(),'Debit' ),
		   (5 ,GETDATE(),'Money' ),
		   (4 ,GETDATE(),'Credit'),
		   (8 ,GETDATE(),'Money' ),
		   (6 ,GETDATE(),'Debit' ),
		   (9 ,GETDATE(),'Debit' ),
		   (4 ,GETDATE(),'Credit'),
		   (5 ,GETDATE(),'Money' )

GO

INSERT INTO [dbo].[OrdersDetails] ([OrderID],[ProductNumber],[ProductID],[ProductOrigin])
     VALUES
           (1 , 445  , 1112222333,'Arg'),
		   (2 , 400  , 1112222444,'Arg'),
		   (3 , 450  , 1112222322,'Arg'),
		   (4 , 308  , 1112211221,'Arg'),
		   (5 , 48   , 1111111444,'Arg'),
		   (6 , 79   , 1111112444,'Arg'),
		   (7 , 125  , 1111122999,'Arg'),
		   (8 , 358  , 1144878333,'Arg'),
		   (9 , 478  , 1111199888,'Arg'),
		   (10 , 482 , 1133346546,'Arg'),
		   (11 , 501 , 1933333333,'Arg'),
		   (12 , 259 , 1151111333,'Arg'),
		   (13 , 78  , 1111111193,'Arg'),
		   (14 , 445 , 1112222333,'Arg'),
		   (15 , 465 , 1489677777,'Arg'),
		   (16 , 354 , 1122553344,'Arg'),
		   (17 , 199 , 1222244558,'Arg'),
		   (18 , 230 , 1222222333,'Arg'),
		   (19 , 15  , 1111111113,'Arg'),
		   (20 , 524 , 1333333333,'Arg')
GO

/*Query to solve the problem, uncomment*/
/*

SELECT 
CONCAT(c.FirstName,' ',c.LastName) as [Full Name],
c.Age as [Age],
o.OrderID as [Order ID],
o.DateCreated as [Creation Date],
o.MethodofPurchase as [Purchase Method],
od.ProductNumber as [Product Number],
od.ProductOrigin as [Product Origin]
FROM Customer c
INNER JOIN Orders o on o.PersonID = c.PersonID
INNER JOIN OrdersDetails od on od.OrderID = o.OrderID
WHERE od.ProductID = 1112222333
GO

*/