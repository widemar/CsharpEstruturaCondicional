using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite a primeira nota: ");
double notaUm = double.Parse(Console.ReadLine()!, info);
Console.Write("Digite a segunda nota: ");
double notaDois = double.Parse(Console.ReadLine()!, info);

double somaNotas = notaUm + notaDois;

Console.WriteLine($"NOTA FINAL = {somaNotas.ToString("F1", info)}");
if (somaNotas < 60)
{
    Console.WriteLine("REPROVADO");
}