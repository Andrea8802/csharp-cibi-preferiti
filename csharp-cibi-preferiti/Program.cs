string[] cibi = { "pizza", "pasta", "kebab", "panino", "piadina" };

Console.WriteLine($"Lunghezza classifica: {cibi.Length}");

Console.WriteLine("Classifica:");
for  ( int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i + 1}) {cibi[i]}");
}

Console.WriteLine($"Cibo top: {cibi[0]}");

Console.WriteLine($"Cibo meno preferito: {cibi[cibi.Length - 1]}");

int indiceMedio = cibi.Length / 2;

if(cibi.Length % 2 == 0)
{
    Console.WriteLine($"Cibo di mezzo: {cibi[indiceMedio]} e {cibi[indiceMedio - 1]}");
}
else
{
    Console.WriteLine($"Cibo di mezzo: {cibi[indiceMedio]}");
}