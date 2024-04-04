int numero;

Console.Write ("Digite um número para descobrir se ele é Negativo: ");
numero = Convert.ToInt32 (Console.ReadLine());

if (numero < 0)

{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine ($"{numero} é negativo");
}
    else if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine ($"{numero} não é negativo");
}