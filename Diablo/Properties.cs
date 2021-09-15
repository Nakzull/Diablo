using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class Properties
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public Properties()
        {
        }
        public Properties(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public List<PrimaryProp> AddPrimaryProp(Random rng, List<PrimaryProp> primaryProps, List<PrimaryProp> primaryPropsForThisWeapon, int amountOfProps)
        {
            switch (amountOfProps)
            {
                case 1:
                    {
                        primaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 8);
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice]);
                        return primaryPropsForThisWeapon;
                    }
                case 2:
                    {
                        primaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 8);
                        int primaryPropChoice2 = rng.Next(0, 8);
                        bool checkNumber = true;
                        while (checkNumber == true)
                        {
                            if (primaryPropChoice2 == primaryPropChoice)
                            {
                                primaryPropChoice2 = rng.Next(0, 8);
                            }
                            else
                                checkNumber = false;
                        }
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice]);
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice2]);
                        return primaryPropsForThisWeapon;
                    }
                case 3:
                    {
                        primaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 8);
                        int primaryPropChoice2 = rng.Next(0, 8);
                        int primaryPropChoice3 = rng.Next(0, 8);
                        bool checkNumber = true;
                        while (checkNumber == true)
                        {
                            if (primaryPropChoice2 == primaryPropChoice)
                            {
                                primaryPropChoice2 = rng.Next(0, 8);
                            }
                            else if (primaryPropChoice3 == primaryPropChoice2)
                            {
                                primaryPropChoice3 = rng.Next(0, 8);
                            }
                            else
                                checkNumber = false;
                        }
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice]);
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice2]);
                        primaryPropsForThisWeapon.Add(primaryProps[primaryPropChoice3]);
                        return primaryPropsForThisWeapon;
                    }
                default:
                    return null;
            }
        }
        public List<SecondaryProp> AddSecondaryProp(Random rng, List<SecondaryProp> secondaryProps, List<SecondaryProp> secondaryPropsForThisWeapon, int amountOfProps)
        {
            switch (amountOfProps)
            {
                case 1:
                    {
                        secondaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 5);
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice]);
                        return secondaryPropsForThisWeapon;
                    }
                case 2:
                    {
                        secondaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 5);
                        int primaryPropChoice2 = rng.Next(0, 5);
                        bool checkNumber = true;
                        while (checkNumber == true)
                        {
                            if (primaryPropChoice2 == primaryPropChoice)
                            {
                                primaryPropChoice2 = rng.Next(0, 5);
                            }
                            else
                                checkNumber = false;
                        }
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice]);
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice2]);
                        return secondaryPropsForThisWeapon;
                    }
                case 3:
                    {
                        secondaryPropsForThisWeapon.Clear();
                        int primaryPropChoice = rng.Next(0, 5);
                        int primaryPropChoice2 = rng.Next(0, 5);
                        int primaryPropChoice3 = rng.Next(0, 5);
                        bool checkNumber = true;
                        while (checkNumber == true)
                        {
                            if (primaryPropChoice2 == primaryPropChoice)
                            {
                                primaryPropChoice2 = rng.Next(0, 5);
                            }
                            else if (primaryPropChoice3 == primaryPropChoice2)
                            {
                                primaryPropChoice3 = rng.Next(0, 5);
                            }
                            else
                                checkNumber = false;
                        }
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice]);
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice2]);
                        secondaryPropsForThisWeapon.Add(secondaryProps[primaryPropChoice3]);
                        return secondaryPropsForThisWeapon;
                    }
                default:
                    return null;
            }
        }
    }
}
