using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactusCodeChallenge.Subroutines
{
    class RubickCubeBuilder
    {
        public RubickCubeBuilder() { }

        public int StickerCalculator(int side)
        {
            return (side * side) * 6;
        }
    }
}
