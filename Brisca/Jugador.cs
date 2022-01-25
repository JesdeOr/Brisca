using System;
using System.Collections.Generic;
using System.Text;

namespace Brisca
{
    class Jugador
    {
        string nombre;
        int turno;
        Naipe[] mano;
        string color;

        public Jugador(string nombre, int turno, Naipe[] mano, string color)
        {
            this.Nombre = nombre;
            this.Turno = turno;
            this.Mano = mano;
            this.Color = color;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Turno { get => turno; set => turno = value; }
        public string Color { get => color; set => color = value; }
        internal Naipe[] Mano { get => mano; set => mano = value; }
    }
}