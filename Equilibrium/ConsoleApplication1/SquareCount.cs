using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SquareCount
    {
        public int solution(int A, int B)
        {
            int result = 0;

            // A < B is assumed but guard against it anyway
            if (A > B)
                return result;

            // Find lo and hi limits on range 
            // (0 if negative as negatives can not be whole squares)
            int lo = (A < 0 ? 0 : A);
            int hi = (B < 0 ? 0 : B);

            // Find the lowest and highest square roots within the range
            double loSqrt = Math.Ceiling(Math.Sqrt(lo));
            double hiSqrt = Math.Floor(Math.Sqrt(hi));

            // Calculate how many whole square roots are between above values
            result = (int)(hiSqrt - loSqrt + 1);

            return result;
        }
    }
}
