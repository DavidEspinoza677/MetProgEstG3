using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{
    internal class rrhh
    {
        /*Caluclar el salario neto de el empleado*/
        public rrhh() { }
        public double calcularSalario (Empleado empleado, double deducciones)
        { 
            return empleado - deducciones;

        }

        //Aumentar el salario en un 5% si su salario base es menor a 10,000

        public void AumentarSalario(empleado empleado, double procentaje,double techo)
        {
            empleado.Salary = (empleado.Salary <= techo) ? empleado.Salary = (empleado.Salary * (1 + porcentaje)) : empleado.Salary;

            if (empleado.Salary <= techo)
            {
                empleado.Salary = empleado.Salary + (empleado.Salary * porcentaje);
            }
            else
            {
                empleado.Salary = empleado.Salary;
            }
        }

    }|
}
