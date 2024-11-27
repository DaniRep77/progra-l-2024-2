using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de funciones...
            Console.WriteLine("La suma de 10+5={0}", suma());
            // Ejercicio: encontrar la media aritmética y la desviación típica de una serie de números.

            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, suma(num1, num2));

            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("La media aritmética es: {0}, y la desviación típica es: {1}",
                media(serie), tipica(serie));

            Console.ReadLine();
        }

        // Función para sumar números fijos
        static int suma()
        {
            return 10 + 5;
        }

        // Función para sumar dos números dados
        static int suma(int a, int b)
        {
            return a + b;
        }

        // Función para calcular la media aritmética de una serie
        static double media(int[] serie)
        {
            double suma = 0;
            foreach (int num in serie)
            {
                suma += num;
            }
            return suma / serie.Length;
        }

        // Función para calcular la desviación típica de una serie
        static double tipica(int[] serie)
        {
            double m = media(serie);
            double suma = 0;

            foreach (int num in serie)
            {
                suma += Math.Pow(num - m, 2);
            }

            return Math.Round(Math.Sqrt(suma / serie.Length), 2);
        }
    }
}





