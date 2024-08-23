using System;

class Program
{
    static void Main()
    {        
        double radio, area;
       
        Console.Write("Ingrese el radio del círculo: ");
        radio = double.Parse(Console.ReadLine());
        
        area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("El área del círculo con radio " + radio + " es: " + area.ToString("F2"));
    }
}
