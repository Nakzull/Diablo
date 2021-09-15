using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Set : Weapon
    {
        public Set(string name, string rarity, string type, double dps, double minDmg, double maxDmg, double attackSpeed, int levelRequirement, int numberProperties, List<PrimaryProp> primaryProps, List<SecondaryProp> secondaryProps, string setBonus) : base(name, rarity, type, dps, minDmg, maxDmg, attackSpeed, levelRequirement, numberProperties, primaryProps, secondaryProps)
        {
            SetBonus = setBonus;
        }
        public string SetBonus { get; private set; }
    }
}
