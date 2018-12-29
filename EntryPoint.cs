using System;
using System.Collections.Generic;
using System.Threading;
using WarriorWars.Enum;
using WarriorWars.Utils;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random range = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("SnowDog", Faction.GOOD_GUY, WeaponTypes.SWORD);
            Warrior badGuy = new Warrior("ByTor", Faction.BAD_GUY, WeaponTypes.AXE);

            System.Console.WriteLine("Warriors:\n");

            List<Warrior> warriors = new List<Warrior>();
            warriors.Add(goodGuy);
            warriors.Add(badGuy);

            foreach(Warrior warrior in warriors)
            {
                Utilities.ColorfulConsoleText(warrior.Name + " - Weapon: " + warrior.MainWeapon.WeaponType, ConsoleColor.DarkMagenta);

            }

            // Main Game Loop
            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                // Attack turn
                if(range.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                } else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(100);

            }

        }
    }
}
