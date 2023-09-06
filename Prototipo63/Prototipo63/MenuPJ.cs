using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo63
{
    public class MenuPJ
    {
        
        public void menu(int hp)
        {
            Personaje pj = new Personaje(200, 50);
            int opcion;

            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Ataque Normal");
                Console.WriteLine("2. Ataque Especial");
                Console.WriteLine("3. Defender");
                Console.WriteLine("4. Curar");
                Console.WriteLine("0. Salir");


                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has seleccionado Ataque Normal");
                            int aux = pj.ataqueNormal(hp);
                            
                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado Ataque Especial");
                             aux = pj.ataqueEspecial(hp);
                            break;
                        case 3:
                            Console.WriteLine("Has seleccionado Defender");
                            break;
                        case 4:
                            Console.WriteLine("Has seleccionado Curar");
                            pj.curar();
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del juego. ¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción incorrecta, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción incorrecta, intente de nuevo.");
                }

                Console.WriteLine(); // Espacio en blanco para mejorar la legibilidad.
            }
        }
    }
}
