using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodoDiciembre
{
     class Sistema
    {

        ArrayList losExamenes = new ArrayList();  
        public ArrayList losEasyPeasy()
        {
            ArrayList losEasyPeasy = new ArrayList();
            foreach (Examen examenes in losEasyPeasy) {
                if (examenes.esEasyPeasy()){ 
                    losEasyPeasy.Add(examenes);
                }

            }
            return losEasyPeasy;
        }
        
        public Examen masParero()
        {
            Examen aux = new Examen();
            aux = (Examen)losExamenes[0];

            foreach (Examen examenes in losExamenes)
            {
                if (examenes.examenMasAlumnosPar() > aux.examenMasAlumnosPar())
                {
                    aux = examenes;
                }
            }
            return aux;
        }

    }
}
