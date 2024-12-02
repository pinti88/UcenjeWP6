-- Kreiranje baze podataka
CREATE DATABASE knjiznica_baza;
GO
USE knjiznica_baza;
GO

-- Kreiranje tablice clan
CREATE TABLE clan (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    clbroj INT NOT NULL
);

-- Kreiranje tablice osobe
CREATE TABLE osobe (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    ime VARCHAR(50) NOT NULL,
    prezime VARCHAR(50) NOT NULL,
    adresa VARCHAR(50),
    email VARCHAR(50)
);

-- Kreiranje tablice knjige
CREATE TABLE knjige (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    naslov VARCHAR(50) NOT NULL,
    pisac VARCHAR(50),
    vlasnik INT,
    clan INT,
    datumpos DATETIME,
    datumvrac DATETIME,
    FOREIGN KEY (vlasnik) REFERENCES osobe(sifra),
    FOREIGN KEY (clan) REFERENCES clan(sifra)
);

-- Kreiranje tablice vlasnik
CREATE TABLE vlasnik (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    knjiga INT,
    FOREIGN KEY (knjiga) REFERENCES knjige(sifra)
);