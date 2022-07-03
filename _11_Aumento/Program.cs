using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite o salário de pessoa: ");
double salario = double.Parse(Console.ReadLine()!, info);

double novoSalario;
int porcentagem;
double aumento;
switch (salario)
{
    case <= 1000.00:
        porcentagem = 20;
        aumento = salario * (porcentagem / 100.0);
        novoSalario = salario + aumento;
        break;
    case <= 3000.00:
        porcentagem = 15;
        aumento = salario * (porcentagem / 100.0);
        novoSalario = salario + aumento;
        break;
    case <= 8000.00:
        porcentagem = 10;
        aumento = salario * (porcentagem / 100.0);
        novoSalario = salario + aumento;
        break;
    default:
        porcentagem = 5;
        aumento = salario * (porcentagem / 100.0);
        novoSalario = salario + aumento;
        break;
}

Console.WriteLine($"Novo salário = R${novoSalario.ToString("F2", info)}");
Console.WriteLine($"Aumento = R${aumento.ToString("F2", info)}");
Console.WriteLine($"Porcentagem = {porcentagem}%");