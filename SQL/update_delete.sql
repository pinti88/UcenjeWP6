select * from smjerovi 

update smjerovi set cijena=1100
where sifra=2; -- ako mjenjamo po pk tada mjenjamo 1 red 

update smjerovi set izvodiseod='2024-12-05',
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime='Franjić' where sifra=16;

select * from polaznici where sifra=16;


--unjeti 5 novih smjerova s cijenom

insert into smjerovi (naziv,cijena,izvodiseod,vaucer)
values ('audi', 20000,'2024-05-05 18:00',1),
 ('bmw', 22000,'2024-05-05 18:00',1),
 ('wv', 23000,'2024-05-05 18:00',1),
 ('mercedes', 24000,'2024-05-05 18:00',1),
 ('fiat', 25000,'2024-05-05 18:00',1);

select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

--uvecajte sve cijene za 35%

select * from smjerovi;
update smjerovi set cijena = cijena * 1.35;
select * from smjerovi;

--msanjite svim smjerovima cijenu za 10 eura 

select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;

-- uvjet vanjskog kljuca 
update grupe set smjer=8 where sifra=1;

--DELETE naredba 

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;

select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;

