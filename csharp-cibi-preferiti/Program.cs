string[] cibi = { "pizza", "pasta", "kebab", "panino", "piadina" };

Console.WriteLine($"Lunghezza classifica: {cibi.Length}");

Console.WriteLine("Classifica:");
for  ( int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i + 1}) {cibi[i]}");
}

Console.WriteLine($"Cibo top: {cibi[0]}");

Console.WriteLine($"Cibo meno preferito: {cibi[cibi.Length - 1]}");