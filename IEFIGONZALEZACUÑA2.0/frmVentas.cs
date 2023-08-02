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
    public partial class frmVentas : Form
    {
        frmPrincipal objetoMain = new frmPrincipal();
        int Fila = 0;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                MessageBox.Show("Vamos a registrar su producto");

                int n = dtgvCargarVentas.Rows.Add();

                dtgvCargarVentas.Rows[n].Cells[0].Value = txtID.Text;
                dtgvCargarVentas.Rows[n].Cells[1].Value = txtCantidad.Text;
                dtgvCargarVentas.Rows[n].Cells[2].Value = txtProducto.Text;
                dtgvCargarVentas.Rows[n].Cells[3].Value = dtpFecha.Text;

                objetoMain.Listado.matrizRegistro[Fila, 0] = txtID.Text;
                objetoMain.Listado.matrizRegistro[Fila, 1] = txtCantidad.Text;
                objetoMain.Listado.matrizRegistro[Fila, 2] = txtProducto.Text;
                objetoMain.Listado.matrizRegistro[Fila, 3] = dtpFecha.Text;

                Fila++;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual o superior")
; dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           objetoMain.Listado.Show();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
