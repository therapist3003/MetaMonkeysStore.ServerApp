SELECT TOP (1000) [InvoiceItemID]
      ,[InvoiceID]
      ,[ItemID]
      ,[Quantity]
  FROM [MM_Store_Db].[dbo].[InvoiceItems]

INSERT INTO InvoiceItems (InvoiceItemID, InvoiceID, ItemID, Quantity) VALUES ('1', '98765', '2345', 3);
INSERT INTO InvoiceItems (InvoiceItemID, InvoiceID, ItemID, Quantity) VALUES ('2', '98765', '3456', 2);
INSERT INTO InvoiceItems (InvoiceItemID, InvoiceID, ItemID, Quantity) VALUES ('3', '98765', '4567', 1);