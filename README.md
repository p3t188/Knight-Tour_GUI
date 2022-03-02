# Knight-Tour_GUI

**Projekt feladat GUI része!**


Program indítás:\
A "Játékfelület" adott mezejére kattintva választható ki a kezdőpozíció, ide kerül a huszár.\
Ez a start pozíció lekérhető a Display osztály startPos tulajdonságán keresztül.\
[0-63] tartományban lévő értéket ad vissza, az alábbiak szerint:\
00 01 02 03 04 05 06 07\
...\
56 57 58 59 60 61 62 63\
A csúszkával beállítható a sebesség (Timer Tick időintervallum: 5-500ms)\
![ScrShot_1](https://github.com/p3t188/Knight-Tour_GUI/blob/main/ScrShot/scrshot_1.jpg)\

Futás közben:\
A Go gombra kattintva elindul egy időzítő, amely a sebességbeállításnak megfelelő időközönként meghív egy eseményt.\
Itt kell majd "léptetni" a fő algoritmust, jelenleg a teszt kedvéért egy random szám van generálva ilyenkor.\
A "léptetés" eredményét át kell adni a Display osztály Step metódusának ([0-63] tartomáynban lévő szám, a fentiek szerint).\
Ennek határásra megtörténik a huszár léptetése a pozíciónak megfelelő mezőre, közben a haladás vonalakkal is jelölésre kerül.\
Oldalt a kis 8x8-as táblázatba beíródik az adott lépésszám a megfelelő helyre (1-63 lépés). Ahonnan a huszár indult, ott üres marad.\
![ScrShot_2](https://github.com/p3t188/Knight-Tour_GUI/blob/main/ScrShot/scrshot_2.jpg)\

Futás vége:\
Minden lépés megtörtént, a táblázat teljesen ki lett töltve, az útvonalak jelezve vannak.\
Van hagyva egy label az esetleges üzenetek számára.\
![ScrShot_3](https://github.com/p3t188/Knight-Tour_GUI/blob/main/ScrShot/scrshot_3.jpg)\

**Biztosan vannak még hibák, de nagyjából ilyen lett.**
