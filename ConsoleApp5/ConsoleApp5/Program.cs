namespace ConsoleApp5
{
    class JuegoPuntajes
    {
        static int recordPuntaje = 0;
        static string recordJugador = "Ninguno";

        static void VerificarPuntaje(int nuevoPuntaje, string jugador)
        {
            Console.WriteLine($"\nJugador: {jugador} obtuvo {nuevoPuntaje} puntos.");

            if (nuevoPuntaje > recordPuntaje)
            {
                recordPuntaje = nuevoPuntaje;
                recordJugador = jugador;

                Console.WriteLine($"¡Nueva puntuación más alta! La nueva puntuación más alta es {recordPuntaje}.");
                Console.WriteLine($"La puntuación más alta fue lograda por {recordJugador}.");
            }
            else
            {
                Console.WriteLine($"La puntuación más alta de {recordPuntaje} no se ha podido superar.");
                Console.WriteLine($"Aún está en manos de {recordJugador}.");
            }
        }
        static void Main()
        {
            VerificarPuntaje(50, "Juan");

            VerificarPuntaje(80, "Maria");

            VerificarPuntaje(60, "Manolo");
        }
    }

}
