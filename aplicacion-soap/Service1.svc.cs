using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace aplicacion_soap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool AddUsuario(Usuario user)
        {
            try
            {
                using (UsuariosEntities udb = new UsuariosEntities())
                {
                    Users oUsers = new Users();
                    oUsers.Cedula = user.Cedula;
                    oUsers.Nombre = user.Nombre;
                    oUsers.Apellido1 = user.Apellidop1;
                    oUsers.Apellido2 = user.Apellido2;
                    oUsers.Residencia = user.Residencia;

                    udb.Users.Add(oUsers);
                    udb.SaveChanges();
                }
            }catch(Exception e)
            {
                return false;
            }

            return true;
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> lUsers = new List<Usuario>();
            try
            {
                using(UsuariosEntities udb = new UsuariosEntities())
                {
                    var dataUser = udb.Users;

                    foreach (var data in dataUser)
                    {
                        lUsers.Add(new Usuario((int)data.Cedula, data.Nombre, data.Apellido1, data.Apellido2, data.Residencia));
                    }
                }                
            }catch(Exception e)
            {
                return null;
            }

            return lUsers;
        }


        public int Sumar(int a, int b)
        {
            return a + b;
        }

    }
}
