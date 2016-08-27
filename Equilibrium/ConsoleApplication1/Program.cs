using System.Linq;
using System.Text.RegularExpressions;

using static System.Linq.Enumerable;
using static System.Console;
using static System.Text.RegularExpressions.Regex;

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

            WriteLine($"Equilibrium value = {FindEqu(abc)}");

            string s = @"AAAAAAAAAABBBBBBBCCCCCCCCCCAAAAAAABBBBBBBBHHHHHHHHDDDDDDDDDDD";

            WriteLine($"TestChain = {s}");
            WriteLine($"FrequencyChainRegex = {FindChain(s)}" );
            WriteLine($"FrequencyChainLinq  = {FindChain2(s)}");

            ReadKey();
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

        static string FindChain(string input)
        {
            return 
                Matches(input, @"(.)\1*")
                .Cast<Match>()
                .Select(a => string.Concat(a.Value[0], a.Value.Length))
                .JoinString();
        }

        static string FindChain2(string input)
        {
            return 
                Range(0, input.Length - 1)
                .Where(i => (i == 0 || input[i] != input[i - 1]))
                .Select(i => new { tk = input.ToCharArray().Skip(i).TakeWhile(c => c == input[i]) })
                .Select(a => string.Concat(a.tk.First(), a.tk.Count()))
                .JoinString();
        }

        static string UsingConsummer ()
        {
            return 
                Disposable.Using(
                    () => new Greedy(),
                    g => g.GetDescription()
                );
        }
    }
}


        
        //string sample = s;

        //var x =
        //    Repeat(new { c = sample[0], p = 0 }, 1)
        //    .Concat(
        //        Range(0, sample.Length - 1)
        //        .Select(i => new { c = sample[i], p = i })
        //        .Where(e => (e.p > 0 && sample[e.p] != sample[e.p - 1]))
        //    )
        //    .Concat(
        //        Repeat(new { c = '-', p = sample.Length }, 1)
        //    );


