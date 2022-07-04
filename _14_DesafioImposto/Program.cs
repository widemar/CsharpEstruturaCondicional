using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Renda anual com salário: ");
double rendaAnualComSalario = double.Parse(Console.ReadLine()!, info);
Console.Write("Renda anual com prestação de serviço: ");
double rendaAnualComServico = double.Parse(Console.ReadLine()!, info);
Console.Write("Renda anual com ganho de capital: ");
double rendaAnualComCapital = double.Parse(Console.ReadLine()!, info);
Console.Write("Gastos médicos: ");
double gastosMedicos = double.Parse(Console.ReadLine()!, info);
Console.Write("Gastos educacionais: ");
double gastosEducacionais = double.Parse(Console.ReadLine()!, info);

Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA");

double salarioMensal = rendaAnualComSalario / 12;
double impostoSalario = 0.0;
switch (salarioMensal)
{
    case < 3000:
        Console.WriteLine("Isento");
        break;
    case < 5000:
        impostoSalario = rendaAnualComSalario * 0.10;
        break;
    default:
        impostoSalario = rendaAnualComSalario * 0.20;
        break;
}

double impostoServico = rendaAnualComServico switch
{
    > 0 => rendaAnualComServico * 0.15,
    _ => 0.0
};

double impostoCapital = rendaAnualComCapital switch
{
    > 0 => rendaAnualComCapital * 0.20,
    _ => 0.0
};

Console.WriteLine("CONSOLIDADO DE RENDA:");
Console.WriteLine($"Imposto sobre salario: {impostoSalario.ToString("F2", info)}");
Console.WriteLine($"Imposto sobre serviços: {impostoServico.ToString("F2", info)}");
Console.WriteLine($"Imposto sobre ganho de capital: {impostoCapital.ToString("F2", info)}");

double somaImpostos = impostoSalario + impostoServico + impostoCapital;
double maximoDedutivel = somaImpostos * 0.30;
double gastosDedutiveis = gastosMedicos + gastosEducacionais;

Console.WriteLine("DEDUÇÕES:");
Console.WriteLine($"Máximo dedutivel: {maximoDedutivel.ToString("F2", info)}");
Console.WriteLine($"Gastos dedutiveis: {gastosDedutiveis.ToString("F2", info)}");

double abatimento = maximoDedutivel < gastosDedutiveis ? maximoDedutivel : gastosDedutiveis;
double impostoDevido = somaImpostos - abatimento;

Console.WriteLine("RESUMO:");
Console.WriteLine($"Imposto bruto total: {somaImpostos.ToString("F2", info)}");
Console.WriteLine($"Abatimento: {abatimento.ToString("F2", info)}");
Console.WriteLine($"Imposto devido: {impostoDevido.ToString("F2", info)}");