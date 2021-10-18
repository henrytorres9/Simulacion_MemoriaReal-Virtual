using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulacion_Procesos
{
    class Particion
    {
        private int tamaño;
        private bool valor;
        private string tarea;

        public Particion() { }

        public Particion(int tamaño, bool valor, string tarea)
        {
            this.tamaño = tamaño;
            this.valor = valor;
            this.tarea = tarea;
        }

        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public bool Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }
    }
}
