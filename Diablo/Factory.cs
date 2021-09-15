using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Factory
    {
        Properties properties = new Properties();
        List<PrimaryProp> primaryProps = new List<PrimaryProp>();
        List<SecondaryProp> secondaryProps = new List<SecondaryProp>();
        Random rng = new Random();
        List<PrimaryProp> primaryPropsForThisWeapon = new List<PrimaryProp>();
        List<SecondaryProp> secondaryPropsForThisWeapon = new List<SecondaryProp>();
        List<Legendary> legendaryWeapons = new List<Legendary>();
        List<Set> setWeapons = new List<Set>();
        List<Weapon> weapons = new List<Weapon>();
        string currentWeapon;

        public int GetWeaponRarity()
        {
            if (currentWeapon == "Legendary")
            {
                return 1;
            }
            else if (currentWeapon == "Set")
            {
                return 2;
            }   
            else
            {
                return 3;
            }
        }
        public void GetSetEffect(int index)
        {
            Console.WriteLine(setWeapons[index].SetBonus);
        }
        public void GetLegendaryEffect(int index)
        {
            Console.WriteLine(legendaryWeapons[index].SecondaryEffect);
        }
        public void GetPrimaryPropsFromWeapon()
        {
            foreach (var items in primaryPropsForThisWeapon)
                Console.WriteLine(items.Name + items.Value);
        }
        public void GetSecondaryPropsFromWeapon()
        {
            foreach (var items in secondaryPropsForThisWeapon)
                Console.WriteLine(items.Name + items.Value);
        }
        public void AddPrimaryProp()
        {
            primaryProps.Add(new PrimaryProp("Main stat ", 300));
            primaryProps.Add(new PrimaryProp("Attack speed ", 5));
            primaryProps.Add(new PrimaryProp("Damage % ", 5));
            primaryProps.Add(new PrimaryProp("Elemental damage ", 250));
            primaryProps.Add(new PrimaryProp("Socket ", 1));
            primaryProps.Add(new PrimaryProp("Increased damage to elites ", 8));
            primaryProps.Add(new PrimaryProp("Vitality ", 300));
            primaryProps.Add(new PrimaryProp("Cooldown reduction ", 7));
        }
        public void AddSecondaryProp()
        {
            secondaryProps.Add(new SecondaryProp("Life after each kill ", 50));
            secondaryProps.Add(new SecondaryProp("Experience on kill ", 10));
            secondaryProps.Add(new SecondaryProp("Gold find ", 20));
            secondaryProps.Add(new SecondaryProp("Life after each kill ", 50));
            secondaryProps.Add(new SecondaryProp("Reduced level requirement ", 25));
        }
        public Weapon CreateWeapon(int index)
        {
            int weaponChoice = rng.Next(1, 21);
            switch (weaponChoice)
            {
                case 1:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 0);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Toporok", "Normal", "Axe", 101.4, 55, 101, 1.3, 48, 0, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 2:
                    currentWeapon = "Legendary";
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    legendaryWeapons.Add(new Legendary("Mordullu's Promise", "Legendary", "Axe", 461.5, 249, 461, 1.3, 70, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "Firebomb generates 120 mana. (Witch doctor only)"));
                    return legendaryWeapons[index];
                case 3:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 3);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 3);
                    weapons.Add(new Weapon("Punyal", "Rare", "Dagger", 321, 107, 321, 1.5, 70, 6, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 4:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 1);
                    legendaryWeapons.Add(new Legendary("Wizardspike", "Legendary", "Dagger", 202.5, 67, 203, 1.5, 60, 3, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "Performing an attack has a 25% chance to hurl a Frozen Orb. Arcane Orb deals 329% increased damage. (Wizard Only)"));
                    return legendaryWeapons[index];
                case 5:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 1);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Wirt's Original Leg", "Magic", "Mace", 5.4, 3, 6, 1.2, 20, 1, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 6:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 3);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 3);
                    weapons.Add(new Weapon("Skullsplitter", "Rare", "Mace", 540.6, 316, 585, 1.2, 70, 6, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 7:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 0);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Qiang", "Normal", "Spear", 230.4, 155, 229, 1.2, 60, 0, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 8:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 1);
                    legendaryWeapons.Add(new Legendary("Empyrean Messanger", "Legendary", "Spear", 311.4, 209, 310, 1.2, 60, 3, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, ""));
                    return legendaryWeapons[index];
                case 9:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    setWeapons.Add(new Set("Little Rogue", "Set", "Sword", 392, 168, 392, 1.4, 70, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, @"(2) Set" + "\n" +
                        @": Every time you spend primary resource, gain 6 % increased Attack Speed, Damage, and Armor for 5 seconds.This effect stacks up to 5 times."));
                    return setWeapons[index];
                case 10:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    setWeapons.Add(new Set("The Slanderer", "Set", "Sword", 392, 168, 392, 1.4, 70, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, @"(2) Set" + "\n" +
                        @": Every time you spend primary resource, gain 6 % increased Attack Speed, Damage, and Armor for 5 seconds.This effect stacks up to 5 times."));
                    return setWeapons[index];
                case 11:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 3);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    weapons.Add(new Weapon("Obsidian Edge", "Rare", "Ceremonial Knife", 137.2, 39, 157, 1.4, 55, 5, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 12:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 1);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 1);
                    legendaryWeapons.Add(new Legendary("The Gidbinn", "Legendary", "Ceremonial Knife", 251.3, 71, 288, 1.4, 60, 2, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "Chance to summon a Fetish when attacking. (Witch Doctor Only)"));
                    return legendaryWeapons[index];
                case 13:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 0);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Hand of Despair", "Normal", "Fist Weapon", 20.3, 9, 20, 1.4, 1, 0, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 14:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    legendaryWeapons.Add(new Legendary("Scarbringer", "Legendary", "Fist Weapon", 36.4, 16, 36, 1.4, 30, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "The damage of Lashing Tail Kick is increased by 546% to the first 7 enemies hit. (Monk Only)"));
                    return legendaryWeapons[index];
                case 15:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 0);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Knout", "Normal", "Flail", 139.3, 70, 129, 1.4, 57, 0, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 16:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 1);
                    legendaryWeapons.Add(new Legendary("Swiftmount", "Legendary", "Flail", 43.4, 22, 40, 1.4, 34, 3, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "Doubles the duration of Steed Charge. (Crusader Only)"));
                    return legendaryWeapons[index];
                case 17:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    setWeapons.Add(new Set("Bul-Kathos's Warrior Blood", "Set", "Mighty Weapon", 277.5, 150, 277, 1.3, 60, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "(2) Set:" + "\nIncreases Fury Generation by 15 (Barbarian Only)\nDuring Whirlwind you gain 45% increased attack speed and movement speed."));
                    return setWeapons[index];
                case 18:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 2);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 2);
                    setWeapons.Add(new Set("Bul-Kathos's Solemn Wov", "Set", "Mighty Weapon", 277.5, 150, 277, 1.3, 60, 4, primaryPropsForThisWeapon, secondaryPropsForThisWeapon, "(2) Set:" + "\nIncreases Fury Generation by 15 (Barbarian Only)\nDuring Whirlwind you gain 45% increased attack speed and movement speed."));
                    return setWeapons[index];
                case 19:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 0);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 0);
                    weapons.Add(new Weapon("Sacrificial Scythe", "Normal", "Scythe", 371.8, 201, 371, 1.3, 61, 0, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                case 20:
                    properties.AddPrimaryProp(rng, primaryProps, primaryPropsForThisWeapon, 3);
                    properties.AddSecondaryProp(rng, secondaryProps, secondaryPropsForThisWeapon, 3);
                    weapons.Add(new Weapon("Bone Scythe", "Rare", "Scythe", 461.5, 249, 461, 1.3, 70, 6, primaryPropsForThisWeapon, secondaryPropsForThisWeapon));
                    return weapons[index];
                default:
                    return null;
            }

        }

    }
}
