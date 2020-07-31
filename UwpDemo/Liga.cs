using System;
using System.Collections.Generic;
using System.Text;

namespace UwpDemo
{
    public class Liga
    {
        public Liga(string nombre)
        {
            Nombre = nombre;
            Divisiones = new DivisionLista();
        }

        public string Nombre { get; }
        public DivisionLista Divisiones { get; }

        public override string ToString() => Nombre;
    }
}
