DROP TABLE IF EXISTS 'Guests';
Create Table Guests
(
  Id int primary key,
  TenantId int,
  Name varchar(50),
  EntryDate date,
  
  foreign key(TenantId) references Tenants(Id) 
);
DROP TABLE IF EXISTS 'Tenants';
Create Table Tenants
(
  Id int primary key,
  Name varchar(50),
  StartDate date,
  EndDate date,
  ApartmentId int,
  foreign key(ApartmentId) references Apartments(Id) 
);
DROP TABLE IF EXISTS 'Apartments';
Create Table Apartments
(
  Id int primary key,
  Name varchar(50),
  BuildingId int,
  foreign key(BuildingId) references Buildings(Id) 
);
DROP TABLE IF EXISTS 'Buildings';
Create Table Buildings
(
  Id int primary key,
  Name varchar(50)
);



insert into Buildings values 
(1, 'East Wing'),(2, 'West Wing'),(3, 'North Wing'),(4, 'South Wing');

insert into Apartments values 
(101, 'EW-101', 1), (102, 'EW-102', 1),(103, 'EW-103', 1),(104, 'EW-104', 1),
(201, 'WW-201', 2), (202, 'WW-202', 2),(203, 'WW-203', 2),(204, 'WW-204', 2),
(301, 'NW-301', 3), (302, 'NW-302', 3),(303, 'NW-303', 3),(304, 'NW-304', 3),
(401, 'SW-401', 4), (402, 'SW-402', 4),(403, 'SW-403', 4),(404, 'SW-404', 4);

insert into Tenants values
(1, 'Sunny', '1-jan-2023','1-jan-2033', 101),
(2, 'Pankaj', '1-jan-2023','1-jan-2033', 101),
(3, 'Gaurav', '1-jan-2023','1-jan-2033', 101),
(4, 'Vivek', '1-jan-2023','1-jan-2033', 101);

insert into Guests values
(1, 1, 'Vikas',  CURRENT_DATE),
(2, 1, 'Ritika', CURRENT_DATE),
(3, 1, 'Ravi',   CURRENT_DATE),
(4, 1, 'Anshu',  CURRENT_DATE);

select a.Name, count(g.id) as no_of_guests from Apartments as a
left join Tenants as t on a.Id = t.ApartmentId
left join Guests as g on t.id = g.TenantId
Group by a.Id