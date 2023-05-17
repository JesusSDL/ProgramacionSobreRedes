using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodoDiciembre
{
    class Examen
    {
        bool esTeorico;
        int puntos;
        ArrayList estudiosos = new ArrayList();
        

        public bool esExamenComun()
        {
            return estudiosos.Count > 8;
        }
       public bool esExamenLatam()
        {
            return !esTeorico & puntos > 6;
        }

        public bool esEasyPeasy()
        {
            return esTeorico & puntos < 5 & estudiosos.Count < 6;
        }   
        
        public int examenMasAlumnosPar()
        {
            ArrayList examenes = new ArrayList();
            foreach(Alumno alumnos in estudiosos) {
                if (alumnos.esAlumnoPar() )
                {
                    examenes.Add(alumnos);
                }
            }
            return examenes.Count;
        }
        
    }
}
