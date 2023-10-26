using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquizofrenia
{
    public class Cliente
    {
        public string nombreApellido; 
        public int dni {  get; set; }

        public string user { get; set; }
        public string password { get; set; }
        public string correoElectronico { get; set; }
        public int idUser { get; set; }

        public Cliente(string nombreApellido, int dni, string user, string password, string correoElectronico, int idUser)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.user = user;
            this.password = password;
            this.correoElectronico = correoElectronico;
            this.idUser = idUser;


        }
        public Cliente(string nombreApellido, int dni, string correoElectronico, int idUser)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.correoElectronico = correoElectronico;
            this.idUser = idUser;


        }
        public void modificarEstadoMesa()
        {

        }
        public void agregarPedido()
        {

        }
    }
}
