using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double formulaI;
            double formulaII;
            double F;

            Console.WriteLine("valor de F");
            F = double.Parse(Console.ReadLine());

            formulaI = F - 32;
            Console.WriteLine("valor da formulaI {0}", formulaI);
            formulaII = formulaI * 5 / 9;
            Console.WriteLine("valor da convesão de celsius para Fahrenheit {0}", formulaII);
        }
    }
}
