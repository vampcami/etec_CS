double C, F;

Console.Write("Digite uma temperatura em Graus Fahrenheit: ");
F = Convert.ToDouble(Console.ReadLine()!);

C = (F -32) / 1.8;

Console.Write($"\n{F}°F Equivalem a {C}°C");