string nome, frase, meme;

Console.Write("Qual seu nome? ");
nome = Console.ReadLine()!;

Console.Write ($"oi {nome}, o que você acha de mim? ");
frase = Console.ReadLine()!;

meme = $"{frase.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(meme);