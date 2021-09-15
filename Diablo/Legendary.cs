using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Legendary : Weapon
    {
        public Legendary(string name, string rarity, string type, double dps, double minDmg, double maxDmg, double attackSpeed, int levelRequirement, int numberProperties, List<PrimaryProp> primaryProps, List<SecondaryProp> secondaryProps, string secondaryEffect) : base(name, rarity, type, dps, minDmg, maxDmg, attackSpeed, levelRequirement, numberProperties, primaryProps, secondaryProps)
        {
            SecondaryEffect = secondaryEffect;
        }
        public string SecondaryEffect { get; private set; }
        public Legendary()
        {

        }

    }
}
