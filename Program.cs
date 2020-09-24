using System;

namespace CondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elige medio de transporte(coche, tren, avion)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {

                case "coche":
                    Console.WriteLine("Velocidad media: 100km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 250km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media: 800km/h");
                    break;

                default:
                    Console.WriteLine("Transporte no encontrado");
                    break;

            }
            Console.WriteLine("A terminado el programa");
        }
    }
}
