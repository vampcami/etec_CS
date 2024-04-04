int inicio, fim;

Console.Write("Início: ");
inicio = Convert.ToInt32 (Console.ReadLine());

Console.Write("Fim: ");
fim = Convert.ToInt32 (Console.ReadLine());

if (fim >= inicio)
{
    int n = inicio;
    
    while (n <= fim)
{
    Console.Write($"{n}, ");
    n += 1;
}
}
else
{
    Console.WriteLine("Coloque Início e Fim para ter um resultado. ");
}