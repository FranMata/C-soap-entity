using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace aplicacion_soap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Usuario> GetUsuarios();

        [OperationContract]
        bool AddUsuario(Usuario user);

        [OperationContract]
        int Sumar(int a, int b);

        // TODO: agregue aquí sus operaciones de servicio
    }


    //clases
    [DataContract]
    public class Usuario
    {
        int cedula;
        string nombre;
        string apellidop1;
        string apellido2;
        string residencia;

        public Usuario(int cedula,string nombre, string apellidop1, string apellido2, string residencia){
            Cedula = cedula;
            Nombre = nombre;
            Apellidop1 = apellidop1;
            Apellido2 = apellido2;
            Residencia = residencia;
        }        

        [DataMember]
        public int Cedula { get => cedula; set => cedula = value; }
        [DataMember]
        public string Nombre { get => nombre; set => nombre = value; }
        [DataMember]
        public string Apellidop1 { get => apellidop1; set => apellidop1 = value; }
        [DataMember]
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        [DataMember]
        public string Residencia { get => residencia; set => residencia = value; }
    }
}
