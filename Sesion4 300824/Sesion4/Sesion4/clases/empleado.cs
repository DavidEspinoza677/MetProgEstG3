using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases

{/*Calcular el salario neto de el empleado*/
    internal class empleado
    {
        public empleado() { }   
         
        public int ID;  {  get; set; }  
        public string FirstName  {  get; set; }  
        public string LastName  {  get; set; }   
        public string Email  {  get; set; }  
        public string Phone  {  get; set; }  
        public string Salary  {  get; set; }

        public empleado(int id, string firstName, string lastName, string email, string phone, string salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }
}

