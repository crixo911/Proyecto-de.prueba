using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vistas
{
    public partial class frmModificar : Form
    {
        mPersona objPerso = new mPersona();

        public frmModificar(mPersona objPer)
        {
            InitializeComponent();

            objPerso = objPer;
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = objPerso.getCodigo().ToString();
            txtNombres.Text = objPerso.getNombres();
            txtApellidos.Text = objPerso.getApellidos();
            txtCedula.Text = objPerso.getCedula();

            if (objPerso.getSexo() == "Masculino")
            {
                rbtnMasculino.Checked = true;
            }
            else
            {
                rbtnFemenino.Checked = true;
            }
        
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text != "")
            {
                txtNombres.Enabled = true;
            }
            else
            {
                txtNombres.Enabled = false;
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
            {
                txtApellidos.Enabled = true;
            }
            else
            {
                txtApellidos.Enabled = false;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidos.Text != "")
            {
                gbxTipo.Enabled = true;
            }
            else
            {
                gbxTipo.Enabled = false;
            }
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMasculino.Checked == true)
            {
                btnIngresar.Enabled = true;
            }
        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemenino.Checked == true)
            {
                btnIngresar.Enabled = true;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            mPersona objPer = new mPersona();

            objPer.setCedula(txtCedula.Text);
            objPer.setNombres(txtNombres.Text);
            objPer.setApellidos(txtApellidos.Text);
            objPer.setCodigo(Convert.ToInt16(txtCodigo.Text));

            if (rbtnMasculino.Checked == true)
            {
                objPer.setSexo("Masculino");
            }
            else
            {
                objPer.setSexo("Femenino");
            }
            fmrAdministrar_Personas.objPe = objPerso;
            fmrAdministrar_Personas.strCadena = "modificar";
            this.Hide();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
