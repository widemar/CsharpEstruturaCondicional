using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite a medida da glicose: ");
double glicose = double.Parse(Console.ReadLine()!, info);

string classificacao = glicose switch
{
    <= 100 => "normal",
    <= 140 => "elevado",
    _ => "diabetes"
};

Console.WriteLine($"Classificação: {classificacao}");

