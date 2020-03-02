using System;

namespace AppSentenciaIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            float nota1, nota2, nota3,suma, promedio ;
            Console.WriteLine("Programa tres notas");
            Console.WriteLine("Escriba Nota 1:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba Nota 2:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba Nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio >= 3 && promedio<=4)
            {
                Console.WriteLine("ES PROMOCIONADO =)");
            }
            else if(promedio>=4)
            {
                Console.WriteLine("ES EXCELENTE!!!");
            }
            else
            {
                Console.WriteLine("NO ES PROMOCIONADO =(");
            }
            Console.ReadKey();

        }
    }
}
