using System;
using System.Collections.Generic;
using System.Text;

namespace UwpDemo
{
    public class Equipo
    {
        public Equipo(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; }

        public override string ToString() => Nombre;
    }
}
