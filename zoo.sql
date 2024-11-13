use master;
go

drop database if exists zoo;
go
create database zoo;
go
 use zoo;

create table prostorija(
sifra int not null primary key identity(1,1), 
dimenzije varchar(30) not null,
maksimalnbroj int not null,
mjesto varchar(50) not null
);

create table datum(
sifra int not null primary key identity(1,1),
datumrodjenja datetime not null,
datumdolaska datetime not null,
datumsmrti datetime not null
);

create table djelatnik(
sifra int not null primary key identity,
ime varchar(50) not null,
prezime varchar(50)
);

create table zivotinja (
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int references djelatnik (sifra) not null,
prostorija int not null,
datum int references datum (sifra) not null
);