int n, m, produto;

Console.Write("Digite um número: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

m = 0;

while (m <= 10)

{
    produto = n * m;
     Console.WriteLine($"{n} x {m} = {produto}");
     m += 1;

}