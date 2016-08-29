using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApplication1
{
    public class Zip
    {
        public int solution(int A, int B)
        {
            int result = -1;

            //guard against invalid inputs
            if (
                A < 0 || 
                B < 0 ||
                A > 100000000 ||
                B > 100000000
                )
                return result;

            // Convert A to List of characters
            List<char> lA = A.ToString().ToCharArray().ToList(); 

            // Convert B to string
            string sB = B.ToString();

            // Loop through characters in "B" string and insert them in "A" list
            for (int counter = 0; counter < sB.Length; counter++)
            {
                // Calculate where to insert next character
                int pos = (counter + 1) * 2 - 1;

                // If calculated position is greater than list length, insert at the end
                // (B has more digits than A)
                if (pos > lA.Count)
                    pos = lA.Count;

                // Insert character into list
                lA.Insert(pos, sB[counter]);
            }

            // Convert list of characters to string and parse it as long
            long assembled = long.Parse(new String(lA.ToArray()));

            // Test if the resulting value fits within requested data type
            if (assembled > int.MaxValue)
                throw new OverflowException("Resulting value won't fit in specified (int) data type.");

            // cast into result
            result = (int)assembled;

            return result;
        }

        public int solution2(int A, int B)
        {

            //guard against invalid inputs
            if (
                A < 0 ||
                B < 0 ||
                A > 100000000 ||
                B > 100000000
                )
                return -1;

            // Find max length of digits between A and B
            // (can also be done using Math.log10)
            int maxlen = Max(A, B).ToString().Length;

            // Convert numbers to char arrays (padded to max length)
            // Zip them
            // Flatten the results 
            // remove the padding
            // and join elements + convert result to integer
            return
                A.ToPaddedCharArray(maxlen, '~')
                .Zip(
                    B.ToPaddedCharArray(maxlen, '~'),
                    (a, b) => new char[] { a, b }
                )
                .SelectMany(a => a)
                .DebugValues(a => Debug.Write(string.Concat('[', a, ']')))
                .Where(c => c != '~')
                .JoinToInt();
            }

        }
    }
