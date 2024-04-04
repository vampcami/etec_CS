string palavraComCensura = "@#$%¨&*";
string fraseDigitada, fraseCensurada;

Console.Write("O que você acha de quem não faz dever de casa? ");
fraseDigitada = Console.ReadLine()!;

fraseCensurada = fraseDigitada
.Replace("bobo", palavraComCensura)
.Replace("burro", palavraComCensura)
.Replace("idiota", palavraComCensura);

Console.WriteLine();

Console.Write("Que palavra grosseira! No seu lugar eu diria: ");

Console.Write(fraseCensurada);
