int a, b, resto;

Console.WriteLine("Máximo Divisor Comum (método iterativo)");

Console.Write("Digite o primeiro número: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
b = Convert.ToInt32(Console.ReadLine());

do
{
    resto = a % b;
    a = b;
    b = resto;
}

while
(resto != 0);

Console.WriteLine($"MDC(a, b) = {a}");