SELECT TOP (1000) [InvoiceID]
      ,[CustomerID]
      ,[InvoiceDate]
      ,[TotalAmount]
  FROM [MM_Store_Db].[dbo].[Invoices]

INSERT INTO Invoices (InvoiceID, CustomerID, InvoiceDate, TotalAmount) VALUES ('522', '31', '2024-05-07', 3100.00);
INSERT INTO Invoices (InvoiceID, CustomerID, InvoiceDate, TotalAmount) VALUES ('526', '22', '2024-05-08', 8200.00);
INSERT INTO Invoices (InvoiceID, CustomerID, InvoiceDate, TotalAmount) VALUES ('115', '19', '2024-05-14', 1300.00);
INSERT INTO Invoices (InvoiceID, CustomerID, InvoiceDate, TotalAmount) VALUES ('722', '05', '2024-05-15', 3500.00);
