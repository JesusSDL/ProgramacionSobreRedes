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
        MenuPJ menu = new MenuPJ();
        try
        {
            socketComunicacion.Connect(localHost);
            Console.WriteLine("Conectado");
            Byte[] byRecv = new byte[255];
            int enteroRecibido = socketComunicacion.Receive(byRecv, 0, byRecv.Count(), 0);
            Array.Resize(ref byRecv, enteroRecibido);
            int hpContrincante = Int32.Parse(Encoding.Default.GetString(byRecv));
            menu.menu(hpContrincante);
           
            Byte[] envioHpNuevo = Encoding.Default.GetBytes(hpNuevo);
            socketComunicacion.Send(envioHpNuevo, 0, envioHpNuevo.Count(), 0);

        }
        catch (Exception error) 
        {
            Console.WriteLine(error.ToString());    
        }
    }
}
