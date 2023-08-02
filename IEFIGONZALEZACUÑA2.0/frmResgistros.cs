using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIGONZALEZACUÑA2._0
{
    public partial class frmResgistros : Form
    {

        frmPrincipal objetoMain = new frmPrincipal();
        int indiceFila = 0;
        public frmResgistros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.Show();
        }

        private void frmResgistros_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                MessageBox.Show("Vamos a registrar su producto");

                int n = dtgvRegistro.Rows.Add();

                dtgvRegistro.Rows[n].Cells[0].Value = txtID.Text;
                dtgvRegistro.Rows[n].Cells[1].Value = txtNombredeProducto.Text;
                dtgvRegistro.Rows[n].Cells[2].Value = dtpFecha.Text;

                objetoMain.Listado.matrizProducto[indiceFila, 0] = txtID.Text;
                objetoMain.Listado.matrizProducto[indiceFila, 1] = txtNombredeProducto.Text;
                objetoMain.Listado.matrizProducto[indiceFila, 2] = dtpFecha.Text;

                indiceFila++;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o superior");
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
