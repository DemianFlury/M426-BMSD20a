# Test-driven Development in C#

Bitte lösen sie die Aufgabe mit ihrem persönlichen Fork.
Halten Sie Ihre Änderungen mit Git fest
(`git add`, `git commit`) und übertragen Sie diese auf den zentralen Git-Server
(`git push`).

**Der Zustand Ihres persönlichen Repositories dient zur Überprüfung Ihrer
Hausaufgaben und kann zur Benotung herangezogen werden!**  

Bitte gehen sie strikt nach TDD-Regeln vor.

1.	Schreibe keinen Produktivcode, bis es einen Test gibt, der aufgrund dieses fehlenden produktiven Codes scheitert.
2.	Schreibe nicht mehr Testcode, als nötig ist, um den Test zum Scheitern zu bringen ‒ und ein Kompilierfehler gilt als Scheitern.
3.	Schreibe nicht mehr Produktivcode, als nötig ist, um den Test zum Durchlaufen zu bringen.


## Aufgabe 

### FooBarQix
Implementieren sie eine Methode <<`public string Determine(int input)`>>, welche folgende Anforderungen erfüllt 

**Regeln**  
Wenn Nummer durch 3 dividierbar ist, gebe "Foo" anstelle der Nummer zurück.  
Wenn Nummer durch 5 dividierbar ist, gebe "Bar" anstelle der Nummer zurück.  
Wenn Nummer durch 7 dividierbar ist, gebe "Qix" anstelle der Nummer zurück.  

Wenn Nummer durch mehrere der oben gennanten Zahlen dividierbar ist, gebe alle entsprechenden Namen zurück. (siehe Beispiel)

*Beispiel*  
1  => 1  
2  => 2  
3  => Foo (dividierbar durch 3)  
4  => 4  
5  => Bar (dividierbar durch 5)  
6  => Foo (dividierbar durch 3)  
7  => Qix (dividierbar durch 7)  
8  => 8  
9  => Foo  
10 => Bar  
13 => 13  
15 => FooBar (dividierbar durch 3, dividierbar durch 5)  
21 => FooQix (dividierbar durch 3, dividierbar durch 7)  
105 => FooBarQix (dividierbar durch 3, dividierbar durch 5,dividierbar durch 7)  


### Zusatzanforderungen (Freiwillig, für die Schnellen)  
Es gibt zusätzliche Anforderungen:  

Wenn jedes Zeichen 3,5,7, gebe "Foo", "Bar", "Qix" in der entsprechender Reihenfolge dem Resultat hinzu.  
1  => 1  
2  => 2  
3  => FooFoo (dividierbar durch 3, enthält 3)  
4  => 4  
5  => BarBar (dividierbar durch 5, enthält 5)  
6  => Foo (dividierbar durch 3)  
7  => QixQix (dividierbar durch 7, enthält 7)  
8  => 8  
9  => Foo  
10 => Bar  
13 => Foo (enthält 3)  
15 => FooBarBar (dividierbar durch 3, dividierbar durch 5, enthält 5)  
21 => FooQix  
33 => FooFooFoo (dividierbar durch 3, enthält two 3)  
51 => FooBar  
53 => BarFoo  