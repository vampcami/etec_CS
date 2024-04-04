double m, cm, km;

Console.Write("Digite uma medida em metros: ");
m = Convert.ToDouble (Console.ReadLine()!);

Console.WriteLine("");

cm = m * 100;
km = m / 1000;

Console.WriteLine("Equivalências: ");

Console.WriteLine($"{cm} cm");
Console.WriteLine($"{m} m");
Console.WriteLine($"{km} km \n");
