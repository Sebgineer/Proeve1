using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeve1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HeroList
            List<Hero> heroes = new List<Hero>
            {
                new Hero("Minimusen Mikkel", 40, 9, 9),
                new Hero("Super Hunden Dino", 70, 6, 8, 2, 8),
                new Hero("Elgen Egon", 90, 5, 11, 4, 4),
                new Hero("Hurtig Karl", 90, 2, 5, 3, 3),
                new Hero("Gummigeden Ivan", 70, 6, 8),
                new Hero("Katten Tiger", 60, 3, 6, 4, 4),
                new Hero("Gift Gunner", 90, 1, 13, 5, 5),
                new Hero("Kong Fu Harry", 120, 2, 5)
            };
            #endregion



            //Champion is Work in Progress.
            Champion champion = new Champion(heroes);

            Battle battle1 = new Battle(heroes[0], heroes[1]);
            Battle battle2 = new Battle(heroes[2], heroes[3]);
            Battle battle3 = new Battle(heroes[4], heroes[5]);
            Battle battle4 = new Battle(heroes[6], heroes[7]);

            Battle battle5 = new Battle(battle1.StartBattle(), battle2.StartBattle());
            Battle battle6 = new Battle(battle3.StartBattle(), battle4.StartBattle());

            Battle battle7 = new Battle(battle5.StartBattle(), battle6.StartBattle());

            Console.WriteLine("Vinderen er: {0}", battle7.StartBattle().Name);
            Console.ReadKey();
        }
    }
}
