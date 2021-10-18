using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulacion_Procesos
{
    class Asignacion
    {
        private string tarea;
        private int tamaño;
        private bool estado;

        public Asignacion() { }

        public Asignacion(string tarea, int tamaño, bool estado) 
        {
            this.tarea = tarea;
            this.tamaño = tamaño;
            this.estado = estado;
        }

        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }

        public int Tamaño 
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
