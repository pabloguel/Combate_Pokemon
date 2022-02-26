using System;

namespace Combate_Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vida_Pikachu = 100;
            int Vida_Squartle = 100;
            int jugador = 0;
            int ataque = 0;
            int danio = 0;
            string jugador1;
            string jugador2;

            Console.WriteLine("Cual es el nombre del primer jugador");
            jugador1 = Console.ReadLine();
            Console.WriteLine("Cual es el nombre del segundo jugador");
            jugador2 = Console.ReadLine();

            Console.Clear();

            do
            {

                if (jugador == 0)
                {
                    Console.WriteLine("Es el turno del jugador " + jugador1 +" a elegido a Pikachu");
                    Console.WriteLine(
                        "Que ataque quieres hacer \n1 Impact Trueno \n 2 Embestida \n 3 Bola Volteo"
                    );
                }
                else
                {
                    Console.WriteLine("Es el turno del jugador" + jugador2 + "a elegido a Squirtle");
                    Console.WriteLine(
                        "Que ataque quieres hacer \n1 Chorro de agua \n 2 Placaje \n 3 Burbuja"
                    );
                }

                ataque = Convert.ToInt32(Console.ReadLine());

                if (jugador == 0)
                {
                    switch (ataque)
                    {
                        case 1:
                            Console.WriteLine("Pikachu a atacado con Impact trueno");
                            danio = 15;
                            break;
                        case 2:
                            Console.WriteLine("Pikachu a atacado con Embestida");
                            danio = 10;
                            break;
                        case 3:
                            Console.WriteLine("Pikachu a atacado con Bola Voleteo");
                            danio = 20;
                            break;
                        default:
                            Console.WriteLine("Pikachu fallo el ataque");
                            danio = 0;
                            break;
                    }
                    Vida_Squartle -= danio;
                    Console.WriteLine("La vida de squartle a disminuido a:" + Vida_Squartle);
                    jugador = 1;
                }
                else
                {
                    switch (ataque)
                    {
                        case 1:
                            Console.WriteLine("Squartle a atacado con Chorro de agua");
                            danio = 15;
                            break;

                        case 2:
                            Console.WriteLine("Squartle a atacado con Placaje");
                            danio = 10;
                            break;

                        case 3:
                            Console.WriteLine("Squartle a atacado con Burbuja");
                            danio = 20;
                            break;

                        default:
                            Console.WriteLine("Squirtle fallo el ataque");
                            danio = 0;
                            break;
                    }
                    Vida_Pikachu -= danio;
                    Console.WriteLine(
                        "La vida de pikachu a disminuido ahora es de : " + Vida_Pikachu);
                    jugador = 0;
                }
            } while (Vida_Pikachu >= 1 && Vida_Squartle >= 1);
        }
    }
}

