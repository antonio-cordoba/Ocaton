using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
