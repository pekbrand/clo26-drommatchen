# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  
**Grupp:**  
**Datum:**  
**GitHub:**  

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [Philip Ekbrand] | Zip + RAPPORT.md + REFLEKTION.md |


---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> 
Detta var inget större problem, försökte dock förstå skilladen på dem olika sätten att skapa upp klasser och contruktor.
bollade en del med chatgpt gällande auto-construktor och vanligt construktor, blev lite klokare men känner mig fortfarande lite osäker.
Var också kul att förstå "this." använde det initialt men insåg att jag inte behövde det.

### Metoderna

> 
Detta var lite som en klackspark! har jobbat  mycket med funktioner i python men man får ha lite bättre kolla på vad som är privat och inte.
 så man vet vad man får kalla på och inte!

### Main()

>

Alla klasserna är ju flyttade till egna .cs filer så main innehåller skapandet av två fotbollspelare och en match.
Sen gör spelarna mål och vi kallar även MVP() som berättar vem som har gjort mest mål i matchen. 
under utveckluing testade jag även att Console.WriteLine (med  klasser och propertis)

### Git

> 
Jag clonade repot som jag har forkat, så jag kunnde hoppa över
git init.
istället:
git add .
git commit -m "First commit"
git push

Jag såg att det kommit upp något mer i orgianl repot så gjorde pull.
fick konfliket så fick merga dem två commits.
Sen samma steg igen för att uppdatera namn i construktorn och snyggade till hur texten skrivs ut i consolen.

### Kodkvalitet

>  i min sista commit kikade jag in lite i namn på variabler, tror inte dem är perfeka men mer städade än innan. Har även försökt att indenta allt rätt så det skall vara lättläst.
>Hoppas att det är någotlunda rätt, är ju helt nu till C#

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.


### Vad vi lade till

> Jag använde mig av en dict för att hålla reda på hur många mål varje spelare hade gjort, men när jag väl skulle presentera insåg att två spelare kan ha gjort lika många mål. jag fick då även skapa upp en lista för att sen skriva ut dem som hade gjort lika många mål.Kunde lika gärna ha printat listan men använda variblerna och printade en mer unik text om det bara var en MVP
---
### Varför vi löste det såhär

> jag vill försöka göra detta så dynamiskt som möjligt, detta var ju bara för dagen match så jag behöver skapa upp något som kan räkna varje spelares mål i matchen. En dict kändes som det självklara valet. denna var ju tvungen att placeras i klassen match för att räkna unik match, insåg att flera spelare kan ha gjort lika många mål då fick jag skapa en lista, så om den inne håller mer än 1 person så printar vi alla namnen i listan.



---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```
