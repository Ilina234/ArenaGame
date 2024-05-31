using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace ArenaGame
{
    public class Witch : Hero
    {
        private const int PoisonEachNtnRound = 4;

        private int spellCount;

        public Witch(string name) : base(name)
        {
            spellCount = 0;
        }
        public Witch(string name, Weapon weapon) : base(name, weapon)
        {
            spellCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if(spellCount == PoisonEachNtnRound)
            {
                attack += 20;
            }
            
            spellCount++;
            return attack;
        }
    }
}
