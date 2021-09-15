using System;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.AddPrimaryProp();
            factory.AddSecondaryProp();
            int nonLegendarySetCount = 0;
            int legendaryCount = 0;
            int setCount = 0;
            for (; ; )
            {
                Console.WriteLine("Press any key to generate a weapon");
                Console.ReadKey();
                Console.WriteLine(factory.CreateWeapon(nonLegendarySetCount).GetWeaponStats());
                factory.GetPrimaryPropsFromWeapon();
                factory.GetSecondaryPropsFromWeapon();
                if (factory.GetWeaponRarity() == 1)
                {
                    factory.GetLegendaryEffect(legendaryCount);
                    Console.WriteLine(factory.CreateWeapon(legendaryCount).GetWeaponStats());
                    legendaryCount++;
                }
                else if (factory.GetWeaponRarity() == 2)
                {
                    factory.GetSetEffect(setCount);
                    Console.WriteLine(factory.CreateWeapon(setCount).GetWeaponStats());
                    setCount++;
                }
                else if (factory.GetWeaponRarity() == 3)
                {
                    Console.WriteLine(factory.CreateWeapon(nonLegendarySetCount).GetWeaponStats());
                    nonLegendarySetCount++;
                }
                
            }
        }
    }
}
