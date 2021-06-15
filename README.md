# RentAndGo
### Tema projekta: Iznajmljivanje vozila
![Logo](https://user-images.githubusercontent.com/73303082/111942733-31e93900-8ad4-11eb-9b61-7da99b168842.png)
## Članovi tima: 
- Azra Ahmić
- Nedina Muratović
- Dženeta Ahmić
- Emina Bašić
-Deployment aplikacije na linku: http://dahmic-001-site1.itempurl.com/
## Opis teme
Apliakcija "RentAndGo" omogućava jednostavan i brz način pronalaženja odgovarajućeg vozila. Pregled vozila je moguć za sve aktere koje pristupe aplikaciji, što podrazumijeva pregled specifikacije vozila, pregled cijene iznajmljivanja, pretraga određenog vozila. Tek korisnici s nalogom imaju pristup i historiji iznajmljivanja vozila, mogu slati zahtjeve zakazivanja i otazivanja rezervacije. Da bi gost mogao zakazati rezervaciju potrebno je da kreira nalog. Kreiranje naloga podrazumijeva verifikaciju ličnih dokumenata(lična karta, vozačka dozvola u slučaju da korisnik sam namjerava upravljati vozilom) te verifikaciju bankovnog računa. Nakon slanja zahtjeva za rezervaciju, korisnik čeka validaciju zahtjeva koja podrazumijeva povratni e-mail. U slučaju da korisnik želi unajmiti ličnog vozača, to navodi u rezervaciji. U međuvremenu se obračuna popust za korisnika u slučaju da iznajmljuje na duži, unaprijed definisani, vremenski period te se kreira ugovor. Otkazivanje rezervcije je moguće najmanje 24h prije zakazanog termina. Najam vozila uključuje potpuno osiguranje kao i neograničenu kilometražu. Menadžer sistema je jedini akter koji ima mogućnost dodavanja novih vozila u sistem, brisanje postojećih i pregleda svih postojećih zahtjeva. 
## Funkcionalnosti
- Mogućnost pregleda svih vozila
- Mogućnost rezervacije vozila u odabranom terminu
- Pretraživanje vozila po parametrima
- Mogućnost pregleda specifikacije vozila
- Mogućnost kartičnog plaćanja
- Otkazivanje rezervacije 24 sata prije termina
- Mogućnost pregleda ugovora 
- Pregled uslova za iznajmljivanje
- Obračunavanje popusta na iznajmljivanje na duži period 
- Pregled pređenih kilometara u toku dana
- Vođenje evidencije o servisiranju automobila
## Akteri
- Gost
- Klijent sa nalogom
- Menadžer
- Sistem za kartično plaćanje 
## Procesi
- Gost
   - Gost ima pravo pregleda vozila, vršenja pretrage vozila po parametrima, pregleda cijene iznajmljivanja i dostupnih vozila. Gost ima mogućnost da promijeni svoj status pravljenjem korisničkog naloga.
- Klijent sa nalogom
   - Klijent sa nalogom ima kreiran korisnički račun. Ima sva prava pristupa kao i gost, te pored tih mogućnosti ima pravo rezervacije vozila.
- Menadžer
   - Menadžer nema mogućnost rezervacije. Ima pravo dodavanja i brisanja novih vozila u sistem, ažuriranje specifikacije vozila, mijenjanje cijene iznajmljivanja ili dodavanja popusta na rezervacije, verifikacije ugovora, ažuriranja uslova za iznajmljivanje i brisanje korisničkih računa.
- Sistem za katrično plaćanje 
   - Sistem za katično plaćanja obezbjeđuje online naplatu usluga. Sve transakcije su u ovlastima tog sistema. Na osnovu unosenih podataka od strane korisnika vrši provjeru validnosti i postojanosti bankovnog računa. U slučaju otkazivanja sistem poništava transakcije koje se tiču takvog korisnika.
  



