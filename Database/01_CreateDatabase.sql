
USE master;
GO

IF DB_ID(N'pasay') IS NULL
    CREATE DATABASE pasay;
GO

USE pasay;
GO

SET QUOTED_IDENTIFIER ON;
SET ANSI_NULLS ON;
GO

/* =====================================================
   1. DATABASE TABLES
   ===================================================== */

IF OBJECT_ID(N'dbo.Roles', N'U') IS NULL
CREATE TABLE dbo.Roles
(
    RoleId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Roles PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL
        CONSTRAINT UQ_Roles_RoleName UNIQUE,
    Description NVARCHAR(200) NULL
);
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users
(
    UserId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Users PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL
        CONSTRAINT UQ_Users_Username UNIQUE,
    PasswordHash VARCHAR(64) NOT NULL,
    Salt VARCHAR(32) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    RoleId INT NOT NULL
        CONSTRAINT FK_Users_Roles REFERENCES dbo.Roles(RoleId),
    IsActive BIT NOT NULL
        CONSTRAINT DF_Users_IsActive DEFAULT (1),
    CreatedAt DATETIME NOT NULL
        CONSTRAINT DF_Users_CreatedAt DEFAULT (GETDATE()),
    LastLoginAt DATETIME NULL
);
GO

IF OBJECT_ID(N'dbo.Categories', N'U') IS NULL
CREATE TABLE dbo.Categories
(
    CategoryId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Categories PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
        CONSTRAINT UQ_Categories_Name UNIQUE,
    Description NVARCHAR(200) NULL
);
GO

IF OBJECT_ID(N'dbo.ProductSkuCounters', N'U') IS NULL
CREATE TABLE dbo.ProductSkuCounters
(
    CategoryId INT NOT NULL
        CONSTRAINT PK_ProductSkuCounters PRIMARY KEY
        CONSTRAINT FK_ProductSkuCounters_Categories
        REFERENCES dbo.Categories(CategoryId),
    Prefix NVARCHAR(3) NOT NULL,
    LastNumber BIGINT NOT NULL
        CONSTRAINT DF_ProductSkuCounters_LastNumber DEFAULT (0)
);
GO

IF OBJECT_ID(N'dbo.ProductBarcodeCounter', N'U') IS NULL
CREATE TABLE dbo.ProductBarcodeCounter
(
    CounterId INT NOT NULL
        CONSTRAINT PK_ProductBarcodeCounter PRIMARY KEY,
    LastNumber BIGINT NOT NULL
);
GO

IF OBJECT_ID(N'dbo.ProductBarcodeCounters', N'U') IS NULL
CREATE TABLE dbo.ProductBarcodeCounters
(
    CategoryId INT NOT NULL
        CONSTRAINT PK_ProductBarcodeCounters PRIMARY KEY
        CONSTRAINT FK_ProductBarcodeCounters_Categories
        REFERENCES dbo.Categories(CategoryId),
    BarcodePrefix CHAR(4) NOT NULL,
    LastNumber BIGINT NOT NULL
        CONSTRAINT DF_ProductBarcodeCounters_LastNumber DEFAULT (0)
);
GO

IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
CREATE TABLE dbo.Products
(
    ProductId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Products PRIMARY KEY,
    Sku NVARCHAR(30) NOT NULL
        CONSTRAINT UQ_Products_Sku UNIQUE,
    Barcode NVARCHAR(50) NULL,
    Name NVARCHAR(150) NOT NULL,
    CategoryId INT NOT NULL
        CONSTRAINT FK_Products_Categories
        REFERENCES dbo.Categories(CategoryId),
    Price DECIMAL(18,2) NOT NULL
        CONSTRAINT CK_Products_Price CHECK (Price >= 0),
    Cost DECIMAL(18,2) NOT NULL
        CONSTRAINT CK_Products_Cost CHECK (Cost >= 0),
    StockQty INT NOT NULL
        CONSTRAINT DF_Products_Stock DEFAULT (0)
        CONSTRAINT CK_Products_Stock CHECK (StockQty >= 0),
    ReorderLevel INT NOT NULL
        CONSTRAINT DF_Products_Reorder DEFAULT (5)
        CONSTRAINT CK_Products_Reorder CHECK (ReorderLevel >= 0),
    Image VARBINARY(MAX) NULL,
    IsActive BIT NOT NULL
        CONSTRAINT DF_Products_IsActive DEFAULT (1),
    CreatedAt DATETIME NOT NULL
        CONSTRAINT DF_Products_CreatedAt DEFAULT (GETDATE()),
    UpdatedAt DATETIME NOT NULL
        CONSTRAINT DF_Products_UpdatedAt DEFAULT (GETDATE())
);
GO

IF OBJECT_ID(N'dbo.Customers', N'U') IS NULL
CREATE TABLE dbo.Customers
(
    CustomerId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Customers PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(30) NULL,
    Email NVARCHAR(120) NULL,
    Address NVARCHAR(250) NULL,
    CreatedAt DATETIME NOT NULL
        CONSTRAINT DF_Customers_CreatedAt DEFAULT (GETDATE())
);
GO

IF OBJECT_ID(N'dbo.Orders', N'U') IS NULL
CREATE TABLE dbo.Orders
(
    OrderId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_Orders PRIMARY KEY,
    OrderNumber NVARCHAR(30) NOT NULL
        CONSTRAINT UQ_Orders_Number UNIQUE,
    CustomerId INT NULL
        CONSTRAINT FK_Orders_Customers
        REFERENCES dbo.Customers(CustomerId),
    UserId INT NOT NULL
        CONSTRAINT FK_Orders_Users REFERENCES dbo.Users(UserId),
    OrderDate DATETIME NOT NULL
        CONSTRAINT DF_Orders_Date DEFAULT (GETDATE()),
    Subtotal DECIMAL(18,2) NOT NULL,
    TaxAmount DECIMAL(18,2) NOT NULL,
    DiscountAmount DECIMAL(18,2) NOT NULL
        CONSTRAINT DF_Orders_Discount DEFAULT (0),
    Total DECIMAL(18,2) NOT NULL,
    PaymentMethod NVARCHAR(20) NOT NULL
        CONSTRAINT CK_Orders_Payment
        CHECK (PaymentMethod IN (N'Cash', N'Card', N'Mobile')),
    AmountPaid DECIMAL(18,2) NOT NULL,
    ChangeDue DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(20) NOT NULL
        CONSTRAINT DF_Orders_Status DEFAULT (N'Completed')
        CONSTRAINT CK_Orders_Status
        CHECK (Status IN (N'Completed', N'Voided'))
);
GO

IF OBJECT_ID(N'dbo.OrderDetails', N'U') IS NULL
CREATE TABLE dbo.OrderDetails
(
    OrderDetailId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_OrderDetails PRIMARY KEY,
    OrderId INT NOT NULL
        CONSTRAINT FK_OrderDetails_Orders
        REFERENCES dbo.Orders(OrderId) ON DELETE CASCADE,
    ProductId INT NOT NULL
        CONSTRAINT FK_OrderDetails_Products
        REFERENCES dbo.Products(ProductId),
    Quantity INT NOT NULL
        CONSTRAINT CK_OrderDetails_Qty CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) NOT NULL,
    LineTotal DECIMAL(18,2) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.InventoryLog', N'U') IS NULL
CREATE TABLE dbo.InventoryLog
(
    LogId INT IDENTITY(1,1) NOT NULL
        CONSTRAINT PK_InventoryLog PRIMARY KEY,
    ProductId INT NOT NULL
        CONSTRAINT FK_InventoryLog_Products
        REFERENCES dbo.Products(ProductId),
    ChangeQty INT NOT NULL,
    Reason NVARCHAR(200) NOT NULL,
    UserId INT NOT NULL
        CONSTRAINT FK_InventoryLog_Users
        REFERENCES dbo.Users(UserId),
    CreatedAt DATETIME NOT NULL
        CONSTRAINT DF_InventoryLog_Created DEFAULT (GETDATE())
);
GO

/* =====================================================
   2. INDEXES
   ===================================================== */

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'UX_Products_Barcode' AND object_id = OBJECT_ID(N'dbo.Products'))
    CREATE UNIQUE INDEX UX_Products_Barcode
    ON dbo.Products(Barcode) WHERE Barcode IS NOT NULL;

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Products_Name' AND object_id = OBJECT_ID(N'dbo.Products'))
    CREATE INDEX IX_Products_Name ON dbo.Products(Name);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Products_CategoryId' AND object_id = OBJECT_ID(N'dbo.Products'))
    CREATE INDEX IX_Products_CategoryId ON dbo.Products(CategoryId);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Users_RoleId' AND object_id = OBJECT_ID(N'dbo.Users'))
    CREATE INDEX IX_Users_RoleId ON dbo.Users(RoleId);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Orders_OrderDate' AND object_id = OBJECT_ID(N'dbo.Orders'))
    CREATE INDEX IX_Orders_OrderDate ON dbo.Orders(OrderDate) INCLUDE (Total, Status);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Orders_UserId' AND object_id = OBJECT_ID(N'dbo.Orders'))
    CREATE INDEX IX_Orders_UserId ON dbo.Orders(UserId);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Orders_CustomerId' AND object_id = OBJECT_ID(N'dbo.Orders'))
    CREATE INDEX IX_Orders_CustomerId ON dbo.Orders(CustomerId);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_OrderDetails_OrderId' AND object_id = OBJECT_ID(N'dbo.OrderDetails'))
    CREATE INDEX IX_OrderDetails_OrderId ON dbo.OrderDetails(OrderId);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_OrderDetails_ProductId' AND object_id = OBJECT_ID(N'dbo.OrderDetails'))
    CREATE INDEX IX_OrderDetails_ProductId ON dbo.OrderDetails(ProductId) INCLUDE (Quantity, LineTotal);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_InventoryLog_Product' AND object_id = OBJECT_ID(N'dbo.InventoryLog'))
    CREATE INDEX IX_InventoryLog_Product ON dbo.InventoryLog(ProductId, CreatedAt DESC);
GO

/* =====================================================
   3. SAMPLE DATA
   ===================================================== */

/* ROLES */
IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RoleName = N'Admin')
    INSERT dbo.Roles (RoleName, Description)
    VALUES (N'Admin', N'Full access including user management');

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RoleName = N'Manager')
    INSERT dbo.Roles (RoleName, Description)
    VALUES (N'Manager', N'POS, products, inventory and analytics');

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE RoleName = N'Cashier')
    INSERT dbo.Roles (RoleName, Description)
    VALUES (N'Cashier', N'Point of sale only');
GO

/* USERS */
DECLARE @s1 VARCHAR(32) = 'A1B2C3D4E5F60718293A4B5C6D7E8F90';
DECLARE @s2 VARCHAR(32) = '0F1E2D3C4B5A69788796A5B4C3D2E1F0';
DECLARE @s3 VARCHAR(32) = '1122334455667788AABBCCDDEEFF0011';

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = N'admin')
BEGIN
    INSERT dbo.Users (Username, PasswordHash, Salt, FullName, RoleId)
    VALUES
    (
        N'admin',
        CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @s1 + 'Admin@123'), 2),
        @s1,
        N'System Administrator',
        (SELECT RoleId FROM dbo.Roles WHERE RoleName = N'Admin')
    );
END;

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = N'manager')
BEGIN
    INSERT dbo.Users (Username, PasswordHash, Salt, FullName, RoleId)
    VALUES
    (
        N'manager',
        CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @s2 + 'Manager@123'), 2),
        @s2,
        N'Store Manager',
        (SELECT RoleId FROM dbo.Roles WHERE RoleName = N'Manager')
    );
END;

IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = N'cashier')
BEGIN
    INSERT dbo.Users (Username, PasswordHash, Salt, FullName, RoleId)
    VALUES
    (
        N'cashier',
        CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @s3 + 'Cashier@123'), 2),
        @s3,
        N'Front Desk Cashier',
        (SELECT RoleId FROM dbo.Roles WHERE RoleName = N'Cashier')
    );
END;
GO

/* CATEGORIES */
IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = N'Beverages')
    INSERT dbo.Categories (Name, Description)
    VALUES (N'Beverages', N'Drinks');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = N'Snacks')
    INSERT dbo.Categories (Name, Description)
    VALUES (N'Snacks', N'Chips, biscuits and sweets');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = N'Groceries')
    INSERT dbo.Categories (Name, Description)
    VALUES (N'Groceries', N'Pantry staples');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = N'Household')
    INSERT dbo.Categories (Name, Description)
    VALUES (N'Household', N'Cleaning and home');

IF NOT EXISTS (SELECT 1 FROM dbo.Categories WHERE Name = N'Personal Care')
    INSERT dbo.Categories (Name, Description)
    VALUES (N'Personal Care', N'Hygiene and beauty');
GO

/* COUNTER INITIALIZATION */
DECLARE @CategoryCounters TABLE
(
    CategoryName NVARCHAR(100),
    SkuPrefix NVARCHAR(3),
    BarcodePrefix CHAR(4)
);

INSERT INTO @CategoryCounters VALUES
(N'Beverages', N'BEV', '8901'),
(N'Snacks', N'SNK', '8902'),
(N'Groceries', N'GRO', '8903'),
(N'Household', N'HOU', '8904'),
(N'Personal Care', N'PER', '8905');

INSERT dbo.ProductSkuCounters (CategoryId, Prefix, LastNumber)
SELECT c.CategoryId, x.SkuPrefix, 0
FROM @CategoryCounters x
JOIN dbo.Categories c ON c.Name = x.CategoryName
WHERE NOT EXISTS
(
    SELECT 1 FROM dbo.ProductSkuCounters s
    WHERE s.CategoryId = c.CategoryId
);

INSERT dbo.ProductBarcodeCounters (CategoryId, BarcodePrefix, LastNumber)
SELECT c.CategoryId, x.BarcodePrefix, 0
FROM @CategoryCounters x
JOIN dbo.Categories c ON c.Name = x.CategoryName
WHERE NOT EXISTS
(
    SELECT 1 FROM dbo.ProductBarcodeCounters b
    WHERE b.CategoryId = c.CategoryId
);

IF NOT EXISTS (SELECT 1 FROM dbo.ProductBarcodeCounter WHERE CounterId = 1)
    INSERT dbo.ProductBarcodeCounter (CounterId, LastNumber)
    VALUES (1, 0);
GO

/* SAMPLE PRODUCTS */
DECLARE @SampleProducts TABLE
(
    Sku NVARCHAR(30),
    Barcode NVARCHAR(50),
    ProductName NVARCHAR(150),
    CategoryName NVARCHAR(100),
    Price DECIMAL(18,2),
    Cost DECIMAL(18,2),
    StockQty INT,
    ReorderLevel INT
);

INSERT INTO @SampleProducts VALUES
(N'BEV-001', N'8901000000011', N'Mineral Water 500ml', N'Beverages', 1.00, 0.45, 200, 40),
(N'BEV-002', N'8901000000028', N'Cola 330ml Can', N'Beverages', 1.50, 0.80, 150, 30),
(N'BEV-003', N'8901000000035', N'Orange Juice 1L', N'Beverages', 3.20, 1.90, 60, 15),
(N'SNK-001', N'8902000000014', N'Potato Chips 150g', N'Snacks', 2.50, 1.30, 90, 20),
(N'SNK-002', N'8902000000021', N'Chocolate Bar 50g', N'Snacks', 1.80, 0.95, 120, 25),
(N'SNK-003', N'8902000000038', N'Salted Peanuts 200g', N'Snacks', 2.90, 1.60, 8, 10),
(N'GRO-001', N'8903000000017', N'Basmati Rice 5kg', N'Groceries', 12.50, 8.90, 40, 10),
(N'GRO-002', N'8903000000024', N'Olive Oil 500ml', N'Groceries', 7.80, 5.20, 35, 8),
(N'GRO-003', N'8903000000031', N'Spaghetti 500g', N'Groceries', 2.10, 1.10, 70, 15),
(N'HOU-001', N'8904000000010', N'Dish Soap 750ml', N'Household', 3.60, 2.00, 45, 10),
(N'HOU-002', N'8904000000027', N'Paper Towels 2-pack', N'Household', 4.20, 2.60, 5, 10),
(N'PER-001', N'8905000000013', N'Shampoo 400ml', N'Personal Care', 6.90, 4.10, 30, 8),
(N'PER-002', N'8905000000020', N'Toothpaste 120g', N'Personal Care', 3.40, 1.70, 55, 12);

INSERT dbo.Products
(
    Sku, Barcode, Name, CategoryId, Price, Cost, StockQty, ReorderLevel
)
SELECT
    s.Sku,
    s.Barcode,
    s.ProductName,
    c.CategoryId,
    s.Price,
    s.Cost,
    s.StockQty,
    s.ReorderLevel
FROM @SampleProducts s
JOIN dbo.Categories c ON c.Name = s.CategoryName
WHERE NOT EXISTS
(
    SELECT 1 FROM dbo.Products p WHERE p.Sku = s.Sku
);
GO

/* UPDATE COUNTERS TO MATCH EXISTING PRODUCTS */
UPDATE sc
SET LastNumber =
    CASE
        WHEN sc.LastNumber < ISNULL(x.MaxNumber, 0)
        THEN ISNULL(x.MaxNumber, 0)
        ELSE sc.LastNumber
    END
FROM dbo.ProductSkuCounters sc
OUTER APPLY
(
    SELECT MAX(TRY_CONVERT(BIGINT, RIGHT(p.Sku, 6))) AS MaxNumber
    FROM dbo.Products p
    WHERE p.CategoryId = sc.CategoryId
) x;

UPDATE bc
SET LastNumber =
    CASE
        WHEN bc.LastNumber < ISNULL(x.MaxNumber, 0)
        THEN ISNULL(x.MaxNumber, 0)
        ELSE bc.LastNumber
    END
FROM dbo.ProductBarcodeCounters bc
OUTER APPLY
(
    SELECT MAX(TRY_CONVERT(BIGINT, RIGHT(p.Barcode, 9))) AS MaxNumber
    FROM dbo.Products p
    WHERE p.CategoryId = bc.CategoryId
      AND p.Barcode LIKE bc.BarcodePrefix + '%'
) x;
GO

/* INITIAL INVENTORY LOG */
INSERT dbo.InventoryLog (ProductId, ChangeQty, Reason, UserId)
SELECT
    p.ProductId,
    p.StockQty,
    N'Initial stock',
    u.UserId
FROM dbo.Products p
CROSS JOIN dbo.Users u
WHERE u.Username = N'admin'
AND NOT EXISTS
(
    SELECT 1
    FROM dbo.InventoryLog l
    WHERE l.ProductId = p.ProductId
      AND l.Reason = N'Initial stock'
);
GO

/* CUSTOMERS */
IF NOT EXISTS (SELECT 1 FROM dbo.Customers WHERE Email = N'alice@example.com')
    INSERT dbo.Customers (FullName, Phone, Email, Address)
    VALUES (N'Alice Tan', N'+65 8111 2233', N'alice@example.com', N'12 Orchard Road');

IF NOT EXISTS (SELECT 1 FROM dbo.Customers WHERE Email = N'brian@example.com')
    INSERT dbo.Customers (FullName, Phone, Email, Address)
    VALUES (N'Brian Lim', N'+65 8222 3344', N'brian@example.com', N'45 Bukit Timah Road');

IF NOT EXISTS (SELECT 1 FROM dbo.Customers WHERE FullName = N'Carla Gomez')
    INSERT dbo.Customers (FullName, Phone, Email, Address)
    VALUES (N'Carla Gomez', N'+65 8333 4455', NULL, NULL);
GO

/* =====================================================
   4. AUTHENTICATION PROCEDURES
   ===================================================== */

CREATE OR ALTER PROCEDURE dbo.usp_Login
    @Username NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        u.UserId,
        u.Username,
        u.PasswordHash,
        u.Salt,
        u.FullName,
        u.RoleId,
        r.RoleName,
        u.IsActive
    FROM dbo.Users u
    INNER JOIN dbo.Roles r ON r.RoleId = u.RoleId
    WHERE u.Username = @Username;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_User_TouchLogin
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Users
    SET LastLoginAt = GETDATE()
    WHERE UserId = @UserId;
END;
GO

/* =====================================================
   5. PRODUCT PROCEDURES
   ===================================================== */

/* INSERT PRODUCT */
CREATE OR ALTER PROCEDURE dbo.usp_Product_Insert
    @Name NVARCHAR(150),
    @CategoryId INT,
    @Price DECIMAL(18,2),
    @Cost DECIMAL(18,2),
    @StockQty INT,
    @ReorderLevel INT,
    @UserId INT,
    @Image VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @Prefix NVARCHAR(3);
        DECLARE @SkuNumber BIGINT;
        DECLARE @BarcodePrefix CHAR(4);
        DECLARE @BarcodeNumber BIGINT;
        DECLARE @Sku NVARCHAR(30);
        DECLARE @Barcode NVARCHAR(50);
        DECLARE @ProductId INT;

        SELECT
            @Prefix = Prefix,
            @SkuNumber = LastNumber + 1
        FROM dbo.ProductSkuCounters WITH (UPDLOCK, HOLDLOCK)
        WHERE CategoryId = @CategoryId;

        IF @Prefix IS NULL OR @SkuNumber IS NULL
            THROW 50001, 'SKU counter is missing for this category.', 1;

        UPDATE dbo.ProductSkuCounters
        SET LastNumber = @SkuNumber
        WHERE CategoryId = @CategoryId;

        SET @Sku = @Prefix + N'-' +
            RIGHT(N'000000' + CONVERT(NVARCHAR(20), @SkuNumber), 6);

        SELECT
            @BarcodePrefix = BarcodePrefix,
            @BarcodeNumber = LastNumber + 1
        FROM dbo.ProductBarcodeCounters WITH (UPDLOCK, HOLDLOCK)
        WHERE CategoryId = @CategoryId;

        IF @BarcodePrefix IS NULL OR @BarcodeNumber IS NULL
            THROW 50002, 'Barcode counter is missing for this category.', 1;

        IF @BarcodeNumber > 999999999
            THROW 50003, 'Barcode number range has been exhausted.', 1;

        UPDATE dbo.ProductBarcodeCounters
        SET LastNumber = @BarcodeNumber
        WHERE CategoryId = @CategoryId;

        SET @Barcode = @BarcodePrefix +
            RIGHT(N'000000000' + CONVERT(NVARCHAR(20), @BarcodeNumber), 9);

        INSERT dbo.Products
        (
            Sku, Barcode, Name, CategoryId, Price, Cost,
            StockQty, ReorderLevel, Image
        )
        VALUES
        (
            @Sku, @Barcode, @Name, @CategoryId, @Price, @Cost,
            @StockQty, @ReorderLevel, @Image
        );

        SET @ProductId = CONVERT(INT, SCOPE_IDENTITY());

        IF @StockQty > 0
        BEGIN
            INSERT dbo.InventoryLog
                (ProductId, ChangeQty, Reason, UserId)
            VALUES
                (@ProductId, @StockQty, N'Initial stock', @UserId);
        END;

        COMMIT TRANSACTION;

        SELECT @ProductId AS Id;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
GO

/* UPDATE PRODUCT */
CREATE OR ALTER PROCEDURE dbo.usp_Product_Update
    @ProductId INT,
    @Sku NVARCHAR(30),
    @Barcode NVARCHAR(50) = NULL,
    @Name NVARCHAR(150),
    @CategoryId INT,
    @Price DECIMAL(18,2),
    @Cost DECIMAL(18,2),
    @StockQty INT,
    @ReorderLevel INT,
    @IsActive BIT,
    @Image VARBINARY(MAX) = NULL,
    @ChangeImage BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Products
    SET
        Sku = @Sku,
        Barcode = @Barcode,
        Name = @Name,
        CategoryId = @CategoryId,
        Price = @Price,
        Cost = @Cost,
        StockQty = @StockQty,
        ReorderLevel = @ReorderLevel,
        IsActive = @IsActive,
        Image = CASE
            WHEN @ChangeImage = 1 THEN @Image
            ELSE Image
        END,
        UpdatedAt = GETDATE()
    WHERE ProductId = @ProductId;

    IF @@ROWCOUNT = 0
        THROW 50004, 'Product not found.', 1;
END;
GO

/* DEACTIVATE PRODUCT */
CREATE OR ALTER PROCEDURE dbo.usp_Product_Delete
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Products
    SET
        IsActive = 0,
        UpdatedAt = GETDATE()
    WHERE ProductId = @ProductId;

    IF @@ROWCOUNT = 0
        THROW 50005, 'Product not found.', 1;
END;
GO

/* =====================================================
   6. INVENTORY PROCEDURES
   ===================================================== */

CREATE OR ALTER PROCEDURE dbo.usp_Inventory_Adjust
    @ProductId INT,
    @ChangeQty INT,
    @Reason NVARCHAR(200),
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @CurrentStock INT;

        SELECT @CurrentStock = StockQty
        FROM dbo.Products WITH (UPDLOCK, ROWLOCK)
        WHERE ProductId = @ProductId;

        IF @CurrentStock IS NULL
            THROW 50010, N'Product not found.', 1;

        IF @CurrentStock + @ChangeQty < 0
            THROW 50011, N'Adjustment would make stock negative.', 1;

        UPDATE dbo.Products
        SET StockQty = @CurrentStock + @ChangeQty,
            UpdatedAt = GETDATE()
        WHERE ProductId = @ProductId;

        INSERT dbo.InventoryLog
            (ProductId, ChangeQty, Reason, UserId)
        VALUES
            (@ProductId, @ChangeQty, @Reason, @UserId);

        COMMIT TRANSACTION;

        SELECT @CurrentStock + @ChangeQty AS NewStock;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
GO

/* =====================================================
   7. ORDER PROCEDURE
   ===================================================== */

CREATE OR ALTER PROCEDURE dbo.usp_Order_Create
    @UserId INT,
    @CustomerId INT = NULL,
    @PaymentMethod NVARCHAR(20),
    @DiscountAmount DECIMAL(18,2) = 0,
    @TaxRate DECIMAL(5,2) = 12,
    @AmountPaid DECIMAL(18,2),
    @ItemsXml XML
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @Items TABLE
        (
            ProductId INT NOT NULL PRIMARY KEY,
            Quantity INT NOT NULL
        );

        INSERT @Items (ProductId, Quantity)
        SELECT ProductId, SUM(Quantity)
        FROM
        (
            SELECT
                x.value('@ProductId', 'INT') AS ProductId,
                x.value('@Quantity', 'INT') AS Quantity
            FROM @ItemsXml.nodes('/Items/Item') AS t(x)
        ) s
        GROUP BY ProductId;

        IF NOT EXISTS (SELECT 1 FROM @Items)
            THROW 50020, N'The order has no items.', 1;

        IF EXISTS (SELECT 1 FROM @Items WHERE Quantity <= 0)
            THROW 50021, N'Invalid item quantity.', 1;

        IF @PaymentMethod NOT IN (N'Cash', N'Card', N'Mobile')
            THROW 50026, N'Invalid payment method.', 1;

        IF EXISTS
        (
            SELECT 1
            FROM @Items i
            LEFT JOIN dbo.Products p WITH (UPDLOCK, ROWLOCK)
                ON p.ProductId = i.ProductId
            WHERE p.ProductId IS NULL OR p.IsActive = 0
        )
            THROW 50022, N'One or more products are unavailable.', 1;

        DECLARE @Msg NVARCHAR(200);

        SELECT TOP 1
            @Msg = N'Insufficient stock for ' + p.Name
                + N' (available: ' + CAST(p.StockQty AS NVARCHAR(10)) + N').'
        FROM @Items i
        INNER JOIN dbo.Products p ON p.ProductId = i.ProductId
        WHERE p.StockQty < i.Quantity;

        IF @Msg IS NOT NULL
            THROW 50023, @Msg, 1;

        DECLARE @Subtotal DECIMAL(18,2);

        SELECT @Subtotal =
            SUM(p.Price * i.Quantity)
        FROM @Items i
        INNER JOIN dbo.Products p ON p.ProductId = i.ProductId;

        IF @DiscountAmount < 0 OR @DiscountAmount > @Subtotal
            THROW 50024, N'Invalid discount amount.', 1;

        IF @TaxRate < 0
            THROW 50027, N'Invalid tax rate.', 1;

        DECLARE @Tax DECIMAL(18,2) =
            ROUND(@Subtotal * @TaxRate / 100.0, 2);

        DECLARE @Total DECIMAL(18,2) =
            @Subtotal + @Tax - @DiscountAmount;

        IF @AmountPaid < @Total
            THROW 50025, N'Amount paid is less than the total.', 1;

        DECLARE @OrderNumber NVARCHAR(30) =
            N'ORD-' + CONVERT(NVARCHAR(8), GETDATE(), 112)
            + N'-' + LEFT(REPLACE(CONVERT(NVARCHAR(36), NEWID()), N'-', N''), 17);

        INSERT dbo.Orders
        (
            OrderNumber, CustomerId, UserId, OrderDate,
            Subtotal, TaxAmount, DiscountAmount, Total,
            PaymentMethod, AmountPaid, ChangeDue, Status
        )
        VALUES
        (
            @OrderNumber, @CustomerId, @UserId, GETDATE(),
            @Subtotal, @Tax, @DiscountAmount, @Total,
            @PaymentMethod, @AmountPaid, @AmountPaid - @Total,
            N'Completed'
        );

        DECLARE @OrderId INT = CONVERT(INT, SCOPE_IDENTITY());

        INSERT dbo.OrderDetails
            (OrderId, ProductId, Quantity, UnitPrice, LineTotal)
        SELECT
            @OrderId,
            i.ProductId,
            i.Quantity,
            p.Price,
            p.Price * i.Quantity
        FROM @Items i
        INNER JOIN dbo.Products p ON p.ProductId = i.ProductId;

        UPDATE p
        SET
            StockQty = p.StockQty - i.Quantity,
            UpdatedAt = GETDATE()
        FROM dbo.Products p
        INNER JOIN @Items i ON i.ProductId = p.ProductId;

        INSERT dbo.InventoryLog
            (ProductId, ChangeQty, Reason, UserId)
        SELECT
            i.ProductId,
            -i.Quantity,
            N'Sale ' + @OrderNumber,
            @UserId
        FROM @Items i;

        COMMIT TRANSACTION;

        SELECT @OrderId AS Id, @OrderNumber AS OrderNumber;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
GO

/* =====================================================
   8. REPORT PROCEDURES
   ===================================================== */

CREATE OR ALTER PROCEDURE dbo.usp_Report_DailySales
    @From DATETIME,
    @To DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        CAST(OrderDate AS DATE) AS SaleDate,
        COUNT(*) AS OrderCount,
        SUM(Total) AS Revenue
    FROM dbo.Orders
    WHERE Status = N'Completed'
      AND OrderDate >= @From
      AND OrderDate < DATEADD(DAY, 1, @To)
    GROUP BY CAST(OrderDate AS DATE)
    ORDER BY SaleDate;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Report_TopProducts
    @From DATETIME,
    @To DATETIME,
    @Top INT = 10
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@Top)
        p.Name AS ProductName,
        SUM(d.Quantity) AS QtySold,
        SUM(d.LineTotal) AS Revenue
    FROM dbo.OrderDetails d
    INNER JOIN dbo.Orders o ON o.OrderId = d.OrderId
    INNER JOIN dbo.Products p ON p.ProductId = d.ProductId
    WHERE o.Status = N'Completed'
      AND o.OrderDate >= @From
      AND o.OrderDate < DATEADD(DAY, 1, @To)
    GROUP BY p.Name
    ORDER BY SUM(d.LineTotal) DESC;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Report_SalesByCategory
    @From DATETIME,
    @To DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.Name AS CategoryName,
        SUM(d.LineTotal) AS Revenue
    FROM dbo.OrderDetails d
    INNER JOIN dbo.Orders o ON o.OrderId = d.OrderId
    INNER JOIN dbo.Products p ON p.ProductId = d.ProductId
    INNER JOIN dbo.Categories c ON c.CategoryId = p.CategoryId
    WHERE o.Status = N'Completed'
      AND o.OrderDate >= @From
      AND o.OrderDate < DATEADD(DAY, 1, @To)
    GROUP BY c.Name
    ORDER BY SUM(d.LineTotal) DESC;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Report_LowStock
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ProductId,
        Sku,
        Name,
        StockQty,
        ReorderLevel
    FROM dbo.Products
    WHERE IsActive = 1
      AND StockQty <= ReorderLevel
    ORDER BY StockQty, Name;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_Report_Dashboard
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        (
            SELECT ISNULL(SUM(Total), 0)
            FROM dbo.Orders
            WHERE Status = N'Completed'
              AND OrderDate >= CAST(GETDATE() AS DATE)
        ) AS TodaySales,

        (
            SELECT COUNT(*)
            FROM dbo.Orders
            WHERE Status = N'Completed'
              AND OrderDate >= CAST(GETDATE() AS DATE)
        ) AS TodayOrders,

        (
            SELECT COUNT(*)
            FROM dbo.Products
            WHERE IsActive = 1
              AND StockQty <= ReorderLevel
        ) AS LowStockCount,

        (
            SELECT COUNT(*)
            FROM dbo.Products
            WHERE IsActive = 1
        ) AS ActiveProducts;
END;
GO

PRINT N'THEPA-POS database setup completed.';
GO
