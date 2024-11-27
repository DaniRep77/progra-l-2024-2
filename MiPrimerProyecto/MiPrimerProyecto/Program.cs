using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primera serie definida
            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("La media aritmética es: {0}, y la desviación típica es: {1}",
                Media(serie), DesviacionTipica(serie));

            // Serie ingresada por el usuario
            Console.Write("Ingrese la serie de números separados por comas: ");
            string input = Console.ReadLine();
            string[] numeros = input.Split(',');

            // Convertimos los números ingresados a un arreglo de enteros
            int[] serieUsuario = Array.ConvertAll(numeros, int.Parse);

            Console.WriteLine("La media aritmética es: {0}, y la desviación típica es: {1}",
                Media(serieUsuario), DesviacionTipica(serieUsuario));

            Console.ReadLine();
        }

        static double Media(int[] serie)
        {
            double suma = 0;
            foreach (int num in serie)
            {
                suma += num;
            }
            return suma / serie.Length;
        }

        static double DesviacionTipica(int[] serie)
        {
            double m = Media(serie);
            double sumaCuadrados = 0;
            foreach (int num in serie)
            {
                sumaCuadrados += Math.Pow(num - m, 2);
            }
            double desviacion = Math.Sqrt(sumaCuadrados / serie.Length);
            return Math.Round(desviacion, 2);
        }
    }
}

