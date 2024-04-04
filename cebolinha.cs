string frase, dislalia;

Console.Write("Digite uma flase: ");
frase = Console.ReadLine()!;

dislalia = frase
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine (dislalia);