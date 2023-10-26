using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esquizofrenia;

namespace Esquizofrenia
{
    internal class ClienteDAO
    {
        public MySqlConnection conectarse()
        {
            string sv = "localhost";
            string bd = "monitoreoMesas";
            string user = "admin";
            string pwd = "Administrador.";
            string cadenaConexion = ($" Database = {bd}; DataSource = {sv}; User Id = {user}; Password = {pwd}");
            MySqlConnection c = new MySqlConnection(cadenaConexion);
            try
            { 
                c.Open();
                
            }
            catch (MySqlException error)
            {
                Console.WriteLine(error.ToString());
                return null;
            }
            return c;
        }
        
        public void prueba()
        {
            string nombre = "jesusDL";
            int dni = 46647703;
            string correo = "jesusdilorenzo335@gmail.com";
            Cliente cliente = new Cliente(nombre, dni, correo, 2);
            agregarCliente(cliente);
            
        }
        public void agregarCliente(Cliente cliente)
        {
            string insert = "INSERT INTO cliente (nombre_apellido, dni, correo, USER_id_user) VALUES (@nomApe, @dni, @correo, @idUser);";
            MySqlCommand command = new MySqlCommand(insert, conectarse());
            command.Parameters.Add(new MySqlParameter("@nombre", cliente.nombreApellido));
            command.Parameters.Add(new MySqlParameter("@dni", cliente.dni));
            command.Parameters.Add(new MySqlParameter("@correo", cliente.correoElectronico));
            command.Parameters.Add(new MySqlParameter("@idUser", cliente.idUser));
            command.ExecuteNonQuery();
        }
        public bool logIn(Cliente cli)
        {
            string existeCliente = "SELECT user, password FROM user WHERE user = @user and password = @pwd;";
            MySqlCommand comando = new MySqlCommand(existeCliente, conectarse());
            comando.Parameters.Add(new MySqlParameter("@user", cli.user));
            comando.Parameters.Add(new MySqlParameter("@pwd", cli.password));
            return comando.ExecuteNonQuery() == 1;
        
        }


    }
    
}
