Console.Write("Primeiro valor: ");
int primeiro = int.Parse(Console.ReadLine()!);
Console.Write("Segundo valor: ");
int segundo = int.Parse(Console.ReadLine()!);
Console.Write("Terceiro valor: ");
int terceiro = int.Parse(Console.ReadLine()!);

int menor = primeiro < segundo && primeiro < terceiro ? primeiro : Math.Min(segundo, terceiro);

Console.WriteLine($"MENOR = {menor}");