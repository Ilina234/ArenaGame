using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace Weapons
{
    public class TwoSwords : Weapon
    {
        public TwoSwords(string name) : base(name)
        {
            Damage = 30;
            SpecialTraitAtivateRound = 4;
            SpecialTraitDamage = 68;
        }
    }
}
