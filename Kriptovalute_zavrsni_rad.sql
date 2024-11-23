use master;
go

drop database if exists kriptovalute;
go

create database kriptovalute collate Croatian_CI_AS; 
go

use kriptovalute;
go

use kriptovalute;

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(50),
telefonski_broj varchar(50)
);

create table walleti(
wallet_id int not null primary key identity(1,1),
mreza varchar(50),
korisnik_id int not null references korisnici(sifra),
kljuc varchar(50) not null
);

create table kriptovalute(
kripto_id int not null primary key identity(1,1),
ime varchar(50),
simbol varchar(50),
cijena decimal(10,2),
trzisna_vrjednost decimal (15,2),
volumen decimal(15,2)
);

create table kriptowallet(
wallet_id int not null references walleti(wallet_id),
kripto_id int not null references kriptovalute(kripto_id)
);


create table transakcije( 
sifra int not null primary key identity(1,1),
 kolicina decimal(15,2),
 kripto_id int not null references kriptovalute(kripto_id),
 naknada decimal(10,2)
 );

