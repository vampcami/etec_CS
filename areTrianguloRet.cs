double b, h, área;

Console.Write("Base: ");
b = Convert.ToDouble (Console.ReadLine()!);

Console.Write("Altura: ");
h = Convert.ToDouble (Console.ReadLine()!);

área = (b * h) / 2;

Console.Write($"Área: {área:N1}");