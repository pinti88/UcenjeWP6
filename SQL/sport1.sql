-- Kreiranje baze podataka
CREATE DATABASE sportska_baza;
GO
USE sportska_baza;
GO

-- Kreiranje tablice klub
CREATE TABLE klub (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    naziv VARCHAR(100) NOT NULL,
    osnovan DATETIME NOT NULL,
    stadion VARCHAR(100),
    predsjednik VARCHAR(100),
    drzava VARCHAR(50),
    liga VARCHAR(50)
);

-- Kreiranje tablice igrac
CREATE TABLE igrac (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    ime VARCHAR(50) NOT NULL,
    prezime VARCHAR(50) NOT NULL,
    datum_rodjenja DATE,
    pozicija VARCHAR(50),
    broj_dresa INT,
    klub INT,
    FOREIGN KEY (klub) REFERENCES klub(sifra)
);

-- Kreiranje tablice utakmica
CREATE TABLE utakmica (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    datum DATE NOT NULL,
    vrijeme TIME NOT NULL,
    lokacija VARCHAR(100),
    stadion VARCHAR(100),
    domaci_klub INT,
    gostujuci_klub INT,
    FOREIGN KEY (domaci_klub) REFERENCES klub(sifra),
    FOREIGN KEY (gostujuci_klub) REFERENCES klub(sifra)
);

-- Kreiranje tablice trener
CREATE TABLE trener (
    sifra INT IDENTITY(1,1) PRIMARY KEY,
    ime VARCHAR(50) NOT NULL,
    prezime VARCHAR(50) NOT NULL,
    klub INT,
    nacionalnost VARCHAR(50),
    iskustvo INT,
    FOREIGN KEY (klub) REFERENCES klub(sifra)
);