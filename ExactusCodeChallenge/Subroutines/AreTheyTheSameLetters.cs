using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactusCodeChallenge.Subroutines
{
    public class AreTheyTheSameLetters
    {
        public AreTheyTheSameLetters() { }

        public int calculateSimilarity( string letter1, string letter2 ) 
        {
            int n = letter1.Length;
            int m = letter2.Length;
            int[,] d = new int[n + 1, m + 1];
            int maxLength = 0;

            if(letter1 == letter2)
            {
                return 100;
            }

            if(letter1.Length == letter2.Length)
            {
                maxLength = letter1.Length;

            }
            else if (letter1.Length > letter2.Length)
            {
                maxLength = letter1.Length;

            }
            else if(letter1.Length < letter2.Length)
            {
                maxLength = letter2.Length;

            }

            for (int i = 1; i <= letter1.Length; i++)
            {
                for (int j = 1; j <= letter2.Length; j++)
                {
 
                    int cost = (letter2[j - 1] == letter1[i - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }

            double sim = Math.Round((double)((maxLength - d[n, m]) / (double)maxLength) * 100);

            return (int)sim;
        }
    }
}
