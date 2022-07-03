using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Você vai digitar a temperatura em qual escala? C ou F: ");
char tipoTemperatura = char.Parse(Console.ReadLine()!.ToUpper());

if (tipoTemperatura == 'F')
{
    Console.Write("Digite a temperatura em Fahrenheit: ");
    double fahrenheit = double.Parse(Console.ReadLine()!, info);
    double conversao = (fahrenheit - 32) / 1.8;
    Console.WriteLine($"Temperatura equivalente em Celsius: {conversao.ToString("F2", info)}");
}
else
{
    Console.Write("Digite a temperatura em Celsius: ");
    double celsius = double.Parse(Console.ReadLine()!, info);
    double conversao = celsius * 1.8 + 32;
    Console.WriteLine($"Temperatura equivalente em Fahrenheit: {conversao.ToString("F2", info)}");
}