using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIf.models
{
    internal class evaluate
    {
        public evaluate() { }

        public string EvalAge(int age)
        {
            try
            {
                if (age >= 0 && age <= 12) return "Eres un niño";
                else if (age >= 13 && age <= 25) return "Eres un joven";
                else if (age >= 26) return "Eres un adulto";
                return "Edad no admitida";
            }catch (Exception ex)
            {
                return $"Error {ex.ToString}";
            }
            return "Edad no adminitida";
        }

    }
}
