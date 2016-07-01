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
    public partial class fmrIngresarPersona : Form
    {
        int intContador;

        public fmrIngresarPersona(int intCont)
        {
            InitializeComponent();

            intContador = intCont;
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

            if (rbtnMasculino.Checked == true)
            {
                objPer.setSexo("Masculino");
            }
            else
            {
                objPer.setSexo("Femenino");
            }

            intContador = intContador + 1;

            objPer.setCodigo(intContador);

            fmrAdministrar_Personas.objPe = objPer;
            fmrAdministrar_Personas.strCadena = "DSDS";

            this.Hide();
            this.Dispose();
        }

        private void fmrIngresarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void lblCedula_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void gbxTipo_Enter(object sender, EventArgs e)
        {

        }
    }
}
