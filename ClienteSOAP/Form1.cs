using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSOAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            if(!(TBCedula.Text.Equals("") || TBNombre.Equals("") || TBApellido1.Equals("") || TBApellido2.Equals("") || TBResidencia.Equals("")))
            {
                SOAPReference.Service1Client con = new SOAPReference.Service1Client();

                SOAPReference.Usuario user = new SOAPReference.Usuario();

                user.Cedula =  Int32.Parse(TBCedula.Text);
                user.Nombre = TBNombre.Text;
                user.Apellidop1 = TBApellido1.Text;
                user.Apellido2 = TBApellido2.Text;
                user.Residencia = TBResidencia.Text;
                    
                con.AddUsuario(user);
            }
        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            SOAPReference.Service1Client con = new SOAPReference.Service1Client();

            DGVUsuarios.DataSource = con.GetUsuarios();
        }
    }
}
