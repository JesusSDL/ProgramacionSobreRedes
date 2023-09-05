using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo63
{
    internal class Personaje
    {

        private int hp { get; set; } = 200;
        private int def { get; set; } = 50;
        private int usosEspecial { get; set; } = 3;
        private int usosCura { get; set; } = 2;

        public int ataqueNormal(int hp)
            {
                return hp -= 30;
            }
            
            public int ataqueEspecial(int hp)
            {
                if (usosEspecial > 0)
                {
                Random random = new Random();
                int valorMinimo = 15;
                int valorMaximo = 80;
                int numeroAleatorio = random.Next(valorMinimo, valorMaximo + 1);
                usosEspecial -= 1;
                return hp -= numeroAleatorio;
                }
            else
            {
                return 0; //si retorna 0 este método significa que se acabaron los usos,
                          //es más cómodo para sacarlo del menú al hacer una comparativa 
            }
            }
            public float defender(int atkContrario)
            {
            Random random = new Random();
            int valorMinimo = 20;
            int valorMaximo = 100;
            int randomizer = random.Next(valorMinimo, valorMaximo + 1);
            Console.WriteLine(randomizer);
            int sumarVida = (randomizer * atkContrario) / 100;
            hp += sumarVida;
            Console.WriteLine(hp);
            hp -= atkContrario;
            return hp;

        }
            public int curar()
            { 
                if (usosCura > 0)
                {
                usosCura -= 1;
                    return hp += 40;
                }
                else
                {
                    return 0;
                }
            }

        }
}
