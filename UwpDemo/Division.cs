using System;
using System.Collections.Generic;
using System.Text;

namespace UwpDemo
{
    public class Division
    {
        public Division(string nombre)
        {
            Nombre = nombre;
            Equipos = new EquipoLista();
        }

        public string Nombre { get; }
        public EquipoLista Equipos { get; }

        public override string ToString() => Nombre;
    }
}
