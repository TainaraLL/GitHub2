using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num + num2;


        if (resultado == 0) { }
            
        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey();
    }
}