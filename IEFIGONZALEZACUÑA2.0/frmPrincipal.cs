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
    public partial class frmPrincipal : Form
    {
        public frmListado Listado = new frmListado();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            Form Ventas = new frmVentas();
            Ventas.Show();
        }

        private void cmdRegistro_Click(object sender, EventArgs e)
        {
            Form Productos = new frmResgistros();
            Productos.Show();
        }
    }
}
