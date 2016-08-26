using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            int result = 0;


            string[] gaps = Convert.ToString(N, 2).Trim('0').Split('1');

            result = gaps.Select(a => a.Length).Max();

            return result;
        }
    }
}
