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

            if(letter1.Length != letter2.Length)
            {
                _ = letter1.Length > letter2.Length ? letter2 = letter2.PadRight(letter1.Length) : letter1 = letter1.PadRight(letter2.Length);
            }
            var letterArray1 = letter1.ToCharArray();
            var letterArray2 = letter2.ToCharArray();
            var sim = 0;
            var dif = 0;
            for (int i = 0; i < letterArray1.Length; i++)
            {
                if (letterArray1[i] == letterArray2[i])
                {
                    sim++;
                }
            }
            return ((sim + dif) *100)/ letterArray1.Length;
        }
    }
}
