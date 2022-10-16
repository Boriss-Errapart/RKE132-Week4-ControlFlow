// "forloop" on tsükkel mis paneb meie koodi käima niikaua kuni mingi tingimus täidetud.


Random rnd = new Random();
int cpuRandom;
bool loopActive = true; // "bool" on väärtus mis võib olla kahte tüüpi, "true" või #false"
Console.WriteLine("");

while (loopActive) // "while" käsku kasutades saab loop töötada nii kaua kuni muutuja "loopActive" saab olema "true".
{
    cpuRandom = rnd.Next(1, 4); // hakkame genereerima juhuslikku numbreid "Next(1, 4)" tähendab, et viimane väärtus mida võib genereerida on tegelikult 3
    Console.WriteLine("Tee pakkumine. Trükkige number vahemikus 1 kuni 3 (kaasa arvatud)");
    Console.WriteLine($"Arvuti on genereerinud juhusliku numbri {cpuRandom}");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Õnnitleme, teie võitsite!");
        loopActive = false; // selle käsuga väljub ringlusest. Saab kasutada ka "break" käsku lõpetamiseks.
    }
    else
    {
        Console.WriteLine("Väga kahju, proovige uuesti!");
    }
}

Console.WriteLine("Ilusat päeva jätku teile!");
Console.WriteLine("");