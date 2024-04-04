string opcaoDesejada;

Console.Clear();

Console.WriteLine("Calculadora 4 operações\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação que deseja calcular: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":

    double a, b, resultado1; 

    Console.WriteLine("Soma\n");
    Console.WriteLine("Digite os valores: ");
        
        Console.Write(" ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write(" ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado1 = a + b;

        Console.WriteLine($"{a} + {b} = {resultado1}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
        
    case "-":
    double c, d, resultado2;
        Console.WriteLine("subtração\n");
    Console.WriteLine("Digite os valores");
        
        Console.Write(" ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write(" ");
        d = Convert.ToDouble(Console.ReadLine());

        resultado2 = c - d;

        Console.WriteLine($"{c} - {d} = {resultado2}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();


        break;

    case "*":
        double e, f, resultado3;

        Console.WriteLine("Multiplicação\n");
        Console.WriteLine("Digite os valores.");

        Console.Write(" ");
        e = Convert.ToDouble(Console.ReadLine());
        Console.Write(" ");
        f = Convert.ToDouble(Console.ReadLine());

        resultado3 = e * f;

        Console.WriteLine($"{e} x {f} = {resultado3}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;

    case "/":
double g, h, resultado4;
        Console.WriteLine("divisão\n");
    Console.WriteLine("Digite os valores");
        
        Console.Write(" ");
        g = Convert.ToDouble(Console.ReadLine());
        Console.Write(" ");
        h = Convert.ToDouble(Console.ReadLine());

        resultado4 = g / h;

        Console.WriteLine($"{g} ÷ {h} = {resultado4}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;
}