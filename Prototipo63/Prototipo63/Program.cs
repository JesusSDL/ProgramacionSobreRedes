using Prototipo63;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Program
{
    
    static void Main(string[] args)
    {
        Socket socketComunicacion = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint localHost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
        Personaje pj = new Personaje( 200 , 50) ; 
       
        try
        {
            socketComunicacion.Connect(localHost);
            Console.WriteLine("Conectado");
            byte[] byRecv = new byte[255];
            int enteroRecibido = socketComunicacion.Receive(byRecv, 0, byRecv.Count(), 0);
            Array.Resize(ref byRecv, enteroRecibido);
            int hpContrincante = Int32.Parse(Encoding.Default.GetString(byRecv));

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
                            string aux = pj.ataqueNormal(hpContrincante).ToString();
                            Console.Write(aux);
                            byte[] byEnviarATK = Encoding.Default.GetBytes(aux);

                            break;
                        case 2:
                            Console.WriteLine("Has seleccionado Ataque Especial");
                            aux = pj.ataqueEspecial(hpContrincante).ToString();
                            byEnviarATK = Encoding.Default.GetBytes(aux);

                            break;
                        case 3:
                            Console.WriteLine("Has seleccionado Defender");
                            byte[] recibirDanio = new byte[255];
                            int lenght = socketComunicacion.Receive(recibirDanio, 0, recibirDanio.Count(), 0);
                            Array.Resize(ref recibirDanio, lenght);
                            int recibirDanioNro = Int32.Parse(Encoding.Default.GetString(recibirDanio));
                            pj.defender(recibirDanioNro);
                            break;
                        case 4:
                            Console.WriteLine("Tu vida actual es: " + pj.curar());
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del juego. ¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción incorrecta, intente de nuevo.");
                            break;
                    }

                    Console.Clear();
                }
            }

            
        }
        catch (Exception error) 
        {
            Console.WriteLine(error.ToString());    
        }
        socketComunicacion.Close();
    }
}
