using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace ArenaGame
{
    public class Gladiator : Hero
    {
        protected int Fame { get; private set; }

        public Gladiator(string name) : base(name)
        { 
        
        }

        public Gladiator(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override int Attack()
        {
            int attack;
            if(Fame == 100)
            {
                attack = 500;
            }
            else
            {
                attack = base.Attack();
            }

            return attack;
        }
    }
}
