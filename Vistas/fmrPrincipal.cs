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
    public partial class fmrPrincipal : Form
    {
        static String strUser;
        static String strPass;

        public fmrPrincipal(String strUsuario, String strClave)
        {
            strUser = strUsuario;

            strPass = strClave;

            InitializeComponent();
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = strUser;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fmrAdministrar_Personas frmPer = new fmrAdministrar_Personas();
            frmPer.ShowDialog();
        }
    }
}
