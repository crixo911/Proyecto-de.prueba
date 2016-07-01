using System;
using System.Windows.Forms;
using Modelo;

namespace Vistas
{

    public partial class fmrAdministrar_Personas : Form
    {
       public static mPersona mPer;
        int intIndice = 0;
        public static mPersona objPe;
        public static  String strCadena ="";

        public fmrAdministrar_Personas()
        {
            InitializeComponent();
        }

        private void fmrAdministrar_Personas_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int intContador;

            intContador = dgvDatos.Rows.Count;
            timer1.Enabled = true;

            fmrIngresarPersona frmPer = new fmrIngresarPersona(intContador);
            frmPer.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String[] datos = new String[5];
            if (strCadena != "")
            {
                if (strCadena == "modificar") {
                    dgvDatos.Rows[intIndice].Cells[0].Value =objPe.getCodigo().ToString();
                    dgvDatos.Rows[intIndice].Cells[1].Value = objPe.getNombres();
                    dgvDatos.Rows[intIndice].Cells[2].Value = objPe.getApellidos();
                    dgvDatos.Rows[intIndice].Cells[3].Value = objPe.getCedula();
                    dgvDatos.Rows[intIndice].Cells[4].Value = objPe.getSexo();

                    timer1.Enabled = false;
                    strCadena = "";
                }
                else { 
                timer1.Enabled = false;

               // String[] datos = new String[5];

                datos[0] = objPe.getCodigo().ToString();
                datos[1] = objPe.getNombres();
                datos[2] = objPe.getApellidos();
                datos[3] = objPe.getCedula();
                datos[4] = objPe.getSexo();

                dgvDatos.Rows.Add(datos);

                strCadena = "";
            }
        }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void dgvDatos_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    mPer.setCodigo(Convert.ToInt16(dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    mPer.setNombres(dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString());
                    mPer.setApellidos(dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    mPer.setCedula(dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString());
                    mPer.setSexo(dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString());

                    intIndice = e.RowIndex;
                }

                else
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar fmrMod = new frmModificar(objPe);
            fmrMod.ShowDialog();
            timer1.Enabled = true;
        }
    }
}
