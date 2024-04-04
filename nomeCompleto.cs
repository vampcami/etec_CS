string Nome, Sobrenome, SobrenomeMaiusculo;

Console.Write ("Digite seu Nome: ");
Nome = Console.ReadLine ()!;

Console.Write ("Digite seu Sobrenome: ");
Sobrenome = Console.ReadLine ()!;

SobrenomeMaiusculo = Sobrenome.ToUpper(); 

Console.WriteLine ($"Nome Completo: {Nome} {Sobrenome} ");

Console.WriteLine ($"Nome de Catálogo: {SobrenomeMaiusculo}, {Nome} ");