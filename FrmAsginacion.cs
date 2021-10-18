using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulacion_Procesos
{
    public partial class FrmAsginacion : Form
    {
        public static int cantidad;
        public static int rango1;
        public static int rango2;

        public FrmAsginacion()
        {
            InitializeComponent();
            cantidad = 0;
            rango1 = 0;
            rango2 = 0;
        }

        private void FrmAsginacion_Load(object sender, EventArgs e)
        {
            txtTamaño.Select();
            txtRango1.Text = "1000";
            txtRango2.Text = "5000";
        }

        private void txtTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            e.Handled = (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))?true:false;
            if (e.KeyChar == 13)
            {
                if (txtTamaño.Text.Trim().Length > 0)
                {
                    btngenerar.Focus();
                }
                else 
                {
                    error.SetError(txtTamaño, "null");
                }
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtTamaño.Text.Trim());
            rango1 = (txtRango1.Text.Trim().Length>0)?int.Parse(txtRango1.Text.Trim()):1000;
            rango2 = (txtRango2.Text.Trim().Length > 0) ? int.Parse(txtRango2.Text.Trim()) : 9999;
            new frmProyecto().Show();
            this.Hide();
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {
            btngenerar.Enabled = (txtTamaño.Text.Trim().Length > 0) ? true : false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtTamaño.Clear();
                txtTamaño.Focus();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                chkRango.Checked = false;
            }
        }

        private void chkRango_CheckedChanged(object sender, EventArgs e)
        {
            txtRango1.Enabled = false;
            txtRango2.Enabled = false;
            if (chkRango.Checked)
            {
                txtRango1.Enabled = true;
                txtRango2.Enabled = true;
                txtRango2.Focus();
                txtRango1.Focus();
            }
        }

        private void txtRango1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)) ? true : false;
        }

        private void txtRango2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)) ? true : false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMPrincipal nuevaVentana = new frmMPrincipal();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMPrincipal nuevaVentana = new frmMPrincipal();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
