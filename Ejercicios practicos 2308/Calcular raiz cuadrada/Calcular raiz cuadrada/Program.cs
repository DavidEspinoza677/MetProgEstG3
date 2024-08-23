using System;

class Program
{
    static void Main()
    {
        double numero, raizCuadrada;
       
        Console.Write("Ingrese un número: ");
        numero = double.Parse(Console.ReadLine());

        raizCuadrada = Math.Sqrt(numero);

        Console.WriteLine("La raíz cuadrada de " + numero + " es: " + raizCuadrada);
    }
}
