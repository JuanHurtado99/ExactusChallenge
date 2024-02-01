using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactusCodeChallenge.Subroutines
{
        public class RandomGift
    {
        private List<int> _gifts;
        public RandomGift() 
        {
            _gifts = new List<int>();
        }

        public int generateGift()
        {
            int seed = unchecked(DateTime.Now.Ticks.GetHashCode());
            seed = seed - unchecked(DateTime.Now.Ticks.GetHashCode());
            seed = seed * unchecked(DateTime.Now.Ticks.GetHashCode());
            seed = seed - unchecked(DateTime.Now.Ticks.GetHashCode());
            seed = seed + unchecked(DateTime.Now.Ticks.GetHashCode());


            if(seed % 2 == 0) 
            {
                seed = seed - 52;
                seed = seed * 2;
                seed = seed / 5;
            }
            else
            {
                seed = seed / 8;
                seed = seed + 24;
                seed = seed * 3;
            }
            _gifts.Add(seed);
            return seed;
        }

        public List<int> getGifts()
        {
            return _gifts;
        }

        public bool areGiftsUnique()
        {   
            return _gifts.Distinct().Count() == _gifts.Count();
        }

        public void clearGifts()
        {
            _gifts.Clear();
        }
    }
}
