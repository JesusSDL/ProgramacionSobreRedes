using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Servidor
{
    static void Main(string[] args) { 
    Socket miSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    IPEndPoint miDir = new IPEndPoint(IPAddress.Any, 1234);

     try{
         miSocket.Bind(miDir);
            miSocket.Listen(1);
            Console.WriteLine("Escuchando...");
            Socket escuchar = miSocket.Accept();
            Console.WriteLine("Conecta2");
            Byte[] byRecv = new byte[255];
            int enteroRecibido = escuchar.Receive(byRecv, 0, byRecv.Count(), 0);
            Array.Resize(ref byRecv, enteroRecibido);
            String elMensaje = Encoding.Default.GetString(byRecv);
            Console.WriteLine(elMensaje);
            String texto = "nombre?";
            Byte[] txtAEnviar = Encoding.Default.GetBytes(texto);
            miSocket.Send(txtAEnviar, 0, txtAEnviar.Count(), 0);
            Console.WriteLine(texto);
            Byte[] byteRecv = new byte[255];
            enteroRecibido = escuchar.Receive(byteRecv, 0, byteRecv.Count(), 0);
            Array.Resize(ref  byteRecv, enteroRecibido);
            elMensaje = Encoding.Default.GetString((byte[])byteRecv);
            Console.WriteLine(elMensaje);
            String nuevoMensaje = "Hola " + elMensaje;
            Byte[] byRepartir = Encoding.Default.GetBytes(nuevoMensaje);
            miSocket.Send(byRepartir, 0, byRepartir.Count(), 0);
            Console.WriteLine(nuevoMensaje);
            miSocket.Close();
        }
        catch(Exception error){

        Console.WriteLine(error.ToString());

        }
        Console.ReadKey();
    }
}
