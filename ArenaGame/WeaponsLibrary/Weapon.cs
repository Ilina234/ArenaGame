using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int Damage { get; protected set; }
        public int AttacksCounter { get; set; }
        public int SpecialTraitAtivateRound { get; protected set; }
        public int SpecialTraitDamage { get; protected set; }

        public Weapon(string name)
        {
            Name = name;
            Damage = 0;
            AttacksCounter = 0;
            SpecialTraitAtivateRound = 0;
            SpecialTraitDamage = 0;
        }

    }
}
