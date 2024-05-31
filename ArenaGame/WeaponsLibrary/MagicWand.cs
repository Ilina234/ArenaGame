using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace Weapons
{
    public class MagicWand : Weapon
    {
        public MagicWand(string name) : base(name)
        {
            Damage = 25;
            SpecialTraitAtivateRound = 3;
            SpecialTraitDamage = 49;
        }
    }
}
