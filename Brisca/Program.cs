using System;

namespace Brisca
{
    class Program
    {
        static void Main(string[] args)
        {
            Naipe[] baraja = new Naipe[40];
            Naipe[] manoj1 = new Naipe[3];
            Naipe[] manoj2 = new Naipe[3];
            Naipe[] montonj1 = new Naipe[40];
            Naipe[] montonj2 = new Naipe[40];
            Naipe carta1 = null;
            Naipe carta2 = null;
            Naipe naipej1 = new Naipe("carta null1", 0, "0", 0);
            Naipe naipej2 = new Naipe("carta null2", 0, "0", 0);
            Naipe vida;


            baraja[0] = new Naipe("As de Oros", 10, "Oros", 0);
            baraja[1] = new Naipe("Tres de Oros", 9, "Oros", 1);
            baraja[2] = new Naipe("Dos de Oros", 1, "Oros", 2);
            baraja[3] = new Naipe("Cuatro de Oros", 2, "Oros", 3);
            baraja[4] = new Naipe("Cinco de Oros", 3, "Oros", 4);
            baraja[5] = new Naipe("Seis de Oros", 4, "Oros", 5);
            baraja[6] = new Naipe("Siete de Oros", 5, "Oros", 6);
            baraja[7] = new Naipe("Sota de Oros", 6, "Oros", 7);
            baraja[8] = new Naipe("Caballo de Oros", 7, "Oros", 8);
            baraja[9] = new Naipe("Rey de Oros", 8, "Oros", 9);
            baraja[10] = new Naipe("As de Copas", 10, "Copas", 10);
            baraja[11] = new Naipe("Tres de Copas", 9, "Copas", 11);
            baraja[12] = new Naipe("Dos de Copas", 1, "Copas", 12);
            baraja[13] = new Naipe("Cuatro de Copas", 2, "Copas", 13);
            baraja[14] = new Naipe("Cinco de Copas", 3, "Copas", 14);
            baraja[15] = new Naipe("Seis de Copas", 4, "Copas", 15);
            baraja[16] = new Naipe("Siete de Copas", 5, "Copas", 16);
            baraja[17] = new Naipe("Sota de Copas", 6, "Copas", 17);
            baraja[18] = new Naipe("Caballo de Copas", 7, "Copas", 18);
            baraja[19] = new Naipe("Rey de Copas", 8, "Copas", 19);
            baraja[20] = new Naipe("As de Espadas", 10, "Espadas", 20);
            baraja[21] = new Naipe("Tres de Espadas", 9, "Espadas", 21);
            baraja[22] = new Naipe("Dos de Espadas", 1, "Espadas", 22);
            baraja[23] = new Naipe("Cuatro de Espadas", 2, "Espadas", 23);
            baraja[24] = new Naipe("Cinco de Espadas", 3, "Espadas", 24);
            baraja[25] = new Naipe("Seis de Espadas", 4, "Espadas", 25);
            baraja[26] = new Naipe("Siete de Espadas", 5, "Espadas", 26);
            baraja[27] = new Naipe("Sota de Espadas", 6, "Espadas", 27);
            baraja[28] = new Naipe("Caballo de Espadas", 7, "Espadas", 28);
            baraja[29] = new Naipe("Rey de Espadas", 8, "Espadas", 29);
            baraja[30] = new Naipe("As de Bastos", 10, "Bastos", 30);
            baraja[31] = new Naipe("Tres de Bastos", 9, "Bastos", 31);
            baraja[32] = new Naipe("Dos de Bastos", 1, "Bastos", 32);
            baraja[33] = new Naipe("Cuatro de Bastos", 2, "Bastos", 33);
            baraja[34] = new Naipe("Cinco de Bastos", 3, "Bastos", 34);
            baraja[35] = new Naipe("Seis de Bastos", 4, "Bastos", 35);
            baraja[36] = new Naipe("Siete de Bastos", 5, "Bastos", 36);
            baraja[37] = new Naipe("Sota de Bastos", 6, "Bastos", 37);
            baraja[38] = new Naipe("Caballo de Bastos", 7, "Bastos", 38);
            baraja[39] = new Naipe("Rey de Bastos", 8, "Bastos", 39);
            Jugador jugador1;
            Jugador jugador2;
            Jugador primero;
            Jugador segundo;
            Turno turno;
            //hola jonmataaaaaaaan

            Menu(out jugador1, out jugador2);
                        
            ManoInicial(jugador1, baraja, out manoj1);
            jugador1.Mano = manoj1;

            ManoInicial(jugador2, baraja, out manoj2);
            jugador2.Mano = manoj2;

            SacarVida(baraja, out vida);
            
            DecidirPrimero(jugador1, jugador2, out primero, out segundo);
            

            turno = new Turno(primero, vida, null, null, 0);

            turno.Carta1 = turno.ComenzarTurno(primero);
            turno.Carta2 = turno.ComenzarTurno(segundo);

            ComprobarVictoria(turno.Carta1, turno.Carta2);

            


        }
        public static void Menu(out Jugador j1, out Jugador j2)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("- BRISQUITA WENA -");
            Console.WriteLine("------------------\n");
            Console.Write("Introduzca el nombre del jugador 1: ");
            String jugador = Console.ReadLine();
            jugador = jugador.ToUpper();
            j1 = new Jugador(jugador, 0, null, "rojo");
            Console.Write("Introduzca el nombre del jugador 2: ");
            jugador = Console.ReadLine();
            jugador = jugador.ToUpper();
            j2 = new Jugador(jugador, 1, null, "azul");

            Console.WriteLine("\n¡Está apunto de disputarse la partida entre {0} y {1}!\nPulsa enter para comenzar...", j1.Nombre, j2.Nombre);
            Console.ReadLine();
            Console.Clear();
        }
        public static void ManoInicial(Jugador jugador, Naipe[] baraja, out Naipe[] mano)
        {
            Random rnd = new Random();
            int indicernd;
            Naipe[] manotemp = new Naipe[3];
            for (int i = 0; i < 3; i++)
            {
                indicernd = rnd.Next(0, 39);
                while (baraja[indicernd] == null)
                {
                    indicernd = rnd.Next(0, 39);
                }
                manotemp[i] = baraja[indicernd];
                baraja[indicernd] = null;
            }
            mano = manotemp;

        }
        public static void SacarVida(Naipe[] baraja, out Naipe vida)
        {
            Random rnd = new Random();
            int indicernd;
            Naipe vidatemp;
            indicernd = rnd.Next(0, 39);
            while (baraja[indicernd] == null)
            {
                indicernd = rnd.Next(0, 39);
            }
            vidatemp = baraja[indicernd];
            baraja[indicernd] = null;
            vida = vidatemp;
        }
        public static void DecidirPrimero(Jugador j1, Jugador j2, out Jugador primero, out Jugador segundo)
        {
            if (j1.Turno < j2.Turno)
            {
                primero = j1;
                segundo = j2;
            }
            else
            {
               primero = j2;
               segundo = j1;
            }
        }
    }
}
