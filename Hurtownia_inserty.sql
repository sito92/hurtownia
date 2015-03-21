Insert Clients(Name,Surname,NIP,CompanyName,TelephoneNumber,EMail,Address_Id) VALUES ('Jan','Kowalski','AugFaug','767123321','Jan.Ko@wp.pl',1)



Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Dębska Kuźnia','Wiejska',32,2)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Opole','Głowna',2,6)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Luboszyce','Krótka',1,4)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Metalchem','',5,2)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Ozimek','Opolska',6,7)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Opole','Wiejska',1,1)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Opole','Krakowska',9,1)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Krapkowice','Opolska',7,1)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Kamionek','Kamienna',4,8)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Opole','Głucha',4,1)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Opole','Krakowska',1,15)
Insert Addresses(City,Street,HomeNumber,FlatNumber) Values('Ozimek','Opolska',45,13)

Insert Employees(Name,Surname,Login,Password,TelephoneNumber,EMail) Values('Jan','Kowalski','JanKo','Haslo1111','692321592','Jan.Ko@wp.pl')
Insert Employees(Name,Surname,Login,Password,TelephoneNumber,EMail) Values('Piotr','Kaśko','PiotrKa','Password2222','695324389','PiotrKa@onet.pl')
Insert Employees(Name,Surname,Login,Password,TelephoneNumber,EMail) Values('Anna','Nowak','Annka','NieWiem','952322591','AnnkaNo@gazeta.pl')
Insert Employees(Name,Surname,Login,Password,TelephoneNumber,EMail) Values('Elżbieta','Totutuaj','ElkaTotu','Wchodze','937244392','Elkka.Totu@onet.pl')

Insert ProductTypes(Name) Values('warzywo')
Insert ProductTypes(Name) Values('owoc')
Insert ProductTypes(Name) Values('nabiał')
Insert ProductTypes(Name) Values('napój')
Insert ProductTypes(Name) Values('mięso')

Insert Units(Name,MinimalAmount) Values('kg',10)
Insert Units(Name,MinimalAmount) Values('l',10)
Insert Units(Name,MinimalAmount) Values('Piece',10)
Insert Units(Name,MinimalAmount) Values('g',100)

Insert PaymentTypes(Type) Values('karta')
Insert PaymentTypes(Type) Values('przelew')


Insert Products(Name,UnitId,ProductTypeId,ExpiryDate,Price,Amount) Values('Cytryna',1,2,2015-09-09,1.5,30)
Insert Products(Name,UnitId,ProductTypeId,ExpiryDate,Price,Amount) Values('Marchewka',1,1,2015-09-09,2.5,12)
Insert Products(Name,UnitId,ProductTypeId,ExpiryDate,Price,Amount) Values('Mleko2l',3,3,2015-02-04,5.7,31)
Insert Products(Name,UnitId,ProductTypeId,ExpiryDate,Price,Amount) Values('Pierś z kurczaka',1,5,2015-01-01,24.99,10)

