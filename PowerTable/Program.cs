using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Number num = new Number(50);

            var powers = num.GetPowers();
            int x = powers.GetLength(0);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(powers[i, j]);
                }
            }

        }
    }
}
