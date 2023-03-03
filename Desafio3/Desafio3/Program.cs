namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertiraEntero();
        }
        public static void ConvertiraEntero()
        {
            
            try
            {
                Console.WriteLine("Ingrese 2 numeros");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int total = n1 + n2;

                Console.WriteLine("El resultado es {0}", total);
            }catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error");
            }
            finally
            {
                Console.WriteLine("Programa finalizado");
            }
        }
    }
}