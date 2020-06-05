using System;

namespace consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola mundo!");

            Program.ImprimirFecha();

            ////Para que se quede abierta la consola (En Windows)
            //Console.ReadKey();
        }

        private static void ImprimirFecha()
        {
            var fecha = new DateTime(2020,05,23);

            Console.WriteLine(fecha.ToString("yy-dd-MMMM"));
        }
    }
}
