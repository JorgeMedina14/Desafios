namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu salario de los ultimos 3 meses");

            Console.WriteLine("Ingrese su sueldo 1");
            int sueldo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sueldo 2");
            int sueldo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sueldo 3");
            int sueldo3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            MostrarDatos(sueldo1, sueldo2, sueldo3, nombre);

        }
        public static void MostrarDatos(int sueldo1, int sueldo2, int sueldo3, string nombre)
        {
           
            int suma = sueldo1 + sueldo2 + sueldo3;

            int promedio = suma / 3;
            Console.WriteLine("hola {0} en total ganaste: {1} y promediaste: {2}", nombre, suma, promedio);
        }
    }
}