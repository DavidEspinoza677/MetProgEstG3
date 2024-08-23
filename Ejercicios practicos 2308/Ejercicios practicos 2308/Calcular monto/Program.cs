using System;

class Program
{
    static void Main()
    {
       
        int cantidadProductos;
        decimal precioProducto, montoTotal;


        Console.Write("Ingrese la cantidad de productos: ");
        cantidadProductos = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio por producto: ");
        precioProducto = decimal.Parse(Console.ReadLine());

        montoTotal = cantidadProductos * precioProducto;

 
        Console.WriteLine("El monto total a pagar es: " + montoTotal.ToString("C"));
    }
}
