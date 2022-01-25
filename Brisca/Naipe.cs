using System;
using System.Collections.Generic;
using System.Text;

namespace Brisca
{
    class Naipe
    {
        string nombre;
        int valor;
        string palo;
        int indice;

        public Naipe(string nombre, int valor, string palo, int indice)
        {
            this.Nombre = nombre;
            this.Valor = valor;
            this.Palo = palo;
            this.Indice = indice;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Palo { get => palo; set => palo = value; }
        public int Indice { get => indice; set => indice = value; }
        public void MostrarNaipe()
        {
            Console.WriteLine("{0} {1} {2} {3}", this.Nombre, this.Valor, this.Palo, this.Indice);
        }
    }
}
