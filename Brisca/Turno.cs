using System;
using System.Collections.Generic;
using System.Text;

namespace Brisca
{
    class Turno
    {
        Jugador jugador;
        Naipe vida;
        Naipe carta1;
        Naipe carta2;
        int contador;




        public Turno(Jugador jugador, Naipe vida, Naipe carta1, Naipe carta2, int contador)
        {
            this.Jugador = jugador;
            this.Vida = vida;
            this.Carta1 = carta1;
            this.Carta2 = carta2;
            this.Contador = contador;
            
        }

        public int Contador { get => contador; set => contador = value; }
        internal Jugador Jugador { get => jugador; set => jugador = value; }
        internal Naipe Vida { get => vida; set => vida = value; }
        internal Naipe Carta1 { get => carta1; set => carta1 = value; }
        internal Naipe Carta2 { get => carta2; set => carta2 = value; }


        public Naipe ComenzarTurno(Jugador jugador)
        {
            switch (jugador.Color)
            {
                case "rojo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TURNO DE {0}\n", jugador.Nombre);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("TURNO DE {0}\n", jugador.Nombre);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VIDA: {0}\n", this.Vida.Nombre);
            Console.ForegroundColor = ConsoleColor.Gray;

            if (this.Carta1 == null)
            {
                Console.WriteLine("Carta sobre la mesa: (ninguna)\n");                
            }
            else
            {
                Console.WriteLine("Carta sobre la mesa: {0}\n", this.Carta1.Nombre);
            }

            Console.WriteLine("Mano actual: \n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}.- {1}", i + 1, jugador.Mano[i].Nombre);
            }
        eleccioncarta:
            Console.Write("\nElije una carta para soltar: ");
            string eleccion = Console.ReadLine();
            int eleccionint;
            try
            {
                eleccionint = int.Parse(eleccion) - 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                goto eleccioncarta;
            }
            if (eleccionint < 0 || eleccionint > 3)
            {
                Console.WriteLine("Elije entre 1 y 3, por favor.");
                goto eleccioncarta;
            }
            Console.WriteLine("Has echado la carta {0}.\n", jugador.Mano[eleccionint].Nombre);

            return jugador.Mano[eleccionint];
        }
        public void ComprobarVictoria()
        {
            Console.WriteLine("carta1: {0}\ncarta2: {1}", this.Carta1.Nombre, this.Carta2.Nombre);
        }
    }

}
