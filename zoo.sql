use master;
go

drop database if exsist zoo;
go
create database zoo;
 use zoo;

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int,
);


