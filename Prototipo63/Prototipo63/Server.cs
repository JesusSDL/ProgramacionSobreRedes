using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo63
{
    public class Server
    {
        static void Main(string[] args)
        {
            Socket miSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint miDir = new IPEndPoint(IPAddress.Any, 1234);

            try
            {
                miSocket.Bind(miDir);
                miSocket.Listen(1);
                Console.WriteLine("Escuchando...");
                Socket escuchar = miSocket.Accept();
                Console.WriteLine("Conecta2");
                
                miSocket.Close();
                escuchar.Close();
            }
            catch (Exception error)
            {

                Console.WriteLine(error.ToString());

            }
            Console.ReadKey();
        }


    }
}
