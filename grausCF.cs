double C, F;

Console.Write("Digite uma temperatura em Graus Celsius: ");
C = Convert.ToDouble(Console.ReadLine()!);

F = C * 1.8 + 32;

Console.Write($"\n{C}°C Equivalem a {F}°F");