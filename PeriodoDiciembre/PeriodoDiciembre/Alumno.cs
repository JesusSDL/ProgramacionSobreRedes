using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodoDiciembre
{
    class Alumno
    {
        string nombre;
        string apellido;
        int curso;
        string DNI;
        
        public bool esAlumnoPar()
        {
            return Int32.Parse(DNI) % 2 == 0;
        }


    }
}
