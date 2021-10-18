using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_Procesos
{
    public partial class frmMPrincipal : Form
    {
        public frmMPrincipal()
        {
            InitializeComponent();
        }

        private void panelSimulacionProcesos_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void lblSimulacionProcesos_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEstadisticasMemorias_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void panelEstadisticasMemorias_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBoxEstadisticas_Click(object sender, EventArgs e)
        {
            Form1 nuevaVentana = new Form1();
            nuevaVentana.Show();
            this.Hide();
        }

        private void lblSimulacionProcesos_Click_1(object sender, EventArgs e)
        {
            FrmAsginacion nuevaVentana = new FrmAsginacion();
            nuevaVentana.Show();
            this.Hide();
        }

        private void panelSimulacionProcesos_Click_1(object sender, EventArgs e)
        {
            FrmAsginacion nuevaVentana = new FrmAsginacion();
            nuevaVentana.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAsginacion nuevaVentana = new FrmAsginacion();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
