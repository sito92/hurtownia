USE [Hurtownia]
GO

INSERT INTO [dbo].[Addresses]
           ([City]
           ,[Street]
           ,[HomeNumber]
           ,[FlatNumber])
     VALUES
         ('Metalchem','',5,2),
		 ('Ozimek','Opolska',6,7),
		 ('Opole','Wiejska',1,1),
		 ('Krapkowice','Opolska',7,1),
		 ('Kamionek','Kamienna',4,8),
		 ('Opole','Krakowska',9,1)
GO


USE [Hurtownia]
GO

INSERT INTO [dbo].[Employees]
           ([Name]
           ,[Surname]
           ,[Login]
           ,[Password]
           ,[TelephoneNumber]
           ,[EMail])
     VALUES
        --('Administrator','Nowak','admin','qwerty123','32434213','admin@sklep.pl'),
		('Jan','Kowalski','JanKo','Haslo1111','692321592','Jan.Ko@wp.pl'),
		('Piotr','Kaśko','PiotrKa','Password2222','695324389','PiotrKa@onet.pl'),
		('Anna','Nowak','Annka','NieWiem','952322591','AnnkaNo@gazeta.pl'),
		('Elżbieta','Totutuaj','ElkaTotu','Wchodze','937244392','Elkka.Totu@onet.pl')
GO





USE [Hurtownia]
GO

INSERT INTO [dbo].[ProductTypes]
           ([Name])
     VALUES
          ('warzywo'),
		  ('owoc'),
		  ('nabiał'),
		  ('napój'),
		  ('mięso')
GO


USE [Hurtownia]
GO

INSERT INTO [dbo].[Units]
           ([Name]
           ,[MinimalAmount])
     VALUES
          ('kg',10),
		  ('l',10),
		  ('Piece',10),
		  ('g',100)
GO


USE [Hurtownia]
GO

INSERT INTO [dbo].[Products]
           ([Name]
           ,[UnitId]
           ,[ProductTypeID]
           ,[ExpiryDate]
           ,[Price]
           ,[Amount])
     VALUES
         ('Cytryna',1,2,2015-09-09,1.5,30),
		 ('Marchewka',1,1,2015-09-09,2.5,12),
		 ('Mleko2l',3,3,2015-02-04,5.7,31),
		 ('Pierś z kurczaka',1,5,2015-01-01,24.99,10)
GO