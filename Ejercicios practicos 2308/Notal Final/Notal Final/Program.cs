using System;

class Program
{
    static void Main()
    {
      
        double nota1, nota2, nota3, notaFinal;

        
        Console.Write("Ingrese la primera nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        nota3 = double.Parse(Console.ReadLine());
      
        notaFinal = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("La nota final del estudiante es: " + notaFinal.ToString("F2"));
    }
}
