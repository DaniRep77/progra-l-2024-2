using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            //determinar si cada numero de la serie es primo.
            int[] serie = new int[] { 5, 9, 4, 6, 3, 2, 7, 11, 15, 17, 21};
            foreach (int num in serie){
                int i = 1,
                    n = 0;
                while (i<=num && n<=2){
                    if (num % i == 0){
                        n++;//n=n+1
                    }
                    i++; //i=i+1
                }
                Console.WriteLine("el numero {0} {1}", num, n <= 2 ? "es primo" : "NO es primo");
            }
            Console.ReadLine();
        }
    }
}
