using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;
using WarriorWars.Utils;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 50;
        private const int BAD_GUY_STARTING_HEALTH = 50;
        private readonly Faction FACTION;

        private int health; 
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

        }
        private bool isAlive;
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }

        }

        private Weapon mainWeapon;
        public Weapon MainWeapon
        {
            get
            {
                return mainWeapon;
            }

        }
        private Armor armor;

        public Warrior(string name, Faction faction, WeaponTypes weaponType)
        {
            // Attributes
            this.name = name;
            FACTION = faction;
            isAlive = true;
            // Equipment
            mainWeapon = new Weapon(faction, weaponType);
            armor = new Armor(faction);

            switch(faction)
            {
                case Faction.GOOD_GUY:
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BAD_GUY:
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;

            }


        }

        public void Attack(Warrior enemy)
        {
            // Calculate de damage
            int damage = mainWeapon.Damage - enemy.armor.Endurance;

            enemy.health -= damage;

            // Show the result
            AttackResult(enemy, damage);

        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if(enemy.health <= 0)
            {
                enemy.isAlive = false;
                Utilities.ColorfulConsoleText($"{enemy.name} is dead!", ConsoleColor.Red);
                Utilities.ColorfulConsoleText($"{name} is victorious!", ConsoleColor.DarkGreen);

            } else
            {
                System.Console.WriteLine($"{name} attacked! {damage} damage point was inflicted. {enemy.Name} remaining health is: {enemy.health}.");
            }

        }

    }

}