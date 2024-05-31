using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name) : base(name)
        {
            Damage = 20;
            SpecialTraitAtivateRound = 4;
            SpecialTraitDamage = 53;
        }
    }
}
