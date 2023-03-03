/*
Crea un sistema de inicio de sesión de usuario, donde el usuario puede primero registrarse y luego iniciar sesión.
El programa debe verificar si el usuario ha ingresado el nombre de usuario y la contraseña correctos al iniciar sesión 
(por lo tanto, los mismos que utilizó al registrarse).

Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.
 */

namespace Desafio4
{
    internal class Program
    {
        static string nombre = "";
        static string contrasena = "" ;
        static void Main(string[] args)
        {
            Registrarse();
            Iniciar_Sesion();
        }
        public static void Registrarse()
        {
            Console.WriteLine("Ingrese nombre de su Usuario: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Contrasena: ");
            contrasena = Console.ReadLine();

        }
        public static void Iniciar_Sesion()
        {

            Console.WriteLine("Login ingrese nombre de su Usuario: ");
            string nombre_usuario = Console.ReadLine();

            Console.WriteLine("Login ingrese su Contrasena: ");
            string contrasena_usuario = Console.ReadLine();

            if (nombre.ToLower().Equals(nombre_usuario))
            {
                if (contrasena.Equals(contrasena_usuario))
                {
                    Console.WriteLine("Bienvenido {0}",nombre_usuario);
                }
                else
                {
                    Console.WriteLine("Contrasena incorrecto");
                }
            }
            else
            {
                Console.WriteLine("El usuario o la contraseña que ingreso son incorrectos, Por favor intente de nuevo");
            }
        }
    }
}