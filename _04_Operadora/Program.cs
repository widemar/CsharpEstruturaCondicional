using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite a quantidade de minutos: ");
int minutos = int.Parse(Console.ReadLine()!);

double valorPagar = minutos <= 100 ? 50.00 : (minutos - 100) * 2 + 50.00;

Console.WriteLine($"Valor a pagar: R${valorPagar.ToString("F2", info)}");