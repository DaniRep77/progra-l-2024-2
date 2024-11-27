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
            // Uso de funciones...
            // Ejercicio: Encontrar la media aritmética, desviación típica y media armónica de una serie de números.
            Console.Write("Ingrese la serie de números separados por comas: ");
            string input = Console.ReadLine();
            string[] numeros = input.Split(',');

            // Calculamos los valores necesarios.
            double mediaAritmetica = Media(numeros);
            double desviacionTipica = Tipica(numeros);
            double mediaArmonica = Armonica(numeros);

            // Mostramos los resultados.
            Console.WriteLine("La media aritmética es: {0}, y la desviación típica es: {1}", mediaAritmetica, desviacionTipica);
            Console.WriteLine("La media aritmética es: {0}, la desviación típica es: {1}, y la media armónica es: {2}",
                mediaAritmetica, desviacionTipica, mediaArmonica);

            Console.ReadLine();
        }

        static double Media(string[] serie)
        {
            double suma = 0;
            foreach (string num in serie)
            {
                suma += double.Parse(num);
            }
            return suma / serie.Length;
        }

        static double Tipica(string[] serie)
        {
            double media = Media(serie);
            double sumaCuadrados = 0;
            foreach (string num in serie)
            {
                double valor = double.Parse(num);
                sumaCuadrados += Math.Pow(valor - media, 2);
            }
            return Math.Round(Math.Sqrt(sumaCuadrados / serie.Length), 2);
        }

        static double Armonica(string[] serie)
        {
            double sumaInversa = 0;
            foreach (string num in serie)
            {
                sumaInversa += 1.0 / double.Parse(num);
            }
            return Math.Round(serie.Length / sumaInversa, 2);
        }
    }
}
