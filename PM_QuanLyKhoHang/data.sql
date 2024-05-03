CREATE DATABASE QuanLyKhoHang
GO
USE QuanLyKhoHang
GO


CREATE TABLE TypeAct
(
    ID   INT IDENTITY PRIMARY KEY NOT NULL,
    Name NVARCHAR(500),
    Del  BIT,
    Note NTEXT
)
GO
CREATE TABLE TypeAccount
(
    ID   INT IDENTITY PRIMARY KEY NOT NULL,
    Name NVARCHAR(500),
    Del  BIT,
    Note NTEXT
)
GO
CREATE TABLE Account
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    UserName  NVARCHAR(500),
    Password  NVARCHAR(500) NOT NULL DEFAULT 1,
    FullName  NVARCHAR(500),
    Address   NVARCHAR(500),
    TypeId    INT  NOT NULL,
    StartDate DATE NOT NULL DEFAULT GETDATE(),
    Del       BIT,
    Note      NTEXT,
    FOREIGN KEY (TypeId) REFERENCES dbo.TypeAccount (ID)
)
GO
CREATE TABLE Decentralization
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    AccountID INT NOT NULL,
    TypeActID INT NOT NULL,
    Del       BIT,
    FOREIGN KEY (AccountID) REFERENCES dbo.Account (ID),
    FOREIGN KEY (TypeActID) REFERENCES dbo.TypeAct (ID)
)
GO
CREATE TABLE Unit
(
    ID   INT IDENTITY PRIMARY KEY NOT NULL,
    Name NVARCHAR(100),
    Del  BIT,
    Note NTEXT
)
GO
CREATE TABLE Products
(
    ID            INT IDENTITY PRIMARY KEY NOT NULL,
    Name          NVARCHAR( MAX),
    Dimensions	  NVARCHAR(MAX),
    UnitID        INT NOT NULL,
    Stock         INT,
    StartDate     DATE NOT NULL DEFAULT GETDATE(),
    InputSource   NVARCHAR( MAX),
    Del           BIT,
    Note          NTEXT,
    FOREIGN KEY (UnitID) REFERENCES dbo.Unit (ID)
)
GO
CREATE TABLE Parameter
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    ProductID INT NOT NULL,
    Value     INT,
    Del       BIT,
    Note      NTEXT,
    FOREIGN KEY (ProductID) REFERENCES dbo.Products (ID)
)
GO
CREATE TABLE Input
(
    ID          INT IDENTITY PRIMARY KEY NOT NULL,
    ProductID   INT NOT NULL,
    Count       INT,
    ImportPrice NUMERIC(18, 0),
    StartDate   DATE NOT NULL DEFAULT GETDATE(),
    AccountID   INT NOT NULL,
    Del         BIT,
    Note        NTEXT,
    FOREIGN KEY (ProductID) REFERENCES dbo.Products (ID),
    FOREIGN KEY (AccountID) REFERENCES dbo.Account (ID),
)
GO
CREATE TABLE SalePrice
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    InputID   INT NOT NULL,
    SalePrice NUMERIC(18, 0),
    AccountID INT NOT NULL,
    StartDate DATE,
    Del       BIT,
    Note      NTEXT,
    FOREIGN KEY (AccountID) REFERENCES dbo.Account (ID),
    FOREIGN KEY (InputID) REFERENCES dbo.Input (ID)
)
GO
CREATE TABLE Company
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    Name      NVARCHAR( MAX),
    Address   NVARCHAR( MAX),
    Phone     VARCHAR(15),
    Fax       VARCHAR(50),
    StartDate DATE NOT NULL DEFAULT GETDATE(),
    Del       BIT,
    Note      NTEXT
)
GO
CREATE TABLE TypeReferrer
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    Name      NVARCHAR(500),
    StartDate DATE NOT NULL DEFAULT GETDATE(),
    Del       BIT,
    Note      NTEXT
)
GO
CREATE TABLE ReceiveCommission
(
    ID             INT IDENTITY PRIMARY KEY NOT NULL,
    Name           NVARCHAR(200),
    Address        NVARCHAR( MAX),
    Phone          VARCHAR(15),
    Fax            VARCHAR(50),
    TypeReferrerID INT NOT NULL,
    Del            BIT,
    Note           NTEXT,
    FOREIGN KEY (TypeReferrerID) REFERENCES dbo.TypeReferrer (ID)
)
GO
CREATE TABLE Bill
(
    ID                   INT IDENTITY PRIMARY KEY NOT NULL,
    Name                 NVARCHAR( MAX),
    CompanyID            INT NOT NULL,
    AccountID            INT NOT NULL,
    StartDate            DATE NOT NULL DEFAULT GETDATE(),
    TotalBill            NUMERIC(18, 0),
    TotalPayment         NUMERIC(18, 0),
    PaymentDueDate       DATE,
    Dividend             NUMERIC(18, 0),
    Commission          NUMERIC(18, 0),
    ReceiveCommissionID INT,
    Del                  BIT,
    Note                 NTEXT,
    FOREIGN KEY (CompanyID) REFERENCES dbo.Company (ID),
    FOREIGN KEY (AccountID) REFERENCES dbo.Account (ID),
    FOREIGN KEY (ReceiveCommissionID) REFERENCES dbo.ReceiveCommission (ID)
)
GO
CREATE TABLE Representative
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    Name      NVARCHAR(500),
    Phone     VARCHAR(15),
    CompanyID INT NOT NULL,
    StartDate DATE NOT NULL DEFAULT GETDATE(),
    Del       BIT,
    Note      NTEXT,
    FOREIGN KEY (CompanyID) REFERENCES dbo.Company (ID)
)
GO
CREATE TABLE BillInfo
(
    ID        INT IDENTITY PRIMARY KEY NOT NULL,
    BillID    INT NOT NULL,
    ProductID INt NOT NULL,
    Count     INT,
    SalePrice NUMERIC(18, 0),
    VAT       INT,
    Dividend  NUMERIC(18, 0),
    Del       BIT,
    Note      NTEXT,
    FOREIGN KEY (BillID) REFERENCES dbo.Bill (ID),
    FOREIGN KEY (ProductID) REFERENCES dbo.Products (ID)
)
GO
CREATE TABLE PaymentInfo
(
    ID            INT IDENTITY PRIMARY KEY NOT NULL,
    BillID        INT NOT NULL,
    Payment		  NUMERIC(18, 0),
    StartDate     DATE NOT NULL DEFAULT GETDATE(),
    StartNextDate DATE,
    Del           BIT,
    Note          NTEXT,
    FOREIGN KEY (BillID) REFERENCES dbo.Bill (ID)
)
GO
CREATE TABLE Expenditure
(
    ID					INT IDENTITY PRIMARY KEY NOT NULL,
	Name				NVARCHAR(500),
    StartDate			DATE NOT NULL DEFAULT GETDATE(),
	Expenditure			NUMERIC(18, 0),
    AccountID			INT NOT NULL,
    Del					BIT,
    Note				NTEXT,
    FOREIGN KEY (AccountID) REFERENCES dbo.Account (ID)
)
GO
CREATE TABLE ExpenditureInfo
(
    ID            INT IDENTITY PRIMARY KEY NOT NULL,
	ExpenditureID INT NOT NULL,
	Price         NUMERIC(18, 0),
    StartDate     DATE NOT NULL DEFAULT GETDATE(),
    Del           BIT,
    Note          NTEXT,
    FOREIGN KEY (ExpenditureID) REFERENCES dbo.Expenditure (ID)
)
GO
CREATE TABLE SystemError
(
    ID      INT IDENTITY PRIMARY KEY NOT NULL,
    NameErr Ntext,
    NameFn  NVARCHAR(200),
    Del     BIT,
    Note    NTEXT
)
GO
CREATE TABLE FKey
(
    ID           INT IDENTITY PRIMARY KEY NOT NULL,
    TimeDateLine TEXT,
    Del          BIT,
)
GO
SET IDENTITY_INSERT dbo.TypeAccount ON
INSERT dbo.TypeAccount (ID, name, Del, Note) VALUES (1, N'Giám Đốc', 0, N'Giám đốc')
INSERT dbo.TypeAccount (ID, name, Del, Note) VALUES (2, N'Nhân Viên Nhập Kho', 0, N'Nhân Viên Nhập Kho')
SET IDENTITY_INSERT dbo.TypeAccount OFF
SET IDENTITY_INSERT dbo.TypeReferrer ON
INSERT dbo.TypeReferrer (ID, name, Del, Note) VALUES (1, N'Người Giới Thiệu Tự Do',0, N'')
SET IDENTITY_INSERT dbo.TypeReferrer OFF	
SET IDENTITY_INSERT dbo.Unit ON
INSERT dbo.Unit (ID, name, Del, Note) VALUES (1, N'Tấm', 0, N'Tấm tôn')
INSERT dbo.Unit (ID, name, Del, Note) VALUES (2, N'Miếng', 0, N'miếng gỗ')
SET IDENTITY_INSERT dbo.Unit OFF
SET IDENTITY_INSERT dbo.Company ON
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (1, N'Công ty TNHH PaoYeng', N'123-Đường số 10- khu công nghiệp tân tạo', N'08376621544', N'082112123344', 0, N'thường nhập hàng mủ')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (2, N'Công ty TNHH Bình Minh', N'12-Lò gốm - Quận 6 -tphcm', N'08212134552', N'01212121212', 0, N'chuyên kinh doanh nhựa')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (3, N'Công ty TNHH Tân Tân', N'145/13- tỉnh lộ 10 - bình chánh - tphcm', N'08123435533', N'08121342342', 0, N'công ty đậu ')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (4, N'Công ty TNHH NahaShi', N'121-Điện biên phủ - quận 3-tphcm', N'0812343434535', N'132232321312', 0, N'mua hàng số lượng rất lớn')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (5, N'Công ty TNHH Phú Lạc Việt', N'12-Trần Bình Trọng', N'081213244', N'121321313213123', 0, N'ông khang làm giám đốc')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (6, N'Công ty TNHH Phân Bón Bình Điền', N'123-QL1- Bình chánh-tphcm', N'0812123123', N'08131233123', 0, N'đây là công ty phân bón')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (7, N'Công ty TNHH Mai Linh', N'1212314', N'1434243', N'1431412312', 0, N'')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (8, N'Công ty TNHH SinYahoo', N'123-Lý Thái Tổ-Q10-TPHCM', N'09212101212', N'0831341234', 0, N'')
INSERT dbo.Company (ID, Name, Address, Phone, Fax, Del, Note) VALUES (9, N'Công ty bánh kẹo Phạm Nguyên', N'12 -Trần đại nghĩa- khu công nghiệp Lê Minh Xuân', N'081212123', N'2133213213', 0, N'công ty bánh kẹo')
SET IDENTITY_INSERT dbo.Company OFF
SET IDENTITY_INSERT dbo.Account ON
INSERT dbo.Account (ID, UserName, Password, FullName, Address, TypeId, Del, Note) VALUES (1, N'admin', N'123', N'Dương Minh Triều', N'TPHCM', 1, 0, N'giám đốc ')
INSERT dbo.Account (ID, UserName, Password, FullName, Address, TypeId, Del, Note) VALUES (2, N'mt276', N'123', N'Triều Minh', N'TPHCM', 2, 0, N'nhân viên nhập kho')
INSERT dbo.Account (ID, UserName, Password, FullName, Address, TypeId, Del, Note) VALUES (3, N'eni', N'123', N'Kim Anh', N'TPHCM', 2, 0, N'nhân viên nhập kho')
SET IDENTITY_INSERT dbo.Account OFF
SET IDENTITY_INSERT dbo.Representative ON
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (1, N'ông Trần Tiến', N'12313132313', 1, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (2, N'bà Trầm Bê', N'0921323244', 2, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (3, N'ông Khang Phú', N'0998121212112', 3, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (4, N'bà Lý Thị Mạc', N'081212123', 4, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (5, N'bà Nguyễn Tố Châu', N'123133212312321', 5, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (6, N'ông Công Hậu', N'0947271638199', 6, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (7, N'ông Cao Thắng', N'092121234', 7, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (8, N'bà Nguyễn Mai', N'0947271638199', 8, 0, N'')
INSERT dbo.Representative (ID, Name, Phone, CompanyID, Del, Note) VALUES (9, N'ông Phạm Thắng', N'092121234', 9, 0, N'')
SET IDENTITY_INSERT dbo.Representative OFF
SET IDENTITY_INSERT dbo.Products ON
INSERT dbo.Products (ID, Name, Dimensions, UnitID, Stock, InputSource, Del, Note) VALUES (1, N'Bìa cứng', N'130x12', 2, 12, N'canada', 0, N'hàng trong nước')
INSERT dbo.Products (ID, Name, Dimensions, UnitID, Stock, InputSource, Del, Note) VALUES (2, N'Bế cuộn', N'13x 213', 1, 32, N'malaysia', 0, N'hàng nhập từ nước ngoài')
INSERT dbo.Products (ID, Name, Dimensions, UnitID, Stock, InputSource, Del, Note) VALUES (3, N'Chỉ bế', N'0.6 x 3.2', 2, 0, N'indonesia', 0, N'hàng nhập từ nước ngoài')
INSERT dbo.Products (ID, Name, Dimensions, UnitID, Stock, InputSource, Del, Note) VALUES (4, N'Keo dính chuột', N'12x12.00', 1, 100, N'malaisia', 0, N'hàng trong nước')
SET IDENTITY_INSERT dbo.Products OFF
SET IDENTITY_INSERT dbo.Parameter ON
INSERT dbo.Parameter (ID, ProductID, Value,Del,Note) VALUES (1, 1, 5, 0, N'Giá trị nhỏ nhất')
INSERT dbo.Parameter (ID, ProductID, Value,Del,Note) VALUES (2, 2, 3, 0, N'Giá trị nhỏ nhất')
INSERT dbo.Parameter (ID, ProductID, Value,Del,Note) VALUES (3, 3, 3, 0, N'Giá trị nhỏ nhất')
SET IDENTITY_INSERT dbo.Parameter OFF
SET IDENTITY_INSERT dbo.Input ON
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (1, 2, 123, CAST(1500000 AS Numeric(18, 0)), 1, 0, N'bế cuộng sấm')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (2, 2, 10, CAST(15000000 AS Numeric(18, 0)), 1, 0, N'bế cuộn nhập mới')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (3, 1, 1200000, CAST(13000 AS Numeric(18, 0)), 1, 0, N'parasetamon')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (5, 1, 12, CAST(50000 AS Numeric(18, 0)), 1, 0, N'bìa cứng')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (6, 2, 20, CAST(200000 AS Numeric(18, 0)), 1, 0, N'bế cuộng mỏng')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (7, 2, 12, CAST(100000 AS Numeric(18, 0)), 1, 0, N'cập nhật giá bán')
INSERT dbo.Input (ID, ProductID, Count, ImportPrice, AccountID, Del, Note) VALUES (8, 4, 100, CAST(12000 AS Numeric(18, 0)), 1, 0, N'')
SET IDENTITY_INSERT dbo.Input OFF
SET IDENTITY_INSERT dbo.ReceiveCommission ON
INSERT dbo.ReceiveCommission (ID, Name, Address, Phone, Fax, TypeReferrerID, Del, Note) VALUES (1, N'Nguyễn Văn An', N'123-Điện Biên Phủ', N'0947294761', N'083712343', 1, 0, N'')
SET IDENTITY_INSERT dbo.ReceiveCommission OFF
SET IDENTITY_INSERT dbo.Bill ON
INSERT dbo.Bill (ID, Name, CompanyID, AccountID, TotalBill, TotalPayment, PaymentDueDate, Dividend, Commission, ReceiveCommissionID, Del, Note) VALUES (1, N'Hóa đơn', 2, 1, CAST(748000 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), Null, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, 0, N'')
INSERT dbo.Bill (ID, Name, CompanyID, AccountID, TotalBill, TotalPayment, PaymentDueDate, Dividend, Commission, ReceiveCommissionID, Del, Note) VALUES (2, N'Hóa đơn', 3, 1, CAST(748000 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), Null, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, 0, N'')
INSERT dbo.Bill (ID, Name, CompanyID, AccountID, TotalBill, TotalPayment, PaymentDueDate, Dividend, Commission, ReceiveCommissionID, Del, Note) VALUES (3, N'Hóa đơn', 4, 1, CAST(748000 AS Numeric(18, 0)), CAST(3123 AS Numeric(18, 0)), Null, CAST(360000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), NULL, 0, N'')
SET IDENTITY_INSERT dbo.Bill OFF
SET IDENTITY_INSERT dbo.SalePrice ON
INSERT dbo.SalePrice (ID, InputID, SalePrice, AccountID,StartDate, Del, Note) VALUES (1, 1, CAST(12000 AS Numeric(18, 0)), 1,GETDATE(), 0, N'')
INSERT dbo.SalePrice (ID, InputID, SalePrice, AccountID,StartDate, Del, Note) VALUES (2, 2, CAST(340000 AS Numeric(18, 0)), 1,GETDATE(), 0, N'')
INSERT dbo.SalePrice (ID, InputID, SalePrice, AccountID,StartDate, Del, Note) VALUES (3, 3, CAST(35000 AS Numeric(18, 0)), 1,GETDATE(), 0, N'')
SET IDENTITY_INSERT dbo.SalePrice OFF
SET IDENTITY_INSERT dbo.BillInfo ON
INSERT dbo.BillInfo (ID, BillID, ProductID, Count, SalePrice, VAT, Dividend, Del, Note) VALUES (1, 1, 2, 2, CAST(340000 AS Numeric(18, 0)), 2, CAST(180000 AS Numeric(18, 0)), 0, N'')
INSERT dbo.BillInfo (ID, BillID, ProductID, Count, SalePrice, VAT, Dividend, Del, Note) VALUES (2, 2, 2, 2, CAST(340000 AS Numeric(18, 0)), 2, CAST(180000 AS Numeric(18, 0)), 0, N'')
INSERT dbo.BillInfo (ID, BillID, ProductID, Count, SalePrice, VAT, Dividend, Del, Note) VALUES (3, 3, 2, 2, CAST(340000 AS Numeric(18, 0)), 0, CAST(180000 AS Numeric(18, 0)), 0, N'')
SET IDENTITY_INSERT dbo.BillInfo OFF

CREATE PROC USP_DeleteRecordsBasedOnDelValue
AS
BEGIN
	DELETE FROM dbo.Account WHERE DEL = 1
	DELETE FROM dbo.Bill WHERE DEL = 1
	DELETE FROM dbo.BillInfo WHERE DEL = 1
	DELETE FROM dbo.Company WHERE DEL = 1
	DELETE FROM dbo.Decentralization WHERE DEL = 1
	DELETE FROM dbo.Input WHERE DEL = 1
	DELETE FROM dbo.Parameter WHERE DEL = 1
	DELETE FROM dbo.PaymentInfo WHERE DEL = 1
	DELETE FROM dbo.Products WHERE DEL = 1
	DELETE FROM dbo.ReceiveCommission WHERE DEL = 1
	DELETE FROM dbo.Representative WHERE DEL = 1
	DELETE FROM dbo.SalePrice WHERE DEL = 1
	DELETE FROM dbo.TypeAccount WHERE DEL = 1
	DELETE FROM dbo.TypeAct WHERE DEL = 1
	DELETE FROM dbo.TypeReferrer WHERE DEL = 1
	DELETE FROM dbo.Unit WHERE DEL = 1
	DELETE FROM dbo.SystemError WHERE DEL = 1
	DELETE FROM dbo.FKey WHERE DEL = 1
END
GO
--exec USP_DeleteRecordsBasedOnDelValue
--select * from unit

--select * from TypeAct
--select * from TypeAccount
--select * from Account
--select * from Decentralization
--select * from Unit
--select * from Company
--select * from Products 
--select * from Input
--select * from Representative
--select * from TypeReferrer
--select * from ReceiveCommissions
--select * from Bill
--select * from BillInfo
--select * from PaymentInfo
--select * from Parameter
--select * from SalePrice
