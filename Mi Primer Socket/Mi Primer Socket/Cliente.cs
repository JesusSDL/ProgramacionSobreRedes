using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

public class Cliente	
{
    static void Main(string[] args)
    {
        Socket miSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint miDir = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
        try
        {
         miSocket.Connect(miDir);
            Console.WriteLine("conectado");
            String texto = "hola";
            byte[] aEnviar = Encoding.Default.GetBytes(texto);
            miSocket.Send(aEnviar);
            Console.WriteLine(texto);
            byte[] byterecib= new byte[255];
            int numrec=miSocket.Receive(byterecib,0,byterecib.Count(),0);
            Array.Resize(ref byterecib,numrec);
            String txtrec = Encoding.Default.GetString(byterecib);
            Console.WriteLine(txtrec);
            String nombre = Console.ReadLine();
            byte[] otrotxt= Encoding.Default.GetBytes(nombre);
            miSocket.Send(otrotxt, 0, otrotxt.Count(), 0);
            Console.WriteLine("envio : " + nombre);
            byte[] byterecibido = new byte[255];
            int numero = miSocket.Receive(byterecibido,0,byterecibido.Count(),0);
            Array.Resize(ref byterecibido,numero);
            txtrec = Encoding.Default.GetString(byterecibido);
            Console.WriteLine(txtrec);
            miSocket.Close();
            
            
        }
        catch (Exception error)
        {

            Console.WriteLine(error.ToString());

        }
        Console.ReadKey();
    }
}
