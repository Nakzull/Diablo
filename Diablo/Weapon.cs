using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Weapon
    {
        public string Name { get; private set; }
        public string Rarity { get; private set; }
        public string Type { get; private set; }
        public double MinDmg { get; private set; }
        public double MaxDmg { get; private set; }
        public double AttackSpeed { get; private set; }
        public int LevelRequirement { get; private set; }
        public double Dps { get; private set; }
        public int NumberProperties { get; private set; }
        public List<PrimaryProp> PrimaryProps { get; private set; }
        public List<SecondaryProp> SecondaryProps { get; private set; }

        public Weapon()
        {

        }
        public Weapon(string name, string rarity, string type, double dps, double minDmg, double maxDmg, double attackSpeed, int levelRequirement, int numberProperties, List<PrimaryProp> primaryProps, List<SecondaryProp> secondaryProps)
        {
            Name = name;
            Rarity = rarity;
            Type = type;
            Dps = dps;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            AttackSpeed = attackSpeed;
            LevelRequirement = levelRequirement;
            NumberProperties = numberProperties;
            PrimaryProps = primaryProps;
            SecondaryProps = secondaryProps;
        }
        public string GetWeaponStats()
        {
            
            return Name + $"                                                      {LevelRequirement}\n" + Rarity + " " + Type + "\n" + Dps + "\nDamage per second\n" + MinDmg + " - " + MaxDmg + " Damage\n" + AttackSpeed + " Attacks per Second\n";
        }
        public List<PrimaryProp> GetPrimaryProps()
        {
            return PrimaryProps;
        }        
    }
}
