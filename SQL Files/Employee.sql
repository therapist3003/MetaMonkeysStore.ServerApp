SELECT TOP (1000) [Username]
      ,[Role]
      ,[Password]
  FROM [MM_Store_Db].[dbo].[Employees]

INSERT INTO Employees (Username, Role, Password) VALUES ('travich', 'User', 'travich@mmstore');
INSERT INTO Employees (Username, Role, Password) VALUES ('travich_admin', 'Admin', 'travich_admin@mmstor');