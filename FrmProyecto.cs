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
    public partial class frmProyecto : Form
    {
        private List<Asignacion> lstTareas;
        private List<Particion> Particiones;
        private int index;
        private int tamañofijo;
        private int indexDeseleccion;

        public frmProyecto()
        {
            InitializeComponent();
            lstTareas = new List<Asignacion>();
            Particiones = new List<Particion>();
            setListarParticiones();
            index = 0;
            tamañofijo = 0;
            indexDeseleccion = -1;
        }

        private void setAddParticiones()
        {
            Random r = new Random();
            for (int i = 0; i < FrmAsginacion.cantidad; i++)
            {
                Particiones.Add(new Particion(r.Next(FrmAsginacion.rango1, FrmAsginacion.rango2), true, ""));
            }
        }

        private void AsignarTareaSuspendida()
        {
            for (int i = 0; i < lstTareas.Count; i++) 
            {
                if (lstTareas[i].Tamaño <= tamañofijo & lstTareas[i].Estado == false)
                {
                    string tarea = lstTareas[i].Tarea;
                    int tamaño = lstTareas[i].Tamaño;
                    setAsignarParticion(tamañofijo, tarea);
                    lstTareas.RemoveAt(i);
                    indexDeseleccion = i;
                    lstTareas.Insert(i, new Asignacion(tarea, tamaño, true));
                    setListarTareas();
                    break;
                }
            }
        }

        private void liberarParticion()
        {
            Particiones.RemoveAt(index);
            Particiones.Insert(index,new Particion(tamañofijo,true,""));
            setListarParticionesAsignadas();
            dgvTareas.ClearSelection();
        }

        private bool tamanoLibre(int tamaño) 
        {
            for (int i = 0; i < Particiones.Count; i++)
            {
                if (tamaño <= Particiones[i].Tamaño & 
                    Particiones[i].Valor==true) 
                {
                    return true;
                }
            }
            return false;
        }

        private void setListarParticionesAsignadas()
        {
            dgvTareas.Rows.Clear();
            for (int i = 0; i < Particiones.Count; i++)
            {
                if (Particiones[i].Valor == false)
                {
                    dgvTareas.Rows.Add(i + 1, Particiones[i].Tarea, Particiones[i].Tamaño);
                }
                else 
                {
                    dgvTareas.Rows.Add(i + 1, "",0);
                }
            }
            dgvTareas.ClearSelection();
        }

        private void setAsignarParticion(int longitud, string tarea)
        {
            for (int i = 0; i < Particiones.Count; i++)
            {
                if (longitud <=Particiones[i].Tamaño &
                    Particiones[i].Valor==true)
                {
                    int tamaño = Particiones[i].Tamaño;
                    Particiones.RemoveAt(i);
                    Particiones.Insert(i,new Particion(tamaño,false,tarea));
                    break;
                }
            }
            setListarParticionesAsignadas();
        }

        private void setListarTareas()
        {
            dgvIngreso.Rows.Clear();
            for (int i = 0; i < lstTareas.Count; i++)
            {
                dgvIngreso.Rows.Add((i + 1), lstTareas[i].Tarea, lstTareas[i].Tamaño);
                if (lstTareas[i].Estado == true)
                {
                    dgvIngreso.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else 
                {
                    dgvIngreso.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            indexDeseleccion = -1;
            dgvIngreso.ClearSelection();
        }

        private void setListarParticiones()
        {
            setAddParticiones();
            dgvParticion.Rows.Clear();
            for (int i = 0; i < Particiones.Count; i++)
            {
                dgvParticion.Rows.Add(i + 1, Particiones[i].Tamaño);
            }
            dgvParticion.ClearSelection();
        }

        private void setIngresarTareas()
        {
            bool valor = tamanoLibre(int.Parse(txtTamaño.Text.Trim()));
            lstTareas.Add(
                new Asignacion(txtTarea.Text.Trim(),int.Parse(txtTamaño.Text.Trim()),valor)
                );
            setListarTareas();    
        }

        private void FrmProyecto_Load(object sender, EventArgs e)
        {
            txtTarea.Select();
            dgvParticion.ClearSelection(); 
        }

        private void txtTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (e.KeyChar == 13) 
            {
                if (txtTarea.Text.Trim().Length > 0)
                {
                    txtTamaño.Focus(); 
                }
                else
                {
                    error.SetError(txtTarea, "null");
                }
            }
        }

        private void txtTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (e.KeyChar == 13)
            {
                if (txtTarea.Text.Trim().Length > 0 & txtTamaño.Text.Trim().Length > 0)
                {
                    setIngresarTareas();
                    setAsignarParticion(int.Parse(txtTamaño.Text.Trim()), txtTarea.Text.Trim());
                    txtTamaño.Clear(); txtTarea.Clear(); txtTarea.Focus();
                }
                else
                {
                    error.SetError(txtTamaño, "null");
                }
            } 
        }

        private void dgvTareas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTareas.Rows.Count > 0)
            {
                DataGridViewRow dgtabla = this.dgvTareas.CurrentRow;
                index = dgtabla.Index;
                tamañofijo = int.Parse(dgtabla.Cells[2].Value.ToString());
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            liberarParticion();
            AsignarTareaSuspendida();
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
