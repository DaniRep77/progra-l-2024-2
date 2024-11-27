using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace miPrimerProyecto
{
    internal class Conversores
    {
        double[][] valores = new double[][] {
            new double[] {},//vacio solo para comenzar en 1
            new double[] {0,1,7.73,24.76,36.80, 517.04,8.75,0.9},//monedas
            new double[] {0,1,100,39.37,3.28084,1.196308,1.09361,0.001},//longitud
            new double[] {0,1,453.592,16,0.453592, 0.000446429}, //masa
            new double[] {0,1,86400, 1440, 24, 0.142857, 0.032876643423, 0.0027397232876831892345}//tiempo
        };
        public String[][] etiquetas = new String[][]{
            new String[] {},//vacio solo para comenzar en 1
            new string[] {"", "Dolar","Quetzal","Lempira","Cordoba","Colon CR","Colon SV", "Euro"},//monedas
            new string[] {"", "Metro","Cm","Pulgada","Pie","Vara","Yarda","Km"},//longitud
            new string[] {"", "Libra","Gramo","Onza","Kilogramo","Tonelada Larga"},//Masa
            new string[] {"", "Dia","Sg","Min","Horas","Semana","Mes","Año"}
        };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
