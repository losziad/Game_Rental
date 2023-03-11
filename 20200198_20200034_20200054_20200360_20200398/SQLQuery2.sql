create database Game_Rental;

CREATE TABLE Game
(
  GID INT NOT NULL,
  Vendor VARCHAR(25) NOT NULL,
  Gname VARCHAR(30) NOT NULL,
  Category VARCHAR(25) NOT NULL,
  NumberofRenters INT NOT NULL,
  publishedYear INT NOT NULL,
  publishedMonth INT NOT NULL,
  PRIMARY KEY (GID)
);

CREATE TABLE Vendor
(
  VID INT NOT NULL,
  FNAME VARCHAR(25) NOT NULL,
  LName VARCHAR(25) NOT NULL,
  Year INT NOT NULL,
  NumberOfGames INT NOT NULL,
  phone VARCHAR(15) NOT NULL,
  email VARCHAR(35) NOT NULL,
  GID INT NOT NULL,
  PRIMARY KEY (VID),
  FOREIGN KEY (GID) REFERENCES Game(GID)
);

CREATE TABLE Client
(
  CID INT NOT NULL,
  Gender VARCHAR(7) NOT NULL,
  FName VARCHAR(25) NOT NULL,
  LName VARCHAR(25) NOT NULL,
  phone VARCHAR(15) NOT NULL,
  Age INT NOT NULL,
  NumberOfRenteredGames INT NOT NULL,
  email VARCHAR(35) NOT NULL,
  GID INT NOT NULL,
  PRIMARY KEY (CID),
  FOREIGN KEY (GID) REFERENCES Game(GID),
  Password_ varchar(20) not null,
);

CREATE TABLE Admin
(
  Fname VARCHAR(25) NOT NULL,
  Lname VARCHAR(25) NOT NULL,
  email VARCHAR(35) NOT NULL,
  phone VARCHAR(15) NOT NULL,
  Password_ varchar(20) not null,
);

select * from Game;

insert into Game values (1,'Omar','pubg','war',300,2020,3);
insert into Game values (2,'ahmedm','callofduty','war',200,2018,4);
insert into Game values (3,'ahmedh','pes','sport',3000,2009,5);
insert into Game values (4,'zyad','mario','adventure',8550,2010,6);
insert into Game values (5,'kamal','stample guy','challenge',10000,2021,7);
insert into Game values (6,'wael','critical ops','action',0,2022,4);

select * from Vendor;

insert into Vendor values(20200360,'omar','mahmoud',2020,10,01114466095,'mohamedahmed@gmail.com',1);
insert into Vendor values(20200034,'ahmed','magdy',2021,3,01268426168,'ahmedmagdy@gmail.com',2);
insert into Vendor values(20200054,'ahmed','hany',2022,5,01236547894,'ahmedhany@gmail.com',3);
insert into Vendor values(20200398,'kamal','ahmed',2018,1,01116644008,'kamalahmed@gmail.com',5);
insert into Vendor values(20200198,'ziad','ayman',2019,15,01115588123,'ziadayman@gmail.com',4);
insert into Vendor values(20200001,'mahmoud','wael',2022,0,01115588138,'mahmoudwael@gmail.com',6);



select * from Client 

insert into Client values (55,'male','mahmoud','alaa',01234587963,20,3,'mahmoudalaa33@gmail.com',2,'12345678')
insert into Client values (66,'female','ryym','alaa',01234326967,22,1,'ryym_a@gmail.com',4,'987654321')
insert into Client values (77,'male','omar','gaber',01087889963,15,6,'mahmoudalaa33@gmail.com',5,'258963147')
insert into Client values (88,'female','nour','sherbeny',01569779624,25,1,'nourr666@gmail.com',1,'123987456')
insert into Client values (99,'male','ibrahem','mohamed',01113377035,28,1,'ibrahem_mohamed@gmail.com',3,'258963147')

select * from Admin

insert into Admin values ('fathy','adel','fathyadel@yahoo.com',01114466000,'125968763')


--Maximium number of renters
SELECT Gname,Vendor,NumberofRenters from Game
where NumberofRenters=(Select MAX(NumberofRenters) from game);

--
select Gname,Vendor,NumberofRenters from Game 
Where NumberofRenters =0 and publishedMonth = 4 ;

SELECT FName,LName,NumberOfRenteredGames from Client
where NumberOfRenteredGames=(Select MAX(NumberOfRenteredGames) from Client);



SELECT TOP 1  Vendor.FNAME,Vendor.LName,Game.NumberofRenters
from Game
INNER Join Vendor

on Game.GID=Vendor.GID

order by NumberofRenters desc;


SELECT TOP 1  Vendor.FNAME,Vendor.LName,Game.NumberofRenters
from Game
INNER Join Vendor

on Game.GID=Vendor.GID

order by NumberofRenters ASC;




select *from Vendor
where NumberOfGames=0;



