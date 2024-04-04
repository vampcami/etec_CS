double a, b, c, p, área;

Console.WriteLine("Digite o valor que você deseja nos lados do triângulo.\n");

Console.Write("Lado a: ");
a = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado b: ");
b = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado c: ");
c = Convert.ToDouble(Console.ReadLine()!);

p = (a + b + c) /2;
área = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.Write($"\nSemiperímetro: {p}\n");

Console.Write($"Área: {área}");