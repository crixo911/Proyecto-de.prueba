using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form1 : Form
    {
        String strUsuario ="crixo";
        String strClave = "12345";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String strUser;
            String strPass;

            strUser = txtUsuario.Text;
            strPass = txtClave.Text;

            if ((strUser == strUsuario) && (strClave == strPass))
            {
                fmrPrincipal objPrin = new fmrPrincipal(strUser, strPass);
                objPrin.Show();

                
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no existe", 
                "Mensaje del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Text = "";
                txtClave.Text = "";

                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
