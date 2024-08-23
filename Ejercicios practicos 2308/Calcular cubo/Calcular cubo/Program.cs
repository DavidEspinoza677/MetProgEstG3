using System;

class Program
{
    static void Main()
    {
     
        double numero, cubo;

       
        Console.Write("Ingrese un número: ");
        numero = double.Parse(Console.ReadLine());
        
        cubo = Math.Pow(numero, 3);

       
        Console.WriteLine("El cubo de " + numero + " es: " + cubo);
    }
}
