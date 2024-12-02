use master;
go

drop database if exists kolokvij_vjezba1;
go

create database kolokvij_vjezba1 collate Croatian_CI_AS; 
go

use kolokvij_vjezba1;
go

CREATE TABLE sestra (
    sifra INT PRIMARY KEY,
    introvertno BIT,
    hljina VARCHAR(30) NOT NULL,
    maraka DECIMAL(16, 5),
    hlace VARCHAR(40),
    nankovica INT NOT NULL
);

CREATE TABLE svekar (
    sifra INT PRIMARY KEY,
    bogatstvo VARCHAR(40),
    penzija INT,
    dukserica VARCHAR(40),
    lipa DECIMAL(16, 8),
    usna DECIMAL(12, 2),
    majica VARCHAR(30)
);

CREATE TABLE sestra_svekar (
    sifra INT PRIMARY KEY,
    sestra INT NOT NULL,
    svekar INT NOT NULL,
    FOREIGN KEY (sestra) REFERENCES sestra(sifra),
    FOREIGN KEY (svekar) REFERENCES svekar(sifra)
);

CREATE TABLE zena (
    sifra INT PRIMARY KEY,
    treciputa DATETIME,
    hlace VARCHAR(40),
    kratkamajica VARCHAR(31),
    jmbag CHAR(1),
    bojaociju VARCHAR(39),
    hljina VARCHAR(40),
    sestra INT,
    FOREIGN KEY (sestra) REFERENCES sestra(sifra)
);

CREATE TABLE muskarac (
    sifra INT PRIMARY KEY,
    bogatstvo VARCHAR(50),
    hlace VARCHAR(30),
    model_novca VARCHAR(34),
    maraka DECIMAL(14, 5) NOT NULL,
    zena INT,
    FOREIGN KEY (zena) REFERENCES zena(sifra)
);

CREATE TABLE mladic (
    sifra INT PRIMARY KEY,
    suknja VARCHAR(50),
    kuna DECIMAL(16, 8) NOT NULL,
    drugiputa DATETIME,
    asocijalno BIT,
    ekstrovertno BIT,
    dukserica VARCHAR(40),
    muskarac INT NOT NULL,
    FOREIGN KEY (muskarac) REFERENCES muskarac(sifra)
);

CREATE TABLE cura (
    sifra INT PRIMARY KEY,
    novaca DECIMAL(16, 5) NOT NULL,
    gustoca DECIMAL(15, 8),
    lipa DECIMAL(16, 8),
    ogitac INT,
    bogatstvo VARCHAR(30),
    suknja VARCHAR(30),
    punac INT,
    FOREIGN KEY (punac) REFERENCES svekar(sifra)
);

CREATE TABLE punac (
    sifra INT PRIMARY KEY,
    gustoca INT,
    lipa DECIMAL(15, 8),
    hlace VARCHAR(40)
);


INSERT INTO sestra (sifra, introvertno, hljina, maraka, hlace, nankovica) 
VALUES 
(1, 1, 'Crvena haljina', 500.00, 'Traperice', 10),
(2, 0, 'Plava haljina', 300.50, 'Sportske', 20),
(3, 0, 'Bijela haljina', 150.75, 'Kratke', 30);

INSERT INTO svekar (sifra, bogatstvo, penzija, dukserica, lipa, usna, majica) 
VALUES 
(1, 'Veliko', 3000, 'Zlatni', 150.75, 75.50, 'Plava majica'),
(2, 'Prosječno', 2000, 'Srebrni', 120.30, 50.40, 'Crvena majica'),
(3, 'Minimalno', 1000, 'Brončani', 80.10, 25.20, 'Bijela majica');

INSERT INTO zena (sifra, treciputa, hlace, kratkamajica, jmbag, bojaociju, hljina, sestra)
VALUES 
(1, '2024-12-02 10:00:00', 'Plave', 'Da', 'A', 'Srećna', 'Crvena', 1);

INSERT INTO zena (sifra, treciputa, hlace, kratkamajica, jmbag, bojaociju, hljina, sestra)
VALUES 
(2, '2024-12-02 12:30:00', 'Crne', 'Ne', 'B', 'Tužna', 'Plava', 2);

INSERT INTO zena (sifra, treciputa, hlace, kratkamajica, jmbag, bojaociju, hljina, sestra)
VALUES 
(3, '2024-12-02 15:00:00', 'Bež', 'Da', 'C', 'Srećna', 'Zelena', 3);


INSERT INTO muskarac (sifra, bogatstvo, hlace, model_novca, maraka, zena) 
VALUES 
(1, 'Veliko', 'Traperice', 'Novčanik A', 12345.67, 1),
(2, 'Prosječno', 'Sportske', 'Torba B', 7654.32, 2),
(3, 'Minimalno', 'Kratke', 'Novčanik C', 4321.00, 3);

INSERT INTO sestra_svekar (sifra, sestra, svekar) 
VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 3);

INSERT INTO mladic (sifra, suknja, kuna, drugiputa, asocijalno, ekstrovertno, dukserica, muskarac)
VALUES 
(1, 'Mini suknja', 123.45678901, '2024-01-01 12:00:00', 1, 0, 'Zlatna', 1),
(2, 'Srednja suknja', 234.56789012, '2024-01-02 12:00:00', 0, 1, 'Srebrna', 2),
(3, 'Duga suknja', 345.67890123, '2024-01-03 12:00:00', 1, 1, 'Brončana', 3);

INSERT INTO cura (sifra, novaca, gustoca, lipa, ogitac, bogatstvo, suknja, punac)
VALUES 
(1, 123.45678, 1.23456789, 12.34567891, 10, 'Veliko', 'Mini suknja', 1),
(2, 234.56789, 2.34567891, 23.45678912, 20, 'Prosječno', 'Srednja suknja', 2),
(3, 345.67891, 3.45678912, 34.56789123, 30, 'Minimalno', 'Duga suknja', 3);

INSERT INTO punac (sifra, gustoca, lipa, hlace)
VALUES 
(1, 10, 12.34567891, 'Traperice'),
(2, 20, 23.45678912, 'Sportske'),
(3, 30, 34.56789123, 'Kratke');

UPDATE cura SET gustoca = 15.77;

DELETE FROM mladic WHERE kuna > 15.78;

