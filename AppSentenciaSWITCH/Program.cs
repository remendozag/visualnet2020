using System;

namespace AppSentenciaSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("PROGRAMA SENTENCIA SWITCH");
            Console.WriteLine("Escriba numero en castellano:");
            numero = Console.ReadLine();
            switch (numero.ToUpper()) 
            {
                case "UNO":
                    Console.WriteLine("1");
                    break;
                case "DOS":
                    Console.WriteLine("2");
                    break;
                case "TRES":
                    Console.WriteLine("3");
                    break;
                case "CUATRO":
                    Console.WriteLine("4");
                    break;
                case "CINCO":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("NO SEA BRUTO SOLO NUMEROS!!!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
