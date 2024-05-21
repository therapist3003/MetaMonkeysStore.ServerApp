SELECT TOP (1000) [ItemID]
      ,[Name]
      ,[UnitCost]
      ,[GST]
      ,[Discount]
      ,[ProcuredQuantity]
  FROM [MM_Store_Db].[dbo].[Items]

INSERT INTO Items (ItemID, Name, UnitCost, GST, Discount, ProcuredQuantity) VALUES ('1234', 'Hard disk', 4000.00, 12.00, 5.00, 2);
INSERT INTO Items (ItemID, Name, UnitCost, GST, Discount, ProcuredQuantity) VALUES ('2345', 'RAM', 12000.00, 12.00, 5.00, 3);
INSERT INTO Items (ItemID, Name, UnitCost, GST, Discount, ProcuredQuantity) VALUES ('3456', 'Laptop stand', 1000.00, 12.00, 5.00, 2);
INSERT INTO Items (ItemID, Name, UnitCost, GST, Discount, ProcuredQuantity) VALUES ('4567', 'Wireless keyboard', 600.00, 12.00, 5.00, 1);