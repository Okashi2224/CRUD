CREATE TABLE tbl_inventory_Bautista (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(15), 
    Description VARCHAR(50), 
    Quantity INT,
    Price DECIMAL(10,2),
    DateAdded DATETIME DEFAULT GETDATE()
);
