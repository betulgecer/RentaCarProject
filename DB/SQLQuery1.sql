Create table Cars (
CarId int Primary key identity(1,1),
BrandId int,
ColorId smallint, 
ModelYear smallint,
DailyPrice decimal,
Descriptions nvarchar(50),
foreign key (BrandId) references Brands (BrandId),
foreign key (ColorId)references Colors (ColorId),
)

Create table Colors (
ColorId smallint primary key identity(1,1),
ColorName nvarchar(25)

)

Create table Brands (
BrandId int primary key identity(1,1),
BrandName nvarchar(25)
)

insert into Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) values 
('1','3',1998,110,'Manuel 5 vites'),
('2','1',2010,170,'Otomatik benzin'),
('3','2',2013,190,'Otomatik dizel'),
('1','3',2015,200,'Otomatik hybrid'),
('1','3',2002,130,'Manuel 5 vites LPG');

insert into Colors(ColorName) values ('Siyah'), ('Beyaz'), ('Mavi'), ('Kırmızı'), ('Kahverengi');

insert into Brands(BrandName) values ('BMW'), ('Mercedes'), ('Wolksvagen'),('Ford'),('Renault'),('Fiat');

select * from Cars

select * from Brands
select * from Colors