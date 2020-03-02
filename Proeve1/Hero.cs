using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeve1
{
    class Hero
    {
        private string name;
        private int defaultHitpoint, hitpoint, minAttackRange, maxAttackRange, minDefenceRange, maxDefenceRange;
        Random rnd = new Random();

        public string Name { get { return this.name; } }
        public int Hitpoint { get { return this.hitpoint; } set { this.hitpoint = value; } }

        //this makes a hero thats have Random Stats
        public Hero(string name)
        {
            this.name = name;
            this.defaultHitpoint = rnd.Next(7, 13 + 1) * 10;
            this.hitpoint = this.defaultHitpoint;
            this.minAttackRange = rnd.Next(2, 10 + 1);
            this.maxAttackRange = rnd.Next(this.minAttackRange, 10 + 1);
            this.minDefenceRange = rnd.Next(2, 10 + 1);
            this.maxDefenceRange = rnd.Next(this.minDefenceRange, 10 + 1);
        }

        public Hero(string name, int defaultHitpoint, int attack, int defence) : this(name)
        {
            this.defaultHitpoint = defaultHitpoint;
            this.hitpoint = this.defaultHitpoint;
            this.minAttackRange = attack;
            this.maxAttackRange = attack;
            this.minDefenceRange = defence;
            this.maxDefenceRange = defence;
        }

        public Hero(string name, int defaultHitpoint, int minAttackRange, int maxAttackRange, int minDefenceRange, int maxDefenceRange) : this(name, defaultHitpoint, maxAttackRange, maxDefenceRange)
        {
            this.minAttackRange = minAttackRange;
            this.minDefenceRange = minDefenceRange;
        }

        public void Attack(Hero hero)
        {
            hero.Defence(this.GetAttack());
        }
    
        public void Defence(int attack)
        {
            int de = this.GetDefence();
            int attackDefence = de - attack;
            if (attackDefence >= 0)
            {
                attackDefence = 0;
            }
            this.hitpoint += attackDefence;
        }
        
        //You Get here's Attack Damage.
        public int GetAttack()
        {
            return rnd.Next(this.minAttackRange, this.maxAttackRange + 1);
        }

        //you get hero's Defence.
        public int GetDefence()
        {
            return rnd.Next(this.minDefenceRange, this.maxDefenceRange + 1);
        }

        //Resets Heros Hitpoints.
        public void ResetHitpoints()
        {
            this.hitpoint = this.defaultHitpoint;
        }
    }
}
