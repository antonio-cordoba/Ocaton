using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2147395600
            // https://codility.com/c/run/RWGZYM-7EK
            Console.WriteLine("Zip : {0}", (new Zip()).solution(100000000, 100000000));
            Console.WriteLine("Whole Square Count : {0}", (new SquareCount()).solution(0, 2147483647));
            Console.WriteLine("gaps: {0}", (new BinaryGap()).solution(20));

            int[] abc = { 1, 2, 3, 5, -2, 11 };
            Console.WriteLine("Equilibrium value = {0}", FindEqu(abc));
            Console.ReadKey();

        }

        static int FindEqu(int[] data)
        {
            int result = -1;

            var calc = data
                .Select((a, i) => new {
                    pos = i,
                    sumpre = data.Take(i).Sum(),
                    sumsuf = data.Skip(i + 1).Sum()
                })
                .Where(c => c.sumpre == c.sumsuf)
                .FirstOrDefault();

            if (calc != null)
                result = calc.pos;

            return result;
        }
    }
}
