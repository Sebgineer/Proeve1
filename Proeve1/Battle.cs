using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proeve1
{
    class Battle
    {
        private Hero hero1, hero2;

        public Battle(Hero hero1, Hero hero2)
        {
            this.hero1 = hero1;
            this.hero2 = hero2;
        }

        public Hero StartBattle()
        {
            hero1.ResetHitpoints();
            hero2.ResetHitpoints();
            while (true)
            {
                if (hero1.Hitpoint > 0)
                {
                    Console.WriteLine($"{hero1.Name} {hero1.Hitpoint}HP | {hero2.Name} {hero2.Hitpoint}HP");
                    Console.WriteLine($"{hero1.Name}: attacks");
                    hero1.Attack(hero2);
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    return hero2;
                }


                if (hero2.Hitpoint > 0)
                {
                    Console.WriteLine($"{hero1.Name} {hero1.Hitpoint}HP | {hero2.Name} {hero2.Hitpoint}HP");
                    Console.WriteLine($"{hero2.Name}: attacks");
                    hero2.Attack(hero1);
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    return hero1;
                }


            }
        }
    }
}
