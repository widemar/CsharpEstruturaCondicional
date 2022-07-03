using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Código do produto comprado: ");
int codigo = int.Parse(Console.ReadLine()!);
Console.Write("Quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine()!);

double valorPagar = codigo switch
{
    1 => quantidade * 5.00,
    2 => quantidade * 3.50,
    3 => quantidade * 4.80,
    4 => quantidade * 8.90,
    _ => quantidade * 7.32
};

Console.WriteLine($"Valor a pagar = R${valorPagar.ToString("F2", info)}");