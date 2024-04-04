double kms, milhas;

Console.Write("Digite para transformar milhas em kms: ");
milhas = Convert.ToDouble (Console.ReadLine()!);

kms = milhas * 1.609;

Console.Write ($"{kms:N3} Km");