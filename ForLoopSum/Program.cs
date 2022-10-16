// Ettepidi

Console.WriteLine("");
Console.WriteLine("Ettepidi");
Console.WriteLine("");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i={i + 1}");
}


// Tagurpidi
Console.WriteLine("");
Console.WriteLine("Tagurpidi");
Console.WriteLine("");
for (int i = 3; i > 0; i--) // "i--" on sama mis "i - 1"
{
    Console.WriteLine($"i={i}");
}

// Uuesti aga summeerime

Console.WriteLine("");
Console.WriteLine("Ettepidi ja summeerime");
Console.WriteLine("");
int sum = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i={i}");
    Console.WriteLine($"Hetkel kokku:{sum}");
    sum = sum + i;
}
Console.WriteLine($"Lõplik kokku:{sum}");