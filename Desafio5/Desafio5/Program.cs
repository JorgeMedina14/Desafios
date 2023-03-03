/*Crea una aplicación que maneje los puntajes de un juego imaginario. Tendrá un puntaje, un puntaje record y un jugador record.

Crea un método que tenga dos parámetros, uno para el puntaje obtenido y otro para el nombre del jugador.

Cuando se llama a ese método, se debe verificar si el puntaje del jugador es mayor que la puntuación más alta, si es así, 
que se escriba en la consola algo así como"La nueva puntuación más alta es " + puntuación. Y en otra línea "La puntuación más alta 
fue lograda por " + nombre del jugador.

Si no fue así, entonces que se escriba algo como "La puntuación más alta de " + puntuación más alta + " no se ha podido superar,
y aún está en manos de " + jugador record.

Considera qué variables se requieren globalmente y cuáles localmente.*/

namespace Desafio5
{
    internal class Program
    {
        static int puntaje_record = 0;
        static string jugador_record = "";
        static void Main(string[] args)
        {
            puntajes(20, "Ingrid");
            puntajes(40, "Mario");
            puntajes(60, "Pedro");
            puntajes(45, "Dylan");
            puntajes(100, "Jorge");
            puntajes(99, "Lupe");
        }

        public static void puntajes(int puntaje_obtenido, string nombre_jugador)
        {
            if (puntaje_obtenido > puntaje_record)
            {
                puntaje_record = puntaje_obtenido;
                jugador_record = nombre_jugador;

                Console.WriteLine("La nueva puntuacion mas alta es: {0} ", puntaje_record);
                Console.WriteLine("La nueva puntuacion fue obtenida por: {0} ", jugador_record);
            }
            else
            {
                Console.WriteLine("La puntuacion mas alta de: {0}, no se ha podido superarar y " +
                    "aun esta en manos de: {1}",puntaje_record,jugador_record);
            }
        }
    }
}