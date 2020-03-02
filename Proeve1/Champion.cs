using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeve1
{
    class Champion
    {
        //Work In progress
        List<Hero> fighters;
        List<Battle> battles;
        


        public Champion(List<Hero> fighters)
        {
            this.fighters = fighters;
            this.kage();
        }

        public void kage()
        {
            int noget = fighters.Count;
            List<int> ja = new List<int>();
            while (noget > 0)
            {
                noget /= 2;
                if (noget != 0)
                {
                    ja.Add(noget);
                }
            }

        }
    }
}
