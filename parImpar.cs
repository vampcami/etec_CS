int numero; 
Console.WriteLine("Vamos descobrir se o número é ímpar ou par? ");

Console.Write("Digite um número: ");
numero = Convert.ToInt32 (Console.ReadLine());

bool ehpar = (numero % 2) == 0;

if (ehpar)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen; 
    Console.WriteLine($"{numero} é par");
}
else
{ 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{numero} é impar");
}

Console.ResetColor();