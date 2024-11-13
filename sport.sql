use master;
go

drop database if exists sport;
go

create database sport;
go
 use sport go

 create table klub(
 sifra int not null primary key identity(1,1),
 naziv varchar(50) not null,
 osnovan datetime not null,
 stadion varchar(50) not null,
 predsjednik varchar(50) not null,
 drzava varchar(50) not null,
 liga int not null
 );

 create table utakmica 
 sifra int not null primary key identity(1,1), 
 vrijeme datetime not null,
 lokacija varchar(50),
 stadion varchar(50)
 domaci_klub int references(
 gostujuci_klub