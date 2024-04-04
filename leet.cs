string texto, tradução;

Console.Write("Texto que será traduzido: ");
texto = Console.ReadLine()!;

tradução = texto
.Replace ("a", "4")
.Replace ("A", "4")
.Replace ("e", "3")
.Replace ("E", "3")
.Replace ("i", "1")
.Replace ("I", "1")
.Replace ("T", "7")
.Replace ("t", "7")
.Replace ("S", "5")
.Replace ("s", "5")
.Replace ("O", "0")
.Replace ("o", "0");


Console.Write(tradução);