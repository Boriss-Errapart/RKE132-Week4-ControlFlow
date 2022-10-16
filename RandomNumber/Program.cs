// Juhuslikud numbrid harjutus


using System;

Console.WriteLine("");
Console.WriteLine("Juhuslikud numbrid VOL1");
Console.WriteLine("");

Random rnd = new Random();
int myRandomNum; // deklareerin "int" väärtuse väljaspool "for"-i.
int RandomSum = 0;

for (int i = 0; i < 4; i++)
{
    myRandomNum = rnd.Next(0, 11); // "0, 11" tähendab et genereeritakse väärtusi nullistr kümneni
    Console.WriteLine($"Hetke juhuslik number: {myRandomNum}");
}

Console.WriteLine("");
Console.WriteLine("Juhuslikud numbrid VOL2");
Console.WriteLine("");

for (int i = 0; i < 4; i++)
{
    myRandomNum = rnd.Next(0, 11); // "0, 11" tähendab et genereeritakse väärtusi nullistr kümneni
        RandomSum = RandomSum + myRandomNum;
        Console.WriteLine($"Hetke juhuslik number: {myRandomNum}");
}

Console.WriteLine("");
Console.WriteLine($"Juhuslikke numbrite summa: {RandomSum}");
Console.WriteLine("");
