using System;

class Program
{
    static void Main()
    {
        double basetriangulo;
        double altura;
        double area;

        Console.WriteLine("Digite a base do triangulo");
        basetriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura");
        altura = double.Parse(Console.ReadLine());

        area = (basetriangulo * altura) / 2;

        Console.WriteLine("Área do triângulo: " + area);
    }
}