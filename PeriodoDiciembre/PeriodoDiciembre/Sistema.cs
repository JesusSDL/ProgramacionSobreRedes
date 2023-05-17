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
        
        

    }
}
