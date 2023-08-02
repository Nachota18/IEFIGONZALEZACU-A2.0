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
    public partial class frmListado : Form
    {
        public string[,] matrizProducto = new string[10, 3];
        public string[,] matrizRegistro = new string[10, 4];
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (matrizRegistro[i, 1] != null)
                {
                    if (lstVenta.Items.Contains(matrizRegistro[i, 1]) == false)
                    {
                        lstVenta.Items.Add(matrizRegistro[i, 1]);
                    }
                }
            }
        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (matrizProducto[i, 1] != null)
                {
                    dtgvListado.Rows.Add(matrizProducto[i, 0], matrizProducto[i, 1], matrizProducto[i, 2]);
                }

            }
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (rdbProducto.Checked == true)
            {
                for (int i = 0; i < matrizProducto.GetLength(0); i++)
                {
                    if (matrizProducto[i, 1] != null)
                    {
                        dtgvListado.Rows.Add(matrizProducto[i, 0], matrizProducto[i, 1], matrizProducto[i, 2]);
                    }
                }
            }
            else
            {

                for (int i = 0; i < matrizRegistro.GetLength(0); i++)
                {
                    if (lstVenta.Text == matrizRegistro[i, 1])
                    {
                        dtgvListado.Rows.Add(matrizRegistro[i, 0], matrizRegistro[i, 1], matrizRegistro[i, 2]);
                    }
                }
            }
        }

        private void rdbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked)
            {
                lstVenta.Enabled = true;
            }
        }
    }
}
