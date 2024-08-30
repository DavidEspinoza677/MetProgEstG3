using sesion2.clases;

namespace sesion2
{

    //leer los datos de un person y decir sie es mayor o menor de edad
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Persona persona = new Persona();

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Dime tu fecha de nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}