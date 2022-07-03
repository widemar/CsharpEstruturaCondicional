Console.WriteLine("Digite dois  números inteiros: ");
int numUm = int.Parse(Console.ReadLine()!);
int numDois = int.Parse(Console.ReadLine()!);

string mensagem = numUm % numDois == 0 || numDois % numUm == 0 ? "São múltiplos" : "Não são múltiplos";
Console.Write(mensagem);