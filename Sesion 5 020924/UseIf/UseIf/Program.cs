using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*Decir si es niño, joven o adulto
            /*
             * Niño: 0 -12
             * Joven: 13 - 25
             * aulto: 26 a mas.
             * */
            int edad = 0;
            evaluate evaluate = new evaluate();
            Console.WriteLine("Evaluar edad");
            Console.Write("Ingresa tu edad");
            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(evaluate.EvalAge(edad));


        }
    }
}
