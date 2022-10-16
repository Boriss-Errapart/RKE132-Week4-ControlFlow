//FOR-LOOP
//DRY-principle - Do not repeat yourself
// kasutame "for" tsüklit, see nõuab algust, kust me hakkame arvutame neid sammud mida "for" tsükkel hakkab meie jaoks tegema.


int i = 0;

for (i = 0; i < 4; i++) // "i++" on sama asi mis "i + 1"
{
    Console.WriteLine("We dont need no education!");
}

// "int i = 0" -> START, algväärtus kust me peame alustame tsükli tööga.
// "i < 5" -> tingimus, millal tsükkel peab lõppema, antud juhul siis kui i väärtus jõuab 5-eni.END
// "i++" on STEP, ehk samm. Mis peab i-ga toimuma siis kui seda koodi sulgudes täidetakse,nö. määrama astme suuruse.

Console.WriteLine(i);
Console.WriteLine("Ilusat päeva!");


//Console.WriteLine("We dont need no education!!!");
//Console.WriteLine("We dont need no education!!!");
//Console.WriteLine("We dont need no education!!!");
//Console.WriteLine("We dont need no education!!!");
//Console.WriteLine("We dont need no education!!!");
